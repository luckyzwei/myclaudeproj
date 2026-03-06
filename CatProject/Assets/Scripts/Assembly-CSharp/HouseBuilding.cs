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
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	private void LoadUI()
	{
		if (RealtorRoot == null) return;
	}

	private void LoadCarInfoUI()
	{
		if (RealtorRoot == null) return;
	}

	private void LoadCeo()
	{
		if (CeoRoot == null) return;
	}

	private void LoadCars()
	{
		if (ParkingTrans == null) return;
		for (int i = 0; i < ParkingTrans.Count; i++)
		{
			if (ParkingTrans[i] == null) continue;
		}
	}

	public void OnClickRealtor()
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null) return;
		root.WaitAndOpenUICoroutine<PopupHouseSale>();
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
		if (CarInfoUI == null) return;
	}

	private void ShowSpecialCarInfo(int idx)
	{
		if (SpecialParkingTrans == null) return;
	}

	private void OnDestroy()
	{
		if (Cars != null) Cars.Clear();
	}
}
