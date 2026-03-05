using System;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupHouseBase", false, false)]
public class PopupHouseBase : UIBase
{
	[Header("PopupHouseBase")]
	[SerializeField]
	private Image ParkingLotIcon;

	[SerializeField]
	private Text TitleText;

	[SerializeField]
	private Button UpgradeBtn;

	[SerializeField]
	private GameObject UpgradeFocusObj;

	[Space(10f)]
	[SerializeField]
	private ItemParkingCar ParkingCar;

	[Space(5f)]
	[SerializeField]
	private ScrollRect ParkingSlotScroll;

	[SerializeField]
	private GameObject ParkingSlotItem;

	[Space(5f)]
	[SerializeField]
	private Button LeftBtn;

	[SerializeField]
	private Button RightBtn;

	private int CurHouseIdx;

	private int NextHouseIdx;

	private int CurParkingZone;

	private int SelectParkingSpace;

	private Action BuyCallback;

	protected override void Awake()
	{
		base.Awake();

		if (LeftBtn != null) LeftBtn.onClick.AddListener(OnClickLeft);
		if (RightBtn != null) RightBtn.onClick.AddListener(OnClickRight);
		if (UpgradeBtn != null) UpgradeBtn.onClick.AddListener(OnClickUpgrade);
	}

	public void SetHouse(int houseIdx, int order, Action buyCallback)
	{
		CurHouseIdx = houseIdx;
		NextHouseIdx = houseIdx;
		BuyCallback = buyCallback;

		if (TitleText != null) TitleText.text = "";
		SetParkingSlot();
		UpdateMoveBtn();
	}

	public void SetBuyParkingLot(int zone, int space)
	{
		CurParkingZone = zone;
		SelectParkingSpace = space;
		UpdateParkingSlot();
	}

	public void SetSpecialParkingLot(int idx)
	{
		// Set up special parking lot display
	}

	public void UpdateParkingSlot()
	{
		if (ParkingCar != null)
			ParkingCar.Set(CurParkingZone, SelectParkingSpace, () => { UpdateParkingSlot(); });
	}

	public void SetParkingSlot(bool isFocus = false)
	{
		UpdateParkingSlot();
		if (isFocus) FocusParkingLot();
	}

	public void UpdateSetBuff()
	{
		// Update parking set buff display
	}

	private void FocusParkingLot()
	{
		// Scroll to the selected parking space
	}

	private void UpdateMoveBtn()
	{
		if (LeftBtn != null) LeftBtn.gameObject.SetActive(CurHouseIdx > 0);
		if (RightBtn != null) RightBtn.gameObject.SetActive(true);
	}

	private void OnClickLeft()
	{
		if (CurHouseIdx > 0)
		{
			CurHouseIdx--;
			SetParkingSlot();
			UpdateMoveBtn();
		}
	}

	private void OnClickRight()
	{
		CurHouseIdx++;
		SetParkingSlot();
		UpdateMoveBtn();
	}

	private void OnClickUpgrade()
	{
		// Upgrade parking lot
		BuyCallback?.Invoke();
	}

	public void FocusUpgradeBtn()
	{
		if (UpgradeFocusObj != null) UpgradeFocusObj.SetActive(true);
	}

	public override void Hide()
	{
		base.Hide();
		if (UpgradeFocusObj != null) UpgradeFocusObj.SetActive(false);
	}
}
