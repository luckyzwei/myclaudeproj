using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class PushNotificationsAdapter : PushNotifications
	{
		[SerializeField]
		private PushNotificationsMessageAdapter[] messages;

		[SerializeField]
		private PMManagerSettingsAdapter pmManagerSettings;

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
