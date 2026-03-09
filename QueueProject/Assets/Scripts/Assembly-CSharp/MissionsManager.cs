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

	private BaseMission CurrentMission => null;

	private void TryToUnlock()
	{
	}

	protected override void Init()
	{
	}

	public bool IsUnlockedAndActive()
	{
		return false;
	}

	public bool IsUnlocked()
	{
		return false;
	}

	public bool IsActive()
	{
		return false;
	}

	private void OnMissionProgress(bool isCompleted)
	{
	}

	public MissionsStatus GetMissionsStatus()
	{
		return default(MissionsStatus);
	}

	public void GenerateNewDayMissions()
	{
	}

	private int CalculateReward(bool increment)
	{
		return 0;
	}

	private void CalculateAndSaveDeadlineTime()
	{
	}

	private DateTime GetMissionsDeadline()
	{
		return default(DateTime);
	}

	private void SetMissionsDeadline(DateTime value)
	{
	}

	private bool IsThereMissionSaved()
	{
		return false;
	}

	private DateTime GetCurrentDateTime()
	{
		return default(DateTime);
	}

	public void GetNextMission()
	{
	}

	private void GetMissionFromCurrentPool()
	{
	}

	public BaseMission GetCurrentMission()
	{
		return null;
	}

	public Reward GetReward()
	{
		return null;
	}

	public float GetRemainingTimeInSeconds()
	{
		return 0f;
	}

	private MissionData GrabMissionFromPool(int poolIndex)
	{
		return null;
	}

	private List<int> GetAvailableMissionIndexesFromPool(int poolIndex)
	{
		return null;
	}

	private void SaveAsCurrentMission(int poolIndex, BaseMission mission)
	{
	}

	private BaseMission LoadCurrentMission()
	{
		return null;
	}

	private void SaveProgress()
	{
	}

	private void ResetPool(int poolIndex)
	{
	}

	public bool IsRewardAvailable()
	{
		return false;
	}

	public int GetCurrentPoolIndex()
	{
		return 0;
	}

	public void SwapCurrentMission()
	{
	}

	public float GetLastSeenProgress()
	{
		return 0f;
	}

	public void SeenAllProgress()
	{
	}

	public void GiveReward(Action flowFinishedCallback = null, Action rewardGivenCallback = null)
	{
	}

	private void OnRewardGiven()
	{
	}

	public void ResaveCurrentMission()
	{
	}
}
