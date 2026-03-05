using System;
using System.Collections.Generic;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
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
		// Update day/night time icon based on current game time
	}

	protected void UpdateDayTime()
	{
		// Update day time display from DaySystem
	}

	public void OnClickedBackToOfficeBtn()
	{
		// Navigate back to office scene
	}

	private void OnClickedTimeScheduleBtn()
	{
		// Open time schedule popup
	}

	private void OnClickedPopupSkillsBtn()
	{
		// Open skills popup
	}

	private void OnClickedMissionBtn()
	{
		// Open mission popup
	}

	private void OnClickedArcadeMachineBtn()
	{
		// Open arcade machine page
	}

	private void SetHudIconResources()
	{
		// Load and set HUD icon resources (sprites)
	}

	public void SetAdSupplyTween(bool show, bool direct = false)
	{
		ShowHudObjectTween(AdsupplyRoot, AdsupplyBtn != null ? AdsupplyBtn.gameObject : null, -200f, 0f, show, direct);
	}

	private void SetAdSupply()
	{
		// Check ad supply active state
		SetAdSupplyTween(false, true);
	}

	private void OnClickAdSupply()
	{
		// Open ad supply popup
	}

	private void SetNightSkip()
	{
		// Check if night time
		SetNightSkipTween(false, true);
	}

	private void SetNightSkipTween(bool show, bool direct = false)
	{
		ShowHudObjectTween(NightSkipRoot, NightSkipBtn != null ? NightSkipBtn.gameObject : null, -200f, 0f, show, direct);
	}

	private void OnClickNightSkip()
	{
		// Skip night time via ad
	}

	private void OnClickShop()
	{
		// Open shop page
	}

	private void OnClickedOvertimeWorkButton()
	{
		// Toggle overtime work
		var root = Singleton<GameRoot>.Instance;
		if (root == null) return;
	}

	private void SetOvertimeWorkState(bool bActiveOvertimeWork)
	{
		if (OvertimeWorkToggle != null)
			OvertimeWorkToggle.SetToggle(bActiveOvertimeWork);
	}

	private void OnClickStatue()
	{
		// Open statue popup
	}

	public void SetStatue()
	{
		// Update statue button icon
	}

	private void OnClickCoinBank()
	{
		// Open coin bank popup
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
		// Update coin bank value text
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
			// Update piggy bank display
		}
	}

	private void SetPiggyBank()
	{
		if (PiggyBankComponent == null) return;
		// Initialize piggy bank component
	}

	public void UpdatePackage()
	{
		if (PackageComp != null)
		{
			// Update package component
		}
	}

	public void UpdateEnabledSkillBook()
	{
		if (PopupSkillsBtnImage == null) return;
		// Update skill book button enabled state
	}

	private void OnClickedOptionBtn()
	{
		// Open game option popup
	}

	private void OnDistributeProduct(int productIdx, BigInteger sellingPrice_PerMile)
	{
		// Handle distribute product event - show coin effect
	}

	private void SubscribeSaleProduct()
	{
		// Subscribe to distributor sale product events
	}

	private void UpdatePauseSelling()
	{
		// Update distributor button soldout state
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
		// Open worker manager popup
	}

	private void UpdateWorkerCount()
	{
		if (text_totalWorkerCount == null) return;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		// text_totalWorkerCount.text = workerCount.ToString();
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
		// Set no-ads button icon/sale state
		if (NoAdsSaleObj != null) NoAdsSaleObj.SetActive(false);
	}

	private void OnClickNoAds()
	{
		// Open no-ads purchase page
	}

	private void OnClickSeasonalPass()
	{
		// Open seasonal pass page
	}

	private void OnClickStepReward()
	{
		// Open step reward page
	}

	private void OnClickSlotCoinBuff()
	{
		// Open slot coin buff popup
	}

	private void OnClickCoinRank()
	{
		// Open coin rank popup
	}

	private void OnClickDistributorShortcut()
	{
		// Navigate to distributor
	}

	private void OnClickRestaurantShortcut()
	{
		// Navigate to restaurant
	}
}
