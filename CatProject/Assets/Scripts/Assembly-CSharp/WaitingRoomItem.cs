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
		return CurState == state;
	}

	public void Init(int office, int type, int idx)
	{
		OfficeIdx = office;
		ItemType = type;
		ItemIdx = idx;
		CurState = State.Close;
		InUseEmployee = null;
		deltaTime = 0f;
	}

	public void SetOpen(bool value)
	{
		CurState = value ? State.Empty : State.Close;
	}

	public void SetUseTime(float time)
	{
		UseTime = time;
	}

	public void WaitEnter(Employee employee)
	{
		InUseEmployee = employee;
		CurState = State.Wait;
	}

	public void StartWaitingRoom()
	{
		CurState = State.Process;
		deltaTime = 0f;
		SetUseObjActive(true);
	}

	public void ResetWaitingRoom()
	{
		CurState = State.Empty;
		InUseEmployee = null;
		deltaTime = 0f;
		SetUseObjActive(false);
	}

	public void EndInWaitingRoom()
	{
		if (InUseEmployee != null)
		{
			InUseEmployee.EndUseWaitingItem?.Invoke();
			InUseEmployee = null;
		}
		ResetWaitingRoom();
	}

	public void SetUseObjActive(bool value)
	{
		if (UseOnObjs != null)
		{
			for (int i = 0; i < UseOnObjs.Count; i++)
			{
				if (UseOnObjs[i] != null && UseOnObjs[i].OnObjs != null)
					for (int j = 0; j < UseOnObjs[i].OnObjs.Count; j++)
						if (UseOnObjs[i].OnObjs[j] != null) UseOnObjs[i].OnObjs[j].SetActive(value);
			}
		}
		if (UseOffObjs != null)
		{
			for (int i = 0; i < UseOffObjs.Count; i++)
				if (UseOffObjs[i] != null) UseOffObjs[i].SetActive(!value);
		}
	}

	public void UpdateUseEmployee()
	{
		if (CurState != State.Process || InUseEmployee == null) return;
		deltaTime += Time.deltaTime;
		if (UseTime > 0f && deltaTime >= UseTime)
			EndInWaitingRoom();
	}
}
