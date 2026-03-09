namespace KWCore.SaveData
{
	public class BucketRating : BucketBase
	{
		[KeyBool]
		private const string RATING_SHOWN = "RATING_SHOWN";

		private static BucketRating s_bucketrating;

		public static bool RatingShown
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

		private static BucketRating GetBucket()
		{
			return null;
		}

		public static bool GetRatingShown(bool defaultValue = false)
		{
			return false;
		}

		public static void SetRatingShown(bool value)
		{
		}
	}
}
