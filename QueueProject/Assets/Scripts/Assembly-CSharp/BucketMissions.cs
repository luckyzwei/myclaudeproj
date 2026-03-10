using System.Collections.Generic;
using KWCore;
using KWCore.SaveData;

public class BucketMissions : BucketBase
{
	private const string BUCKET_KEY = "BUCKET_MISSIONS";

	[KeyString]
	public const string ACTIVE_MISSION_CLIENT_ID = "ACTIVE_MISSION_CLIENT_ID";

	[KeyInt]
	public const string MISSION_TARGET_VALUE = "MISSION_TARGET_VALUE";

	[KeyInt]
	public const string MISSION_POOL_INDEX = "MISSION_POOL_INDEX";

	[KeyInt]
	public const string REWARD_INDEX = "REWARD_INDEX";

	[KeyInt]
	public const string MISSION_PROGRESS = "MISSION_PROGRESS";

	[KeyLong]
	public const string MISSIONS_DEADLINE = "MISSIONS_DEADLINE";

	[KeyFloat]
	public const string MISSION_LAST_SEEN_PROGRESS = "MISSION_LAST_SEEN_PROGRESS";

	[KeyBool]
	public const string IS_REWARD_COLLECTED = "IS_REWARD_COLLECTED";

	[SubkeyList(typeof(string))]
	public const string MISSIONS_TAKEN = "MISSIONS_TAKEN";

	[KeyList(typeof(string))]
	public const string MISSION_TYPES_TAKEN_TODAY = "MISSION_TYPES_TAKEN_TODAY";

	private static BucketMissions s_bucketmissions;

	public static string ActiveMissionClientId
	{
		get { return GetBucket().GetString(ACTIVE_MISSION_CLIENT_ID); }
		set { GetBucket().SetString(ACTIVE_MISSION_CLIENT_ID, value); }
	}

	public static int MissionTargetValue
	{
		get { return GetBucket().GetInt(MISSION_TARGET_VALUE); }
		set { GetBucket().SetInt(MISSION_TARGET_VALUE, value); }
	}

	public static int MissionPoolIndex
	{
		get { return GetBucket().GetInt(MISSION_POOL_INDEX); }
		set { GetBucket().SetInt(MISSION_POOL_INDEX, value); }
	}

	public static int RewardIndex
	{
		get { return GetBucket().GetInt(REWARD_INDEX); }
		set { GetBucket().SetInt(REWARD_INDEX, value); }
	}

	public static int MissionProgress
	{
		get { return GetBucket().GetInt(MISSION_PROGRESS); }
		set { GetBucket().SetInt(MISSION_PROGRESS, value); }
	}

	public static long MissionsDeadline
	{
		get { return GetBucket().GetLong(MISSIONS_DEADLINE); }
		set { GetBucket().SetLong(MISSIONS_DEADLINE, value); }
	}

	public static float MissionLastSeenProgress
	{
		get { return GetBucket().GetFloat(MISSION_LAST_SEEN_PROGRESS); }
		set { GetBucket().SetFloat(MISSION_LAST_SEEN_PROGRESS, value); }
	}

	public static bool IsRewardCollected
	{
		get { return GetBucket().GetBool(IS_REWARD_COLLECTED); }
		set { GetBucket().SetBool(IS_REWARD_COLLECTED, value); }
	}

	public static List<string> MissionTypesTakenToday
	{
		get { return GetBucket().GetList<string>(MISSION_TYPES_TAKEN_TODAY) ?? new List<string>(); }
		set { GetBucket().SetList(MISSION_TYPES_TAKEN_TODAY, value); }
	}

	public override string GetBucketKey()
	{
		return BUCKET_KEY;
	}

	public override bool IsStoredInCloud()
	{
		return true;
	}

	private static BucketMissions GetBucket()
	{
		if (s_bucketmissions == null)
		{
			s_bucketmissions = new BucketMissions();
			s_bucketmissions.LoadFromDisk();
		}
		return s_bucketmissions;
	}

	public static string GetActiveMissionClientId(string defaultValue = null)
	{
		return GetBucket().GetString(ACTIVE_MISSION_CLIENT_ID, defaultValue);
	}

	public static void SetActiveMissionClientId(string value)
	{
		GetBucket().SetString(ACTIVE_MISSION_CLIENT_ID, value);
		GetBucket().SaveToDisk();
	}

	public static int GetMissionTargetValue(int defaultValue = 0)
	{
		return GetBucket().GetInt(MISSION_TARGET_VALUE, defaultValue);
	}

	public static void SetMissionTargetValue(int value)
	{
		GetBucket().SetInt(MISSION_TARGET_VALUE, value);
		GetBucket().SaveToDisk();
	}

	public static int IncrementAndSetMissionTargetValue(int increment = 1)
	{
		return GetBucket().IncrementAndSetInt(MISSION_TARGET_VALUE, increment);
	}

	public static int GetMissionPoolIndex(int defaultValue = 0)
	{
		return GetBucket().GetInt(MISSION_POOL_INDEX, defaultValue);
	}

	public static void SetMissionPoolIndex(int value)
	{
		GetBucket().SetInt(MISSION_POOL_INDEX, value);
		GetBucket().SaveToDisk();
	}

	public static int IncrementAndSetMissionPoolIndex(int increment = 1)
	{
		return GetBucket().IncrementAndSetInt(MISSION_POOL_INDEX, increment);
	}

	public static int GetRewardIndex(int defaultValue = 0)
	{
		return GetBucket().GetInt(REWARD_INDEX, defaultValue);
	}

	public static void SetRewardIndex(int value)
	{
		GetBucket().SetInt(REWARD_INDEX, value);
		GetBucket().SaveToDisk();
	}

	public static int IncrementAndSetRewardIndex(int increment = 1)
	{
		return GetBucket().IncrementAndSetInt(REWARD_INDEX, increment);
	}

	public static int GetMissionProgress(int defaultValue = 0)
	{
		return GetBucket().GetInt(MISSION_PROGRESS, defaultValue);
	}

	public static void SetMissionProgress(int value)
	{
		GetBucket().SetInt(MISSION_PROGRESS, value);
		GetBucket().SaveToDisk();
	}

	public static int IncrementAndSetMissionProgress(int increment = 1)
	{
		return GetBucket().IncrementAndSetInt(MISSION_PROGRESS, increment);
	}

	public static long GetMissionsDeadline(long defaultValue = 0L)
	{
		return GetBucket().GetLong(MISSIONS_DEADLINE, defaultValue);
	}

	public static void SetMissionsDeadline(long value)
	{
		GetBucket().SetLong(MISSIONS_DEADLINE, value);
		GetBucket().SaveToDisk();
	}

	public static float GetMissionLastSeenProgress(float defaultValue = 0f)
	{
		return GetBucket().GetFloat(MISSION_LAST_SEEN_PROGRESS, defaultValue);
	}

	public static void SetMissionLastSeenProgress(float value)
	{
		GetBucket().SetFloat(MISSION_LAST_SEEN_PROGRESS, value);
		GetBucket().SaveToDisk();
	}

	public static bool GetIsRewardCollected(bool defaultValue = false)
	{
		return GetBucket().GetBool(IS_REWARD_COLLECTED, defaultValue);
	}

	public static void SetIsRewardCollected(bool value)
	{
		GetBucket().SetBool(IS_REWARD_COLLECTED, value);
		GetBucket().SaveToDisk();
	}

	public static List<string> GetMissionsTaken(string subkey)
	{
		return GetBucket().GetList<string>(MISSIONS_TAKEN, subkey) ?? new List<string>();
	}

	public static void SetMissionsTaken(string subkey, List<string> value)
	{
		GetBucket().SetList(MISSIONS_TAKEN, value, subkey);
		GetBucket().SaveToDisk();
	}

	public static List<string> GetMissionTypesTakenToday()
	{
		return GetBucket().GetList<string>(MISSION_TYPES_TAKEN_TODAY) ?? new List<string>();
	}

	public static void SetMissionTypesTakenToday(List<string> value)
	{
		GetBucket().SetList(MISSION_TYPES_TAKEN_TODAY, value);
		GetBucket().SaveToDisk();
	}
}
