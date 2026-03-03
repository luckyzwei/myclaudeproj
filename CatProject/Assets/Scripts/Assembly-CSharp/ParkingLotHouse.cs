using System;
using System.Collections.Generic;
using UnityEngine;

public class ParkingLotHouse : MonoBehaviour
{
	[Serializable]
	private class HouseParkingTransData
	{
		[SerializeField]
		private GameObject HouseRoot;

		[SerializeField]
		private GameObject ParkingRoot;

		[SerializeField]
		public GameObject OpenFx;

		private List<Transform> ParkingTrans;

		public GameObject GetHouseRoot => null;

		public GameObject GetParkingRoot => null;

		public List<Transform> GetParkingTrans => null;

		public void Init(Action onClickHouse)
		{
		}
	}

	[SerializeField]
	private Transform RealtorRoot;

	[SerializeField]
	private Transform CeoRoot;

	[Space(10f)]
	[SerializeField]
	private List<HouseParkingLot> HouseParkingLots;

	[SerializeField]
	private List<PaidParkingLot> PaidParkingLots;

	[SerializeField]
	private List<SpecialParkingLot> SpecialParkingLots;

	[Header("Input Value")]
	[SerializeField]
	private float CamOrthographicSize;

	[SerializeField]
	private float CameraMinXPadding;

	[SerializeField]
	private float CameraMaxXPadding;

	[SerializeField]
	private float CameraMinYPadding;

	[SerializeField]
	private float CameraMaxYPadding;

	[Space(5f)]
	[SerializeField]
	private Vector2 HouseZoomPadding;

	private InGameRealtorUI RealtorUI;

	private InGameArrow Arrow;

	private int CurHouseIdx;

	private int CurHouseOrder;

	private Animator CeoAni;

	public void Init()
	{
	}

	public void SetOwn()
	{
	}

	public void SetSpecialParking()
	{
	}

	public void SetPaidParking(int zone = -1)
	{
	}

	public void SetHouseParking()
	{
	}

	public void RedrawParkingLot()
	{
	}

	public void UpdateEditModeUI()
	{
	}

	private void InitHouse()
	{
	}

	public void SetHouse()
	{
	}

	public void ShowArrow(Transform Trans)
	{
	}

	public void HideArrow()
	{
	}

	private void LoadUI()
	{
	}

	private void LoadCeo()
	{
	}

	public void ShowConversation()
	{
	}

	public Transform GetCurHouseParkingLotByOrder(int order)
	{
		return null;
	}

	public Transform GetCurBuyParkingLotByOrder(int parkingLotZone, int parkingLotSpace)
	{
		return null;
	}

	public Transform GetCurSpecialParkingLotByOrder(int order)
	{
		return null;
	}

	public void PlayCeoDance(bool isMoveHouse = true)
	{
	}

	public void OnClickRealtor()
	{
	}

	public void BuyUpdateHouse()
	{
	}

	public void FocusHouse(Action callback)
	{
	}

	public void OnClickHouse(int houseIdx)
	{
	}

	private void OnDestroy()
	{
	}
}
