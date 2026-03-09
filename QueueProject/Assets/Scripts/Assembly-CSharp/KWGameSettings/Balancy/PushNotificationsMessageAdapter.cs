using System;
using Balancy.Models.Settings.Core;

namespace KWGameSettings.Balancy
{
	[Serializable]
	public class PushNotificationsMessageAdapter : PushNotificationsMessage
	{
		public override long TimeMS { get; set; }

		public override string Title { get; set; }

		public override string Message { get; set; }

		public override string MessageId { get; set; }

		public PushNotificationsMessageAdapter(global::Balancy.Models.Settings.Core.PushNotificationsMessage message)
		{
		}

		public static PushNotificationsMessageAdapter[] GetArray()
		{
			return null;
		}
	}
}
