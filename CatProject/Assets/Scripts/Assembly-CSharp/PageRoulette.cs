using System.Collections.Generic;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageRoulette", false, false)]
public class PageRoulette : UIBase, ILocalizeRefresh
{
	[SerializeField]
	private Button RatioInfoBtn;

	[SerializeField]
	private Transform RouletteWheel;

	[SerializeField]
	private List<ItemRoulette> RouletteItems;

	[SerializeField]
	private GameObject LuckyDrawObj;

	[SerializeField]
	private Slider LuckyDrawProgress;

	[SerializeField]
	private Text LuckyDrawCount;

	[SerializeField]
	private Text LuckyDrawDesc;

	[SerializeField]
	private Text NeedGemCount;

	[SerializeField]
	private Text RemainCooltime;

	[SerializeField]
	private Text CashCount;

	[SerializeField]
	private Button LuckyDrawBtn;

	[SerializeField]
	private Button FreeSpinBtn;

	[SerializeField]
	private Button AdSpinBtn;

	[SerializeField]
	private Button GemSpinBtn;

	[SerializeField]
	private SuperStaffStatBtn superStaffBtn;

	[Header("OneTimeEvent")]
	[SerializeField]
	private OnetimeCurrencyComponent oneTimeComponent;

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

	private CompositeDisposable disposables;

	private bool isSpinRoulette;

	private bool OpenSeasonal;

	protected override void Awake()
	{
		base.Awake();
		disposables = new CompositeDisposable();
		noadssale_disposables = new CompositeDisposable();
		isSpinRoulette = false;
		OpenSeasonal = false;

		if (FreeSpinBtn != null) FreeSpinBtn.onClick.AddListener(OnClickFreeSpin);
		if (AdSpinBtn != null) AdSpinBtn.onClick.AddListener(OnClickAdSpin);
		if (GemSpinBtn != null) GemSpinBtn.onClick.AddListener(OnClickGemSpin);
		if (RatioInfoBtn != null) RatioInfoBtn.onClick.AddListener(OnClickRatioInfo);
		if (LuckyDrawBtn != null) LuckyDrawBtn.onClick.AddListener(OnClickFreeSpin);
		if (NoAdsBtn != null) NoAdsBtn.onClick.AddListener(OnClickNoAds);
	}

	public override void OnShowBefore()
	{
		UpdateRoulette();
		UpdateBtn();
		UpdateGemValue();
		UpdateSuperStaff();
		UpdateNoAds();
		SubscribeCash();
		SubscribeCooltime();
	}

	public void ShowPlantFocusing()
	{
		// Highlight plant-related roulette items
	}

	private void UpdateRoulette()
	{
		if (RouletteItems == null) return;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		// Set roulette item rewards from table data
		UpdateLuckyDraw(true);
	}

	public void UpdateSuperStaff()
	{
		if (superStaffBtn == null) return;
		// Update super staff button state
	}

	public void UpdateGemValue()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		if (NeedGemCount != null) NeedGemCount.text = "0";
	}

	private void SubscribeCash()
	{
		if (disposables != null)
		{
			disposables.Dispose();
			disposables = new CompositeDisposable();
		}
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		// Subscribe to cash value changes
		if (CashCount != null) CashCount.text = "0";
	}

	private void SubscribeCooltime()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		// Subscribe to roulette cooltime changes
		if (RemainCooltime != null) RemainCooltime.text = "";
	}

	private void UpdateBtn()
	{
		bool canFreeSpin = false;
		bool canAdSpin = false;

		if (FreeSpinBtn != null) FreeSpinBtn.gameObject.SetActive(canFreeSpin);
		if (AdSpinBtn != null) AdSpinBtn.gameObject.SetActive(canAdSpin);
		if (GemSpinBtn != null) GemSpinBtn.gameObject.SetActive(!canFreeSpin && !canAdSpin);
	}

	private void UpdateLuckyDraw(bool objActive)
	{
		if (LuckyDrawObj == null) return;
		LuckyDrawObj.SetActive(objActive);
		if (LuckyDrawProgress != null) LuckyDrawProgress.value = 0f;
		if (LuckyDrawCount != null) LuckyDrawCount.text = "0";
	}

	private void SpinRoulette()
	{
		if (isSpinRoulette) return;
		isSpinRoulette = true;
		// Start roulette spin animation on RouletteWheel
	}

	private void OnClickFreeSpin()
	{
		if (isSpinRoulette) return;
		SpinRoulette();
	}

	private void OnClickAdSpin()
	{
		if (isSpinRoulette) return;
		// Watch ad then spin
	}

	private bool CheckCompanyContract()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return false;
		// Check if company contract is needed before spin
		return true;
	}

	private void OnClickGemSpin()
	{
		if (isSpinRoulette) return;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		// Use gem to spin
		SpinRoulette();
	}

	private void OnClickRatioInfo()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupRewardDetail>();
	}

	public override void Hide()
	{
		base.Hide();
	}

	public void RefreshText()
	{
		UpdateGemValue();
		UpdateBtn();
	}

	public void UpdateNoAds()
	{
		if (NoAdsBtn == null) return;
		NoAdsBtn.gameObject.SetActive(false);
		UpdateNoAdsIcon();
		// Check if no-ads sale is active
		if (NoAdsSaleObj != null) NoAdsSaleObj.SetActive(false);
	}

	private void UpdateNoAdsIcon()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.ShopSystem == null) return;
		bool noAds = root.ShopSystem.NoAds;
		if (NoAdsBtn != null) NoAdsBtn.gameObject.SetActive(!noAds);
	}

	private void OnClickNoAds()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupNoAds>();
	}

	private void OnDestroy()
	{
		if (disposables != null) { disposables.Dispose(); disposables = null; }
		if (noadssale_disposables != null) { noadssale_disposables.Dispose(); noadssale_disposables = null; }
	}

	private void OnDisable()
	{
		if (disposables != null) { disposables.Dispose(); disposables = new CompositeDisposable(); }
		if (noadssale_disposables != null) { noadssale_disposables.Dispose(); noadssale_disposables = new CompositeDisposable(); }
	}
}
