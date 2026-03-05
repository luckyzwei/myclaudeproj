using System;
using System.Collections.Generic;
using System.Numerics;
using UniRx;

public class ContentsMissionSystem
{
	public const int DAY_HOUR = 24;

	private const int REFRESH_COST = 100;

	private Dictionary<E_ContentsMissionType, ContentsMissionData> ContentMissions;

	public Subject<(E_ContentsMissionType, int)> OnMissionCompleteEvent;

	public Subject<(E_ContentsMissionType, int)> OnMissionRewardedEvent;

	public Subject<E_ContentsMissionType> OnMissionResetEvent;

	private CompositeDisposable Disposables;

	public void Reset()
	{
		if (Disposables != null)
		{
			Disposables.Dispose();
			Disposables = null;
		}
		if (ContentMissions != null)
		{
			ContentMissions.Clear();
		}
	}

	public void UpdateOneSecond()
	{
		if (ContentMissions == null)
		{
			return;
		}
		DateTime now = DateTime.UtcNow;
		foreach (var kvp in ContentMissions)
		{
			ContentsMissionData contentData = kvp.Value;
			if (now >= contentData.MissionEndTime)
			{
				continue;
			}
			if (now >= contentData.MissionNextResetTime)
			{
				contentData.ClearMissions();
				GenerateNewMissions(contentData, now);
				contentData.SetMissionSetTime(now);
				contentData.IsRefreshed = false;
				SaveContentMissionData(kvp.Key, -1);
				if (OnMissionResetEvent != null)
				{
					OnMissionResetEvent.OnNext(kvp.Key);
				}
			}
		}
	}

	public void GenerateContentsMission(E_ContentsMissionType contentType, int missionGroupIdx, int missionCount, DateTime startTime, DateTime endTime, int resetHour)
	{
		if (ContentMissions == null)
		{
			ContentMissions = new Dictionary<E_ContentsMissionType, ContentsMissionData>();
		}
		if (Disposables == null)
		{
			Disposables = new CompositeDisposable();
		}
		if (OnMissionCompleteEvent == null)
		{
			OnMissionCompleteEvent = new Subject<(E_ContentsMissionType, int)>();
		}
		if (OnMissionRewardedEvent == null)
		{
			OnMissionRewardedEvent = new Subject<(E_ContentsMissionType, int)>();
		}
		if (OnMissionResetEvent == null)
		{
			OnMissionResetEvent = new Subject<E_ContentsMissionType>();
		}

		int resetCost = GetMissionResetCost(contentType);
		ContentsMissionData contentData = new ContentsMissionData(contentType, missionGroupIdx, missionCount, startTime, endTime, resetHour, resetCost);

		if (ContentMissions.ContainsKey(contentType))
		{
			ContentMissions[contentType] = contentData;
		}
		else
		{
			ContentMissions.Add(contentType, contentData);
		}

		// Check if there is saved user data
		var userData = GameRoot.Instance.UserData;
		if (userData != null && userData.ContentsMissionDataMap != null && userData.ContentsMissionDataMap.ContainsKey(contentType))
		{
			ContentsMissionUserData savedData = userData.ContentsMissionDataMap[contentType];
			if (savedData.Missions != null && savedData.Missions.Count > 0)
			{
				contentData.SetMissionSetTime(savedData.MissionSetTime);
				contentData.IsRefreshed = savedData.IsRefreshed;
				for (int i = 0; i < savedData.Missions.Count; i++)
				{
					SingleMissionUserData missionUserData = savedData.Missions[i];
					SingleMissionBase mission = ParseMissionData(contentType, missionGroupIdx, missionUserData);
					if (mission != null)
					{
						contentData.PutNewMission(missionUserData.SlotIdx, mission);
					}
				}
				return;
			}
		}

		GenerateNewMissions(contentData, DateTime.UtcNow);
	}

	public void RemoveContentsMission(E_ContentsMissionType contentType)
	{
		if (ContentMissions == null)
		{
			return;
		}
		if (ContentMissions.ContainsKey(contentType))
		{
			ContentsMissionData contentData = ContentMissions[contentType];
			contentData.ClearMissions();
			ContentMissions.Remove(contentType);
		}
	}

	private void GenerateNewMissions(ContentsMissionData contentData, DateTime setTime)
	{
		contentData.ClearMissions();
		contentData.SetMissionSetTime(setTime);
		HashSet<int> excludeMissions = new HashSet<int>();

		for (int slotId = 0; slotId < contentData.MissionCount; slotId++)
		{
			SingleMissionBase mission = GenerateNewMission(contentData.ContentType, contentData.MissionGroupIdx, slotId, excludeMissions);
			if (mission != null)
			{
				contentData.PutNewMission(slotId, mission);
				excludeMissions.Add(mission.MissionIdx);
				NewMissionGeneratedLog(mission);
			}
		}

		contentData.OnMissionComplete = new Subject<(E_ContentsMissionType, int)>();
		contentData.OnMissionRewarded = new Subject<(E_ContentsMissionType, int)>();
		contentData.OnMissionValueChanged = new Subject<(E_ContentsMissionType, int)>();
		contentData.OnMissionActivate = new Subject<(E_ContentsMissionType, int)>();

		contentData.OnMissionComplete.Subscribe(OnMissionComplete).AddTo(Disposables);
		contentData.OnMissionRewarded.Subscribe(OnMissionRewarded).AddTo(Disposables);
		contentData.OnMissionValueChanged.Subscribe(OnMissionValueChanged).AddTo(Disposables);
		contentData.OnMissionActivate.Subscribe(OnMissionActivate).AddTo(Disposables);

		SaveContentMissionData(contentData.ContentType, -1);
	}

	private SingleMissionBase ParseMissionData(E_ContentsMissionType contentType, int missionGroupIdx, SingleMissionUserData missionData)
	{
		if (missionData == null)
		{
			return null;
		}
		SingleMissionInitParams initParams = MakeMissionInitParams(
			contentType,
			missionData.SlotIdx,
			missionData.MissionIdx,
			missionGroupIdx,
			missionData.CurrentValue,
			missionData.IsCompleted,
			missionData.IsRewarded
		);
		SingleMissionBase mission = ContentsMissionFactory.CreateMission(initParams);
		if (mission != null)
		{
			mission.Subscribe();
		}
		return mission;
	}

	private SingleMissionBase GenerateNewMission(E_ContentsMissionType contentType, int missionGroupIdx, int slotId, HashSet<int> excludeMissions)
	{
		List<int> availableMissions = GetAvailableMissionList(contentType, missionGroupIdx);
		if (availableMissions == null || availableMissions.Count == 0)
		{
			return null;
		}

		// Remove excluded missions
		if (excludeMissions != null && excludeMissions.Count > 0)
		{
			List<int> filtered = new List<int>();
			for (int i = 0; i < availableMissions.Count; i++)
			{
				if (!excludeMissions.Contains(availableMissions[i]))
				{
					filtered.Add(availableMissions[i]);
				}
			}
			availableMissions = filtered;
		}

		if (availableMissions.Count == 0)
		{
			return null;
		}

		int missionIdx = SelectRandomMissionIdx(availableMissions);
		SingleMissionInitParams initParams = MakeMissionInitParams(contentType, slotId, missionIdx, missionGroupIdx, BigInteger.Zero, false, false);
		SingleMissionBase mission = ContentsMissionFactory.CreateMission(initParams);
		if (mission != null)
		{
			mission.Subscribe();
		}
		return mission;
	}

	private List<int> GetAvailableMissionList(E_ContentsMissionType contentType, int missionGroupIdx)
	{
		List<int> availableList = new List<int>();
		// Query mission indices from data table for the given content type and group
		// This would typically iterate the mission info table entries matching missionGroupIdx
		return availableList;
	}

	private int SelectRandomMissionIdx(List<int> availableMissions)
	{
		if (availableMissions == null || availableMissions.Count == 0)
		{
			return 0;
		}
		int randomIndex = UnityEngine.Random.Range(0, availableMissions.Count);
		return availableMissions[randomIndex];
	}

	private int GetMissionResetCost(E_ContentsMissionType contentType)
	{
		return REFRESH_COST;
	}

	private SingleMissionInitParams MakeMissionInitParams(E_ContentsMissionType contentType, int slotId, int missionIdx, int missionGroupIdx, BigInteger currentValue, bool isCompleted, bool isRewarded)
	{
		SingleMissionInitParams initParams = new SingleMissionInitParams();
		initParams.ContentType = contentType;
		initParams.SlotId = slotId;
		initParams.MissionIdx = missionIdx;
		initParams.CurrentValue = currentValue;
		initParams.IsCompleted = isCompleted;
		initParams.IsRewarded = isRewarded;
		return initParams;
	}

	public SingleMissionBase TryRefreshMission(E_ContentsMissionType contentsType, int slotId)
	{
		ContentsMissionData contentData = GetContentMissionData(contentsType);
		if (contentData == null)
		{
			return null;
		}

		SingleMissionBase oldMission;
		if (!contentData.TryGetMission(slotId, out oldMission))
		{
			return null;
		}

		// Collect existing mission indices to exclude
		HashSet<int> excludeMissions = new HashSet<int>();
		List<SingleMissionBase> allMissions = contentData.GetAllMissions();
		if (allMissions != null)
		{
			for (int i = 0; i < allMissions.Count; i++)
			{
				if (allMissions[i] != null)
				{
					excludeMissions.Add(allMissions[i].MissionIdx);
				}
			}
		}

		SingleMissionBase newMission = GenerateNewMission(contentsType, contentData.MissionGroupIdx, slotId, excludeMissions);
		if (newMission == null)
		{
			return null;
		}

		contentData.PutNewMission(slotId, newMission);
		SaveContentMissionData(contentsType, slotId);
		NewMissionGeneratedLog(newMission);
		return newMission;
	}

	public IRewardItemData TryClaimMission(E_ContentsMissionType contentType, int slotId)
	{
		ContentsMissionData contentData = GetContentMissionData(contentType);
		if (contentData == null)
		{
			return null;
		}

		SingleMissionBase mission;
		if (!contentData.TryGetMission(slotId, out mission))
		{
			return null;
		}

		if (mission.IsCompleted == null || !mission.IsCompleted.Value)
		{
			return null;
		}

		if (mission.IsRewarded != null && mission.IsRewarded.Value)
		{
			return null;
		}

		mission.IsRewarded.Value = true;
		SaveContentMissionData(contentType, slotId);
		return mission.RewardItem;
	}

	public ContentsMissionData GetContentMissionData(E_ContentsMissionType contentType)
	{
		if (ContentMissions == null)
		{
			return null;
		}
		ContentsMissionData data;
		if (ContentMissions.TryGetValue(contentType, out data))
		{
			return data;
		}
		return null;
	}

	public SingleMissionBase GetContentMission(E_ContentsMissionType contentType, int slotId)
	{
		ContentsMissionData contentData = GetContentMissionData(contentType);
		if (contentData == null)
		{
			return null;
		}
		SingleMissionBase mission;
		if (contentData.TryGetMission(slotId, out mission))
		{
			return mission;
		}
		return null;
	}

	public List<SingleMissionBase> GetContentMissions(E_ContentsMissionType contentType)
	{
		ContentsMissionData contentData = GetContentMissionData(contentType);
		if (contentData == null)
		{
			return null;
		}
		return contentData.GetAllMissions();
	}

	public void OnShownMission(E_ContentsMissionType contentType)
	{
		List<SingleMissionBase> missions = GetContentMissions(contentType);
		if (missions == null)
		{
			return;
		}
		for (int i = 0; i < missions.Count; i++)
		{
			SingleMissionBase mission = missions[i];
			if (mission != null && mission.OnMissionActivated != null)
			{
				mission.OnMissionActivated.OnNext(true);
			}
		}
	}

	private void OnMissionComplete((E_ContentsMissionType contentType, int slotId) completeInfo)
	{
		if (OnMissionCompleteEvent != null)
		{
			OnMissionCompleteEvent.OnNext(completeInfo);
		}
		SingleMissionBase mission = GetContentMission(completeInfo.contentType, completeInfo.slotId);
		if (mission != null)
		{
			MissionCompletedLog(mission);
		}
	}

	private void OnMissionRewarded((E_ContentsMissionType contentType, int slotId) rewardInfo)
	{
		if (OnMissionRewardedEvent != null)
		{
			OnMissionRewardedEvent.OnNext(rewardInfo);
		}
	}

	private void OnMissionValueChanged((E_ContentsMissionType contentType, int slotId) valueChangedInfo)
	{
		SaveContentMissionData(valueChangedInfo.contentType, valueChangedInfo.slotId);
	}

	private void OnMissionActivate((E_ContentsMissionType contentType, int slotId) activateInfo)
	{
		SingleMissionBase mission = GetContentMission(activateInfo.contentType, activateInfo.slotId);
		if (mission != null)
		{
			mission.Subscribe();
		}
	}

	private void SaveContentMissionData(E_ContentsMissionType contentType, int slotId)
	{
		var userData = GameRoot.Instance.UserData;
		if (userData == null)
		{
			return;
		}
		ContentsMissionData contentData = GetContentMissionData(contentType);
		if (contentData == null)
		{
			return;
		}
		ContentsMissionUserData saveData = new ContentsMissionUserData(contentData);
		if (userData.ContentsMissionDataMap != null)
		{
			userData.ContentsMissionDataMap[contentType] = saveData;
		}
	}

	private bool IsOpenMission(MissionSystem.E_MissionType missionType, int regionIdx)
	{
		var contentsOpenSystem = GameRoot.Instance.ContentsOpenSystem;
		if (contentsOpenSystem == null)
		{
			return false;
		}
		return true;
	}

	private void NewMissionGeneratedLog(SingleMissionBase missionData)
	{
	}

	private void MissionCompletedLog(SingleMissionBase missionData)
	{
	}
}
