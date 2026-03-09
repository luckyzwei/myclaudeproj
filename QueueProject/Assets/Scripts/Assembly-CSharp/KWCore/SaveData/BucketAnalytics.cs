namespace KWCore.SaveData
{
	public class BucketAnalytics : BucketBase
	{
		[KeyBool]
		private const string SENT_PLAYER_INSTALL_EVENT = "sent_player_install_event";

		[KeyBool]
		private const string SENT_DEVICE_INFO_EVENT = "sent_device_info_event";

		private static BucketAnalytics s_bucketanalytics;

		public static bool SentPlayerInstallEvent
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool SentDeviceInfoEvent
		{
			get
			{
				return false;
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

		private static BucketAnalytics GetBucket()
		{
			return null;
		}

		public static bool GetSentPlayerInstallEvent(bool defaultValue = false)
		{
			return false;
		}

		public static void SetSentPlayerInstallEvent(bool value)
		{
		}

		public static bool GetSentDeviceInfoEvent(bool defaultValue = false)
		{
			return false;
		}

		public static void SetSentDeviceInfoEvent(bool value)
		{
		}
	}
}
