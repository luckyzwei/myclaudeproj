using System.Collections.Generic;
using KWCore;
using KWCore.SaveData;

public class BucketDailyWinStreak : BucketBase
{
	private const string BUCKET_KEY = "BUCKET_DAILY_WIN_STREAK";

	[KeyInt]
	public const string WIN_STREAK = "win_streak";

	[KeyInt]
	public const string MAX_WIN_STREAK = "max_win_streak";

	[KeyLong]
	public const string LAST_WIN_TIMESTAMP = "last_win_timestamp";

	[KeyList(typeof(int))]
	public const string WIN_STREAK_HISTORY = "win_streak_history";

	[KeyInt]
	public const string TOTAL_WINS = "total_wins";

	[KeyInt]
	public const string TOTAL_LOSSES = "total_losses";

	[SubkeyBool]
	public const string MILESTONE = "milestone";

	[KeyLong]
	public const string LAST_HISTORY_UPDATE_TIMESTAMP = "last_history_update_timestamp";

	[KeyString]
	public const string LAST_REPAIR_DATE = "last_repair_date";

	private static BucketDailyWinStreak s_bucketdailywinstreak;

	public static int WinStreak
	{
		get
		{
			return GetBucket()?.GetInt(WIN_STREAK, 0) ?? 0;
		}
		set
		{
			GetBucket()?.SetInt(WIN_STREAK, value);
		}
	}

	public static int MaxWinStreak
	{
		get
		{
			return GetBucket()?.GetInt(MAX_WIN_STREAK, 0) ?? 0;
		}
		set
		{
			GetBucket()?.SetInt(MAX_WIN_STREAK, value);
		}
	}

	public static long LastWinTimestamp
	{
		get
		{
			return GetBucket()?.GetLong(LAST_WIN_TIMESTAMP, 0L) ?? 0L;
		}
		set
		{
			GetBucket()?.SetLong(LAST_WIN_TIMESTAMP, value);
		}
	}

	public static List<int> WinStreakHistory
	{
		get
		{
			return GetBucket()?.GetList<int>(WIN_STREAK_HISTORY);
		}
		set
		{
			GetBucket()?.SetList(WIN_STREAK_HISTORY, value);
		}
	}

	public static int TotalWins
	{
		get
		{
			return GetBucket()?.GetInt(TOTAL_WINS, 0) ?? 0;
		}
		set
		{
			GetBucket()?.SetInt(TOTAL_WINS, value);
		}
	}

	public static int TotalLosses
	{
		get
		{
			return GetBucket()?.GetInt(TOTAL_LOSSES, 0) ?? 0;
		}
		set
		{
			GetBucket()?.SetInt(TOTAL_LOSSES, value);
		}
	}

	public static long LastHistoryUpdateTimestamp
	{
		get
		{
			return GetBucket()?.GetLong(LAST_HISTORY_UPDATE_TIMESTAMP, 0L) ?? 0L;
		}
		set
		{
			GetBucket()?.SetLong(LAST_HISTORY_UPDATE_TIMESTAMP, value);
		}
	}

	public static string LastRepairDate
	{
		get
		{
			return GetBucket()?.GetString(LAST_REPAIR_DATE, null);
		}
		set
		{
			GetBucket()?.SetString(LAST_REPAIR_DATE, value);
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

	private static BucketDailyWinStreak GetBucket()
	{
		if (s_bucketdailywinstreak == null)
		{
			s_bucketdailywinstreak = new BucketDailyWinStreak();
			s_bucketdailywinstreak.LoadFromDisk();
		}
		return s_bucketdailywinstreak;
	}

	public static int GetWinStreak(int defaultValue = 0)
	{
		return GetBucket()?.GetInt(WIN_STREAK, defaultValue) ?? defaultValue;
	}

	public static void SetWinStreak(int value)
	{
		GetBucket()?.SetInt(WIN_STREAK, value);
	}

	public static int IncrementAndSetWinStreak(int increment = 1)
	{
		return GetBucket()?.IncrementAndSetInt(WIN_STREAK, increment) ?? 0;
	}

	public static int GetMaxWinStreak(int defaultValue = 0)
	{
		return GetBucket()?.GetInt(MAX_WIN_STREAK, defaultValue) ?? defaultValue;
	}

	public static void SetMaxWinStreak(int value)
	{
		GetBucket()?.SetInt(MAX_WIN_STREAK, value);
	}

	public static int IncrementAndSetMaxWinStreak(int increment = 1)
	{
		return GetBucket()?.IncrementAndSetInt(MAX_WIN_STREAK, increment) ?? 0;
	}

	public static long GetLastWinTimestamp(long defaultValue = 0L)
	{
		return GetBucket()?.GetLong(LAST_WIN_TIMESTAMP, defaultValue) ?? defaultValue;
	}

	public static void SetLastWinTimestamp(long value)
	{
		GetBucket()?.SetLong(LAST_WIN_TIMESTAMP, value);
	}

	public static List<int> GetWinStreakHistory()
	{
		return GetBucket()?.GetList<int>(WIN_STREAK_HISTORY);
	}

	public static void SetWinStreakHistory(List<int> value)
	{
		GetBucket()?.SetList(WIN_STREAK_HISTORY, value);
	}

	public static int GetTotalWins(int defaultValue = 0)
	{
		return GetBucket()?.GetInt(TOTAL_WINS, defaultValue) ?? defaultValue;
	}

	public static void SetTotalWins(int value)
	{
		GetBucket()?.SetInt(TOTAL_WINS, value);
	}

	public static int IncrementAndSetTotalWins(int increment = 1)
	{
		return GetBucket()?.IncrementAndSetInt(TOTAL_WINS, increment) ?? 0;
	}

	public static int GetTotalLosses(int defaultValue = 0)
	{
		return GetBucket()?.GetInt(TOTAL_LOSSES, defaultValue) ?? defaultValue;
	}

	public static void SetTotalLosses(int value)
	{
		GetBucket()?.SetInt(TOTAL_LOSSES, value);
	}

	public static int IncrementAndSetTotalLosses(int increment = 1)
	{
		return GetBucket()?.IncrementAndSetInt(TOTAL_LOSSES, increment) ?? 0;
	}

	public static bool GetMilestone(string subkey, bool defaultValue = false)
	{
		return GetBucket()?.GetBool(MILESTONE, defaultValue, subkey) ?? defaultValue;
	}

	public static void SetMilestone(string subkey, bool value)
	{
		GetBucket()?.SetBool(MILESTONE, value, subkey);
	}

	public static long GetLastHistoryUpdateTimestamp(long defaultValue = 0L)
	{
		return GetBucket()?.GetLong(LAST_HISTORY_UPDATE_TIMESTAMP, defaultValue) ?? defaultValue;
	}

	public static void SetLastHistoryUpdateTimestamp(long value)
	{
		GetBucket()?.SetLong(LAST_HISTORY_UPDATE_TIMESTAMP, value);
	}

	public static string GetLastRepairDate(string defaultValue = null)
	{
		return GetBucket()?.GetString(LAST_REPAIR_DATE, defaultValue);
	}

	public static void SetLastRepairDate(string value)
	{
		GetBucket()?.SetString(LAST_REPAIR_DATE, value);
	}
}
