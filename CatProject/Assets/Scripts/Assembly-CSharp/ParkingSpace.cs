using System;
using UnityEngine;

public class ParkingSpace : MonoBehaviour
{
	[SerializeField]
	private GameObject LockObj;

	[SerializeField]
	private GameObject ParkingObj;

	[SerializeField]
	private Transform CarTrans;

	private int ParkingZone;

	private int ParkingOrder;

	public Action<int> ClickAction;

	private bool IsOpen;

	private int CarIdx;

	private GameObject CarObj;

	private InGameParkingEditUI EditUI;

	private bool isInit;

	public Transform ParkingTrans { get { return CarTrans; } }

	private void Awake()
	{
		isInit = false;
		IsOpen = false;
		CarIdx = -1;
	}

	public void Set(int zone, int order)
	{
		ParkingZone = zone;
		ParkingOrder = order;
		isInit = true;
		UpdateOpen();
	}

	private void LoadEditUI()
	{
	}

	public void UpdateEditMode()
	{
		if (EditUI != null)
			EditUI.gameObject.SetActive(IsOpen);
	}

	public void UpdateOpen()
	{
		if (LockObj != null) LockObj.SetActive(!IsOpen);
		if (ParkingObj != null) ParkingObj.SetActive(IsOpen);
	}

	private void OnClickParkingSpace()
	{
		ClickAction?.Invoke(ParkingOrder);
	}

	public void UpdateCar()
	{
	}

	private void DestroyCar()
	{
		if (CarObj != null)
		{
			Destroy(CarObj);
			CarObj = null;
		}
		CarIdx = -1;
	}

	private void OnDestroy()
	{
		DestroyCar();
	}
}
