namespace KWAnalytics.Analytics
{
	[AnalyticsEvent("bank_transaction", "An event for tracking in-game currency transactions.")]
	public class BankTransactionEvent : AnalyticEvent
	{
		[AnalyticsEventParameter("currencies_spent", "A JSON object with keys as the currency types spent and values the amount of currency spent.")]
		public AnalyticsParameter<string> currenciesSpent;

		[AnalyticsEventParameter("currencies_earned", "A JSON object with keys as the currency types earned and values the amount of currency earned.")]
		public AnalyticsParameter<string> currenciesEarned;

		public BankTransactionEvent(string currencyID, long diffAmount)
			: base(null)
		{
		}
	}
}
