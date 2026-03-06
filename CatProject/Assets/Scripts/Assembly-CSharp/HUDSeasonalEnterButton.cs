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
		Disposables = new CompositeDisposable();
		if (EnterButton != null)
			EnterButton.onClick.AddListener(OnClickedEnterButton);
		if (PrevSeasonRewardNoticeBtn != null)
			PrevSeasonRewardNoticeBtn.onClick.AddListener(OnClickedPrevSeasonRewardNoticeBtn);
	}

	private void OnDestroy()
	{
		if (Disposables != null)
		{
			Disposables.Dispose();
			Disposables = null;
		}
	}

	private void Start()
	{
		UpdateSeasonInfo();
		UpdateNotification();
	}

	private void Update()
	{
		if (SeasonEndDateTime > DateTime.MinValue)
		{
			int remainSec = (int)(SeasonEndDateTime - DateTime.UtcNow).TotalSeconds;
			SetSeasonRemainTime(remainSec);
		}
		if (PrevSeasonRewardLimitTime > DateTime.MinValue && PrevSeasonRewardNoticeObj != null && PrevSeasonRewardNoticeObj.activeSelf)
		{
			int remainSec = (int)(PrevSeasonRewardLimitTime - DateTime.UtcNow).TotalSeconds;
			SetPrevSeasonRewardLimitTime(remainSec);
		}
	}

	private void UpdateSeasonInfo()
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.SeasonalSystem == null) return;
	}

	private void UpdateNotification()
	{
		if (FreeCoinNotiObj != null)
			FreeCoinNotiObj.SetActive(false);
		if (OfflineRewardNotiObj != null)
			OfflineRewardNotiObj.SetActive(false);
	}

	private void SetPreOpenState(SeasonScheduleInfo seasonScheduleInfo, bool isActiveSchedule)
	{
		if (SeasonLockObj != null)
			SeasonLockObj.SetActive(!isActiveSchedule);
		if (NextSeasonStartNotiText != null)
			NextSeasonStartNotiText.SetActive(!isActiveSchedule);
	}

	private void SetNowSeasonInfo(int seasonInfoIdx)
	{
		if (SeasonLockObj != null) SeasonLockObj.SetActive(false);
		if (NextSeasonStartNotiText != null) NextSeasonStartNotiText.SetActive(false);
		if (NewSeasonNoticeObj != null) NewSeasonNoticeObj.SetActive(false);
	}

	private void SetNextSeasonSchedule(SeasonScheduleInfo seasonScheduleInfo)
	{
		if (SeasonLockObj != null) SeasonLockObj.SetActive(true);
	}

	private void SetPrevSeasonRewardInfo(bool bExist)
	{
		if (PrevSeasonRewardNoticeObj != null)
			PrevSeasonRewardNoticeObj.SetActive(bExist);
	}

	private void OnClickedEnterButton()
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.InGameSystem == null) return;
		root.InGameSystem.ChangeMode(GameType.Seasonal);
	}

	private void OnClickedPrevSeasonRewardNoticeBtn()
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null) return;
		root.WaitAndOpenUICoroutine<PopupSeasonalDone>();
	}

	private void SetSeasonMainImage(string imageKey)
	{
		if (SeasonMainImage == null || string.IsNullOrEmpty(imageKey)) return;
	}

	private void SetSeasonMainIcon(string iconKey)
	{
		if (SeasonMainIcon == null || string.IsNullOrEmpty(iconKey)) return;
	}

	private void SetProgressInfo(int curStep, int maxStep)
	{
		SetProgressStepText(curStep, maxStep);
		SetProgressSliderRatio(curStep, maxStep);
	}

	private void SetProgressStepText(int curStep, int maxStep)
	{
		if (MilestoneProgressText != null)
			MilestoneProgressText.text = curStep + "/" + maxStep;
	}

	private void SetProgressSliderRatio(int curStep, int maxStep)
	{
		if (MilestoneProgressSlider != null)
			MilestoneProgressSlider.value = maxStep > 0 ? (float)curStep / maxStep : 0f;
	}

	private void SetSeasonRemainTime(int remainSec)
	{
		if (SeasonEndRemainTimeText == null) return;
		if (remainSec <= 0)
		{
			SeasonEndRemainTimeText.text = "";
			return;
		}
		int days = remainSec / 86400;
		int hours = (remainSec % 86400) / 3600;
		int mins = (remainSec % 3600) / 60;
		SeasonEndRemainTimeText.text = string.Format("{0}d {1:D2}:{2:D2}", days, hours, mins);
	}

	private void SetPrevSeasonRewardLimitTime(int remainSec)
	{
		if (PrevSeasonRewardLimitTimeText == null) return;
		if (remainSec <= 0)
		{
			PrevSeasonRewardNoticeObj?.SetActive(false);
			return;
		}
		int hours = remainSec / 3600;
		int mins = (remainSec % 3600) / 60;
		int secs = remainSec % 60;
		PrevSeasonRewardLimitTimeText.text = string.Format("{0:D2}:{1:D2}:{2:D2}", hours, mins, secs);
	}
}
