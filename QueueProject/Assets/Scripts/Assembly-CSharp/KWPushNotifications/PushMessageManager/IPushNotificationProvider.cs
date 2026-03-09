using System.Collections.Generic;

namespace KWPushNotifications.PushMessageManager
{
	public interface IPushNotificationProvider
	{
		void Initialise(bool requestAuthorizationOnAppLaunch, PushStorage storage);

		void DoOnApplicationPause(bool pause);

		void RequestUserAuthorization();

		void CreateLocalPushNotification(long inMilliseconds, string title, string messageBody, string messageId, string customData = "", bool isCancellable = false);

		void TriggerLocalPushNotification(PushTriggerData data);

		void CancelScheduledLocalPushNotification(string messageId);

		Dictionary<string, SavedNotificationData> GetScheduledPushes();

		int GetTodaysDeliveredPushCount();

		string GetSystemName();

		void Dispose();
	}
}
