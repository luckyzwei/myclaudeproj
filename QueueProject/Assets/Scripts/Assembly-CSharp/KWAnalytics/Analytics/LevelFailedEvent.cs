namespace KWAnalytics.Analytics
{
	[AnalyticsEvent("level_failed", "An event for tracking how many times particular level is failed.")]
	public class LevelFailedEvent : AnalyticEvent
	{
		[AnalyticsEventParameter("level_value", "The index of the level the player is on.")]
		public AnalyticsParameter<int> levelValue;

		[AnalyticsEventParameter("level_id", "The ID of the level the player is on.")]
		public AnalyticsParameter<string> levelId;

		[AnalyticsEventParameter("attempt_id", "A unique ID generated for this attempt of the level or stage.")]
		public AnalyticsParameter<string> attemptId;

		public LevelFailedEvent(int levelValue, string levelId, string attemptId)
			: base(null)
		{
		}
	}
}
