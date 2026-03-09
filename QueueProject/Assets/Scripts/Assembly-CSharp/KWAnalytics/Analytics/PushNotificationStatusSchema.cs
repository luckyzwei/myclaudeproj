using System;

namespace KWAnalytics.Analytics
{
	[Serializable]
	public class PushNotificationStatusSchema : ClosedSchema
	{
		public enum PushNotificationAcceptance
		{
			ACCEPTED = 0,
			REJECTED = 1,
			TURNED_OFF = 2,
			TURNED_ON = 3
		}

		public PushNotificationStatusSchema(PushNotificationAcceptance acceptance)
		{
		}
	}
}
