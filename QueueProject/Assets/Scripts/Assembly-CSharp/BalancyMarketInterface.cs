using System;
using KWCore.SaveData;
using KWGameCore;
using UnityEngine;

public class BalancyMarketInterface : MarketInterface, IMarket
{
	private const string NO_ADS_STORE_ID = "no_ads";

	private const string NO_ADS_BANNER_STORE_ID = "no_ads_banner";

	[Header("No Ads Offer Popup - Must Inherit INoAdsOfferPopUp")]
	[SerializeField]
	private GameObject m_noAdsPopUp;

	public override IMarket GetMarketServer()
	{
		return null;
	}

	public void Initialise(MarketInterface del)
	{
	}

	private void OnSmartObjectsInitializedEvent()
	{
	}

	private void OnBalancyDocumentsLoaded()
	{
	}

	private void ConfigureBalancyMarket()
	{
	}

	private bool HasPurchasedProduct(string id)
	{
		return false;
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

	public override void BuyNoAds(NoAdsType type, Action purchaseSuccess = null, Action purchaseFailed = null)
	{
	}

	public override bool CanShowBannerCloseButton()
	{
		return false;
	}

	public override void RegisterBuckets(SaveDataManager saveDataManager)
	{
	}

	public static void SendIAPFailedEvents(string productCode, string currencyCode, float price, string error)
	{
	}

	public static void SendIAPCompletedEvents(string productCode, string currencyCode, float price, bool isRestore, bool sandbox)
	{
	}

	public void DoOnApplicationPause(bool isPaused)
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
