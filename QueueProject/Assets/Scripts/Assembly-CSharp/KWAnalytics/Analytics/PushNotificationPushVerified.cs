using System;

namespace KWAnalytics.Analytics
{
	[Serializable]
	public class PushNotificationPushVerified : ClosedSchema
	{
		public PushNotificationPushVerified(string uniqueId, long duration, string title, string messageID, bool verified, string context)
		{
		}
	}
}
