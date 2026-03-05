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
		ParkingLotZone = parking_zone;
		IsOpen = false;
		if (LockObj != null) LockObj.SetActive(true);
		if (UnLockObj != null) UnLockObj.SetActive(false);
		UpdateSpaces(true);
	}

	private void UpdateSpaces(bool init = false)
	{
		if (ParkingLotSpace == null) return;
		for (int i = 0; i < ParkingLotSpace.Count; i++)
		{
			if (ParkingLotSpace[i] != null)
			{
				if (init)
					ParkingLotSpace[i].Set(ParkingLotZone, i);
				else
					ParkingLotSpace[i].UpdateOpen();
			}
		}
	}

	public void SetOpen()
	{
		IsOpen = true;
		if (LockObj != null) LockObj.SetActive(false);
		if (UnLockObj != null) UnLockObj.SetActive(true);
		UpdateSpaces();
	}

	private void LoadUI(int needHouse)
	{
		// Load InGameParkingOpenUI at UITrans via Addressables
	}

	public void UpdateEditModeUI()
	{
		if (ParkingLotSpace == null) return;
		for (int i = 0; i < ParkingLotSpace.Count; i++)
		{
			if (ParkingLotSpace[i] != null)
				ParkingLotSpace[i].UpdateEditMode();
		}
	}

	private void UpdateUI()
	{
		if (OpenUI != null)
			OpenUI.gameObject.SetActive(!IsOpen);
	}

	public Transform GetParkingLotTrans(int order)
	{
		if (ParkingLotSpace == null || order < 0 || order >= ParkingLotSpace.Count)
			return null;
		if (ParkingLotSpace[order] != null)
			return ParkingLotSpace[order].ParkingTrans;
		return null;
	}

	public void OnClickParkingLot(int space = -1)
	{
		if (!IsOpen) return;
		// Open parking lot management popup
	}
}
