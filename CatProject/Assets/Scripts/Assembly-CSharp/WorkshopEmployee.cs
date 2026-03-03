using System;
using System.Collections.Generic;
using SeasonalDef;
using UnityEngine;
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
		}

		public static EmployeeActivityData MakeMoveState(Queue<InGameAstar.Node> moveNodeList, int interactionItemIdx, float moveDelayTime, UnityAction<WorkshopEmployee> moveEndCallback)
		{
			return null;
		}

		public static EmployeeActivityData MakeWorkState(int workAnimIndex, Transform focusTr)
		{
			return null;
		}

		public static EmployeeActivityData MakeWorkOffState(Transform focusTr)
		{
			return null;
		}

		public static EmployeeActivityData MakeRestaurantState(Transform focusTr, float activityTime, BuildingFacilityInteractiveItem interactiveItem)
		{
			return null;
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
	}

	public void Init(int workerIdx, int buildingIdx, int transformIdx)
	{
	}

	public void ChangeAssignBuilding(int buildingIdx, int buildingTransformIdx)
	{
	}

	public void ResetActivity()
	{
	}

	public void SetActivity(EmployeeActivityData activityData)
	{
	}

	public void SetActivity(Queue<EmployeeActivityData> activityQueue)
	{
	}

	public void SetShowMoodNotice(bool bShow)
	{
	}

	public void SetShowMealNotice(bool bShow)
	{
	}

	public void SetVisibility(bool isVisible)
	{
	}

	private void PlayNextActivity()
	{
	}

	public void ChangeState(E_EmployeeState newState)
	{
	}

	private void LoadResource(int prefabIdx, Action onLoadCb)
	{
	}

	private void Update()
	{
	}

	protected void SetAni(E_EmployeeState state, E_Direction dir)
	{
	}

	protected E_Direction GetFocusDir(Transform trans)
	{
		return default(E_Direction);
	}

	protected E_Direction GetDir(Vector2 curPos, Vector2 nextPos)
	{
		return default(E_Direction);
	}

	private void SetActiveEmployeeUI(bool bActive)
	{
	}

	private void SetActiveProgressUI(bool bActive)
	{
	}

	private bool IsActiveWork(int buildingIdx, int buildingTransformIdx)
	{
		return false;
	}

	private bool IsActiveWork(SeasonalWorkshopData workshopData, int buildingTransformIdx)
	{
		return false;
	}

	protected void LoadProductionProgressUI()
	{
	}

	protected void LoadEmployeeUI()
	{
	}
}
