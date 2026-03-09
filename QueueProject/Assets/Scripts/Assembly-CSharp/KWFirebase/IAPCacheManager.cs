using System;
using System.Collections.Generic;

namespace KWFirebase
{
	public class IAPCacheManager
	{
		[Serializable]
		private class IAPProductsRecord
		{
			public List<ProductInfo> products;
		}

		private readonly string m_key;

		public IAPCacheManager(string key)
		{
		}

		public void CachePurchase(string productId, bool isValidated = false)
		{
		}

		public void CacheProducts(List<ProductInfo> products)
		{
		}

		public Dictionary<string, ProductInfo> GetProducts()
		{
			return null;
		}
	}
}
