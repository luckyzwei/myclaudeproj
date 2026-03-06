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

	public Transform Trans { get { return transform; } }

	public Transform ParkingTrans(int order)
	{
		if (ParkingSpaces == null || order < 0 || order >= ParkingSpaces.Count) return null;
		if (ParkingSpaces[order] != null)
			return ParkingSpaces[order].transform;
		return null;
	}

	public void Init(int houseIdx, Action<int> clickHouse)
	{
		HouseIdx = houseIdx;
		OriginHouseIdx = houseIdx;
		CbClickHouse = clickHouse;
	}

	public void UpdateCurHouse()
	{
		if (HouseRoot != null)
			HouseRoot.SetActive(true);
	}

	public void UpdateParkingSpace()
	{
		if (ParkingRoot != null)
			ParkingRoot.SetActive(true);
	}

	public void UpdateEditModeUI()
	{
	}

	private void OnClickHouse()
	{
		CbClickHouse?.Invoke(HouseIdx);
	}
}
