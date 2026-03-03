using System;
using System.Collections.Generic;
using Treeplla;
using UniRx;
using UnityEngine;

public class OneTimeEventSystem
{
	public struct OnetimeRewardData
	{
		public int type;

		public int idx;

		public int region;

		public int value;

		public string icon;

		public OnetimeRewardData(int _type, int _idx, int _region, int _value, string _icon)
		{
			type = 0;
			idx = 0;
			region = 0;
			value = 0;
			icon = null;
		}
	}

	public int SIMPLE_MODE_ON_PLAY_COUNT;

	private int ONCE_USE_COUNT;

	private int BONUS_ONE_TIME_START_LIMIT_TIME_SEC;

	private List<OneTimeSpecialRewardData> CurSpecialRewards;

	public IReactiveProperty<bool> ShowOneTimeUI;

	public IReactiveProperty<int> RemainEndTime;

	private DateTime curEndTime;

	private int RemainCompanyResetTime;

	public int MaxLevel { get; private set; }

	public bool IsRewardReddot { get; private set; }

	public bool IsCurrencyReddot { get; private set; }

	public int CurIdx { get; private set; }

	public int CurThemeIdx { get; private set; }

	public bool IsSpecialOneTime { get; private set; }

	private bool isSystemInit { get; set; }

	public bool IsEnqueueOpenPopup { get; set; }

	public bool IsEnqueueDonePopup { get; set; }

	public void Init(bool reset = false)
	{
	}

	private void SubscribeContentOpen()
	{
	}

	private void UpdateOneTimeEvent()
	{
	}

	public void OpenOneTimeEvent(bool cheatInit = false)
	{
	}

	private void DoneOneTimeEvent()
	{
	}

	private void CompleteOneTimeEvent(Action hideCb)
	{
	}

	public void UpdateShowOneTimeUI()
	{
	}

	public void ShowOneTimePage()
	{
	}

	private void ShowOpenPopup()
	{
	}

	private void ShowBonusOneTimeOpenPopup()
	{
	}

	private void ShowDonePopup()
	{
	}

	private bool CheckSpecialDayAtlas()
	{
		return false;
	}

	public void UpdateOneSeconds()
	{
	}

	private DateTime GetEndTime()
	{
		return default(DateTime);
	}

	private bool CheckMaxReceive()
	{
		return false;
	}

	public bool CheckMaxLevel()
	{
		return false;
	}

	private void SetCurEventIdx()
	{
	}

	public int GetCurEventIdx()
	{
		return 0;
	}

	public int GetCurEventResIdx()
	{
		return 0;
	}

	public Sprite GetOnetimeHUDIcon()
	{
		return null;
	}

	public string GetOnetimeHUDIconString()
	{
		return null;
	}

	public Sprite GetOnetimeHUDCurrencyIcon()
	{
		return null;
	}

	public Sprite GetOnetimeCurrencyIcon()
	{
		return null;
	}

	public void AddOneTimeEventCurrency(int value)
	{
	}

	public void UseOneTimeEventCurrency(int remainExp, bool isSimpleMode, Action levelUpCb, Action<int> playAnyCb)
	{
	}

	public void SetOneTimeReceiveLevel(int curLevel)
	{
	}

	public bool IsOnSimpleMode()
	{
		return false;
	}

	private void GetOneTimeRewards(int level, List<OnetimeRewardData> data, bool isPurchase)
	{
	}

	public void GetOneTimeMainRewards(out int type, out int rewardIdx, out int value, out string icon)
	{
		type = default(int);
		rewardIdx = default(int);
		value = default(int);
		icon = null;
	}

	public bool IsContainOneTimeReward(int type, int idx)
	{
		return false;
	}

	public void CheckActiveBonusOneTime()
	{
	}

	public void SetAllOneTimeHUDReddot()
	{
	}

	public void UpdateOneTimeHUDReddot()
	{
	}

	public void UpdateRewardReddot(bool isUpdate = true)
	{
	}

	public void UpdateCurrencyReddot(bool isUpdate = true)
	{
	}

	private void InitCompanyResetData()
	{
	}

	private void ResetOneTimeOneDayData()
	{
	}

	private void ResetCompanyResetData(bool isSave = true)
	{
	}

	private void LogOpenOneTime()
	{
	}

	private void LogLevelUp(int level)
	{
	}

	private void LogLevelMax()
	{
	}

	private void LogGetReward(int level, bool isPurchase)
	{
	}

	private void LogGetAllReward()
	{
	}

	public void LogEnterPage()
	{
	}

	private void LogPurchase1()
	{
	}

	private void LogPurchase2()
	{
	}

	private void LogPurchase3()
	{
	}

	private void LogPurchase4()
	{
	}
}
