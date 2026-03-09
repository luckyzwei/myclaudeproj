namespace KWCore.SaveData
{
	public class BucketLives : BucketBase
	{
		private const string BUCKET_KEY = "BUCKET_LIVES";

		[KeyInt]
		public const string TOTAL_LIVES_LOST = "TOTAL_LIVES_LOST";

		private static BucketLives s_bucketlives;

		public static int TotalLivesLost
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

		private static BucketLives GetBucket()
		{
			return null;
		}

		public static int GetTotalLivesLost(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetTotalLivesLost(int value)
		{
		}

		public static int IncrementAndSetTotalLivesLost(int increment = 1)
		{
			return 0;
		}
	}
}
