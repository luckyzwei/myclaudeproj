using System.Collections.Generic;
using KWCore;
using KWCore.SaveData;

public class BucketRoyalTournament : BucketBase
{
	private const string BUCKET_KEY = "RoyalTournamentBucket";

	[KeyInt]
	private const string BEST_POSITION = "best_position";

	[KeyLong]
	private const string BEST_TIME = "best_time";

	[KeyInt]
	private const string LAST_RESULT_POSITION = "last_result_position";

	[KeyInt]
	private const string TIMES_COMPLETE = "times_completed";

	[KeyLong]
	private const string LAST_FINISHED_TIME_STAMP = "last_finished_time_stamp";

	[KeyList(typeof(int))]
	public const string LEVEL_POOL = "level_pool";

	[KeyBool]
	private const string GIVEN_LAST_RT_STARS = "given_last_rt_stars";

	[KeyBool]
	private const string FTUE_SHOWN = "ftue_shown";

	[KeyString]
	private const string ELIMINATION_REASON = "elimination_reason";

	private static BucketRoyalTournament s_bucketroyaltournament;

	public static int BestPosition
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static long BestTime
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public static int LastResultPosition
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int TimesComplete
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static long LastFinishedTimeStamp
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public static List<int> LevelPool
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static bool GivenLastRtStars
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool FtueShown
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static string EliminationReason
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

	private static BucketRoyalTournament GetBucket()
	{
		return null;
	}

	public static int GetBestPosition(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetBestPosition(int value)
	{
	}

	public static int IncrementAndSetBestPosition(int increment = 1)
	{
		return 0;
	}

	public static long GetBestTime(long defaultValue = 0L)
	{
		return 0L;
	}

	public static void SetBestTime(long value)
	{
	}

	public static int GetLastResultPosition(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetLastResultPosition(int value)
	{
	}

	public static int IncrementAndSetLastResultPosition(int increment = 1)
	{
		return 0;
	}

	public static int GetTimesComplete(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetTimesComplete(int value)
	{
	}

	public static int IncrementAndSetTimesComplete(int increment = 1)
	{
		return 0;
	}

	public static long GetLastFinishedTimeStamp(long defaultValue = 0L)
	{
		return 0L;
	}

	public static void SetLastFinishedTimeStamp(long value)
	{
	}

	public static List<int> GetLevelPool()
	{
		return null;
	}

	public static void SetLevelPool(List<int> value)
	{
	}

	public static bool GetGivenLastRtStars(bool defaultValue = false)
	{
		return false;
	}

	public static void SetGivenLastRtStars(bool value)
	{
	}

	public static bool GetFtueShown(bool defaultValue = false)
	{
		return false;
	}

	public static void SetFtueShown(bool value)
	{
	}

	public static string GetEliminationReason(string defaultValue = null)
	{
		return null;
	}

	public static void SetEliminationReason(string value)
	{
	}
}
