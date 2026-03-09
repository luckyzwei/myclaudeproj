using KWCore;
using KWCore.SaveData;

public class BucketSoftRating : BucketBase
{
	[KeyInt]
	private const string LAST_RATE_REQUEST_DAY = "LAST_RATE_REQUEST_DAY";

	[KeyInt]
	private const string DAYS_PASSED_SINCE_LAST_RATE_REQUEST = "DAYS_PASSED_SINCE_LAST_RATE_REQUEST";

	[KeyInt]
	private const string POPUP_SHOWS_COUNT = "POPUP_SHOWS_COUNT";

	[KeyInt]
	private const string LAST_DISPLAY_PLAYS_COUNT = "LAST_DISPLAY_PLAYS_COUNT";

	private static BucketSoftRating s_bucketsoftrating;

	public static int LastRateRequestDay
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int DaysPassedSinceLastRateRequest
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int PopupShowsCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int LastDisplayPlaysCount
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

	private static BucketSoftRating GetBucket()
	{
		return null;
	}

	public static int GetLastRateRequestDay(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetLastRateRequestDay(int value)
	{
	}

	public static int IncrementAndSetLastRateRequestDay(int increment = 1)
	{
		return 0;
	}

	public static int GetDaysPassedSinceLastRateRequest(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetDaysPassedSinceLastRateRequest(int value)
	{
	}

	public static int IncrementAndSetDaysPassedSinceLastRateRequest(int increment = 1)
	{
		return 0;
	}

	public static int GetPopupShowsCount(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetPopupShowsCount(int value)
	{
	}

	public static int IncrementAndSetPopupShowsCount(int increment = 1)
	{
		return 0;
	}

	public static int GetLastDisplayPlaysCount(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetLastDisplayPlaysCount(int value)
	{
	}

	public static int IncrementAndSetLastDisplayPlaysCount(int increment = 1)
	{
		return 0;
	}
}
