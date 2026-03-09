using System;
using KWCore.SaveData;
using KWGameCore;

public class NakamaMarketInterface : MarketInterface, IMarket
{
	private const string NO_ADS_STORE_ID = "no_ads";

	private const string NO_ADS_BANNER_STORE_ID = "no_ads_banner";

	public override IMarket GetMarketServer()
	{
		return null;
	}

	public void Initialise(MarketInterface del)
	{
	}

	public void DoOnApplicationPause(bool isPaused)
	{
	}

	public override bool HasPurchasedNoAds()
	{
		return false;
	}

	public override void BuyProduct(string productID, Action onSuccess = null, Action onFailed = null)
	{
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

	public override bool CanShowBannerCloseButton()
	{
		return false;
	}

	public override void RegisterBuckets(SaveDataManager saveDataManager)
	{
	}

	public override void BuyNoAds(NoAdsType type, Action purchaseSuccess = null, Action purchaseFailed = null)
	{
	}

	public override void RestorePurchases(Action onSuccess = null)
	{
	}

	public override float GetPriceWithProductClientID(string productCode)
	{
		return 0f;
	}
}
