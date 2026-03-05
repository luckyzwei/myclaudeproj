using System;
using System.Collections.Generic;

public class SeasonalMissionSlotData
{
	public int SlotIndex;

	public int LastActiveMissionGroupIndex;

	public List<List<SeasonalMissionGroupData>> MissionPriorityGroups;

	public Dictionary<int, IDisposable> Disposable_MissionGroupOpen;

	public List<SeasonalMissionGroupData> LastActiveMissionGroup
	{
		get
		{
			if (MissionPriorityGroups == null || LastActiveMissionGroupIndex < 0 || LastActiveMissionGroupIndex >= MissionPriorityGroups.Count)
				return null;
			return MissionPriorityGroups[LastActiveMissionGroupIndex];
		}
	}

	~SeasonalMissionSlotData()
	{
		if (Disposable_MissionGroupOpen != null)
		{
			foreach (var kvp in Disposable_MissionGroupOpen)
				kvp.Value?.Dispose();
			Disposable_MissionGroupOpen.Clear();
		}
	}
}
