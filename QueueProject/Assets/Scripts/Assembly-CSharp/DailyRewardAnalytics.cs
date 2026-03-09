using Balancy.Models.SmartObjects;
using UnityEngine;

public class DailyRewardAnalytics : MonoBehaviour
{
	private const string DAILY_REWARD_OPENED = "daily_reward_opened";

	private const string DAILY_REWARD_CLAIMED = "daily_reward_claimed";

	private static DailyRewardDataPacket s_dailyProgressRewardDataPacket;

	public static void PopulateDataPacket(Reward reward, bool isRv)
	{
	}

	public static void SendDailyRewardOpened()
	{
	}

	public static void SendDailyRewardClaimed()
	{
	}

	private static void SendProgressRewardEvent(string eventName)
	{
	}
}
