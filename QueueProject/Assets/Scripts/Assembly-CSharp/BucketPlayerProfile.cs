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
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static string LastMigrationVersion
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static string SavedDataAvatarUrl
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static string CurrentUserId
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static string AvatarIconClientId
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static string Name
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

	public void MigrateFromBalancy()
	{
	}

	public void MigrateFromBalancy(string installVersion)
	{
	}

	private static BucketPlayerProfile GetBucket()
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

	public static string GetLastMigrationVersion(string defaultValue = null)
	{
		return null;
	}

	public static void SetLastMigrationVersion(string value)
	{
	}

	public static string GetSavedDataAvatarUrl(string defaultValue = null)
	{
		return null;
	}

	public static void SetSavedDataAvatarUrl(string value)
	{
	}

	public static string GetCurrentUserId(string defaultValue = null)
	{
		return null;
	}

	public static void SetCurrentUserId(string value)
	{
	}

	public static string GetAvatarIconClientId(string defaultValue = null)
	{
		return null;
	}

	public static void SetAvatarIconClientId(string value)
	{
	}

	public static string GetName(string defaultValue = null)
	{
		return null;
	}

	public static void SetName(string value)
	{
	}
}
