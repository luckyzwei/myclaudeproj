using System;
using Treeplla;
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
		if (OnEquipBtn != null) OnEquipBtn.onClick.AddListener(OnClickEquip);
		if (OnSellBtn != null) OnSellBtn.onClick.AddListener(OnClickSale);
		if (PurchaseGemBtn != null) PurchaseGemBtn.onClick.AddListener(OnClickPurchase);
		if (PurchaseCashBtn != null) PurchaseCashBtn.onClick.AddListener(OnClickPurchase);
		if (NoneShortCutBtn != null) NoneShortCutBtn.onClick.AddListener(OnClickNoneShortCut);
		if (NextNoneShortCutBtn != null) NextNoneShortCutBtn.onClick.AddListener(OnClickNextNoneShortCut);
		if (RichPointInfoBtn != null) RichPointInfoBtn.onClick.AddListener(OnClickRichPointInfo);
	}

	public void Set(int zone, int space, Action sellCarAction)
	{
		CurParkingZone = zone;
		CurParkingSpace = space;
		SellCarCallback = sellCarAction;
		UpdateState();
	}

	public void UpdateState()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		// Determine parking slot type based on zone/space data
		CurrentParkingSlotType = E_ParkingSlotType.NONE;
		DrawStatus();
	}

	private void DrawStatus()
	{
		if (NoneObj != null) NoneObj.SetActive(CurrentParkingSlotType == E_ParkingSlotType.NONE);
		if (OnObj != null) OnObj.SetActive(CurrentParkingSlotType == E_ParkingSlotType.ON);
		if (PurchaseObj != null) PurchaseObj.SetActive(CurrentParkingSlotType == E_ParkingSlotType.PURCHASE);
		if (RichPointObj != null) RichPointObj.SetActive(CurrentParkingSlotType == E_ParkingSlotType.RICH_POINT);
		if (PlayerLvObj != null) PlayerLvObj.SetActive(CurrentParkingSlotType == E_ParkingSlotType.PLAYER_LV);
		if (NextNoneObj != null) NextNoneObj.SetActive(CurrentParkingSlotType == E_ParkingSlotType.NEXT_NONE);
		if (SpecialNoneObj != null) SpecialNoneObj.SetActive(CurrentParkingSlotType == E_ParkingSlotType.SPECIAL);

		switch (CurrentParkingSlotType)
		{
			case E_ParkingSlotType.ON:
				SetCarUI();
				break;
			case E_ParkingSlotType.PURCHASE:
				SetPurchaseUI();
				break;
			case E_ParkingSlotType.RICH_POINT:
				SetRichPointUI();
				break;
			case E_ParkingSlotType.SPECIAL:
				SetSpecialUI();
				break;
		}
	}

	private void SetCarUI()
	{
		// Set car image, name, desc, logo, rich point text
		if (OnCarNameText != null) OnCarNameText.text = "";
		if (OnCarDescText != null) OnCarDescText.text = "";
		if (OnRichPointText != null) OnRichPointText.text = "0";
		if (OnEquippedObj != null) OnEquippedObj.SetActive(false);
	}

	private void SetPurchaseUI()
	{
		// Set purchase car image and price
		if (PurchaseGemBtnText != null) PurchaseGemBtnText.text = PurchaseGemPrice.ToString();
	}

	private void SetRichPointUI()
	{
		// Set rich point progress bar
		if (RichPointSlider != null) RichPointSlider.value = 0f;
		if (RichPointCountText != null) RichPointCountText.SetText("0");
	}

	private void SetSpecialUI()
	{
		// Set special car info
		if (SpecialCarName != null) SpecialCarName.text = "";
		if (SpecialCarDesc != null) SpecialCarDesc.text = "";
	}

	private void OnClickEquip()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		// Equip the car in this parking space
		UpdateState();
	}

	private void OnClickSale()
	{
		// Sell the parked car
		SellCarCallback?.Invoke();
		UpdateState();
	}

	private void OnClickPurchase()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		// Purchase car via gem or cash
		if (PurchaseEffectObj != null)
		{
			PurchaseEffectObj.SetActive(false);
			PurchaseEffectObj.SetActive(true);
		}
		UpdateState();
	}

	private void OnClickRichPointInfo()
	{
		// Show rich point info popup
	}

	private void OnClickNoneShortCut()
	{
		// Navigate to car market to buy a car for this slot
		OpenCarMarket(0);
	}

	private void OnClickNextNoneShortCut()
	{
		// Navigate to next region car market
		OpenCarMarket(0);
	}

	private bool IsAllCarsPurchased()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return false;
		// Check if all cars in current zone are purchased
		return false;
	}

	private void OpenCarMarket(int carStoreIdx)
	{
		// Open car market page for purchasing
	}

	private void UpdateParkingLotUI()
	{
		UpdateState();
	}

	private void OnDestroy()
	{
		if (UpdateStateCoroutine != null)
		{
			StopCoroutine(UpdateStateCoroutine);
			UpdateStateCoroutine = null;
		}
	}
}
