namespace KWCore.SaveData
{
	public class BucketAttribution : BucketBase
	{
		[KeyBool]
		private const string MIGRATED_TO_APPSFLYER = "migrated_to_appsflyer";

		[KeyInt]
		public const string LAST_AD_REVENUE_OVER_CENTS_THRESHOLD = "last_ad_revenue_over_cents_threshold";

		[KeyInt]
		public const string LAST_FIRED_REVENUE_THRESHOLD = "last_fired_revenue_threshold";

		[KeyBool]
		public const string HAS_SENT_CONVERSION_EVENT = "has_sent_conversion_event";

		[KeyBool]
		private const string SENT_APPSFLYER_ID_EVENT = "sent_appsflyer_id_event";

		private static BucketAttribution s_bucketattribution;

		public static bool MigratedToAppsflyer
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static int LastAdRevenueOverCentsThreshold
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int LastFiredRevenueThreshold
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static bool HasSentConversionEvent
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool SentAppsflyerIdEvent
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

		private static BucketAttribution GetBucket()
		{
			return null;
		}

		public static bool GetMigratedToAppsflyer(bool defaultValue = false)
		{
			return false;
		}

		public static void SetMigratedToAppsflyer(bool value)
		{
		}

		public static int GetLastAdRevenueOverCentsThreshold(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetLastAdRevenueOverCentsThreshold(int value)
		{
		}

		public static int IncrementAndSetLastAdRevenueOverCentsThreshold(int increment = 1)
		{
			return 0;
		}

		public static int GetLastFiredRevenueThreshold(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetLastFiredRevenueThreshold(int value)
		{
		}

		public static int IncrementAndSetLastFiredRevenueThreshold(int increment = 1)
		{
			return 0;
		}

		public static bool GetHasSentConversionEvent(bool defaultValue = false)
		{
			return false;
		}

		public static void SetHasSentConversionEvent(bool value)
		{
		}

		public static bool GetSentAppsflyerIdEvent(bool defaultValue = false)
		{
			return false;
		}

		public static void SetSentAppsflyerIdEvent(bool value)
		{
		}
	}
}
