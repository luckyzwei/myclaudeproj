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
	}

	public void SetHouse(int houseIdx, int order, Action buyCallback)
	{
	}

	public void SetBuyParkingLot(int zone, int space)
	{
	}

	public void SetSpecialParkingLot(int idx)
	{
	}

	public void UpdateParkingSlot()
	{
	}

	public void SetParkingSlot(bool isFocus = false)
	{
	}

	public void UpdateSetBuff()
	{
	}

	private void FocusParkingLot()
	{
	}

	private void UpdateMoveBtn()
	{
	}

	private void OnClickLeft()
	{
	}

	private void OnClickRight()
	{
	}

	private void OnClickUpgrade()
	{
	}

	public void FocusUpgradeBtn()
	{
	}

	public override void Hide()
	{
	}
}
