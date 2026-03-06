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

	public Image OneTimeCurrencyIcon { get { return oneTimeCurrencyIcon; } }

	protected override void Awake()
	{
		base.Awake();
		disposables = new CompositeDisposable();
	}

	public override void OnShowBefore()
	{
		DrawPage();
	}

	public void ShowPlantFocusing()
	{
		DrawPage();
	}

	private void DrawPage()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		SetList();
		UpdateRewardInfo();
		UpdateProgress();
		SetOneTime();
	}

	private void SetList()
	{
		// Populate quest list from QuestScroll - resource/addressable loading
	}

	private void UpdateRewardInfo()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		var questData = root.UserData.DailyQuestData;
		if (questData == null) return;

		if (CurDayPoint != null) CurDayPoint.text = questData.DayPoint.ToString();
		if (CurWeekPoint != null) CurWeekPoint.text = questData.WeekPoint.ToString();

		if (NextDayResetTime != null)
		{
			int remainSec = (int)(questData.QuestResetTime - System.DateTime.UtcNow).TotalSeconds;
			if (remainSec < 0) remainSec = 0;
			NextDayResetTime.text = ProjectUtility.GetTimeStringFormattingShort(remainSec);
		}

		if (NextWeekResetTime != null)
		{
			int remainSec = (int)(questData.NextWeekResetTime - System.DateTime.UtcNow).TotalSeconds;
			if (remainSec < 0) remainSec = 0;
			NextWeekResetTime.text = ProjectUtility.GetTimeStringFormattingShort(remainSec);
		}

		bool allDailyRewardsClaimed = questData.GetDailyRewards != null && questData.GetDailyRewards.Count > 0;
		if (RewardObj != null) RewardObj.SetActive(!allDailyRewardsClaimed);
		if (RewardLastObj != null) RewardLastObj.SetActive(allDailyRewardsClaimed);
	}

	private void UpdateProgress()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		var questData = root.UserData.DailyQuestData;
		if (questData == null) return;

		if (DayPointProgress != null && MaxPoint > 0)
			DayPointProgress.value = (float)questData.DayPoint / MaxPoint;
	}

	private void CompleteQuest(int quest)
	{
		DrawPage();
	}

	private void ShortcutQuest(int quest)
	{
		Hide();
	}

	private void SetOneTime()
	{
		if (oneTimeUIRoot != null) oneTimeUIRoot.SetActive(false);
		UpdateOneTimeCurrencyIcon();
		UpdateOneTimeCurrencyCount();
	}

	private void UpdateOneTimeCurrencyIcon()
	{
		// Resource loading for currency icon - keep empty
	}

	public void UpdateOneTimeCurrencyCount()
	{
		if (oneTimeCurrencyCount != null) oneTimeCurrencyCount.text = "0";
	}

	private void OnDestroy()
	{
		if (disposables != null) { disposables.Dispose(); disposables = null; }
	}

	private void OnDisable()
	{
		if (disposables != null) { disposables.Dispose(); disposables = new CompositeDisposable(); }
	}
}
