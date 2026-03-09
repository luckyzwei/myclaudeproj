using System;
using UnityEngine.Purchasing;
using UnityEngine.Serialization;

namespace KWFirebase
{
	[Serializable]
	public abstract class MarketItem
	{
		[FormerlySerializedAs("m_productId")]
		public string productId;

		[FormerlySerializedAs("m_productType")]
		public ProductType productType;

		[FormerlySerializedAs("m_category")]
		public string category;

		[FormerlySerializedAs("m_noAdsIncluded")]
		public bool noAdsIncluded;

		public abstract CustomProductData CustomData { get; }
	}
	[Serializable]
	public class MarketItem<T> : MarketItem where T : CustomProductData
	{
		public T customData;

		public override CustomProductData CustomData => null;
	}
}
