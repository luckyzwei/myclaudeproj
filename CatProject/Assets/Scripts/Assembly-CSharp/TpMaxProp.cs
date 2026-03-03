using System;
using UniRx;
using UnityEngine;

public class TpMaxProp
{
	public enum AdRewardType
	{
		None = -1,
		ContractCompany = 0,
		RefreshCompanyList = 1,
		AdSupply = 2,
		SkipNight = 3,
		Roulette = 4,
		ExpAdSupply = 5,
		DoubleReward = 6,
		Offline_3XReward = 7,
		Money_Safe = 8,
		PlayerLvPass = 9,
		FactoryOrderSlot = 10,
		FactoryItem_Battery = 11,
		FactoryItem_Timewarp = 12,
		Invest = 13,
		ManagerBox = 14,
		SpecialDayRoulette = 15,
		Free_Coin_Seasonal = 16,
		Offline_reward_Seasonal = 17,
		AdSupply_Seasonal = 18,
		SkipNight_Seasonal = 19,
		ShopAuction_Stamina = 20,
		AdSupply_Gem = 21,
		RichWay = 22,
		Acq_Pass = 23,
		Sub_Acq = 24,
		Tarot_Reroll = 25,
		OnePlusSixPackageAds = 26,
		Booster_Money = 27,
		Booster_Exp = 28,
		Booster_Speed = 29
	}

	public enum AdInterType
	{
		None = -1,
		NextStage = 0
	}

	private string adInterstitialUnitId;

	private string adRewardUnitId;

	private string adBannerUnitId;

	private string adAppOpenUnitId;

	private string amazone_inter_id;

	private string amazone_reward_id;

	private Action<bool> OnRewardResult;

	public Subject<bool> OnRewardResultBroadcast;

	private AdRewardType adType;

	private DateTime adLoadedTime;

	private Coroutine waitCo;

	private Action cb_loadRewardedAd;

	private Action cb_loadInterstitialAd;

	public Action<bool> listenerRewardedAd;

	private bool setFirstEcpm;

	public bool ShowingAd { get; private set; }

	public void AddRewardedAdEvent(Action<bool> cb)
	{
	}

	public void RemoveRewardedAdEvent(Action<bool> cb)
	{
	}

	public bool IsRewardedAd()
	{
		return false;
	}

	public void Init()
	{
	}

	public void InitializeInterstitialAds()
	{
	}

	public void InitializeRewardedAds()
	{
	}

	public void InitializeBannerAds()
	{
	}

	public void HideBannerAD()
	{
	}

	public void ShowInterstitialAD()
	{
	}

	public void ShowRewardAD(AdRewardType type, Action<bool> OnSuccess)
	{
	}

	private void onRewardResult(bool value)
	{
	}

	private void ShowNoAdsPopup()
	{
	}

	public void LoadInterstitial()
	{
	}

	public bool IsInterstitialReady()
	{
		return false;
	}

	private void OnInterstitialLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnInterstitialFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
	{
	}

	private void InterstitialFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnInterstitialDismissedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnInterstitialRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	public void LoadRewardedAd()
	{
	}

	private void OnRewardedAdLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnRewardedAdFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
	{
	}

	private void OnRewardedAdFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnRewardedAdDisplayedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnRewardedAdClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnRewardedAdDismissedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnRewardedAdReceivedRewardEvent(string adUnitId, MaxSdkBase.Reward reward, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnRewardedAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void Check_m_Rev(int addRev)
	{
	}

	private void OnBannerAdsClickedEvent(string id)
	{
	}

	private void OnBannerAdsCollapsedEvent(string id)
	{
	}

	private void OnBannerAdsExpandedEvent(string id)
	{
	}

	private void OnBannerAdLoadedEvent(string id)
	{
	}

	private void OnBannerAdLoadFailedEvent(string id, int errorCode)
	{
	}

	private bool IsCheatNoAds()
	{
		return false;
	}
}
