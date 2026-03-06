using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageSeasonalCoinBank", false, false)]
public class PageSeasonalCoinBank : UIBase
{
	[SerializeField]
	private Text CoinText;

	[SerializeField]
	private SeasonalCoinBankComponent coinComp;

	[Header("LevelInfo")]
	[SerializeField]
	private Image NextPiggyImg;

	[SerializeField]
	private GameObject NextLevelRoot;

	[SerializeField]
	private Text NextLevelText;

	[SerializeField]
	private Text CurMaxFullCountText;

	[SerializeField]
	private Text NextMaxFullCountText;

	[SerializeField]
	private Button LevelInfoBtn;

	protected override void Awake()
	{
		base.Awake();
		if (LevelInfoBtn != null) LevelInfoBtn.onClick.AddListener(OnClickLevelInfo);
	}

	public override void OnShowBefore()
	{
		UpdateLevel();
		UpdateCoin();
	}

	public override void OnShowAfter()
	{
		if (coinComp != null) coinComp.gameObject.SetActive(true);
	}

	private void UpdateLevel()
	{
		if (NextLevelRoot != null) NextLevelRoot.SetActive(true);
	}

	private void UpdateCoin()
	{
		if (CoinText != null) CoinText.text = "0";
	}

	private void OnClickLevelInfo()
	{
	}
}
