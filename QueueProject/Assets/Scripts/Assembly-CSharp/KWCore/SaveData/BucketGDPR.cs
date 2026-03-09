namespace KWCore.SaveData
{
	public class BucketGDPR : BucketBase
	{
		[SubkeyBool]
		public const string AGREED = "agreed_";

		[SubkeyLong]
		private const string TIME_AGREED = "time_agreed_";

		private static BucketGDPR s_bucketgdpr;

		public override string GetBucketKey()
		{
			return null;
		}

		public override bool IsStoredInCloud()
		{
			return false;
		}

		private static BucketGDPR GetBucket()
		{
			return null;
		}

		public static bool GetAgreed(string subkey, bool defaultValue = false)
		{
			return false;
		}

		public static void SetAgreed(string subkey, bool value)
		{
		}

		public static long GetTimeAgreed(string subkey, long defaultValue = 0L)
		{
			return 0L;
		}

		public static void SetTimeAgreed(string subkey, long value)
		{
		}
	}
}
