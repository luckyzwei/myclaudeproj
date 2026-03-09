namespace KWAnalytics.Analytics
{
	[AnalyticsEvent("ab_test", "Events for tracking AB tests")]
	public class AbTestEvent : AnalyticEvent
	{
		[AnalyticsEventParameter("ab_test_name", "AB Test Name")]
		public AnalyticsParameter<string> abTestName;

		[AnalyticsEventParameter("ab_test_group", "AB Test Group")]
		public AnalyticsParameter<string> abTestGroup;

		public AbTestEvent(string abTestName, string abTestGroup)
			: base(null)
		{
		}
	}
}
