using System;
using System.Collections.Generic;

public class SeasonalMissionSlotData
{
	public int SlotIndex;

	public int LastActiveMissionGroupIndex;

	public List<List<SeasonalMissionGroupData>> MissionPriorityGroups;

	public Dictionary<int, IDisposable> Disposable_MissionGroupOpen;

	public List<SeasonalMissionGroupData> LastActiveMissionGroup { get { return null; } }

	~SeasonalMissionSlotData()
	{
	}
}
