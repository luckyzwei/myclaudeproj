using System.Collections.Generic;
using UnityEngine;

public class PaidParkingLot : MonoBehaviour
{
	[SerializeField]
	private GameObject LockObj;

	[SerializeField]
	private GameObject UnLockObj;

	[SerializeField]
	private Transform UITrans;

	[SerializeField]
	private List<ParkingSpace> ParkingLotSpace;

	private bool IsOpen;

	private InGameParkingOpenUI OpenUI;

	public int ParkingLotZone { get; private set; }

	public void Init(int parking_zone)
	{
	}

	private void UpdateSpaces(bool init = false)
	{
	}

	public void SetOpen()
	{
	}

	private void LoadUI(int needHouse)
	{
	}

	public void UpdateEditModeUI()
	{
	}

	private void UpdateUI()
	{
	}

	public Transform GetParkingLotTrans(int order)
	{
		return null;
	}

	public void OnClickParkingLot(int space = -1)
	{
	}
}
