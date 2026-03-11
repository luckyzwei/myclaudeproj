namespace KWCore.SaveData
{
	public class BucketCore : BucketBase
	{
		private const string BUCKET_KEY = "BUCKET_CORE";

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
			get { return GetBucket().GetString(COUNTRY_CODE); }
			set { GetBucket().SetString(COUNTRY_CODE, value); }
		}

		public static string StoreCountryCode
		{
			get { return GetBucket().GetString(STORE_COUNTRY_CODE); }
			set { GetBucket().SetString(STORE_COUNTRY_CODE, value); }
		}

		public static bool IdfaHardAnswered
		{
			get { return GetBucket().GetBool(IDFA_HARD_ANSWERED); }
			set { GetBucket().SetBool(IDFA_HARD_ANSWERED, value); }
		}

		public static bool IdfaHardAccepted
		{
			get { return GetBucket().GetBool(IDFA_HARD_ACCEPTED); }
			set { GetBucket().SetBool(IDFA_HARD_ACCEPTED, value); }
		}

		public static int LastFiredAdRevenueEventThreshold
		{
			get { return GetBucket().GetInt(LAST_FIRED_AD_REVENUE_EVENT_THRESHOLD); }
			set { GetBucket().SetInt(LAST_FIRED_AD_REVENUE_EVENT_THRESHOLD, value); }
		}

		public static int LastFiredTotalRevenueEventThreshold
		{
			get { return GetBucket().GetInt(LAST_FIRED_TOTAL_REVENUE_EVENT_THRESHOLD); }
			set { GetBucket().SetInt(LAST_FIRED_TOTAL_REVENUE_EVENT_THRESHOLD, value); }
		}

		public static bool TermsOfUseAccepted
		{
			get { return GetBucket().GetBool(TERMS_OF_USE_ACCEPTED); }
			set { GetBucket().SetBool(TERMS_OF_USE_ACCEPTED, value); }
		}

		public static string CurrencyConversionRates
		{
			get { return GetBucket().GetString(CURRENCY_CONVERSION_RATES); }
			set { GetBucket().SetString(CURRENCY_CONVERSION_RATES, value); }
		}

		public static bool SocialFollowShown
		{
			get { return GetBucket().GetBool(SOCIAL_FOLLOW_SHOWN); }
			set { GetBucket().SetBool(SOCIAL_FOLLOW_SHOWN, value); }
		}

		public static string CurrencyCode
		{
			get { return GetBucket().GetString(CURRENCY_CODE); }
			set { GetBucket().SetString(CURRENCY_CODE, value); }
		}

		public static string BackupCurrencyConversionRates
		{
			get { return GetBucket().GetString(BACKUP_CURRENCY_CONVERSION_RATES); }
			set { GetBucket().SetString(BACKUP_CURRENCY_CONVERSION_RATES, value); }
		}

		public static float CurrencyConversionMultiplier
		{
			get { return GetBucket().GetFloat(CURRENCY_CONVERSION_MULTIPLIER); }
			set { GetBucket().SetFloat(CURRENCY_CONVERSION_MULTIPLIER, value); }
		}

		public static string LastCurrencyRateFetchedTime
		{
			get { return GetBucket().GetString(LAST_CURRENCY_RATE_FETCHED_TIME); }
			set { GetBucket().SetString(LAST_CURRENCY_RATE_FETCHED_TIME, value); }
		}

		public override string GetBucketKey()
		{
			return BUCKET_KEY;
		}

		public override bool IsStoredInCloud()
		{
			return true;
		}

		private static BucketCore GetBucket()
		{
			if (s_bucketcore == null)
			{
				s_bucketcore = new BucketCore();
				s_bucketcore.LoadFromDisk();
			}
			return s_bucketcore;
		}

		public static string GetCountryCode(string defaultValue = null)
		{
			return GetBucket().GetString(COUNTRY_CODE, defaultValue);
		}

		public static void SetCountryCode(string value)
		{
			GetBucket().SetString(COUNTRY_CODE, value);
			GetBucket().SaveToDisk();
		}

		public static string GetStoreCountryCode(string defaultValue = null)
		{
			return GetBucket().GetString(STORE_COUNTRY_CODE, defaultValue);
		}

		public static void SetStoreCountryCode(string value)
		{
			GetBucket().SetString(STORE_COUNTRY_CODE, value);
			GetBucket().SaveToDisk();
		}

		public static bool GetIdfaHardAnswered(bool defaultValue = false)
		{
			return GetBucket().GetBool(IDFA_HARD_ANSWERED, defaultValue);
		}

		public static void SetIdfaHardAnswered(bool value)
		{
			GetBucket().SetBool(IDFA_HARD_ANSWERED, value);
			GetBucket().SaveToDisk();
		}

		public static bool GetIdfaHardAccepted(bool defaultValue = false)
		{
			return GetBucket().GetBool(IDFA_HARD_ACCEPTED, defaultValue);
		}

		public static void SetIdfaHardAccepted(bool value)
		{
			GetBucket().SetBool(IDFA_HARD_ACCEPTED, value);
			GetBucket().SaveToDisk();
		}

		public static int GetLastFiredAdRevenueEventThreshold(int defaultValue = 0)
		{
			return GetBucket().GetInt(LAST_FIRED_AD_REVENUE_EVENT_THRESHOLD, defaultValue);
		}

		public static void SetLastFiredAdRevenueEventThreshold(int value)
		{
			GetBucket().SetInt(LAST_FIRED_AD_REVENUE_EVENT_THRESHOLD, value);
			GetBucket().SaveToDisk();
		}

		public static int IncrementAndSetLastFiredAdRevenueEventThreshold(int increment = 1)
		{
			return GetBucket().IncrementAndSetInt(LAST_FIRED_AD_REVENUE_EVENT_THRESHOLD, increment);
		}

		public static int GetLastFiredTotalRevenueEventThreshold(int defaultValue = 0)
		{
			return GetBucket().GetInt(LAST_FIRED_TOTAL_REVENUE_EVENT_THRESHOLD, defaultValue);
		}

		public static void SetLastFiredTotalRevenueEventThreshold(int value)
		{
			GetBucket().SetInt(LAST_FIRED_TOTAL_REVENUE_EVENT_THRESHOLD, value);
			GetBucket().SaveToDisk();
		}

		public static int IncrementAndSetLastFiredTotalRevenueEventThreshold(int increment = 1)
		{
			return GetBucket().IncrementAndSetInt(LAST_FIRED_TOTAL_REVENUE_EVENT_THRESHOLD, increment);
		}

		public static bool GetTermsOfUseAccepted(bool defaultValue = false)
		{
			return GetBucket().GetBool(TERMS_OF_USE_ACCEPTED, defaultValue);
		}

		public static void SetTermsOfUseAccepted(bool value)
		{
			GetBucket().SetBool(TERMS_OF_USE_ACCEPTED, value);
			GetBucket().SaveToDisk();
		}

		public static string GetCurrencyConversionRates(string defaultValue = null)
		{
			return GetBucket().GetString(CURRENCY_CONVERSION_RATES, defaultValue);
		}

		public static void SetCurrencyConversionRates(string value)
		{
			GetBucket().SetString(CURRENCY_CONVERSION_RATES, value);
			GetBucket().SaveToDisk();
		}

		public static bool GetSocialFollowShown(bool defaultValue = false)
		{
			return GetBucket().GetBool(SOCIAL_FOLLOW_SHOWN, defaultValue);
		}

		public static void SetSocialFollowShown(bool value)
		{
			GetBucket().SetBool(SOCIAL_FOLLOW_SHOWN, value);
			GetBucket().SaveToDisk();
		}

		public static string GetCurrencyCode(string defaultValue = null)
		{
			return GetBucket().GetString(CURRENCY_CODE, defaultValue);
		}

		public static void SetCurrencyCode(string value)
		{
			GetBucket().SetString(CURRENCY_CODE, value);
			GetBucket().SaveToDisk();
		}

		public static string GetBackupCurrencyConversionRates(string defaultValue = null)
		{
			return GetBucket().GetString(BACKUP_CURRENCY_CONVERSION_RATES, defaultValue);
		}

		public static void SetBackupCurrencyConversionRates(string value)
		{
			GetBucket().SetString(BACKUP_CURRENCY_CONVERSION_RATES, value);
			GetBucket().SaveToDisk();
		}

		public static float GetCurrencyConversionMultiplier(float defaultValue = 0f)
		{
			return GetBucket().GetFloat(CURRENCY_CONVERSION_MULTIPLIER, defaultValue);
		}

		public static void SetCurrencyConversionMultiplier(float value)
		{
			GetBucket().SetFloat(CURRENCY_CONVERSION_MULTIPLIER, value);
			GetBucket().SaveToDisk();
		}

		public static string GetLastCurrencyRateFetchedTime(string defaultValue = null)
		{
			return GetBucket().GetString(LAST_CURRENCY_RATE_FETCHED_TIME, defaultValue);
		}

		public static void SetLastCurrencyRateFetchedTime(string value)
		{
			GetBucket().SetString(LAST_CURRENCY_RATE_FETCHED_TIME, value);
			GetBucket().SaveToDisk();
		}
	}
}
