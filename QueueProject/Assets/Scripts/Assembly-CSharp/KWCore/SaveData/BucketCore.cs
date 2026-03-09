namespace KWCore.SaveData
{
	public class BucketCore : BucketBase
	{
		[KeyString]
		private const string COUNTRY_CODE = "COUNTRY_CODE";

		[KeyString]
		private const string STORE_COUNTRY_CODE = "STORE_COUNTRY_CODE";

		[KeyBool]
		private const string IDFA_HARD_ANSWERED = "IDFA_HARD_ANSWERED";

		[KeyBool]
		private const string IDFA_HARD_ACCEPTED = "IDFA_HARD_ACCEPTED";

		[KeyInt]
		private const string LAST_FIRED_AD_REVENUE_EVENT_THRESHOLD = "LAST_FIRED_AD_REVENUE_EVENT_THRESHOLD";

		[KeyInt]
		private const string LAST_FIRED_TOTAL_REVENUE_EVENT_THRESHOLD = "LAST_FIRED_TOTAL_REVENUE_EVENT_THRESHOLD";

		[KeyBool]
		public const string TERMS_OF_USE_ACCEPTED = "TERMS_OF_USE_ACCEPTED";

		[KeyString]
		public const string CURRENCY_CONVERSION_RATES = "CURRENCY_CONVERSION_RATES";

		[KeyBool]
		public const string SOCIAL_FOLLOW_SHOWN = "SOCIAL_FOLLOW_SHOWN";

		[KeyString]
		public const string CURRENCY_CODE = "CURRENCY_CODE";

		[KeyString]
		public const string BACKUP_CURRENCY_CONVERSION_RATES = "BACKUP_CURRENCY_CONVERSION_RATES";

		[KeyFloat]
		public const string CURRENCY_CONVERSION_MULTIPLIER = "CURRENCY_CONVERSION_MULTIPLIER";

		[KeyString]
		public const string LAST_CURRENCY_RATE_FETCHED_TIME = "LAST_CURRENCY_RATE_FETCHED_TIME";

		private static BucketCore s_bucketcore;

		public static string CountryCode
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static string StoreCountryCode
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool IdfaHardAnswered
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool IdfaHardAccepted
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static int LastFiredAdRevenueEventThreshold
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int LastFiredTotalRevenueEventThreshold
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static bool TermsOfUseAccepted
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static string CurrencyConversionRates
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool SocialFollowShown
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static string CurrencyCode
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static string BackupCurrencyConversionRates
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static float CurrencyConversionMultiplier
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static string LastCurrencyRateFetchedTime
		{
			get
			{
				return null;
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

		private static BucketCore GetBucket()
		{
			return null;
		}

		public static string GetCountryCode(string defaultValue = null)
		{
			return null;
		}

		public static void SetCountryCode(string value)
		{
		}

		public static string GetStoreCountryCode(string defaultValue = null)
		{
			return null;
		}

		public static void SetStoreCountryCode(string value)
		{
		}

		public static bool GetIdfaHardAnswered(bool defaultValue = false)
		{
			return false;
		}

		public static void SetIdfaHardAnswered(bool value)
		{
		}

		public static bool GetIdfaHardAccepted(bool defaultValue = false)
		{
			return false;
		}

		public static void SetIdfaHardAccepted(bool value)
		{
		}

		public static int GetLastFiredAdRevenueEventThreshold(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetLastFiredAdRevenueEventThreshold(int value)
		{
		}

		public static int IncrementAndSetLastFiredAdRevenueEventThreshold(int increment = 1)
		{
			return 0;
		}

		public static int GetLastFiredTotalRevenueEventThreshold(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetLastFiredTotalRevenueEventThreshold(int value)
		{
		}

		public static int IncrementAndSetLastFiredTotalRevenueEventThreshold(int increment = 1)
		{
			return 0;
		}

		public static bool GetTermsOfUseAccepted(bool defaultValue = false)
		{
			return false;
		}

		public static void SetTermsOfUseAccepted(bool value)
		{
		}

		public static string GetCurrencyConversionRates(string defaultValue = null)
		{
			return null;
		}

		public static void SetCurrencyConversionRates(string value)
		{
		}

		public static bool GetSocialFollowShown(bool defaultValue = false)
		{
			return false;
		}

		public static void SetSocialFollowShown(bool value)
		{
		}

		public static string GetCurrencyCode(string defaultValue = null)
		{
			return null;
		}

		public static void SetCurrencyCode(string value)
		{
		}

		public static string GetBackupCurrencyConversionRates(string defaultValue = null)
		{
			return null;
		}

		public static void SetBackupCurrencyConversionRates(string value)
		{
		}

		public static float GetCurrencyConversionMultiplier(float defaultValue = 0f)
		{
			return 0f;
		}

		public static void SetCurrencyConversionMultiplier(float value)
		{
		}

		public static string GetLastCurrencyRateFetchedTime(string defaultValue = null)
		{
			return null;
		}

		public static void SetLastCurrencyRateFetchedTime(string value)
		{
		}
	}
}
