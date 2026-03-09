namespace KWCore.SaveData
{
	public class LegacyBucketAnalyticsProviderLocalStorage : BucketBase
	{
		[KeyInt]
		private const string ITEM_COUNT = "item_count";

		[SubkeyString]
		private const string ITEM_JSON = "item_json";

		private static LegacyBucketAnalyticsProviderLocalStorage s_legacybucketanalyticsproviderlocalstorage;

		public static int ItemCount
		{
			get
			{
				return 0;
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

		private static LegacyBucketAnalyticsProviderLocalStorage GetBucket()
		{
			return null;
		}

		public static int GetItemCount(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetItemCount(int value)
		{
		}

		public static int IncrementAndSetItemCount(int increment = 1)
		{
			return 0;
		}

		public static string GetItemJson(string subkey, string defaultValue = null)
		{
			return null;
		}

		public static void SetItemJson(string subkey, string value)
		{
		}
	}
}
