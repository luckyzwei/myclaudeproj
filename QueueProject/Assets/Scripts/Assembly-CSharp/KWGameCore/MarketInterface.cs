using System;
using KWCore.SaveData;
using UnityEngine;

namespace KWGameCore
{
	public abstract class MarketInterface : MonoBehaviour
	{
		public enum NoAdsType
		{
			NO_ADS_BUTTON = 0,
			BANNER_CLOSE = 1
		}

		public abstract IMarket GetMarketServer();

		public abstract bool HasPurchasedNoAds();

		public abstract void BuyProduct(string productID, Action onSuccess = null, Action onFailed = null);

		public abstract void BuyNoAds(NoAdsType type, Action purchaseSuccess = null, Action purchaseFailed = null);

		public abstract void RestorePurchases(Action onSuccess = null);

		public abstract float GetPriceWithProductClientID(string productCode);

		public abstract string GetLocalisedPriceWithProductClientID(string productCode);

		public abstract bool GetSubscribed();

		public abstract string GetNoAdsPrice();

		public abstract bool CanShowBannerCloseButton();

		public abstract void RegisterBuckets(SaveDataManager saveDataManager);
	}
}
