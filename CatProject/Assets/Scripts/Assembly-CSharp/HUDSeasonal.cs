using System;
using System.Collections.Generic;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using Vector2 = UnityEngine.Vector2;
using DG.Tweening;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/HUDSeasonal", true, false)]
public class HUDSeasonal : HUDBaseSeasonal
{
	[Header("Worker")]
	[SerializeField]
	private Button btn_WorkerManager;

	[SerializeField]
	private Text text_totalWorkerCount;

	[SerializeField]
	private GameObject FreeWorkerRedDot;

	[Header("Day")]
	[SerializeField]
	private Image TimeIcon;

	[SerializeField]
	private Text TimeText;

	[SerializeField]
	private Slider TimeProgress;

	[SerializeField]
	private Button TimeScheduleButton;

	[SerializeField]
	private HUDSeasonalMilestone SeasonalMilestone;

	[SerializeField]
	private Button BackToOfficeBtn;

	[SerializeField]
	private Button MissionBtn;

	[SerializeField]
	private Button ArcadeMachineBtn;

	[SerializeField]
	private Button RestaurantShortCutBtn;

	[Header("Distributor")]
	[SerializeField]
	private Button DistributorShortCutBtn;

	[SerializeField]
	private Image DistributorShortCutBtnImage;

	[SerializeField]
	private GameObject DistributorSoldoutObj;

	[Header("Skill")]
	[SerializeField]
	private Button PopupSkillsBtn;

	[SerializeField]
	private Image PopupSkillsBtnImage;

	[Header("Adsupply")]
	[SerializeField]
	private GameObject AdsupplyRoot;

	[SerializeField]
	private Button AdsupplyBtn;

	[Header("NightSkip")]
	[SerializeField]
	private GameObject NightSkipRoot;

	[SerializeField]
	private Button NightSkipBtn;

	[Header("Shop")]
	[SerializeField]
	private Button ShopBtn;

	[Header("OvertimeWork")]
	[SerializeField]
	private Button OvertimeWorkButton;

	[SerializeField]
	private ToggleController OvertimeWorkToggle;

	[Header("Statue")]
	[SerializeField]
	private Button StatueBtn;

	[SerializeField]
	private Image StatueImg;

	[SerializeField]
	private Button SeasonalPassBtn;

	[Header("CoinBank")]
	[SerializeField]
	private Button CoinBankBtn;

	[SerializeField]
	private Image CoinBankIcon;

	[SerializeField]
	private Text CoinBankValueText;

	[SerializeField]
	private GameObject CoinBankReddot;

	[SerializeField]
	private DoTweenScriptComponent CoinBankTween;

	[Header("PiggyBank")]
	[SerializeField]
	private HUDPiggyBankComponent PiggyBankComponent;

	[Header("Package")]
	[SerializeField]
	private HudPackageComponent PackageComp;

	[Header("SeasonalStepReward")]
	[SerializeField]
	private Button StepRewardBtn;

	[Header("GameOption")]
	[SerializeField]
	private Button GameOptionBtn;

	[Header("SeasonalNotice")]
	[SerializeField]
	private GameObject NoticeListObj;

	[SerializeField]
	private GameObject NoticePrefabObj;

	[Header("Mood")]
	[SerializeField]
	private HUDSeasonalWorkerMood WorkersMood;

	[Header("Buff")]
	[SerializeField]
	private Button btnSlotCoinBuff;

	[SerializeField]
	private Text textSlotCoinBuffEndTime;

	[SerializeField]
	private GameObject objMissionCoinBuff;

	[SerializeField]
	private Text textMissionCoinBuffEndTime;

	[Header("Rank")]
	[SerializeField]
	private GameObject rankRoot;

	[SerializeField]
	private Button btnRank;

	[SerializeField]
	private Text textRankEndTime;

	[SerializeField]
	private Text textRankEndTimeInHudTop;

	[SerializeField]
	private Text textMyRank;

	[SerializeField]
	private Image imgRank;

	[Header("Tutorial")]
	[SerializeField]
	private List<GameObject> TutorialVisibilityObj;

	[Header("NoAds")]
	[SerializeField]
	private Button NoAdsBtn;

	[SerializeField]
	private Image NoAdsIcon;

	[SerializeField]
	private Image NoAdsIcon2;

	[SerializeField]
	private Text NoAdsSaleRemainTime;

	[SerializeField]
	private GameObject NoAdsSaleObj;

	[SerializeField]
	private Text NoAdsSale;

	private CompositeDisposable noadssale_disposables;

	private bool bStartGame;

	private List<TopInfoData> TopInfoDataList;

	private List<HUDSeasonalNotice> SeasonalNoticeList;

	private CompositeDisposable Disposables;

	private IDisposable OvertimeWorkDisposable;

	private IDisposable SkillBookEnableDisposable;

	public Vector3 GetQuestBtnPos { get { return MissionBtn != null ? MissionBtn.transform.position : default(Vector3); } }

	protected override void Awake()
	{
		base.Awake();
		Disposables = new CompositeDisposable();
		noadssale_disposables = new CompositeDisposable();
		SeasonalNoticeList = new List<HUDSeasonalNotice>();
		bStartGame = false;

		// Bind button listeners
		if (BackToOfficeBtn != null) BackToOfficeBtn.onClick.AddListener(OnClickedBackToOfficeBtn);
		if (TimeScheduleButton != null) TimeScheduleButton.onClick.AddListener(OnClickedTimeScheduleBtn);
		if (PopupSkillsBtn != null) PopupSkillsBtn.onClick.AddListener(OnClickedPopupSkillsBtn);
		if (MissionBtn != null) MissionBtn.onClick.AddListener(OnClickedMissionBtn);
		if (ArcadeMachineBtn != null) ArcadeMachineBtn.onClick.AddListener(OnClickedArcadeMachineBtn);
		if (AdsupplyBtn != null) AdsupplyBtn.onClick.AddListener(OnClickAdSupply);
		if (NightSkipBtn != null) NightSkipBtn.onClick.AddListener(OnClickNightSkip);
		if (ShopBtn != null) ShopBtn.onClick.AddListener(OnClickShop);
		if (OvertimeWorkButton != null) OvertimeWorkButton.onClick.AddListener(OnClickedOvertimeWorkButton);
		if (StatueBtn != null) StatueBtn.onClick.AddListener(OnClickStatue);
		if (CoinBankBtn != null) CoinBankBtn.onClick.AddListener(OnClickCoinBank);
		if (SeasonalPassBtn != null) SeasonalPassBtn.onClick.AddListener(OnClickSeasonalPass);
		if (StepRewardBtn != null) StepRewardBtn.onClick.AddListener(OnClickStepReward);
		if (GameOptionBtn != null) GameOptionBtn.onClick.AddListener(OnClickedOptionBtn);
		if (NoAdsBtn != null) NoAdsBtn.onClick.AddListener(OnClickNoAds);
		if (btn_WorkerManager != null) btn_WorkerManager.onClick.AddListener(OnClickWorkerManager);
		if (btnSlotCoinBuff != null) btnSlotCoinBuff.onClick.AddListener(OnClickSlotCoinBuff);
		if (btnRank != null) btnRank.onClick.AddListener(OnClickCoinRank);
		if (DistributorShortCutBtn != null) DistributorShortCutBtn.onClick.AddListener(OnClickDistributorShortcut);
		if (RestaurantShortCutBtn != null) RestaurantShortCutBtn.onClick.AddListener(OnClickRestaurantShortcut);
	}

	public override void OnShowBefore()
	{
		SubscribeEvents();
		SetHudIconResources();
		SetAdSupply();
		SetNightSkip();
		SetStatue();
		SetPiggyBank();
		SetNoAds();
		UpdateWorkerCount();
		UpdateDayTime();
		UpdateCoinBankValue();
		UpdatePackage();
		UpdateEnabledSkillBook();
	}

	private void OnDestroy()
	{
		if (Disposables != null)
		{
			Disposables.Dispose();
			Disposables = null;
		}
		if (noadssale_disposables != null)
		{
			noadssale_disposables.Dispose();
			noadssale_disposables = null;
		}
		if (OvertimeWorkDisposable != null)
		{
			OvertimeWorkDisposable.Dispose();
			OvertimeWorkDisposable = null;
		}
		if (SkillBookEnableDisposable != null)
		{
			SkillBookEnableDisposable.Dispose();
			SkillBookEnableDisposable = null;
		}
	}

	private void Update()
	{
		if (!bStartGame) return;
		UpdateDayTime();
	}

	public void InitTopInfo(List<TopInfoData> topInfoDataList)
	{
		TopInfoDataList = topInfoDataList;
		InitTopCurrencyInfo(topInfoDataList);
	}

	public void SetTutorialVisibility(bool bShow)
	{
		if (TutorialVisibilityObj == null) return;
		for (int i = 0; i < TutorialVisibilityObj.Count; i++)
		{
			if (TutorialVisibilityObj[i] != null)
				TutorialVisibilityObj[i].SetActive(bShow);
		}
	}

	private void InitTopCurrencyInfo(List<TopInfoData> topInfoDataList)
	{
		if (CurrencyHud != null)
			CurrencyHud.SetCurrencyInfo(topInfoDataList);
	}

	private void SubscribeEvents()
	{
		if (Disposables != null)
		{
			Disposables.Dispose();
			Disposables = new CompositeDisposable();
		}
		var root = Singleton<GameRoot>.Instance;
		if (root == null) return;

		SubscribeSaleProduct();
	}

	private void OnStartGame(bool bStart)
	{
		bStartGame = bStart;
	}

	private void UpdateMyRank(int rank)
	{
		if (textMyRank != null)
			textMyRank.text = rank > 0 ? rank.ToString() : "-";
	}

	public void UpdateTimeIcon()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.DaySystem == null) return;
	}

	protected void UpdateDayTime()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.DaySystem == null) return;
		float dayTime = root.DaySystem.DayTime;
		if (TimeProgress != null) TimeProgress.value = dayTime;
		UpdateTimeIcon();
	}

	public void OnClickedBackToOfficeBtn()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root != null && root.InGameSystem != null)
			root.InGameSystem.ChangeMode(GameType.Main);
	}

	private void OnClickedTimeScheduleBtn()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupSeasonalTimeSchedule>();
	}

	private void OnClickedPopupSkillsBtn()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupSkills>();
	}

	private void OnClickedMissionBtn()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupSeasonalMission>();
	}

	private void OnClickedArcadeMachineBtn()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PageArcadeSlotMachine>();
	}

	private void SetHudIconResources()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.SeasonalSystem == null) return;
	}

	public void SetAdSupplyTween(bool show, bool direct = false)
	{
		ShowHudObjectTween(AdsupplyRoot, AdsupplyBtn != null ? AdsupplyBtn.gameObject : null, -200f, 0f, show, direct);
	}

	private void SetAdSupply()
	{
		SetAdSupplyTween(false, true);
	}

	private void OnClickAdSupply()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupSeasonalAdsSupply>();
	}

	private void SetNightSkip()
	{
		SetNightSkipTween(false, true);
	}

	private void SetNightSkipTween(bool show, bool direct = false)
	{
		ShowHudObjectTween(NightSkipRoot, NightSkipBtn != null ? NightSkipBtn.gameObject : null, -200f, 0f, show, direct);
	}

	private void OnClickNightSkip()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupAdsNightSkip>();
	}

	private void OnClickShop()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PageSeasonalShop>();
	}

	private void OnClickedOvertimeWorkButton()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null) return;
	}

	private void SetOvertimeWorkState(bool bActiveOvertimeWork)
	{
		if (OvertimeWorkToggle != null)
			OvertimeWorkToggle.Toggle(bActiveOvertimeWork);
	}

	private void OnClickStatue()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupStatueGallery>();
	}

	public void SetStatue()
	{
		if (StatueBtn == null) return;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.SeasonalSystem == null) return;
		StatueBtn.gameObject.SetActive(true);
	}

	private void OnClickCoinBank()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupPiggyBank>();
	}

	public Vector3 GetCoinBankPos()
	{
		if (CoinBankBtn != null) return CoinBankBtn.transform.position;
		return default(Vector3);
	}

	public void UpdateCoinBankValue()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		var shopData = root.UserData.ShopData;
		if (shopData == null) return;
		if (CoinBankValueText != null) CoinBankValueText.text = shopData.PiggyValue.ToString();
		if (CoinBankReddot != null) CoinBankReddot.SetActive(shopData.PiggyValue > 0);
	}

	public Vector3 GetPiggyBankPos()
	{
		if (PiggyBankComponent != null) return PiggyBankComponent.transform.position;
		return default(Vector3);
	}

	public void UpdatePiggyValue()
	{
		if (PiggyBankComponent != null)
		{
			PiggyBankComponent.UpdatePiggyValue();
		}
	}

	private void SetPiggyBank()
	{
		if (PiggyBankComponent == null) return;
		PiggyBankComponent.UpdatePiggyValue();
	}

	public void UpdatePackage()
	{
		if (PackageComp != null)
		{
			PackageComp.Refresh();
		}
	}

	public void UpdateEnabledSkillBook()
	{
		if (PopupSkillsBtnImage == null) return;
	}

	private void OnClickedOptionBtn()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupOption>();
	}

	private void OnDistributeProduct(int productIdx, BigInteger sellingPrice_PerMile)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.InGameSystem == null) return;
	}

	private void SubscribeSaleProduct()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.SeasonalSystem == null) return;
		UpdatePauseSelling();
	}

	private void UpdatePauseSelling()
	{
		if (DistributorSoldoutObj != null) DistributorSoldoutObj.SetActive(false);
	}

	private void OnAddNewWorker(int prevCnt, int curCnt)
	{
		UpdateWorkerCount();
		if (FreeWorkerRedDot != null)
			FreeWorkerRedDot.SetActive(false);
	}

	private HUDSeasonalNotice GetOrCreateSeasonalNoticeObject()
	{
		if (NoticeListObj == null || NoticePrefabObj == null) return null;

		// Try reuse inactive notice
		if (SeasonalNoticeList != null)
		{
			for (int i = 0; i < SeasonalNoticeList.Count; i++)
			{
				if (SeasonalNoticeList[i] != null && !SeasonalNoticeList[i].gameObject.activeSelf)
					return SeasonalNoticeList[i];
			}
		}

		// Create new
		var go = Instantiate(NoticePrefabObj, NoticeListObj.transform);
		var notice = go.GetComponent<HUDSeasonalNotice>();
		if (notice != null)
		{
			if (SeasonalNoticeList == null) SeasonalNoticeList = new List<HUDSeasonalNotice>();
			SeasonalNoticeList.Add(notice);
		}
		return notice;
	}

	private void ShowHudObjectTween(GameObject rootObject, GameObject targetObject, float fromXPos, float toXpos, bool show, bool direct = false)
	{
		if (rootObject == null) return;
		rootObject.SetActive(true);
		var rt = rootObject.GetComponent<RectTransform>();
		if (rt == null) return;

		if (direct)
		{
			rt.anchoredPosition = new Vector2(show ? toXpos : fromXPos, rt.anchoredPosition.y);
			if (!show) rootObject.SetActive(false);
		}
		else
		{
			float target = show ? toXpos : fromXPos;
			rt.DOAnchorPosX(target, 0.3f).OnComplete(() =>
			{
				if (!show) rootObject.SetActive(false);
			});
		}
	}

	private void OnClickWorkerManager()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupSeasonalWorker>();
	}

	private void UpdateWorkerCount()
	{
		if (text_totalWorkerCount == null) return;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	public void SetNoAds()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.ShopSystem == null) return;
		bool noAds = root.ShopSystem.NoAds;
		if (NoAdsBtn != null) NoAdsBtn.gameObject.SetActive(!noAds);
		UpdateNoAdsIcon();
	}

	private void UpdateNoAdsIcon()
	{
		if (NoAdsSaleObj != null) NoAdsSaleObj.SetActive(false);
	}

	private void OnClickNoAds()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupNoAds>();
	}

	private void OnClickSeasonalPass()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PageSeasonalPass>();
	}

	private void OnClickStepReward()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void OnClickSlotCoinBuff()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PageArcadeSlotMachine>();
	}

	private void OnClickCoinRank()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PageSeasonalSlotRank>();
	}

	private void OnClickDistributorShortcut()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupDistributorMenu>();
	}

	private void OnClickRestaurantShortcut()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupSeasonalShortcut>();
	}
}
