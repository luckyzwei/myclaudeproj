namespace KWAnalytics.Analytics
{
	[AnalyticsEvent("user_update", "An event that is used for updating our user face table")]
	public class UserUpdateEvent : AnalyticEvent
	{
		[AnalyticsEventParameter("player_id_type", "The type of player ID")]
		public AnalyticsParameter<string> playerIdType;

		[AnalyticsEventParameter("player_id_value", "The value of the player ID")]
		public AnalyticsParameter<string> playerIdValue;

		public UserUpdateEvent(string playerIdType, string playerIdValue)
			: base(null)
		{
		}
	}
}
