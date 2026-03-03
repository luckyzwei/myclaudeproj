using System;

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
	}

	public override void OnChangeScene()
	{
	}

	public void UpdateActiveFlag()
	{
	}

	public int GetShowRemainTime()
	{
		return 0;
	}

	public bool IsActive()
	{
		return false;
	}

	private void InitAdsShowTime()
	{
	}

	private void SubscribeConditionEvents()
	{
	}

	public void SetCountry(string countryCode)
	{
	}

	public void UpdateOneSecond()
	{
	}

	private void OpenInterstitial()
	{
	}

	public void ResetTimer()
	{
	}

	public void ShowInterstitial(Action callBack)
	{
	}
}
