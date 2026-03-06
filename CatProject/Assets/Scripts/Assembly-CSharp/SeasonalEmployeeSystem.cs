using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SeasonalDef;
using Treeplla;
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
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public _003CWaitAndPlayRestaurantActivity_003Ed__36(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
				case 0:
					_003C_003E1__state = -1;
					if (employee == null)
						return false;
					// Wait a short random delay before starting the restaurant activity
					_003C_003E2__current = new WaitForSeconds(UnityEngine.Random.Range(0.5f, 2.0f));
					_003C_003E1__state = 1;
					return true;
				case 1:
					_003C_003E1__state = -1;
					_003C_003E4__this.PlayRestaurantActivity(employee);
					return false;
				default:
					return false;
			}
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
		InitEmployeeDataList = new List<InitEmployeeData>();
		EmployeeMap = new Dictionary<int, List<WorkshopEmployee>>();
		Disposables = new CompositeDisposable();
		NowActivityStatus = E_DayActivityStatus.None;
		ActivityStartEmployeeCnt = 0;
		AsyncLoadEmployeeCnt = 0;
		IsInitSystem = true;
		SubscribeEvent();
	}

	public void Reset()
	{
		if (EmployeeMap != null)
			EmployeeMap.Clear();
		if (InitEmployeeDataList != null)
			InitEmployeeDataList.Clear();
		if (Disposables != null)
			Disposables.Clear();
		NowActivityStatus = E_DayActivityStatus.None;
		IsInitSystem = false;
	}

	public void OnStartGame()
	{
		InitStageEmployee();
	}

	private void InitStageEmployee()
	{
		var stageData = SeasonalHelper.SeasonalStageData;
		if (stageData == null || stageData.WorkerDataMap == null)
			return;

		var buildingDataMap = SeasonalHelper.SeasonalBuildingData;
		if (buildingDataMap == null)
			return;

		foreach (var kvp in stageData.WorkerDataMap)
		{
			var workerData = kvp.Value;
			if (!workerData.bActiveWorker)
				continue;

			int assignedBuildingIdx = 0;
			if (workerData.AssignedBuildingIdx != null)
				assignedBuildingIdx = workerData.AssignedBuildingIdx.Value;

			if (assignedBuildingIdx <= 0)
				continue;

			if (!buildingDataMap.TryGetValue(assignedBuildingIdx, out var buildingData))
				continue;

			if (buildingData.IsOpen == null || !buildingData.IsOpen.Value)
				continue;

			int workerIdx = kvp.Key;
			int spawnIndex = workerData.AssignedBuildingTransformIdx;
			SpawnNewWorker(workerIdx, spawnIndex, true, null);
		}
	}

	private void SubscribeEvent()
	{
		var stageData = SeasonalHelper.SeasonalStageData;
		if (stageData == null)
			return;

		if (stageData.OnChangedAnyWorkerMoodState != null)
		{
			stageData.OnChangedAnyWorkerMoodState
				.Subscribe(_ => UpdateEmployeeAutoActiveMoodFlag())
				.AddTo(Disposables);
		}
	}

	private void SpawnNewWorker(int workerIdx, int spawnIndex, bool bGameInitSpawn, UnityAction<WorkshopEmployee> onSpawnEnd)
	{
		var inGameSeasonal = SeasonalHelper.InGameSeasonalMode;
		if (inGameSeasonal == null)
			return;

		AsyncLoadEmployeeCnt++;

		inGameSeasonal.LoadWorkshopEmployee((WorkshopEmployee spawnedEmployee) =>
		{
			AsyncLoadEmployeeCnt--;

			if (spawnedEmployee == null)
				return;

			OnCompeteSpawnEmployee(spawnedEmployee, workerIdx, spawnIndex, bGameInitSpawn);
			onSpawnEnd?.Invoke(spawnedEmployee);
		});
	}

	public void ReqHireEmployee(SeasonalWorkerData workerData, int hiredBuildingIdx, int hireIndex)
	{
		if (workerData == null)
			return;

		if (workerData.AssignedBuildingIdx != null)
			workerData.AssignedBuildingIdx.Value = hiredBuildingIdx;
		workerData.AssignedBuildingTransformIdx = hireIndex;

		var buildingDataMap = SeasonalHelper.SeasonalBuildingData;
		if (buildingDataMap != null && buildingDataMap.TryGetValue(hiredBuildingIdx, out var buildingData))
		{
			int prevCount = buildingData.GetBuildingWorkerCount();
			if (buildingData.WorkerData != null && buildingData.WorkerData.HiredWorkerCount != null)
			{
				buildingData.WorkerData.HiredWorkerCount.Value = prevCount + 1;
			}
			OnChangedBuildingWorkerCount(hiredBuildingIdx, prevCount, prevCount + 1);
		}

		var stageData = SeasonalHelper.SeasonalStageData;
		if (stageData != null)
			stageData.UpdateWorkerCount();

		int workerIdx = SeasonalHelper.MakeWorkerIdx(hiredBuildingIdx, hireIndex);
		SpawnNewWorker(workerIdx, hireIndex, false, null);
	}

	public void ReqFireEmployee(SeasonalWorkerData workerData, int fireBuildingIdx, int fireIndex)
	{
		if (workerData == null)
			return;

		int workerIdx = SeasonalHelper.MakeWorkerIdx(fireBuildingIdx, fireIndex);

		if (EmployeeMap != null && EmployeeMap.TryGetValue(fireBuildingIdx, out var employeeList))
		{
			for (int i = employeeList.Count - 1; i >= 0; i--)
			{
				if (employeeList[i] != null && employeeList[i].WorkerIdx == workerIdx)
				{
					var employee = employeeList[i];
					employee.ResetActivity();
					employee.SetVisibility(false);
					GameObject.Destroy(employee.gameObject);
					employeeList.RemoveAt(i);
					break;
				}
			}
		}

		if (workerData.AssignedBuildingIdx != null)
			workerData.AssignedBuildingIdx.Value = 0;
		workerData.AssignedBuildingTransformIdx = 0;

		var buildingDataMap = SeasonalHelper.SeasonalBuildingData;
		if (buildingDataMap != null && buildingDataMap.TryGetValue(fireBuildingIdx, out var buildingData))
		{
			int prevCount = buildingData.GetBuildingWorkerCount();
			if (buildingData.WorkerData != null && buildingData.WorkerData.HiredWorkerCount != null)
			{
				int newCount = Mathf.Max(0, prevCount - 1);
				buildingData.WorkerData.HiredWorkerCount.Value = newCount;
				OnChangedBuildingWorkerCount(fireBuildingIdx, prevCount, newCount);
			}
		}

		var stageData = SeasonalHelper.SeasonalStageData;
		if (stageData != null)
			stageData.UpdateWorkerCount();
	}

	private void OnCompeteSpawnEmployee(WorkshopEmployee spawnedEmployee, int workerIdx, int spawnIndex, bool bGameInitSpawn)
	{
		if (spawnedEmployee == null)
			return;

		var stageData = SeasonalHelper.SeasonalStageData;
		if (stageData == null || stageData.WorkerDataMap == null)
			return;

		int buildingIdx = 0;
		int buildingTransformIdx = spawnIndex;

		if (stageData.WorkerDataMap.TryGetValue(workerIdx, out var workerData))
		{
			if (workerData.AssignedBuildingIdx != null)
				buildingIdx = workerData.AssignedBuildingIdx.Value;
			buildingTransformIdx = workerData.AssignedBuildingTransformIdx;
		}

		spawnedEmployee.Init(workerIdx, buildingIdx, buildingTransformIdx);

		var inGameStage = SeasonalHelper.InGameSeasonalStage;
		if (inGameStage != null && buildingIdx > 0)
		{
			Transform spawnTr = inGameStage.FindWorkshopEmployeeTransform(buildingIdx, buildingTransformIdx);
			if (spawnTr != null)
			{
				spawnedEmployee.transform.position = spawnTr.position;
			}
		}

		if (!EmployeeMap.ContainsKey(buildingIdx))
			EmployeeMap[buildingIdx] = new List<WorkshopEmployee>();
		EmployeeMap[buildingIdx].Add(spawnedEmployee);

		if (bGameInitSpawn)
		{
			switch (NowActivityStatus)
			{
				case E_DayActivityStatus.Work:
					spawnedEmployee.ChangeState(E_EmployeeState.Work);
					break;
				case E_DayActivityStatus.WorkOff:
					spawnedEmployee.ChangeState(E_EmployeeState.WorkOff);
					break;
				case E_DayActivityStatus.GoToMeal:
				case E_DayActivityStatus.Meal:
					if (IsUseRestaurantEmployee(spawnedEmployee))
						spawnedEmployee.ChangeState(E_EmployeeState.Restaurant);
					else
						spawnedEmployee.ChangeState(E_EmployeeState.WorkOff);
					break;
				default:
					spawnedEmployee.ChangeState(E_EmployeeState.Idle);
					break;
			}
		}
		else
		{
			// Newly hired employee starts working if it's work time
			if (NowActivityStatus == E_DayActivityStatus.Work)
				spawnedEmployee.ChangeState(E_EmployeeState.Work);
			else
				spawnedEmployee.ChangeState(E_EmployeeState.Idle);
		}
	}

	private void OnChangedBuildingWorkerCount(int buildingIdx, int prevWorkerCnt, int curWorkerCnt)
	{
		var buildingDataMap = SeasonalHelper.SeasonalBuildingData;
		if (buildingDataMap == null)
			return;

		if (!buildingDataMap.TryGetValue(buildingIdx, out var buildingData))
			return;

		if (buildingData.WorkerData != null && buildingData.WorkerData.ActiveWorkerCount != null)
		{
			buildingData.WorkerData.ActiveWorkerCount.Value = curWorkerCnt;
		}
	}

	public void OnChangeDayActivityState(E_DayActivityStatus newActivityStatus)
	{
		if (NowActivityStatus == newActivityStatus) return;
		NowActivityStatus = newActivityStatus;
		switch (newActivityStatus)
		{
			case E_DayActivityStatus.Work:
				AllEmployeeWorkOn(false);
				break;
			case E_DayActivityStatus.WorkOff:
				AllEmployeeWorkOff(false);
				break;
			case E_DayActivityStatus.GoToMeal:
				AllEmployeeGotoRestaurant(false);
				break;
		}
	}

	private void UpdateEmployeeAutoActiveMoodFlag()
	{
		var stageData = SeasonalHelper.SeasonalStageData;
		if (stageData == null || stageData.WorkerDataMap == null)
			return;

		if (EmployeeMap == null)
			return;

		foreach (var kvp in EmployeeMap)
		{
			for (int i = 0; i < kvp.Value.Count; i++)
			{
				var employee = kvp.Value[i];
				if (employee == null)
					continue;

				int workerIdx = employee.WorkerIdx;
				if (stageData.WorkerDataMap.TryGetValue(workerIdx, out var workerData))
				{
					bool isBadMood = workerData.MoodState != null &&
						workerData.MoodState.Value == E_EmployeeMoodState.Bad;
					employee.AutoActiveEmployeeUI = isBadMood;
					employee.SetShowMoodNotice(isBadMood);
				}
			}
		}
	}

	private void AllEmployeeWorkOn(bool bForceUpdate)
	{
		if (EmployeeMap == null) return;
		foreach (var kvp in EmployeeMap)
		{
			for (int i = 0; i < kvp.Value.Count; i++)
			{
				if (kvp.Value[i] != null)
					kvp.Value[i].ChangeState(E_EmployeeState.Work);
			}
		}
	}

	private void AllEmployeeWorkOff(bool bForceUpdate)
	{
		if (EmployeeMap == null) return;
		foreach (var kvp in EmployeeMap)
		{
			for (int i = 0; i < kvp.Value.Count; i++)
			{
				if (kvp.Value[i] != null)
					kvp.Value[i].ChangeState(E_EmployeeState.WorkOff);
			}
		}
		OnEndAllEmployeeWorkOff?.Invoke();
	}

	private void AllEmployeeGotoRestaurant(bool bForceUpdate)
	{
		if (EmployeeMap == null) return;
		foreach (var kvp in EmployeeMap)
		{
			for (int i = 0; i < kvp.Value.Count; i++)
			{
				if (kvp.Value[i] != null && IsUseRestaurantEmployee(kvp.Value[i]))
					kvp.Value[i].ChangeState(E_EmployeeState.Restaurant);
			}
		}
	}

	private void AllUnHiredEmployeeWorkOff(bool bForceUpdate)
	{
		if (EmployeeMap == null) return;
		foreach (var kvp in EmployeeMap)
		{
			for (int i = 0; i < kvp.Value.Count; i++)
			{
				if (kvp.Value[i] != null && kvp.Value[i].BuildingIdx <= 0)
					kvp.Value[i].ChangeState(E_EmployeeState.WorkOff);
			}
		}
	}

	private void OnArriveRestaurant(WorkshopEmployee employee)
	{
		if (employee == null)
			return;

		var inGameSeasonal = SeasonalHelper.InGameSeasonalMode;
		if (inGameSeasonal != null)
		{
			inGameSeasonal.StartCoroutine(WaitAndPlayRestaurantActivity(employee));
		}
	}

	[IteratorStateMachine(typeof(_003CWaitAndPlayRestaurantActivity_003Ed__36))]
	private IEnumerator WaitAndPlayRestaurantActivity(WorkshopEmployee employee)
	{
		if (employee == null)
			yield break;

		yield return new WaitForSeconds(UnityEngine.Random.Range(0.5f, 2.0f));

		PlayRestaurantActivity(employee);
	}

	private void PlayRestaurantActivity(WorkshopEmployee employee)
	{
		if (employee == null)
			return;

		var inGameStage = SeasonalHelper.InGameSeasonalStage;
		if (inGameStage == null)
			return;

		int buildingIdx = employee.BuildingIdx;
		int transformIdx = employee.BuildingTransformIdx;

		Transform restaurantTr = inGameStage.FindRestaurantEmployeeTransform(buildingIdx, transformIdx);

		BuildingFacilityInteractiveItem interactiveItem = null;
		BuildingBase restaurantBuilding = inGameStage.FindBuilding(E_BuildingType.Restaurant, 0);
		if (restaurantBuilding != null)
		{
			var restaurant = restaurantBuilding as Restaurant;
			if (restaurant != null && restaurant.InteractiveItemList != null)
			{
				// Pick an interactive item based on activity count
				int itemIndex = ActivityStartEmployeeCnt % restaurant.InteractiveItemList.Count;
				if (itemIndex >= 0 && itemIndex < restaurant.InteractiveItemList.Count)
					interactiveItem = restaurant.InteractiveItemList[itemIndex];
			}
		}

		var activityData = WorkshopEmployee.EmployeeActivityData.MakeRestaurantState(
			restaurantTr,
			EMPLOYEE_RESTAURANT_USE_TIME_SEC,
			interactiveItem);
		activityData.ActivityEndCallback = OnEndEmployeeActivity;

		employee.SetActivity(activityData);
		ActivityStartEmployeeCnt++;

		if (ActivityStartEmployeeCnt <= RESTAURANT_SPEECH_BUBBLE_MAX_COUNT)
		{
			employee.SetShowMealNotice(true);
		}
	}

	private void OnEndEmployeeActivity(WorkshopEmployee employee)
	{
		if (employee == null)
			return;

		employee.SetShowMealNotice(false);

		switch (NowActivityStatus)
		{
			case E_DayActivityStatus.Work:
				employee.ChangeState(E_EmployeeState.Work);
				break;
			case E_DayActivityStatus.WorkOff:
				employee.ChangeState(E_EmployeeState.WorkOff);
				break;
			default:
				employee.ChangeState(E_EmployeeState.Idle);
				break;
		}

		var stageData = SeasonalHelper.SeasonalStageData;
		if (stageData != null && stageData.WorkerDataMap != null)
		{
			if (stageData.WorkerDataMap.TryGetValue(employee.WorkerIdx, out var workerData))
			{
				workerData.LastRestaurantUseTime = DateTime.UtcNow;
			}
		}
	}

	private bool IsUseRestaurantEmployee(WorkshopEmployee employee)
	{
		if (employee == null) return false;
		return employee.BuildingIdx > 0;
	}

	private int GetWorkAnimIndex(int buildingIdx)
	{
		return buildingIdx % 3;
	}

	private Queue<InGameAstar.Node> MakeMovePathQueue(Vector3 startPos, Vector3 endPos)
	{
		var pathQueue = new Queue<InGameAstar.Node>();

		var inGameStage = SeasonalHelper.InGameSeasonalStage;
		if (inGameStage == null)
			return pathQueue;

		var astar = inGameStage.GetStageAstar();
		if (astar == null)
			return pathQueue;

		var pathNodes = astar.FindPath(startPos, endPos);
		if (pathNodes == null || pathNodes.Count == 0)
			return pathQueue;

		for (int i = 0; i < pathNodes.Count; i++)
		{
			pathQueue.Enqueue(pathNodes[i]);
		}

		return pathQueue;
	}
}
