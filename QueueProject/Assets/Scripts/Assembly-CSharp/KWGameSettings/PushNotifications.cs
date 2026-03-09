using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class PushNotifications
	{
		public abstract PushNotificationsMessage[] Messages { get; set; }

		public abstract PMManagerSettings PmManagerSettings { get; set; }
	}
}
