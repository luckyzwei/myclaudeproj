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
			return null;
		}
		set
		{
		}
	}

	public static string PreviousWeekReward
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static long WeekExpiryDate
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public static bool MigrationShown
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool OfferPurchased
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static string DebugId
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static int CacheRank
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int CacheScore
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static bool WaitingServerNotification
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static long DownPeriodDate
	{
		get
		{
			return 0L;
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

	private static BucketWeeklyLeadeboard GetBucket()
	{
		return null;
	}

	public static string GetPendingReward(string defaultValue = null)
	{
		return null;
	}

	public static void SetPendingReward(string value)
	{
	}

	public static string GetPreviousWeekReward(string defaultValue = null)
	{
		return null;
	}

	public static void SetPreviousWeekReward(string value)
	{
	}

	public static long GetWeekExpiryDate(long defaultValue = 0L)
	{
		return 0L;
	}

	public static void SetWeekExpiryDate(long value)
	{
	}

	public static bool GetMigrationShown(bool defaultValue = false)
	{
		return false;
	}

	public static void SetMigrationShown(bool value)
	{
	}

	public static bool GetOfferPurchased(bool defaultValue = false)
	{
		return false;
	}

	public static void SetOfferPurchased(bool value)
	{
	}

	public static string GetDebugId(string defaultValue = null)
	{
		return null;
	}

	public static void SetDebugId(string value)
	{
	}

	public static int GetCacheRank(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetCacheRank(int value)
	{
	}

	public static int IncrementAndSetCacheRank(int increment = 1)
	{
		return 0;
	}

	public static int GetCacheScore(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetCacheScore(int value)
	{
	}

	public static int IncrementAndSetCacheScore(int increment = 1)
	{
		return 0;
	}

	public static bool GetWaitingServerNotification(bool defaultValue = false)
	{
		return false;
	}

	public static void SetWaitingServerNotification(bool value)
	{
	}

	public static long GetDownPeriodDate(long defaultValue = 0L)
	{
		return 0L;
	}

	public static void SetDownPeriodDate(long value)
	{
	}
}
