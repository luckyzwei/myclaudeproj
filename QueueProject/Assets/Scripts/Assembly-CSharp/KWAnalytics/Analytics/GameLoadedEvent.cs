namespace KWAnalytics.Analytics
{
	[AnalyticsEvent("game_loaded", "Events to determine when the game is loaded and status of game settings")]
	public class GameLoadedEvent : AnalyticEvent
	{
		[AnalyticsEventParameter("game_settings_loaded", "Game Settings Loaded")]
		public AnalyticsParameter<bool> gameSettingsLoaded;

		public GameLoadedEvent(bool settingsLoaded)
			: base(null)
		{
		}
	}
}
