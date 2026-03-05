using System;
using System.Collections.Generic;
using Treeplla;
using UniRx;
using UnityEngine;

public class Room : MonoBehaviour
{
	public enum RoomStatus
	{
		None = 0,
		BookRepairing = 1,
		Repairing = 2,
		Repair = 3,
		Maintenance = 4,
		LvUp = 5,
		EndCompany = 6,
		NewCompany = 7,
		NewRoom = 8,
		MaxLevel = 9
	}

	[Serializable]
	protected class RoomItemGroup
	{
		[HideInInspector]
		public int Type;

		[HideInInspector]
		public bool UseSeat;

		public List<OfficeItem> Items;
	}

	[SerializeField]
	protected List<RoomItemGroup> ItemGroups;

	[SerializeField]
	private GameObject LockObj;

	[SerializeField]
	private GameObject UnLockObj;

	[SerializeField]
	protected Transform LockUITrans;

	[SerializeField]
	public Transform RepairTrans;

	[SerializeField]
	private GameObject OpenEffect;

	private OfficeData OfficeData;

	protected bool IsOpened;

	private InGameOpenRoom openRoomUI;

	protected InGameRoomUI roomUI;

	private RoomStatus BeforeRoomStatus;

	private RoomStatus CurRoomStatus;

	private CompositeDisposable disposables;

	private CompositeDisposable openDisposables;

	public int OfficeIdx { get; private set; }

	public int OfficeFloor { get; private set; }

	public bool isLevelUpTutorialTarget { get; private set; }

	public bool IsState(RoomStatus status)
	{
		return CurRoomStatus == status;
	}

	public virtual void Init(int office)
	{
		OfficeIdx = office;
		OfficeFloor = transform.GetSiblingIndex();
		disposables = new CompositeDisposable();
		openDisposables = new CompositeDisposable();

		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var curMode = gameRoot.UserData.CurMode;
		if (curMode == null || curMode.StageData == null) return;

		if (curMode.StageData.Offices != null && curMode.StageData.Offices.TryGetValue(office, out var officeData))
		{
			OfficeData = officeData;
		}

		if (OfficeData != null && OfficeData.IsOpen != null)
		{
			SetOpened(OfficeData.IsOpen.Value);
			SubscribeOpen();
			SubscribeRoomStatus();
		}
		else
		{
			SetOpened(false);
		}
	}

	protected virtual void SetOpened(bool value)
	{
		IsOpened = value;
		if (LockObj != null) LockObj.SetActive(!value);
		if (UnLockObj != null) UnLockObj.SetActive(value);

		if (value)
		{
			LoadRoomUI();
			if (OpenEffect != null) OpenEffect.SetActive(false);
		}
		else
		{
			LoadOpenRoomUI();
		}
	}

	public virtual void OnClickOffice()
	{
		if (!IsOpened) return;
		if (OfficeData == null) return;

		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null) return;

		gameRoot.WaitAndOpenUICoroutine<PopupOfficeUpgrade>((popup) =>
		{
			// popup would be initialized with OfficeIdx
		});
	}

	private void LoadRoomUI()
	{
		if (roomUI != null) return;

		var prefab = Resources.Load<GameObject>("UI/InGame/RoomUI");
		if (prefab == null) return;

		var go = Instantiate(prefab, transform);
		roomUI = go.GetComponent<InGameRoomUI>();
		if (roomUI != null)
		{
			roomUI.Init(RepairTrans != null ? RepairTrans : transform);
			roomUI.Set(OfficeIdx);
			roomUI.SetFloor(OfficeFloor);
			UpdateStatus();
		}
	}

	private void LoadOpenRoomUI()
	{
		if (openRoomUI != null) return;

		var prefab = Resources.Load<GameObject>("UI/InGame/OpenRoom");
		if (prefab == null) return;

		var go = Instantiate(prefab, transform);
		openRoomUI = go.GetComponent<InGameOpenRoom>();
		if (openRoomUI != null)
		{
			openRoomUI.Init(LockUITrans != null ? LockUITrans : transform);
			openRoomUI.SetOffice(OfficeIdx);
			openRoomUI.SetFloor(OfficeFloor);
		}
	}

	public void UpdateRoomUI()
	{
		if (roomUI != null)
		{
			UpdateStatus();
		}
	}

	private void SubscribeOpen()
	{
		if (OfficeData == null || OfficeData.IsOpen == null) return;

		OfficeData.IsOpen.Subscribe(isOpen =>
		{
			SetOpened(isOpen);
			if (isOpen && openRoomUI != null)
			{
				Destroy(openRoomUI.gameObject);
				openRoomUI = null;
				if (OpenEffect != null) OpenEffect.SetActive(true);
			}
		}).AddTo(openDisposables);
	}

	private void SubscribeRoomStatus()
	{
		if (OfficeData == null) return;

		if (OfficeData.Level != null)
		{
			OfficeData.Level.Subscribe(_ => UpdateStatus()).AddTo(disposables);
		}

		if (OfficeData.CompanyIdx != null)
		{
			OfficeData.CompanyIdx.Subscribe(_ => UpdateStatus()).AddTo(disposables);
		}

		if (OfficeData.inRepair != null)
		{
			OfficeData.inRepair.Subscribe(_ => UpdateStatus()).AddTo(disposables);
		}

		if (OfficeData.inMaintenance != null)
		{
			OfficeData.inMaintenance.Subscribe(_ => UpdateStatus()).AddTo(disposables);
		}

		if (OfficeData.EnableStrike != null)
		{
			OfficeData.EnableStrike.Subscribe(_ => UpdateStatus()).AddTo(disposables);
		}

		if (OfficeData.OnNegotiation != null)
		{
			OfficeData.OnNegotiation.Subscribe(_ => UpdateStatus()).AddTo(disposables);
		}
	}

	public void UpdateStatus()
	{
		if (OfficeData == null || !IsOpened) return;

		BeforeRoomStatus = CurRoomStatus;

		if (!OfficeData.IsOpen.Value)
		{
			CurRoomStatus = RoomStatus.NewRoom;
		}
		else if (OfficeData.inRepair != null && OfficeData.inRepair.Value)
		{
			CurRoomStatus = RoomStatus.Repair;
		}
		else if (OfficeData.inMaintenance != null && OfficeData.inMaintenance.Value)
		{
			CurRoomStatus = RoomStatus.Maintenance;
		}
		else if (OfficeData.CompanyIdx != null && OfficeData.CompanyIdx.Value <= 0)
		{
			CurRoomStatus = RoomStatus.NewCompany;
		}
		else if (OfficeData.CompanyRemainTime != null && OfficeData.CompanyRemainTime.Value <= 0
			&& OfficeData.CompanyIdx != null && OfficeData.CompanyIdx.Value > 0)
		{
			CurRoomStatus = RoomStatus.EndCompany;
		}
		else
		{
			CurRoomStatus = RoomStatus.None;
		}

		bool onStrike = OfficeData.EnableStrike != null && OfficeData.EnableStrike.Value;
		bool onNegotiation = OfficeData.OnNegotiation != null && OfficeData.OnNegotiation.Value;

		if (roomUI != null)
		{
			roomUI.UpdateStatus(CurRoomStatus, onStrike, onNegotiation);
		}
	}

	public void AddUITutorialRegister(TutorialIdent ident)
	{
		if (roomUI == null) return;

		var register = roomUI.TutorialObj.GetComponent<TutorialRegister>();
		if (register == null)
		{
			register = roomUI.TutorialObj.AddComponent<TutorialRegister>();
		}
		register.AddData(ident);
		isLevelUpTutorialTarget = true;
	}

	public void ResetRepairing()
	{
		if (OfficeData == null) return;
		if (OfficeData.inRepair != null)
			OfficeData.inRepair.Value = false;

		CurRoomStatus = RoomStatus.None;
		UpdateStatus();
	}

	public void WaitRepairing()
	{
		CurRoomStatus = RoomStatus.BookRepairing;
		UpdateStatus();
	}

	public void StartRepairing()
	{
		if (OfficeData == null) return;
		if (OfficeData.inRepair != null)
			OfficeData.inRepair.Value = true;

		CurRoomStatus = RoomStatus.Repairing;
		UpdateStatus();
	}

	public virtual void EndRepairing()
	{
		if (OfficeData == null) return;
		if (OfficeData.inRepair != null)
			OfficeData.inRepair.Value = false;

		CurRoomStatus = RoomStatus.Repair;
		UpdateStatus();
	}

	public void ShowItemPreview(int type, int idx, bool value)
	{
		if (ItemGroups == null) return;

		for (int i = 0; i < ItemGroups.Count; i++)
		{
			if (ItemGroups[i] == null || ItemGroups[i].Type != type) continue;
			if (ItemGroups[i].Items == null) continue;

			for (int j = 0; j < ItemGroups[i].Items.Count; j++)
			{
				if (ItemGroups[i].Items[j] != null && ItemGroups[i].Items[j].ItemIdx == idx)
				{
					ItemGroups[i].Items[j].ShowPreview(value);
					return;
				}
			}
		}
	}

	public Transform GetItemTrans(int type, int idx)
	{
		if (ItemGroups == null) return null;

		for (int i = 0; i < ItemGroups.Count; i++)
		{
			if (ItemGroups[i] == null || ItemGroups[i].Type != type) continue;
			if (ItemGroups[i].Items == null) continue;

			for (int j = 0; j < ItemGroups[i].Items.Count; j++)
			{
				if (ItemGroups[i].Items[j] != null && ItemGroups[i].Items[j].ItemIdx == idx)
				{
					return ItemGroups[i].Items[j].transform;
				}
			}
		}
		return null;
	}

	public Transform GetItemLowLevelTrans(int type, int level)
	{
		if (ItemGroups == null) return null;

		for (int i = 0; i < ItemGroups.Count; i++)
		{
			if (ItemGroups[i] == null || ItemGroups[i].Type != type) continue;
			if (ItemGroups[i].Items == null) continue;

			for (int j = 0; j < ItemGroups[i].Items.Count; j++)
			{
				if (ItemGroups[i].Items[j] != null && ItemGroups[i].Items[j].ItemIdx <= level)
				{
					return ItemGroups[i].Items[j].transform;
				}
			}
		}
		return null;
	}

	public Transform GetFirstItemTrans()
	{
		if (ItemGroups == null || ItemGroups.Count == 0) return null;

		for (int i = 0; i < ItemGroups.Count; i++)
		{
			if (ItemGroups[i] == null || ItemGroups[i].Items == null) continue;

			for (int j = 0; j < ItemGroups[i].Items.Count; j++)
			{
				if (ItemGroups[i].Items[j] != null)
				{
					return ItemGroups[i].Items[j].transform;
				}
			}
		}
		return null;
	}

	private void OnDestroy()
	{
		if (disposables != null)
		{
			disposables.Dispose();
			disposables = null;
		}
		if (openDisposables != null)
		{
			openDisposables.Dispose();
			openDisposables = null;
		}
	}
}
