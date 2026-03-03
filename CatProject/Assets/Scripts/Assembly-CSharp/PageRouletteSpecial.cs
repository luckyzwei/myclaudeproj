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
	}

	public override void OnShowBefore()
	{
	}

	private void UpdateRoulette()
	{
	}

	private void SubscribeCash()
	{
	}

	private void SubscribeCooltime()
	{
	}

	private void SubscribeEventDuration()
	{
	}

	private void UpdateBtn()
	{
	}

	public void UpdateLuckyDrawReward()
	{
	}

	public void UpdateLuckyDraw()
	{
	}

	public void UpdateGemBtn()
	{
	}

	private void SpinRoulette()
	{
	}

	private void OnClickFreeSpin()
	{
	}

	private void OnClickAdSpin()
	{
	}

	private void OnClickGemSpin()
	{
	}

	private void OnClickRatioInfo()
	{
	}

	private void OnClickLuckyDrawReward()
	{
	}

	private void OnClickLuckyDrawInfo()
	{
	}

	public override void Hide()
	{
	}

	public void RefreshText()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}
}
