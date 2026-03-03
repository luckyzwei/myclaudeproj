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

	public HUDType[] HudType => null;

	public bool IsAppear => false;

	public bool IsScreenAction => false;

	public WaitUntil WaitHUDAppear { get; set; }

	public HudMissionItem GetHudMissionItem => null;

	public Button GetMissionBtn => null;

	public Button GetOneTimeBtn => null;

	public OnetimeCurrencyComponent GetOneTimeComponent => null;

	public GameObject OneTimeReddot => null;

	public bool OfferwallReddot { get; set; }

	protected override void Awake()
	{
	}

	public override void OnShowBefore()
	{
	}

	public void SetSegmentText()
	{
	}

	public void SetInterstitialText()
	{
	}

	private void Update()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void ResetSubscribe()
	{
	}

	public override void Refresh(E_RefreshType refreshType)
	{
	}

	public override Vector3 GetHUDPos(E_HUDPosType posType, int rewardType = 0, int rewardIdx = 0)
	{
		return default(Vector3);
	}

	public void SetActiveRoot(bool isActive)
	{
	}

	public void SetActiveArrow(Config.ContentsOpenType contentsOpenType)
	{
	}

	private void SetLevel()
	{
	}

	private void SetWorldmap()
	{
	}

	private void StartWorldmap()
	{
	}

	private void StartWorldmapBank()
	{
	}

	private void SetFloor()
	{
	}

	public void UpdateFloor()
	{
	}

	private void OnClickFloorUp()
	{
	}

	private void OnClickFloorDown()
	{
	}

	private void SetShop()
	{
	}

	private void OnClickShop()
	{
	}

	public void UpdatePackage()
	{
	}

	public void SetPackageNoTimeLimit()
	{
	}

	public void OnClickPackageNoTimeLimit()
	{
	}

	public void SetFirstManagerPackage()
	{
	}

	public void OnClickFirstManagerPackage()
	{
	}

	private void SetFactory()
	{
	}

	private void OnClickFactoryOrder()
	{
	}

	private void OnClickFactoryStorage()
	{
	}

	private void OnClickFactoryBuy()
	{
	}

	public void SetStorageTween(bool show, bool direct = false)
	{
	}

	public void SetOpenTween(bool show, bool direct = false)
	{
	}

	private void SetRentalFee()
	{
	}

	public void UpdateRentalFeeProgress(float value)
	{
	}

	public void UpdateAddRewawrdBuff()
	{
	}

	public void ShowEarnToast()
	{
	}

	private void OnClickAuctionPassBonus()
	{
	}

	private void OnClickOfficeManagement()
	{
	}

	private void SetPiggyBank()
	{
	}

	public void UpdatePiggyValue()
	{
	}

	private void OnClickPiggyBank()
	{
	}

	private void SetOneTime()
	{
	}

	private void SubscribeOneTime()
	{
	}

	public void UpdateOneTimeCurrencyRoot()
	{
	}

	public void UpdateOneTimeCurrencyIcon()
	{
	}

	public void UpdateOneTimeCurrencyCount()
	{
	}

	public void OneTimeHUDHideContent()
	{
	}

	public void OneTimeHUDStartEffect()
	{
	}

	private void OnClickOneTime()
	{
	}

	public Vector3 GetOneTimePos()
	{
		return default(Vector3);
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

	public void SetGemPass()
	{
	}

	private void UpdateGemPassIcon()
	{
	}

	private void OnClickGemPass()
	{
	}

	private void OnClickOption()
	{
	}

	private void SetAdPass()
	{
	}

	public void UpdateAdPass()
	{
	}

	private void OnClickAdPass()
	{
	}

	private void SetCrossPromotion()
	{
	}

	public void RunCrossPromotionEffect()
	{
	}

	[IteratorStateMachine(typeof(_003CShowCrossPromotionEffect_003Ed__220))]
	private IEnumerator ShowCrossPromotionEffect()
	{
		return null;
	}

	private void OnClickCrossPromotion()
	{
	}

	private void SetInvest()
	{
	}

	private void UpdateInvest()
	{
	}

	private void OnClickInvest()
	{
	}

	private void SetInvite()
	{
	}

	public void RunInviteEffect()
	{
	}

	private void ShowInviteEffect()
	{
	}

	private void OnClickInvite()
	{
	}

	private void SetOfferwall()
	{
	}

	private void OnClickOfferwall()
	{
	}

	private void SetFreecash()
	{
	}

	private void OnClickFreecash()
	{
	}

	private bool IsVisibleFreecash()
	{
		return false;
	}

	public void SetMRSale()
	{
	}

	public void SetMultiRevenue()
	{
	}

	private void OnClickMultiRevenue()
	{
	}

	private void SetRoulette()
	{
	}

	private void OnClickRoulette()
	{
	}

	private void SetPhone()
	{
	}

	private void StartPhone()
	{
	}

	private void OnClickPhone()
	{
	}

	private void SetMission()
	{
	}

	private void OnClickMission()
	{
	}

	private void SetManager()
	{
	}

	private void OnClickManager()
	{
	}

	private void SetBizAcq()
	{
	}

	private void OnClickBizAcq()
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

	public void SetGemAdSupplyTween(bool show, bool direct = false)
	{
	}

	private void SetGemAdSupply()
	{
	}

	private void OnClickGemAdSupply()
	{
	}

	private void SetExpAdSupplyTween(bool show, bool direct = false)
	{
	}

	private void SetExpAdSupply()
	{
	}

	private void OnClickExpAdsupply()
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

	public void UpdateOffline()
	{
	}

	private void SetOffline()
	{
	}

	private void SetOfflineTween(bool show, bool direct = false)
	{
	}

	private void OnClickOffline()
	{
	}

	public void SetTarotTween(bool show, bool direct = false)
	{
	}

	private void SetTarot()
	{
	}

	private void OnClickTarot()
	{
	}

	private void SetSpecialDay()
	{
	}

	public void UpdateSpecialDay()
	{
	}

	public void SpecialDayHUDHideContent()
	{
	}

	public void SpecialDayHUDStartEffect()
	{
	}

	private void OnClickSpecialDay()
	{
	}

	private void SetOfficeStrikeAlert()
	{
	}

	public void ShowOfficeStrikeAlert()
	{
	}

	private void UpdateOfficeStrikeAlertTime()
	{
	}

	public void SetOnePlusSix()
	{
	}

	private void OnOpenOnePlusSix()
	{
	}

	private void OnClickOnePlusSix()
	{
	}

	private void SetBooster()
	{
	}

	private void UpdateBooster()
	{
	}

	private void OnClickWorldmap()
	{
	}

	public Vector3 GetPiggyPos()
	{
		return default(Vector3);
	}

	public void SetVisibleSeasonalEnterButton(bool bVisible)
	{
	}

	public Vector3 GetSeasonalEnterButtonPos()
	{
		return default(Vector3);
	}

	private void SetSeasonalOffline()
	{
	}

	private void SetSeasonalOfflineTween(bool show, bool direct = false)
	{
	}

	private void OnClickSeasonalOffline()
	{
	}

	public void SetVisibleMiniGameButton(bool isVisible)
	{
	}

	public Vector3 GetMiniGameButtonPos()
	{
		return default(Vector3);
	}

	[IteratorStateMachine(typeof(_003CWaitComebackCo_003Ed__291))]
	private IEnumerator WaitComebackCo(bool value)
	{
		return null;
	}

	public void ScreenAction(bool value)
	{
	}

	private void InitScreenTweens()
	{
	}

	public void ScreenTopOn(bool value)
	{
	}

	public bool IsScreenTopOn()
	{
		return false;
	}
}
