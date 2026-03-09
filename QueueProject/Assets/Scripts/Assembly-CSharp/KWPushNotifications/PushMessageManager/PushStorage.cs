using System.Collections.Generic;

namespace KWPushNotifications.PushMessageManager
{
	public class PushStorage
	{
		private enum PushProvider
		{
			LEGACY = 0,
			PMM = 1
		}

		private Dictionary<string, SavedNotificationData> m_cachedScheduledPushes;

		private int m_todaysPushCount;

		private IPushNotificationProvider m_pushNotificationProvider;

		public void TryAddCachedScheduledPush(SavedNotificationData savedNotificationData)
		{
		}

		public void RemoveCachedScheduledPush(string messageId)
		{
		}

		public void SaveScheduledPushes()
		{
		}

		private PushProvider GetProvider()
		{
			return default(PushProvider);
		}

		public Dictionary<string, SavedNotificationData> LoadScheduledPushes()
		{
			return null;
		}

		public int GetTodaysDeliveredPushCount()
		{
			return 0;
		}

		public void IncrementTodaysPushCount()
		{
		}

		public void ClearExpiredPushes()
		{
		}
	}
}
