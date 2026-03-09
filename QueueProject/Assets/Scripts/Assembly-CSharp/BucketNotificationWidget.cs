using KWCore;
using KWCore.SaveData;

public class BucketNotificationWidget : BucketBase
{
	[KeyBool]
	private const string MIGRATED = "migrated";

	[SubkeyInt]
	public const string ACTIVE_NOTIFICATION_COUNT = "active_notification_count";

	private static BucketNotificationWidget s_bucketnotificationwidget;

	public static bool Migrated
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void MigrateFromBalancy()
	{
	}

	public override string GetBucketKey()
	{
		return null;
	}

	public override bool IsStoredInCloud()
	{
		return false;
	}

	private static BucketNotificationWidget GetBucket()
	{
		return null;
	}

	public static bool GetMigrated(bool defaultValue = false)
	{
		return false;
	}

	public static void SetMigrated(bool value)
	{
	}

	public static int GetActiveNotificationCount(string subkey, int defaultValue = 0)
	{
		return 0;
	}

	public static void SetActiveNotificationCount(string subkey, int value)
	{
	}

	public static int IncrementAndSetActiveNotificationCount(string subkey, int increment = 1)
	{
		return 0;
	}
}
