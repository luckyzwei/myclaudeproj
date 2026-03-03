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
		return 0;
	}

	public ParkingLotHouse GetCurParkingLotHouse()
	{
		return null;
	}

	public override void Load()
	{
	}

	public void LoadHouse()
	{
	}

	public void LoadHouse(int idx)
	{
	}

	public void SetEditMode(bool value)
	{
	}

	private void ConfirmEditMode()
	{
	}

	public void SetEditParkingLot(int parkingLotIndex)
	{
	}

	protected override void LoadUI()
	{
	}

	public override void UnLoad()
	{
	}
}
