using KWCore;
using KWPushNotifications.PushMessageManager;

namespace KWPushNotifications
{
	public class LocalPushNotificationsBase
	{
		protected const string EVENTS_QUEUE_ID = "LocalPushNotificationsBase.RegisterForPermission";

		protected bool m_notificationEnabled;

		protected PushStorage m_storage;

		private const string POPUP_TYPE = "PopUpPushNotifications";

		[EventsQueuePriority(QueueId = "LocalPushNotificationsBase.RegisterForPermission", Priority = 500)]
		public virtual void Initialise(PushStorage storage)
		{
		}

		public virtual void InitializeAuthorizationRequest(bool requestAuthorizationOnAppLaunch)
		{
		}

		public virtual void DoOnApplicationPause(bool pause)
		{
		}

		public virtual void HandleLocalNotificationsOnPause(bool pause)
		{
		}

		public virtual void RequestUserAuthorization()
		{
		}

		public virtual int SendLocalPushNotification(long inMilliseconds, string title, string messageBody, string messageId, string customData = "", bool isCancellable = false)
		{
			return 0;
		}

		protected virtual void CheckForPermissionChange()
		{
		}

		public virtual void OnUserRespondedToNotification()
		{
		}

		public virtual bool IsSystemNotificationEnabled()
		{
			return false;
		}

		private void SendPlayerNotificationPushVerified()
		{
		}

		protected void SendPlayerNotificationPushSession(string title, string intentData)
		{
		}

		protected void SendPlayerNotificationAnalyticEvent(bool accepted)
		{
		}

		protected void SendPlayerNotificationChangeAnalyticEvent(bool accepted)
		{
		}

		protected void SendPlayerNotificationPushScheduled(string uniqueId, string title, long duration, string messageId)
		{
		}

		public virtual void CancelAllLocalNotifications()
		{
		}

		public virtual void CancelScheduledLocalNotificationFromId(string messageId, string context = "")
		{
		}

		private void SendPlayerNotificationPushVerifiedForId(string messageId, string context = "")
		{
		}

		private void SendPushVerifiedEventForNotification(string messageId, SavedNotificationData notification, string contextOverride = "")
		{
		}

		protected string GetMessageIdFromNotificationData(string data)
		{
			return null;
		}

		protected string GetUniqueIdFromNotificationData(string data)
		{
			return null;
		}

		protected void SendPopUpEvent(string popUpStatus)
		{
		}
	}
}
