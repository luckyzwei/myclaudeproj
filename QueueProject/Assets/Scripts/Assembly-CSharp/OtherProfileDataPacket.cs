using System.Collections;
using KWAnalytics.Analytics;
using Nakama;

public class OtherProfileDataPacket : AnalyticsDataPacketBase
{
	private const string HASHTABLE_KEY = "other_profile";

	private IApiUser m_otherUser;

	public void SetOtherUser(IApiUser otherUser)
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
