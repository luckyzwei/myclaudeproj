namespace KWCore.SaveData
{
	public class BucketForceInterstitial : BucketBase
	{
		private const string BUCKET_KEY = "BUCKET_FORCE_INTERSTITIAL";

		[KeyInt]
		private const string BOOT_COUNT = "boot_count";

		[KeyInt]
		private const string SESSION_COUNT = "session_count";

		[KeyLong]
		private const string INT_TIME = "int_time";

		private static BucketForceInterstitial s_bucketforceinterstitial;

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

		public static long IntTime
		{
			get
			{
				return 0L;
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

		private static BucketForceInterstitial GetBucket()
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

		public static long GetIntTime(long defaultValue = 0L)
		{
			return 0L;
		}

		public static void SetIntTime(long value)
		{
		}
	}
}
