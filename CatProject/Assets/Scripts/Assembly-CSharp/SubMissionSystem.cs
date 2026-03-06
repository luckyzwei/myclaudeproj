using System.Collections.Generic;
using Treeplla;

public class SubMissionSystem
{
	private readonly int MAX_SLOT_CNT;

	public Dictionary<int, SubMissionSlotData> MissionSlotDataMap { get; private set; }

	public List<SubMissionStepData> SlotDisplayMissionDataList { get; private set; }

	public void Init()
	{
		MissionSlotDataMap = new Dictionary<int, SubMissionSlotData>();
		SlotDisplayMissionDataList = new List<SubMissionStepData>();
	}

	public (int, SubMissionStepData) GetReadyToCompleteMission()
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

	public SubMissionStepData GetSlotMission(int slotIdx)
	{
		if (SlotDisplayMissionDataList == null || slotIdx < 0 || slotIdx >= SlotDisplayMissionDataList.Count)
			return null;
		return SlotDisplayMissionDataList[slotIdx];
	}

	public SubMissionGroupData FindMissionGroupData(int slotIdx, int missionIdx, out int groupIndex)
	{
		groupIndex = -1;
		if (MissionSlotDataMap == null) return null;
		if (!MissionSlotDataMap.TryGetValue(slotIdx, out var slotData)) return null;
		if (slotData.MissionPriorityGroups == null) return null;
		for (int p = 0; p < slotData.MissionPriorityGroups.Count; p++)
		{
			var groupList = slotData.MissionPriorityGroups[p];
			if (groupList == null) continue;
			for (int i = 0; i < groupList.Count; i++)
			{
				var group = groupList[i];
				if (group != null && group.MissionIdx == missionIdx)
				{
					groupIndex = i;
					return group;
				}
			}
		}
		return null;
	}

	public bool ReqCompleteMission(int slotIdx)
	{
		var mission = GetSlotMission(slotIdx);
		if (mission == null || !mission.bReadyToComplete) return false;
		OnMissionCompleteReady(slotIdx, mission);
		return true;
	}

	private SubMissionStepData PickSlotTopMission(int slotIdx)
	{
		if (MissionSlotDataMap == null) return null;
		if (!MissionSlotDataMap.TryGetValue(slotIdx, out var slotData)) return null;
		if (slotData.MissionPriorityGroups == null) return null;

		SubMissionStepData bestMission = null;
		int bestPriority = int.MaxValue;
		for (int p = 0; p < slotData.MissionPriorityGroups.Count; p++)
		{
			var groupList = slotData.MissionPriorityGroups[p];
			if (groupList == null) continue;
			for (int i = 0; i < groupList.Count; i++)
			{
				var group = groupList[i];
				if (group == null || group.bCompleteGroup) continue;
				if (group.MissionData == null || group.CurActiveMissionIndex < 0 || group.CurActiveMissionIndex >= group.MissionData.Count) continue;
				var step = group.MissionData[group.CurActiveMissionIndex];
				if (step != null && group.ShowPriority < bestPriority)
				{
					bestPriority = group.ShowPriority;
					bestMission = step;
				}
			}
		}
		return bestMission;
	}

	private void UpdateAndSubscribeMissionEvent(SubMissionStepData missionData, int slotIndex, int listIndex)
	{
		if (missionData == null) return;
		UpdateMissionSaveData(missionData, listIndex);
	}

	private void UpdateMissionSaveData(SubMissionStepData missionData, int listIndex)
	{
		if (missionData == null) return;
		JustSyncMissionSaveData();
	}

	private void OnMissionCompleteReady(int slotIdx, SubMissionStepData missionData)
	{
		if (missionData == null) return;
		NotifyMissionRewardReady();
	}

	private void NotifyMissionRewardReady()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		root.UserData.Save();
	}

	private void JustSyncMissionSaveData()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		root.UserData.Save();
	}

	private SubMissionSlotData MakeMissionSlotData(SubMissionData missionTable)
	{
		if (missionTable == null) return null;
		var slotData = new SubMissionSlotData();
		return slotData;
	}

	private SubMissionGroupData MakeMissionGroupData(SubMissionData missionTable)
	{
		if (missionTable == null) return null;
		var groupData = new SubMissionGroupData();
		return groupData;
	}

	private List<SubMissionStepData> MakeMissionDataList(SubMissionData missionTable, SubMissionSaveData saveData)
	{
		if (missionTable == null) return null;
		var list = new List<SubMissionStepData>();
		return list;
	}
}
