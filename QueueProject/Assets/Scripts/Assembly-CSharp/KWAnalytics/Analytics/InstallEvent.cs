namespace KWAnalytics.Analytics
{
	[AnalyticsEvent("install", "Events for tracking app installs")]
	public class InstallEvent : AnalyticEvent
	{
		[AnalyticsEventParameter("install_mode", "The mode of install")]
		public AnalyticsParameter<string> installMode;

		[AnalyticsEventParameter("install_name", "The installer package used")]
		public AnalyticsParameter<string> installName;

		[AnalyticsEventParameter("install_bundle_id", "The bundle ID of the installed app")]
		public AnalyticsParameter<string> installBundleID;

		public InstallEvent()
			: base(null)
		{
		}
	}
}
