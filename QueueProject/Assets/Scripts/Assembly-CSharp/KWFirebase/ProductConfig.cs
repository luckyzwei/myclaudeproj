using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace KWFirebase
{
	[Serializable]
	public class ProductConfig<T> : ProductConfigBase where T : CustomProductData
	{
		[FormerlySerializedAs("m_products")]
		public List<MarketItem<T>> products;

		public override List<MarketItem> Products => null;
	}
	[Serializable]
	[CreateAssetMenu(fileName = "FirebaseProductConfiguration", menuName = "KWFirebase/Market/FirebaseProductConfiguration")]
	public class ProductConfig : ProductConfig<CustomProductData>
	{
	}
}
