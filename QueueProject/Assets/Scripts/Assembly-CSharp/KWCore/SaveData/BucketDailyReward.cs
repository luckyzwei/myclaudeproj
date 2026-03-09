namespace KWCore.SaveData
{
	public class BucketDailyReward : BucketBase
	{
		private const string BUCKET_KEY = "BUCKET_DAILY_REWARDS";

		[KeyBool]
		public const string MIGRATION_DONE = "migration_done";

		[KeyInt]
		public const string CONSECUTIVE_DAYS = "CONSECUTIVE_DAYS";

		[KeyInt]
		public const string MAX_CONSECUTIVE_DAYS = "MAX_CONSECUTIVE_DAYS";

		[KeyLong]
		public const string LAST_ADMIN_DAY_REWARD_OBTAINED = "LAST_ADMIN_DAY_REWARD_OBTAINED";

		[KeyInt]
		public const string DAILY_REWARD_INDEX = "DAILY_REWARD_INDEX";

		[KeyInt]
		public const string WEEK_INDEX = "WEEK_INDEX";

		[KeyInt]
		public const string NUM_CLAIMED_TODAY = "NUM_CLAIMED_TODAY";

		private static BucketDailyReward s_bucketdailyreward;

		public static bool MigrationDone
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static int ConsecutiveDays
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int MaxConsecutiveDays
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static long LastAdminDayRewardObtained
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public static int DailyRewardIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int WeekIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int NumClaimedToday
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

		public void MigrateFromBalancy()
		{
		}

		private static BucketDailyReward GetBucket()
		{
			return null;
		}

		public static bool GetMigrationDone(bool defaultValue = false)
		{
			return false;
		}

		public static void SetMigrationDone(bool value)
		{
		}

		public static int GetConsecutiveDays(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetConsecutiveDays(int value)
		{
		}

		public static int IncrementAndSetConsecutiveDays(int increment = 1)
		{
			return 0;
		}

		public static int GetMaxConsecutiveDays(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetMaxConsecutiveDays(int value)
		{
		}

		public static int IncrementAndSetMaxConsecutiveDays(int increment = 1)
		{
			return 0;
		}

		public static long GetLastAdminDayRewardObtained(long defaultValue = 0L)
		{
			return 0L;
		}

		public static void SetLastAdminDayRewardObtained(long value)
		{
		}

		public static int GetDailyRewardIndex(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetDailyRewardIndex(int value)
		{
		}

		public static int IncrementAndSetDailyRewardIndex(int increment = 1)
		{
			return 0;
		}

		public static int GetWeekIndex(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetWeekIndex(int value)
		{
		}

		public static int IncrementAndSetWeekIndex(int increment = 1)
		{
			return 0;
		}

		public static int GetNumClaimedToday(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetNumClaimedToday(int value)
		{
		}

		public static int IncrementAndSetNumClaimedToday(int increment = 1)
		{
			return 0;
		}
	}
}
