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
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static int DailyFreeChances
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int LastDailyFreeChancesDay
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static bool IsAllFree
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static Dictionary<int, int> CompletedDays
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static Dictionary<int, int> FailedDays
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static Dictionary<int, int> CompletedDaysNew
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

		private static BucketDailyChallenge GetBucket()
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

		public static int GetDailyFreeChances(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetDailyFreeChances(int value)
		{
		}

		public static int IncrementAndSetDailyFreeChances(int increment = 1)
		{
			return 0;
		}

		public static int GetLastDailyFreeChancesDay(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetLastDailyFreeChancesDay(int value)
		{
		}

		public static int IncrementAndSetLastDailyFreeChancesDay(int increment = 1)
		{
			return 0;
		}

		public static bool GetIsAllFree(bool defaultValue = false)
		{
			return false;
		}

		public static void SetIsAllFree(bool value)
		{
		}

		public static Dictionary<int, int> GetCompletedDays()
		{
			return null;
		}

		public static void SetCompletedDays(Dictionary<int, int> value)
		{
		}

		public static Dictionary<int, int> GetFailedDays()
		{
			return null;
		}

		public static void SetFailedDays(Dictionary<int, int> value)
		{
		}

		public static Dictionary<int, int> GetCompletedDaysNew()
		{
			return null;
		}

		public static void SetCompletedDaysNew(Dictionary<int, int> value)
		{
		}
	}
}
