using System.Collections.Generic;
using KWCore;
using KWCore.SaveData;

public class BucketCustomisation : BucketBase
{
	private const string BUCKET_KEY = "BUCKET_CUSTOMISATION";

	[KeyBool]
	private const string MIGRATION_DONE = "MIGRATION_DONE";

	[KeyBool]
	private const string AUTO_X_ON_OFF_STATE = "AUTO_X_ON_OFF_STATE";

	[KeyString]
	private const string BOARD_COLOUR_CLIENT_ID = "BOARD_COLOUR_CLIENT_ID";

	[KeyString]
	private const string QUEEN_SKIN_CLIENT_ID = "QUEEN_SKIN_CLIENT_ID";

	[KeyList(typeof(string))]
	private const string AVATARS_INVENTORY = "AVATARS_INVENTORY";

	private static BucketCustomisation s_bucketcustomisation;

	public static bool MigrationDone
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool AutoXOnOffState
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static string BoardColourClientId
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static string QueenSkinClientId
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static List<string> AvatarsInventory
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

	private static BucketCustomisation GetBucket()
	{
		return null;
	}

	public static bool GetMigrationDone(bool defaultValue = false)
	{
		return false;
	}

	public static void SetMigrationDone(bool value)
	{
	}

	public static bool GetAutoXOnOffState(bool defaultValue = false)
	{
		return false;
	}

	public static void SetAutoXOnOffState(bool value)
	{
	}

	public static string GetBoardColourClientId(string defaultValue = null)
	{
		return null;
	}

	public static void SetBoardColourClientId(string value)
	{
	}

	public static string GetQueenSkinClientId(string defaultValue = null)
	{
		return null;
	}

	public static void SetQueenSkinClientId(string value)
	{
	}

	public static List<string> GetAvatarsInventory()
	{
		return null;
	}

	public static void SetAvatarsInventory(List<string> value)
	{
	}
}
