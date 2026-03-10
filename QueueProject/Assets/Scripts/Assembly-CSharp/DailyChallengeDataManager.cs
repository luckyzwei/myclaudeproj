using KWCore.SaveData;
using UnityEngine;

public class DailyChallengeDataManager : MonoBehaviour
{
	private static BucketDailyChallenge s_bucket;

	// Bit layout per day key: bit 0 = completed, bit 1 = new, bit 2 = failed
	private const int BIT_COMPLETED = 0;
	private const int BIT_NEW = 1;
	private const int BIT_FAILED = 2;

	public static int GetFreeChances(string dailyChallengeID)
	{
		return BucketDailyChallenge.GetDailyFreeChances();
	}

	public static void SetFreeChances(string dailyChallengeID, int remainingFreeChances)
	{
		BucketDailyChallenge.SetDailyFreeChances(remainingFreeChances);
	}

	public static int GetLastFreeChanceDay(string dailyChallengeID)
	{
		return BucketDailyChallenge.GetLastDailyFreeChancesDay();
	}

	public static void SetLastFreeChanceDay(string dailyChallengeID, int dayOfYear)
	{
		BucketDailyChallenge.SetLastDailyFreeChancesDay(dayOfYear);
	}

	public static bool IsDayCompleted(DCDate dcDate, string dailyChallengeID)
	{
		return GetValueFromDict(dcDate, BucketDailyChallenge.COMPLETED_DAYS, dailyChallengeID);
	}

	public static bool IsDayNew(DCDate dcDate, string dailyChallengeID)
	{
		int key = GetKey(dcDate);
		var dict = BucketDailyChallenge.GetCompletedDaysNew();
		if (dict == null || !dict.ContainsKey(key)) return false;
		return GetBit(dict[key], BIT_NEW);
	}

	public static bool IsDayFailed(DCDate dcDate, string dailyChallengeID)
	{
		return GetValueFromDict(dcDate, BucketDailyChallenge.FAILED_DAYS, dailyChallengeID);
	}

	public static void SetDayCompleted(DCDate dcDate, string dailyChallengeID, bool isNew)
	{
		SetValueInDict(dcDate, true, BucketDailyChallenge.COMPLETED_DAYS, dailyChallengeID);
		if (isNew)
		{
			int key = GetKey(dcDate);
			var dict = BucketDailyChallenge.GetCompletedDaysNew();
			if (dict == null) dict = new System.Collections.Generic.Dictionary<int, int>();
			int val = dict.ContainsKey(key) ? dict[key] : 0;
			val = SetBit(val, BIT_NEW, true);
			dict[key] = val;
			BucketDailyChallenge.SetCompletedDaysNew(dict);
		}
	}

	public static void SetDayFailed(DCDate dcDate, string dailyChallengeID)
	{
		SetValueInDict(dcDate, true, BucketDailyChallenge.FAILED_DAYS, dailyChallengeID);
	}

	public static void MarkDayOld(DCDate dcDate, string dailyChallengeID)
	{
		int key = GetKey(dcDate);
		var dict = BucketDailyChallenge.GetCompletedDaysNew();
		if (dict != null && dict.ContainsKey(key))
		{
			int val = dict[key];
			val = SetBit(val, BIT_NEW, false);
			dict[key] = val;
			BucketDailyChallenge.SetCompletedDaysNew(dict);
		}
	}

	private static bool GetValueFromDict(DCDate dcDate, string dictKey, string dailyChallengeID)
	{
		int key = GetKey(dcDate);
		System.Collections.Generic.Dictionary<int, int> dict = null;
		if (dictKey == BucketDailyChallenge.COMPLETED_DAYS)
			dict = BucketDailyChallenge.GetCompletedDays();
		else if (dictKey == BucketDailyChallenge.FAILED_DAYS)
			dict = BucketDailyChallenge.GetFailedDays();
		if (dict == null) return false;
		return dict.ContainsKey(key) && dict[key] != 0;
	}

	private static bool SetValueInDict(DCDate dcDate, bool value, string dictKey, string dailyChallengeID)
	{
		int key = GetKey(dcDate);
		System.Collections.Generic.Dictionary<int, int> dict = null;
		if (dictKey == BucketDailyChallenge.COMPLETED_DAYS)
			dict = BucketDailyChallenge.GetCompletedDays();
		else if (dictKey == BucketDailyChallenge.FAILED_DAYS)
			dict = BucketDailyChallenge.GetFailedDays();
		if (dict == null) dict = new System.Collections.Generic.Dictionary<int, int>();
		dict[key] = value ? 1 : 0;
		if (dictKey == BucketDailyChallenge.COMPLETED_DAYS)
			BucketDailyChallenge.SetCompletedDays(dict);
		else if (dictKey == BucketDailyChallenge.FAILED_DAYS)
			BucketDailyChallenge.SetFailedDays(dict);
		return true;
	}

	private static int GetKey(DCDate dcDate)
	{
		// Encode date as YYYYMMDD integer
		return dcDate.year * 10000 + dcDate.month * 100 + dcDate.day;
	}

	public static bool IsDayCompleted(DCDate dcDate, out bool isNew)
	{
		isNew = false;
		int key = GetKey(dcDate);
		var completedDict = BucketDailyChallenge.GetCompletedDays();
		if (completedDict == null || !completedDict.ContainsKey(key) || completedDict[key] == 0)
			return false;
		var newDict = BucketDailyChallenge.GetCompletedDaysNew();
		if (newDict != null && newDict.ContainsKey(key))
			isNew = GetBit(newDict[key], BIT_NEW);
		return true;
	}

	public static bool IsDayFailed(DCDate dcDate)
	{
		int key = GetKey(dcDate);
		var dict = BucketDailyChallenge.GetFailedDays();
		return dict != null && dict.ContainsKey(key) && dict[key] != 0;
	}

	private static bool GetBit(int value, int bitIndex)
	{
		return (value & (1 << bitIndex)) != 0;
	}

	private static int SetBit(int value, int bitIndex, bool bitValue)
	{
		if (bitValue)
			return value | (1 << bitIndex);
		else
			return value & ~(1 << bitIndex);
	}

	private static BucketDailyChallenge GetBucket()
	{
		if (s_bucket == null)
		{
			s_bucket = new BucketDailyChallenge();
			s_bucket.LoadFromDisk();
		}
		return s_bucket;
	}

	public static void TryMigrate()
	{
		if (BucketDailyChallenge.GetIsMigrated()) return;
		BucketDailyChallenge.SetIsMigrated(true);
	}
}
