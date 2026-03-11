namespace KWCore.SaveData
{
	public class BucketGameCore : BucketBase
	{
		private const string BUCKET_KEY = "BUCKET_GAME_CORE";

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
			get { return GetBucket().GetInt(PROGRESS_MANAGER_LEVEL_INDEX); }
			set { GetBucket().SetInt(PROGRESS_MANAGER_LEVEL_INDEX, value); }
		}

		public static int ProgressManagerStageIndex
		{
			get { return GetBucket().GetInt(PROGRESS_MANAGER_STAGE_INDEX); }
			set { GetBucket().SetInt(PROGRESS_MANAGER_STAGE_INDEX, value); }
		}

		public static long CurrentLevelDuration
		{
			get { return GetBucket().GetLong(CURRENT_LEVEL_DURATION); }
			set { GetBucket().SetLong(CURRENT_LEVEL_DURATION, value); }
		}

		public static long CurrentLevelAdWatchedDuration
		{
			get { return GetBucket().GetLong(CURRENT_LEVEL_AD_WATCHED_DURATION); }
			set { GetBucket().SetLong(CURRENT_LEVEL_AD_WATCHED_DURATION, value); }
		}

		public static bool LastStageCompleted
		{
			get { return GetBucket().GetBool(LAST_STAGE_COMPLETED); }
			set { GetBucket().SetBool(LAST_STAGE_COMPLETED, value); }
		}

		public static int LastActiveProgressManagerLevelIndex
		{
			get { return GetBucket().GetInt(LAST_ACTIVE_PROGRESS_MANAGER_LEVEL_INDEX); }
			set { GetBucket().SetInt(LAST_ACTIVE_PROGRESS_MANAGER_LEVEL_INDEX, value); }
		}

		public static int LastActiveProgressManagerStageIndex
		{
			get { return GetBucket().GetInt(LAST_ACTIVE_PROGRESS_MANAGER_STAGE_INDEX); }
			set { GetBucket().SetInt(LAST_ACTIVE_PROGRESS_MANAGER_STAGE_INDEX, value); }
		}

		public static string LevelClientId
		{
			get { return GetBucket().GetString(LEVEL_CLIENT_ID); }
			set { GetBucket().SetString(LEVEL_CLIENT_ID, value); }
		}

		public override string GetBucketKey()
		{
			return BUCKET_KEY;
		}

		public override bool IsStoredInCloud()
		{
			return true;
		}

		private static BucketGameCore GetBucket()
		{
			if (s_bucketgamecore == null)
			{
				s_bucketgamecore = new BucketGameCore();
				s_bucketgamecore.LoadFromDisk();
			}
			return s_bucketgamecore;
		}

		public static int GetProgressManagerLevelIndex(int defaultValue = 0)
		{
			return GetBucket().GetInt(PROGRESS_MANAGER_LEVEL_INDEX, defaultValue);
		}

		public static void SetProgressManagerLevelIndex(int value)
		{
			GetBucket().SetInt(PROGRESS_MANAGER_LEVEL_INDEX, value);
			GetBucket().SaveToDisk();
		}

		public static int IncrementAndSetProgressManagerLevelIndex(int increment = 1)
		{
			int result = GetBucket().IncrementAndSetInt(PROGRESS_MANAGER_LEVEL_INDEX, increment);
			GetBucket().SaveToDisk();
			return result;
		}

		public static int GetProgressManagerStageIndex(int defaultValue = 0)
		{
			return GetBucket().GetInt(PROGRESS_MANAGER_STAGE_INDEX, defaultValue);
		}

		public static void SetProgressManagerStageIndex(int value)
		{
			GetBucket().SetInt(PROGRESS_MANAGER_STAGE_INDEX, value);
			GetBucket().SaveToDisk();
		}

		public static int IncrementAndSetProgressManagerStageIndex(int increment = 1)
		{
			int result = GetBucket().IncrementAndSetInt(PROGRESS_MANAGER_STAGE_INDEX, increment);
			GetBucket().SaveToDisk();
			return result;
		}

		public static long GetCurrentLevelDuration(long defaultValue = 0L)
		{
			return GetBucket().GetLong(CURRENT_LEVEL_DURATION, defaultValue);
		}

		public static void SetCurrentLevelDuration(long value)
		{
			GetBucket().SetLong(CURRENT_LEVEL_DURATION, value);
			GetBucket().SaveToDisk();
		}

		public static long GetCurrentLevelAdWatchedDuration(long defaultValue = 0L)
		{
			return GetBucket().GetLong(CURRENT_LEVEL_AD_WATCHED_DURATION, defaultValue);
		}

		public static void SetCurrentLevelAdWatchedDuration(long value)
		{
			GetBucket().SetLong(CURRENT_LEVEL_AD_WATCHED_DURATION, value);
			GetBucket().SaveToDisk();
		}

		public static bool GetLastStageCompleted(bool defaultValue = false)
		{
			return GetBucket().GetBool(LAST_STAGE_COMPLETED, defaultValue);
		}

		public static void SetLastStageCompleted(bool value)
		{
			GetBucket().SetBool(LAST_STAGE_COMPLETED, value);
			GetBucket().SaveToDisk();
		}

		public static long GetSimpleBankMoneyCore(string subkey, long defaultValue = 0L)
		{
			return GetBucket().GetLong(SIMPLE_BANK_MONEY_CORE, defaultValue, subkey);
		}

		public static void SetSimpleBankMoneyCore(string subkey, long value)
		{
			GetBucket().SetLong(SIMPLE_BANK_MONEY_CORE, value, subkey);
			GetBucket().SaveToDisk();
		}

		public static int GetLastActiveProgressManagerLevelIndex(int defaultValue = 0)
		{
			return GetBucket().GetInt(LAST_ACTIVE_PROGRESS_MANAGER_LEVEL_INDEX, defaultValue);
		}

		public static void SetLastActiveProgressManagerLevelIndex(int value)
		{
			GetBucket().SetInt(LAST_ACTIVE_PROGRESS_MANAGER_LEVEL_INDEX, value);
			GetBucket().SaveToDisk();
		}

		public static int IncrementAndSetLastActiveProgressManagerLevelIndex(int increment = 1)
		{
			int result = GetBucket().IncrementAndSetInt(LAST_ACTIVE_PROGRESS_MANAGER_LEVEL_INDEX, increment);
			GetBucket().SaveToDisk();
			return result;
		}

		public static int GetLastActiveProgressManagerStageIndex(int defaultValue = 0)
		{
			return GetBucket().GetInt(LAST_ACTIVE_PROGRESS_MANAGER_STAGE_INDEX, defaultValue);
		}

		public static void SetLastActiveProgressManagerStageIndex(int value)
		{
			GetBucket().SetInt(LAST_ACTIVE_PROGRESS_MANAGER_STAGE_INDEX, value);
			GetBucket().SaveToDisk();
		}

		public static int IncrementAndSetLastActiveProgressManagerStageIndex(int increment = 1)
		{
			int result = GetBucket().IncrementAndSetInt(LAST_ACTIVE_PROGRESS_MANAGER_STAGE_INDEX, increment);
			GetBucket().SaveToDisk();
			return result;
		}

		public static int GetLevelAttemptCount(string subkey, int defaultValue = 0)
		{
			return GetBucket().GetInt(LEVEL_ATTEMPT_COUNT, defaultValue, subkey);
		}

		public static void SetLevelAttemptCount(string subkey, int value)
		{
			GetBucket().SetInt(LEVEL_ATTEMPT_COUNT, value, subkey);
			GetBucket().SaveToDisk();
		}

		public static int IncrementAndSetLevelAttemptCount(string subkey, int increment = 1)
		{
			int result = GetBucket().IncrementAndSetInt(LEVEL_ATTEMPT_COUNT, increment, subkey);
			GetBucket().SaveToDisk();
			return result;
		}

		public static string GetLevelAttemptId(string subkey, string defaultValue = null)
		{
			return GetBucket().GetString(LEVEL_ATTEMPT_ID, defaultValue, subkey);
		}

		public static void SetLevelAttemptId(string subkey, string value)
		{
			GetBucket().SetString(LEVEL_ATTEMPT_ID, value, subkey);
			GetBucket().SaveToDisk();
		}

		public static string GetLevelClientId(string defaultValue = null)
		{
			return GetBucket().GetString(LEVEL_CLIENT_ID, defaultValue);
		}

		public static void SetLevelClientId(string value)
		{
			GetBucket().SetString(LEVEL_CLIENT_ID, value);
			GetBucket().SaveToDisk();
		}
	}
}
