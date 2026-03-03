using System;
using System.Collections.Generic;
using UnityEngine;

public class WaitingRoomItem : MonoBehaviour
{
	[Serializable]
	private class UseOnObj
	{
		public int Level;

		public List<GameObject> OnObjs;
	}

	public enum State
	{
		Close = 0,
		Empty = 1,
		Wait = 2,
		Process = 3
	}

	private float deltaTime;

	private Employee InUseEmployee;

	[SerializeField]
	public Transform CharTrans;

	[SerializeField]
	private List<UseOnObj> UseOnObjs;

	[SerializeField]
	private List<GameObject> UseOffObjs;

	[SerializeField]
	private WaitingRoomItem ReplaceUseItems;

	private int OfficeIdx;

	private int ItemType;

	private int ItemIdx;

	private State CurState;

	private int ReplaceItem;

	public float UseTime { get; protected set; }

	public bool IsState(State state)
	{
		return false;
	}

	public void Init(int office, int type, int idx)
	{
	}

	public void SetOpen(bool value)
	{
	}

	public void SetUseTime(float time)
	{
	}

	public void WaitEnter(Employee employee)
	{
	}

	public void StartWaitingRoom()
	{
	}

	public void ResetWaitingRoom()
	{
	}

	public void EndInWaitingRoom()
	{
	}

	public void SetUseObjActive(bool value)
	{
	}

	public void UpdateUseEmployee()
	{
	}
}
