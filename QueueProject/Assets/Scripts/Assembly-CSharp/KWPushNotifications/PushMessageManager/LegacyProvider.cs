namespace KWPushNotifications.PushMessageManager
{
	public class LegacyProvider : PushNotificationProviderBase
	{
		public override void Initialise(bool requestAuthorizationOnAppLaunch, PushStorage storage)
		{
		}

		public override void DoOnApplicationPause(bool pause)
		{
		}

		private void CancelExistingNotifications()
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

		public override string GetSystemName()
		{
			return null;
		}
	}
}
