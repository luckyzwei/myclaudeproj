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
			type = _type;
			idx = _idx;
			region = _region;
			value = _value;
			icon = _icon;
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
		ShowOneTimeUI = new ReactiveProperty<bool>(false);
		RemainEndTime = new ReactiveProperty<int>(0);
		CurSpecialRewards = new List<OneTimeSpecialRewardData>();
		SIMPLE_MODE_ON_PLAY_COUNT = 10;
		ONCE_USE_COUNT = 1;
		BONUS_ONE_TIME_START_LIMIT_TIME_SEC = 600;
		MaxLevel = 0;
		IsRewardReddot = false;
		IsCurrencyReddot = false;
		isSystemInit = true;
		if (!reset)
			SubscribeContentOpen();
		SetCurEventIdx();
		UpdateOneTimeEvent();
	}

	private void SubscribeContentOpen()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.ContentsOpenSystem == null) return;
		root.ContentsOpenSystem.Subscribe(Config.ContentsOpenType.Level, () =>
		{
			SetCurEventIdx();
			UpdateOneTimeEvent();
		});
	}

	private void UpdateOneTimeEvent()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		var data = root.UserData.OneTimeEventData;
		if (data == null) return;
		CurIdx = data.OneTimeIdx != null ? data.OneTimeIdx.Value : 0;
		curEndTime = GetEndTime();
		UpdateShowOneTimeUI();
	}

	public void OpenOneTimeEvent(bool cheatInit = false)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		var data = root.UserData.OneTimeEventData;
		if (data == null) return;
		if (data.OneTimeIdx == null)
			data.OneTimeIdx = new ReactiveProperty<int>(0);
		if (data.OneTimeCurrency == null)
			data.OneTimeCurrency = new ReactiveProperty<int>(0);
		curEndTime = GetEndTime();
		UpdateShowOneTimeUI();
		LogOpenOneTime();
	}

	private void DoneOneTimeEvent()
	{
		ShowOneTimeUI.Value = false;
		ShowDonePopup();
	}

	private void CompleteOneTimeEvent(Action hideCb)
	{
		ShowOneTimeUI.Value = false;
		hideCb?.Invoke();
	}

	public void UpdateShowOneTimeUI()
	{
		if (ShowOneTimeUI == null) return;
		bool show = CurIdx > 0 && !CheckMaxReceive();
		ShowOneTimeUI.Value = show;
	}

	public void ShowOneTimePage()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null) return;
		LogEnterPage();
	}

	private void ShowOpenPopup()
	{
		IsEnqueueOpenPopup = true;
	}

	private void ShowBonusOneTimeOpenPopup()
	{
		IsEnqueueOpenPopup = true;
	}

	private void ShowDonePopup()
	{
		IsEnqueueDonePopup = true;
	}

	private bool CheckSpecialDayAtlas()
	{
		return IsSpecialOneTime;
	}

	public void UpdateOneSeconds()
	{
		if (RemainEndTime == null) return;
		var remain = (int)(curEndTime - DateTime.UtcNow).TotalSeconds;
		if (remain < 0) remain = 0;
		RemainEndTime.Value = remain;
		if (remain <= 0 && ShowOneTimeUI.Value)
		{
			DoneOneTimeEvent();
		}
	}

	private DateTime GetEndTime()
	{
		return DateTime.UtcNow.AddHours(24);
	}

	private bool CheckMaxReceive()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return true;
		var data = root.UserData.OneTimeEventData;
		if (data == null) return true;
		return data.OneTimeReceiveLevel >= MaxLevel && MaxLevel > 0;
	}

	public bool CheckMaxLevel()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return false;
		var data = root.UserData.OneTimeEventData;
		if (data == null) return false;
		return data.OneTimeLevel >= MaxLevel && MaxLevel > 0;
	}

	private void SetCurEventIdx()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		var data = root.UserData.OneTimeEventData;
		if (data == null) return;
		CurIdx = data.OneTimeIdx != null ? data.OneTimeIdx.Value : 0;
	}

	public int GetCurEventIdx()
	{
		return CurIdx;
	}

	public int GetCurEventResIdx()
	{
		return CurThemeIdx;
	}

	public Sprite GetOnetimeHUDIcon()
	{
		return null;
	}

	public string GetOnetimeHUDIconString()
	{
		return "";
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
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		var data = root.UserData.OneTimeEventData;
		if (data == null || data.OneTimeCurrency == null) return;
		data.OneTimeCurrency.Value += value;
		UpdateCurrencyReddot();
	}

	public void UseOneTimeEventCurrency(int remainExp, bool isSimpleMode, Action levelUpCb, Action<int> playAnyCb)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		var data = root.UserData.OneTimeEventData;
		if (data == null || data.OneTimeCurrency == null) return;

		int useCount = ONCE_USE_COUNT;
		if (data.OneTimeCurrency.Value < useCount) return;

		data.OneTimeCurrency.Value -= useCount;
		if (remainExp <= 0)
		{
			// Level up
			data.OneTimeLevel++;
			LogLevelUp(data.OneTimeLevel);
			if (data.OneTimeLevel >= MaxLevel)
				LogLevelMax();
			levelUpCb?.Invoke();
		}
		else
		{
			playAnyCb?.Invoke(remainExp);
		}
		UpdateCurrencyReddot();
		root.UserData.Save();
	}

	public void SetOneTimeReceiveLevel(int curLevel)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		var data = root.UserData.OneTimeEventData;
		if (data == null) return;
		data.OneTimeReceiveLevel = curLevel;
		UpdateRewardReddot();
		root.UserData.Save();
	}

	public bool IsOnSimpleMode()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return false;
		return root.GamePlayTimeSec != null && root.GamePlayTimeSec.Value >= SIMPLE_MODE_ON_PLAY_COUNT;
	}

	private void GetOneTimeRewards(int level, List<OnetimeRewardData> data, bool isPurchase)
	{
		if (data == null) return;
		LogGetReward(level, isPurchase);
	}

	public void GetOneTimeMainRewards(out int type, out int rewardIdx, out int value, out string icon)
	{
		type = 0;
		rewardIdx = 0;
		value = 0;
		icon = null;
		if (CurSpecialRewards != null && CurSpecialRewards.Count > 0)
		{
			var reward = CurSpecialRewards[0];
			type = reward.RewardType;
			rewardIdx = reward.RewardIdx;
			value = reward.RewardValue;
			icon = reward.Icon;
		}
	}

	public bool IsContainOneTimeReward(int type, int idx)
	{
		if (CurSpecialRewards == null) return false;
		for (int i = 0; i < CurSpecialRewards.Count; i++)
		{
			if (CurSpecialRewards[i] != null && CurSpecialRewards[i].RewardType == type && CurSpecialRewards[i].RewardIdx == idx)
				return true;
		}
		return false;
	}

	public void CheckActiveBonusOneTime()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	public void SetAllOneTimeHUDReddot()
	{
		UpdateRewardReddot(false);
		UpdateCurrencyReddot(false);
	}

	public void UpdateOneTimeHUDReddot()
	{
		UpdateRewardReddot();
		UpdateCurrencyReddot();
	}

	public void UpdateRewardReddot(bool isUpdate = true)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		var data = root.UserData.OneTimeEventData;
		if (data == null) { IsRewardReddot = false; return; }
		IsRewardReddot = data.OneTimeLevel > data.OneTimeReceiveLevel;
	}

	public void UpdateCurrencyReddot(bool isUpdate = true)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		var data = root.UserData.OneTimeEventData;
		if (data == null) { IsCurrencyReddot = false; return; }
		IsCurrencyReddot = data.OneTimeCurrency != null && data.OneTimeCurrency.Value > 0;
	}

	private void InitCompanyResetData()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		var data = root.UserData.OneTimeEventData;
		if (data == null) return;
		RemainCompanyResetTime = data.OneTimeCompanyResetCount;
	}

	private void ResetOneTimeOneDayData()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		var data = root.UserData.OneTimeEventData;
		if (data == null) return;
		data.OneTimeCompanyResetCount = 0;
		data.OneTimeCompanyResetTime = DateTime.UtcNow;
		root.UserData.Save();
	}

	private void ResetCompanyResetData(bool isSave = true)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		var data = root.UserData.OneTimeEventData;
		if (data == null) return;
		data.OneTimeCompanyResetCount = 0;
		if (isSave)
			root.UserData.Save();
	}

	private void LogOpenOneTime()
	{
		Debug.Log($"[OneTimeEvent] Open OneTime Event idx:{CurIdx}");
	}

	private void LogLevelUp(int level)
	{
		Debug.Log($"[OneTimeEvent] LevelUp level:{level}");
	}

	private void LogLevelMax()
	{
		Debug.Log($"[OneTimeEvent] LevelMax idx:{CurIdx}");
	}

	private void LogGetReward(int level, bool isPurchase)
	{
		Debug.Log($"[OneTimeEvent] GetReward level:{level} isPurchase:{isPurchase}");
	}

	private void LogGetAllReward()
	{
		Debug.Log($"[OneTimeEvent] GetAllReward idx:{CurIdx}");
	}

	public void LogEnterPage()
	{
		Debug.Log($"[OneTimeEvent] EnterPage idx:{CurIdx}");
	}

	private void LogPurchase1()
	{
		Debug.Log("[OneTimeEvent] Purchase1");
	}

	private void LogPurchase2()
	{
		Debug.Log("[OneTimeEvent] Purchase2");
	}

	private void LogPurchase3()
	{
		Debug.Log("[OneTimeEvent] Purchase3");
	}

	private void LogPurchase4()
	{
		Debug.Log("[OneTimeEvent] Purchase4");
	}
}
