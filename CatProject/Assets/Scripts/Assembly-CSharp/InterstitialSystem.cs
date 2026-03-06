using System;
using Treeplla;

public class InterstitialSystem : SystemBase
{
	private bool bActivate;

	private int ElapsedTimeSec;

	private int AdsShowCoolTimeSec;

	private bool IsFirstTier;

	private IDisposable InAppBuyDisposable;

	private int INTERSTITIAL_FIRST_COOL_TIME_SEC_WW;

	private int INTERSTITIAL_FIRST_COOL_TIME_SEC_US_KR_JP;

	private int INTERSTITIAL_COOL_TIME_SEC_WW;

	private int INTERSTITIAL_COOL_TIME_SEC_US_KR_JP;

	public int INTERSTITIAL_GEM_REWARD { get; private set; }

	public bool INTERSTITIAL_ACTIVE_FLAG { get; private set; }

	public override void InitSystem()
	{
		INTERSTITIAL_FIRST_COOL_TIME_SEC_WW = 300;
		INTERSTITIAL_FIRST_COOL_TIME_SEC_US_KR_JP = 300;
		INTERSTITIAL_COOL_TIME_SEC_WW = 180;
		INTERSTITIAL_COOL_TIME_SEC_US_KR_JP = 180;
		INTERSTITIAL_GEM_REWARD = 5;
		INTERSTITIAL_ACTIVE_FLAG = true;
		bActivate = false;
		ElapsedTimeSec = 0;
		InitAdsShowTime();
		SubscribeConditionEvents();
	}

	public override void OnChangeScene()
	{
		ResetTimer();
	}

	public void UpdateActiveFlag()
	{
		var userData = Singleton<GameRoot>.Instance.UserData;
		if (userData == null) return;
		if (userData.BuyInappIds != null && userData.BuyInappIds.Count > 0)
			INTERSTITIAL_ACTIVE_FLAG = false;
	}

	public int GetShowRemainTime()
	{
		return Math.Max(0, AdsShowCoolTimeSec - ElapsedTimeSec);
	}

	public bool IsActive()
	{
		return bActivate && INTERSTITIAL_ACTIVE_FLAG && GetShowRemainTime() <= 0;
	}

	private void InitAdsShowTime()
	{
		AdsShowCoolTimeSec = IsFirstTier ? INTERSTITIAL_FIRST_COOL_TIME_SEC_US_KR_JP : INTERSTITIAL_FIRST_COOL_TIME_SEC_WW;
	}

	private void SubscribeConditionEvents()
	{
	}

	public void SetCountry(string countryCode)
	{
		if (string.IsNullOrEmpty(countryCode)) return;
		string upper = countryCode.ToUpper();
		IsFirstTier = upper == "US" || upper == "KR" || upper == "JP";
		InitAdsShowTime();
	}

	public void UpdateOneSecond()
	{
		if (!bActivate || !INTERSTITIAL_ACTIVE_FLAG) return;
		ElapsedTimeSec++;
		if (IsActive())
			OpenInterstitial();
	}

	private void OpenInterstitial()
	{
		ResetTimer();
	}

	public void ResetTimer()
	{
		ElapsedTimeSec = 0;
		AdsShowCoolTimeSec = IsFirstTier ? INTERSTITIAL_COOL_TIME_SEC_US_KR_JP : INTERSTITIAL_COOL_TIME_SEC_WW;
	}

	public void ShowInterstitial(Action callBack)
	{
		ResetTimer();
		callBack?.Invoke();
	}
}
