namespace KWCore.SaveData
{
	public class BucketAds : BucketBase
	{
		[KeyInt]
		private const string CUSTOM_FIREBASE_AD_COUNT = "custom_firebase_ad";

		[KeyFloat]
		private const string TOTAL_INT_IMPRESSIONS_REVENUE = "total_int_impressions_revenue";

		[KeyInt]
		private const string TOTAL_INT_IMPRESSIONS_WATCHED = "total_int_impressions_watched";

		[KeyString]
		private const string LAST_INT_REPLACED_BY_RV_DATE = "last_int_replaced_by_rv_date";

		[KeyInt]
		private const string DAILY_INT_REPLACED_BY_RV = "daily_int_replaced_by_rv";

		[KeyInt]
		private const string RV_FILL_DAILY_COUNT = "rv_fill_daily_count";

		private static BucketAds s_bucketads;

		public static int CustomFirebaseAdCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static float TotalIntImpressionsRevenue
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static int TotalIntImpressionsWatched
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static string LastIntReplacedByRvDate
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static int DailyIntReplacedByRv
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int RvFillDailyCount
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

		private static BucketAds GetBucket()
		{
			return null;
		}

		public static int GetCustomFirebaseAdCount(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetCustomFirebaseAdCount(int value)
		{
		}

		public static int IncrementAndSetCustomFirebaseAdCount(int increment = 1)
		{
			return 0;
		}

		public static float GetTotalIntImpressionsRevenue(float defaultValue = 0f)
		{
			return 0f;
		}

		public static void SetTotalIntImpressionsRevenue(float value)
		{
		}

		public static int GetTotalIntImpressionsWatched(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetTotalIntImpressionsWatched(int value)
		{
		}

		public static int IncrementAndSetTotalIntImpressionsWatched(int increment = 1)
		{
			return 0;
		}

		public static string GetLastIntReplacedByRvDate(string defaultValue = null)
		{
			return null;
		}

		public static void SetLastIntReplacedByRvDate(string value)
		{
		}

		public static int GetDailyIntReplacedByRv(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetDailyIntReplacedByRv(int value)
		{
		}

		public static int IncrementAndSetDailyIntReplacedByRv(int increment = 1)
		{
			return 0;
		}

		public static int GetRvFillDailyCount(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetRvFillDailyCount(int value)
		{
		}

		public static int IncrementAndSetRvFillDailyCount(int increment = 1)
		{
			return 0;
		}
	}
}
