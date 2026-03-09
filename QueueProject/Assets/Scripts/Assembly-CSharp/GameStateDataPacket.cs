using System.Collections;
using KWAnalytics.Analytics;

public class GameStateDataPacket : AnalyticsDataPacketBase
{
	private const string HASHTABLE_KEY = "game_state";

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
