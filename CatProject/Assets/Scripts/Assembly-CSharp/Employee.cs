using System;
using System.Collections.Generic;
using Treeplla;
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
		WorkerInit();
		OfficeIdx = office;
		SeatIdx = seat;
		WorkerType = E_WorkerType.Employee;
		disposable = new CompositeDisposable();
		moodDisposables = new CompositeDisposable();
		poolingDisposables = new CompositeDisposable();
		loadCharDisposables = new CompositeDisposable();
		OnEffectBurning = new Subject<PoolingCharacterEffect.BurningArgs>();
		CurMood = EmployeeMoodSystem.Mood.Soso;
		WorkAnis = new List<string>();
		bEnableCritical = false;
		IsDoneMeeting = false;
		isWorkOnComp = false;
		AddWorkAniStates();
	}

	protected override void UpdateFloor()
	{
		Floor = Mathf.RoundToInt(transform.position.y);
	}

	private void AddWorkAniStates()
	{
		if (WorkAnis == null)
			WorkAnis = new List<string>();
		WorkAnis.Clear();
		WorkAnis.Add("Work_01");
		WorkAnis.Add("Work_02");
		WorkAnis.Add("Work_03");
	}

	public void RemoveOffice()
	{
		OfficeIdx = -1;
		SeatIdx = -1;
	}

	public void CalcCriticalCooltime()
	{
		CriticalCooltime = UnityEngine.Random.Range(30, 120);
	}

	public override void Return()
	{
		ReturnEmployeeUI();
		if (disposable != null) disposable.Dispose();
		if (moodDisposables != null) moodDisposables.Dispose();
		if (poolingDisposables != null) poolingDisposables.Dispose();
		if (loadCharDisposables != null) loadCharDisposables.Dispose();
		base.Return();
	}

	public void SetEvaluation(bool isgood)
	{
		CurMood = isgood ? EmployeeMoodSystem.Mood.Good : EmployeeMoodSystem.Mood.Bad;
	}

	private void ReturnEmployeeUI()
	{
		if (EmployeeUI != null)
		{
			EmployeeUI.gameObject.SetActive(false);
			EmployeeUI = null;
		}
	}

	private void UseEmployeeUI(Action action)
	{
		if (EmployeeUI != null)
		{
			EmployeeUI.gameObject.SetActive(true);
			action?.Invoke();
		}
		else
		{
			LoadEmployeeUI(action);
		}
	}

	private void LoadEmployeeUI(Action action)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.InGameSystem == null) return;
		var curInGame = gameRoot.InGameSystem.CurInGame;
		if (curInGame == null) return;

		var prefab = Resources.Load<GameObject>("UI/InGame/EmployeeUI");
		if (prefab == null) return;

		var go = UnityEngine.Object.Instantiate(prefab, ProgressTrans != null ? ProgressTrans : transform);
		EmployeeUI = go.GetComponent<InGameEmployeeUI>();
		if (EmployeeUI != null)
		{
			EmployeeUI.Init(ProgressTrans != null ? ProgressTrans : transform);
			EmployeeUI.SetFloor(OfficeFloor);
			EmployeeUI.SetId(EmployeeIdx);
			action?.Invoke();
		}
	}

	public void LoadChar(int viewIdx, Action loadComp)
	{
		InGameViewIdx = viewIdx;
		if (CharLoadObj == null)
			CharLoadObj = new AddressableLoadGameObject();

		string key = string.Format("Character/Employee_{0}", viewIdx);
		CharLoadObj.InstantiateAsync(key, CharRoot, false, (go) =>
		{
			if (go != null)
			{
				CharAni = go.GetComponent<Animator>();
			}
			SubscribeMood();
			loadComp?.Invoke();
		});
	}

	private void SubscribeMood()
	{
		if (moodDisposables != null)
			moodDisposables.Dispose();
		moodDisposables = new CompositeDisposable();

		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var curMode = gameRoot.UserData.CurMode;
		if (curMode == null || curMode.StageData == null) return;

		if (curMode.StageData.Offices == null) return;
		if (!curMode.StageData.Offices.TryGetValue(OfficeIdx, out var officeData)) return;
		if (officeData == null || officeData.Employees == null) return;
		if (SeatIdx < 0 || SeatIdx >= officeData.Employees.Count) return;

		var employeeData = officeData.Employees[SeatIdx];
		if (employeeData == null || employeeData.MoodStatus == null) return;

		EmployeeIdx = employeeData.Idx;

		employeeData.MoodStatus.Subscribe(mood =>
		{
			var prevMood = CurMood;
			CurMood = mood;
			if (prevMood != mood)
			{
				PlayEffectBurning();
			}
		}).AddTo(moodDisposables);
	}

	public void StartActivity(int itemtype, int itemidx, int itemLevel, bool enoughlevel, float activitytime)
	{
		useWaitingRoomItemType = itemtype;
		useWaitingRoomItemIdx = itemidx;
		WaitingRoomItemEnoughLevel = enoughlevel;
		AcitivtyUseTime = activitytime;
		ActivityStartTime = DateTime.UtcNow;
	}

	public void ShowActivity(Config.OfficeType type)
	{
		ShowWaitingRoomMsg = true;
	}

	public void HideActivity()
	{
		ShowWaitingRoomMsg = false;
	}

	public void MoveWithAction(Transform Trans, int floor, Action nextAction)
	{
		TargetFloor = floor;
		NextAction = nextAction;
		if (Trans != null)
			TargetPosition = Trans.position;
		ChangeState(E_State.Move);
	}

	public void ReturnToOffceAndWork(bool isfromMeetingroom = false)
	{
		if (isfromMeetingroom)
			IsDoneMeeting = true;
		WorkStart();
	}

	private void WorkWait()
	{
		isWorkOnComp = false;
		ChangeState(E_State.Idle);
	}

	public void WorkStart()
	{
		isWorkOnComp = true;
		ChangeState(E_State.Work);
	}

	protected override void ChangeState(E_State _state, bool isForce = false)
	{
		base.ChangeState(_state, isForce);
	}

	public override void WorkOut(int order, bool outcompany = false)
	{
		isWorkOnComp = false;
		ChangeState(E_State.Workoff);
		if (outcompany)
			GotoWorkOffBus(order);
	}

	public void WorkOutImmediate()
	{
		isWorkOnComp = false;
		ChangeState(E_State.None);
		ReturnEmployeeUI();
	}

	private void GotoWorkOffReturn(int order = 0)
	{
		OfficeFloor = ProjectUtility.GetOfficeFloor(OfficeIdx);
		TargetFloor = OfficeFloor;
		NextAction = () =>
		{
			WorkStart();
		};
		ChangeState(E_State.WalkToWorkOn);
	}

	public void GotoWaitingRoom(int officeIdx)
	{
		isWorkOnComp = false;
		ChangeState(E_State.InWaitingRoom);
		SelectActivityAndGo();
	}

	private void SelectActivityAndGo()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.InGameSystem == null) return;
		var curInGame = gameRoot.InGameSystem.CurInGame as InGameOffice;
		if (curInGame == null || curInGame.Stage == null) return;

	}

	public void ResetActivityTime()
	{
		AcitivtyUseTime = 0f;
		ActivityStartTime = DateTime.MinValue;
	}

	public void SetWaitLine(InGamePath path)
	{
		WaitLine = path;
	}

	public void SetWaitNum(int num)
	{
		WaitNum = num;
	}

	public void GetExp(int exp)
	{
		if (exp <= 0) return;

		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var curMode = gameRoot.UserData.CurMode;
		if (curMode == null || curMode.StageData == null) return;
		if (curMode.StageData.Offices == null) return;
		if (!curMode.StageData.Offices.TryGetValue(OfficeIdx, out var officeData)) return;
		if (officeData == null || officeData.Exp == null) return;

		officeData.Exp.Value += exp;

		UseEmployeeUI(() =>
		{
			if (EmployeeUI != null)
				EmployeeUI.ShowExp(exp);
		});
	}

	public void SetActivityTime(DateTime time)
	{
		ActivityStartTime = time;
	}

	private void CheckCritical()
	{
		if (!bEnableCritical) return;
		if (DateTime.UtcNow >= CriticalEndTime)
		{
			EndCritical();
		}
	}

	private void EndCritical()
	{
		bEnableCritical = false;
		StopEffectBurning();
	}

	private void PlayEffectBurning()
	{
		if (OnEffectBurning != null && CharRoot != null)
		{
			var args = new PoolingCharacterEffect.BurningArgs(CharRoot, bEnableCritical, CurMood);
			OnEffectBurning.OnNext(args);
		}
	}

	private void StopEffectBurning()
	{
		if (OnEffectBurning != null && CharRoot != null)
		{
			var args = new PoolingCharacterEffect.BurningArgs(null, false, EmployeeMoodSystem.Mood.Bad);
			OnEffectBurning.OnNext(args);
		}
	}

	private void UpdateCurCompanyExp()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.CompanySystem == null) return;

		int exp = gameRoot.CompanySystem.CalcCompanyExp(OfficeIdx);
		if (exp > 0)
		{
			GetExp(exp);
		}
	}

	public void UpdateEmployeeItem(int itemIdx = -1, int itemLevel = -1)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var curMode = gameRoot.UserData.CurMode;
		if (curMode == null || curMode.StageData == null) return;
		if (curMode.StageData.Offices == null) return;
		if (!curMode.StageData.Offices.TryGetValue(OfficeIdx, out var officeData)) return;
		if (officeData == null || officeData.Items == null) return;

		if (itemIdx >= 0 && itemLevel >= 0)
		{
			for (int i = 0; i < officeData.Items.Count; i++)
			{
				if (officeData.Items[i] != null && officeData.Items[i].Idx == itemIdx)
				{
					if (officeData.Items[i].LevelProperty != null)
						officeData.Items[i].LevelProperty.Value = itemLevel;
					break;
				}
			}
		}

		if (gameRoot.MoodSystem != null)
		{
			gameRoot.MoodSystem.UpdateMood(OfficeIdx, SeatIdx);
		}
	}

	protected override void Update()
	{
		base.Update();

		deltaTime = Time.deltaTime;
		realtime_dtime = Time.unscaledDeltaTime;

		if (state == E_State.Work)
		{
			// Check critical boost timer
			if (bEnableCritical)
			{
				CheckCritical();
			}

			// Work animation cycling
			if (InWorkAni)
			{
				WorkAniDeltaTime += deltaTime;
				if (WorkAniDeltaTime >= WorkAniDuration)
				{
					WorkAniDeltaTime = 0f;
					InWorkAni = false;
					WorkAniCount++;
					if (WorkAnis != null && WorkAnis.Count > 0)
					{
						int idx = WorkAniCount % WorkAnis.Count;
						if (CharAni != null)
						{
							CharAni.SetTrigger(WorkAnis[idx]);
						}
						InWorkAni = true;
					}
				}
			}
		}
		else if (state == E_State.WaitLine)
		{
			// Update wait line position
			if (WaitLine != null)
			{
				WaitlineDeltaTime += deltaTime;
				Vector3 pos = WaitLine.GetPathByTime(WaitlineDeltaTime);
				transform.position = pos;
			}
		}
		else if (state == E_State.InWaitingRoom)
		{
			// Update activity use time
			if (AcitivtyUseTime > 0f)
			{
				AcitivtyUseTime -= deltaTime;
				if (AcitivtyUseTime <= 0f)
				{
					AcitivtyUseTime = 0f;
					EndUseWaitingItem?.Invoke();
				}
			}
		}

		UpdateFloor();
	}

	private void OnDestroy()
	{
		if (disposable != null) disposable.Dispose();
		if (moodDisposables != null) moodDisposables.Dispose();
		if (poolingDisposables != null) poolingDisposables.Dispose();
		if (loadCharDisposables != null) loadCharDisposables.Dispose();
	}

	private void OnDisable()
	{
		StopEffectBurning();
	}
}
