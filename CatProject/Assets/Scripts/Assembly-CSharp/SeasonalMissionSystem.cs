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
	}

	public void Reset()
	{
	}

	public (int, SeasonalMissionData) GetReadyToCompleteMission()
	{
		return default((int, SeasonalMissionData));
	}

	public SeasonalMissionData GetSlotMission(int slotIdx)
	{
		return null;
	}

	public SeasonalMissionGroupData FindMissionGroupData(int slotIdx, int missionIdx, out int groupIndex)
	{
		groupIndex = default(int);
		return null;
	}

	public bool ReqCompleteMission(int slotIdx)
	{
		return false;
	}

	private SeasonalMissionData PickSlotTopMission(int slotIdx)
	{
		return null;
	}

	private void OnOpenMissionGroup(int slotIdx, int missionIdx)
	{
	}

	private void UpdateAndSubscribeMissionEvent(SeasonalMissionData missionData, int slotIndex, int listIndex)
	{
	}

	private void UpdateMissionSaveData(SeasonalMissionData missionData, int listIndex)
	{
	}

	private void OnMissionCompleteReady(int slotIdx, SeasonalMissionData missionData)
	{
	}

	private void NotifyMissionRewardReady()
	{
	}

	private void JustSyncMissionSaveData()
	{
	}

	private SeasonalMissionSlotData MakeMissionSlotData(SeasonalMissionInfoData missionTable)
	{
		return null;
	}

	private SeasonalMissionGroupData MakeMissionGroupData(SeasonalMissionInfoData missionTable)
	{
		return null;
	}

	private List<SeasonalMissionData> MakeMissionDataList(SeasonalMissionInfoData missionTable, SeasonalMissionSaveData saveData)
	{
		return null;
	}
}
