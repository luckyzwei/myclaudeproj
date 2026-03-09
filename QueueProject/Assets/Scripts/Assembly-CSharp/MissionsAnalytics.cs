public static class MissionsAnalytics
{
	public static class DailyMissionStatus
	{
		public enum Flow
		{
			MISSION_START = 0,
			MISSION_COMPLETE = 1,
			MISSION_SWAPPED = 2,
			REWARD_CLAIMED = 3
		}

		private static string[] s_flowTexts;

		public static void SendEvent(int missionNumber, Flow flow, string missionClientId)
		{
		}
	}
}
