using KWCore.SaveData;
using UnityEngine;

public class DailyChallengeDataManager : MonoBehaviour
{
	private static BucketDailyChallenge s_bucket;

	public static int GetFreeChances(string dailyChallengeID)
	{
		return 0;
	}

	public static void SetFreeChances(string dailyChallengeID, int remainingFreeChances)
	{
	}

	public static int GetLastFreeChanceDay(string dailyChallengeID)
	{
		return 0;
	}

	public static void SetLastFreeChanceDay(string dailyChallengeID, int remainingFreeChances)
	{
	}

	public static bool IsDayCompleted(DCDate dcDate, string dailyChallengeID)
	{
		return false;
	}

	public static bool IsDayNew(DCDate dcDate, string dailyChallengeID)
	{
		return false;
	}

	public static bool IsDayFailed(DCDate dcDate, string dailyChallengeID)
	{
		return false;
	}

	public static void SetDayCompleted(DCDate dcDate, string dailyChallengeID, bool isNew)
	{
	}

	public static void SetDayFailed(DCDate dcDate, string dailyChallengeID)
	{
	}

	public static void MarkDayOld(DCDate dcDate, string dailyChallengeID)
	{
	}

	private static bool GetValueFromDict(DCDate dcDate, string dictKey, string dailyChallengeID)
	{
		return false;
	}

	private static bool SetValueInDict(DCDate dcDate, bool value, string dictKey, string dailyChallengeID)
	{
		return false;
	}

	private static int GetKey(DCDate dcDate)
	{
		return 0;
	}

	public static bool IsDayCompleted(DCDate dcDate, out bool isNew)
	{
		isNew = default(bool);
		return false;
	}

	public static bool IsDayFailed(DCDate dcDate)
	{
		return false;
	}

	private static bool GetBit(int value, int bitIndex)
	{
		return false;
	}

	private static int SetBit(int value, int bitIndex, bool bitValue)
	{
		return 0;
	}

	private static BucketDailyChallenge GetBucket()
	{
		return null;
	}

	public static void TryMigrate()
	{
	}
}
