using System.Collections;
using KWAnalytics.Analytics;

public class LeagueDataPacket : AnalyticsDataPacketBase
{
	private const string HASHTABLE_KEY = "league_data";

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
