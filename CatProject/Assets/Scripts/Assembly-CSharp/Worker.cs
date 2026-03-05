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
		if (transform.position.y > 0)
			Floor = Mathf.FloorToInt(transform.position.y / 3f);
	}

	protected void LoadRepairProgress()
	{
		if (ProgressTrans != null && RepairProgress == null)
		{
			RepairProgress = ProgressTrans.GetComponentInChildren<InGameProgress>(true);
		}
	}

	protected void SetAni(E_State state, E_Direction dir)
	{
		SetAni(state.ToString(), dir);
	}

	protected void SetAni(string state, E_Direction dir)
	{
		if (CharAni == null) return;
		string aniName = state + "_" + dir.ToString();
		if (aniName == LastAni) return;
		LastAni = aniName;
		CharAni.Play(aniName);
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
		isOut = true;
		ChangeState(E_State.Workoff);
		if (outcompany)
			GotoWorkOffBus(order);
	}

	protected void GotoWorkOffBus(int order = 0)
	{
		ChangeState(E_State.Workoff);
		// Walk to bus stop then call Return
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
		TargetOffice = OfficeIdx;
		ChangeState(E_State.Repairing);
		LoadRepairProgress();
		RepairStart();
	}

	private void RepairStart()
	{
		if (RepairProgress != null)
		{
			RepairProgress.gameObject.SetActive(true);
			RepairProgress.Show();
		}
		d_repair = 0f;
		RepairTime = OriginRepairTime;
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
		switch (state)
		{
			case E_State.Move:
			case E_State.WalkToWorkOn:
			case E_State.Run:
			{
				if (CurTargetNode == null && MoveNodeList != null && MoveNodeList.Count > 0)
					CurTargetNode = MoveNodeList.Dequeue();
				if (CurTargetNode != null)
				{
					float spd = (state == E_State.Run) ? RunSpeed : Speed;
					Vector2 targetPos = new Vector2(CurTargetNode.WorldPos.x, CurTargetNode.WorldPos.y);
					Vector2 curPos = new Vector2(transform.position.x, transform.position.y);
					dir = GetDir(curPos, targetPos);
					SetAni(state, dir);
					transform.position = Vector3.MoveTowards(transform.position, CurTargetNode.WorldPos, spd * Time.deltaTime);
					if (Vector2.Distance(curPos, targetPos) < 0.05f)
					{
						CurTargetNode = null;
						if (MoveNodeList == null || MoveNodeList.Count == 0)
						{
							if (NextAction != null)
							{
								var action = NextAction;
								NextAction = null;
								action.Invoke();
							}
						}
					}
				}
				break;
			}
			case E_State.Repairing:
			{
				if (RepairTime > 0f)
				{
					d_repair += Time.deltaTime;
					if (RepairProgress != null)
						RepairProgress.UpdateValue(d_repair / RepairTime);
					if (d_repair >= RepairTime)
					{
						if (RepairProgress != null)
							RepairProgress.Hide();
						if (TargetRepairRoom != null)
							TargetRepairRoom.EndRepairing();
						ChangeState(E_State.Idle);
					}
				}
				break;
			}
		}
	}
}
