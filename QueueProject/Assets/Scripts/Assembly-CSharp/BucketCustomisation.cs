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
		get { return GetBucket().GetBool(MIGRATION_DONE); }
		set { GetBucket().SetBool(MIGRATION_DONE, value); }
	}

	public static bool AutoXOnOffState
	{
		get { return GetBucket().GetBool(AUTO_X_ON_OFF_STATE); }
		set { GetBucket().SetBool(AUTO_X_ON_OFF_STATE, value); }
	}

	public static string BoardColourClientId
	{
		get { return GetBucket().GetString(BOARD_COLOUR_CLIENT_ID); }
		set { GetBucket().SetString(BOARD_COLOUR_CLIENT_ID, value); }
	}

	public static string QueenSkinClientId
	{
		get { return GetBucket().GetString(QUEEN_SKIN_CLIENT_ID); }
		set { GetBucket().SetString(QUEEN_SKIN_CLIENT_ID, value); }
	}

	public static List<string> AvatarsInventory
	{
		get { return GetBucket().GetList<string>(AVATARS_INVENTORY) ?? new List<string>(); }
		set { GetBucket().SetList(AVATARS_INVENTORY, value); }
	}

	public override string GetBucketKey()
	{
		return BUCKET_KEY;
	}

	public override bool IsStoredInCloud()
	{
		return true;
	}

	private static BucketCustomisation GetBucket()
	{
		if (s_bucketcustomisation == null)
		{
			s_bucketcustomisation = new BucketCustomisation();
			s_bucketcustomisation.LoadFromDisk();
		}
		return s_bucketcustomisation;
	}

	public static bool GetMigrationDone(bool defaultValue = false)
	{
		return GetBucket().GetBool(MIGRATION_DONE, defaultValue);
	}

	public static void SetMigrationDone(bool value)
	{
		GetBucket().SetBool(MIGRATION_DONE, value);
		GetBucket().SaveToDisk();
	}

	public static bool GetAutoXOnOffState(bool defaultValue = false)
	{
		return GetBucket().GetBool(AUTO_X_ON_OFF_STATE, defaultValue);
	}

	public static void SetAutoXOnOffState(bool value)
	{
		GetBucket().SetBool(AUTO_X_ON_OFF_STATE, value);
		GetBucket().SaveToDisk();
	}

	public static string GetBoardColourClientId(string defaultValue = null)
	{
		return GetBucket().GetString(BOARD_COLOUR_CLIENT_ID, defaultValue);
	}

	public static void SetBoardColourClientId(string value)
	{
		GetBucket().SetString(BOARD_COLOUR_CLIENT_ID, value);
		GetBucket().SaveToDisk();
	}

	public static string GetQueenSkinClientId(string defaultValue = null)
	{
		return GetBucket().GetString(QUEEN_SKIN_CLIENT_ID, defaultValue);
	}

	public static void SetQueenSkinClientId(string value)
	{
		GetBucket().SetString(QUEEN_SKIN_CLIENT_ID, value);
		GetBucket().SaveToDisk();
	}

	public static List<string> GetAvatarsInventory()
	{
		return GetBucket().GetList<string>(AVATARS_INVENTORY) ?? new List<string>();
	}

	public static void SetAvatarsInventory(List<string> value)
	{
		GetBucket().SetList(AVATARS_INVENTORY, value);
		GetBucket().SaveToDisk();
	}
}
