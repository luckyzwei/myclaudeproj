using System;
using System.Collections.Generic;
using Balancy.Models.Gameplay.Missions;
using Balancy.Models.SmartObjects;
using KWCore.Utils;

public class MissionsManager : Singleton<MissionsManager>
{
	public enum MissionsStatus
	{
		MISSION_IN_PROGRESS = 0,
		REWARD_AVAILABLE = 1,
		WAITING_FOR_NEXT_MISSIONS = 2
	}

	private int m_currentMissionIndex;

	private BaseMission m_currentMission;

	private DateTime m_missionsDeadline;

	private List<int> m_availableMissions;

	private bool m_forceGeneration;

	private BaseMission CurrentMission => m_currentMission;

	private void TryToUnlock()
	{
		// Missions unlock after completing enough levels
		if (!FeatureUnlockManager.IsDailyChallengeUnlocked) return;
	}

	protected override void Init()
	{
		m_availableMissions = new List<int>();

		// Try to load saved mission
		m_currentMission = LoadCurrentMission();
		m_missionsDeadline = GetMissionsDeadline();

		// Check if deadline has passed
		if (m_missionsDeadline != default && GetCurrentDateTime() > m_missionsDeadline)
		{
			m_forceGeneration = true;
		}
	}

	public bool IsUnlockedAndActive()
	{
		return IsUnlocked() && IsActive();
	}

	public bool IsUnlocked()
	{
		return FeatureUnlockManager.IsDailyChallengeUnlocked;
	}

	public bool IsActive()
	{
		return m_currentMission != null || m_forceGeneration;
	}

	private void OnMissionProgress(bool isCompleted)
	{
		SaveProgress();
		if (isCompleted)
		{
			BucketMissions.SetIsRewardCollected(false);
		}
	}

	public MissionsStatus GetMissionsStatus()
	{
		if (m_currentMission != null && m_currentMission.IsCompleted())
		{
			if (!BucketMissions.GetIsRewardCollected())
				return MissionsStatus.REWARD_AVAILABLE;
		}

		if (m_currentMission != null && !m_currentMission.IsCompleted())
			return MissionsStatus.MISSION_IN_PROGRESS;

		return MissionsStatus.WAITING_FOR_NEXT_MISSIONS;
	}

	public void GenerateNewDayMissions()
	{
		// Stop tracking old mission
		if (m_currentMission != null)
			m_currentMission.StopTracking();

		m_currentMission = null;
		m_currentMissionIndex = 0;
		m_forceGeneration = false;

		CalculateAndSaveDeadlineTime();
		GetNextMission();
	}

	private int CalculateReward(bool increment)
	{
		int rewardIndex = BucketMissions.GetRewardIndex();
		if (increment)
		{
			rewardIndex = BucketMissions.IncrementAndSetRewardIndex();
		}
		// Base reward + bonus per completed mission
		return 50 + rewardIndex * 10;
	}

	private void CalculateAndSaveDeadlineTime()
	{
		// Deadline is end of today (midnight UTC)
		DateTime now = GetCurrentDateTime();
		DateTime deadline = new DateTime(now.Year, now.Month, now.Day, 23, 59, 59, DateTimeKind.Utc);
		SetMissionsDeadline(deadline);
	}

	private DateTime GetMissionsDeadline()
	{
		long ticks = BucketMissions.GetMissionsDeadline();
		if (ticks <= 0) return default;
		return new DateTime(ticks, DateTimeKind.Utc);
	}

	private void SetMissionsDeadline(DateTime value)
	{
		m_missionsDeadline = value;
		BucketMissions.SetMissionsDeadline(value.Ticks);
	}

	private bool IsThereMissionSaved()
	{
		return !string.IsNullOrEmpty(BucketMissions.GetActiveMissionClientId());
	}

	private DateTime GetCurrentDateTime()
	{
		return DateTime.UtcNow;
	}

	public void GetNextMission()
	{
		// Stop tracking old mission
		if (m_currentMission != null)
		{
			m_currentMission.StopTracking();
			m_currentMission.ProgressEvent -= OnMissionProgress;
		}

		GetMissionFromCurrentPool();

		if (m_currentMission != null)
		{
			m_currentMission.ProgressEvent += OnMissionProgress;
			m_currentMission.StartTracking();
		}
	}

	private void GetMissionFromCurrentPool()
	{
		int poolIndex = GetCurrentPoolIndex();
		var missionData = GrabMissionFromPool(poolIndex);
		if (missionData != null)
		{
			m_currentMission = MissionFactory.CreateMissionClass(missionData);
			if (m_currentMission != null)
			{
				SaveAsCurrentMission(poolIndex, m_currentMission);
			}
		}
	}

	public BaseMission GetCurrentMission()
	{
		return m_currentMission;
	}

	public Reward GetReward()
	{
		// Rewards handled via Balancy - return null as we use CalculateReward for coin amounts
		return null;
	}

	public float GetRemainingTimeInSeconds()
	{
		if (m_missionsDeadline == default) return 0f;
		TimeSpan remaining = m_missionsDeadline - GetCurrentDateTime();
		return remaining.TotalSeconds > 0 ? (float)remaining.TotalSeconds : 0f;
	}

	private MissionData GrabMissionFromPool(int poolIndex)
	{
		// This would normally pull from Balancy data
		// For now return null - missions need Balancy integration
		return null;
	}

	private List<int> GetAvailableMissionIndexesFromPool(int poolIndex)
	{
		var taken = BucketMissions.GetMissionsTaken(poolIndex.ToString());
		var available = new List<int>();
		// Without Balancy mission pool data, return empty
		return available;
	}

	private void SaveAsCurrentMission(int poolIndex, BaseMission mission)
	{
		var missionData = mission.GetMissionData();
		if (missionData != null)
		{
			BucketMissions.SetActiveMissionClientId(missionData.ToString());
		}
		BucketMissions.SetMissionPoolIndex(poolIndex);
		BucketMissions.SetMissionProgress(mission.GetProgress());
		BucketMissions.SetMissionTargetValue(mission.TargetValue);
	}

	private BaseMission LoadCurrentMission()
	{
		string clientId = BucketMissions.GetActiveMissionClientId();
		if (string.IsNullOrEmpty(clientId)) return null;

		// Would need to reconstruct mission from saved data + Balancy
		return null;
	}

	private void SaveProgress()
	{
		if (m_currentMission != null)
		{
			BucketMissions.SetMissionProgress(m_currentMission.GetProgress());
			BucketMissions.SetMissionLastSeenProgress(m_currentMission.GetProgressNormalized());
		}
	}

	private void ResetPool(int poolIndex)
	{
		BucketMissions.SetMissionsTaken(poolIndex.ToString(), new List<string>());
	}

	public bool IsRewardAvailable()
	{
		return GetMissionsStatus() == MissionsStatus.REWARD_AVAILABLE;
	}

	public int GetCurrentPoolIndex()
	{
		return BucketMissions.GetMissionPoolIndex();
	}

	public void SwapCurrentMission()
	{
		if (m_currentMission != null)
		{
			m_currentMission.StopTracking();
			m_currentMission.ProgressEvent -= OnMissionProgress;
		}
		GetMissionFromCurrentPool();
		if (m_currentMission != null)
		{
			m_currentMission.ProgressEvent += OnMissionProgress;
			m_currentMission.StartTracking();
		}
	}

	public float GetLastSeenProgress()
	{
		return BucketMissions.GetMissionLastSeenProgress();
	}

	public void SeenAllProgress()
	{
		if (m_currentMission != null)
			BucketMissions.SetMissionLastSeenProgress(m_currentMission.GetProgressNormalized());
	}

	public void GiveReward(Action flowFinishedCallback = null, Action rewardGivenCallback = null)
	{
		int rewardAmount = CalculateReward(true);
		BucketMissions.SetIsRewardCollected(true);
		rewardGivenCallback?.Invoke();
		OnRewardGiven();
		flowFinishedCallback?.Invoke();
	}

	private void OnRewardGiven()
	{
		// Generate next mission after reward collected
		GetNextMission();
	}

	public void ResaveCurrentMission()
	{
		SaveProgress();
	}
}
