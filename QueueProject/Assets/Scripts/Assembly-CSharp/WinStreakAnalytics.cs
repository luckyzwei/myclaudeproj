public static class WinStreakAnalytics
{
	public static class StreakStatus
	{
		public enum UpdateMethod
		{
			LEVEL = 0,
			REPAIR = 1,
			RESET = 2
		}

		private const string EVENT_NAME = "streak_status";

		public static void SendEvent(UpdateMethod UpdateMethod)
		{
		}
	}

	public static class StreakPopup
	{
		public enum PopupOpenType
		{
			MANUAL = 0,
			REPAIR = 1,
			MILESTONE = 2
		}

		private const string EVENT_NAME = "streak_popup";

		public static void SendEvent(PopupOpenType openType)
		{
		}
	}
}
