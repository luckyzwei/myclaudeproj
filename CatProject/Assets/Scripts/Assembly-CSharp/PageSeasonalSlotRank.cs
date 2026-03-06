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
		base.Awake();
		if (btnMove != null) btnMove.onClick.AddListener(OnClickMove);
		if (CoinBankBtn != null) CoinBankBtn.onClick.AddListener(OnClickedCoinBankBtn);
	}

	public override void OnShowBefore()
	{
		deltaTime = 0f;
		noInternetCheck = false;
		if (Loading != null) Loading.SetActive(true);
		if (rankRoot != null) rankRoot.SetActive(false);
		if (noInternet != null) noInternet.SetActive(false);
		RefreshRank();
		UpdateCoinBankValue();
		UpdatePackage();
	}

	public override void OnRefresh()
	{
		UpdateRank();
		UpdateCoinBankValue();
	}

	private void Update()
	{
		deltaTime += Time.deltaTime;
		if (deltaTime >= RankRefreshTime)
		{
			deltaTime = 0f;
			RefreshRank();
		}

		// Update remain time text
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.SeasonalSystem == null) return;
		var nowSeason = root.SeasonalSystem.NowSeasonScheduleInfo;
		if (nowSeason != null && textRemainTime != null)
		{
			int remainSec = (int)(nowSeason.Endtime - System.DateTime.UtcNow).TotalSeconds;
			if (remainSec < 0) remainSec = 0;
			textRemainTime.text = ProjectUtility.GetTimeStringFormattingShort(remainSec);
		}
	}

	private void RefreshRank()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.SeasonalSystem == null) return;
		root.SeasonalSystem.RefreshRankData();
		UpdateRank();
	}

	private void UpdateRank()
	{
		if (Loading != null) Loading.SetActive(false);

		if (noInternetCheck)
		{
			if (rankRoot != null) rankRoot.SetActive(false);
			if (noInternet != null) noInternet.SetActive(true);
			return;
		}

		if (rankRoot != null) rankRoot.SetActive(true);
		if (noInternet != null) noInternet.SetActive(false);
	}

	private void OnClickMove()
	{
		Hide();
	}

	private void OnClickedCoinBankBtn()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.SeasonalSystem == null) return;
		// Open coin bank collection
		if (CoinBankTween != null) CoinBankTween.Play();
	}

	public void UpdateCoinBankValue()
	{
		if (CoinBankValueText != null) CoinBankValueText.text = "";
		if (CoinBankReddot != null) CoinBankReddot.SetActive(false);
	}

	private void UpdatePackage()
	{
	}
}
