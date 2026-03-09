namespace KWAnalytics.Analytics
{
	[AnalyticsEvent("screen_entered", "An event for tracking when the player enters a new screen.")]
	public class ScreenEnteredEvent : AnalyticEvent
	{
		[AnalyticsEventParameter("screen_name", "The name of the screen the player is transitioning to or from.")]
		public AnalyticsParameter<string> screenName;

		[AnalyticsEventParameter("screen_transition_id", "An ID generated to link together screen_entered and screen_exited events.")]
		public AnalyticsParameter<string> screenTransitionId;

		public ScreenEnteredEvent(string screenName, string screenTransitionId)
			: base(null)
		{
		}
	}
}
