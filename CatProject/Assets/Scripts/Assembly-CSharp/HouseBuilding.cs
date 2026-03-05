using System;
using System.Collections.Generic;
using UnityEngine;

public class HouseBuilding : MonoBehaviour
{
	[Serializable]
	private class SpecialParkingTransData
	{
		[SerializeField]
		private int idx;

		[SerializeField]
		private Transform transform;

		[SerializeField]
		private GameObject lockObj;

		public int Idx { get { return idx; } }

		public Transform Transform { get { return transform; } }

		public GameObject LockObj { get { return lockObj; } }

		public InGameTouchInfoUI TouchInfoUI { get; set; }
	}

	[SerializeField]
	private Transform RealtorRoot;

	[SerializeField]
	private Transform CeoRoot;

	[SerializeField]
	private List<Transform> ParkingTrans;

	[SerializeField]
	private List<SpecialParkingTransData> SpecialParkingTrans;

	[Header("Input Value")]
	[SerializeField]
	private float camOrthographicSize;

	[SerializeField]
	private float cameraMinXPadding;

	[SerializeField]
	private float cameraMaxXPadding;

	[SerializeField]
	private float cameraMinYPadding;

	[SerializeField]
	private float cameraMaxYPadding;

	private InGameRealtorUI RealtorUI;

	private InGameHouseCarInfo CarInfoUI;

	private int HouseIdx;

	private Dictionary<int, Animator> Cars;

	private Animator CeoAni;

	public void Init(int idx)
	{
		HouseIdx = idx;
		Cars = new Dictionary<int, Animator>();
		LoadUI();
		LoadCeo();
		LoadCars();
	}

	private void SetOwn()
	{
		// Setup ownership state for the house building
	}

	private void LoadUI()
	{
		// Load realtor UI at RealtorRoot
	}

	private void LoadCarInfoUI()
	{
		// Load car info UI
	}

	private void LoadCeo()
	{
		if (CeoRoot == null) return;
		// Load CEO character at CeoRoot
	}

	private void LoadCars()
	{
		if (ParkingTrans == null) return;
		// Load cars at parking transform positions
	}

	public void OnClickRealtor()
	{
		// Open realtor menu popup
	}

	private void OnClickCar(int idx, bool isSpecial = false)
	{
		if (isSpecial)
			ShowSpecialCarInfo(idx);
		else
			UpdateTouchInfoUI(idx);
	}

	private void UpdateTouchInfoUI(int idx)
	{
		// Show touch info UI for the car at index
	}

	private void ShowSpecialCarInfo(int idx)
	{
		// Show special car info popup
	}

	private void OnDestroy()
	{
		if (Cars != null) Cars.Clear();
	}
}
