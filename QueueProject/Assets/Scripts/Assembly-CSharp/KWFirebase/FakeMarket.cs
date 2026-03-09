using System;
using System.Collections.Generic;

namespace KWFirebase
{
	public class FakeMarket
	{
		private Dictionary<string, ProductInfo> m_availableProducts;

		private List<ProductInfo> m_purchasedConsumables;

		private readonly IAPCacheManager m_cache;

		public bool Enabled { get; private set; }

		public void Initialize(Dictionary<string, ProductInfo> productDefinitions)
		{
		}

		public void ToggleFakeMarket()
		{
		}

		public void PurchaseProduct(string productId, Action<PurchaseResult> onFinishedCallBack)
		{
		}

		private ProductInfo GetProduct(string productId)
		{
			return null;
		}
	}
}
