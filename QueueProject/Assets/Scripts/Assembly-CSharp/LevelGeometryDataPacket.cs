using System.Collections;
using KWAnalytics.Analytics;

public class LevelGeometryDataPacket : AnalyticsDataPacketBase
{
	private const string HASHTABLE_KEY = "level_geometry";

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
