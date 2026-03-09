namespace KWCore.SaveData
{
	public class BucketFeatureUnlock : BucketBase
	{
		private const string BUCKET_KEY = "BUCKET_FEATURE_UNLOCK";

		[KeyBool]
		public const string IS_MIGRATED = "is_migrated";

		[KeyInt]
		public const string FEATURES_UNLOCKED = "features_unlocked";

		private static BucketFeatureUnlock s_bucketfeatureunlock;

		public static bool IsMigrated
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static int FeaturesUnlocked
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

		private static BucketFeatureUnlock GetBucket()
		{
			return null;
		}

		public static bool GetIsMigrated(bool defaultValue = false)
		{
			return false;
		}

		public static void SetIsMigrated(bool value)
		{
		}

		public static int GetFeaturesUnlocked(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetFeaturesUnlocked(int value)
		{
		}

		public static int IncrementAndSetFeaturesUnlocked(int increment = 1)
		{
			return 0;
		}
	}
}
