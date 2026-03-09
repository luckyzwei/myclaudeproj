namespace KWAnalytics.Analytics
{
	[AnalyticsEvent("server_country_received", "An event for recording what country the players is in on install based on the server response")]
	public class ServerCountryReceivedEvent : AnalyticEvent
	{
		[AnalyticsEventParameter("install_server_country", "The country code received from the server.")]
		public AnalyticsParameter<string> serverCountry;

		public ServerCountryReceivedEvent(string country)
			: base(null)
		{
		}
	}
}
