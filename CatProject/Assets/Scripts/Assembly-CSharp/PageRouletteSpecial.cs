using System.Collections.Generic;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageRouletteSpecial", false, false)]
public class PageRouletteSpecial : UIBase, ILocalizeRefresh
{
	[SerializeField]
	private Button RatioInfoBtn;

	[SerializeField]
	private Transform RouletteWheel;

	[SerializeField]
	private List<ItemRoulette> RouletteItems;

	[Header("LuckyDraw")]
	[SerializeField]
	private Slider LuckyDrawProgress;

	[SerializeField]
	private Text LuckyDrawCount;

	[SerializeField]
	private Text LuckyDrawDesc;

	[Space(5f)]
	[SerializeField]
	private Button LuckyDrawRewardBtn;

	[SerializeField]
	private Button LuckDrawInfoBtn;

	[SerializeField]
	private Image LuckyDrawRewardIcon;

	[SerializeField]
	private GameObject LuckyDrawEnableObj;

	[SerializeField]
	private GameObject LuckyDrawDoneObj;

	[Header("Texts")]
	[SerializeField]
	private Text RemainEventTime;

	[SerializeField]
	private Text RemainCooltime;

	[SerializeField]
	private Text NeedGemCount;

	[SerializeField]
	private Text CashCount;

	[Header("Buttons")]
	[SerializeField]
	private Button FreeSpinBtn;

	[SerializeField]
	private Button AdSpinBtn;

	[SerializeField]
	private Button GemSpinBtn;

	[Header("OneTimeEvent")]
	[SerializeField]
	private OnetimeCurrencyComponent oneTimeComponent;

	private CompositeDisposable disposables;

	private bool isSpinRoulette;

	private bool isLuckyDrawReward;

	private bool doneLuckDrawReward;

	protected override void Awake()
	{
		base.Awake();
		disposables = new CompositeDisposable();
		isSpinRoulette = false;
		isLuckyDrawReward = false;
		doneLuckDrawReward = false;

		if (FreeSpinBtn != null) FreeSpinBtn.onClick.AddListener(OnClickFreeSpin);
		if (AdSpinBtn != null) AdSpinBtn.onClick.AddListener(OnClickAdSpin);
		if (GemSpinBtn != null) GemSpinBtn.onClick.AddListener(OnClickGemSpin);
		if (RatioInfoBtn != null) RatioInfoBtn.onClick.AddListener(OnClickRatioInfo);
		if (LuckyDrawRewardBtn != null) LuckyDrawRewardBtn.onClick.AddListener(OnClickLuckyDrawReward);
		if (LuckDrawInfoBtn != null) LuckDrawInfoBtn.onClick.AddListener(OnClickLuckyDrawInfo);
	}

	public override void OnShowBefore()
	{
		UpdateRoulette();
		UpdateBtn();
		UpdateLuckyDraw();
		UpdateLuckyDrawReward();
		UpdateGemBtn();
		SubscribeCash();
		SubscribeCooltime();
		SubscribeEventDuration();
	}

	private void UpdateRoulette()
	{
		if (RouletteItems == null) return;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		// Set roulette items from special roulette data
	}

	private void SubscribeCash()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		if (CashCount != null) CashCount.text = "0";
	}

	private void SubscribeCooltime()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		if (RemainCooltime != null) RemainCooltime.text = "";
	}

	private void SubscribeEventDuration()
	{
		if (RemainEventTime != null) RemainEventTime.text = "";
	}

	private void UpdateBtn()
	{
		bool canFreeSpin = false;
		bool canAdSpin = false;
		if (FreeSpinBtn != null) FreeSpinBtn.gameObject.SetActive(canFreeSpin);
		if (AdSpinBtn != null) AdSpinBtn.gameObject.SetActive(canAdSpin);
		if (GemSpinBtn != null) GemSpinBtn.gameObject.SetActive(!canFreeSpin && !canAdSpin);
	}

	public void UpdateLuckyDrawReward()
	{
		if (LuckyDrawEnableObj != null) LuckyDrawEnableObj.SetActive(isLuckyDrawReward);
		if (LuckyDrawDoneObj != null) LuckyDrawDoneObj.SetActive(doneLuckDrawReward);
	}

	public void UpdateLuckyDraw()
	{
		if (LuckyDrawProgress != null) LuckyDrawProgress.value = 0f;
		if (LuckyDrawCount != null) LuckyDrawCount.text = "0";
	}

	public void UpdateGemBtn()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		if (NeedGemCount != null) NeedGemCount.text = "0";
	}

	private void SpinRoulette()
	{
		if (isSpinRoulette) return;
		isSpinRoulette = true;
		// Start spin animation
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

	private void OnClickGemSpin()
	{
		if (isSpinRoulette) return;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		SpinRoulette();
	}

	private void OnClickRatioInfo()
	{
	}

	private void OnClickLuckyDrawReward()
	{
		if (!isLuckyDrawReward || doneLuckDrawReward) return;
		doneLuckDrawReward = true;
		// Claim lucky draw reward
		UpdateLuckyDrawReward();
	}

	private void OnClickLuckyDrawInfo()
	{
	}

	public override void Hide()
	{
		base.Hide();
	}

	public void RefreshText()
	{
		UpdateGemBtn();
		UpdateBtn();
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
