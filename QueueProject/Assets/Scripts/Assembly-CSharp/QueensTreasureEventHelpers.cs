using System;
using Balancy.Models;
using Balancy.Models.SmartObjects;

public static class QueensTreasureEventHelpers
{
	private const string NOTIFICATION_ID = "queenevent";

	private const string EVENT_ACTIVE_ID = "QueensTreasure";

	private const string EVENT_INACTIVE_ID = "QueensTreasureInactive";

	private const char CLAIMED_REWARD = '*';

	private const char UNCLAIMED_REWARD = '.';

	private static bool s_useDeviceTime;

	private static int[] s_cumulativeGems;

	private static int s_initialisedRewardSetIndex;

	public static PrizeLadderRewardData[] PrizeLadderRewardDatas => null;

	public static int RewardSetIndex => 0;

	private static int Loop(int index, int count, int loopFrom)
	{
		return 0;
	}

	private static GameEvent GetCurrentlyActiveQueenEvent()
	{
		return null;
	}

	public static bool IsEventLive(bool ignoreMinLevel = false)
	{
		return false;
	}

	private static bool IsTreasureEventStartDateBeforeCustomEventEnd()
	{
		return false;
	}

	private static GameEvent GetInactiveQueenEvent()
	{
		return null;
	}

	public static bool ReachedTheMinimumRequiredLevelForTreassureEvent()
	{
		return false;
	}

	public static int GetUnlockLevel()
	{
		return 0;
	}

	public static int GetTimeLeftUntilEventStart()
	{
		return 0;
	}

	public static int GetTimeLeftUntilEventFinish()
	{
		return 0;
	}

	public static void StartCustomEvent()
	{
	}

	public static void EndCustomEvent()
	{
	}

	public static bool IsCustomEventActive(out long remainingTime)
	{
		remainingTime = default(long);
		return false;
	}

	public static int NumberOfGemsCollected()
	{
		return 0;
	}

	public static void ResetGems()
	{
	}

	public static void AddGems(int gems)
	{
	}

	public static bool HasRewardBeenClaimed(int rewardIndex)
	{
		return false;
	}

	public static void RecordClaimedReward(int rewardIndex, bool claimed = true)
	{
	}

	public static bool AnyRewardIsAvailable()
	{
		return false;
	}

	public static bool RewardIsAvailable(int rewardIndex)
	{
		return false;
	}

	public static bool LastRewardClaimed()
	{
		return false;
	}

	public static DateTime GetEventStartDate()
	{
		return default(DateTime);
	}

	public static int GetEventStartDateDayIndex()
	{
		return 0;
	}

	public static bool HasPlayedBefore()
	{
		return false;
	}

	public static void SetPlayedBefore()
	{
	}

	public static int GetLastSeenGems()
	{
		return 0;
	}

	public static bool HasUnseenGems()
	{
		return false;
	}

	public static void SawAllGems()
	{
	}

	public static void CheckForNotifications()
	{
	}

	public static bool HasCollectedAllGems()
	{
		return false;
	}

	public static int GetRemainingGems()
	{
		return 0;
	}

	public static bool HasClaimedAllRewards()
	{
		return false;
	}

	public static void ClaimedAllRewards()
	{
	}

	public static void SetRewardSetIndex(int setIndex)
	{
	}

	public static int GetCumulativeRequiredGemsForPrize(int prizeIndex)
	{
		return 0;
	}
}
