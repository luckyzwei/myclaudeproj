using System;
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

	public int NowScheduleIdx { get { return 0; } }

	public int NowEventIdx { get { return 0; } }

	public int UseCurrencyIdx { get; private set; }

	public int FreeItemMaxCount { get; private set; }

	public override void InitSystem()
	{
		EventRemainTimeSec = new ReactiveProperty<int>();
		OnChangeNowScheduleInfo = new Subject<int>();
	}

	public override void OnChangeScene()
	{
	}

	public void UpdateOneSecond()
	{
	}

	private void InitData()
	{
	}

	private void SetScheduleInfo()
	{
	}

	private void InitCommonData()
	{
	}

	private void InitNowMiniGameModule()
	{
	}

	private void CheckAndOpenMiniGameDonePopup(int lastPlayScheduleIdx, Action onEndAction)
	{
	}

	private void CheckAndOpenMiniGameOpenPopup(Action onEndAction)
	{
	}

	public MiniGameBase GetNowMiniGameBase()
	{
		return null;
	}

	public T GetNowMiniGame<T>() where T : MiniGameBase
	{
		return null;
	}

	public int GetGameStage()
	{
		return 0;
	}

	public bool IsGameClear()
	{
		return false;
	}

	public bool IsProgressRewardClaimed(int index)
	{
		return false;
	}

	public bool ClaimProgressReward(int index)
	{
		return false;
	}

	public void OpenMiniGameOpenPopup(Action onEndAction)
	{
	}

	public void OpenMiniGameDonePopup(Action onEndAction)
	{
	}

	public void OnShownOpenPopup()
	{
	}

	public int GetRemainFreeItemCount()
	{
		return 0;
	}

	public void AddExchangeItemBuyCount(int itemIdx, int buyCount)
	{
	}

	public int GetExchangeItemBuyCount(int itemIdx)
	{
		return 0;
	}

	private ExchangeShopUserData GetExchangeItemData(int itemIdx)
	{
		return null;
	}
}
