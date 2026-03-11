using System;
using Balancy.Models;
using Balancy.Models.SmartObjects;
using KWCore.SaveData;

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

	public static int RewardSetIndex => BucketGameplay.QueensEventRewardIndex;

	private static int Loop(int index, int count, int loopFrom)
	{
		if (index < loopFrom)
			return index;
		return loopFrom + (index - loopFrom) % (count - loopFrom);
	}

	private static GameEvent GetCurrentlyActiveQueenEvent()
	{
		return QueensGameEventsHelper.FindActiveGameEventById(EVENT_ACTIVE_ID);
	}

	public static bool IsEventLive(bool ignoreMinLevel = false)
	{
		if (!ignoreMinLevel && !ReachedTheMinimumRequiredLevelForTreassureEvent())
			return false;

		GameEvent activeEvent = GetCurrentlyActiveQueenEvent();
		if (activeEvent != null)
			return true;

		return IsCustomEventActive(out _);
	}

	private static bool IsTreasureEventStartDateBeforeCustomEventEnd()
	{
		long customFinishTime = BucketQueensEvent.CustomEventFinishTime;
		if (customFinishTime <= 0)
			return false;

		int timeUntilStart = QueensGameEventsHelper.GetTimeLeftUntilEventStart(EVENT_ACTIVE_ID);
		if (timeUntilStart <= 0)
			return false;

		long now = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
		long eventStartTime = now + timeUntilStart;
		return eventStartTime < customFinishTime;
	}

	private static GameEvent GetInactiveQueenEvent()
	{
		return QueensGameEventsHelper.FindActiveGameEventById(EVENT_INACTIVE_ID);
	}

	public static bool ReachedTheMinimumRequiredLevelForTreassureEvent()
	{
		return FeatureUnlockManager.IsQueensEventUnlocked;
	}

	public static int GetUnlockLevel()
	{
		// Queens event unlock level; typical default for feature unlock
		return 5;
	}

	public static int GetTimeLeftUntilEventStart()
	{
		return QueensGameEventsHelper.GetTimeLeftUntilEventStart(EVENT_ACTIVE_ID);
	}

	public static int GetTimeLeftUntilEventFinish()
	{
		// Check custom event first
		if (IsCustomEventActive(out long remaining))
			return (int)remaining;

		return QueensGameEventsHelper.GetTimeLeftUntilEventFinish(EVENT_ACTIVE_ID);
	}

	public static void StartCustomEvent()
	{
		// Set custom event finish time (e.g. 24 hours from now)
		long finishTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds() + 86400;
		BucketQueensEvent.CustomEventFinishTime = finishTime;
	}

	public static void EndCustomEvent()
	{
		BucketQueensEvent.CustomEventFinishTime = 0;
	}

	public static bool IsCustomEventActive(out long remainingTime)
	{
		long finishTime = BucketQueensEvent.CustomEventFinishTime;
		if (finishTime <= 0)
		{
			remainingTime = 0;
			return false;
		}

		long now = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
		remainingTime = finishTime - now;
		if (remainingTime <= 0)
		{
			remainingTime = 0;
			return false;
		}
		return true;
	}

	public static int NumberOfGemsCollected()
	{
		return BucketGameplay.NumQueenEventGemsCollected;
	}

	public static void ResetGems()
	{
		BucketGameplay.NumQueenEventGemsCollected = 0;
		BucketGameplay.NumLastSeenGems = 0;
	}

	public static void AddGems(int gems)
	{
		BucketGameplay.NumQueenEventGemsCollected = BucketGameplay.NumQueenEventGemsCollected + gems;
	}

	public static bool HasRewardBeenClaimed(int rewardIndex)
	{
		string claimed = BucketGameplay.QueenEventRewardsClaimed;
		if (string.IsNullOrEmpty(claimed) || rewardIndex < 0 || rewardIndex >= claimed.Length)
			return false;
		return claimed[rewardIndex] == CLAIMED_REWARD;
	}

	public static void RecordClaimedReward(int rewardIndex, bool claimed = true)
	{
		string rewardsClaimed = BucketGameplay.QueenEventRewardsClaimed ?? "";

		// Extend the string if needed
		while (rewardsClaimed.Length <= rewardIndex)
			rewardsClaimed += UNCLAIMED_REWARD;

		char[] chars = rewardsClaimed.ToCharArray();
		chars[rewardIndex] = claimed ? CLAIMED_REWARD : UNCLAIMED_REWARD;
		BucketGameplay.QueenEventRewardsClaimed = new string(chars);
	}

	public static bool AnyRewardIsAvailable()
	{
		PrizeLadderRewardData[] rewards = PrizeLadderRewardDatas;
		if (rewards == null)
			return false;

		for (int i = 0; i < rewards.Length; i++)
		{
			if (RewardIsAvailable(i))
				return true;
		}
		return false;
	}

	public static bool RewardIsAvailable(int rewardIndex)
	{
		if (HasRewardBeenClaimed(rewardIndex))
			return false;

		int gemsRequired = GetCumulativeRequiredGemsForPrize(rewardIndex);
		return NumberOfGemsCollected() >= gemsRequired;
	}

	public static bool LastRewardClaimed()
	{
		PrizeLadderRewardData[] rewards = PrizeLadderRewardDatas;
		if (rewards == null || rewards.Length == 0)
			return false;
		return HasRewardBeenClaimed(rewards.Length - 1);
	}

	public static DateTime GetEventStartDate()
	{
		GameEvent activeEvent = GetCurrentlyActiveQueenEvent();
		if (activeEvent != null)
		{
			// Compute start date from time left until finish and event duration
			int timeLeftFinish = QueensGameEventsHelper.GetTimeLeftUntilEventFinish(EVENT_ACTIVE_ID);
			return DateTime.UtcNow.AddSeconds(timeLeftFinish).Date;
		}
		return DateTime.UtcNow.Date;
	}

	public static int GetEventStartDateDayIndex()
	{
		return BucketGameplay.LastQueensEventStartDay;
	}

	public static bool HasPlayedBefore()
	{
		return BucketQueensEvent.PlayedBefore;
	}

	public static void SetPlayedBefore()
	{
		BucketQueensEvent.PlayedBefore = true;
	}

	public static int GetLastSeenGems()
	{
		return BucketGameplay.NumLastSeenGems;
	}

	public static bool HasUnseenGems()
	{
		return NumberOfGemsCollected() > GetLastSeenGems();
	}

	public static void SawAllGems()
	{
		BucketGameplay.NumLastSeenGems = NumberOfGemsCollected();
	}

	public static void CheckForNotifications()
	{
		if (!IsEventLive())
			return;

		if (AnyRewardIsAvailable())
		{
			NotificationWidgetManager.Instance.AddNotification(NOTIFICATION_ID);
		}
		else
		{
			NotificationWidgetManager.Instance.SwallowNotification(NOTIFICATION_ID);
		}
	}

	public static bool HasCollectedAllGems()
	{
		PrizeLadderRewardData[] rewards = PrizeLadderRewardDatas;
		if (rewards == null || rewards.Length == 0)
			return false;

		int totalRequired = GetCumulativeRequiredGemsForPrize(rewards.Length - 1);
		return NumberOfGemsCollected() >= totalRequired;
	}

	public static int GetRemainingGems()
	{
		PrizeLadderRewardData[] rewards = PrizeLadderRewardDatas;
		if (rewards == null || rewards.Length == 0)
			return 0;

		int totalRequired = GetCumulativeRequiredGemsForPrize(rewards.Length - 1);
		int collected = NumberOfGemsCollected();
		return Math.Max(0, totalRequired - collected);
	}

	public static bool HasClaimedAllRewards()
	{
		return BucketGameplay.HasCollectedAllQueensRewards;
	}

	public static void ClaimedAllRewards()
	{
		BucketGameplay.HasCollectedAllQueensRewards = true;
	}

	public static void SetRewardSetIndex(int setIndex)
	{
		BucketGameplay.QueensEventRewardIndex = setIndex;
		s_initialisedRewardSetIndex = setIndex;
	}

	public static int GetCumulativeRequiredGemsForPrize(int prizeIndex)
	{
		if (s_cumulativeGems != null && prizeIndex >= 0 && prizeIndex < s_cumulativeGems.Length)
			return s_cumulativeGems[prizeIndex];
		return 0;
	}
}
