using System;
using System.Collections.Generic;
using UnityEngine.Serialization;

namespace KWFirebase
{
	[Serializable]
	public abstract class ProductConfigBase : FirebaseScriptableObject
	{
		[FormerlySerializedAs("m_noAdsClientId")]
		public string noAdsClientId;

		[FormerlySerializedAs("m_noAdsCloseBannerClientId")]
		public string noAdsCloseBannerClientId;

		[FormerlySerializedAs("m_noAdsCategory")]
		public string noAdsCategory;

		public abstract List<MarketItem> Products { get; }
	}
}
