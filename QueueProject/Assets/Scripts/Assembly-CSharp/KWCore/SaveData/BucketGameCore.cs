namespace KWCore.SaveData
{
	public class BucketGameCore : BucketBase
	{
		[KeyInt]
		private const string PROGRESS_MANAGER_LEVEL_INDEX = "progress_manager_level_index";

		[KeyInt]
		private const string PROGRESS_MANAGER_STAGE_INDEX = "progress_manager_stage_index";

		[KeyLong]
		private const string CURRENT_LEVEL_DURATION = "current_level_duration";

		[KeyLong]
		private const string CURRENT_LEVEL_AD_WATCHED_DURATION = "current_level_ad_watched_duration";

		[KeyBool]
		private const string LAST_STAGE_COMPLETED = "last_stage_completed";

		[SubkeyLong]
		public const string SIMPLE_BANK_MONEY_CORE = "simple_bank_money_core";

		[KeyInt]
		private const string LAST_ACTIVE_PROGRESS_MANAGER_LEVEL_INDEX = "last_active_progress_manager_level_index";

		[KeyInt]
		private const string LAST_ACTIVE_PROGRESS_MANAGER_STAGE_INDEX = "last_active_progress_manager_stage_index";

		[SubkeyInt]
		private const string LEVEL_ATTEMPT_COUNT = "LEVEL_ATTEMPT_COUNT";

		[SubkeyString]
		private const string LEVEL_ATTEMPT_ID = "LEVEL_ATTEMPT_ID";

		[KeyString]
		private const string LEVEL_CLIENT_ID = "CURRENT_CLIENT_ID";

		private static BucketGameCore s_bucketgamecore;

		public static int ProgressManagerLevelIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int ProgressManagerStageIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static long CurrentLevelDuration
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public static long CurrentLevelAdWatchedDuration
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public static bool LastStageCompleted
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static int LastActiveProgressManagerLevelIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int LastActiveProgressManagerStageIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static string LevelClientId
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

		private static BucketGameCore GetBucket()
		{
			return null;
		}

		public static int GetProgressManagerLevelIndex(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetProgressManagerLevelIndex(int value)
		{
		}

		public static int IncrementAndSetProgressManagerLevelIndex(int increment = 1)
		{
			return 0;
		}

		public static int GetProgressManagerStageIndex(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetProgressManagerStageIndex(int value)
		{
		}

		public static int IncrementAndSetProgressManagerStageIndex(int increment = 1)
		{
			return 0;
		}

		public static long GetCurrentLevelDuration(long defaultValue = 0L)
		{
			return 0L;
		}

		public static void SetCurrentLevelDuration(long value)
		{
		}

		public static long GetCurrentLevelAdWatchedDuration(long defaultValue = 0L)
		{
			return 0L;
		}

		public static void SetCurrentLevelAdWatchedDuration(long value)
		{
		}

		public static bool GetLastStageCompleted(bool defaultValue = false)
		{
			return false;
		}

		public static void SetLastStageCompleted(bool value)
		{
		}

		public static long GetSimpleBankMoneyCore(string subkey, long defaultValue = 0L)
		{
			return 0L;
		}

		public static void SetSimpleBankMoneyCore(string subkey, long value)
		{
		}

		public static int GetLastActiveProgressManagerLevelIndex(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetLastActiveProgressManagerLevelIndex(int value)
		{
		}

		public static int IncrementAndSetLastActiveProgressManagerLevelIndex(int increment = 1)
		{
			return 0;
		}

		public static int GetLastActiveProgressManagerStageIndex(int defaultValue = 0)
		{
			return 0;
		}

		public static void SetLastActiveProgressManagerStageIndex(int value)
		{
		}

		public static int IncrementAndSetLastActiveProgressManagerStageIndex(int increment = 1)
		{
			return 0;
		}

		public static int GetLevelAttemptCount(string subkey, int defaultValue = 0)
		{
			return 0;
		}

		public static void SetLevelAttemptCount(string subkey, int value)
		{
		}

		public static int IncrementAndSetLevelAttemptCount(string subkey, int increment = 1)
		{
			return 0;
		}

		public static string GetLevelAttemptId(string subkey, string defaultValue = null)
		{
			return null;
		}

		public static void SetLevelAttemptId(string subkey, string value)
		{
		}

		public static string GetLevelClientId(string defaultValue = null)
		{
			return null;
		}

		public static void SetLevelClientId(string value)
		{
		}
	}
}
