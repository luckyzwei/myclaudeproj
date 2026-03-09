using System.Collections;
using KWAnalytics.Analytics;

public class LeaderboardLegendsTrophiesDataPacket : AnalyticsDataPacketBase
{
	private const string HASHTABLE_KEY = "leaderboard_legends_trophies";

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
