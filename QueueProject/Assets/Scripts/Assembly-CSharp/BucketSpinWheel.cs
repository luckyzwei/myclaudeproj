using KWCore;
using KWCore.SaveData;

public class BucketSpinWheel : BucketBase
{
	[KeyInt]
	public const string TOTAL_SPINS = "TOTAL_SPINS";

	[KeyBool]
	private const string MIGRATED = "migrated";

	[KeyInt]
	private const string ACTIVATION_INDEX = "activation_index";

	[KeyInt]
	private const string REWARD_SEGMENT_INDEX = "reward_segment_index";

	[KeyInt]
	private const string REWARD_ACTIVATION_INDEX = "reward_activation_index";

	[KeyLong]
	private const string LAST_START_SPIN_TIMESTAMP = "lastStartSpinTimeStamp";

	private static BucketSpinWheel s_bucketspinwheel;

	public static int TotalSpins
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

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

	public static int ActivationIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int RewardSegmentIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int RewardActivationIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static long LastStartSpinTimestamp
	{
		get
		{
			return 0L;
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

	private static BucketSpinWheel GetBucket()
	{
		return null;
	}

	public static int GetTotalSpins(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetTotalSpins(int value)
	{
	}

	public static int IncrementAndSetTotalSpins(int increment = 1)
	{
		return 0;
	}

	public static bool GetMigrated(bool defaultValue = false)
	{
		return false;
	}

	public static void SetMigrated(bool value)
	{
	}

	public static int GetActivationIndex(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetActivationIndex(int value)
	{
	}

	public static int IncrementAndSetActivationIndex(int increment = 1)
	{
		return 0;
	}

	public static int GetRewardSegmentIndex(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetRewardSegmentIndex(int value)
	{
	}

	public static int IncrementAndSetRewardSegmentIndex(int increment = 1)
	{
		return 0;
	}

	public static int GetRewardActivationIndex(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetRewardActivationIndex(int value)
	{
	}

	public static int IncrementAndSetRewardActivationIndex(int increment = 1)
	{
		return 0;
	}

	public static long GetLastStartSpinTimestamp(long defaultValue = 0L)
	{
		return 0L;
	}

	public static void SetLastStartSpinTimestamp(long value)
	{
	}
}
