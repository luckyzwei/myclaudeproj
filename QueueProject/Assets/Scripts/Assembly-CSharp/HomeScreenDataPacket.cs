using System.Collections;
using KWAnalytics.Analytics;

public class HomeScreenDataPacket : AnalyticsDataPacketBase
{
	private const string HASHTABLE_KEY = "home_screen";

	private string m_context;

	private int m_taps;

	private float m_startTime;

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

	public void IncremementTap()
	{
	}

	public void SetContext(string context)
	{
	}
}
