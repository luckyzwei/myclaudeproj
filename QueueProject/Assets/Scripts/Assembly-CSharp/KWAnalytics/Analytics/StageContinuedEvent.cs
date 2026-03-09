namespace KWAnalytics.Analytics
{
	[AnalyticsEvent("stage_continued", "An event for tracking when a particular stage is continued after a failure.")]
	public class StageContinuedEvent : AnalyticEvent
	{
		[AnalyticsEventParameter("level_id", "The ID of the level the player is on.")]
		public AnalyticsParameter<string> levelId;

		[AnalyticsEventParameter("level_value", "The index of the level the player is on.")]
		public AnalyticsParameter<int> levelValue;

		[AnalyticsEventParameter("stage_id", "The ID of the stage within the level the player is on.")]
		public AnalyticsParameter<string> stageId;

		[AnalyticsEventParameter("stage_value", "The index of the stage within the level the player is on.")]
		public AnalyticsParameter<int> stageValue;

		[AnalyticsEventParameter("attempt_id", "A unique ID generated for this attempt of the level or stage.")]
		public AnalyticsParameter<string> attemptId;

		[AnalyticsEventParameter("continue_context", "The reason the user could continue.")]
		public AnalyticsParameter<string> continueContext;

		public StageContinuedEvent(string levelId, int levelValue, string stageId, int stageValue, string attemptId, string continueContext)
			: base(null)
		{
		}
	}
}
