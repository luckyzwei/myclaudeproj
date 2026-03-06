using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/HUDTotal", true, false)]
public class HUDTotal : HUDBase, IScreenAction
{
	[CompilerGenerated]
	private sealed class _003CShowCrossPromotionEffect_003Ed__220 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HUDTotal _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CShowCrossPromotionEffect_003Ed__220(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CWaitComebackCo_003Ed__291 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HUDTotal _003C_003E4__this;

		public bool value;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CWaitComebackCo_003Ed__291(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private HUDType[] aniType;

	private bool appear;

	private bool screenAction;

	[Header("[HUDTotal]")]
	[SerializeField]
	private GameObject TotalRoot;

	[SerializeField]
	private List<GameObject> LeftRoot;

	[SerializeField]
	private List<GameObject> RightRoot;

	private List<float> originLeftPos;

	private List<float> originRightPos;

	[Header("Level")]
	[SerializeField]
	private DoTweenScriptComponent LvTween;

	[Header("MoneyValue")]
	[SerializeField]
	private Slider RentalFeeProgress;

	[SerializeField]
	private Text EarnValueText;

	[SerializeField]
	private Text ToastEarnValueText;

	[SerializeField]
	private Text EarnTimeText;

	[SerializeField]
	private GameObject EarnValueToast;

	[SerializeField]
	private Text AddRewardBuffText;

	[SerializeField]
	private Button OfficeManagementBtn;

	[Header("Shop")]
	[SerializeField]
	private Button ShopBtn;

	[Header("Roulette")]
	[SerializeField]
	private Button RouletteBtn;

	[Header("Adsupply")]
	[SerializeField]
	private GameObject AdsupplyRoot;

	[SerializeField]
	private Button AdsupplyBtn;

	[Header("GemAdsupply")]
	[SerializeField]
	private GameObject GemAdsupplyRoot;

	[SerializeField]
	private Button GemAdsupplyBtn;

	[Header("ExpAdsupply")]
	[SerializeField]
	private GameObject ExpsupplyRoot;

	[SerializeField]
	private Button ExpAdsupplyBtn;

	[Header("NightSkip")]
	[SerializeField]
	private GameObject NightskipRoot;

	[SerializeField]
	private Button NightSkipBtn;

	[Header("Offline")]
	[SerializeField]
	private GameObject OfflineRoot;

	[SerializeField]
	private Button OfflineBtn;

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

	[Header("AdPass")]
	[SerializeField]
	private Button AdPassBtn;

	[SerializeField]
	private Text AdPassTimeText;

	[SerializeField]
	private Text AdPassCountText;

	private CompositeDisposable adpass_disposables;

	[Header("GemPass")]
	[SerializeField]
	private Button GemPassBtn;

	[SerializeField]
	private Image GemPassIcon;

	[SerializeField]
	private Image GemPassIcon2;

	[SerializeField]
	private GameObject GemPassSaleObj;

	[SerializeField]
	private Text GemPassText;

	[SerializeField]
	private Text GemPassSaleText;

	private CompositeDisposable playerlvpasssale_disposables;

	[Header("Mission")]
	[SerializeField]
	private Button MissionBtn;

	[SerializeField]
	private HUDMissionMilestoneComponent MissionMilestoneComp;

	[SerializeField]
	private HudMissionItem HudMissionItem;

	[Header("Worldmap")]
	[SerializeField]
	private Button WorldmapBtn;

	[Header("Phone")]
	[SerializeField]
	private Button PhoneBtn;

	[SerializeField]
	private DoTweenScriptComponent PhoneTween;

	[Header("Option")]
	[SerializeField]
	private Button OptionBtn;

	[SerializeField]
	[Header("CrossPromotion")]
	private GameObject CrossPromotionRoot;

	[SerializeField]
	private Button CrossPromotionBtn;

	[Header("Floor")]
	[SerializeField]
	private GameObject FloorRoot;

	[SerializeField]
	private Text FloorText;

	[SerializeField]
	private Button FloorUpBtn;

	[SerializeField]
	private Button FloorDownBtn;

	private int MaxFloor;

	[Header("PiggyBank")]
	[SerializeField]
	private Button PiggyBtn;

	[SerializeField]
	private Text PiggyCount;

	[SerializeField]
	private Image PiggyIcon;

	[SerializeField]
	private GameObject PiggyReddot;

	[SerializeField]
	private DoTweenScriptComponent PiggyTween;

	[Header("Package")]
	[SerializeField]
	private HudPackageComponent PackageComp;

	[SerializeField]
	private GameObject PackageNoTimeLimitObj;

	[SerializeField]
	private Button PackageNoTimeLimitBtn;

	[SerializeField]
	private GameObject FirstManagerPackageObj;

	[SerializeField]
	private Button FirstManagerPackageBtn;

	[Header("OneTime")]
	[SerializeField]
	private Button oneTimeBtn;

	[SerializeField]
	private Image oneTimeIcon;

	[SerializeField]
	private GameObject OneTimeContent;

	[SerializeField]
	private Text OneTimeRemainTimeText;

	[SerializeField]
	private GameObject OneTimeCurrencyRoot;

	[SerializeField]
	private Image OneTimeCurCurrencyIcon;

	[SerializeField]
	private Text OneTimeCurCurrencyCount;

	[SerializeField]
	private OnetimeCurrencyComponent OneTimeComponent;

	[SerializeField]
	private GameObject oneTimeReddot;

	private CompositeDisposable onetime_disposables;

	[Header("Factory")]
	[SerializeField]
	private GameObject FactoryStorageRoot;

	[SerializeField]
	private Button FactoryStorageBtn;

	[SerializeField]
	private GameObject FactoryBuyRoot;

	[SerializeField]
	private Button FactoryBuyBtn;

	private bool isOnOrder;

	[Header("Invest")]
	[SerializeField]
	private Button InvestBtn;

	[SerializeField]
	private Text InvestRatioText;

	private CompositeDisposable invest_disposables;

	[Header("MultiRevenue")]
	[SerializeField]
	private Button MultiRevenueBtn;

	[SerializeField]
	private GameObject MultiRevenueSaleObj;

	[SerializeField]
	private Text MultiRevenueRemainText;

	[SerializeField]
	private Text MultiRevenueSaleText;

	private CompositeDisposable mrsale_disposables;

	[Header("Recommend")]
	[SerializeField]
	private Button RecommendBtn;

	private Vector2 recommendPos;

	[Header("Manager")]
	[SerializeField]
	private Button ManagerBtn;

	[Header("BizAcq")]
	[SerializeField]
	private Button BizAcqBtn;

	[SerializeField]
	private GameObject BizAcqArrow;

	[SerializeField]
	private GameObject BizAcqLockObj;

	[Header("Offerwall")]
	[SerializeField]
	private Button OfferwallBtn;

	[SerializeField]
	private GameObject OfferwallEventObj;

	[Header("Freecash")]
	[SerializeField]
	private GameObject FreecashRoot;

	[SerializeField]
	private Button FreecashBtn;

	private IDisposable freecash_disposable;

	[Header("ShopSale")]
	[SerializeField]
	private HudShopSaleComponent ShopSaleComp;

	[Header("Tarot")]
	[SerializeField]
	private GameObject TarotRoot;

	[SerializeField]
	private Button TarotBtn;

	[Header("Special Day")]
	[SerializeField]
	private Button SpecialDayBtn;

	[SerializeField]
	private Image SpecialDayIcon;

	[SerializeField]
	private GameObject SpecialDayBtnContent;

	[SerializeField]
	private Text SpecialDayRemainTimeText;

	[SerializeField]
	private GameObject AuctionPassBonusRoot;

	[SerializeField]
	private Button AuctionPassBonusBtn;

	[SerializeField]
	private Text AuctionPassBonusRemainTimeText;

	private CompositeDisposable specialday_disposables;

	[SerializeField]
	private GameObject SpecialDayEffectDeco;

	[Header("Seasonal")]
	[SerializeField]
	private GameObject SeasonalEnterButton;

	[SerializeField]
	private GameObject SeasonalOfflineRoot;

	[SerializeField]
	private Button SeasonalOfflineBtn;

	[Header("OfficeStrike")]
	[SerializeField]
	private GameObject OfficeStrikeRoot;

	[SerializeField]
	private Text OfficeStrikeRemainTimeText;

	private CompositeDisposable officestrike_disposables;

	[Header("OnePlusSix")]
	[SerializeField]
	private Button OnePlusSixBtn;

	[Header("MiniGame")]
	[SerializeField]
	private HUDMiniGameComponent MiniGameComp;

	[Header("Booster")]
	[SerializeField]
	private GameObject ExpBoostObj;

	[SerializeField]
	private GameObject RentalFeeBoostObj;

	private CompositeDisposable booster_disposables;

	[Header("Etc")]
	[SerializeField]
	private GameObject TopRightBGObj;

	[SerializeField]
	private Text segmentText;

	[SerializeField]
	private Text InterstitialText;

	private float timer;

	private IDisposable SeasonalOfflineDisposable;

	private bool IsBizAcqPreOpen;

	private Coroutine ScreenActionCo;

	private List<Tween> ScreenActionTweens;

	public HUDType[] HudType { get { return aniType; } }

	public bool IsAppear { get { return appear; } }

	public bool IsScreenAction { get { return screenAction; } }

	public WaitUntil WaitHUDAppear { get; set; }

	public HudMissionItem GetHudMissionItem { get { return HudMissionItem; } }

	public Button GetMissionBtn { get { return MissionBtn; } }

	public Button GetOneTimeBtn { get { return oneTimeBtn; } }

	public OnetimeCurrencyComponent GetOneTimeComponent { get { return OneTimeComponent; } }

	public GameObject OneTimeReddot { get { return oneTimeReddot; } }

	public bool OfferwallReddot { get; set; }

	protected override void Awake()
	{
		base.Awake();
		WaitHUDAppear = new WaitUntil(() => appear);
		originLeftPos = new List<float>();
		originRightPos = new List<float>();
		ScreenActionTweens = new List<Tween>();

		if (LeftRoot != null)
		{
			for (int i = 0; i < LeftRoot.Count; i++)
			{
				if (LeftRoot[i] != null)
					originLeftPos.Add(LeftRoot[i].transform.localPosition.x);
				else
					originLeftPos.Add(0f);
			}
		}
		if (RightRoot != null)
		{
			for (int i = 0; i < RightRoot.Count; i++)
			{
				if (RightRoot[i] != null)
					originRightPos.Add(RightRoot[i].transform.localPosition.x);
				else
					originRightPos.Add(0f);
			}
		}

		if (ShopBtn != null) ShopBtn.onClick.AddListener(OnClickShop);
		if (OptionBtn != null) OptionBtn.onClick.AddListener(OnClickOption);
		if (MissionBtn != null) MissionBtn.onClick.AddListener(OnClickMission);
		if (ManagerBtn != null) ManagerBtn.onClick.AddListener(OnClickManager);
		if (RouletteBtn != null) RouletteBtn.onClick.AddListener(OnClickRoulette);
		if (PhoneBtn != null) PhoneBtn.onClick.AddListener(OnClickPhone);
		if (WorldmapBtn != null) WorldmapBtn.onClick.AddListener(OnClickWorldmap);
		if (PiggyBtn != null) PiggyBtn.onClick.AddListener(OnClickPiggyBank);
		if (NoAdsBtn != null) NoAdsBtn.onClick.AddListener(OnClickNoAds);
		if (GemPassBtn != null) GemPassBtn.onClick.AddListener(OnClickGemPass);
		if (AdPassBtn != null) AdPassBtn.onClick.AddListener(OnClickAdPass);
		if (CrossPromotionBtn != null) CrossPromotionBtn.onClick.AddListener(OnClickCrossPromotion);
		if (InvestBtn != null) InvestBtn.onClick.AddListener(OnClickInvest);
		if (MultiRevenueBtn != null) MultiRevenueBtn.onClick.AddListener(OnClickMultiRevenue);
		if (RecommendBtn != null) RecommendBtn.onClick.AddListener(OnClickInvite);
		if (BizAcqBtn != null) BizAcqBtn.onClick.AddListener(OnClickBizAcq);
		if (OfferwallBtn != null) OfferwallBtn.onClick.AddListener(OnClickOfferwall);
		if (FreecashBtn != null) FreecashBtn.onClick.AddListener(OnClickFreecash);
		if (oneTimeBtn != null) oneTimeBtn.onClick.AddListener(OnClickOneTime);
		if (SpecialDayBtn != null) SpecialDayBtn.onClick.AddListener(OnClickSpecialDay);
		if (OfficeManagementBtn != null) OfficeManagementBtn.onClick.AddListener(OnClickOfficeManagement);
		if (AdsupplyBtn != null) AdsupplyBtn.onClick.AddListener(OnClickAdSupply);
		if (GemAdsupplyBtn != null) GemAdsupplyBtn.onClick.AddListener(OnClickGemAdSupply);
		if (ExpAdsupplyBtn != null) ExpAdsupplyBtn.onClick.AddListener(OnClickExpAdsupply);
		if (NightSkipBtn != null) NightSkipBtn.onClick.AddListener(OnClickNightSkip);
		if (OfflineBtn != null) OfflineBtn.onClick.AddListener(OnClickOffline);
		if (TarotBtn != null) TarotBtn.onClick.AddListener(OnClickTarot);
		if (FloorUpBtn != null) FloorUpBtn.onClick.AddListener(OnClickFloorUp);
		if (FloorDownBtn != null) FloorDownBtn.onClick.AddListener(OnClickFloorDown);
		if (FactoryStorageBtn != null) FactoryStorageBtn.onClick.AddListener(OnClickFactoryStorage);
		if (FactoryBuyBtn != null) FactoryBuyBtn.onClick.AddListener(OnClickFactoryBuy);
		if (PackageNoTimeLimitBtn != null) PackageNoTimeLimitBtn.onClick.AddListener(OnClickPackageNoTimeLimit);
		if (FirstManagerPackageBtn != null) FirstManagerPackageBtn.onClick.AddListener(OnClickFirstManagerPackage);
		if (OnePlusSixBtn != null) OnePlusSixBtn.onClick.AddListener(OnClickOnePlusSix);
		if (AuctionPassBonusBtn != null) AuctionPassBonusBtn.onClick.AddListener(OnClickAuctionPassBonus);
		if (SeasonalOfflineBtn != null) SeasonalOfflineBtn.onClick.AddListener(OnClickSeasonalOffline);
	}

	public override void OnShowBefore()
	{
		SetLevel();
		SetDayTime();
		SetFloor();
		SetShop();
		SetRentalFee();
		SetPiggyBank();
		SetMission();
		SetManager();
		SetPhone();
		SetRoulette();
		SetFactory();
		SetNoAds();
		SetGemPass();
		SetAdPass();
		SetCrossPromotion();
		SetInvest();
		SetInvite();
		SetOfferwall();
		SetFreecash();
		SetMultiRevenue();
		SetMRSale();
		SetBizAcq();
		SetOneTime();
		SetAdSupply();
		SetGemAdSupply();
		SetExpAdSupply();
		SetNightSkip();
		SetOffline();
		SetTarot();
		SetSpecialDay();
		SetWorldmap();
		SetOfficeStrikeAlert();
		SetOnePlusSix();
		SetBooster();
		SetPackageNoTimeLimit();
		SetFirstManagerPackage();
		SetSeasonalOffline();
		SetSegmentText();
		SetInterstitialText();
		UpdatePackage();
		if (ShopSaleComp != null) ShopSaleComp.Set();
		if (MiniGameComp != null) MiniGameComp.Init();
		appear = true;
	}

	public void SetSegmentText()
	{
		if (segmentText != null)
			segmentText.text = string.Empty;
	}

	public void SetInterstitialText()
	{
		if (InterstitialText != null)
			InterstitialText.text = string.Empty;
	}

	private void Update()
	{
		timer += Time.deltaTime;
		if (timer >= 1f)
		{
			timer = 0f;
			UpdateDayTime();
		}
	}

	private void OnDisable()
	{
		ResetSubscribe();
	}

	private void OnDestroy()
	{
		ResetSubscribe();
	}

	private void ResetSubscribe()
	{
		noadssale_disposables?.Dispose();
		noadssale_disposables = null;
		adpass_disposables?.Dispose();
		adpass_disposables = null;
		playerlvpasssale_disposables?.Dispose();
		playerlvpasssale_disposables = null;
		onetime_disposables?.Dispose();
		onetime_disposables = null;
		invest_disposables?.Dispose();
		invest_disposables = null;
		mrsale_disposables?.Dispose();
		mrsale_disposables = null;
		specialday_disposables?.Dispose();
		specialday_disposables = null;
		officestrike_disposables?.Dispose();
		officestrike_disposables = null;
		booster_disposables?.Dispose();
		booster_disposables = null;
		freecash_disposable?.Dispose();
		freecash_disposable = null;
		SeasonalOfflineDisposable?.Dispose();
		SeasonalOfflineDisposable = null;
	}

	public override void Refresh(E_RefreshType refreshType)
	{
		switch (refreshType)
		{
			case E_RefreshType.ShopSale:
				if (ShopSaleComp != null) ShopSaleComp.Set();
				break;
			case E_RefreshType.SpecialDay:
				UpdateSpecialDay();
				break;
			case E_RefreshType.Package:
				UpdatePackage();
				break;
			case E_RefreshType.MiniGame:
				if (MiniGameComp != null) MiniGameComp.Init();
				break;
		}
	}

	public override Vector3 GetHUDPos(E_HUDPosType posType, int rewardType = 0, int rewardIdx = 0)
	{
		switch (posType)
		{
			case E_HUDPosType.RentalFee:
				return RentalFeeProgress != null ? RentalFeeProgress.transform.position : default(Vector3);
			default:
				return default(Vector3);
		}
	}

	public void SetActiveRoot(bool isActive)
	{
		if (TotalRoot != null)
			TotalRoot.SetActive(isActive);
	}

	public void SetActiveArrow(Config.ContentsOpenType contentsOpenType)
	{
		if (BizAcqArrow != null)
			BizAcqArrow.SetActive(contentsOpenType == Config.ContentsOpenType.Building);
	}

	private void SetLevel()
	{
		if (LvTween != null)
			LvTween.Play();
	}

	private void SetWorldmap()
	{
		if (WorldmapBtn != null)
			WorldmapBtn.gameObject.SetActive(true);
	}

	private void StartWorldmap()
	{
		if (WorldmapBtn != null)
			WorldmapBtn.gameObject.SetActive(true);
	}

	private void StartWorldmapBank()
	{
		if (WorldmapBtn != null)
			WorldmapBtn.gameObject.SetActive(true);
	}

	private void SetFloor()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null) return;
		var inGame = root.InGameSystem;
		if (inGame == null || inGame.CurInGame == null) return;
		var office = inGame.CurInGame as InGameOffice;
		if (office == null || office.Stage == null) return;
		MaxFloor = office.Stage.MaxFloor;
		if (FloorRoot != null)
			FloorRoot.SetActive(MaxFloor > 1);
		UpdateFloor();
	}

	public void UpdateFloor()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null) return;
		var inGame = root.InGameSystem;
		if (inGame == null || inGame.CurInGame == null) return;
		var office = inGame.CurInGame as InGameOffice;
		if (office == null || office.Stage == null) return;
		int curFloor = office.Stage.CurFloor;
		if (FloorText != null)
			FloorText.text = (curFloor + 1).ToString();
		if (FloorUpBtn != null)
			FloorUpBtn.gameObject.SetActive(curFloor < MaxFloor - 1);
		if (FloorDownBtn != null)
			FloorDownBtn.gameObject.SetActive(curFloor > 0);
	}

	private void OnClickFloorUp()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null) return;
		var inGame = root.InGameSystem;
		if (inGame == null || inGame.CurInGame == null) return;
		var office = inGame.CurInGame as InGameOffice;
		if (office == null || office.Stage == null) return;
		office.Stage.FloorUp();
		UpdateFloor();
	}

	private void OnClickFloorDown()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null) return;
		var inGame = root.InGameSystem;
		if (inGame == null || inGame.CurInGame == null) return;
		var office = inGame.CurInGame as InGameOffice;
		if (office == null || office.Stage == null) return;
		office.Stage.FloorDown();
		UpdateFloor();
	}

	private void SetShop()
	{
		if (ShopBtn != null)
			ShopBtn.gameObject.SetActive(true);
	}

	private void OnClickShop()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	public void UpdatePackage()
	{
		if (PackageComp != null)
			PackageComp.Refresh();
	}

	public void SetPackageNoTimeLimit()
	{
		if (PackageNoTimeLimitObj != null)
			PackageNoTimeLimitObj.SetActive(true);
	}

	public void OnClickPackageNoTimeLimit()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	public void SetFirstManagerPackage()
	{
		if (FirstManagerPackageObj != null)
			FirstManagerPackageObj.SetActive(true);
	}

	public void OnClickFirstManagerPackage()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void SetFactory()
	{
		if (FactoryStorageRoot != null)
			FactoryStorageRoot.SetActive(false);
		if (FactoryBuyRoot != null)
			FactoryBuyRoot.SetActive(false);
		isOnOrder = false;
	}

	private void OnClickFactoryOrder()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupFactoryOrder>();
	}

	private void OnClickFactoryStorage()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupFactoryStorage>();
	}

	private void OnClickFactoryBuy()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	public void SetStorageTween(bool show, bool direct = false)
	{
		if (FactoryStorageRoot == null) return;
		if (direct)
		{
			FactoryStorageRoot.SetActive(show);
			return;
		}
		if (show)
		{
			FactoryStorageRoot.SetActive(true);
			FactoryStorageRoot.transform.localScale = Vector3.zero;
			FactoryStorageRoot.transform.DOScale(Vector3.one, 0.3f).SetEase(Ease.OutBack);
		}
		else
		{
			FactoryStorageRoot.transform.DOScale(Vector3.zero, 0.2f).SetEase(Ease.InBack)
				.OnComplete(() => FactoryStorageRoot.SetActive(false));
		}
	}

	public void SetOpenTween(bool show, bool direct = false)
	{
		if (FactoryBuyRoot == null) return;
		if (direct)
		{
			FactoryBuyRoot.SetActive(show);
			return;
		}
		if (show)
		{
			FactoryBuyRoot.SetActive(true);
			FactoryBuyRoot.transform.localScale = Vector3.zero;
			FactoryBuyRoot.transform.DOScale(Vector3.one, 0.3f).SetEase(Ease.OutBack);
		}
		else
		{
			FactoryBuyRoot.transform.DOScale(Vector3.zero, 0.2f).SetEase(Ease.InBack)
				.OnComplete(() => FactoryBuyRoot.SetActive(false));
		}
	}

	private void SetRentalFee()
	{
		if (RentalFeeProgress != null)
			RentalFeeProgress.value = 0f;
		UpdateAddRewawrdBuff();
	}

	public void UpdateRentalFeeProgress(float value)
	{
		if (RentalFeeProgress != null)
			RentalFeeProgress.value = value;
	}

	public void UpdateAddRewawrdBuff()
	{
		if (AddRewardBuffText != null)
			AddRewardBuffText.text = string.Empty;
	}

	public void ShowEarnToast()
	{
		if (EarnValueToast == null) return;
		EarnValueToast.SetActive(true);
		EarnValueToast.transform.localScale = Vector3.zero;
		EarnValueToast.transform.DOScale(Vector3.one, 0.3f).SetEase(Ease.OutBack)
			.OnComplete(() =>
			{
				DOVirtual.DelayedCall(1.5f, () =>
				{
					if (EarnValueToast != null)
						EarnValueToast.SetActive(false);
				});
			});
	}

	private void OnClickAuctionPassBonus()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void OnClickOfficeManagement()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupOfficeUpgrade>();
	}

	private void SetPiggyBank()
	{
		if (PiggyBtn != null)
			PiggyBtn.gameObject.SetActive(true);
		if (PiggyReddot != null)
			PiggyReddot.SetActive(false);
		UpdatePiggyValue();
	}

	public void UpdatePiggyValue()
	{
		if (PiggyCount == null) return;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		PiggyCount.text = "0";
	}

	private void OnClickPiggyBank()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupPiggyBank>();
	}

	private void SetOneTime()
	{
		if (OneTimeContent != null)
			OneTimeContent.SetActive(false);
		if (oneTimeReddot != null)
			oneTimeReddot.SetActive(false);
		SubscribeOneTime();
	}

	private void SubscribeOneTime()
	{
		onetime_disposables?.Dispose();
		onetime_disposables = new CompositeDisposable();
	}

	public void UpdateOneTimeCurrencyRoot()
	{
		if (OneTimeCurrencyRoot != null)
			OneTimeCurrencyRoot.SetActive(true);
	}

	public void UpdateOneTimeCurrencyIcon()
	{
	}

	public void UpdateOneTimeCurrencyCount()
	{
		if (OneTimeCurCurrencyCount != null)
			OneTimeCurCurrencyCount.text = "0";
	}

	public void OneTimeHUDHideContent()
	{
		if (OneTimeContent != null)
			OneTimeContent.SetActive(false);
	}

	public void OneTimeHUDStartEffect()
	{
		if (OneTimeContent != null)
		{
			OneTimeContent.SetActive(true);
			OneTimeContent.transform.localScale = Vector3.zero;
			OneTimeContent.transform.DOScale(Vector3.one, 0.3f).SetEase(Ease.OutBack);
		}
	}

	private void OnClickOneTime()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupOneTimeEventOpen>();
	}

	public Vector3 GetOneTimePos()
	{
		if (oneTimeBtn != null)
			return oneTimeBtn.transform.position;
		return default(Vector3);
	}

	public void SetNoAds()
	{
		if (NoAdsBtn == null) return;
		noadssale_disposables?.Dispose();
		noadssale_disposables = new CompositeDisposable();
		NoAdsBtn.gameObject.SetActive(true);
		UpdateNoAdsIcon();
	}

	private void UpdateNoAdsIcon()
	{
		if (NoAdsIcon != null) NoAdsIcon.gameObject.SetActive(true);
		if (NoAdsIcon2 != null) NoAdsIcon2.gameObject.SetActive(false);
		if (NoAdsSaleObj != null) NoAdsSaleObj.SetActive(false);
	}

	private void OnClickNoAds()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	public void SetGemPass()
	{
		if (GemPassBtn == null) return;
		playerlvpasssale_disposables?.Dispose();
		playerlvpasssale_disposables = new CompositeDisposable();
		GemPassBtn.gameObject.SetActive(true);
		UpdateGemPassIcon();
	}

	private void UpdateGemPassIcon()
	{
		if (GemPassIcon != null) GemPassIcon.gameObject.SetActive(true);
		if (GemPassIcon2 != null) GemPassIcon2.gameObject.SetActive(false);
		if (GemPassSaleObj != null) GemPassSaleObj.SetActive(false);
	}

	private void OnClickGemPass()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void OnClickOption()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupOption>();
	}

	private void SetAdPass()
	{
		if (AdPassBtn == null) return;
		adpass_disposables?.Dispose();
		adpass_disposables = new CompositeDisposable();
		AdPassBtn.gameObject.SetActive(true);
	}

	public void UpdateAdPass()
	{
		if (AdPassTimeText != null) AdPassTimeText.text = string.Empty;
		if (AdPassCountText != null) AdPassCountText.text = string.Empty;
	}

	private void OnClickAdPass()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void SetCrossPromotion()
	{
		if (CrossPromotionRoot != null)
			CrossPromotionRoot.SetActive(false);
	}

	public void RunCrossPromotionEffect()
	{
		if (CrossPromotionRoot != null)
		{
			CrossPromotionRoot.SetActive(true);
			StartCoroutine(ShowCrossPromotionEffect());
		}
	}

	[IteratorStateMachine(typeof(_003CShowCrossPromotionEffect_003Ed__220))]
	private IEnumerator ShowCrossPromotionEffect()
	{
		if (CrossPromotionRoot != null)
		{
			CrossPromotionRoot.transform.localScale = Vector3.zero;
			CrossPromotionRoot.transform.DOScale(Vector3.one, 0.3f).SetEase(Ease.OutBack);
		}
		yield return new WaitForSeconds(0.3f);
	}

	private void OnClickCrossPromotion()
	{
	}

	private void SetInvest()
	{
		if (InvestBtn == null) return;
		invest_disposables?.Dispose();
		invest_disposables = new CompositeDisposable();
		var root = Singleton<GameRoot>.Instance;
		if (root == null) return;
		bool isOpen = root.ContentsOpenSystem != null;
		InvestBtn.gameObject.SetActive(isOpen);
		UpdateInvest();
	}

	private void UpdateInvest()
	{
		if (InvestRatioText == null) return;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.InvestSystem == null) return;
		InvestRatioText.text = string.Empty;
	}

	private void OnClickInvest()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupInvest>();
	}

	private void SetInvite()
	{
		if (RecommendBtn == null) return;
		RecommendBtn.gameObject.SetActive(true);
		if (RecommendBtn.transform is RectTransform rt)
			recommendPos = rt.anchoredPosition;
	}

	public void RunInviteEffect()
	{
		ShowInviteEffect();
	}

	private void ShowInviteEffect()
	{
		if (RecommendBtn == null) return;
		RecommendBtn.transform.localScale = Vector3.zero;
		RecommendBtn.transform.DOScale(Vector3.one, 0.3f).SetEase(Ease.OutBack);
	}

	private void OnClickInvite()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void SetOfferwall()
	{
		if (OfferwallBtn == null) return;
		OfferwallBtn.gameObject.SetActive(true);
		if (OfferwallEventObj != null)
			OfferwallEventObj.SetActive(OfferwallReddot);
	}

	private void OnClickOfferwall()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void SetFreecash()
	{
		if (FreecashRoot == null) return;
		bool visible = IsVisibleFreecash();
		FreecashRoot.SetActive(visible);
	}

	private void OnClickFreecash()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.FreecashSystem == null) return;
		root.FreecashSystem.OpenUrl();
	}

	private bool IsVisibleFreecash()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.FreecashSystem == null) return false;
		return root.FreecashSystem != null;
	}

	public void SetMRSale()
	{
		mrsale_disposables?.Dispose();
		mrsale_disposables = new CompositeDisposable();
		if (MultiRevenueSaleObj != null)
			MultiRevenueSaleObj.SetActive(false);
	}

	public void SetMultiRevenue()
	{
		if (MultiRevenueBtn == null) return;
		MultiRevenueBtn.gameObject.SetActive(true);
	}

	private void OnClickMultiRevenue()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void SetRoulette()
	{
		if (RouletteBtn == null) return;
		var root = Singleton<GameRoot>.Instance;
		bool isOpen = root != null && root.ContentsOpenSystem != null;
		RouletteBtn.gameObject.SetActive(isOpen);
	}

	private void OnClickRoulette()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void SetPhone()
	{
		if (PhoneBtn == null) return;
		PhoneBtn.gameObject.SetActive(true);
	}

	private void StartPhone()
	{
		if (PhoneTween != null)
			PhoneTween.Play();
	}

	private void OnClickPhone()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupPhone>();
	}

	private void SetMission()
	{
		if (MissionBtn == null) return;
		MissionBtn.gameObject.SetActive(true);
		if (MissionMilestoneComp != null)
			MissionMilestoneComp.Init();
	}

	private void OnClickMission()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupMission>();
	}

	private void SetManager()
	{
		if (ManagerBtn == null) return;
		var root = Singleton<GameRoot>.Instance;
		bool isOpen = root != null && root.ContentsOpenSystem != null;
		ManagerBtn.gameObject.SetActive(isOpen);
	}

	private void OnClickManager()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void SetBizAcq()
	{
		if (BizAcqBtn == null) return;
		var root = Singleton<GameRoot>.Instance;
		bool isOpen = root != null && root.ContentsOpenSystem != null && root.ContentsOpenSystem.IsContentsOpen(ContentsOpenSystem.OpenConditionType.Level, 0);
		BizAcqBtn.gameObject.SetActive(isOpen);
		if (BizAcqLockObj != null)
			BizAcqLockObj.SetActive(!isOpen);
		IsBizAcqPreOpen = false;
	}

	private void OnClickBizAcq()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	public void SetAdSupplyTween(bool show, bool direct = false)
	{
		if (AdsupplyRoot == null) return;
		if (direct) { AdsupplyRoot.SetActive(show); return; }
		if (show)
		{
			AdsupplyRoot.SetActive(true);
			AdsupplyRoot.transform.localScale = Vector3.zero;
			AdsupplyRoot.transform.DOScale(Vector3.one, 0.3f).SetEase(Ease.OutBack);
		}
		else
		{
			AdsupplyRoot.transform.DOScale(Vector3.zero, 0.2f).SetEase(Ease.InBack)
				.OnComplete(() => AdsupplyRoot.SetActive(false));
		}
	}

	private void SetAdSupply()
	{
		if (AdsupplyRoot != null) AdsupplyRoot.SetActive(false);
	}

	private void OnClickAdSupply()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupAdsSupply>();
	}

	public void SetGemAdSupplyTween(bool show, bool direct = false)
	{
		if (GemAdsupplyRoot == null) return;
		if (direct) { GemAdsupplyRoot.SetActive(show); return; }
		if (show)
		{
			GemAdsupplyRoot.SetActive(true);
			GemAdsupplyRoot.transform.localScale = Vector3.zero;
			GemAdsupplyRoot.transform.DOScale(Vector3.one, 0.3f).SetEase(Ease.OutBack);
		}
		else
		{
			GemAdsupplyRoot.transform.DOScale(Vector3.zero, 0.2f).SetEase(Ease.InBack)
				.OnComplete(() => GemAdsupplyRoot.SetActive(false));
		}
	}

	private void SetGemAdSupply()
	{
		if (GemAdsupplyRoot != null) GemAdsupplyRoot.SetActive(false);
	}

	private void OnClickGemAdSupply()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupAdsSupply>();
	}

	private void SetExpAdSupplyTween(bool show, bool direct = false)
	{
		if (ExpsupplyRoot == null) return;
		if (direct) { ExpsupplyRoot.SetActive(show); return; }
		if (show)
		{
			ExpsupplyRoot.SetActive(true);
			ExpsupplyRoot.transform.localScale = Vector3.zero;
			ExpsupplyRoot.transform.DOScale(Vector3.one, 0.3f).SetEase(Ease.OutBack);
		}
		else
		{
			ExpsupplyRoot.transform.DOScale(Vector3.zero, 0.2f).SetEase(Ease.InBack)
				.OnComplete(() => ExpsupplyRoot.SetActive(false));
		}
	}

	private void SetExpAdSupply()
	{
		if (ExpsupplyRoot != null) ExpsupplyRoot.SetActive(false);
	}

	private void OnClickExpAdsupply()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupAdsSupply>();
	}

	private void SetNightSkip()
	{
		if (NightskipRoot != null) NightskipRoot.SetActive(false);
	}

	private void SetNightSkipTween(bool show, bool direct = false)
	{
		if (NightskipRoot == null) return;
		if (direct) { NightskipRoot.SetActive(show); return; }
		if (show)
		{
			NightskipRoot.SetActive(true);
			NightskipRoot.transform.localScale = Vector3.zero;
			NightskipRoot.transform.DOScale(Vector3.one, 0.3f).SetEase(Ease.OutBack);
		}
		else
		{
			NightskipRoot.transform.DOScale(Vector3.zero, 0.2f).SetEase(Ease.InBack)
				.OnComplete(() => NightskipRoot.SetActive(false));
		}
	}

	private void OnClickNightSkip()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root != null && root.DaySystem != null)
			root.DaySystem.SkipNight();
	}

	public void UpdateOffline()
	{
		if (OfflineRoot == null) return;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		var curMode = root.UserData.CurMode;
		bool hasOffline = curMode != null && curMode.RegionData?.OfflineData != null && curMode.RegionData.OfflineData.TotalOfflineTime > 0;
		OfflineRoot.SetActive(hasOffline);
	}

	private void SetOffline()
	{
		if (OfflineRoot != null) OfflineRoot.SetActive(false);
	}

	private void SetOfflineTween(bool show, bool direct = false)
	{
		if (OfflineRoot == null) return;
		if (direct) { OfflineRoot.SetActive(show); return; }
		if (show)
		{
			OfflineRoot.SetActive(true);
			OfflineRoot.transform.localScale = Vector3.zero;
			OfflineRoot.transform.DOScale(Vector3.one, 0.3f).SetEase(Ease.OutBack);
		}
		else
		{
			OfflineRoot.transform.DOScale(Vector3.zero, 0.2f).SetEase(Ease.InBack)
				.OnComplete(() => OfflineRoot.SetActive(false));
		}
	}

	private void OnClickOffline()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupOfflineReward>();
	}

	public void SetTarotTween(bool show, bool direct = false)
	{
		if (TarotRoot == null) return;
		if (direct) { TarotRoot.SetActive(show); return; }
		if (show)
		{
			TarotRoot.SetActive(true);
			TarotRoot.transform.localScale = Vector3.zero;
			TarotRoot.transform.DOScale(Vector3.one, 0.3f).SetEase(Ease.OutBack);
		}
		else
		{
			TarotRoot.transform.DOScale(Vector3.zero, 0.2f).SetEase(Ease.InBack)
				.OnComplete(() => TarotRoot.SetActive(false));
		}
	}

	private void SetTarot()
	{
		if (TarotRoot != null) TarotRoot.SetActive(false);
	}

	private void OnClickTarot()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void SetSpecialDay()
	{
		specialday_disposables?.Dispose();
		specialday_disposables = new CompositeDisposable();
		if (SpecialDayBtnContent != null) SpecialDayBtnContent.SetActive(false);
		if (AuctionPassBonusRoot != null) AuctionPassBonusRoot.SetActive(false);
	}

	public void UpdateSpecialDay()
	{
		if (SpecialDayBtnContent != null) SpecialDayBtnContent.SetActive(true);
		if (SpecialDayRemainTimeText != null) SpecialDayRemainTimeText.text = string.Empty;
	}

	public void SpecialDayHUDHideContent()
	{
		if (SpecialDayBtnContent != null) SpecialDayBtnContent.SetActive(false);
	}

	public void SpecialDayHUDStartEffect()
	{
		if (SpecialDayBtnContent != null)
		{
			SpecialDayBtnContent.SetActive(true);
			SpecialDayBtnContent.transform.localScale = Vector3.zero;
			SpecialDayBtnContent.transform.DOScale(Vector3.one, 0.3f).SetEase(Ease.OutBack);
		}
		if (SpecialDayEffectDeco != null) SpecialDayEffectDeco.SetActive(true);
	}

	private void OnClickSpecialDay()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupSpecialDayOpen>();
	}

	private void SetOfficeStrikeAlert()
	{
		officestrike_disposables?.Dispose();
		officestrike_disposables = new CompositeDisposable();
		if (OfficeStrikeRoot != null) OfficeStrikeRoot.SetActive(false);
	}

	public void ShowOfficeStrikeAlert()
	{
		if (OfficeStrikeRoot != null)
		{
			OfficeStrikeRoot.SetActive(true);
			UpdateOfficeStrikeAlertTime();
		}
	}

	private void UpdateOfficeStrikeAlertTime()
	{
		if (OfficeStrikeRemainTimeText != null)
			OfficeStrikeRemainTimeText.text = string.Empty;
	}

	public void SetOnePlusSix()
	{
		if (OnePlusSixBtn == null) return;
		var root = Singleton<GameRoot>.Instance;
		bool isOpen = root != null && root.ContentsOpenSystem != null;
		OnePlusSixBtn.gameObject.SetActive(isOpen);
	}

	private void OnOpenOnePlusSix()
	{
		if (OnePlusSixBtn != null) OnePlusSixBtn.gameObject.SetActive(true);
	}

	private void OnClickOnePlusSix()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void SetBooster()
	{
		booster_disposables?.Dispose();
		booster_disposables = new CompositeDisposable();
		UpdateBooster();
	}

	private void UpdateBooster()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.AbilitySystem == null) return;
		bool expBoost = root.AbilitySystem.IsActiveExpBooster(root.UserData?.CurMode?.ActiveRegion ?? 0);
		bool moneyBoost = root.AbilitySystem.IsActiveMoneyBooster(root.UserData?.CurMode?.ActiveRegion ?? 0);
		if (ExpBoostObj != null) ExpBoostObj.SetActive(expBoost);
		if (RentalFeeBoostObj != null) RentalFeeBoostObj.SetActive(moneyBoost);
	}

	private void OnClickWorldmap()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root != null && root.InGameSystem != null)
			root.InGameSystem.ChangeMode(GameType.WorldMap);
	}

	public Vector3 GetPiggyPos()
	{
		if (PiggyBtn != null)
			return PiggyBtn.transform.position;
		return default(Vector3);
	}

	public void SetVisibleSeasonalEnterButton(bool bVisible)
	{
		if (SeasonalEnterButton != null)
			SeasonalEnterButton.SetActive(bVisible);
	}

	public Vector3 GetSeasonalEnterButtonPos()
	{
		if (SeasonalEnterButton != null)
			return SeasonalEnterButton.transform.position;
		return default(Vector3);
	}

	private void SetSeasonalOffline()
	{
		if (SeasonalOfflineRoot != null) SeasonalOfflineRoot.SetActive(false);
	}

	private void SetSeasonalOfflineTween(bool show, bool direct = false)
	{
		if (SeasonalOfflineRoot == null) return;
		if (direct) { SeasonalOfflineRoot.SetActive(show); return; }
		if (show)
		{
			SeasonalOfflineRoot.SetActive(true);
			SeasonalOfflineRoot.transform.localScale = Vector3.zero;
			SeasonalOfflineRoot.transform.DOScale(Vector3.one, 0.3f).SetEase(Ease.OutBack);
		}
		else
		{
			SeasonalOfflineRoot.transform.DOScale(Vector3.zero, 0.2f).SetEase(Ease.InBack)
				.OnComplete(() => SeasonalOfflineRoot.SetActive(false));
		}
	}

	private void OnClickSeasonalOffline()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupOfflineReward>();
	}

	public void SetVisibleMiniGameButton(bool isVisible)
	{
		if (MiniGameComp != null)
			MiniGameComp.gameObject.SetActive(isVisible);
	}

	public Vector3 GetMiniGameButtonPos()
	{
		if (MiniGameComp != null)
			return MiniGameComp.transform.position;
		return default(Vector3);
	}

	[IteratorStateMachine(typeof(_003CWaitComebackCo_003Ed__291))]
	private IEnumerator WaitComebackCo(bool value)
	{
		yield return new WaitForSeconds(0.5f);
		ScreenAction(value);
	}

	public void ScreenAction(bool value)
	{
		screenAction = value;
		if (ScreenActionCo != null)
		{
			StopCoroutine(ScreenActionCo);
			ScreenActionCo = null;
		}
		InitScreenTweens();
		float targetX = value ? -300f : 0f;
		float duration = 0.3f;

		if (LeftRoot != null)
		{
			for (int i = 0; i < LeftRoot.Count; i++)
			{
				if (LeftRoot[i] == null) continue;
				float originX = i < originLeftPos.Count ? originLeftPos[i] : 0f;
				float targetPosX = value ? originX - 300f : originX;
				ScreenActionTweens.Add(LeftRoot[i].transform.DOLocalMoveX(targetPosX, duration).SetEase(Ease.OutQuad));
			}
		}
		if (RightRoot != null)
		{
			for (int i = 0; i < RightRoot.Count; i++)
			{
				if (RightRoot[i] == null) continue;
				float originX = i < originRightPos.Count ? originRightPos[i] : 0f;
				float targetPosX = value ? originX + 300f : originX;
				ScreenActionTweens.Add(RightRoot[i].transform.DOLocalMoveX(targetPosX, duration).SetEase(Ease.OutQuad));
			}
		}
	}

	private void InitScreenTweens()
	{
		if (ScreenActionTweens != null)
		{
			for (int i = 0; i < ScreenActionTweens.Count; i++)
			{
				if (ScreenActionTweens[i] != null)
					ScreenActionTweens[i].Kill();
			}
			ScreenActionTweens.Clear();
		}
	}

	public void ScreenTopOn(bool value)
	{
		if (TopRightBGObj != null)
			TopRightBGObj.SetActive(value);
	}

	public bool IsScreenTopOn()
	{
		if (TopRightBGObj != null)
			return TopRightBGObj.activeSelf;
		return false;
	}
}
