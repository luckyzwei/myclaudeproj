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
			return 0;
		}
		set
		{
		}
	}

	public static int MaxWinStreak
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static long LastWinTimestamp
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public static List<int> WinStreakHistory
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static int TotalWins
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int TotalLosses
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static long LastHistoryUpdateTimestamp
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public static string LastRepairDate
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

	private static BucketDailyWinStreak GetBucket()
	{
		return null;
	}

	public static int GetWinStreak(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetWinStreak(int value)
	{
	}

	public static int IncrementAndSetWinStreak(int increment = 1)
	{
		return 0;
	}

	public static int GetMaxWinStreak(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetMaxWinStreak(int value)
	{
	}

	public static int IncrementAndSetMaxWinStreak(int increment = 1)
	{
		return 0;
	}

	public static long GetLastWinTimestamp(long defaultValue = 0L)
	{
		return 0L;
	}

	public static void SetLastWinTimestamp(long value)
	{
	}

	public static List<int> GetWinStreakHistory()
	{
		return null;
	}

	public static void SetWinStreakHistory(List<int> value)
	{
	}

	public static int GetTotalWins(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetTotalWins(int value)
	{
	}

	public static int IncrementAndSetTotalWins(int increment = 1)
	{
		return 0;
	}

	public static int GetTotalLosses(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetTotalLosses(int value)
	{
	}

	public static int IncrementAndSetTotalLosses(int increment = 1)
	{
		return 0;
	}

	public static bool GetMilestone(string subkey, bool defaultValue = false)
	{
		return false;
	}

	public static void SetMilestone(string subkey, bool value)
	{
	}

	public static long GetLastHistoryUpdateTimestamp(long defaultValue = 0L)
	{
		return 0L;
	}

	public static void SetLastHistoryUpdateTimestamp(long value)
	{
	}

	public static string GetLastRepairDate(string defaultValue = null)
	{
		return null;
	}

	public static void SetLastRepairDate(string value)
	{
	}
}
