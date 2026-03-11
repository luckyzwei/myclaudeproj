using KWCore;
using KWCore.SaveData;

public class BucketSoftRating : BucketBase
{
	private const string BUCKET_KEY = "BUCKET_SOFT_RATING";

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
		get { return GetBucket().GetInt(LAST_RATE_REQUEST_DAY); }
		set { GetBucket().SetInt(LAST_RATE_REQUEST_DAY, value); }
	}

	public static int DaysPassedSinceLastRateRequest
	{
		get { return GetBucket().GetInt(DAYS_PASSED_SINCE_LAST_RATE_REQUEST); }
		set { GetBucket().SetInt(DAYS_PASSED_SINCE_LAST_RATE_REQUEST, value); }
	}

	public static int PopupShowsCount
	{
		get { return GetBucket().GetInt(POPUP_SHOWS_COUNT); }
		set { GetBucket().SetInt(POPUP_SHOWS_COUNT, value); }
	}

	public static int LastDisplayPlaysCount
	{
		get { return GetBucket().GetInt(LAST_DISPLAY_PLAYS_COUNT); }
		set { GetBucket().SetInt(LAST_DISPLAY_PLAYS_COUNT, value); }
	}

	public override string GetBucketKey()
	{
		return BUCKET_KEY;
	}

	public override bool IsStoredInCloud()
	{
		return true;
	}

	private static BucketSoftRating GetBucket()
	{
		if (s_bucketsoftrating == null)
		{
			s_bucketsoftrating = new BucketSoftRating();
			s_bucketsoftrating.LoadFromDisk();
		}
		return s_bucketsoftrating;
	}

	public static int GetLastRateRequestDay(int defaultValue = 0)
	{
		return GetBucket().GetInt(LAST_RATE_REQUEST_DAY, defaultValue);
	}

	public static void SetLastRateRequestDay(int value)
	{
		GetBucket().SetInt(LAST_RATE_REQUEST_DAY, value);
		GetBucket().SaveToDisk();
	}

	public static int IncrementAndSetLastRateRequestDay(int increment = 1)
	{
		return GetBucket().IncrementAndSetInt(LAST_RATE_REQUEST_DAY, increment);
	}

	public static int GetDaysPassedSinceLastRateRequest(int defaultValue = 0)
	{
		return GetBucket().GetInt(DAYS_PASSED_SINCE_LAST_RATE_REQUEST, defaultValue);
	}

	public static void SetDaysPassedSinceLastRateRequest(int value)
	{
		GetBucket().SetInt(DAYS_PASSED_SINCE_LAST_RATE_REQUEST, value);
		GetBucket().SaveToDisk();
	}

	public static int IncrementAndSetDaysPassedSinceLastRateRequest(int increment = 1)
	{
		return GetBucket().IncrementAndSetInt(DAYS_PASSED_SINCE_LAST_RATE_REQUEST, increment);
	}

	public static int GetPopupShowsCount(int defaultValue = 0)
	{
		return GetBucket().GetInt(POPUP_SHOWS_COUNT, defaultValue);
	}

	public static void SetPopupShowsCount(int value)
	{
		GetBucket().SetInt(POPUP_SHOWS_COUNT, value);
		GetBucket().SaveToDisk();
	}

	public static int IncrementAndSetPopupShowsCount(int increment = 1)
	{
		return GetBucket().IncrementAndSetInt(POPUP_SHOWS_COUNT, increment);
	}

	public static int GetLastDisplayPlaysCount(int defaultValue = 0)
	{
		return GetBucket().GetInt(LAST_DISPLAY_PLAYS_COUNT, defaultValue);
	}

	public static void SetLastDisplayPlaysCount(int value)
	{
		GetBucket().SetInt(LAST_DISPLAY_PLAYS_COUNT, value);
		GetBucket().SaveToDisk();
	}

	public static int IncrementAndSetLastDisplayPlaysCount(int increment = 1)
	{
		return GetBucket().IncrementAndSetInt(LAST_DISPLAY_PLAYS_COUNT, increment);
	}
}
