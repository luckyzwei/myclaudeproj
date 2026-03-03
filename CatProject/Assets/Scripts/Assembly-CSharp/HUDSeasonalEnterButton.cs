using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class HUDSeasonalEnterButton : MonoBehaviour
{
	[SerializeField]
	private Image SeasonMainImage;

	[SerializeField]
	private Image SeasonMainIcon;

	[SerializeField]
	private GameObject NewSeasonNoticeObj;

	[Header("Milestone")]
	[SerializeField]
	private GameObject MilestoneProgressObj;

	[SerializeField]
	private Text MilestoneProgressText;

	[SerializeField]
	private Slider MilestoneProgressSlider;

	[Header("Time")]
	[SerializeField]
	private Text SeasonEndRemainTimeText;

	[Header("EnterButton")]
	[SerializeField]
	private Button EnterButton;

	[Header("PrevSeason")]
	[SerializeField]
	private GameObject PrevSeasonRewardNoticeObj;

	[SerializeField]
	private Button PrevSeasonRewardNoticeBtn;

	[SerializeField]
	private Text PrevSeasonRewardLimitTimeText;

	[Header("NextSeason")]
	[SerializeField]
	private GameObject NextSeasonStartNotiText;

	[SerializeField]
	private GameObject SeasonLockObj;

	[Header("Notification")]
	[SerializeField]
	private GameObject FreeCoinNotiObj;

	[SerializeField]
	private GameObject OfflineRewardNotiObj;

	private DateTime SeasonEndDateTime;

	private int PrevSeasonInfoIdx;

	private DateTime PrevSeasonRewardLimitTime;

	private CompositeDisposable Disposables;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void UpdateSeasonInfo()
	{
	}

	private void UpdateNotification()
	{
	}

	private void SetPreOpenState(SeasonScheduleInfo seasonScheduleInfo, bool isActiveSchedule)
	{
	}

	private void SetNowSeasonInfo(int seasonInfoIdx)
	{
	}

	private void SetNextSeasonSchedule(SeasonScheduleInfo seasonScheduleInfo)
	{
	}

	private void SetPrevSeasonRewardInfo(bool bExist)
	{
	}

	private void OnClickedEnterButton()
	{
	}

	private void OnClickedPrevSeasonRewardNoticeBtn()
	{
	}

	private void SetSeasonMainImage(string imageKey)
	{
	}

	private void SetSeasonMainIcon(string iconKey)
	{
	}

	private void SetProgressInfo(int curStep, int maxStep)
	{
	}

	private void SetProgressStepText(int curStep, int maxStep)
	{
	}

	private void SetProgressSliderRatio(int curStep, int maxStep)
	{
	}

	private void SetSeasonRemainTime(int remainSec)
	{
	}

	private void SetPrevSeasonRewardLimitTime(int remainSec)
	{
	}
}
