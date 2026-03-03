using System.Collections.Generic;
using Treeplla;

public class SubMissionSystem
{
	private readonly int MAX_SLOT_CNT;

	public Dictionary<int, SubMissionSlotData> MissionSlotDataMap { get; private set; }

	public List<SubMissionStepData> SlotDisplayMissionDataList { get; private set; }

	public void Init()
	{
	}

	public (int, SubMissionStepData) GetReadyToCompleteMission()
	{
		return default((int, SubMissionStepData));
	}

	public SubMissionStepData GetSlotMission(int slotIdx)
	{
		return null;
	}

	public SubMissionGroupData FindMissionGroupData(int slotIdx, int missionIdx, out int groupIndex)
	{
		groupIndex = default(int);
		return null;
	}

	public bool ReqCompleteMission(int slotIdx)
	{
		return false;
	}

	private SubMissionStepData PickSlotTopMission(int slotIdx)
	{
		return null;
	}

	private void UpdateAndSubscribeMissionEvent(SubMissionStepData missionData, int slotIndex, int listIndex)
	{
	}

	private void UpdateMissionSaveData(SubMissionStepData missionData, int listIndex)
	{
	}

	private void OnMissionCompleteReady(int slotIdx, SubMissionStepData missionData)
	{
	}

	private void NotifyMissionRewardReady()
	{
	}

	private void JustSyncMissionSaveData()
	{
	}

	private SubMissionSlotData MakeMissionSlotData(SubMissionData missionTable)
	{
		return null;
	}

	private SubMissionGroupData MakeMissionGroupData(SubMissionData missionTable)
	{
		return null;
	}

	private List<SubMissionStepData> MakeMissionDataList(SubMissionData missionTable, SubMissionSaveData saveData)
	{
		return null;
	}
}
