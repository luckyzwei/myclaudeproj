using System;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupHouseSale", false, false)]
public class PopupHouseSale : UIBase
{
	[SerializeField]
	private Image HouseImg;

	[SerializeField]
	private Text HouseName;

	[SerializeField]
	private Image PriceIcon;

	[SerializeField]
	private Text PriceText;

	[SerializeField]
	private Text BtnPriceText;

	[SerializeField]
	private Text TextBtnPriceTitle;

	[SerializeField]
	private Text ParkingLotCount;

	[SerializeField]
	private Text PointRewardCount;

	[SerializeField]
	private GameObject MainBtnObj;

	[SerializeField]
	private Button PurchaseBtn;

	[SerializeField]
	private Button IAPBuyBtn;

	[SerializeField]
	private Text IAPPriceText;

	[SerializeField]
	private Text IAPAddPoint;

	[SerializeField]
	private GameObject PurchaseCompleteObj;

	[Header("Condition")]
	[SerializeField]
	private GameObject NeedObj;

	[SerializeField]
	private Text NeedText;

	[SerializeField]
	private GameObject NeedPlayerLvObj;

	[SerializeField]
	private Text NeedPlayerLvText;

	[Header("ManagerKey")]
	[SerializeField]
	private GameObject ManagerKeyObj;

	[SerializeField]
	private GameObject ManagerKeyCashObj;

	[SerializeField]
	private Image ManagerKeyIcon;

	[SerializeField]
	private Text ManagerKeyText;

	[SerializeField]
	private Image ManagerKeyCashIcon;

	[SerializeField]
	private Text ManagerKeyCashText;

	[Header("Dim")]
	[SerializeField]
	private Button DimBtn;

	[SerializeField]
	private Image DimImg;

	private int HouseIdx;

	public Action BuyHouseCallback { get; set; }

	protected override void Awake()
	{
	}

	public void Set(int houseIdx, bool skipConversation = false)
	{
	}

	private void OnClickPurchase()
	{
	}

	private void OnClickBuy()
	{
	}

	public override void Hide()
	{
	}
}
