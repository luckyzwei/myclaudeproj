namespace KWAnalytics.Analytics
{
	[AnalyticsEvent("app_update", "Event for tracking when players update the app")]
	public class AppUpdateEvent : AnalyticEvent
	{
		[AnalyticsEventParameter("previous_app_version", "The app version the user updated from")]
		public AnalyticsParameter<string> previousAppVersion;

		public AppUpdateEvent(string previousAppVersion)
			: base(null)
		{
		}
	}
}
