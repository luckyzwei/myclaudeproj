using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Balancy.API.Payments;
using Balancy.Data.SmartObjects;
using Balancy.Models.SmartObjects;
using KWCore.Utils;
using UnityEngine.Purchasing;
using Price = Balancy.Models.SmartObjects.Price;

public class BalancyMarket : MonoSingleton<BalancyMarket>, AppStore.IDelegate
{
	public class IAPItem
	{
		public StoreItem itemData;

		public UnityEngine.Purchasing.Product appstoreProduct;
	}

	[CompilerGenerated]
	private sealed class _003CStart_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BalancyMarket _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CStart_003Ed__21(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private Dictionary<string, IAPItem> m_iapItems;

	private AppStore m_appStore;

	private bool m_purchaseInProgress;

	private bool m_restoreInProgress;

	private List<string> m_fetchList;

	private Action<PurchaseProductResponseData> m_callback;

	private INoAdsOfferInterface m_noAdsOfferInterface;

	private OfferGroupInfo m_offerGroup;

	public bool ProductsFetched { get; private set; }

	public static event Action<string> ItemRestored
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

	public static void SendItemRestoredEvent(string clientId)
	{
	}

	protected override void Init()
	{
	}

	public void SetNoAdsOfferPrefabInterface(INoAdsOfferInterface noAdsOfferPrefabInterface)
	{
	}

	protected override void OnDestroy()
	{
	}

	private void BalancyBootstrapEventsOnProfileWasReset()
	{
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__21))]
	private IEnumerator Start()
	{
		return null;
	}

	private void InitStantardStoreItems()
	{
	}

	public void AddCustomStoreItems(List<StoreItem> storeItems)
	{
	}

	private void RestorePurchases(List<string> productIDs)
	{
	}

	public void RestorePurchases()
	{
	}

	private void AddAppStoreProductsToFetch(List<StoreItem> storeItems)
	{
	}

	public void AddCustomPrices(List<Price> prices)
	{
	}

	private void AddAppStoreProductsToFetch(List<Price> prices)
	{
	}

	private void FetchAppstoreProducts()
	{
	}

	public UnityEngine.Purchasing.Product GetProduct(string productId)
	{
		return null;
	}

	public StoreItem GetStoreItem(string productId)
	{
		return null;
	}

	public void OnFetchedAppStoreProducts(ProductCollection products)
	{
	}

	private void CheckForReceiptsInIAPItemsToRestore()
	{
	}

	public void OnAppStorePurchasedComplete(UnityEngine.Purchasing.Product product)
	{
	}

	private void OnBalancyPurchaseSuccess(PurchaseProductResponseData purchaseProductResponseData)
	{
	}

	public void OnAppStorePurchasedFailed(string failureReason)
	{
	}

	public void PurchaseIAP(string productId, Action<PurchaseProductResponseData> callback)
	{
	}

	public void PurchaseIAP(string productId, OfferGroupInfo offerGroup, Action<PurchaseProductResponseData> callback)
	{
	}

	public void TryShowNoAdsOffer(string location, Action callback = null)
	{
	}
}
