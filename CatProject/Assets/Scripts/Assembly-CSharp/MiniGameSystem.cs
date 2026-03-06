using System;
using Treeplla;
using UniRx;
using UnityEngine;

public class MiniGameSystem : SystemBase
{
	public static class DigTreasureHunt
	{
		public static readonly Vector2Int OneCellSize;
	}

	public bool bNeedEnqueueMiniGameOpenPopup;

	public bool bNeedEnqueueMiniGameDonePopup;

	public IReactiveProperty<int> EventRemainTimeSec;

	public Subject<int> OnChangeNowScheduleInfo;

	private MiniGameBase NowMiniGame;

	public bool CHEAT_ON;

	public MiniGameScheduleInfo NowMiniGameScheduleInfo { get; private set; }

	public MiniGameScheduleInfo NextMiniGameScheduleInfo { get; private set; }

	public int NowScheduleIdx
	{
		get
		{
			return NowMiniGameScheduleInfo != null ? NowMiniGameScheduleInfo.ScheduleIndex : 0;
		}
	}

	public int NowEventIdx
	{
		get
		{
			return NowMiniGameScheduleInfo != null ? NowMiniGameScheduleInfo.EventIdx : 0;
		}
	}

	public int UseCurrencyIdx { get; private set; }

	public int FreeItemMaxCount { get; private set; }

	public override void InitSystem()
	{
		EventRemainTimeSec = new ReactiveProperty<int>();
		OnChangeNowScheduleInfo = new Subject<int>();
		NowMiniGameScheduleInfo = new MiniGameScheduleInfo();
		NextMiniGameScheduleInfo = new MiniGameScheduleInfo();
		FreeItemMaxCount = 5;
		InitData();
	}

	public override void OnChangeScene()
	{
	}

	public void UpdateOneSecond()
	{
		if (NowMiniGameScheduleInfo == null || NowMiniGameScheduleInfo.IsEmpty())
			return;

		DateTime now = DateTime.UtcNow;
		int remain = (int)(NowMiniGameScheduleInfo.Endtime - now).TotalSeconds;
		EventRemainTimeSec.Value = Math.Max(0, remain);

		if (remain <= 0)
		{
			SetScheduleInfo();
		}
	}

	private void InitData()
	{
		SetScheduleInfo();
		InitCommonData();
		InitNowMiniGameModule();
	}

	private void SetScheduleInfo()
	{
		OnChangeNowScheduleInfo.OnNext(NowScheduleIdx);
	}

	private void InitCommonData()
	{
		UseCurrencyIdx = 0;
	}

	private void InitNowMiniGameModule()
	{
		if (NowMiniGameScheduleInfo == null || NowMiniGameScheduleInfo.IsEmpty())
			return;

	}

	private void CheckAndOpenMiniGameDonePopup(int lastPlayScheduleIdx, Action onEndAction)
	{
		if (bNeedEnqueueMiniGameDonePopup)
		{
			bNeedEnqueueMiniGameDonePopup = false;
			OpenMiniGameDonePopup(onEndAction);
		}
		else
		{
			onEndAction?.Invoke();
		}
	}

	private void CheckAndOpenMiniGameOpenPopup(Action onEndAction)
	{
		if (bNeedEnqueueMiniGameOpenPopup)
		{
			bNeedEnqueueMiniGameOpenPopup = false;
			OpenMiniGameOpenPopup(onEndAction);
		}
		else
		{
			onEndAction?.Invoke();
		}
	}

	public MiniGameBase GetNowMiniGameBase()
	{
		return NowMiniGame;
	}

	public T GetNowMiniGame<T>() where T : MiniGameBase
	{
		return NowMiniGame as T;
	}

	public int GetGameStage()
	{
		var userData = Singleton<GameRoot>.Instance.UserData;
		if (userData?.MiniGameUserData == null)
			return 0;

		return 0;
	}

	public bool IsGameClear()
	{
		var userData = Singleton<GameRoot>.Instance.UserData;
		if (userData?.MiniGameUserData == null)
			return false;

		return false;
	}

	public bool IsProgressRewardClaimed(int index)
	{
		return false;
	}

	public bool ClaimProgressReward(int index)
	{
		if (IsProgressRewardClaimed(index))
			return false;

		return false;
	}

	public void OpenMiniGameOpenPopup(Action onEndAction)
	{
		onEndAction?.Invoke();
	}

	public void OpenMiniGameDonePopup(Action onEndAction)
	{
		onEndAction?.Invoke();
	}

	public void OnShownOpenPopup()
	{
		var userData = Singleton<GameRoot>.Instance.UserData;
		userData?.MiniGameUserData?.OnShownOpenPopup();
		bNeedEnqueueMiniGameOpenPopup = false;
	}

	public int GetRemainFreeItemCount()
	{
		var userData = Singleton<GameRoot>.Instance.UserData;
		if (userData?.MiniGameUserData == null)
			return FreeItemMaxCount;

		return FreeItemMaxCount;
	}

	public void AddExchangeItemBuyCount(int itemIdx, int buyCount)
	{
		var data = GetExchangeItemData(itemIdx);
		if (data != null)
		{
			data.AddItemBuyCount(buyCount);
		}
	}

	public int GetExchangeItemBuyCount(int itemIdx)
	{
		var data = GetExchangeItemData(itemIdx);
		return data != null ? data.ItemBuyCount : 0;
	}

	private ExchangeShopUserData GetExchangeItemData(int itemIdx)
	{
		return null;
	}
}
