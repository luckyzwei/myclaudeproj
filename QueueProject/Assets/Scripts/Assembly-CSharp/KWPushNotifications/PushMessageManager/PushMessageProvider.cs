using System.Collections.Generic;
using KWGameSettings;

namespace KWPushNotifications.PushMessageManager
{
	public class PushMessageProvider : PushNotificationProviderBase
	{
		private PushMessageManager m_pmmManager;

		public override void Initialise(bool requestAuthorizationOnAppLaunch, PushStorage storage)
		{
		}

		public override void DoOnApplicationPause(bool pause)
		{
		}

		public override void CreateLocalPushNotification(long inMilliseconds, string title, string messageBody, string messageId, string customData = "", bool isCancellable = false)
		{
		}

		public override void TriggerLocalPushNotification(PushTriggerData data)
		{
		}

		public override void CancelScheduledLocalPushNotification(string messageId)
		{
		}

		public override Dictionary<string, SavedNotificationData> GetScheduledPushes()
		{
			return null;
		}

		public override int GetTodaysDeliveredPushCount()
		{
			return 0;
		}

		public override string GetSystemName()
		{
			return null;
		}

		public override void Dispose()
		{
		}

		private PushNotifications GetPushNotificationsSettings()
		{
			return null;
		}
	}
}
