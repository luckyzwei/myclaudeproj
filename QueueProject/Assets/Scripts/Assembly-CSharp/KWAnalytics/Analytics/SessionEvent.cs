namespace KWAnalytics.Analytics
{
	[AnalyticsEvent("session", "An event that bookends a session, that is, between app suspension and resumption")]
	public class SessionEvent : AnalyticEvent
	{
		[AnalyticsEventParameter("session_context", "Whether this is a session start or session end event.")]
		public AnalyticsParameter<string> sessionContext;

		public SessionEvent(string sessionCtx)
			: base(null)
		{
		}
	}
}
