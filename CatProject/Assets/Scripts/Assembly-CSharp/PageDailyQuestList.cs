using System.Collections.Generic;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupDailyQuestList", false, false)]
public class PageDailyQuestList : UIBase
{
	[SerializeField]
	private Text CashText;

	[Header("DayPoint")]
	[SerializeField]
	private Text NextDayResetTime;

	[SerializeField]
	private Text CurDayPoint;

	[SerializeField]
	private Slider DayPointProgress;

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

	public Image OneTimeCurrencyIcon { get { return null; } }

	protected override void Awake()
	{
	}

	public override void OnShowBefore()
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

	private void UpdateProgress()
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

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}
}
