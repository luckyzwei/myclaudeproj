using System;
using System.Collections.Generic;
using SeasonalDef;
using Treeplla;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;

public class WorkshopEmployee : MonoBehaviour
{
	protected enum E_Direction
	{
		None = 0,
		Front_Left = 1,
		Front_Right = 2,
		Front = 3,
		Back_Left = 4,
		Back_Right = 5,
		Back = 6
	}

	public class EmployeeActivityData
	{
		public E_EmployeeState EmployeeState;

		public int WorkTypeIndex;

		public int InteractionItemIdx;

		public Transform FocusTransform;

		public Queue<InGameAstar.Node> MoveNodeList;

		public float MoveTime;

		public InGameAstar.Node MoveNextNode;

		public float WaitTimeSec;

		public float WaitElapsedTime;

		public UnityAction<WorkshopEmployee> ActivityEndCallback;

		public WeakReference<BuildingFacilityInteractiveItem> InteractiveItem;

		public DateTime WaitEndTime;

		public void Reset()
		{
			EmployeeState = E_EmployeeState.None;
			WorkTypeIndex = 0;
			InteractionItemIdx = 0;
			FocusTransform = null;
			MoveNodeList = null;
			MoveTime = 0f;
			MoveNextNode = null;
			WaitTimeSec = 0f;
			WaitElapsedTime = 0f;
			ActivityEndCallback = null;
			InteractiveItem = null;
			WaitEndTime = DateTime.MinValue;
		}

		public static EmployeeActivityData MakeMoveState(Queue<InGameAstar.Node> moveNodeList, int interactionItemIdx, float moveDelayTime, UnityAction<WorkshopEmployee> moveEndCallback)
		{
			var data = new EmployeeActivityData();
			data.EmployeeState = E_EmployeeState.Move;
			data.MoveNodeList = moveNodeList;
			data.InteractionItemIdx = interactionItemIdx;
			data.MoveTime = moveDelayTime;
			data.MoveNextNode = null;
			data.ActivityEndCallback = moveEndCallback;
			return data;
		}

		public static EmployeeActivityData MakeWorkState(int workAnimIndex, Transform focusTr)
		{
			var data = new EmployeeActivityData();
			data.EmployeeState = E_EmployeeState.Work;
			data.WorkTypeIndex = workAnimIndex;
			data.FocusTransform = focusTr;
			return data;
		}

		public static EmployeeActivityData MakeWorkOffState(Transform focusTr)
		{
			var data = new EmployeeActivityData();
			data.EmployeeState = E_EmployeeState.WorkOff;
			data.FocusTransform = focusTr;
			return data;
		}

		public static EmployeeActivityData MakeRestaurantState(Transform focusTr, float activityTime, BuildingFacilityInteractiveItem interactiveItem)
		{
			var data = new EmployeeActivityData();
			data.EmployeeState = E_EmployeeState.Restaurant;
			data.FocusTransform = focusTr;
			data.WaitTimeSec = activityTime;
			data.WaitElapsedTime = 0f;
			if (interactiveItem != null)
				data.InteractiveItem = new WeakReference<BuildingFacilityInteractiveItem>(interactiveItem);
			return data;
		}
	}

	[SerializeField]
	public Transform ProgressTrans;

	[SerializeField]
	private Transform CharRoot;

	private E_Direction FocusDirection;

	private Animator CharAnimator;

	private InGameSeasonalProgress WorkProgress;

	private InGameSeasonalEmployeeUI EmployeeUI;

	public EmployeeActivityData ActivityData;

	public Queue<EmployeeActivityData> ActivityQueue;

	private int SeasonResourceIdx;

	public E_EmployeeState EmployeeActivityState;

	public int InteractionItemIdx;

	public bool WaitActivate;

	public bool AutoActiveEmployeeUI;

	private float WalkSpeed;

	private bool CachedActiveWork;

	private bool bActiveProgressUI;

	private bool bActiveEmployeeUI;

	private string WorkAnimName_FormatStr;

	private string LastAniName;

	public int WorkerIdx { get; private set; }

	public int BuildingIdx { get; private set; }

	public int BuildingTransformIdx { get; private set; }

	public E_EmployeeState EmployeeState { get; private set; }

	private WorkshopEmployee()
	{
		ActivityQueue = new Queue<EmployeeActivityData>();
		WalkSpeed = 2f;
		WaitActivate = false;
		AutoActiveEmployeeUI = false;
		CachedActiveWork = false;
		bActiveProgressUI = false;
		bActiveEmployeeUI = false;
	}

	public void Init(int workerIdx, int buildingIdx, int transformIdx)
	{
		WorkerIdx = workerIdx;
		BuildingIdx = buildingIdx;
		BuildingTransformIdx = transformIdx;
		EmployeeState = E_EmployeeState.None;
		EmployeeActivityState = E_EmployeeState.None;
		ActivityData = null;
		if (ActivityQueue == null)
			ActivityQueue = new Queue<EmployeeActivityData>();
		else
			ActivityQueue.Clear();

		var stageData = SeasonalHelper.SeasonalStageData;
		if (stageData != null)
			SeasonResourceIdx = stageData.SeasonResourceIdx;

		WorkAnimName_FormatStr = "Work_{0}";
		CachedActiveWork = IsActiveWork(buildingIdx, transformIdx);

		LoadProductionProgressUI();
		LoadEmployeeUI();
	}

	public void ChangeAssignBuilding(int buildingIdx, int buildingTransformIdx)
	{
		BuildingIdx = buildingIdx;
		BuildingTransformIdx = buildingTransformIdx;
		CachedActiveWork = IsActiveWork(buildingIdx, buildingTransformIdx);
	}

	public void ResetActivity()
	{
		if (ActivityData != null)
		{
			// Release interactive item if any
			if (ActivityData.InteractiveItem != null &&
				ActivityData.InteractiveItem.TryGetTarget(out var item))
			{
				item.SetOnOff(false);
			}
			ActivityData.Reset();
			ActivityData = null;
		}
		if (ActivityQueue != null)
			ActivityQueue.Clear();

		EmployeeActivityState = E_EmployeeState.None;
		InteractionItemIdx = 0;
	}

	public void SetActivity(EmployeeActivityData activityData)
	{
		ResetActivity();
		ActivityData = activityData;
		if (activityData != null)
		{
			ChangeState(activityData.EmployeeState);
		}
	}

	public void SetActivity(Queue<EmployeeActivityData> activityQueue)
	{
		ResetActivity();
		if (activityQueue == null || activityQueue.Count == 0)
			return;

		ActivityQueue = activityQueue;
		PlayNextActivity();
	}

	public void SetShowMoodNotice(bool bShow)
	{
		if (EmployeeUI != null)
		{
			if (bShow)
				EmployeeUI.ShowMoodNotice();
			else
				EmployeeUI.Hide();
		}
	}

	public void SetShowMealNotice(bool bShow)
	{
		if (EmployeeUI != null)
		{
			if (bShow)
				EmployeeUI.ShowMealNotice();
			else
				EmployeeUI.Hide();
		}
	}

	public void SetVisibility(bool isVisible)
	{
		if (CharRoot != null)
			CharRoot.gameObject.SetActive(isVisible);
	}

	private void PlayNextActivity()
	{
		if (ActivityQueue == null || ActivityQueue.Count == 0)
		{
			// All activities done, go idle
			ChangeState(E_EmployeeState.Idle);
			return;
		}

		ActivityData = ActivityQueue.Dequeue();
		if (ActivityData != null)
		{
			ChangeState(ActivityData.EmployeeState);
		}
	}

	public void ChangeState(E_EmployeeState newState)
	{
		if (EmployeeState == newState && newState != E_EmployeeState.None)
			return;

		EmployeeState = newState;
		EmployeeActivityState = newState;

		switch (newState)
		{
			case E_EmployeeState.None:
			case E_EmployeeState.Idle:
			{
				E_Direction dir = E_Direction.Front;
				if (ActivityData != null && ActivityData.FocusTransform != null)
					dir = GetFocusDir(ActivityData.FocusTransform);
				SetAni(E_EmployeeState.Idle, dir);
				SetActiveProgressUI(false);
				break;
			}
			case E_EmployeeState.Move:
			{
				if (ActivityData != null && ActivityData.MoveNodeList != null && ActivityData.MoveNodeList.Count > 0)
				{
					ActivityData.MoveNextNode = ActivityData.MoveNodeList.Dequeue();
					InteractionItemIdx = ActivityData.InteractionItemIdx;
				}
				SetActiveProgressUI(false);
				break;
			}
			case E_EmployeeState.Work:
			{
				E_Direction dir = E_Direction.Front;
				if (ActivityData != null && ActivityData.FocusTransform != null)
					dir = GetFocusDir(ActivityData.FocusTransform);
				FocusDirection = dir;

				bool isActive = IsActiveWork(BuildingIdx, BuildingTransformIdx);
				CachedActiveWork = isActive;

				if (isActive)
				{
					SetAni(E_EmployeeState.Work, dir);
					SetActiveProgressUI(true);
				}
				else
				{
					SetAni(E_EmployeeState.Idle, dir);
					SetActiveProgressUI(false);
				}
				break;
			}
			case E_EmployeeState.WorkOff:
			{
				E_Direction dir = E_Direction.Front;
				if (ActivityData != null && ActivityData.FocusTransform != null)
					dir = GetFocusDir(ActivityData.FocusTransform);
				SetAni(E_EmployeeState.WorkOff, dir);
				SetActiveProgressUI(false);
				break;
			}
			case E_EmployeeState.Restaurant:
			{
				E_Direction dir = E_Direction.Front;
				if (ActivityData != null && ActivityData.FocusTransform != null)
					dir = GetFocusDir(ActivityData.FocusTransform);
				SetAni(E_EmployeeState.Restaurant, dir);
				SetActiveProgressUI(false);

				if (ActivityData != null)
				{
					ActivityData.WaitElapsedTime = 0f;
					ActivityData.WaitEndTime = DateTime.UtcNow.AddSeconds(ActivityData.WaitTimeSec);

					if (ActivityData.InteractiveItem != null &&
						ActivityData.InteractiveItem.TryGetTarget(out var item))
					{
						item.SetOnOff(true);
					}
				}
				break;
			}
		}
	}

	private void LoadResource(int prefabIdx, Action onLoadCb)
	{
		string key = string.Format("Character/Seasonal/{0}/Employee_{1}", SeasonResourceIdx, prefabIdx);
		Addressables.InstantiateAsync(key, CharRoot).Completed += (handle) =>
		{
			if (handle.Status == UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationStatus.Succeeded && handle.Result != null)
			{
				CharAnimator = handle.Result.GetComponent<Animator>();
			}
			onLoadCb?.Invoke();
		};
	}

	private void Update()
	{
		if (EmployeeState == E_EmployeeState.None)
			return;

		switch (EmployeeState)
		{
			case E_EmployeeState.Move:
				UpdateMove();
				break;
			case E_EmployeeState.Work:
				UpdateWork();
				break;
			case E_EmployeeState.Restaurant:
				UpdateRestaurant();
				break;
		}
	}

	private void UpdateMove()
	{
		if (ActivityData == null)
			return;

		if (ActivityData.MoveNextNode == null)
		{
			// Movement complete
			var callback = ActivityData.ActivityEndCallback;
			if (ActivityQueue != null && ActivityQueue.Count > 0)
			{
				PlayNextActivity();
			}
			else
			{
				ChangeState(E_EmployeeState.Idle);
			}
			callback?.Invoke(this);
			return;
		}

		Vector3 targetPos = ActivityData.MoveNextNode.WorldPos;
		Vector3 curPos = transform.position;

		// Calculate direction for animation
		E_Direction moveDir = GetDir(curPos, targetPos);
		SetAni(E_EmployeeState.Move, moveDir);

		// Move toward target
		float speed = WalkSpeed;
		if (ActivityData.MoveTime > 0f)
			speed = ActivityData.MoveTime;

		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(curPos, targetPos, step);

		// Check if reached target node
		if (Vector3.Distance(transform.position, targetPos) < 0.01f)
		{
			transform.position = targetPos;

			if (ActivityData.MoveNodeList != null && ActivityData.MoveNodeList.Count > 0)
			{
				ActivityData.MoveNextNode = ActivityData.MoveNodeList.Dequeue();
			}
			else
			{
				ActivityData.MoveNextNode = null;
			}
		}
	}

	private void UpdateWork()
	{
		// Check if workshop became active/inactive
		bool isActive = IsActiveWork(BuildingIdx, BuildingTransformIdx);
		if (isActive != CachedActiveWork)
		{
			CachedActiveWork = isActive;
			if (isActive)
			{
				SetAni(E_EmployeeState.Work, FocusDirection);
				SetActiveProgressUI(true);
			}
			else
			{
				SetAni(E_EmployeeState.Idle, FocusDirection);
				SetActiveProgressUI(false);
			}
		}
	}

	private void UpdateRestaurant()
	{
		if (ActivityData == null)
			return;

		ActivityData.WaitElapsedTime += Time.deltaTime;

		if (ActivityData.WaitElapsedTime >= ActivityData.WaitTimeSec)
		{
			// Restaurant time done
			if (ActivityData.InteractiveItem != null &&
				ActivityData.InteractiveItem.TryGetTarget(out var item))
			{
				item.SetOnOff(false);
			}

			var callback = ActivityData.ActivityEndCallback;
			if (ActivityQueue != null && ActivityQueue.Count > 0)
			{
				PlayNextActivity();
			}
			else
			{
				ChangeState(E_EmployeeState.Idle);
			}
			callback?.Invoke(this);
		}
	}

	protected void SetAni(E_EmployeeState state, E_Direction dir)
	{
		if (CharAnimator == null)
			return;

		string aniName;
		switch (state)
		{
			case E_EmployeeState.Idle:
			case E_EmployeeState.None:
				aniName = "Idle_" + dir.ToString();
				break;
			case E_EmployeeState.Move:
				aniName = "Move_" + dir.ToString();
				break;
			case E_EmployeeState.Work:
				if (ActivityData != null && ActivityData.WorkTypeIndex > 0)
					aniName = string.Format(WorkAnimName_FormatStr, ActivityData.WorkTypeIndex) + "_" + dir.ToString();
				else
					aniName = "Work_" + dir.ToString();
				break;
			case E_EmployeeState.WorkOff:
				aniName = "Idle_" + dir.ToString();
				break;
			case E_EmployeeState.Restaurant:
				aniName = "Idle_" + dir.ToString();
				break;
			default:
				aniName = "Idle_" + dir.ToString();
				break;
		}

		if (aniName == LastAniName)
			return;

		LastAniName = aniName;
		CharAnimator.Play(aniName);
	}

	protected E_Direction GetFocusDir(Transform trans)
	{
		if (trans == null)
			return E_Direction.Front;

		return GetDir(transform.position, trans.position);
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

	private void SetActiveEmployeeUI(bool bActive)
	{
		if (bActiveEmployeeUI == bActive)
			return;

		bActiveEmployeeUI = bActive;
		if (EmployeeUI != null)
		{
			if (bActive)
				EmployeeUI.Show();
			else
				EmployeeUI.Hide();
		}
	}

	private void SetActiveProgressUI(bool bActive)
	{
		if (bActiveProgressUI == bActive)
			return;

		bActiveProgressUI = bActive;
		if (WorkProgress != null)
		{
			if (bActive)
				WorkProgress.Show();
			else
				WorkProgress.Hide();
		}
	}

	private bool IsActiveWork(int buildingIdx, int buildingTransformIdx)
	{
		var buildingDataMap = SeasonalHelper.SeasonalBuildingData;
		if (buildingDataMap == null)
			return false;

		if (!buildingDataMap.TryGetValue(buildingIdx, out var buildingData))
			return false;

		var workshopData = buildingData as SeasonalWorkshopData;
		if (workshopData == null)
			return false;

		return IsActiveWork(workshopData, buildingTransformIdx);
	}

	private bool IsActiveWork(SeasonalWorkshopData workshopData, int buildingTransformIdx)
	{
		if (workshopData == null)
			return false;

		if (!workshopData.IsWorkshopActive)
			return false;

		if (workshopData.WorkshopState == null)
			return false;

		return workshopData.WorkshopState.Value == E_WorkshopState.WorkOn;
	}

	protected void LoadProductionProgressUI()
	{
		if (WorkProgress != null)
			return;

		if (ProgressTrans == null)
			return;

		// Load floating UI via Addressables
		var inGameSeasonal = SeasonalHelper.InGameSeasonalMode;
		if (inGameSeasonal == null)
			return;

		// InGameSeasonalProgress is loaded as a floating UI attached to ProgressTrans
		var progressGo = ProgressTrans.GetComponentInChildren<InGameSeasonalProgress>();
		if (progressGo != null)
		{
			WorkProgress = progressGo;
			WorkProgress.Init(ProgressTrans);
			WorkProgress.Hide();
		}
	}

	protected void LoadEmployeeUI()
	{
		if (EmployeeUI != null)
			return;

		var employeeUIComp = GetComponentInChildren<InGameSeasonalEmployeeUI>();
		if (employeeUIComp != null)
		{
			EmployeeUI = employeeUIComp;
			EmployeeUI.SetAttachEmployee(this);
			EmployeeUI.Hide();
		}
	}
}
