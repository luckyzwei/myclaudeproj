using System.Collections;

namespace KWAnalytics.Analytics
{
	public class AnalyticEvent
	{
		public AnalyticsParameter<string> eventType;

		public AnalyticsParameter<string> appInstanceID;

		public AnalyticsParameter<string> appSessionID;

		public AnalyticsParameter<long?> eventCreatedTimeNTP;

		public AnalyticsParameter<long?> eventCreatedTimeDevice;

		public AnalyticsParameter<string> eventSendContext;

		public AnalyticsParameter<string> gameID;

		public AnalyticsParameter<string> installID;

		public AnalyticsParameter<string> appVersion;

		public AnalyticsParameter<string> devicePlatform;

		protected AnalyticEvent(string eventType)
		{
		}

		public Hashtable GetEventHashTable(bool removeNullValues = false)
		{
			return null;
		}

		private string GetDevicePlatform()
		{
			return null;
		}
	}
}
