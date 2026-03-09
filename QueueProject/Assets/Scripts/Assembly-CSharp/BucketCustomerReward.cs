using System.Collections.Generic;
using KWCore;
using KWCore.SaveData;

public class BucketCustomerReward : BucketBase
{
	private const string BUCKET_KEY = "BUCKET_CUSTOMER_REWARD";

	[KeyBool]
	private const string MIGRATION_DONE = "migration_done";

	[KeyList(typeof(string))]
	private const string RECEVIED_REWARDS_LIST = "RECEVIED_REWARDS_LIST";

	private static BucketCustomerReward s_bucketcustomerreward;

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

	public static List<string> ReceviedRewardsList
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

	private static BucketCustomerReward GetBucket()
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

	public static List<string> GetReceviedRewardsList()
	{
		return null;
	}

	public static void SetReceviedRewardsList(List<string> value)
	{
	}
}
