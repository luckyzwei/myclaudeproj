using System.Collections.Generic;

public class SubMissionSlotData
{
	public int SlotIndex;

	public int LastActiveMissionGroupIndex;

	public List<List<SubMissionGroupData>> MissionPriorityGroups;

	public List<SubMissionGroupData> LastActiveMissionGroup => null;
}
