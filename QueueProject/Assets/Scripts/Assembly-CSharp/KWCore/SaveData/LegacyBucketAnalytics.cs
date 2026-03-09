namespace KWCore.SaveData
{
	public class LegacyBucketAnalytics : BucketBase
	{
		[KeyBool]
		private const string SENT_PLAYER_INSTALL_EVENT = "sent_player_install_event";

		private static LegacyBucketAnalytics s_legacybucketanalytics;

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

		public override string GetBucketKey()
		{
			return null;
		}

		public override bool IsStoredInCloud()
		{
			return false;
		}

		private static LegacyBucketAnalytics GetBucket()
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
	}
}
