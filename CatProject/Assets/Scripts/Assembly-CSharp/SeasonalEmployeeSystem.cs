using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SeasonalDef;
using UniRx;
using UnityEngine;
using UnityEngine.Events;

public class SeasonalEmployeeSystem
{
	private class InitEmployeeData
	{
		public WorkshopEmployee Employee;

		public int WorkerIdx;

		public int SpawnIndex;

		public bool bGameInitSpawn;

		public UnityAction<WorkshopEmployee> OnSpawnEnd;
	}

	[CompilerGenerated]
	private sealed class _003CWaitAndPlayRestaurantActivity_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SeasonalEmployeeSystem _003C_003E4__this;

		public WorkshopEmployee employee;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CWaitAndPlayRestaurantActivity_003Ed__36(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private readonly int MAX_WORKER_COUNT;

	private int EMPLOYEE_RESTAURANT_USE_TIME_SEC;

	private int RESTAURANT_SPEECH_BUBBLE_MAX_COUNT;

	private List<InitEmployeeData> InitEmployeeDataList;

	public Dictionary<int, List<WorkshopEmployee>> EmployeeMap;

	private E_DayActivityStatus NowActivityStatus;

	private int ActivityStartEmployeeCnt;

	public UnityAction OnEndAllEmployeeWorkOff;

	private CompositeDisposable Disposables;

	public bool IsInitSystem { get; private set; }

	public int AsyncLoadEmployeeCnt { get; private set; }

	public void Init()
	{
	}

	public void Reset()
	{
	}

	public void OnStartGame()
	{
	}

	private void InitStageEmployee()
	{
	}

	private void SubscribeEvent()
	{
	}

	private void SpawnNewWorker(int workerIdx, int spawnIndex, bool bGameInitSpawn, UnityAction<WorkshopEmployee> onSpawnEnd)
	{
	}

	public void ReqHireEmployee(SeasonalWorkerData workerData, int hiredBuildingIdx, int hireIndex)
	{
	}

	public void ReqFireEmployee(SeasonalWorkerData workerData, int fireBuildingIdx, int fireIndex)
	{
	}

	private void OnCompeteSpawnEmployee(WorkshopEmployee spawnedEmployee, int workerIdx, int spawnIndex, bool bGameInitSpawn)
	{
	}

	private void OnChangedBuildingWorkerCount(int buildingIdx, int prevWorkerCnt, int curWorkerCnt)
	{
	}

	public void OnChangeDayActivityState(E_DayActivityStatus newActivityStatus)
	{
	}

	private void UpdateEmployeeAutoActiveMoodFlag()
	{
	}

	private void AllEmployeeWorkOn(bool bForceUpdate)
	{
	}

	private void AllEmployeeWorkOff(bool bForceUpdate)
	{
	}

	private void AllEmployeeGotoRestaurant(bool bForceUpdate)
	{
	}

	private void AllUnHiredEmployeeWorkOff(bool bForceUpdate)
	{
	}

	private void OnArriveRestaurant(WorkshopEmployee employee)
	{
	}

	[IteratorStateMachine(typeof(_003CWaitAndPlayRestaurantActivity_003Ed__36))]
	private IEnumerator WaitAndPlayRestaurantActivity(WorkshopEmployee employee)
	{
		yield break;
	}

	private void PlayRestaurantActivity(WorkshopEmployee employee)
	{
	}

	private void OnEndEmployeeActivity(WorkshopEmployee employee)
	{
	}

	private bool IsUseRestaurantEmployee(WorkshopEmployee employee)
	{
		return false;
	}

	private int GetWorkAnimIndex(int buildingIdx)
	{
		return 0;
	}

	private Queue<InGameAstar.Node> MakeMovePathQueue(Vector3 startPos, Vector3 endPos)
	{
		return null;
	}
}
