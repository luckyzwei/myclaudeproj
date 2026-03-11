using KWCore;
using KWCore.SaveData;

public class BucketLimitedOffer : BucketBase
{
	private static string BUCKET_KEY = "BUCKET_LIMITED_OFFER";

	[SubkeyInt]
	public const string LIMITED_OFFER_LAST_LEVEL_SEEN = "last_level_seen";

	[SubkeyBool]
	public const string TRIAL_SEEN = "trial_seen";

	[SubkeyBool]
	public const string TRIAL_ACTIVE = "trial_active";

	[SubkeyLong]
	public const string TRIAL_TIMESTAMP = "trial_timestamp";

	[SubkeyInt]
	public const string TRIAL_LEVEL_COUNT = "trial_level_count";

	[KeyString]
	public const string LAST_LIMITED_OFFER_SHOWN = "last_limited_offer_shown";

	private static BucketLimitedOffer s_bucketlimitedoffer;

	public static string LastLimitedOfferShown
	{
		get
		{
			return GetBucket()?.GetString(LAST_LIMITED_OFFER_SHOWN);
		}
		set
		{
			GetBucket()?.SetString(LAST_LIMITED_OFFER_SHOWN, value);
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

	private static BucketLimitedOffer GetBucket()
	{
		if (s_bucketlimitedoffer == null)
		{
			s_bucketlimitedoffer = new BucketLimitedOffer();
			s_bucketlimitedoffer.LoadFromDisk();
		}
		return s_bucketlimitedoffer;
	}

	public static int GetLimitedOfferLastLevelSeen(string subkey, int defaultValue = 0)
	{
		return GetBucket()?.GetInt(LIMITED_OFFER_LAST_LEVEL_SEEN, defaultValue, subkey) ?? defaultValue;
	}

	public static void SetLimitedOfferLastLevelSeen(string subkey, int value)
	{
		GetBucket()?.SetInt(LIMITED_OFFER_LAST_LEVEL_SEEN, value, subkey);
	}

	public static int IncrementAndSetLimitedOfferLastLevelSeen(string subkey, int increment = 1)
	{
		return GetBucket()?.IncrementAndSetInt(LIMITED_OFFER_LAST_LEVEL_SEEN, increment, subkey) ?? 0;
	}

	public static bool GetTrialSeen(string subkey, bool defaultValue = false)
	{
		return GetBucket()?.GetBool(TRIAL_SEEN, defaultValue, subkey) ?? defaultValue;
	}

	public static void SetTrialSeen(string subkey, bool value)
	{
		GetBucket()?.SetBool(TRIAL_SEEN, value, subkey);
	}

	public static bool GetTrialActive(string subkey, bool defaultValue = false)
	{
		return GetBucket()?.GetBool(TRIAL_ACTIVE, defaultValue, subkey) ?? defaultValue;
	}

	public static void SetTrialActive(string subkey, bool value)
	{
		GetBucket()?.SetBool(TRIAL_ACTIVE, value, subkey);
	}

	public static long GetTrialTimestamp(string subkey, long defaultValue = 0L)
	{
		return GetBucket()?.GetLong(TRIAL_TIMESTAMP, defaultValue, subkey) ?? defaultValue;
	}

	public static void SetTrialTimestamp(string subkey, long value)
	{
		GetBucket()?.SetLong(TRIAL_TIMESTAMP, value, subkey);
	}

	public static int GetTrialLevelCount(string subkey, int defaultValue = 0)
	{
		return GetBucket()?.GetInt(TRIAL_LEVEL_COUNT, defaultValue, subkey) ?? defaultValue;
	}

	public static void SetTrialLevelCount(string subkey, int value)
	{
		GetBucket()?.SetInt(TRIAL_LEVEL_COUNT, value, subkey);
	}

	public static int IncrementAndSetTrialLevelCount(string subkey, int increment = 1)
	{
		return GetBucket()?.IncrementAndSetInt(TRIAL_LEVEL_COUNT, increment, subkey) ?? 0;
	}

	public static string GetLastLimitedOfferShown(string defaultValue = null)
	{
		return GetBucket()?.GetString(LAST_LIMITED_OFFER_SHOWN, defaultValue) ?? defaultValue;
	}

	public static void SetLastLimitedOfferShown(string value)
	{
		GetBucket()?.SetString(LAST_LIMITED_OFFER_SHOWN, value);
	}
}
