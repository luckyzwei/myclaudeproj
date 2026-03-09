namespace KWAnalytics.Analytics
{
	[AnalyticsEvent("store_country_received", "An event with the country of the store the app was downloaded from.")]
	public class StoreCountryReceivedEvent : AnalyticEvent
	{
		[AnalyticsEventParameter("install_store_country", "The 2 letter ISO country of the store where the game was installed.")]
		public AnalyticsParameter<string> storeCountry;

		public StoreCountryReceivedEvent(string country)
			: base(null)
		{
		}
	}
}
