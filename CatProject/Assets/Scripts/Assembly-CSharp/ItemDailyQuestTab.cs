using System;
using System.Collections.Generic;
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

	public Image OneTimeCurrencyIcon { get { return null; } }

	public void InitTab(Action onGotoNavi)
	{
	}

	private void InitData()
	{
	}

	public void ShowPlantFocusing()
	{
	}

	private void DrawPage()
	{
	}

	private void SetList()
	{
	}

	private void UpdateRewardInfo()
	{
	}

	private void UpdateProgress(bool bInit)
	{
	}

	private void CompleteQuest(int quest)
	{
	}

	private void ShortcutQuest(int quest)
	{
	}

	private void SetOneTime()
	{
	}

	private void UpdateOneTimeCurrencyIcon()
	{
	}

	public void UpdateOneTimeCurrencyCount()
	{
	}

	public void Refresh()
	{
	}

	public void Reset()
	{
	}

	private void OnDestroy()
	{
	}
}
