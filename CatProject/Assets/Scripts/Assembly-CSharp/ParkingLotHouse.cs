using System;
using System.Collections.Generic;
using Treeplla;
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

		public GameObject GetHouseRoot { get { return HouseRoot; } }

		public GameObject GetParkingRoot { get { return ParkingRoot; } }

		public List<Transform> GetParkingTrans { get { return ParkingTrans; } }

		public void Init(Action onClickHouse)
		{
			ParkingTrans = new List<Transform>();
			if (ParkingRoot != null)
			{
				for (int i = 0; i < ParkingRoot.transform.childCount; i++)
				{
					ParkingTrans.Add(ParkingRoot.transform.GetChild(i));
				}
			}

			if (HouseRoot != null)
			{
				var clickCb = HouseRoot.GetComponent<ClickCallback>();
				if (clickCb != null)
				{
					clickCb.AddCallback(() => onClickHouse?.Invoke());
				}
			}
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
		CurHouseIdx = -1;
		CurHouseOrder = -1;

		InitHouse();
		SetOwn();
		LoadUI();
		LoadCeo();
	}

	public void SetOwn()
	{
		SetHouseParking();
		SetPaidParking();
		SetSpecialParking();
	}

	public void SetSpecialParking()
	{
		if (SpecialParkingLots == null) return;
		for (int i = 0; i < SpecialParkingLots.Count; i++)
		{
			if (SpecialParkingLots[i] != null)
			{
				SpecialParkingLots[i].Init(i);
			}
		}
	}

	public void SetPaidParking(int zone = -1)
	{
		if (PaidParkingLots == null) return;
		for (int i = 0; i < PaidParkingLots.Count; i++)
		{
			if (PaidParkingLots[i] != null)
			{
				if (zone >= 0 && i != zone) continue;
				PaidParkingLots[i].Init(i);
				PaidParkingLots[i].SetOpen();
			}
		}
	}

	public void SetHouseParking()
	{
		if (HouseParkingLots == null) return;
		for (int i = 0; i < HouseParkingLots.Count; i++)
		{
			if (HouseParkingLots[i] != null)
			{
				HouseParkingLots[i].UpdateCurHouse();
				HouseParkingLots[i].UpdateParkingSpace();
			}
		}
	}

	public void RedrawParkingLot()
	{
		SetHouseParking();
		SetPaidParking();
		SetSpecialParking();
	}

	public void UpdateEditModeUI()
	{
		if (HouseParkingLots != null)
		{
			for (int i = 0; i < HouseParkingLots.Count; i++)
			{
				if (HouseParkingLots[i] != null)
					HouseParkingLots[i].UpdateEditModeUI();
			}
		}

		if (PaidParkingLots != null)
		{
			for (int i = 0; i < PaidParkingLots.Count; i++)
			{
				if (PaidParkingLots[i] != null)
					PaidParkingLots[i].UpdateEditModeUI();
			}
		}
	}

	private void InitHouse()
	{
		if (HouseParkingLots == null) return;
		for (int i = 0; i < HouseParkingLots.Count; i++)
		{
			if (HouseParkingLots[i] != null)
			{
				HouseParkingLots[i].Init(i, OnClickHouse);
			}
		}
	}

	public void SetHouse()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null) return;

		int houseIdx = ProjectUtility.FindRegionCurHouseIdx();
		if (houseIdx >= 0)
		{
			CurHouseIdx = houseIdx;
		}

		SetHouseParking();
	}

	public void ShowArrow(Transform Trans)
	{
		if (Arrow == null) return;
		Arrow.Init(Trans);
		Arrow.Show();
	}

	public void HideArrow()
	{
		if (Arrow == null) return;
		Arrow.Hide();
	}

	private void LoadUI()
	{
		if (RealtorUI == null && RealtorRoot != null)
		{
			var prefab = Resources.Load<GameObject>("UI/InGame/RealtorUI");
			if (prefab != null)
			{
				var go = Instantiate(prefab, RealtorRoot);
				RealtorUI = go.GetComponent<InGameRealtorUI>();
				if (RealtorUI != null)
				{
					RealtorUI.Init(RealtorRoot, GameType.House);
				}
			}
		}

		if (Arrow == null)
		{
			var prefab = Resources.Load<GameObject>("UI/InGame/Arrow");
			if (prefab != null)
			{
				var go = Instantiate(prefab, transform);
				Arrow = go.GetComponent<InGameArrow>();
				if (Arrow != null)
				{
					Arrow.Init(transform, GameType.House);
					Arrow.Hide();
				}
			}
		}
	}

	private void LoadCeo()
	{
		if (CeoRoot == null) return;

		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		int costumeIdx = 0;
		if (root.UserData.CeoCostumeData != null)
			costumeIdx = root.UserData.CeoCostumeData.EquippedCostumeIdx;

		string key = string.Format("Character/Ceo_{0}", costumeIdx);
		var loadObj = new AddressableLoadGameObject();
		loadObj.InstantiateAsync(key, CeoRoot, false, (go) =>
		{
			if (go != null)
			{
				CeoAni = go.GetComponent<Animator>();
			}
		});
	}

	public void ShowConversation()
	{
		if (ProjectUtility.ShouldShowConversationForHouse(CurHouseIdx))
		{
			var root = Singleton<GameRoot>.Instance;
			if (root == null || root.UISystem == null) return;
			// Show conversation page for current house
		}
	}

	public Transform GetCurHouseParkingLotByOrder(int order)
	{
		if (HouseParkingLots == null || CurHouseOrder < 0 || CurHouseOrder >= HouseParkingLots.Count)
			return null;

		var lot = HouseParkingLots[CurHouseOrder];
		if (lot == null) return null;
		return lot.ParkingTrans(order);
	}

	public Transform GetCurBuyParkingLotByOrder(int parkingLotZone, int parkingLotSpace)
	{
		if (PaidParkingLots == null || parkingLotZone < 0 || parkingLotZone >= PaidParkingLots.Count)
			return null;

		var lot = PaidParkingLots[parkingLotZone];
		if (lot == null) return null;
		return lot.GetParkingLotTrans(parkingLotSpace);
	}

	public Transform GetCurSpecialParkingLotByOrder(int order)
	{
		if (SpecialParkingLots == null || order < 0 || order >= SpecialParkingLots.Count)
			return null;

		var lot = SpecialParkingLots[order];
		if (lot == null) return null;
		return lot.transform;
	}

	public void PlayCeoDance(bool isMoveHouse = true)
	{
		if (CeoAni == null) return;
		CeoAni.SetTrigger("Dance");
	}

	public void OnClickRealtor()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.InGameSystem == null) return;

		var inGameHouse = root.InGameSystem.CurOutGame as InGameHouse;
		if (inGameHouse == null) return;

		int houseIdx = inGameHouse.GetHouseIdx();
		OnClickHouse(houseIdx);
	}

	public void BuyUpdateHouse()
	{
		SetHouse();
		RedrawParkingLot();
		PlayCeoDance();
	}

	public void FocusHouse(Action callback)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.InGameSystem == null)
		{
			callback?.Invoke();
			return;
		}

		var inGameHouse = root.InGameSystem.CurOutGame as InGameHouse;
		if (inGameHouse == null || inGameHouse.IngameCamera == null)
		{
			callback?.Invoke();
			return;
		}

		if (CurHouseOrder >= 0 && CurHouseOrder < HouseParkingLots.Count && HouseParkingLots[CurHouseOrder] != null)
		{
			Vector3 housePos = HouseParkingLots[CurHouseOrder].Trans.position;
			inGameHouse.IngameCamera.FocusPosition(housePos, CamOrthographicSize);
		}

		callback?.Invoke();
	}

	public void OnClickHouse(int houseIdx)
	{
		CurHouseIdx = houseIdx;

		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.InGameSystem == null) return;

		var inGameHouse = root.InGameSystem.CurOutGame as InGameHouse;
		if (inGameHouse == null) return;

		if (inGameHouse.IngameCamera != null)
		{
			inGameHouse.IngameCamera.SetCameraZoom(CamOrthographicSize);
			inGameHouse.IngameCamera.useBounds = true;
			inGameHouse.IngameCamera.boundMinX = transform.position.x + CameraMinXPadding;
			inGameHouse.IngameCamera.boundMaxX = transform.position.x + CameraMaxXPadding;
			inGameHouse.IngameCamera.boundMinY = transform.position.y + CameraMinYPadding;
			inGameHouse.IngameCamera.boundMaxY = transform.position.y + CameraMaxYPadding;
		}
	}

	private void OnDestroy()
	{
		if (RealtorUI != null)
		{
			Destroy(RealtorUI.gameObject);
			RealtorUI = null;
		}

		if (Arrow != null)
		{
			Destroy(Arrow.gameObject);
			Arrow = null;
		}

		CeoAni = null;
	}
}
