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
			return false;
		}
		set
		{
		}
	}

	public static int FriendsCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int FriendsRequestCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int FriendsAcceptedCount
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

	private static BucketNakama GetBucket()
	{
		return null;
	}

	public static bool GetAccountAccepted(bool defaultValue = false)
	{
		return false;
	}

	public static void SetAccountAccepted(bool value)
	{
	}

	public static int GetFriendsCount(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetFriendsCount(int value)
	{
	}

	public static int IncrementAndSetFriendsCount(int increment = 1)
	{
		return 0;
	}

	public static int GetFriendsRequestCount(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetFriendsRequestCount(int value)
	{
	}

	public static int IncrementAndSetFriendsRequestCount(int increment = 1)
	{
		return 0;
	}

	public static int GetFriendsAcceptedCount(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetFriendsAcceptedCount(int value)
	{
	}

	public static int IncrementAndSetFriendsAcceptedCount(int increment = 1)
	{
		return 0;
	}

	public static int GetProductPurchasedCount(string subkey, int defaultValue = 0)
	{
		return 0;
	}

	public static void SetProductPurchasedCount(string subkey, int value)
	{
	}

	public static int IncrementAndSetProductPurchasedCount(string subkey, int increment = 1)
	{
		return 0;
	}

	public static bool GetUserNotificationRead(string subkey, bool defaultValue = false)
	{
		return false;
	}

	public static void SetUserNotificationRead(string subkey, bool value)
	{
	}
}
