using System.Collections.Generic;
using KWPushNotifications.PushMessageManager;
using UnityEngine;

namespace KWPushNotifications
{
	[DefaultExecutionOrder(1)]
	public class LocalPushNotificationsManager : MonoBehaviour
	{
		[Tooltip("When enabled, the push notifications permission popup will show up on boot, according to the Events Queue priority.")]
		[SerializeField]
		private bool m_requestAuthorizationOnAppLaunch;

		private IPushNotificationProvider m_pushProvider;

		private PushStorage m_pushStorage;

		public void Awake()
		{
		}

		public void Start()
		{
		}

		private void OnApplicationFocus(bool hasFocus)
		{
		}

		private void HandleApplicationStateChange(bool isInForeground)
		{
		}

		public void RequestUserAuthorization()
		{
		}

		public void CreateLocalPushNotification(long inMilliseconds, string title, string messageBody, string messageId, string customData = "", bool isCancellable = false)
		{
		}

		public void TriggerLocalPushNotification(PushTriggerData data)
		{
		}

		public void CancelScheduledLocalPushNotification(string messageId)
		{
		}

		public Dictionary<string, SavedNotificationData> GetScheduledPushes()
		{
			return null;
		}

		private void InitializePushProvider()
		{
		}

		public string GetSystemName()
		{
			return null;
		}

		private bool GetPMMEnabled()
		{
			return false;
		}

		private void OnDestroy()
		{
		}

		public int GetTodaysDeliveredPushCount()
		{
			return 0;
		}
	}
}
