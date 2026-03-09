using System.Collections;
using Balancy.Models.Store;

namespace KWAnalytics.Analytics
{
	public class ShopScreenDataPacket : AnalyticsDataPacketBase
	{
		private const string HASHTABLE_KEY = "store_screen";

		private int m_numTaps;

		private float m_startTime;

		private bool m_wasProductPurchased;

		~ShopScreenDataPacket()
		{
		}

		private void StoreEventsOnItemPurchased(Product product, bool wasSuccess)
		{
		}

		public override void FillHashTable(ref Hashtable hashTable)
		{
		}

		private bool DoesPlayerHaveNoAds()
		{
			return false;
		}

		protected override string HashtableKey()
		{
			return null;
		}

		public override void ResetValues()
		{
		}

		public void IncrementTaps()
		{
		}
	}
}
