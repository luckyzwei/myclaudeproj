namespace KWAnalytics.Analytics
{
	[AnalyticsEvent("level_continued", "An event for tracking when a particular level is continued after a failure.")]
	public class LevelContinuedEvent : AnalyticEvent
	{
		[AnalyticsEventParameter("level_value", "The index of the level the player is on.")]
		public AnalyticsParameter<int> levelValue;

		[AnalyticsEventParameter("level_id", "The ID of the level the player is on.")]
		public AnalyticsParameter<string> levelId;

		[AnalyticsEventParameter("attempt_id", "A unique ID generated for this attempt of the level or stage.")]
		public AnalyticsParameter<string> attemptId;

		[AnalyticsEventParameter("continue_context", "The reason the user could continue.")]
		public AnalyticsParameter<string> continueContext;

		public LevelContinuedEvent(int levelValue, string levelId, string attemptId, string continueContext)
			: base(null)
		{
		}
	}
}
