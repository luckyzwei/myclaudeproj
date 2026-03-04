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

		public int Idx { get { return 0; } }

		public Transform Transform { get { return null; } }

		public GameObject LockObj { get { return null; } }

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
	}

	private void SetOwn()
	{
	}

	private void LoadUI()
	{
	}

	private void LoadCarInfoUI()
	{
	}

	private void LoadCeo()
	{
	}

	private void LoadCars()
	{
	}

	public void OnClickRealtor()
	{
	}

	private void OnClickCar(int idx, bool isSpecial = false)
	{
	}

	private void UpdateTouchInfoUI(int idx)
	{
	}

	private void ShowSpecialCarInfo(int idx)
	{
	}

	private void OnDestroy()
	{
	}
}
