using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemParkingSlot : MonoBehaviour
{
	private enum E_ParkingSlotType
	{
		NONE = 0,
		ON = 1,
		PURCHASE = 2,
		RICH_POINT = 3,
		SPECIAL = 4
	}

	[SerializeField]
	private Button ParkingSlotButton;

	[Space(5f)]
	[SerializeField]
	private GameObject RichPointObj;

	[SerializeField]
	private Image RichPointImg;

	[SerializeField]
	private Slider RichPointSlider;

	[SerializeField]
	private ProgressText RichPointText;

	[Space(5f)]
	[SerializeField]
	private GameObject SpecialObj;

	[SerializeField]
	private Image SpecialImg;

	[Space(5f)]
	[SerializeField]
	private GameObject NoneObj;

	[SerializeField]
	private GameObject LockObj;

	[Space(5f)]
	[SerializeField]
	private GameObject OnObj;

	[SerializeField]
	private Image OnImg;

	[SerializeField]
	private Image OnLogo;

	[Space(5f)]
	[SerializeField]
	private GameObject BuffObj;

	[SerializeField]
	private Image BuffIcon;

	[SerializeField]
	private Text BuffText;

	[Space(5f)]
	[SerializeField]
	private GameObject SelectObj;

	private int CurParkingZone;

	private int ParkingCarIdx;

	private E_ParkingSlotType CurrentParkingSlotType;

	public int CurParkingSpace { get; private set; }

	public Action<int> ClickCallback { get; set; }

	private void Awake()
	{
		if (ParkingSlotButton != null)
			ParkingSlotButton.onClick.AddListener(() => ClickCallback?.Invoke(CurParkingSpace));
	}

	public void Set(int zone, int space)
	{
		CurParkingZone = zone;
		CurParkingSpace = space;
		UpdateState();
	}

	public void UpdateState()
	{
		DrawStatus();
	}

	private void DrawStatus()
	{
	}

	public void SetSelect(bool isSelect)
	{
		if (SelectObj != null) SelectObj.SetActive(isSelect);
	}
}
