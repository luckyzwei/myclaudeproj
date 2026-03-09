using System.Collections;
using KWAnalytics.Analytics;

public class LifeSystemDataPacket : AnalyticsDataPacketBase
{
	private const string HASHTABLE_KEY = "lives_data";

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
