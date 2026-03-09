namespace KWAnalytics.Analytics
{
	[AnalyticsEvent("app_lifecycle", "An event that book ends the app lifecycle, from boot to shutdown")]
	public class AppLifeCycleEvent : AnalyticEvent
	{
		[AnalyticsEventParameter("kwsdk_version", "The version of the Kwalee SDK the event is sent from")]
		public AnalyticsParameter<string> kwSdkVersion;

		[AnalyticsEventParameter("connection_type", "The type of connection the device is on")]
		public AnalyticsParameter<string> ConnectionType;

		[AnalyticsEventParameter("session_context", "Whether this is a session start or session end event.")]
		public AnalyticsParameter<string> sessionContext;

		public AppLifeCycleEvent(string sessionCtx)
			: base(null)
		{
		}
	}
}
