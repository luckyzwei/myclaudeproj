namespace KWAnalytics.Analytics
{
	[AnalyticsEvent("screen_exited", "An event for tracking when the player exits a screen.")]
	public class ScreenExitedEvent : AnalyticEvent
	{
		[AnalyticsEventParameter("screen_name", "The name of the screen the player is transitioning to or from.")]
		public AnalyticsParameter<string> screenName;

		[AnalyticsEventParameter("screen_transition_id", "An ID generated to link together screen_entered and screen_exited events.")]
		public AnalyticsParameter<string> screenTransitionId;

		public ScreenExitedEvent(string screenName, string screenTransitionId)
			: base(null)
		{
		}
	}
}
