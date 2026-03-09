public static class RoyalTournamentAnalytics
{
	public static class RoyalTourStatus
	{
		public enum Status
		{
			STARTED = 0,
			QUALIFIED = 1,
			ELIMINATED = 2
		}

		private const string EVENT_NAME = "royal_tour_status";

		public static void SendEvent(Status status)
		{
		}
	}

	public static class RoyalTournamentEvent
	{
		public enum FlowType
		{
			LIVE = 0,
			VISIT = 1,
			JOIN = 2,
			TIME_REDUCE = 3
		}

		private const string EVENT_NAME = "royal_tour_event";

		public static void SendEvent(FlowType flowType)
		{
		}
	}
}
