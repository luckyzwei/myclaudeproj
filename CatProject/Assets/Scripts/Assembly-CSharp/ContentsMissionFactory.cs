using System;
using System.Collections.Generic;

public static class ContentsMissionFactory
{
	private static Dictionary<MissionSystem.E_MissionType, Func<SingleMissionInitParams, SingleMissionBase>> MissionCreators;

	public static SingleMissionBase CreateMission(SingleMissionInitParams missionData)
	{
		return null;
	}
}
