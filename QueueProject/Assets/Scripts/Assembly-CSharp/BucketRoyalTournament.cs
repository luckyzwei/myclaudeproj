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
			return GetBucket()?.GetInt(BEST_POSITION, 0) ?? 0;
		}
		set
		{
			GetBucket()?.SetInt(BEST_POSITION, value);
		}
	}

	public static long BestTime
	{
		get
		{
			return GetBucket()?.GetLong(BEST_TIME, 0L) ?? 0L;
		}
		set
		{
			GetBucket()?.SetLong(BEST_TIME, value);
		}
	}

	public static int LastResultPosition
	{
		get
		{
			return GetBucket()?.GetInt(LAST_RESULT_POSITION, 0) ?? 0;
		}
		set
		{
			GetBucket()?.SetInt(LAST_RESULT_POSITION, value);
		}
	}

	public static int TimesComplete
	{
		get
		{
			return GetBucket()?.GetInt(TIMES_COMPLETE, 0) ?? 0;
		}
		set
		{
			GetBucket()?.SetInt(TIMES_COMPLETE, value);
		}
	}

	public static long LastFinishedTimeStamp
	{
		get
		{
			return GetBucket()?.GetLong(LAST_FINISHED_TIME_STAMP, 0L) ?? 0L;
		}
		set
		{
			GetBucket()?.SetLong(LAST_FINISHED_TIME_STAMP, value);
		}
	}

	public static List<int> LevelPool
	{
		get
		{
			return GetBucket()?.GetList<int>(LEVEL_POOL);
		}
		set
		{
			GetBucket()?.SetList<int>(LEVEL_POOL, value);
		}
	}

	public static bool GivenLastRtStars
	{
		get
		{
			return GetBucket()?.GetBool(GIVEN_LAST_RT_STARS, false) ?? false;
		}
		set
		{
			GetBucket()?.SetBool(GIVEN_LAST_RT_STARS, value);
		}
	}

	public static bool FtueShown
	{
		get
		{
			return GetBucket()?.GetBool(FTUE_SHOWN, false) ?? false;
		}
		set
		{
			GetBucket()?.SetBool(FTUE_SHOWN, value);
		}
	}

	public static string EliminationReason
	{
		get
		{
			return GetBucket()?.GetString(ELIMINATION_REASON, null);
		}
		set
		{
			GetBucket()?.SetString(ELIMINATION_REASON, value);
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

	private static BucketRoyalTournament GetBucket()
	{
		if (s_bucketroyaltournament == null)
		{
			s_bucketroyaltournament = new BucketRoyalTournament();
			s_bucketroyaltournament.LoadFromDisk();
		}
		return s_bucketroyaltournament;
	}

	public static int GetBestPosition(int defaultValue = 0)
	{
		return GetBucket()?.GetInt(BEST_POSITION, defaultValue) ?? defaultValue;
	}

	public static void SetBestPosition(int value)
	{
		GetBucket()?.SetInt(BEST_POSITION, value);
	}

	public static int IncrementAndSetBestPosition(int increment = 1)
	{
		return GetBucket()?.IncrementAndSetInt(BEST_POSITION, increment) ?? 0;
	}

	public static long GetBestTime(long defaultValue = 0L)
	{
		return GetBucket()?.GetLong(BEST_TIME, defaultValue) ?? defaultValue;
	}

	public static void SetBestTime(long value)
	{
		GetBucket()?.SetLong(BEST_TIME, value);
	}

	public static int GetLastResultPosition(int defaultValue = 0)
	{
		return GetBucket()?.GetInt(LAST_RESULT_POSITION, defaultValue) ?? defaultValue;
	}

	public static void SetLastResultPosition(int value)
	{
		GetBucket()?.SetInt(LAST_RESULT_POSITION, value);
	}

	public static int IncrementAndSetLastResultPosition(int increment = 1)
	{
		return GetBucket()?.IncrementAndSetInt(LAST_RESULT_POSITION, increment) ?? 0;
	}

	public static int GetTimesComplete(int defaultValue = 0)
	{
		return GetBucket()?.GetInt(TIMES_COMPLETE, defaultValue) ?? defaultValue;
	}

	public static void SetTimesComplete(int value)
	{
		GetBucket()?.SetInt(TIMES_COMPLETE, value);
	}

	public static int IncrementAndSetTimesComplete(int increment = 1)
	{
		return GetBucket()?.IncrementAndSetInt(TIMES_COMPLETE, increment) ?? 0;
	}

	public static long GetLastFinishedTimeStamp(long defaultValue = 0L)
	{
		return GetBucket()?.GetLong(LAST_FINISHED_TIME_STAMP, defaultValue) ?? defaultValue;
	}

	public static void SetLastFinishedTimeStamp(long value)
	{
		GetBucket()?.SetLong(LAST_FINISHED_TIME_STAMP, value);
	}

	public static List<int> GetLevelPool()
	{
		return GetBucket()?.GetList<int>(LEVEL_POOL);
	}

	public static void SetLevelPool(List<int> value)
	{
		GetBucket()?.SetList<int>(LEVEL_POOL, value);
	}

	public static bool GetGivenLastRtStars(bool defaultValue = false)
	{
		return GetBucket()?.GetBool(GIVEN_LAST_RT_STARS, defaultValue) ?? defaultValue;
	}

	public static void SetGivenLastRtStars(bool value)
	{
		GetBucket()?.SetBool(GIVEN_LAST_RT_STARS, value);
	}

	public static bool GetFtueShown(bool defaultValue = false)
	{
		return GetBucket()?.GetBool(FTUE_SHOWN, defaultValue) ?? defaultValue;
	}

	public static void SetFtueShown(bool value)
	{
		GetBucket()?.SetBool(FTUE_SHOWN, value);
	}

	public static string GetEliminationReason(string defaultValue = null)
	{
		return GetBucket()?.GetString(ELIMINATION_REASON, defaultValue) ?? defaultValue;
	}

	public static void SetEliminationReason(string value)
	{
		GetBucket()?.SetString(ELIMINATION_REASON, value);
	}
}
