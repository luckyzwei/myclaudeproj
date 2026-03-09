using System.Collections;
using KWAnalytics.Analytics;

public class SettingsDataPacket : AnalyticsDataPacketBase
{
	private const string HASHTABLE_KEY = "settings";

	private float m_startTime;

	private int m_taps;

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

	public void IncrementTap()
	{
	}
}
