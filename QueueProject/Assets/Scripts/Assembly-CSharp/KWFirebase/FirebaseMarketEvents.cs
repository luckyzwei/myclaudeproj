using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing;

namespace KWFirebase
{
	public class FirebaseMarketEvents
	{
		public static event Action<List<Product>> OnStoreInitialised
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<ProductInfo> OnProductPurchased
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<ProductInfo> OnSubscriptionExpired
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static void SendStoreInitialisedEvent(List<Product> storeProducts)
		{
		}

		public static void SendProductPurchasedEvent(ProductInfo product)
		{
		}

		public static void SendSubscriptionExpired(ProductInfo product)
		{
		}
	}
}
