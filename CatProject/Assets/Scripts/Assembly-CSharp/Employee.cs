using System;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class Employee : Worker
{
	private int WaitNum;

	private InGamePath WaitLine;

	private InGameEmployeeUI EmployeeUI;

	private int OfficeFloor;

	private bool ShowWaitingRoomMsg;

	private int useWaitingRoomItemType;

	private int useWaitingRoomItemIdx;

	private bool WaitingRoomItemEnoughLevel;

	private Employee NextActivityEmployee;

	private EmployeeMoodSystem.Mood CurMood;

	private CompositeDisposable disposable;

	private CompositeDisposable moodDisposables;

	private CompositeDisposable poolingDisposables;

	private CompositeDisposable loadCharDisposables;

	private bool bEnableCritical;

	private int CriticalCooltime;

	private DateTime CriticalEndTime;

	public Action CancelUseWaitingItem;

	public Action EndUseWaitingItem;

	private float WaitlineDeltaTime;

	private float AcitivtyUseTime;

	private float WorkAniDeltaTime;

	private float WorkAniDuration;

	private bool InWorkAni;

	private int WorkAniCount;

	private int TargetDeltaTime;

	private float CurDeltaTime;

	public List<string> WorkAnis;

	private float deltaTime;

	private float realtime_dtime;

	public int OfficeIdx { get; private set; }

	public int SeatIdx { get; private set; }

	public int EmployeeIdx { get; private set; }

	public int InGameViewIdx { get; private set; }

	public bool isWorkOnComp { get; private set; }

	public Subject<PoolingCharacterEffect.BurningArgs> OnEffectBurning { get; private set; }

	public bool IsDoneMeeting { get; private set; }

	public DateTime ActivityStartTime { get; private set; }

	public void Init(int office, int seat, E_AppearType appearType, int order)
	{
	}

	protected override void UpdateFloor()
	{
	}

	private void AddWorkAniStates()
	{
	}

	public void RemoveOffice()
	{
	}

	public void CalcCriticalCooltime()
	{
	}

	public override void Return()
	{
	}

	public void SetEvaluation(bool isgood)
	{
	}

	private void ReturnEmployeeUI()
	{
	}

	private void UseEmployeeUI(Action action)
	{
	}

	private void LoadEmployeeUI(Action action)
	{
	}

	public void LoadChar(int viewIdx, Action loadComp)
	{
	}

	private void SubscribeMood()
	{
	}

	public void StartActivity(int itemtype, int itemidx, int itemLevel, bool enoughlevel, float activitytime)
	{
	}

	public void ShowActivity(Config.OfficeType type)
	{
	}

	public void HideActivity()
	{
	}

	public void MoveWithAction(Transform Trans, int floor, Action nextAction)
	{
	}

	public void ReturnToOffceAndWork(bool isfromMeetingroom = false)
	{
	}

	private void WorkWait()
	{
	}

	public void WorkStart()
	{
	}

	protected override void ChangeState(E_State _state, bool isForce = false)
	{
	}

	public override void WorkOut(int order, bool outcompany = false)
	{
	}

	public void WorkOutImmediate()
	{
	}

	private void GotoWorkOffReturn(int order = 0)
	{
	}

	public void GotoWaitingRoom(int officeIdx)
	{
	}

	private void SelectActivityAndGo()
	{
	}

	public void ResetActivityTime()
	{
	}

	public void SetWaitLine(InGamePath path)
	{
	}

	public void SetWaitNum(int num)
	{
	}

	public void GetExp(int exp)
	{
	}

	public void SetActivityTime(DateTime time)
	{
	}

	private void CheckCritical()
	{
	}

	private void EndCritical()
	{
	}

	private void PlayEffectBurning()
	{
	}

	private void StopEffectBurning()
	{
	}

	private void UpdateCurCompanyExp()
	{
	}

	public void UpdateEmployeeItem(int itemIdx = -1, int itemLevel = -1)
	{
	}

	protected override void Update()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}
}
