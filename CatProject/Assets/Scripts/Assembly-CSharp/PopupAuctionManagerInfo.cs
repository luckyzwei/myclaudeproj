using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupAuctionManagerInfo", false, false)]
public class PopupAuctionManagerInfo : UIBase
{
	[Header("Button")]
	[SerializeField]
	private Button UpgradeBtn;

	[SerializeField]
	private Button GotoShopBtn;

	[Header("Info")]
	[SerializeField]
	private Text ManagerName;

	[SerializeField]
	private Image ManagerImg;

	[SerializeField]
	private Image ManagerFrame;

	[Header("Level")]
	[SerializeField]
	private Text ManagerLevel;

	[SerializeField]
	private Slider ManagerExpFill;

	[SerializeField]
	private Text ManagerExpText;

	[Space(5f)]
	[SerializeField]
	private Image UpgradeCardIcon;

	[SerializeField]
	private Text UpgradeText;

	[Space(5f)]
	[SerializeField]
	private GameObject LevelIcon;

	[SerializeField]
	private GameObject LevelUpArrow;

	[SerializeField]
	private GameObject LevelUpEffect;

	[Header("Coin")]
	[SerializeField]
	private GameObject NextLevelRoot;

	[SerializeField]
	private GameObject MaxRoot;

	[SerializeField]
	private Text CurMaxCoin;

	[SerializeField]
	private Text NextMaxCoin;

	private int ManagerIdx;

	protected override void Awake()
	{
	}

	public override void OnShowBefore()
	{
	}

	public void Set(int managerIdx)
	{
	}

	public void UpdateLevel()
	{
	}

	private void ShowLevelUpEffect()
	{
	}

	private void OnClickUpgrade()
	{
	}

	private void OnClickShop()
	{
	}
}
