using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Treeplla;
using UnityEngine;

public class InGameOfficeStage : MonoBehaviour
{
	[Serializable]
	private struct DayFilterInfo
	{
		public DaySystem.DayStatus status;

		public Color color;

		public int sortingOrder;
	}

	[Serializable]
	private class FloorInfo
	{
		public GameObject Root;

		public Transform ElevatorTrans;

		public InGameAstar Astar;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass52_0
	{
		public int curstage;

		public int managerUILoadCount;

		public int employeeLoadCount;

		public int employeeUILoadCount;

		public bool loadCeoComp;

		public bool loadSecretaryComp;

		public int engineerLoadCount;

		public int managerLoadCount;

		public InGameOfficeStage _003C_003E4__this;

		public bool adSupplyLoaded;

		public bool nightSkipLoaded;

		public int maxManagerDeskCount;

		public int[] employeeTotalCount;

		public int employeeUITotalCount;

		public int[] engineerTotalCount;

		public int[] managerTotalCount;

		public Action<InGameFindManagerUI> _003C_003E9__13;

		public Action<InGameManagerUI> _003C_003E9__14;

		internal bool _003CSet_003Eb__0(StageOfficeData x)
		{
			return false;
		}

		internal void _003CSet_003Eb__13(InGameFindManagerUI ui)
		{
		}

		internal void _003CSet_003Eb__14(InGameManagerUI ui)
		{
		}

		internal void _003CSet_003Eb__2()
		{
		}

		internal void _003CSet_003Eb__3()
		{
		}

		internal void _003CSet_003Eb__4()
		{
		}

		internal void _003CSet_003Eb__5()
		{
		}

		internal void _003CSet_003Eb__6()
		{
		}

		internal void _003CSet_003Eb__7(AdSupplyVIP vip)
		{
		}

		internal void _003CSet_003Eb__8(NightSkipVIP vip)
		{
		}

		internal void _003CSet_003Eb__9(InGameCompanyNameUI ui)
		{
		}

		internal void _003CSet_003Eb__10(InGameArrow ui)
		{
		}

		internal bool _003CSet_003Eb__12()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CFocusCeoCoroutine_003Ed__97 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InGameOfficeStage _003C_003E4__this;

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
		public _003CFocusCeoCoroutine_003Ed__97(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CSet_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InGameOfficeStage _003C_003E4__this;

		private _003C_003Ec__DisplayClass52_0 _003C_003E8__1;

		public Action compCb;

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
		public _003CSet_003Ed__52(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CUpdateSpecialTheme_003Ed__92 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InGameOfficeStage _003C_003E4__this;

		private bool _003CisSpecialTheme_003E5__2;

		private bool _003ChasAddEmployee_003E5__3;

		private bool _003CcurRegion_003E5__4;

		private Dictionary<int, RegionData>.Enumerator _003C_003E7__wrap4;

		private Dictionary<int, OfficeData>.Enumerator _003C_003E7__wrap5;

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
		public _003CUpdateSpecialTheme_003Ed__92(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		private void _003C_003Em__Finally2()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	private List<Transform> EnterPoints;

	[SerializeField]
	private List<OfficeRoom> Offices;

	[SerializeField]
	private List<RestRoom> RestRooms;

	[SerializeField]
	private List<MeetingRoom> MeetingRooms;

	[SerializeField]
	private TechnicalRoom TechnicalRoom;

	[SerializeField]
	private PowerRoom PowerRoom;

	[SerializeField]
	private CeoRoom CeoRoom;

	[SerializeField]
	private List<LoungeRoom> LoungeRooms;

	[SerializeField]
	private RecreationRoom RecreationRoom;

	[SerializeField]
	private GymRoom GymRoom;

	[SerializeField]
	private SleepingRoom SleepingRoom;

	[SerializeField]
	private RecreationRoom RestaurantRoom;

	[SerializeField]
	private GymRoom PhoneBoothRoom;

	[SerializeField]
	private List<LoungeRoom> SupplyRooms;

	[SerializeField]
	private LoungeRoom MusicRoom;

	[SerializeField]
	private LoungeRoom Cafeteria;

	[Space(20f)]
	[SerializeField]
	private OfficeBus Bus;

	[SerializeField]
	private Roulette Roulette;

	[SerializeField]
	private List<FloorInfo> Floors;

	[Header("Transform")]
	[SerializeField]
	private Transform EnterTrans;

	[SerializeField]
	private Transform ExitTrans;

	[SerializeField]
	private Transform NameTrans;

	[Header("Adsupply")]
	[SerializeField]
	private Transform VipEnterTrans;

	[SerializeField]
	private Transform VipEndTrans;

	[Header("NightSkip")]
	[SerializeField]
	private Transform NightSkipTrans;

	[SerializeField]
	private SpriteRenderer DayFilter;

	[SerializeField]
	private List<DayFilterInfo> DayFilterInfos;

	[SerializeField]
	private List<DaySystem.FarsightedObject> FarsightedObjs;

	private DaySystem.FarsightedObject SpecialDayFarsightedObjs;

	private DaySystem.DayStatus CurStatus;

	[Header("Input Value")]
	[SerializeField]
	private float camOrthographicSize;

	[SerializeField]
	private float cameraMinXPadding;

	[SerializeField]
	private float cameraMaxXPadding;

	[SerializeField]
	private float cameraMinYPadding;

	[SerializeField]
	private float cameraMaxYPadding;

	private InGameCompanyNameUI NameUI;

	private InGameArrow Arrow;

	public List<InGameAstar.Node> EnterNodes;

	[Header("SpecialDay")]
	[SerializeField]
	private Transform bgRoot;

	[SerializeField]
	private List<GameObject> OriginThemeObjs;

	private GameObject specialBG;

	private GameObject specialBGDeco;

	public int MaxFloor { get; private set; }

	public int CurFloor { get; private set; }

	[IteratorStateMachine(typeof(_003CSet_003Ed__52))]
	public IEnumerator Set(Action compCb)
	{
		yield break;
	}

	private void InitRooms(List<StageOfficeData> roomList)
	{
	}

	private void LoadCeoAsync(int order, Action CompCb)
	{
	}

	private void LoadSecretaryAsync(int order, Action CompCb)
	{
	}

	public InGameAstar GetAstar(int floor)
	{
		return null;
	}

	public Transform GetElavatorTrans(int floor)
	{
		return null;
	}

	public void DirectInit()
	{
	}

	private void InitFloor()
	{
	}

	public void FloorUp()
	{
	}

	public void FloorDown()
	{
	}

	public void GotoFloor(int floor = -1)
	{
	}

	private void UpdateCameraCullingMask()
	{
	}

	public void ShowArrow(Transform Trans)
	{
	}

	public void HideArrow()
	{
	}

	public void UpdateFarsightView()
	{
	}

	private void SubscribeDay()
	{
	}

	public void AllResetRepairingRoom()
	{
	}

	public void AllResetInUseRoom()
	{
	}

	private void UpdateFarsightedObjs(DaySystem.DayStatus status)
	{
	}

	public void StartWorkOnBus()
	{
	}

	public void WorkOffBusCountDownStart()
	{
	}

	public void ReturnBus()
	{
	}

	public void UpdateCompanyName()
	{
	}

	public void InitPlants()
	{
	}

	public void SetFocusPlant(int plantIdx = -1)
	{
	}

	public Sequence PlayFocusPlant(int plantIdx = -1, Action endCb = null)
	{
		return null;
	}

	public void OnClickPlantArea()
	{
	}

	public void OnClickEditCompanyName()
	{
	}

	public void CallEngineerToWorkon(Worker.E_AppearType appearType, Action loadCb, out int totalCount, int startorder = 0)
	{
		totalCount = default(int);
	}

	public void CallEmployeeToWorkOn(Worker.E_AppearType appearType, Action loadCb, out int totalCount)
	{
		totalCount = default(int);
	}

	public void CallEmployeeToWorkOff()
	{
	}

	public void CallManagerToWorkOn(Worker.E_AppearType appearType, Action loadCb, out int totalCount, int startorder = 0)
	{
		totalCount = default(int);
	}

	public void CallManagerToWorkOn(int officeIdx, Action loadCb, out int totalCount, int startorder = 0)
	{
		totalCount = default(int);
	}

	public void CallManagerToWorkOn(int managerIdx, int officeIdx, Worker.E_AppearType appearType, Action loadCb = null)
	{
	}

	public Transform GetSpawnTrans(Worker.E_WorkerType type, Worker.E_AppearType appearType)
	{
		return null;
	}

	public Transform GetExitTrans(Worker.E_WorkerType type, Worker.E_AppearType appearType)
	{
		return null;
	}

	public Room GetOfficeRoom(int officeIdx)
	{
		return null;
	}

	public void ClickAdBoard()
	{
	}

	public List<InGameAstar.Node> GetVipPathNodes(AdSupplySystem.AdsupplyType type)
	{
		return null;
	}

	public Vector3 EndVipPos()
	{
		return default(Vector3);
	}

	[IteratorStateMachine(typeof(_003CUpdateSpecialTheme_003Ed__92))]
	public IEnumerator UpdateSpecialTheme()
	{
		yield break;
	}

	private void UpdateBoosterOfficeEffect()
	{
	}

	private void InitBoosterOfficeEffect()
	{
	}

	private void UpdateBoosterOfficeEffect(int officeIdx)
	{
	}

	public void FocusCeo()
	{
	}

	[IteratorStateMachine(typeof(_003CFocusCeoCoroutine_003Ed__97))]
	private IEnumerator FocusCeoCoroutine()
	{
		yield break;
	}

	private void OnDestroy()
	{
	}
}
