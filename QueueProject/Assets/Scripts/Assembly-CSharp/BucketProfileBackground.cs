using System.Collections.Generic;
using KWCore;
using KWCore.SaveData;

public class BucketProfileBackground : BucketBase
{
	private const string BUCKET_KEY = "PROFILE_BACKGROUND";

	[KeyBool]
	public const string BOT_PROFILES_SET = "BOT_PROFILES_SET";

	[KeyInt]
	public const string BOT_PROFILES_SET_DATE = "BOT_PROFILES_SET_DATE";

	[KeyString]
	public const string SELECTED_BACKGROUND_ID = "SELECTED_BACKGROUND_ID";

	[KeyList(typeof(string))]
	public const string BACKGROUNDS_USED = "BACKGROUNDS_USED";

	private static BucketProfileBackground s_bucketprofilebackground;

	public static bool BotProfilesSet
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static int BotProfilesSetDate
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static string SelectedBackgroundId
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static List<string> BackgroundsUsed
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

	private static BucketProfileBackground GetBucket()
	{
		return null;
	}

	public static bool GetBotProfilesSet(bool defaultValue = false)
	{
		return false;
	}

	public static void SetBotProfilesSet(bool value)
	{
	}

	public static int GetBotProfilesSetDate(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetBotProfilesSetDate(int value)
	{
	}

	public static int IncrementAndSetBotProfilesSetDate(int increment = 1)
	{
		return 0;
	}

	public static string GetSelectedBackgroundId(string defaultValue = null)
	{
		return null;
	}

	public static void SetSelectedBackgroundId(string value)
	{
	}

	public static List<string> GetBackgroundsUsed()
	{
		return null;
	}

	public static void SetBackgroundsUsed(List<string> value)
	{
	}
}
