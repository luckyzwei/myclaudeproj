using System;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
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

	public int AdSupplyBankSaveMaxCnt { get { return supply_safe_max_default_count; } }

	public void Init()
	{
		supply_ad_appear_cooltime = 300;
		supply_ad_appear_cooltime_b = 180;
		supply_ad_money_increment = 10;
		supply_ad_add_money = 100;
		dayskip_ad_offtime = 5;
		gem_supply_ad_cooltime = 600;
		gem_supply_ad_limit_daily = 5;
		gem_supply_ad_gem_value = 10;
		exp_ad_start_time = 9;
		exp_ad_end_time = 21;
		exp_ad_cooltime = 600;
		exp_ad_day_count = 3;
		supply_safe_max_default_count = 10;
		seasonal_supply_ad_appear_cooltime = 300;
		seasonal_supply_production_time_min = 60;
		seasonal_supply_production_time_max = 300;
		seasonal_supply_day_count = 3;

		Create();
		bPossible = false;
		bExpAdsPossible = false;
		bGemAdsPossible = false;
		haveNotMaxLvCompany = true;
		AdsupplyShowPopup = false;
		GemAdsupplyShowPopup = false;
		OnSkipNight = false;
		ExpUpCompany = 0;
	}

	public void SetGemAdsupply()
	{
		LoadGemAdsupplyData();
		CheckGemAdsOpen();
	}

	public void Create()
	{
		AdSupplyProperty = new ReactiveProperty<Status>(Status.Hide);
		RemainTimeProperty = new ReactiveProperty<int>(0);
		GemAdSupplyProperty = new ReactiveProperty<Status>(Status.Hide);
		GemRemainTimeProperty = new ReactiveProperty<int>(0);
		NightSkipProperty = new ReactiveProperty<Status>(Status.Hide);
		ExpSupplyProperty = new ReactiveProperty<Status>(Status.Hide);
	}

	private void ResetGemAdsCount()
	{
		bGemAdsPossible = true;
		NextGemAdsTime = DateTime.UtcNow;
	}

	private void ResetExpAdsCount()
	{
		bExpAdsPossible = true;
		NextExpAdsTime = DateTime.UtcNow;
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
		if (!bGemAdsPossible) return;
		if (DateTime.UtcNow >= NextGemAdsTime)
		{
			GemAdSupplyProperty.Value = Status.Show;
		}
	}

	private void CheckExpAdsOpen()
	{
		if (!bExpAdsPossible) return;
		int curHour = DateTime.UtcNow.Hour;
		if (curHour >= exp_ad_start_time && curHour < exp_ad_end_time && DateTime.UtcNow >= NextExpAdsTime)
		{
			ExpSupplyProperty.Value = Status.Show;
		}
	}

	private void CheckMoneyAdsOpen()
	{
		if (!bPossible) return;
		AdSupplyProperty.Value = Status.Show;
	}

	public bool AddPiggySaveCnt()
	{
		// Would add to piggy bank save count
		return true;
	}

	public void StartTutorial()
	{
		bPossible = true;
		SetDirectMoneySupply();
	}

	public void CheckMaxLevelCompany()
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		haveNotMaxLvCompany = true; // Would check actual company levels
	}

	private void SetExpUpCompany()
	{
		ExpUpCompany = 0;
		// Would find a company that can receive exp
	}

	public void UpdateDaySkipStatus()
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.DaySystem == null) return;
		float dayTime = root.DaySystem.DayTime;
		if (dayTime >= dayskip_ad_offtime)
		{
			NightSkipProperty.Value = Status.Show;
		}
		else
		{
			NightSkipProperty.Value = Status.Hide;
		}
	}

	public void SkipNight()
	{
		OnSkipNight = true;
		NightSkipProperty.Value = Status.Hide;
	}

	public void RefreshReward()
	{
		SetReward();
	}

	private void SetReward()
	{
	}

	private void SetSeasonalReward()
	{
	}

	public void SetDirectMoneySupply()
	{
		bPossible = true;
		RemainTimeProperty.Value = supply_ad_appear_cooltime;
		AdSupplyProperty.Value = Status.Show;
		SetReward();
	}

	public void SetMoneySupplyReward()
	{
		SetReward();
	}

	public void CancelSupply()
	{
		bPossible = false;
		AdSupplyProperty.Value = Status.Hide;
		RemainTimeProperty.Value = supply_ad_appear_cooltime;
	}

	public void CancelGemSupply()
	{
		GemAdSupplyProperty.Value = Status.Hide;
		NextGemAdsTime = DateTime.UtcNow.AddSeconds(gem_supply_ad_cooltime);
		GemRemainTimeProperty.Value = gem_supply_ad_cooltime;
		SaveGemAdsupplyData();
	}

	public void CancelSeasonalSupply()
	{
	}

	public void UpdateAdsMoneyOneSeconds()
	{
		if (AdSupplyProperty.Value == Status.Hide)
		{
			if (RemainTimeProperty.Value > 0)
			{
				RemainTimeProperty.Value = RemainTimeProperty.Value - 1;
				if (RemainTimeProperty.Value <= 0)
				{
					CheckMoneyAdsOpen();
				}
			}
		}
	}

	public void UpdateAdsGemOneSeconds()
	{
		if (GemAdSupplyProperty.Value == Status.Hide)
		{
			if (GemRemainTimeProperty.Value > 0)
			{
				GemRemainTimeProperty.Value = GemRemainTimeProperty.Value - 1;
				if (GemRemainTimeProperty.Value <= 0)
				{
					CheckGemAdsOpen();
				}
			}
		}
	}

	public void UpdateAdsExpOneSeconds()
	{
		CheckExpAdsOpen();
	}

	public void ShowExpAd(GameObject obj, int company, BigInteger exp, Action cb)
	{
		ExpUpCompany = company;
		ExpSupplyProperty.Value = Status.Hide;
		NextExpAdsTime = DateTime.UtcNow.AddSeconds(exp_ad_cooltime);
		cb?.Invoke();
	}

	public void SkipExpAd()
	{
		ExpSupplyProperty.Value = Status.Hide;
		NextExpAdsTime = DateTime.UtcNow.AddSeconds(exp_ad_cooltime);
	}

	public void ShowGemAd(Action cb, Action FailCb)
	{
		GemAdSupplyProperty.Value = Status.Hide;
		CancelGemSupply();
		cb?.Invoke();
	}

	public void ShowAd(GameObject obj, ShowType type, Action<int, int, int, BigInteger> Cb, Action FailCb)
	{
		AdsupplyShowPopup = true;
		AdSupplyProperty.Value = Status.Hide;
		// Would show ad via ad SDK, then call Cb on success or FailCb on failure
	}

	public void GetReward(Action<int, int, int, BigInteger> Cb)
	{
		CancelSupply();
		// Would give reward and call Cb
	}
}
