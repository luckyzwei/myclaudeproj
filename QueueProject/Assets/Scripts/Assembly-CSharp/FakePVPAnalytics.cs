public static class FakePVPAnalytics
{
	public static class PVPStatus
	{
		public enum Flow
		{
			INITIATE = 0,
			START = 1,
			COMPLETE = 2,
			REMATCH = 3,
			DOUBLE = 4
		}

		public enum WinLoseStatus
		{
			WON = 0,
			LOST = 1,
			LIVES = 2
		}

		public static void SendEvent(Flow flow, bool autoX, WinLoseStatus winLoseStatus, float timeTaken)
		{
		}
	}
}
