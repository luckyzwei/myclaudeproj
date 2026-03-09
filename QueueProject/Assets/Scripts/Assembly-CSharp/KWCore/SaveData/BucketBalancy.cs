namespace KWCore.SaveData
{
	public class BucketBalancy : BucketBase
	{
		[KeyBool]
		public const string USE_LOCAL_TIME = "use_local_time";

		[KeyBool]
		public const string HAS_SHOWN_POPUP = "has_shown_popup";

		[KeyBool]
		public const string MIGRATION_DONE = "migration_done";

		[KeyBool]
		public const string TIMER_MIGRATION_DONE = "timer_migration_done";

		[SubkeyLong]
		public const string TIMER_START_TIME = "timer_start_time";

		[SubkeyLong]
		public const string TIMER_TOTAL_TIME = "timer_total_time";

		private static BucketBalancy s_bucketbalancy;

		public static bool UseLocalTime
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool HasShownPopup
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

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

		public static bool TimerMigrationDone
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

		public void MigrateFromBalancy()
		{
		}

		public void MigrateTimerDataFromBalancy()
		{
		}

		private static BucketBalancy GetBucket()
		{
			return null;
		}

		public static bool GetUseLocalTime(bool defaultValue = false)
		{
			return false;
		}

		public static void SetUseLocalTime(bool value)
		{
		}

		public static bool GetHasShownPopup(bool defaultValue = false)
		{
			return false;
		}

		public static void SetHasShownPopup(bool value)
		{
		}

		public static bool GetMigrationDone(bool defaultValue = false)
		{
			return false;
		}

		public static void SetMigrationDone(bool value)
		{
		}

		public static bool GetTimerMigrationDone(bool defaultValue = false)
		{
			return false;
		}

		public static void SetTimerMigrationDone(bool value)
		{
		}

		public static long GetTimerStartTime(string subkey, long defaultValue = 0L)
		{
			return 0L;
		}

		public static void SetTimerStartTime(string subkey, long value)
		{
		}

		public static long GetTimerTotalTime(string subkey, long defaultValue = 0L)
		{
			return 0L;
		}

		public static void SetTimerTotalTime(string subkey, long value)
		{
		}
	}
}
