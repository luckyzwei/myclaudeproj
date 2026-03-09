using System;

namespace KWGameSettings.Balancy
{
	[Serializable]
	public class PushNotificationsAdapter : PushNotifications
	{
		public override PushNotificationsMessage[] Messages
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override PMManagerSettings PmManagerSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
