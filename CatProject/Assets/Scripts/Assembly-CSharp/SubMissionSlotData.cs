using System.Collections.Generic;

public class SubMissionSlotData
{
	public int SlotIndex;

	public int LastActiveMissionGroupIndex;

	public List<List<SubMissionGroupData>> MissionPriorityGroups;

	public List<SubMissionGroupData> LastActiveMissionGroup
	{
		get
		{
			if (MissionPriorityGroups == null || LastActiveMissionGroupIndex < 0 || LastActiveMissionGroupIndex >= MissionPriorityGroups.Count)
				return null;
			return MissionPriorityGroups[LastActiveMissionGroupIndex];
		}
	}
}
