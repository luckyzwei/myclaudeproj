using KWCore;
using KWCore.SaveData;

public class BucketLimitedOffer : BucketBase
{
	private static string BUCKET_KEY;

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

	private static BucketLimitedOffer GetBucket()
	{
		return null;
	}

	public static int GetLimitedOfferLastLevelSeen(string subkey, int defaultValue = 0)
	{
		return 0;
	}

	public static void SetLimitedOfferLastLevelSeen(string subkey, int value)
	{
	}

	public static int IncrementAndSetLimitedOfferLastLevelSeen(string subkey, int increment = 1)
	{
		return 0;
	}

	public static bool GetTrialSeen(string subkey, bool defaultValue = false)
	{
		return false;
	}

	public static void SetTrialSeen(string subkey, bool value)
	{
	}

	public static bool GetTrialActive(string subkey, bool defaultValue = false)
	{
		return false;
	}

	public static void SetTrialActive(string subkey, bool value)
	{
	}

	public static long GetTrialTimestamp(string subkey, long defaultValue = 0L)
	{
		return 0L;
	}

	public static void SetTrialTimestamp(string subkey, long value)
	{
	}

	public static int GetTrialLevelCount(string subkey, int defaultValue = 0)
	{
		return 0;
	}

	public static void SetTrialLevelCount(string subkey, int value)
	{
	}

	public static int IncrementAndSetTrialLevelCount(string subkey, int increment = 1)
	{
		return 0;
	}

	public static string GetLastLimitedOfferShown(string defaultValue = null)
	{
		return null;
	}

	public static void SetLastLimitedOfferShown(string value)
	{
	}
}
