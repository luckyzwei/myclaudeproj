using System.Collections.Generic;
using KWGameSettings;

namespace KWPushNotifications.PushMessageManager
{
	public class PushScheduler
	{
		private readonly List<Push> m_pendingQueue;

		private readonly PushStorage m_storage;

		private readonly LocalPushNotificationsBase m_platformProvider;

		private readonly PushRuleEngine m_ruleEngine;

		public PushScheduler(PushStorage storage, PushNotifications settings, LocalPushNotificationsBase platformProvider, PushRuleEngine ruleEngine)
		{
		}

		public void AddToQueue(PushTriggerData data)
		{
		}

		public void ProcessQueue()
		{
		}

		private void SchedulePush(Push pendingPush)
		{
		}

		public void CancelScheduledPush(string pushLocationId)
		{
		}

		public Dictionary<string, SavedNotificationData> GetScheduledPushes()
		{
			return null;
		}

		private string BuildCustomData(PushTriggerData triggerData)
		{
			return null;
		}

		private bool ShouldRejectEarly(PushTriggerData data)
		{
			return false;
		}

		private bool CheckDuplicateEarly(PushTriggerData data)
		{
			return false;
		}
	}
}
