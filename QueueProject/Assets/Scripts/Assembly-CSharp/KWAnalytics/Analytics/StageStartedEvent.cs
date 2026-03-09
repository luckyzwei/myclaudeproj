namespace KWAnalytics.Analytics
{
	[AnalyticsEvent("stage_started", "An event for tracking how many times particular stage is started. This event is used to determine what stage the player is on at any given time.")]
	public class StageStartedEvent : AnalyticEvent
	{
		[AnalyticsEventParameter("level_value", "The index of the level the player is on.")]
		public AnalyticsParameter<int> levelValue;

		[AnalyticsEventParameter("level_id", "The ID of the level the player is on.")]
		public AnalyticsParameter<string> levelId;

		[AnalyticsEventParameter("stage_value", "The index of the stage within the level the player is on.")]
		public AnalyticsParameter<int> stageValue;

		[AnalyticsEventParameter("stage_id", "The ID of the stage within the level the player is on the player is on.")]
		public AnalyticsParameter<string> stageId;

		[AnalyticsEventParameter("attempt_id", "A unique ID generated for this attempt of the level or stage.")]
		public AnalyticsParameter<string> attemptId;

		public StageStartedEvent(int levelValue, string levelId, int stageValue, string stageId, string attemptId)
			: base(null)
		{
		}
	}
}
