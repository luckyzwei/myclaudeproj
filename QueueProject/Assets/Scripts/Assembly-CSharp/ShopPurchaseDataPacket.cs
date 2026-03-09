using System.Collections;
using Balancy.Models.Store;
using KWAnalytics.Analytics;

public class ShopPurchaseDataPacket : AnalyticsDataPacketBase
{
	private const string HASHTABLE_KEY = "purchase_data";

	private Product m_product;

	private string m_location;

	~ShopPurchaseDataPacket()
	{
	}

	private void StoreEventsOnItemPurchased(Product product, bool wasSuccess)
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

	public void SetLocation(string location)
	{
	}
}
