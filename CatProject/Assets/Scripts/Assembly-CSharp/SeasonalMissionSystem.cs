using System.Collections.Generic;
using Treeplla;
using UniRx;

public class SeasonalMissionSystem
{
	private readonly int MAX_SLOT_CNT;

	public Subject<Unit> OnMissionCompleteReadyEvent;

	public Dictionary<int, SeasonalMissionSlotData> MissionSlotDataMap { get; private set; }

	public List<SeasonalMissionData> SlotDisplayMissionDataList { get; private set; }

	public void InitAndSyncData(int seasonThemeIdx, Dictionary<int, SeasonalMissionSaveData> missionSaveData)
	{
		MissionSlotDataMap = new Dictionary<int, SeasonalMissionSlotData>();
		SlotDisplayMissionDataList = new List<SeasonalMissionData>();
		OnMissionCompleteReadyEvent = new Subject<Unit>();
	}

	public void Reset()
	{
		if (SlotDisplayMissionDataList != null)
		{
			for (int i = 0; i < SlotDisplayMissionDataList.Count; i++)
			{
				if (SlotDisplayMissionDataList[i] != null)
					SlotDisplayMissionDataList[i].DisposeSubscribe();
			}
			SlotDisplayMissionDataList.Clear();
		}
		if (MissionSlotDataMap != null)
			MissionSlotDataMap.Clear();
	}

	public (int, SeasonalMissionData) GetReadyToCompleteMission()
	{
		if (SlotDisplayMissionDataList == null) return (-1, null);
		for (int i = 0; i < SlotDisplayMissionDataList.Count; i++)
		{
			var data = SlotDisplayMissionDataList[i];
			if (data != null && data.bReadyToComplete)
				return (i, data);
		}
		return (-1, null);
	}

	public SeasonalMissionData GetSlotMission(int slotIdx)
	{
		if (SlotDisplayMissionDataList == null || slotIdx < 0 || slotIdx >= SlotDisplayMissionDataList.Count)
			return null;
		return SlotDisplayMissionDataList[slotIdx];
	}

	public SeasonalMissionGroupData FindMissionGroupData(int slotIdx, int missionIdx, out int groupIndex)
	{
		groupIndex = -1;
		if (MissionSlotDataMap == null || !MissionSlotDataMap.TryGetValue(slotIdx, out var slotData))
			return null;
		if (slotData.MissionPriorityGroups == null) return null;

		for (int i = 0; i < slotData.MissionPriorityGroups.Count; i++)
		{
			var group = slotData.MissionPriorityGroups[i];
			if (group == null) continue;
			for (int j = 0; j < group.Count; j++)
			{
				if (group[j] != null && group[j].MissionIdx == missionIdx)
				{
					groupIndex = i;
					return group[j];
				}
			}
		}
		return null;
	}

	public bool ReqCompleteMission(int slotIdx)
	{
		if (SlotDisplayMissionDataList == null || slotIdx < 0 || slotIdx >= SlotDisplayMissionDataList.Count)
			return false;

		var missionData = SlotDisplayMissionDataList[slotIdx];
		if (missionData == null || !missionData.bReadyToComplete)
			return false;

		missionData.DisposeSubscribe();

		var nextMission = PickSlotTopMission(slotIdx);
		SlotDisplayMissionDataList[slotIdx] = nextMission;

		if (nextMission != null)
			UpdateAndSubscribeMissionEvent(nextMission, slotIdx, slotIdx);

		return true;
	}

	private SeasonalMissionData PickSlotTopMission(int slotIdx)
	{
		if (MissionSlotDataMap == null || !MissionSlotDataMap.TryGetValue(slotIdx, out var slotData))
			return null;
		if (slotData.LastActiveMissionGroup == null) return null;

		for (int i = 0; i < slotData.LastActiveMissionGroup.Count; i++)
		{
			var groupData = slotData.LastActiveMissionGroup[i];
			if (groupData == null) continue;
			if (groupData.bSatisfiedOpenCondition != null && groupData.bSatisfiedOpenCondition.Value)
				return null;
		}
		return null;
	}

	private void OnOpenMissionGroup(int slotIdx, int missionIdx)
	{
		var nextMission = PickSlotTopMission(slotIdx);
		if (nextMission != null && slotIdx >= 0 && slotIdx < SlotDisplayMissionDataList.Count)
		{
			SlotDisplayMissionDataList[slotIdx] = nextMission;
			UpdateAndSubscribeMissionEvent(nextMission, slotIdx, slotIdx);
		}
	}

	private void UpdateAndSubscribeMissionEvent(SeasonalMissionData missionData, int slotIndex, int listIndex)
	{
		if (missionData == null) return;
		UpdateMissionSaveData(missionData, listIndex);
	}

	private void UpdateMissionSaveData(SeasonalMissionData missionData, int listIndex)
	{
		if (missionData == null) return;
		JustSyncMissionSaveData();
	}

	private void OnMissionCompleteReady(int slotIdx, SeasonalMissionData missionData)
	{
		if (missionData == null) return;
		missionData.bComplete = true;
		NotifyMissionRewardReady();
	}

	private void NotifyMissionRewardReady()
	{
		if (OnMissionCompleteReadyEvent != null)
			OnMissionCompleteReadyEvent.OnNext(Unit.Default);
	}

	private void JustSyncMissionSaveData()
	{
		var stageData = SeasonalHelper.SeasonalStageData;
		if (stageData?.MissionSaveDataMap == null || SlotDisplayMissionDataList == null) return;

		for (int i = 0; i < SlotDisplayMissionDataList.Count; i++)
		{
			var mission = SlotDisplayMissionDataList[i];
			if (mission == null) continue;

			if (!stageData.MissionSaveDataMap.TryGetValue(i, out var saveData))
			{
				saveData = new SeasonalMissionSaveData();
				saveData.MissionIdx = mission.MissionIdx;
				stageData.MissionSaveDataMap[i] = saveData;
			}
			else
			{
				saveData.MissionIdx = mission.MissionIdx;
			}
		}
	}

	private SeasonalMissionSlotData MakeMissionSlotData(SeasonalMissionInfoData missionTable)
	{
		if (missionTable == null) return null;
		var slotData = new SeasonalMissionSlotData();
		slotData.MissionPriorityGroups = new List<List<SeasonalMissionGroupData>>();
		slotData.Disposable_MissionGroupOpen = new Dictionary<int, System.IDisposable>();
		return slotData;
	}

	private SeasonalMissionGroupData MakeMissionGroupData(SeasonalMissionInfoData missionTable)
	{
		if (missionTable == null) return null;
		var groupData = new SeasonalMissionGroupData();
		groupData.bSatisfiedOpenCondition = new ReactiveProperty<bool>(false);
		return groupData;
	}

	private List<SeasonalMissionData> MakeMissionDataList(SeasonalMissionInfoData missionTable, SeasonalMissionSaveData saveData)
	{
		if (missionTable == null) return null;
		var list = new List<SeasonalMissionData>();
		return list;
	}
}
