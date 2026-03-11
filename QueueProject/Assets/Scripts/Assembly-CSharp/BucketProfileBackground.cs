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
			return GetBucket()?.GetBool(BOT_PROFILES_SET) ?? false;
		}
		set
		{
			GetBucket()?.SetBool(BOT_PROFILES_SET, value);
		}
	}

	public static int BotProfilesSetDate
	{
		get
		{
			return GetBucket()?.GetInt(BOT_PROFILES_SET_DATE) ?? 0;
		}
		set
		{
			GetBucket()?.SetInt(BOT_PROFILES_SET_DATE, value);
		}
	}

	public static string SelectedBackgroundId
	{
		get
		{
			return GetBucket()?.GetString(SELECTED_BACKGROUND_ID);
		}
		set
		{
			GetBucket()?.SetString(SELECTED_BACKGROUND_ID, value);
		}
	}

	public static List<string> BackgroundsUsed
	{
		get
		{
			return GetBucket()?.GetList<string>(BACKGROUNDS_USED);
		}
		set
		{
			GetBucket()?.SetList(BACKGROUNDS_USED, value);
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

	private static BucketProfileBackground GetBucket()
	{
		if (s_bucketprofilebackground == null)
		{
			s_bucketprofilebackground = new BucketProfileBackground();
			s_bucketprofilebackground.LoadFromDisk();
		}
		return s_bucketprofilebackground;
	}

	public static bool GetBotProfilesSet(bool defaultValue = false)
	{
		return GetBucket()?.GetBool(BOT_PROFILES_SET, defaultValue) ?? defaultValue;
	}

	public static void SetBotProfilesSet(bool value)
	{
		GetBucket()?.SetBool(BOT_PROFILES_SET, value);
	}

	public static int GetBotProfilesSetDate(int defaultValue = 0)
	{
		return GetBucket()?.GetInt(BOT_PROFILES_SET_DATE, defaultValue) ?? defaultValue;
	}

	public static void SetBotProfilesSetDate(int value)
	{
		GetBucket()?.SetInt(BOT_PROFILES_SET_DATE, value);
	}

	public static int IncrementAndSetBotProfilesSetDate(int increment = 1)
	{
		return GetBucket()?.IncrementAndSetInt(BOT_PROFILES_SET_DATE, increment) ?? 0;
	}

	public static string GetSelectedBackgroundId(string defaultValue = null)
	{
		return GetBucket()?.GetString(SELECTED_BACKGROUND_ID, defaultValue) ?? defaultValue;
	}

	public static void SetSelectedBackgroundId(string value)
	{
		GetBucket()?.SetString(SELECTED_BACKGROUND_ID, value);
	}

	public static List<string> GetBackgroundsUsed()
	{
		return GetBucket()?.GetList<string>(BACKGROUNDS_USED);
	}

	public static void SetBackgroundsUsed(List<string> value)
	{
		GetBucket()?.SetList(BACKGROUNDS_USED, value);
	}
}
