namespace KWAnalytics.Analytics
{
	[AnalyticsEvent("idfa_acceptance", "An event for tracking how the user responds to the IDFA prompt.")]
	public class IdfaAcceptanceEvent : AnalyticEvent
	{
		[AnalyticsEventParameter("user_accepted", "True if the user accepts the agreement, False is they click out without accepting.")]
		public AnalyticsParameter<bool> userAccepted;

		public IdfaAcceptanceEvent(bool userAcceptance)
			: base(null)
		{
		}
	}
}
