using System;

namespace KWPushNotifications.PushMessageManager
{
	[Serializable]
	public struct SavedNotificationData
	{
		public DateTime Time;

		public string Title;

		public string MessageId;

		public string UniqueId;

		public int NotificationId;

		public string MessageBody;

		public bool IsCancellable;

		public SavedNotificationData(DateTime time, string title, string messageId, string uniqueId, int notificationId, string messageBody, bool isCancellable)
		{
			Time = default(DateTime);
			Title = null;
			MessageId = null;
			UniqueId = null;
			NotificationId = 0;
			MessageBody = null;
			IsCancellable = false;
		}

		public bool ShouldCancelForForeground(int foregroundCancelSeconds)
		{
			return false;
		}

		public bool IsDelivered()
		{
			return false;
		}
	}
}
