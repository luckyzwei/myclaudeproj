using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class PushNotificationsMessage
	{
		public abstract long TimeMS { get; set; }

		public abstract string Title { get; set; }

		public abstract string Message { get; set; }

		public abstract string MessageId { get; set; }
	}
}
