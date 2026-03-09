namespace KWAnalytics.Analytics
{
	[AnalyticsEvent("google_ump_acceptance", "An event for tracking how the user responsds to the consent prompt managed by Google UMP.")]
	public class GoogleUmpAcceptanceEvent : AnalyticEvent
	{
		[AnalyticsEventParameter("user_accepted", "True if the user accepts the agreement, False is they click out without accepting.")]
		public AnalyticsParameter<bool> userAccepted;

		public GoogleUmpAcceptanceEvent(bool userAccepted)
			: base(null)
		{
		}
	}
}
