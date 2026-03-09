using System.Collections;
using Balancy.Models.SmartObjects;
using KWAnalytics.Analytics;

public class SpinWheelDataPacket : AnalyticsDataPacketBase
{
	private const string HASHTABLE_KEY = "spin_wheel";

	private bool m_isRv;

	private Reward m_reward;

	private float m_weight;

	private ArrayList m_rewardTypes;

	private ArrayList m_rewardAmount;

	public void PopulatePackage(bool isRv, Reward reward, float weight)
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
