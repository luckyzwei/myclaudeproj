namespace KWAnalytics.Analytics
{
	[AnalyticsEvent("terms_and_conditions_acceptance", "An event for tracking how the user responds to the terms and conditions prompt.")]
	public class TermsAndConditionsAcceptanceEvent : AnalyticEvent
	{
		[AnalyticsEventParameter("user_accepted", "True if the user accepts the agreement, False is they click out without accepting.")]
		public AnalyticsParameter<bool> userAccepted;

		public TermsAndConditionsAcceptanceEvent(bool userAccepted)
			: base(null)
		{
		}
	}
}
