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
	}

	public void UpdateOneSecond()
	{
	}

	public void GenerateContentsMission(E_ContentsMissionType contentType, int missionGroupIdx, int missionCount, DateTime startTime, DateTime endTime, int resetHour)
	{
	}

	public void RemoveContentsMission(E_ContentsMissionType contentType)
	{
	}

	private void GenerateNewMissions(ContentsMissionData contentData, DateTime setTime)
	{
	}

	private SingleMissionBase ParseMissionData(E_ContentsMissionType contentType, int missionGroupIdx, SingleMissionUserData missionData)
	{
		return null;
	}

	private SingleMissionBase GenerateNewMission(E_ContentsMissionType contentType, int missionGroupIdx, int slotId, HashSet<int> excludeMissions)
	{
		return null;
	}

	private List<int> GetAvailableMissionList(E_ContentsMissionType contentType, int missionGroupIdx)
	{
		return null;
	}

	private int SelectRandomMissionIdx(List<int> availableMissions)
	{
		return 0;
	}

	private int GetMissionResetCost(E_ContentsMissionType contentType)
	{
		return 0;
	}

	private SingleMissionInitParams MakeMissionInitParams(E_ContentsMissionType contentType, int slotId, int missionIdx, int missionGroupIdx, BigInteger currentValue, bool isCompleted, bool isRewarded)
	{
		return default(SingleMissionInitParams);
	}

	public SingleMissionBase TryRefreshMission(E_ContentsMissionType contentsType, int slotId)
	{
		return null;
	}

	public IRewardItemData TryClaimMission(E_ContentsMissionType contentType, int slotId)
	{
		return null;
	}

	public ContentsMissionData GetContentMissionData(E_ContentsMissionType contentType)
	{
		return null;
	}

	public SingleMissionBase GetContentMission(E_ContentsMissionType contentType, int slotId)
	{
		return null;
	}

	public List<SingleMissionBase> GetContentMissions(E_ContentsMissionType contentType)
	{
		return null;
	}

	public void OnShownMission(E_ContentsMissionType contentType)
	{
	}

	private void OnMissionComplete((E_ContentsMissionType contentType, int slotId) completeInfo)
	{
	}

	private void OnMissionRewarded((E_ContentsMissionType contentType, int slotId) rewardInfo)
	{
	}

	private void OnMissionValueChanged((E_ContentsMissionType contentType, int slotId) valueChangedInfo)
	{
	}

	private void OnMissionActivate((E_ContentsMissionType contentType, int slotId) activateInfo)
	{
	}

	private void SaveContentMissionData(E_ContentsMissionType contentType, int slotId)
	{
	}

	private bool IsOpenMission(MissionSystem.E_MissionType missionType, int regionIdx)
	{
		return false;
	}

	private void NewMissionGeneratedLog(SingleMissionBase missionData)
	{
	}

	private void MissionCompletedLog(SingleMissionBase missionData)
	{
	}
}
