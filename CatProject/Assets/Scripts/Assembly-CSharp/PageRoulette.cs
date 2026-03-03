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
	}

	public override void OnShowBefore()
	{
	}

	public void ShowPlantFocusing()
	{
	}

	private void UpdateRoulette()
	{
	}

	public void UpdateSuperStaff()
	{
	}

	public void UpdateGemValue()
	{
	}

	private void SubscribeCash()
	{
	}

	private void SubscribeCooltime()
	{
	}

	private void UpdateBtn()
	{
	}

	private void UpdateLuckyDraw(bool objActive)
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

	private bool CheckCompanyContract()
	{
		return false;
	}

	private void OnClickGemSpin()
	{
	}

	private void OnClickRatioInfo()
	{
	}

	public override void Hide()
	{
	}

	public void RefreshText()
	{
	}

	public void UpdateNoAds()
	{
	}

	private void UpdateNoAdsIcon()
	{
	}

	private void OnClickNoAds()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}
}
