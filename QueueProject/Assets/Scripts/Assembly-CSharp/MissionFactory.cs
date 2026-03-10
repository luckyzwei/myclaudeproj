using System.Collections.Generic;
using Balancy.Models.Gameplay.Missions;

public static class MissionFactory
{
	private static Dictionary<MissionType, BaseMission> s_cachedMissions;

	private static BaseMission CreateInstance(MissionType missionType)
	{
		// Each MissionType maps to a specific BaseMission subclass
		// Without concrete implementations, return null
		return null;
	}

	public static BaseMission CreateMissionClass(MissionData missionData)
	{
		if (missionData == null) return null;

		if (s_cachedMissions == null)
			s_cachedMissions = new Dictionary<MissionType, BaseMission>();

		// Try to create mission from type
		var mission = CreateInstance(missionData.MissionType);
		if (mission != null)
		{
			s_cachedMissions[missionData.MissionType] = mission;
		}
		return mission;
	}
}
