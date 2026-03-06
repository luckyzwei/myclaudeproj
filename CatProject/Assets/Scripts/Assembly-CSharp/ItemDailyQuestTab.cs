using System;
using System.Collections.Generic;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ItemDailyQuestTab : MonoBehaviour, ITabToggleTab
{
	[SerializeField]
	private Text CashText;

	[Header("DayPoint")]
	[SerializeField]
	private Text NextDayResetTime;

	[SerializeField]
	private Text CurDayPoint;

	[SerializeField]
	private SliderTextComponent DayPointProgress;

	[SerializeField]
	private GameObject RewardObj;

	[SerializeField]
	private GameObject RewardLastObj;

	[Header("Quest")]
	[SerializeField]
	private ScrollRect QuestScroll;

	[SerializeField]
	private GameObject QuestItem;

	[Header("Week")]
	[SerializeField]
	private Text NextWeekResetTime;

	[SerializeField]
	private Text CurWeekPoint;

	[SerializeField]
	private List<ItemDailyReward> WeeklyRewards;

	[Header("Onetime")]
	[SerializeField]
	private GameObject oneTimeUIRoot;

	[SerializeField]
	private Image oneTimeCurrencyIcon;

	[SerializeField]
	private Text oneTimeCurrencyCount;

	private float MaxPoint;

	private CompositeDisposable disposables;

	private Action OnGotoNavi;

	public Image OneTimeCurrencyIcon { get { return oneTimeCurrencyIcon; } }

	public void InitTab(Action onGotoNavi)
	{
		OnGotoNavi = onGotoNavi;
		disposables = new CompositeDisposable();
		InitData();
	}

	private void InitData()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		var questData = root.UserData.DailyQuestData;
		if (questData == null) return;
		MaxPoint = 100f;
	}

	public void ShowPlantFocusing()
	{
		// TODO
	}

	private void DrawPage()
	{
		SetList();
		UpdateRewardInfo();
		UpdateProgress(true);
		SetOneTime();
	}

	private void SetList()
	{
		// Update display
	}

	private void UpdateRewardInfo()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		var questData = root.UserData.DailyQuestData;
		if (questData == null) return;

		if (CurDayPoint != null) CurDayPoint.text = questData.DayPoint.ToString();
		if (CurWeekPoint != null) CurWeekPoint.text = questData.WeekPoint.ToString();

		bool rewardDone = questData.DayPoint >= (int)MaxPoint;
		if (RewardObj != null) RewardObj.SetActive(!rewardDone);
		if (RewardLastObj != null) RewardLastObj.SetActive(rewardDone);

		if (WeeklyRewards != null)
		{
			for (int i = 0; i < WeeklyRewards.Count; i++)
			{
				if (WeeklyRewards[i] == null) continue;
			}
		}
	}

	private void UpdateProgress(bool bInit)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		var questData = root.UserData.DailyQuestData;
		if (questData == null) return;

		if (DayPointProgress != null)
		{
			float cur = questData.DayPoint;
			float max = MaxPoint > 0 ? MaxPoint : 1f;
			DayPointProgress.SetValue((int)cur, (int)max, bInit);
		}
	}

	private void CompleteQuest(int quest)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		UpdateRewardInfo();
		UpdateProgress(false);
	}

	private void ShortcutQuest(int quest)
	{
		OnGotoNavi?.Invoke();
	}

	private void SetOneTime()
	{
		if (oneTimeUIRoot == null) return;
		oneTimeUIRoot.SetActive(false);
		UpdateOneTimeCurrencyIcon();
		UpdateOneTimeCurrencyCount();
	}

	private void UpdateOneTimeCurrencyIcon()
	{
		if (oneTimeCurrencyIcon == null) return;
	}

	public void UpdateOneTimeCurrencyCount()
	{
		if (oneTimeCurrencyCount == null) return;
		oneTimeCurrencyCount.text = "0";
	}

	public void Refresh()
	{
		DrawPage();
	}

	public void Reset()
	{
		if (disposables != null)
		{
			disposables.Dispose();
			disposables = new CompositeDisposable();
		}
	}

	private void OnDestroy()
	{
		if (disposables != null) { disposables.Dispose(); disposables = null; }
	}
}
