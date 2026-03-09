namespace KWAnalytics.Analytics
{
	[AnalyticsEvent("bank_snapshot", "An event for tracking how much in-game currency the player has at a given time.")]
	public class BankSnapshotEvent : AnalyticEvent
	{
		[AnalyticsEventParameter("currencies_held", "A JSON object with keys as the currency types held and values the amount of currency held.")]
		public AnalyticsParameter<string> currenciesHeld;

		public BankSnapshotEvent(string currenciesHeld)
			: base(null)
		{
		}
	}
}
