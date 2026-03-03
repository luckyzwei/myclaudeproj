using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemParkingCar : MonoBehaviour
{
	private enum E_ParkingSlotType
	{
		NONE = 0,
		ON = 1,
		PURCHASE = 2,
		RICH_POINT = 3,
		PLAYER_LV = 4,
		NEXT_NONE = 5,
		SPECIAL = 6
	}

	[Header("ItemParkingCar")]
	[SerializeField]
	private GameObject NoneObj;

	[SerializeField]
	private Button NoneShortCutBtn;

	[SerializeField]
	private GameObject PurchaseEffectObj;

	[Space(5f)]
	[SerializeField]
	private GameObject OnObj;

	[SerializeField]
	private Image OnCarImg;

	[SerializeField]
	private Text OnCarNameText;

	[SerializeField]
	private Text OnCarDescText;

	[SerializeField]
	private Image OnCarLogo;

	[SerializeField]
	private Text OnRichPointText;

	[SerializeField]
	private GameObject OnEquippedObj;

	[SerializeField]
	private Button OnEquipBtn;

	[SerializeField]
	private Button OnSellBtn;

	[Space(5f)]
	[SerializeField]
	private GameObject PurchaseObj;

	[SerializeField]
	private Image PurchaseCarImg;

	[SerializeField]
	private Button PurchaseGemBtn;

	[SerializeField]
	private Text PurchaseGemBtnText;

	[SerializeField]
	private Button PurchaseCashBtn;

	[SerializeField]
	private Text PurchaseCashBtnText;

	[SerializeField]
	private Animator PurchaseLockAni;

	[Space(5f)]
	[SerializeField]
	private GameObject RichPointObj;

	[SerializeField]
	private Button RichPointInfoBtn;

	[SerializeField]
	private Slider RichPointSlider;

	[SerializeField]
	private ProgressText RichPointCountText;

	[Space(5f)]
	[SerializeField]
	private GameObject PlayerLvObj;

	[SerializeField]
	private Text PlayerLvText;

	[Space(5f)]
	[SerializeField]
	private GameObject NextNoneObj;

	[SerializeField]
	private Button NextNoneShortCutBtn;

	[Space(5f)]
	[SerializeField]
	private GameObject SpecialNoneObj;

	[SerializeField]
	private Image SpecialNoneImg;

	[SerializeField]
	private Image SpecialCarIcon;

	[SerializeField]
	private Text SpecialCarName;

	[SerializeField]
	private Text SpecialCarDesc;

	private int ParkingCarIdx;

	private int CurParkingZone;

	private int CurParkingSpace;

	private Action SellCarCallback;

	private int PurchaseGemPrice;

	private string PurchaseProductId;

	private E_ParkingSlotType CurrentParkingSlotType;

	private Coroutine UpdateStateCoroutine;

	private void Awake()
	{
	}

	public void Set(int zone, int space, Action sellCarAction)
	{
	}

	public void UpdateState()
	{
	}

	private void DrawStatus()
	{
	}

	private void SetCarUI()
	{
	}

	private void SetPurchaseUI()
	{
	}

	private void SetRichPointUI()
	{
	}

	private void SetSpecialUI()
	{
	}

	private void OnClickEquip()
	{
	}

	private void OnClickSale()
	{
	}

	private void OnClickPurchase()
	{
	}

	private void OnClickRichPointInfo()
	{
	}

	private void OnClickNoneShortCut()
	{
	}

	private void OnClickNextNoneShortCut()
	{
	}

	private bool IsAllCarsPurchased()
	{
		return false;
	}

	private void OpenCarMarket(int carStoreIdx)
	{
	}

	private void UpdateParkingLotUI()
	{
	}

	private void OnDestroy()
	{
	}
}
