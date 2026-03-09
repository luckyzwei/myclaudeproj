using System;

namespace KWGameCore
{
	public class MarketManager
	{
		private IMarket m_market;

		private MarketInterface m_marketInterface;

		public void Initialise(MarketInterface marketInterface)
		{
		}

		public bool HasPurchasedNoAds()
		{
			return false;
		}

		public void BuyProduct(string productID, Action onSuccess = null, Action onFailed = null)
		{
		}

		public void BuyNoAds(MarketInterface.NoAdsType type, Action purchaseSuccess = null, Action purchaseFailed = null)
		{
		}

		public void RestorePurchases(Action onSuccess = null)
		{
		}

		public float GetPriceWithProductClientID(string productCode)
		{
			return 0f;
		}

		public string GetLocalisedPriceWithProductClientID(string productCode)
		{
			return null;
		}

		public bool GetSubscribed()
		{
			return false;
		}

		public string GetNoAdsPrice()
		{
			return null;
		}

		public bool CanShowBannerCloseButton()
		{
			return false;
		}

		public void DoOnApplicationPause(bool paused)
		{
		}
	}
}
