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

	public Transform ParkingTrans => null;

	private void Awake()
	{
	}

	public void Set(int zone, int order)
	{
	}

	private void LoadEditUI()
	{
	}

	public void UpdateEditMode()
	{
	}

	public void UpdateOpen()
	{
	}

	private void OnClickParkingSpace()
	{
	}

	public void UpdateCar()
	{
	}

	private void DestroyCar()
	{
	}

	private void OnDestroy()
	{
	}
}
