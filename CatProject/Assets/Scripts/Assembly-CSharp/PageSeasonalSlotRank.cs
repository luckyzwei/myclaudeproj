using System.Collections.Generic;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Seasonal/Page/PageSeasonalSlotRank", false, false)]
public class PageSeasonalSlotRank : UIBase
{
	[SerializeField]
	private SeasonalCoinRankReward RankReward;

	[SerializeField]
	private List<ItemSeasonalSlotRank> listSlotRank;

	[SerializeField]
	private GameObject Loading;

	[SerializeField]
	private Button btnMove;

	[SerializeField]
	private Text textRemainTime;

	[SerializeField]
	private GameObject rankRoot;

	[SerializeField]
	private GameObject noInternet;

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

	[Header("Package")]
	[SerializeField]
	private HudPackageItem hudPackageItem;

	private float deltaTime;

	private const float RankRefreshTime = 10f;

	private bool noInternetCheck;

	protected override void Awake()
	{
	}

	public override void OnShowBefore()
	{
	}

	public override void OnRefresh()
	{
	}

	private void Update()
	{
	}

	private void RefreshRank()
	{
	}

	private void UpdateRank()
	{
	}

	private void OnClickMove()
	{
	}

	private void OnClickedCoinBankBtn()
	{
	}

	public void UpdateCoinBankValue()
	{
	}

	private void UpdatePackage()
	{
	}
}
