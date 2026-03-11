using KWCore;
using KWCore.SaveData;

public class BucketNakama : BucketBase
{
	private const string BUCKET_KEY = "BUCKET_NAKAMA";

	[KeyBool]
	public const string ACCOUNT_ACCEPTED = "ACCOUNT_ACCEPTED";

	[KeyInt]
	public const string FRIENDS_COUNT = "FRIENDS_COUNT";

	[KeyInt]
	public const string FRIENDS_REQUEST_COUNT = "FRIENDS_REQUEST_COUNT";

	[KeyInt]
	public const string FRIENDS_ACCEPTED_COUNT = "FRIENDS_ACCEPTED_COUNT";

	[SubkeyInt]
	public const string PRODUCT_PURCHASED_COUNT = "PRODUCT_PURCHASED_COUNT";

	[SubkeyBool]
	private const string USER_NOTIFICATION_READ = "USER_NOTIFICATION_READ";

	private static BucketNakama s_bucketnakama;

	public static bool AccountAccepted
	{
		get
		{
			return GetBucket()?.GetBool(ACCOUNT_ACCEPTED) ?? false;
		}
		set
		{
			GetBucket()?.SetBool(ACCOUNT_ACCEPTED, value);
		}
	}

	public static int FriendsCount
	{
		get
		{
			return GetBucket()?.GetInt(FRIENDS_COUNT) ?? 0;
		}
		set
		{
			GetBucket()?.SetInt(FRIENDS_COUNT, value);
		}
	}

	public static int FriendsRequestCount
	{
		get
		{
			return GetBucket()?.GetInt(FRIENDS_REQUEST_COUNT) ?? 0;
		}
		set
		{
			GetBucket()?.SetInt(FRIENDS_REQUEST_COUNT, value);
		}
	}

	public static int FriendsAcceptedCount
	{
		get
		{
			return GetBucket()?.GetInt(FRIENDS_ACCEPTED_COUNT) ?? 0;
		}
		set
		{
			GetBucket()?.SetInt(FRIENDS_ACCEPTED_COUNT, value);
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

	private static BucketNakama GetBucket()
	{
		if (s_bucketnakama == null)
		{
			s_bucketnakama = new BucketNakama();
			s_bucketnakama.LoadFromDisk();
		}
		return s_bucketnakama;
	}

	public static bool GetAccountAccepted(bool defaultValue = false)
	{
		return GetBucket()?.GetBool(ACCOUNT_ACCEPTED, defaultValue) ?? defaultValue;
	}

	public static void SetAccountAccepted(bool value)
	{
		GetBucket()?.SetBool(ACCOUNT_ACCEPTED, value);
	}

	public static int GetFriendsCount(int defaultValue = 0)
	{
		return GetBucket()?.GetInt(FRIENDS_COUNT, defaultValue) ?? defaultValue;
	}

	public static void SetFriendsCount(int value)
	{
		GetBucket()?.SetInt(FRIENDS_COUNT, value);
	}

	public static int IncrementAndSetFriendsCount(int increment = 1)
	{
		return GetBucket()?.IncrementAndSetInt(FRIENDS_COUNT, increment) ?? 0;
	}

	public static int GetFriendsRequestCount(int defaultValue = 0)
	{
		return GetBucket()?.GetInt(FRIENDS_REQUEST_COUNT, defaultValue) ?? defaultValue;
	}

	public static void SetFriendsRequestCount(int value)
	{
		GetBucket()?.SetInt(FRIENDS_REQUEST_COUNT, value);
	}

	public static int IncrementAndSetFriendsRequestCount(int increment = 1)
	{
		return GetBucket()?.IncrementAndSetInt(FRIENDS_REQUEST_COUNT, increment) ?? 0;
	}

	public static int GetFriendsAcceptedCount(int defaultValue = 0)
	{
		return GetBucket()?.GetInt(FRIENDS_ACCEPTED_COUNT, defaultValue) ?? defaultValue;
	}

	public static void SetFriendsAcceptedCount(int value)
	{
		GetBucket()?.SetInt(FRIENDS_ACCEPTED_COUNT, value);
	}

	public static int IncrementAndSetFriendsAcceptedCount(int increment = 1)
	{
		return GetBucket()?.IncrementAndSetInt(FRIENDS_ACCEPTED_COUNT, increment) ?? 0;
	}

	public static int GetProductPurchasedCount(string subkey, int defaultValue = 0)
	{
		return GetBucket()?.GetInt(PRODUCT_PURCHASED_COUNT, defaultValue, subkey) ?? defaultValue;
	}

	public static void SetProductPurchasedCount(string subkey, int value)
	{
		GetBucket()?.SetInt(PRODUCT_PURCHASED_COUNT, value, subkey);
	}

	public static int IncrementAndSetProductPurchasedCount(string subkey, int increment = 1)
	{
		return GetBucket()?.IncrementAndSetInt(PRODUCT_PURCHASED_COUNT, increment, subkey) ?? 0;
	}

	public static bool GetUserNotificationRead(string subkey, bool defaultValue = false)
	{
		return GetBucket()?.GetBool(USER_NOTIFICATION_READ, defaultValue, subkey) ?? defaultValue;
	}

	public static void SetUserNotificationRead(string subkey, bool value)
	{
		GetBucket()?.SetBool(USER_NOTIFICATION_READ, value, subkey);
	}
}
