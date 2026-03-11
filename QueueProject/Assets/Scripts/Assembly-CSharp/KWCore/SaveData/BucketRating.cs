namespace KWCore.SaveData
{
	public class BucketRating : BucketBase
	{
		private const string BUCKET_KEY = "BUCKET_RATING";

		[KeyBool]
		private const string RATING_SHOWN = "RATING_SHOWN";

		private static BucketRating s_bucketrating;

		public static bool RatingShown
		{
			get { return GetBucket().GetBool(RATING_SHOWN); }
			set { GetBucket().SetBool(RATING_SHOWN, value); }
		}

		public override string GetBucketKey()
		{
			return BUCKET_KEY;
		}

		public override bool IsStoredInCloud()
		{
			return false;
		}

		private static BucketRating GetBucket()
		{
			if (s_bucketrating == null)
			{
				s_bucketrating = new BucketRating();
				s_bucketrating.LoadFromDisk();
			}
			return s_bucketrating;
		}

		public static bool GetRatingShown(bool defaultValue = false)
		{
			return GetBucket().GetBool(RATING_SHOWN, defaultValue);
		}

		public static void SetRatingShown(bool value)
		{
			GetBucket().SetBool(RATING_SHOWN, value);
			GetBucket().SaveToDisk();
		}
	}
}
