namespace KWCore.SaveData
{
	public class PushNotificationsBucket : BucketBase
	{
		[KeyBool]
		private const string PUSH_NOTIFICATION_ENABLED = "PUSH_NOTIFICATION_ENABLED";

		[KeyBool]
		private const string PUSH_NOTIFICATION_ANSWERED = "PUSH_NOTIFICATION_ANSWERED";

		[KeyString]
		private const string SCHEDULED_PUSH_NOTIFICATIONS = "SCHEDULED_PUSH_NOTIFICATIONS";

		[KeyString]
		private const string PMM_SCHEDULED_PUSHES = "PMM_SCHEDULED_PUSHES";

		[KeyString]
		private const string PMM_PUSH_HISTORY = "PMM_PUSH_HISTORY";

		[KeyInt]
		private const string PMM_DAILY_COUNT = "PMM_DAILY_COUNT";

		[KeyString]
		private const string PMM_LAST_COUNT_DATE = "PMM_LAST_COUNT_DATE";

		private static PushNotificationsBucket s_pushnotificationsbucket;

		public static bool PushNotificationEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool PushNotificationAnswered
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static string ScheduledPushNotifications
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static string PmmScheduledPushes
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static string PmmPushHistory
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static int PmmDailyCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static string PmmLastCountDate
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string GetBucketKey()
		{
			return null;
		}

		public override bool IsStoredInCloud()
		{
			return false;
		}

		private static PushNotificationsBucket GetBucket()
		{
			return null;
		}

		public static bool GetPushNotificationEnabled(bool defaultValue = false)
		{
			return false;
		}

		public static void SetPushNotificationEnabled(bool value)
		{
		}

		public static bool GetPushNotificationAnswered(bool defaultValue = false)
		{
			return false;
		}

		public static void SetPushNotificationAnswered(bool value)
		{
		}

		public static string GetScheduledPushNotifications(string defaultValue = null)
		{
			return null;
		}

		public static void SetScheduledPushNotifications(string value)
		{
		}

		public static string GetPmmScheduledPushes(string defaultValue = null)
		{
			return null;
		}

		public static void SetPmmScheduledPushes(string value)
		{
		}

		public static string GetPmmPushHistory(string defaultValue = null)
		{
			return null;
		}

		public static void SetPmmPushHistory(string value)
		{
		}

		public static int GetPmmDailyCount(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetPmmDailyCount(int value)
		{
		}

		public static int IncrementAndSetPmmDailyCount(int increment = 1)
		{
			return 0;
		}

		public static string GetPmmLastCountDate(string defaultValue = null)
		{
			return null;
		}

		public static void SetPmmLastCountDate(string value)
		{
		}
	}
}
