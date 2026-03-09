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
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static int MissionTargetValue
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int MissionPoolIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int RewardIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int MissionProgress
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static long MissionsDeadline
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public static float MissionLastSeenProgress
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static bool IsRewardCollected
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static List<string> MissionTypesTakenToday
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

	private static BucketMissions GetBucket()
	{
		return null;
	}

	public static string GetActiveMissionClientId(string defaultValue = null)
	{
		return null;
	}

	public static void SetActiveMissionClientId(string value)
	{
	}

	public static int GetMissionTargetValue(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetMissionTargetValue(int value)
	{
	}

	public static int IncrementAndSetMissionTargetValue(int increment = 1)
	{
		return 0;
	}

	public static int GetMissionPoolIndex(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetMissionPoolIndex(int value)
	{
	}

	public static int IncrementAndSetMissionPoolIndex(int increment = 1)
	{
		return 0;
	}

	public static int GetRewardIndex(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetRewardIndex(int value)
	{
	}

	public static int IncrementAndSetRewardIndex(int increment = 1)
	{
		return 0;
	}

	public static int GetMissionProgress(int defaultValue = 0)
	{
		return 0;
	}

	public static void SetMissionProgress(int value)
	{
	}

	public static int IncrementAndSetMissionProgress(int increment = 1)
	{
		return 0;
	}

	public static long GetMissionsDeadline(long defaultValue = 0L)
	{
		return 0L;
	}

	public static void SetMissionsDeadline(long value)
	{
	}

	public static float GetMissionLastSeenProgress(float defaultValue = 0f)
	{
		return 0f;
	}

	public static void SetMissionLastSeenProgress(float value)
	{
	}

	public static bool GetIsRewardCollected(bool defaultValue = false)
	{
		return false;
	}

	public static void SetIsRewardCollected(bool value)
	{
	}

	public static List<string> GetMissionsTaken(string subkey)
	{
		return null;
	}

	public static void SetMissionsTaken(string subkey, List<string> value)
	{
	}

	public static List<string> GetMissionTypesTakenToday()
	{
		return null;
	}

	public static void SetMissionTypesTakenToday(List<string> value)
	{
	}
}
