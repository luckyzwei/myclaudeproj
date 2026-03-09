namespace KWAnalytics.Analytics
{
	[AnalyticsEvent("ntp_time_received", "An event with both device and NTP time in order to impute NTP team for events that do not have it.")]
	public class NTPTimeReceivedEvent : AnalyticEvent
	{
		public NTPTimeReceivedEvent()
			: base(null)
		{
		}
	}
}
