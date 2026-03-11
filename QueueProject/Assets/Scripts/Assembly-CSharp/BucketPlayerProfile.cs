using KWCore;
using KWCore.SaveData;

public class BucketPlayerProfile : BucketBase
{
	private const string BUCKET_KEY = "BUCKET_PLAYER_PROFILE";

	private const string DEFAULT_NAME_KEY = "PlayerProfile.DefaultPlayerName";

	[KeyBool]
	public const string MIGRATION_DONE = "migration_done";

	[KeyString]
	public const string LAST_MIGRATION_VERSION = "LAST_MIGRATION_VERSION";

	[KeyString]
	public const string SAVED_DATA_AVATAR_URL = "SAVED_DATA_AVATAR_URL";

	[KeyString]
	public const string CURRENT_USER_ID = "CURRENT_USER_ID";

	[KeyString]
	public const string AVATAR_ICON_CLIENT_ID = "AVATAR_ICON_CLIENT_ID";

	[KeyString]
	public const string NAME = "NAME";

	private static BucketPlayerProfile s_bucketplayerprofile;

	public static bool MigrationDone
	{
		get { return GetBucket().GetBool(MIGRATION_DONE); }
		set { GetBucket().SetBool(MIGRATION_DONE, value); }
	}

	public static string LastMigrationVersion
	{
		get { return GetBucket().GetString(LAST_MIGRATION_VERSION); }
		set { GetBucket().SetString(LAST_MIGRATION_VERSION, value); }
	}

	public static string SavedDataAvatarUrl
	{
		get { return GetBucket().GetString(SAVED_DATA_AVATAR_URL); }
		set { GetBucket().SetString(SAVED_DATA_AVATAR_URL, value); }
	}

	public static string CurrentUserId
	{
		get { return GetBucket().GetString(CURRENT_USER_ID); }
		set { GetBucket().SetString(CURRENT_USER_ID, value); }
	}

	public static string AvatarIconClientId
	{
		get { return GetBucket().GetString(AVATAR_ICON_CLIENT_ID); }
		set { GetBucket().SetString(AVATAR_ICON_CLIENT_ID, value); }
	}

	public static string Name
	{
		get { return GetBucket().GetString(NAME); }
		set { GetBucket().SetString(NAME, value); }
	}

	public override string GetBucketKey()
	{
		return BUCKET_KEY;
	}

	public override bool IsStoredInCloud()
	{
		return true;
	}

	public void MigrateFromBalancy()
	{
	}

	public void MigrateFromBalancy(string installVersion)
	{
	}

	private static BucketPlayerProfile GetBucket()
	{
		if (s_bucketplayerprofile == null)
		{
			s_bucketplayerprofile = new BucketPlayerProfile();
			s_bucketplayerprofile.LoadFromDisk();
		}
		return s_bucketplayerprofile;
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

	public static string GetLastMigrationVersion(string defaultValue = null)
	{
		return GetBucket().GetString(LAST_MIGRATION_VERSION, defaultValue);
	}

	public static void SetLastMigrationVersion(string value)
	{
		GetBucket().SetString(LAST_MIGRATION_VERSION, value);
		GetBucket().SaveToDisk();
	}

	public static string GetSavedDataAvatarUrl(string defaultValue = null)
	{
		return GetBucket().GetString(SAVED_DATA_AVATAR_URL, defaultValue);
	}

	public static void SetSavedDataAvatarUrl(string value)
	{
		GetBucket().SetString(SAVED_DATA_AVATAR_URL, value);
		GetBucket().SaveToDisk();
	}

	public static string GetCurrentUserId(string defaultValue = null)
	{
		return GetBucket().GetString(CURRENT_USER_ID, defaultValue);
	}

	public static void SetCurrentUserId(string value)
	{
		GetBucket().SetString(CURRENT_USER_ID, value);
		GetBucket().SaveToDisk();
	}

	public static string GetAvatarIconClientId(string defaultValue = null)
	{
		return GetBucket().GetString(AVATAR_ICON_CLIENT_ID, defaultValue);
	}

	public static void SetAvatarIconClientId(string value)
	{
		GetBucket().SetString(AVATAR_ICON_CLIENT_ID, value);
		GetBucket().SaveToDisk();
	}

	public static string GetName(string defaultValue = null)
	{
		return GetBucket().GetString(NAME, defaultValue);
	}

	public static void SetName(string value)
	{
		GetBucket().SetString(NAME, value);
		GetBucket().SaveToDisk();
	}
}
