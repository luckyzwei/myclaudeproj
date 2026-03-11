using KWCore;
using KWCore.SaveData;

public class BucketSpinWheel : BucketBase
{
	private const string BUCKET_KEY = "BUCKET_SPIN_WHEEL";

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
		get { return GetBucket().GetInt(TOTAL_SPINS); }
		set { GetBucket().SetInt(TOTAL_SPINS, value); }
	}

	public static bool Migrated
	{
		get { return GetBucket().GetBool(MIGRATED); }
		set { GetBucket().SetBool(MIGRATED, value); }
	}

	public static int ActivationIndex
	{
		get { return GetBucket().GetInt(ACTIVATION_INDEX); }
		set { GetBucket().SetInt(ACTIVATION_INDEX, value); }
	}

	public static int RewardSegmentIndex
	{
		get { return GetBucket().GetInt(REWARD_SEGMENT_INDEX); }
		set { GetBucket().SetInt(REWARD_SEGMENT_INDEX, value); }
	}

	public static int RewardActivationIndex
	{
		get { return GetBucket().GetInt(REWARD_ACTIVATION_INDEX); }
		set { GetBucket().SetInt(REWARD_ACTIVATION_INDEX, value); }
	}

	public static long LastStartSpinTimestamp
	{
		get { return GetBucket().GetLong(LAST_START_SPIN_TIMESTAMP); }
		set { GetBucket().SetLong(LAST_START_SPIN_TIMESTAMP, value); }
	}

	public void MigrateFromBalancy()
	{
	}

	public override string GetBucketKey()
	{
		return BUCKET_KEY;
	}

	public override bool IsStoredInCloud()
	{
		return true;
	}

	private static BucketSpinWheel GetBucket()
	{
		if (s_bucketspinwheel == null)
		{
			s_bucketspinwheel = new BucketSpinWheel();
			s_bucketspinwheel.LoadFromDisk();
		}
		return s_bucketspinwheel;
	}

	public static int GetTotalSpins(int defaultValue = 0)
	{
		return GetBucket().GetInt(TOTAL_SPINS, defaultValue);
	}

	public static void SetTotalSpins(int value)
	{
		GetBucket().SetInt(TOTAL_SPINS, value);
		GetBucket().SaveToDisk();
	}

	public static int IncrementAndSetTotalSpins(int increment = 1)
	{
		return GetBucket().IncrementAndSetInt(TOTAL_SPINS, increment);
	}

	public static bool GetMigrated(bool defaultValue = false)
	{
		return GetBucket().GetBool(MIGRATED, defaultValue);
	}

	public static void SetMigrated(bool value)
	{
		GetBucket().SetBool(MIGRATED, value);
		GetBucket().SaveToDisk();
	}

	public static int GetActivationIndex(int defaultValue = 0)
	{
		return GetBucket().GetInt(ACTIVATION_INDEX, defaultValue);
	}

	public static void SetActivationIndex(int value)
	{
		GetBucket().SetInt(ACTIVATION_INDEX, value);
		GetBucket().SaveToDisk();
	}

	public static int IncrementAndSetActivationIndex(int increment = 1)
	{
		return GetBucket().IncrementAndSetInt(ACTIVATION_INDEX, increment);
	}

	public static int GetRewardSegmentIndex(int defaultValue = 0)
	{
		return GetBucket().GetInt(REWARD_SEGMENT_INDEX, defaultValue);
	}

	public static void SetRewardSegmentIndex(int value)
	{
		GetBucket().SetInt(REWARD_SEGMENT_INDEX, value);
		GetBucket().SaveToDisk();
	}

	public static int IncrementAndSetRewardSegmentIndex(int increment = 1)
	{
		return GetBucket().IncrementAndSetInt(REWARD_SEGMENT_INDEX, increment);
	}

	public static int GetRewardActivationIndex(int defaultValue = 0)
	{
		return GetBucket().GetInt(REWARD_ACTIVATION_INDEX, defaultValue);
	}

	public static void SetRewardActivationIndex(int value)
	{
		GetBucket().SetInt(REWARD_ACTIVATION_INDEX, value);
		GetBucket().SaveToDisk();
	}

	public static int IncrementAndSetRewardActivationIndex(int increment = 1)
	{
		return GetBucket().IncrementAndSetInt(REWARD_ACTIVATION_INDEX, increment);
	}

	public static long GetLastStartSpinTimestamp(long defaultValue = 0L)
	{
		return GetBucket().GetLong(LAST_START_SPIN_TIMESTAMP, defaultValue);
	}

	public static void SetLastStartSpinTimestamp(long value)
	{
		GetBucket().SetLong(LAST_START_SPIN_TIMESTAMP, value);
		GetBucket().SaveToDisk();
	}
}
