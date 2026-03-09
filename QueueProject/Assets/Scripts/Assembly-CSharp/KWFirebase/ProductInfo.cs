using System;
using Newtonsoft.Json;
using UnityEngine.Purchasing;

namespace KWFirebase
{
	[Serializable]
	public class ProductInfo : IProductStateSetter
	{
		private Product m_product;

		[JsonProperty("IsOwned")]
		private bool m_isOwned;

		[JsonIgnore]
		private IProductPurchaser m_purchaser;

		[JsonIgnore]
		public string Name { get; private set; }

		[JsonProperty("Id")]
		public string Id { get; private set; }

		[JsonIgnore]
		public ProductType Type { get; private set; }

		[JsonProperty("Price")]
		public decimal Price { get; private set; }

		[JsonProperty("LocalizePriceString")]
		public string LocalizePriceString { get; private set; }

		[JsonProperty("CurrencyCode")]
		public string CurrencyCode { get; private set; }

		[JsonIgnore]
		public bool IsNoAdsIncluded { get; private set; }

		[JsonProperty("Quantity")]
		public int Quantity { get; private set; }

		[JsonProperty("IsValidated")]
		public bool IsValidated { get; private set; }

		[JsonProperty("ExpireDuration")]
		public long ExpireDuration { get; private set; }

		[JsonIgnore]
		public string Category { get; private set; }

		[JsonIgnore]
		public CustomProductData CustomData { get; private set; }

		[JsonIgnore]
		public bool IsOwned => false;

		public ProductInfo()
		{
		}

		public ProductInfo(string id, ProductType type, string category, CustomProductData customData, bool isNoAdsIncluded = false)
		{
		}

		public ProductInfo(Product product, bool isNoAdsIncluded, string category, bool isValidated, CustomProductData customData)
		{
		}

		void IProductStateSetter.UpdateFromCache(ProductInfo cachedProduct)
		{
		}

		public bool IsSubscription()
		{
			return false;
		}

		public bool IsNonConsumable()
		{
			return false;
		}

		public bool IsConsumable()
		{
			return false;
		}

		public bool IsSubscriptionExpired()
		{
			return false;
		}

		public bool HasPurchasedProduct()
		{
			return false;
		}

		public void Buy(Action<PurchaseResult> callback)
		{
		}

		public Product GetProduct()
		{
			return null;
		}

		void IProductStateSetter.SetOwnership(bool value)
		{
		}

		void IProductStateSetter.SetValidation(bool value)
		{
		}

		void IProductStateSetter.SetExpireDuration(long duration)
		{
		}

		void IProductStateSetter.SetProduct(Product product)
		{
		}

		void IProductStateSetter.SetPurchaser(IProductPurchaser purchaser)
		{
		}

		void IProductStateSetter.SetQuantity(int quantity)
		{
		}

		internal ProductInfo Clone()
		{
			return null;
		}
	}
}
