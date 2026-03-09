using System.Collections;
using KWAnalytics.Analytics;

public class LeaderboardDataPacket : AnalyticsDataPacketBase
{
	private const string HASHTABLE_KEY = "leaderboard";

	private int m_currentRanking;

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

	public void UpdateValues()
	{
	}
}
