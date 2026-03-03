using System;
using System.Numerics;
using UniRx;
using UnityEngine;

public class AdSupplySystem
{
	public enum ShowType
	{
		HUD = 0,
		VIP = 1,
		Mission = 2
	}

	public enum AdsupplyType
	{
		Money = 0,
		Exp = 1
	}

	public enum Status
	{
		Hide = 0,
		Show = 1
	}

	private int supply_ad_appear_cooltime;

	private int supply_ad_appear_cooltime_b;

	private int supply_ad_money_increment;

	private int supply_ad_add_money;

	private int dayskip_ad_offtime;

	private int gem_supply_ad_cooltime;

	private int exp_ad_start_time;

	private int exp_ad_end_time;

	private int exp_ad_cooltime;

	private int seasonal_supply_ad_appear_cooltime;

	private int seasonal_supply_production_time_min;

	private int seasonal_supply_production_time_max;

	private int seasonal_supply_day_count;

	public IReactiveProperty<Status> AdSupplyProperty;

	public IReactiveProperty<int> RemainTimeProperty;

	public IReactiveProperty<Status> GemAdSupplyProperty;

	public IReactiveProperty<int> GemRemainTimeProperty;

	public IReactiveProperty<Status> NightSkipProperty;

	public IReactiveProperty<Status> ExpSupplyProperty;

	private bool bPossible;

	private bool bExpAdsPossible;

	private bool bGemAdsPossible;

	private bool haveNotMaxLvCompany;

	private DateTime NextExpAdsTime;

	private DateTime NextGemAdsTime;

	public Config.RewardItemData AdSupplyReward;

	public bool AdsupplyShowPopup;

	public bool GemAdsupplyShowPopup;

	public bool OnSkipNight;

	public int gem_supply_ad_limit_daily { get; private set; }

	public int gem_supply_ad_gem_value { get; private set; }

	public int exp_ad_day_count { get; private set; }

	public int supply_safe_max_default_count { get; private set; }

	public int ExpUpCompany { get; private set; }

	public int AdSupplyBankSaveMaxCnt => 0;

	public void Init()
	{
	}

	public void SetGemAdsupply()
	{
	}

	public void Create()
	{
	}

	private void ResetGemAdsCount()
	{
	}

	private void ResetExpAdsCount()
	{
	}

	private void ResetSeasonalAdsCount()
	{
	}

	private void LoadGemAdsupplyData()
	{
	}

	private void SaveGemAdsupplyData()
	{
	}

	private void CheckGemAdsOpen()
	{
	}

	private void CheckExpAdsOpen()
	{
	}

	private void CheckMoneyAdsOpen()
	{
	}

	public bool AddPiggySaveCnt()
	{
		return false;
	}

	public void StartTutorial()
	{
	}

	public void CheckMaxLevelCompany()
	{
	}

	private void SetExpUpCompany()
	{
	}

	public void UpdateDaySkipStatus()
	{
	}

	public void SkipNight()
	{
	}

	public void RefreshReward()
	{
	}

	private void SetReward()
	{
	}

	private void SetSeasonalReward()
	{
	}

	public void SetDirectMoneySupply()
	{
	}

	public void SetMoneySupplyReward()
	{
	}

	public void CancelSupply()
	{
	}

	public void CancelGemSupply()
	{
	}

	public void CancelSeasonalSupply()
	{
	}

	public void UpdateAdsMoneyOneSeconds()
	{
	}

	public void UpdateAdsGemOneSeconds()
	{
	}

	public void UpdateAdsExpOneSeconds()
	{
	}

	public void ShowExpAd(GameObject obj, int company, BigInteger exp, Action cb)
	{
	}

	public void SkipExpAd()
	{
	}

	public void ShowGemAd(Action cb, Action FailCb)
	{
	}

	public void ShowAd(GameObject obj, ShowType type, Action<int, int, int, BigInteger> Cb, Action FailCb)
	{
	}

	public void GetReward(Action<int, int, int, BigInteger> Cb)
	{
	}
}
