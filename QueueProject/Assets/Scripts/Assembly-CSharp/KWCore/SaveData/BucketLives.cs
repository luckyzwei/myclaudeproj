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
			get { return GetBucket().GetInt(TOTAL_LIVES_LOST); }
			set { GetBucket().SetInt(TOTAL_LIVES_LOST, value); }
		}

		public override string GetBucketKey()
		{
			return BUCKET_KEY;
		}

		public override bool IsStoredInCloud()
		{
			return true;
		}

		private static BucketLives GetBucket()
		{
			if (s_bucketlives == null)
			{
				s_bucketlives = new BucketLives();
				s_bucketlives.LoadFromDisk();
			}
			return s_bucketlives;
		}

		public static int GetTotalLivesLost(int defaultValue = 0)
		{
			return GetBucket().GetInt(TOTAL_LIVES_LOST, defaultValue);
		}

		public static void SetTotalLivesLost(int value)
		{
			GetBucket().SetInt(TOTAL_LIVES_LOST, value);
			GetBucket().SaveToDisk();
		}

		public static int IncrementAndSetTotalLivesLost(int increment = 1)
		{
			int result = GetBucket().IncrementAndSetInt(TOTAL_LIVES_LOST, increment);
			GetBucket().SaveToDisk();
			return result;
		}
	}
}
