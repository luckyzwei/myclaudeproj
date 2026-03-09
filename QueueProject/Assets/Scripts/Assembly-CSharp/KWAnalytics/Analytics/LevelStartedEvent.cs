namespace KWAnalytics.Analytics
{
	[AnalyticsEvent("level_started", "An event for tracking how many times particular level is started. This event is used to determine what level the player is on at any given time.")]
	public class LevelStartedEvent : AnalyticEvent
	{
		[AnalyticsEventParameter("level_value", "The index of the level the player is on.")]
		public AnalyticsParameter<int> levelValue;

		[AnalyticsEventParameter("level_id", "The ID of the level the player is on.")]
		public AnalyticsParameter<string> levelId;

		[AnalyticsEventParameter("attempt_id", "A unique ID generated for this attempt of the level or stage.")]
		public AnalyticsParameter<string> attemptId;

		public LevelStartedEvent(int levelValue, string levelId, string attemptId)
			: base(null)
		{
		}
	}
}
