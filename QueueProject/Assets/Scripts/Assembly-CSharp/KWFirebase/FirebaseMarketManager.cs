using System;
using System.Collections.Generic;
using KWCore.SaveData;
using KWGameCore;

namespace KWFirebase
{
	public class FirebaseMarketManager : MarketInterface, IMarket
	{
		private const string FIREBASE_PRODUCT_CONFIGS_PATH = "FirebaseProductConfiguration";

		private string m_noAdsProductId;

		private string m_noAdsBannerProductId;

		private FirebaseIAPManager m_iapManager;

		public override IMarket GetMarketServer()
		{
			return null;
		}

		public override void RegisterBuckets(SaveDataManager saveDataManager)
		{
		}

		public void Initialise(MarketInterface del)
		{
		}

		public override bool HasPurchasedNoAds()
		{
			return false;
		}

		public override void BuyProduct(string productId, Action onSuccess = null, Action onFailed = null)
		{
		}

		public override void BuyNoAds(NoAdsType type, Action purchaseSuccess = null, Action purchaseFailed = null)
		{
		}

		public ProductInfo GetProduct(string productId)
		{
			return null;
		}

		public override void RestorePurchases(Action onSuccess = null)
		{
		}

		public override float GetPriceWithProductClientID(string productCode)
		{
			return 0f;
		}

		public override string GetLocalisedPriceWithProductClientID(string productCode)
		{
			return null;
		}

		public override bool GetSubscribed()
		{
			return false;
		}

		public override string GetNoAdsPrice()
		{
			return null;
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

		public bool IsStoreInitialised()
		{
			return false;
		}

		public override bool CanShowBannerCloseButton()
		{
			return false;
		}

		public void ToggleFakeMarket()
		{
		}

		public void DoOnApplicationPause(bool isPaused)
		{
		}

		private Dictionary<string, ProductInfo> LoadConfiguredProducts()
		{
			return null;
		}
	}
}
