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

[UIPath("UI/Page/HUDFactory", true, false)]
public class HUDFactory : HUDBase, IScreenAction
{
	[CompilerGenerated]
	private sealed class _003CWaitComebackCo_003Ed__77 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HUDFactory _003C_003E4__this;

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
		public _003CWaitComebackCo_003Ed__77(int _003C_003E1__state)
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

	[Header("[HUDFactory]")]
	private bool appear;

	private bool screenAction;

	[SerializeField]
	private GameObject FactoryRoot;

	[SerializeField]
	private List<GameObject> LeftRoot;

	[SerializeField]
	private List<GameObject> RightRoot;

	private List<float> originLeftPos;

	private List<float> originRightPos;

	[Header("Storage")]
	[SerializeField]
	private Button StorageBtn;

	[Header("Order")]
	[SerializeField]
	private Button OrderBtn;

	[Header("Process")]
	[SerializeField]
	private Button ProcessBtn;

	[Header("Shop")]
	[SerializeField]
	private Button ShopBtn;

	[Header("Roulette")]
	[SerializeField]
	private Button RouletteBtn;

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

	[Header("GemPass")]
	[SerializeField]
	private Button GemPassBtn;

	[SerializeField]
	private Image GemPassIcon;

	[SerializeField]
	private Image GemPassIcon2;

	[Header("Worldmap")]
	[SerializeField]
	private Button WorldMapShortCutBtn;

	[SerializeField]
	private Button OfficeShortCutBtn;

	[Header("Option")]
	[SerializeField]
	private Button OptionBtn;

	[Header("DailyQuest")]
	[SerializeField]
	private Button DailyQuestBtn;

	[Header("MultiRevenue")]
	[SerializeField]
	private Button MultiRevenueBtn;

	[SerializeField]
	private GameObject MultiRevenueSaleObj;

	[SerializeField]
	private Text MultiRevenueRemainText;

	[SerializeField]
	private Text MultiRevenueSaleText;

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
	private HudShopSaleComponent ShopSaleComp;

	[Header("Etc")]
	[SerializeField]
	private GameObject TopRightBGObj;

	private CompositeDisposable noadssale_disposables;

	private CompositeDisposable mrsale_disposables;

	private Coroutine ScreenActionCo;

	private List<Tween> ScreenActionTweens;

	public HUDType[] HudType { get { return aniType; } }

	public bool IsScreenAction { get { return screenAction; } }

	protected override void Awake()
	{
		base.Awake();
		aniType = new HUDType[] { anitype, toptype };
		noadssale_disposables = new CompositeDisposable();
		mrsale_disposables = new CompositeDisposable();
		ScreenActionTweens = new List<Tween>();
		InitScreenTweens();

		if (StorageBtn != null) StorageBtn.onClick.AddListener(OnClickStorage);
		if (OrderBtn != null) OrderBtn.onClick.AddListener(OnClickOrder);
		if (ProcessBtn != null) ProcessBtn.onClick.AddListener(OnClickProcess);
		if (ShopBtn != null) ShopBtn.onClick.AddListener(OnClickShop);
		if (RouletteBtn != null) RouletteBtn.onClick.AddListener(OnClickRoulette);
		if (NoAdsBtn != null) NoAdsBtn.onClick.AddListener(OnClickNoAds);
		if (GemPassBtn != null) GemPassBtn.onClick.AddListener(OnClickGemPass);
		if (WorldMapShortCutBtn != null) WorldMapShortCutBtn.onClick.AddListener(OnClickWorldMapShortCutBtn);
		if (OfficeShortCutBtn != null) OfficeShortCutBtn.onClick.AddListener(OnClickOfficeShortCutBtn);
		if (OptionBtn != null) OptionBtn.onClick.AddListener(OnClickOption);
		if (DailyQuestBtn != null) DailyQuestBtn.onClick.AddListener(OnClickDailyQuest);
		if (MultiRevenueBtn != null) MultiRevenueBtn.onClick.AddListener(OnClickMultiRevenue);
		if (PiggyBtn != null) PiggyBtn.onClick.AddListener(OnClickPiggyBank);
	}

	public override void OnShowBefore()
	{
		SetShop();
		SetNoAds();
		SetGemPass();
		SetRoulette();
		SetDailyQuest();
		SetPiggyBank();
		SetMultiRevenue();
		UpdatePackage();
	}

	private void Update()
	{
		// Update timers if needed
	}

	private void OnDisable()
	{
		if (noadssale_disposables != null)
		{
			noadssale_disposables.Dispose();
			noadssale_disposables = new CompositeDisposable();
		}
		if (mrsale_disposables != null)
		{
			mrsale_disposables.Dispose();
			mrsale_disposables = new CompositeDisposable();
		}
	}

	private void OnDestroy()
	{
		if (noadssale_disposables != null)
		{
			noadssale_disposables.Dispose();
			noadssale_disposables = null;
		}
		if (mrsale_disposables != null)
		{
			mrsale_disposables.Dispose();
			mrsale_disposables = null;
		}
		if (ScreenActionTweens != null)
		{
			for (int i = 0; i < ScreenActionTweens.Count; i++)
				ScreenActionTweens[i]?.Kill();
			ScreenActionTweens.Clear();
		}
	}

	public override void Refresh(E_RefreshType refreshType)
	{
		SetNoAds();
		SetGemPass();
		SetMultiRevenue();
		UpdatePackage();
		UpdatePiggyValue();
	}

	public void SetMRSale()
	{
		if (MultiRevenueSaleObj != null) MultiRevenueSaleObj.SetActive(false);
	}

	public void SetMultiRevenue()
	{
		if (MultiRevenueBtn == null) return;
		MultiRevenueBtn.gameObject.SetActive(true);
		SetMRSale();
	}

	private void OnClickMultiRevenue()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void OnClickWorldMapShortCutBtn()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root != null && root.InGameSystem != null)
			root.InGameSystem.ChangeMode(GameType.WorldMap);
	}

	private void OnClickOfficeShortCutBtn()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root != null && root.InGameSystem != null)
			root.InGameSystem.ChangeMode(GameType.Main);
	}

	private void OnClickStorage()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupFactoryStorage>();
	}

	private void OnClickProcess()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupFactoryWorkPlace>();
	}

	private void OnClickOrder()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupFactoryOrder>();
	}

	private void SetShop()
	{
		if (ShopBtn != null) ShopBtn.gameObject.SetActive(true);
	}

	private void OnClickShop()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	public void UpdatePackage()
	{
		if (PackageComp != null) PackageComp.Refresh();
		if (ShopSaleComp != null) ShopSaleComp.Set();
	}

	private void SetDailyQuest()
	{
		if (DailyQuestBtn != null) DailyQuestBtn.gameObject.SetActive(true);
	}

	private void OnClickDailyQuest()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupMission>();
	}

	private void SetPiggyBank()
	{
		if (PiggyBtn == null) return;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.ShopSystem == null) return;
		UpdatePiggyValue();
	}

	public void UpdatePiggyValue()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		var shopData = root.UserData.ShopData;
		if (shopData == null) return;
		if (PiggyCount != null) PiggyCount.text = shopData.PiggyValue.ToString();
		if (PiggyReddot != null) PiggyReddot.SetActive(shopData.PiggyValue > 0);
	}

	private void OnClickPiggyBank()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupPiggyBank>();
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

	public void SetGemPass()
	{
		if (GemPassBtn == null) return;
		int curGroup = ProjectUtility.GetCurGemPassGroup();
		GemPassBtn.gameObject.SetActive(curGroup > 0);
	}

	private void OnClickGemPass()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void OnClickOption()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupOption>();
	}

	private void SetRoulette()
	{
		if (RouletteBtn != null) RouletteBtn.gameObject.SetActive(true);
	}

	private void OnClickRoulette()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PageRoulette>();
	}

	public Vector3 GetPiggyPos()
	{
		if (PiggyBtn != null) return PiggyBtn.transform.position;
		return default(Vector3);
	}

	[IteratorStateMachine(typeof(_003CWaitComebackCo_003Ed__77))]
	private IEnumerator WaitComebackCo(bool value)
	{
		yield return new WaitForSeconds(0.3f);
		appear = value;
	}

	public void ScreenAction(bool value)
	{
		screenAction = value;
		if (ScreenActionCo != null)
			StopCoroutine(ScreenActionCo);
		ScreenActionCo = StartCoroutine(WaitComebackCo(value));
	}

	private void InitScreenTweens()
	{
		originLeftPos = new List<float>();
		originRightPos = new List<float>();
		if (LeftRoot != null)
		{
			for (int i = 0; i < LeftRoot.Count; i++)
			{
				var rt = LeftRoot[i] != null ? LeftRoot[i].GetComponent<RectTransform>() : null;
				if (rt != null) originLeftPos.Add(rt.anchoredPosition.x);
			}
		}
		if (RightRoot != null)
		{
			for (int i = 0; i < RightRoot.Count; i++)
			{
				var rt = RightRoot[i] != null ? RightRoot[i].GetComponent<RectTransform>() : null;
				if (rt != null) originRightPos.Add(rt.anchoredPosition.x);
			}
		}
	}

	public void ScreenTopOn(bool value)
	{
		screenAction = !value;
	}

	public bool IsScreenTopOn()
	{
		return !screenAction;
	}

	public void SetActiveRoot(bool isActive)
	{
		if (FactoryRoot != null) FactoryRoot.SetActive(isActive);
	}
}
