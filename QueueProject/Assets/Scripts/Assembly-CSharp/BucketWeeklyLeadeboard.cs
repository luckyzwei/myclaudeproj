using KWCore;
using KWCore.SaveData;

public class BucketWeeklyLeadeboard : BucketBase
{
	private const string BUCKET_KEY = "BUCKET_WEEKLY_LEADERBOARD";

	[KeyString]
	public const string PENDING_REWARD = "pending_reward";

	[KeyString]
	public const string PREVIOUS_WEEK_REWARD = "previous_week_reward";

	[KeyLong]
	public const string WEEK_EXPIRY_DATE = "expiry_date";

	[KeyBool]
	public const string MIGRATION_SHOWN = "migration_shown";

	[KeyBool]
	public const string OFFER_PURCHASED = "offer_purchased";

	[KeyString]
	public const string DEBUG_ID = "debug_id";

	[KeyInt]
	public const string CACHE_RANK = "cache_rank";

	[KeyInt]
	public const string CACHE_SCORE = "cache_score";

	[KeyBool]
	public const string WAITING_SERVER_NOTIFICATION = "dirty_notification";

	[KeyLong]
	public const string DOWN_PERIOD_DATE = "down_period_date";

	private static BucketWeeklyLeadeboard s_bucketweeklyleadeboard;

	public static string PendingReward
	{
		get
		{
			return GetBucket()?.GetString(PENDING_REWARD, null) ?? null;
		}
		set
		{
			GetBucket()?.SetString(PENDING_REWARD, value);
		}
	}

	public static string PreviousWeekReward
	{
		get
		{
			return GetBucket()?.GetString(PREVIOUS_WEEK_REWARD, null) ?? null;
		}
		set
		{
			GetBucket()?.SetString(PREVIOUS_WEEK_REWARD, value);
		}
	}

	public static long WeekExpiryDate
	{
		get
		{
			return GetBucket()?.GetLong(WEEK_EXPIRY_DATE, 0L) ?? 0L;
		}
		set
		{
			GetBucket()?.SetLong(WEEK_EXPIRY_DATE, value);
		}
	}

	public static bool MigrationShown
	{
		get
		{
			return GetBucket()?.GetBool(MIGRATION_SHOWN, false) ?? false;
		}
		set
		{
			GetBucket()?.SetBool(MIGRATION_SHOWN, value);
		}
	}

	public static bool OfferPurchased
	{
		get
		{
			return GetBucket()?.GetBool(OFFER_PURCHASED, false) ?? false;
		}
		set
		{
			GetBucket()?.SetBool(OFFER_PURCHASED, value);
		}
	}

	public static string DebugId
	{
		get
		{
			return GetBucket()?.GetString(DEBUG_ID, null) ?? null;
		}
		set
		{
			GetBucket()?.SetString(DEBUG_ID, value);
		}
	}

	public static int CacheRank
	{
		get
		{
			return GetBucket()?.GetInt(CACHE_RANK, 0) ?? 0;
		}
		set
		{
			GetBucket()?.SetInt(CACHE_RANK, value);
		}
	}

	public static int CacheScore
	{
		get
		{
			return GetBucket()?.GetInt(CACHE_SCORE, 0) ?? 0;
		}
		set
		{
			GetBucket()?.SetInt(CACHE_SCORE, value);
		}
	}

	public static bool WaitingServerNotification
	{
		get
		{
			return GetBucket()?.GetBool(WAITING_SERVER_NOTIFICATION, false) ?? false;
		}
		set
		{
			GetBucket()?.SetBool(WAITING_SERVER_NOTIFICATION, value);
		}
	}

	public static long DownPeriodDate
	{
		get
		{
			return GetBucket()?.GetLong(DOWN_PERIOD_DATE, 0L) ?? 0L;
		}
		set
		{
			GetBucket()?.SetLong(DOWN_PERIOD_DATE, value);
		}
	}

	public override string GetBucketKey()
	{
		return BUCKET_KEY;
	}

	public override bool IsStoredInCloud()
	{
		return true;
	}

	private static BucketWeeklyLeadeboard GetBucket()
	{
		if (s_bucketweeklyleadeboard == null)
		{
			s_bucketweeklyleadeboard = new BucketWeeklyLeadeboard();
			s_bucketweeklyleadeboard.LoadFromDisk();
		}
		return s_bucketweeklyleadeboard;
	}

	public static string GetPendingReward(string defaultValue = null)
	{
		return GetBucket()?.GetString(PENDING_REWARD, defaultValue) ?? defaultValue;
	}

	public static void SetPendingReward(string value)
	{
		GetBucket()?.SetString(PENDING_REWARD, value);
	}

	public static string GetPreviousWeekReward(string defaultValue = null)
	{
		return GetBucket()?.GetString(PREVIOUS_WEEK_REWARD, defaultValue) ?? defaultValue;
	}

	public static void SetPreviousWeekReward(string value)
	{
		GetBucket()?.SetString(PREVIOUS_WEEK_REWARD, value);
	}

	public static long GetWeekExpiryDate(long defaultValue = 0L)
	{
		return GetBucket()?.GetLong(WEEK_EXPIRY_DATE, defaultValue) ?? defaultValue;
	}

	public static void SetWeekExpiryDate(long value)
	{
		GetBucket()?.SetLong(WEEK_EXPIRY_DATE, value);
	}

	public static bool GetMigrationShown(bool defaultValue = false)
	{
		return GetBucket()?.GetBool(MIGRATION_SHOWN, defaultValue) ?? defaultValue;
	}

	public static void SetMigrationShown(bool value)
	{
		GetBucket()?.SetBool(MIGRATION_SHOWN, value);
	}

	public static bool GetOfferPurchased(bool defaultValue = false)
	{
		return GetBucket()?.GetBool(OFFER_PURCHASED, defaultValue) ?? defaultValue;
	}

	public static void SetOfferPurchased(bool value)
	{
		GetBucket()?.SetBool(OFFER_PURCHASED, value);
	}

	public static string GetDebugId(string defaultValue = null)
	{
		return GetBucket()?.GetString(DEBUG_ID, defaultValue) ?? defaultValue;
	}

	public static void SetDebugId(string value)
	{
		GetBucket()?.SetString(DEBUG_ID, value);
	}

	public static int GetCacheRank(int defaultValue = 0)
	{
		return GetBucket()?.GetInt(CACHE_RANK, defaultValue) ?? defaultValue;
	}

	public static void SetCacheRank(int value)
	{
		GetBucket()?.SetInt(CACHE_RANK, value);
	}

	public static int IncrementAndSetCacheRank(int increment = 1)
	{
		return GetBucket()?.IncrementAndSetInt(CACHE_RANK, increment) ?? 0;
	}

	public static int GetCacheScore(int defaultValue = 0)
	{
		return GetBucket()?.GetInt(CACHE_SCORE, defaultValue) ?? defaultValue;
	}

	public static void SetCacheScore(int value)
	{
		GetBucket()?.SetInt(CACHE_SCORE, value);
	}

	public static int IncrementAndSetCacheScore(int increment = 1)
	{
		return GetBucket()?.IncrementAndSetInt(CACHE_SCORE, increment) ?? 0;
	}

	public static bool GetWaitingServerNotification(bool defaultValue = false)
	{
		return GetBucket()?.GetBool(WAITING_SERVER_NOTIFICATION, defaultValue) ?? defaultValue;
	}

	public static void SetWaitingServerNotification(bool value)
	{
		GetBucket()?.SetBool(WAITING_SERVER_NOTIFICATION, value);
	}

	public static long GetDownPeriodDate(long defaultValue = 0L)
	{
		return GetBucket()?.GetLong(DOWN_PERIOD_DATE, defaultValue) ?? defaultValue;
	}

	public static void SetDownPeriodDate(long value)
	{
		GetBucket()?.SetLong(DOWN_PERIOD_DATE, value);
	}
}
