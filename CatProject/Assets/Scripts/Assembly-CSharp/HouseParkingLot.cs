using System;
using System.Collections.Generic;
using UnityEngine;

public class HouseParkingLot : MonoBehaviour
{
	[SerializeField]
	private GameObject HouseRoot;

	[SerializeField]
	private GameObject ParkingRoot;

	[SerializeField]
	private GameObject OpenFx;

	[SerializeField]
	private List<ParkingSpace> ParkingSpaces;

	private int HouseIdx;

	private Action<int> CbClickHouse;

	private int OriginHouseIdx;

	public Transform Trans { get { return null; } }

	public Transform ParkingTrans(int order)
	{
		return null;
	}

	public void Init(int houseIdx, Action<int> clickHouse)
	{
	}

	public void UpdateCurHouse()
	{
	}

	public void UpdateParkingSpace()
	{
	}

	public void UpdateEditModeUI()
	{
	}

	private void OnClickHouse()
	{
	}
}
