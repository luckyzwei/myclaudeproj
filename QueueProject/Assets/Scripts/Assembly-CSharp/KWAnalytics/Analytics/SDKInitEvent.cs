namespace KWAnalytics.Analytics
{
	[AnalyticsEvent("sdk_init", "An event that tracks which SDKs initialise successfully and which fail to initialise")]
	public class SDKInitEvent : AnalyticEvent
	{
		[AnalyticsEventParameter("sdk_init_success", "Whether the SDK initialisation stage was successful or not")]
		public AnalyticsParameter<bool> sdkInitSuccess;

		[AnalyticsEventParameter("sdk_init_stage", "The SDK being initialised")]
		public AnalyticsParameter<string> sdkInitStage;

		public SDKInitEvent(bool success, string stage)
			: base(null)
		{
		}
	}
}
