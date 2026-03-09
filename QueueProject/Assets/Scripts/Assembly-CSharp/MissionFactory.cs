using System.Collections.Generic;
using Balancy.Models.Gameplay.Missions;

public static class MissionFactory
{
	private static Dictionary<MissionType, BaseMission> s_cachedMissions;

	private static BaseMission CreateInstance(MissionType missionType)
	{
		return null;
	}

	public static BaseMission CreateMissionClass(MissionData missionData)
	{
		return null;
	}
}
