namespace KWCore.SaveData
{
	public class BucketUseStats : BucketBase
	{
		[KeyInt]
		private const string BOOT_COUNT = "stats_boot_count";

		[KeyInt]
		private const string BOOT_COUNT_THIS_VERSION = "stats_boot_count_this_version";

		[KeyInt]
		private const string SESSION_COUNT = "stats_session_count";

		[KeyInt]
		private const string SESSION_COUNT_THIS_VERSION = "stats_session_count_this_version";

		[KeyString]
		private const string INSTALL_ID = "install_id";

		[KeyLong]
		private const string INSTALL_TIME = "stats_install_time";

		[KeyLong]
		private const string SESSION_FINISHED_TIME_STAMP = "stats_session_finished_time_stamp";

		[KeyLong]
		private const string ACCUMULATIVE_SESSION_TIME = "accumulative_session_time";

		[KeyInt]
		private const string TOTAL_NUMBER_OF_PLAYS = "total_number_of_plays";

		[KeyString]
		private const string CURRENT_INSTALL_VERSION = "current_install_version";

		[KeyString]
		private const string PREVIOUS_INSTALL_VERSION = "previous_install_version";

		[KeyString]
		private const string ORIGINAL_INSTALL_VERSION = "original_install_version";

		[KeyInt]
		private const string INTERSTITIALS_WATCHED = "interstitials_watched";

		[KeyInt]
		private const string REWARDS_WATCHED = "rewards_watched";

		[KeyLong]
		private const string ADEXCLUSIVE_SESSION_TIME = "adexclusion_session_time";

		[KeyFloat]
		private const string IAP_REVENUE = "iap_revenue";

		[KeyFloat]
		private const string AD_REVENUE = "ad_revenue";

		[KeyFloat]
		private const string COMBINED_REVENUE = "combined_revenue";

		private static BucketUseStats s_bucketusestats;

		public static int BootCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int BootCountThisVersion
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int SessionCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int SessionCountThisVersion
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static string InstallId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static long InstallTime
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public static long SessionFinishedTimeStamp
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public static long AccumulativeSessionTime
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public static int TotalNumberOfPlays
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static string CurrentInstallVersion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static string PreviousInstallVersion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static string OriginalInstallVersion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static int InterstitialsWatched
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int RewardsWatched
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static long AdexclusiveSessionTime
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public static float IapRevenue
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static float AdRevenue
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static float CombinedRevenue
		{
			get
			{
				return 0f;
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

		private static BucketUseStats GetBucket()
		{
			return null;
		}

		public static int GetBootCount(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetBootCount(int value)
		{
		}

		public static int IncrementAndSetBootCount(int increment = 1)
		{
			return 0;
		}

		public static int GetBootCountThisVersion(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetBootCountThisVersion(int value)
		{
		}

		public static int IncrementAndSetBootCountThisVersion(int increment = 1)
		{
			return 0;
		}

		public static int GetSessionCount(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetSessionCount(int value)
		{
		}

		public static int IncrementAndSetSessionCount(int increment = 1)
		{
			return 0;
		}

		public static int GetSessionCountThisVersion(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetSessionCountThisVersion(int value)
		{
		}

		public static int IncrementAndSetSessionCountThisVersion(int increment = 1)
		{
			return 0;
		}

		public static string GetInstallId(string defaultValue = null)
		{
			return null;
		}

		public static void SetInstallId(string value)
		{
		}

		public static long GetInstallTime(long defaultValue = 0L)
		{
			return 0L;
		}

		public static void SetInstallTime(long value)
		{
		}

		public static long GetSessionFinishedTimeStamp(long defaultValue = 0L)
		{
			return 0L;
		}

		public static void SetSessionFinishedTimeStamp(long value)
		{
		}

		public static long GetAccumulativeSessionTime(long defaultValue = 0L)
		{
			return 0L;
		}

		public static void SetAccumulativeSessionTime(long value)
		{
		}

		public static int GetTotalNumberOfPlays(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetTotalNumberOfPlays(int value)
		{
		}

		public static int IncrementAndSetTotalNumberOfPlays(int increment = 1)
		{
			return 0;
		}

		public static string GetCurrentInstallVersion(string defaultValue = null)
		{
			return null;
		}

		public static void SetCurrentInstallVersion(string value)
		{
		}

		public static string GetPreviousInstallVersion(string defaultValue = null)
		{
			return null;
		}

		public static void SetPreviousInstallVersion(string value)
		{
		}

		public static string GetOriginalInstallVersion(string defaultValue = null)
		{
			return null;
		}

		public static void SetOriginalInstallVersion(string value)
		{
		}

		public static int GetInterstitialsWatched(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetInterstitialsWatched(int value)
		{
		}

		public static int IncrementAndSetInterstitialsWatched(int increment = 1)
		{
			return 0;
		}

		public static int GetRewardsWatched(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetRewardsWatched(int value)
		{
		}

		public static int IncrementAndSetRewardsWatched(int increment = 1)
		{
			return 0;
		}

		public static long GetAdexclusiveSessionTime(long defaultValue = 0L)
		{
			return 0L;
		}

		public static void SetAdexclusiveSessionTime(long value)
		{
		}

		public static float GetIapRevenue(float defaultValue = 0f)
		{
			return 0f;
		}

		public static void SetIapRevenue(float value)
		{
		}

		public static float GetAdRevenue(float defaultValue = 0f)
		{
			return 0f;
		}

		public static void SetAdRevenue(float value)
		{
		}

		public static float GetCombinedRevenue(float defaultValue = 0f)
		{
			return 0f;
		}

		public static void SetCombinedRevenue(float value)
		{
		}
	}
}
