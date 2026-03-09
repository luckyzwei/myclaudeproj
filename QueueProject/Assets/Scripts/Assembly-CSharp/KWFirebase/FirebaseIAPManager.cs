using System;
using System.Collections.Generic;
using KWAttribution.Attribution;
using UnityEngine.Purchasing;

namespace KWFirebase
{
	public class FirebaseIAPManager : IProductPurchaser
	{
		private AppStore m_store;

		private readonly IAPCacheManager m_cache;

		private const string PURCHASE_STATE_COMPLETED = "0";

		private Dictionary<string, ProductInfo> m_availableProducts;

		private readonly List<ProductInfo> m_purchasedConsumables;

		private ProductInfo m_userTriggeredPurchase;

		private Action<PurchaseResult> m_purchaseCompletionCallback;

		private bool m_shouldValidatePurchases;

		private bool m_isStoreInitialized;

		public void Initialize(Dictionary<string, ProductInfo> productDefinitions)
		{
		}

		public void OnStoreInitialized(List<Product> products)
		{
		}

		public void OnStoreInitializationFailed(string failureReason)
		{
		}

		public bool IsStoreInitialised()
		{
			return false;
		}

		public void ToggleFakeMarket()
		{
		}

		public ProductInfo GetProduct(string productId)
		{
			return null;
		}

		public void PurchaseProduct(string productId, Action<PurchaseResult> callback)
		{
		}

		public void OnPurchaseFail(string productId, string reason)
		{
		}

		public void RestorePurchases(Action<bool> callback = null)
		{
		}

		public List<ProductInfo> GetAllProducts()
		{
			return null;
		}

		public List<ProductInfo> GetPurchasedConsumables()
		{
			return null;
		}

		public List<ProductInfo> GetPurchasedProducts()
		{
			return null;
		}

		public List<ProductInfo> GetProductsByCategory(string category)
		{
			return null;
		}

		private void InitialiseAppStore()
		{
		}

		private void HandleGameSettingsUpdated()
		{
		}

		private void SetProducts(Dictionary<string, ProductInfo> productDefinitions)
		{
		}

		private void HandlePurchaseFailedValidation(string validationError)
		{
		}

		private void HandlePurchaseValidated(KWAttribution.Attribution.ProductData validatedProduct)
		{
		}

		private void CompletePurchase(ProductInfo product, bool validated, bool isRestore)
		{
		}

		private void SendIAPCompletedEvents(ProductInfo product, bool isRestore)
		{
		}

		private void SendIAPFailedEvents(ProductInfo product, string errorMsg)
		{
		}

		private void ClearPurchaseState()
		{
		}

		private void OnApplicationPause(bool paused)
		{
		}
	}
}
