using System.Collections;
using KWAnalytics.Analytics;

public class ProfileDataPacket : AnalyticsDataPacketBase
{
	private const string HASHTABLE_KEY = "profile";

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
