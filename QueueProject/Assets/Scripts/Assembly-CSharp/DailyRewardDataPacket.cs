using System.Collections;
using Balancy.Models.SmartObjects;
using KWAnalytics.Analytics;

public class DailyRewardDataPacket : AnalyticsDataPacketBase
{
	private const string HASHTABLE_KEY = "daily_rewards";

	private ArrayList m_rewardTypes;

	private ArrayList m_rewardAmount;

	private bool m_rvReward;

	public void PopulatePacket(Reward reward, bool rvReward)
	{
	}

	public override void FillHashTable(ref Hashtable hashTable)
	{
	}

	protected override string HashtableKey()
	{
		return null;
	}

	public override void ResetValues()
	{
	}
}
