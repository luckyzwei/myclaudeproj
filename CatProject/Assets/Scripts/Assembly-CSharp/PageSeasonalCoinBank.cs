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
	}

	public override void OnShowBefore()
	{
	}

	public override void OnShowAfter()
	{
	}

	private void UpdateLevel()
	{
	}

	private void UpdateCoin()
	{
	}

	private void OnClickLevelInfo()
	{
	}
}
