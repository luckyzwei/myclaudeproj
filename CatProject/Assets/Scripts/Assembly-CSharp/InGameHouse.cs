using System.Collections.Generic;
using UnityEngine;

public class InGameHouse : OutGameMode
{
	[SerializeField]
	private Transform Root;

	private int HouseIdx;

	private ParkingLotHouse CurParkingLotHouse;

	private bool isMoveStatue;

	public bool EDITMODE { get; private set; }

	public int SelectEditParkingLot { get; private set; }

	public List<CarData> EditCarList { get; private set; }

	public int GetHouseIdx()
	{
		return HouseIdx;
	}

	public ParkingLotHouse GetCurParkingLotHouse()
	{
		return CurParkingLotHouse;
	}

	public override void Load()
	{
		LoadHouse();
	}

	public void LoadHouse()
	{
		LoadHouse(HouseIdx);
	}

	public void LoadHouse(int idx)
	{
		HouseIdx = idx;
	}

	public void SetEditMode(bool value)
	{
		EDITMODE = value;
		if (!value)
			ConfirmEditMode();
	}

	private void ConfirmEditMode()
	{
		EditCarList = null;
		SelectEditParkingLot = -1;
	}

	public void SetEditParkingLot(int parkingLotIndex)
	{
		SelectEditParkingLot = parkingLotIndex;
	}

	protected override void LoadUI()
	{
		// Load house-specific UI elements
	}

	public override void UnLoad()
	{
		EDITMODE = false;
		CurParkingLotHouse = null;
	}
}
