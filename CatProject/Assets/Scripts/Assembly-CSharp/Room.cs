using System;
using System.Collections.Generic;
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
		return false;
	}

	public virtual void Init(int office)
	{
	}

	protected virtual void SetOpened(bool value)
	{
	}

	public virtual void OnClickOffice()
	{
	}

	private void LoadRoomUI()
	{
	}

	private void LoadOpenRoomUI()
	{
	}

	public void UpdateRoomUI()
	{
	}

	private void SubscribeOpen()
	{
	}

	private void SubscribeRoomStatus()
	{
	}

	public void UpdateStatus()
	{
	}

	public void AddUITutorialRegister(TutorialIdent ident)
	{
	}

	public void ResetRepairing()
	{
	}

	public void WaitRepairing()
	{
	}

	public void StartRepairing()
	{
	}

	public virtual void EndRepairing()
	{
	}

	public void ShowItemPreview(int type, int idx, bool value)
	{
	}

	public Transform GetItemTrans(int type, int idx)
	{
		return null;
	}

	public Transform GetItemLowLevelTrans(int type, int level)
	{
		return null;
	}

	public Transform GetFirstItemTrans()
	{
		return null;
	}

	private void OnDestroy()
	{
	}
}
