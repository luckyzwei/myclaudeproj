namespace KWCore.SaveData
{
	public class BucketFirebaseMarket : BucketBase
	{
		[KeyString]
		public const string CACHED_ALL_PRODUCT_INFO_KEY = "CACHED_ALL_PRODUCT_LIST_INFO";

		[KeyBool]
		private const string FAKE_MARKET_ENABLED = "FAKE_MARKET_ENABLED";

		private static BucketFirebaseMarket s_bucketfirebasemarket;

		public static string CachedAllProductInfoKey
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool FakeMarketEnabled
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

		private static BucketFirebaseMarket GetBucket()
		{
			return null;
		}

		public static string GetCachedAllProductInfoKey(string defaultValue = null)
		{
			return null;
		}

		public static void SetCachedAllProductInfoKey(string value)
		{
		}

		public static bool GetFakeMarketEnabled(bool defaultValue = false)
		{
			return false;
		}

		public static void SetFakeMarketEnabled(bool value)
		{
		}
	}
}
