using System;
using System.Collections.Generic;
using System.Numerics;
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

	public Vector3 GetQuestBtnPos => default(Vector3);

	protected override void Awake()
	{
	}

	public override void OnShowBefore()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public void InitTopInfo(List<TopInfoData> topInfoDataList)
	{
	}

	public void SetTutorialVisibility(bool bShow)
	{
	}

	private void InitTopCurrencyInfo(List<TopInfoData> topInfoDataList)
	{
	}

	private void SubscribeEvents()
	{
	}

	private void OnStartGame(bool bStart)
	{
	}

	private void UpdateMyRank(int rank)
	{
	}

	public void UpdateTimeIcon()
	{
	}

	protected void UpdateDayTime()
	{
	}

	public void OnClickedBackToOfficeBtn()
	{
	}

	private void OnClickedTimeScheduleBtn()
	{
	}

	private void OnClickedPopupSkillsBtn()
	{
	}

	private void OnClickedMissionBtn()
	{
	}

	private void OnClickedArcadeMachineBtn()
	{
	}

	private void SetHudIconResources()
	{
	}

	public void SetAdSupplyTween(bool show, bool direct = false)
	{
	}

	private void SetAdSupply()
	{
	}

	private void OnClickAdSupply()
	{
	}

	private void SetNightSkip()
	{
	}

	private void SetNightSkipTween(bool show, bool direct = false)
	{
	}

	private void OnClickNightSkip()
	{
	}

	private void OnClickShop()
	{
	}

	private void OnClickedOvertimeWorkButton()
	{
	}

	private void SetOvertimeWorkState(bool bActiveOvertimeWork)
	{
	}

	private void OnClickStatue()
	{
	}

	public void SetStatue()
	{
	}

	private void OnClickCoinBank()
	{
	}

	public Vector3 GetCoinBankPos()
	{
		return default(Vector3);
	}

	public void UpdateCoinBankValue()
	{
	}

	public Vector3 GetPiggyBankPos()
	{
		return default(Vector3);
	}

	public void UpdatePiggyValue()
	{
	}

	private void SetPiggyBank()
	{
	}

	public void UpdatePackage()
	{
	}

	public void UpdateEnabledSkillBook()
	{
	}

	private void OnClickedOptionBtn()
	{
	}

	private void OnDistributeProduct(int productIdx, BigInteger sellingPrice_PerMile)
	{
	}

	private void SubscribeSaleProduct()
	{
	}

	private void UpdatePauseSelling()
	{
	}

	private void OnAddNewWorker(int prevCnt, int curCnt)
	{
	}

	private HUDSeasonalNotice GetOrCreateSeasonalNoticeObject()
	{
		return null;
	}

	private void ShowHudObjectTween(GameObject rootObject, GameObject targetObject, float fromXPos, float toXpos, bool show, bool direct = false)
	{
	}

	private void OnClickWorkerManager()
	{
	}

	private void UpdateWorkerCount()
	{
	}

	public void SetNoAds()
	{
	}

	private void UpdateNoAdsIcon()
	{
	}

	private void OnClickNoAds()
	{
	}

	private void OnClickSeasonalPass()
	{
	}

	private void OnClickStepReward()
	{
	}

	private void OnClickSlotCoinBuff()
	{
	}

	private void OnClickCoinRank()
	{
	}

	private void OnClickDistributorShortcut()
	{
	}

	private void OnClickRestaurantShortcut()
	{
	}
}
