using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Worker : MonoBehaviour
{
	public enum E_WorkerType
	{
		Ceo = 0,
		Employee = 1,
		Engineer = 2,
		Secretary = 3,
		Manager = 4
	}

	public enum E_AppearType
	{
		Seat = 0,
		Bus = 1,
		Walk = 2,
		Tuto_Start = 3
	}

	protected enum E_Direction
	{
		Front_Left = 0,
		Front_Right = 1,
		Front = 2,
		Back_Left = 3,
		Back_Right = 4,
		Back = 5
	}

	public enum E_State
	{
		None = 0,
		WalkToWorkOn = 1,
		Move = 2,
		Idle = 3,
		Work = 4,
		Workoff = 5,
		Run = 6,
		WaitLine = 7,
		InWaitingRoom = 8,
		Repairing = 9,
		Strike = 10
	}

	[SerializeField]
	protected Transform ProgressTrans;

	[SerializeField]
	protected Transform CharRoot;

	protected Animator CharAni;

	protected AddressableLoadGameObject CharLoadObj;

	protected Transform MySeatTrans;

	protected E_Direction WorkDir;

	protected E_Direction TargetDir;

	protected Vector2 TargetPosition;

	protected Queue<InGameAstar.Node> MoveNodeList;

	protected InGameAstar.Node CurTargetNode;

	protected E_Direction dir;

	protected bool CancelCurStatus;

	protected E_State state;

	protected Room TargetRepairRoom;

	protected InGameProgress RepairProgress;

	protected float OriginRepairTime;

	protected float RepairTime;

	protected float d_repair;

	protected string WorkOffWaitTweenKey;

	protected Sequence OutSeq;

	protected Action NextAction;

	protected float Speed;

	protected float RunSpeed;

	protected bool isOut;

	public int Floor;

	protected int MyFloor;

	protected int TargetFloor;

	protected string LastAni;

	public int TargetOffice { get; protected set; }

	public E_WorkerType WorkerType { get; protected set; }

	public bool IsState(E_State _st)
	{
		return state == _st;
	}

	protected void WorkerInit()
	{
		state = E_State.None;
		MoveNodeList = new Queue<InGameAstar.Node>();
		Speed = 2f;
		RunSpeed = 4f;
		isOut = false;
		CancelCurStatus = false;
	}

	protected virtual void ChangeState(E_State _state, bool isForce = false)
	{
		if (state == _state && !isForce) return;
		state = _state;
	}

	public void UnloadChar()
	{
		if (CharLoadObj != null)
		{
			CharLoadObj.Release();
			CharLoadObj = null;
		}
		CharAni = null;
	}

	protected virtual void UpdateFloor()
	{
	}

	protected void LoadRepairProgress()
	{
	}

	protected void SetAni(E_State state, E_Direction dir)
	{
	}

	protected void SetAni(string state, E_Direction dir)
	{
	}

	protected void UpdatWorkDir(Transform trans, out E_Direction dir)
	{
		if (trans != null && MySeatTrans != null)
			dir = GetDir(transform.position, MySeatTrans.position);
		else
			dir = E_Direction.Front;
	}

	public virtual void WorkOut(int order, bool outcompany = false)
	{
	}

	protected void GotoWorkOffBus(int order = 0)
	{
	}

	public int GetRepairRoomIdx()
	{
		if (TargetRepairRoom != null)
			return TargetRepairRoom.OfficeIdx;
		return 0;
	}

	public virtual void Return()
	{
		ChangeState(E_State.None);
		isOut = false;
		UnloadChar();
	}

	public virtual void GotoRepairOffice(int OfficeIdx)
	{
	}

	private void RepairStart()
	{
	}

	protected E_Direction GetDir(Vector2 curPos, Vector2 nextPos)
	{
		float dx = nextPos.x - curPos.x;
		float dy = nextPos.y - curPos.y;
		if (Mathf.Abs(dx) < 0.01f)
			return dy > 0 ? E_Direction.Back : E_Direction.Front;
		if (dx > 0)
			return dy > 0 ? E_Direction.Back_Right : E_Direction.Front_Right;
		return dy > 0 ? E_Direction.Back_Left : E_Direction.Front_Left;
	}

	protected virtual void Update()
	{
	}
}
