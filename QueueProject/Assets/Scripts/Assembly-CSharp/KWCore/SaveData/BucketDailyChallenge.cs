using System.Collections.Generic;

namespace KWCore.SaveData
{
	public class BucketDailyChallenge : BucketBase
	{
		private const string BUCKET_KEY = "BUCKET_DAILY_CHALLENGE";

		[KeyBool]
		public const string IS_MIGRATED = "is_migrated";

		[KeyInt]
		public const string DAILY_FREE_CHANCES = "daily_free_chances";

		[KeyInt]
		public const string LAST_DAILY_FREE_CHANCES_DAY = "last_daily_free_chances_day";

		[KeyBool]
		public const string IS_ALL_FREE = "is_all_free";

		[KeyDictionary(typeof(int), typeof(int))]
		public const string COMPLETED_DAYS = "completed_days";

		[KeyDictionary(typeof(int), typeof(int))]
		public const string FAILED_DAYS = "failed_days";

		[KeyDictionary(typeof(int), typeof(int))]
		public const string COMPLETED_DAYS_NEW = "completed_days_new";

		private static BucketDailyChallenge s_bucketdailychallenge;

		public static bool IsMigrated
		{
			get { return GetBucket().GetBool(IS_MIGRATED); }
			set { GetBucket().SetBool(IS_MIGRATED, value); }
		}

		public static int DailyFreeChances
		{
			get { return GetBucket().GetInt(DAILY_FREE_CHANCES); }
			set { GetBucket().SetInt(DAILY_FREE_CHANCES, value); }
		}

		public static int LastDailyFreeChancesDay
		{
			get { return GetBucket().GetInt(LAST_DAILY_FREE_CHANCES_DAY); }
			set { GetBucket().SetInt(LAST_DAILY_FREE_CHANCES_DAY, value); }
		}

		public static bool IsAllFree
		{
			get { return GetBucket().GetBool(IS_ALL_FREE); }
			set { GetBucket().SetBool(IS_ALL_FREE, value); }
		}

		public static Dictionary<int, int> CompletedDays
		{
			get { return GetBucket().GetDictionary<int, int>(COMPLETED_DAYS) ?? new Dictionary<int, int>(); }
			set { GetBucket().SetDictionary(COMPLETED_DAYS, value); }
		}

		public static Dictionary<int, int> FailedDays
		{
			get { return GetBucket().GetDictionary<int, int>(FAILED_DAYS) ?? new Dictionary<int, int>(); }
			set { GetBucket().SetDictionary(FAILED_DAYS, value); }
		}

		public static Dictionary<int, int> CompletedDaysNew
		{
			get { return GetBucket().GetDictionary<int, int>(COMPLETED_DAYS_NEW) ?? new Dictionary<int, int>(); }
			set { GetBucket().SetDictionary(COMPLETED_DAYS_NEW, value); }
		}

		public override string GetBucketKey()
		{
			return BUCKET_KEY;
		}

		public override bool IsStoredInCloud()
		{
			return true;
		}

		private static BucketDailyChallenge GetBucket()
		{
			if (s_bucketdailychallenge == null)
			{
				s_bucketdailychallenge = new BucketDailyChallenge();
				s_bucketdailychallenge.LoadFromDisk();
			}
			return s_bucketdailychallenge;
		}

		public static bool GetIsMigrated(bool defaultValue = false)
		{
			return GetBucket().GetBool(IS_MIGRATED, defaultValue);
		}

		public static void SetIsMigrated(bool value)
		{
			GetBucket().SetBool(IS_MIGRATED, value);
			GetBucket().SaveToDisk();
		}

		public static int GetDailyFreeChances(int defaultValue = 0)
		{
			return GetBucket().GetInt(DAILY_FREE_CHANCES, defaultValue);
		}

		public static void SetDailyFreeChances(int value)
		{
			GetBucket().SetInt(DAILY_FREE_CHANCES, value);
			GetBucket().SaveToDisk();
		}

		public static int IncrementAndSetDailyFreeChances(int increment = 1)
		{
			return GetBucket().IncrementAndSetInt(DAILY_FREE_CHANCES, increment);
		}

		public static int GetLastDailyFreeChancesDay(int defaultValue = 0)
		{
			return GetBucket().GetInt(LAST_DAILY_FREE_CHANCES_DAY, defaultValue);
		}

		public static void SetLastDailyFreeChancesDay(int value)
		{
			GetBucket().SetInt(LAST_DAILY_FREE_CHANCES_DAY, value);
			GetBucket().SaveToDisk();
		}

		public static int IncrementAndSetLastDailyFreeChancesDay(int increment = 1)
		{
			return GetBucket().IncrementAndSetInt(LAST_DAILY_FREE_CHANCES_DAY, increment);
		}

		public static bool GetIsAllFree(bool defaultValue = false)
		{
			return GetBucket().GetBool(IS_ALL_FREE, defaultValue);
		}

		public static void SetIsAllFree(bool value)
		{
			GetBucket().SetBool(IS_ALL_FREE, value);
			GetBucket().SaveToDisk();
		}

		public static Dictionary<int, int> GetCompletedDays()
		{
			return GetBucket().GetDictionary<int, int>(COMPLETED_DAYS) ?? new Dictionary<int, int>();
		}

		public static void SetCompletedDays(Dictionary<int, int> value)
		{
			GetBucket().SetDictionary(COMPLETED_DAYS, value);
			GetBucket().SaveToDisk();
		}

		public static Dictionary<int, int> GetFailedDays()
		{
			return GetBucket().GetDictionary<int, int>(FAILED_DAYS) ?? new Dictionary<int, int>();
		}

		public static void SetFailedDays(Dictionary<int, int> value)
		{
			GetBucket().SetDictionary(FAILED_DAYS, value);
			GetBucket().SaveToDisk();
		}

		public static Dictionary<int, int> GetCompletedDaysNew()
		{
			return GetBucket().GetDictionary<int, int>(COMPLETED_DAYS_NEW) ?? new Dictionary<int, int>();
		}

		public static void SetCompletedDaysNew(Dictionary<int, int> value)
		{
			GetBucket().SetDictionary(COMPLETED_DAYS_NEW, value);
			GetBucket().SaveToDisk();
		}
	}
}
