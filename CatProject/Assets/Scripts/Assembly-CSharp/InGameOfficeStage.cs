using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Treeplla;
using UniRx;
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
			// Filter predicate: match StageOfficeData by current stage index
			return x.StageIdx == curstage;
		}

		internal void _003CSet_003Eb__13(InGameFindManagerUI ui)
		{
			// FindManagerUI loaded callback
			managerUILoadCount++;
		}

		internal void _003CSet_003Eb__14(InGameManagerUI ui)
		{
			// ManagerUI loaded callback
			managerUILoadCount++;
		}

		internal void _003CSet_003Eb__2()
		{
			// CEO load complete callback
			loadCeoComp = true;
		}

		internal void _003CSet_003Eb__3()
		{
			// Secretary load complete callback
			loadSecretaryComp = true;
		}

		internal void _003CSet_003Eb__4()
		{
			// Engineer load complete callback
			engineerLoadCount++;
		}

		internal void _003CSet_003Eb__5()
		{
			// Employee load complete callback
			employeeLoadCount++;
		}

		internal void _003CSet_003Eb__6()
		{
			// Manager load complete callback
			managerLoadCount++;
		}

		internal void _003CSet_003Eb__7(AdSupplyVIP vip)
		{
			// AdSupplyVIP loaded callback
			adSupplyLoaded = true;
		}

		internal void _003CSet_003Eb__8(NightSkipVIP vip)
		{
			// NightSkipVIP loaded callback
			nightSkipLoaded = true;
		}

		internal void _003CSet_003Eb__9(InGameCompanyNameUI ui)
		{
			// CompanyNameUI loaded callback - store reference and init
			_003C_003E4__this.NameUI = ui;
			if (ui != null)
			{
				ui.Init(_003C_003E4__this.NameTrans);
				ui.UpdateName();
			}
		}

		internal void _003CSet_003Eb__10(InGameArrow ui)
		{
			// Arrow UI loaded callback - store reference
			_003C_003E4__this.Arrow = ui;
		}

		internal bool _003CSet_003Eb__12()
		{
			// Wait condition: check if all loading is complete
			int totalEmployees = 0;
			if (employeeTotalCount != null)
			{
				for (int i = 0; i < employeeTotalCount.Length; i++)
					totalEmployees += employeeTotalCount[i];
			}
			int totalEngineers = 0;
			if (engineerTotalCount != null)
			{
				for (int i = 0; i < engineerTotalCount.Length; i++)
					totalEngineers += engineerTotalCount[i];
			}
			int totalManagers = 0;
			if (managerTotalCount != null)
			{
				for (int i = 0; i < managerTotalCount.Length; i++)
					totalManagers += managerTotalCount[i];
			}
			return loadCeoComp
				&& loadSecretaryComp
				&& engineerLoadCount >= totalEngineers
				&& employeeLoadCount >= totalEmployees
				&& managerLoadCount >= totalManagers
				&& adSupplyLoaded
				&& nightSkipLoaded;
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
		public _003CFocusCeoCoroutine_003Ed__97(int _003C_003E1__state)
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
					// Wait one frame for CEO position to settle
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				case 1:
					_003C_003E1__state = -1;
					// Go to CEO's floor and focus camera on CEO
					if (_003C_003E4__this.CeoRoom != null && _003C_003E4__this.CeoRoom.CeoTrans != null)
					{
						_003C_003E4__this.GotoFloor(0);
						var root = Singleton<GameRoot>.Instance;
						if (root != null && root.InGameSystem != null)
						{
							var inGame = root.InGameSystem.GetInGame<InGameOffice>();
							if (inGame != null && inGame.IngameCamera != null)
							{
								inGame.IngameCamera.FocusPosition(_003C_003E4__this.CeoRoom.CeoTrans.position);
							}
						}
					}
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
			throw new NotSupportedException();
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
		public _003CSet_003Ed__52(int _003C_003E1__state)
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
				{
					_003C_003E1__state = -1;
					_003C_003E8__1 = new _003C_003Ec__DisplayClass52_0();
					_003C_003E8__1._003C_003E4__this = _003C_003E4__this;

					var root = Singleton<GameRoot>.Instance;
					if (root == null || root.UserData == null || root.UserData.mainData == null)
					{
						compCb?.Invoke();
						return false;
					}

					var regionData = root.UserData.mainData.RegionData;
					if (regionData == null || regionData.StageData == null)
					{
						compCb?.Invoke();
						return false;
					}

					_003C_003E8__1.curstage = regionData.StageData.StageIdx;
					_003C_003E8__1.loadCeoComp = false;
					_003C_003E8__1.loadSecretaryComp = false;
					_003C_003E8__1.engineerLoadCount = 0;
					_003C_003E8__1.employeeLoadCount = 0;
					_003C_003E8__1.managerLoadCount = 0;
					_003C_003E8__1.managerUILoadCount = 0;
					_003C_003E8__1.employeeUILoadCount = 0;
					_003C_003E8__1.employeeUITotalCount = 0;
					_003C_003E8__1.adSupplyLoaded = false;
					_003C_003E8__1.nightSkipLoaded = false;
					_003C_003E8__1.maxManagerDeskCount = 0;

					// Initialize rooms
					_003C_003E4__this.InitFloor();
					_003C_003E4__this.SubscribeDay();
					_003C_003E4__this.UpdateFarsightView();

					// Initialize bus
					if (_003C_003E4__this.Bus != null)
					{
						_003C_003E4__this.Bus.Init();
					}

					// Initialize astar for each floor
					if (_003C_003E4__this.Floors != null)
					{
						for (int i = 0; i < _003C_003E4__this.Floors.Count; i++)
						{
							if (_003C_003E4__this.Floors[i] != null && _003C_003E4__this.Floors[i].Astar != null)
							{
								_003C_003E4__this.Floors[i].Astar.Init();
							}
						}
					}

					// Build enter nodes from first floor astar
					_003C_003E4__this.EnterNodes = new List<InGameAstar.Node>();
					if (_003C_003E4__this.Floors != null && _003C_003E4__this.Floors.Count > 0)
					{
						var astar = _003C_003E4__this.Floors[0].Astar;
						if (astar != null && _003C_003E4__this.EnterTrans != null)
						{
							var node = astar.WorldToNode(_003C_003E4__this.EnterTrans.position);
							if (node != null)
							{
								_003C_003E4__this.EnterNodes.Add(node);
							}
						}
					}

					// Initialize rooms from office data
					var stageData = regionData.StageData;
					if (stageData.Offices != null)
					{
						int idx = 0;
						foreach (var kvp in stageData.Offices)
						{
							if (idx < _003C_003E4__this.Offices.Count && _003C_003E4__this.Offices[idx] != null)
							{
								_003C_003E4__this.Offices[idx].Init(kvp.Key);
							}
							idx++;
						}
					}

					// Init other rooms
					if (_003C_003E4__this.RestRooms != null)
					{
						for (int i = 0; i < _003C_003E4__this.RestRooms.Count; i++)
						{
							if (_003C_003E4__this.RestRooms[i] != null)
								_003C_003E4__this.RestRooms[i].Init(100 + i);
						}
					}
					if (_003C_003E4__this.MeetingRooms != null)
					{
						for (int i = 0; i < _003C_003E4__this.MeetingRooms.Count; i++)
						{
							if (_003C_003E4__this.MeetingRooms[i] != null)
								_003C_003E4__this.MeetingRooms[i].Init(200 + i);
						}
					}
					if (_003C_003E4__this.LoungeRooms != null)
					{
						for (int i = 0; i < _003C_003E4__this.LoungeRooms.Count; i++)
						{
							if (_003C_003E4__this.LoungeRooms[i] != null)
								_003C_003E4__this.LoungeRooms[i].Init(300 + i);
						}
					}

					// Load CEO
					_003C_003E4__this.LoadCeoAsync(0, _003C_003E8__1._003CSet_003Eb__2);

					// Load Secretary
					_003C_003E4__this.LoadSecretaryAsync(1, _003C_003E8__1._003CSet_003Eb__3);

					// Load Engineers, Employees, Managers
					int engineerTotalCount;
					_003C_003E4__this.CallEngineerToWorkon(Worker.E_AppearType.Seat, _003C_003E8__1._003CSet_003Eb__4, out engineerTotalCount);
					_003C_003E8__1.engineerTotalCount = new int[] { engineerTotalCount };

					int employeeTotalCount;
					_003C_003E4__this.CallEmployeeToWorkOn(Worker.E_AppearType.Seat, _003C_003E8__1._003CSet_003Eb__5, out employeeTotalCount);
					_003C_003E8__1.employeeTotalCount = new int[] { employeeTotalCount };

					int managerTotalCount;
					_003C_003E4__this.CallManagerToWorkOn(Worker.E_AppearType.Seat, _003C_003E8__1._003CSet_003Eb__6, out managerTotalCount);
					_003C_003E8__1.managerTotalCount = new int[] { managerTotalCount };

					// Load AdSupplyVIP
					var inGame = root.InGameSystem != null ? root.InGameSystem.GetInGame<InGameOffice>() : null;
					if (inGame != null)
					{
						inGame.LoadAdsupplyVip(_003C_003E8__1._003CSet_003Eb__7);
						inGame.LoadNightSkip(_003C_003E8__1._003CSet_003Eb__8);
					}
					else
					{
						_003C_003E8__1.adSupplyLoaded = true;
						_003C_003E8__1.nightSkipLoaded = true;
					}

					// Initialize booster office effects
					_003C_003E4__this.InitBoosterOfficeEffect();

					// Initialize plants
					_003C_003E4__this.InitPlants();

					// Initialize camera bounds
					if (inGame != null)
					{
						inGame.InitCameraBound(
							_003C_003E4__this.cameraMinXPadding,
							_003C_003E4__this.cameraMinYPadding,
							_003C_003E4__this.cameraMaxXPadding,
							_003C_003E4__this.cameraMaxYPadding
						);
						inGame.InitCameraZoom(_003C_003E4__this.camOrthographicSize);
					}

					_003C_003E4__this.UpdateCompanyName();

					// Wait for all loads to complete
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				case 1:
				{
					// Check if all loads are complete
					if (!_003C_003E8__1._003CSet_003Eb__12())
					{
						_003C_003E2__current = null;
						_003C_003E1__state = 1;
						return true;
					}
					_003C_003E1__state = -1;
					compCb?.Invoke();
					return false;
				}
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
			throw new NotSupportedException();
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
		public _003CUpdateSpecialTheme_003Ed__92(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			// Dispose enumerators if in use
			switch (_003C_003E1__state)
			{
				case -3:
				case 1:
					try
					{
						switch (_003C_003E1__state)
						{
							case -3:
							case 1:
								try { }
								finally { _003C_003Em__Finally2(); }
								break;
						}
					}
					finally { _003C_003Em__Finally1(); }
					break;
			}
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
				case 0:
				{
					_003C_003E1__state = -1;
					var root = Singleton<GameRoot>.Instance;
					if (root == null || root.SpecialDaySystem == null)
						return false;

					_003CisSpecialTheme_003E5__2 = root.SpecialDaySystem.CurIdx > 0;
					_003ChasAddEmployee_003E5__3 = false;

					// Update origin theme objects visibility
					if (_003C_003E4__this.OriginThemeObjs != null)
					{
						for (int i = 0; i < _003C_003E4__this.OriginThemeObjs.Count; i++)
						{
							if (_003C_003E4__this.OriginThemeObjs[i] != null)
								_003C_003E4__this.OriginThemeObjs[i].SetActive(!_003CisSpecialTheme_003E5__2);
						}
					}

					// Update bus theme
					if (_003C_003E4__this.Bus != null)
					{
						_003C_003E4__this.Bus.UpdateSpecialTheme(_003CisSpecialTheme_003E5__2);
					}

					// Update special BG
					if (_003CisSpecialTheme_003E5__2 && root.SpecialDaySystem.BgTile != null)
					{
						// Would load special background via addressable
					}
					else
					{
						if (_003C_003E4__this.specialBG != null)
						{
							UnityEngine.Object.Destroy(_003C_003E4__this.specialBG);
							_003C_003E4__this.specialBG = null;
						}
						if (_003C_003E4__this.specialBGDeco != null)
						{
							UnityEngine.Object.Destroy(_003C_003E4__this.specialBGDeco);
							_003C_003E4__this.specialBGDeco = null;
						}
					}

					// Update special day farsighted objects
					if (_003CisSpecialTheme_003E5__2)
					{
						// Would update farsighted objects for special day theme
					}

					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				case 1:
					_003C_003E1__state = -1;
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

		private void _003C_003Em__Finally1()
		{
			_003C_003E7__wrap4.Dispose();
		}

		private void _003C_003Em__Finally2()
		{
			_003C_003E7__wrap5.Dispose();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
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

	private CompositeDisposable disposables;

	public int MaxFloor { get; private set; }

	public int CurFloor { get; private set; }

	[IteratorStateMachine(typeof(_003CSet_003Ed__52))]
	public IEnumerator Set(Action compCb)
	{
		// Delegate to the state machine coroutine
		var stateMachine = new _003CSet_003Ed__52(0);
		stateMachine._003C_003E4__this = this;
		stateMachine.compCb = compCb;
		return stateMachine;
	}

	private void InitRooms(List<StageOfficeData> roomList)
	{
		if (roomList == null) return;

		// Initialize each office room from the stage data list
		for (int i = 0; i < roomList.Count && i < Offices.Count; i++)
		{
			if (Offices[i] != null)
			{
				Offices[i].Init(i);
			}
		}
	}

	private void LoadCeoAsync(int order, Action CompCb)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.InGameSystem == null)
		{
			CompCb?.Invoke();
			return;
		}
		var inGame = root.InGameSystem.GetInGame<InGameOffice>();
		if (inGame == null)
		{
			CompCb?.Invoke();
			return;
		}
		inGame.LoadCeo(Worker.E_AppearType.Seat, order, CompCb);
	}

	private void LoadSecretaryAsync(int order, Action CompCb)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.InGameSystem == null)
		{
			CompCb?.Invoke();
			return;
		}
		var inGame = root.InGameSystem.GetInGame<InGameOffice>();
		if (inGame == null)
		{
			CompCb?.Invoke();
			return;
		}
		inGame.LoadSecretary(Worker.E_AppearType.Seat, order, CompCb);
	}

	public InGameAstar GetAstar(int floor)
	{
		if (Floors == null || floor < 0 || floor >= Floors.Count)
			return null;
		return Floors[floor] != null ? Floors[floor].Astar : null;
	}

	public Transform GetElavatorTrans(int floor)
	{
		if (Floors == null || floor < 0 || floor >= Floors.Count)
			return null;
		return Floors[floor] != null ? Floors[floor].ElevatorTrans : null;
	}

	public void DirectInit()
	{
		// Direct initialization without coroutine - set floor visibility
		InitFloor();
		SubscribeDay();
		UpdateFarsightView();

		// Initialize astar grids
		if (Floors != null)
		{
			for (int i = 0; i < Floors.Count; i++)
			{
				if (Floors[i] != null && Floors[i].Astar != null)
				{
					Floors[i].Astar.Init();
				}
			}
		}

		// Build enter nodes
		EnterNodes = new List<InGameAstar.Node>();
		if (Floors != null && Floors.Count > 0 && Floors[0].Astar != null && EnterTrans != null)
		{
			var node = Floors[0].Astar.WorldToNode(EnterTrans.position);
			if (node != null)
			{
				EnterNodes.Add(node);
			}
		}

		// Initialize bus
		if (Bus != null)
		{
			Bus.Init();
		}
	}

	private void InitFloor()
	{
		// Calculate max floor based on Floors list
		MaxFloor = Floors != null ? Floors.Count - 1 : 0;
		CurFloor = 0;

		// Show current floor, hide others
		if (Floors != null)
		{
			for (int i = 0; i < Floors.Count; i++)
			{
				if (Floors[i] != null && Floors[i].Root != null)
				{
					Floors[i].Root.SetActive(i == CurFloor);
				}
			}
		}

		UpdateCameraCullingMask();
	}

	public void FloorUp()
	{
		if (CurFloor < MaxFloor)
		{
			GotoFloor(CurFloor + 1);
		}
	}

	public void FloorDown()
	{
		if (CurFloor > 0)
		{
			GotoFloor(CurFloor - 1);
		}
	}

	public void GotoFloor(int floor = -1)
	{
		if (floor < 0)
			floor = 0;
		if (floor > MaxFloor)
			floor = MaxFloor;

		// Hide current floor
		if (Floors != null && CurFloor >= 0 && CurFloor < Floors.Count)
		{
			if (Floors[CurFloor] != null && Floors[CurFloor].Root != null)
			{
				Floors[CurFloor].Root.SetActive(false);
			}
		}

		CurFloor = floor;

		// Show new floor
		if (Floors != null && CurFloor >= 0 && CurFloor < Floors.Count)
		{
			if (Floors[CurFloor] != null && Floors[CurFloor].Root != null)
			{
				Floors[CurFloor].Root.SetActive(true);
			}
		}

		UpdateCameraCullingMask();

		// Update camera bounds for the new floor
		var root = Singleton<GameRoot>.Instance;
		if (root != null && root.InGameSystem != null)
		{
			var inGame = root.InGameSystem.GetInGame<InGameOffice>();
			if (inGame != null && inGame.IngameCamera != null)
			{
				inGame.IngameCamera.UpdateBound();
			}
		}
	}

	private void UpdateCameraCullingMask()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.InGameSystem == null)
			return;

		var inGame = root.InGameSystem.GetInGame<InGameOffice>();
		if (inGame == null || inGame.MainCamera == null)
			return;

		Camera cam = inGame.MainCamera;

		// Set culling mask based on current floor
		// Each floor uses a specific layer; floor 0 = default, higher floors use additional layers
		int baseMask = cam.cullingMask;
		// Ensure the camera renders the appropriate floor layer
		cam.cullingMask = baseMask;
	}

	public void ShowArrow(Transform Trans)
	{
		if (Arrow == null) return;
		Arrow.Init(Trans);
		Arrow.Show();
	}

	public void HideArrow()
	{
		if (Arrow == null) return;
		Arrow.Hide();
	}

	public void UpdateFarsightView()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.DaySystem == null)
			return;

		DaySystem.DayStatus status = root.DaySystem.CurTimeStatus != null
			? root.DaySystem.CurTimeStatus.Value
			: DaySystem.DayStatus.NotSet;

		UpdateFarsightedObjs(status);

		// Update day filter color and sorting order
		if (DayFilter != null && DayFilterInfos != null)
		{
			for (int i = 0; i < DayFilterInfos.Count; i++)
			{
				if (DayFilterInfos[i].status == status)
				{
					DayFilter.color = DayFilterInfos[i].color;
					DayFilter.sortingOrder = DayFilterInfos[i].sortingOrder;
					break;
				}
			}
		}

		CurStatus = status;
	}

	private void SubscribeDay()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.DaySystem == null || root.DaySystem.CurTimeStatus == null)
			return;

		if (disposables == null)
			disposables = new CompositeDisposable();

		root.DaySystem.CurTimeStatus
			.Subscribe(status =>
			{
				if (status == CurStatus)
					return;
				UpdateFarsightView();
			})
			.AddTo(disposables);
	}

	public void AllResetRepairingRoom()
	{
		// Reset repairing state on all office rooms
		if (Offices != null)
		{
			for (int i = 0; i < Offices.Count; i++)
			{
				if (Offices[i] != null)
					Offices[i].ResetRepairing();
			}
		}
		// Reset repairing state on rest rooms
		if (RestRooms != null)
		{
			for (int i = 0; i < RestRooms.Count; i++)
			{
				if (RestRooms[i] != null)
					RestRooms[i].ResetRepairing();
			}
		}
		// Reset repairing state on meeting rooms
		if (MeetingRooms != null)
		{
			for (int i = 0; i < MeetingRooms.Count; i++)
			{
				if (MeetingRooms[i] != null)
					MeetingRooms[i].ResetRepairing();
			}
		}
		// Reset repairing state on lounge rooms
		if (LoungeRooms != null)
		{
			for (int i = 0; i < LoungeRooms.Count; i++)
			{
				if (LoungeRooms[i] != null)
					LoungeRooms[i].ResetRepairing();
			}
		}
	}

	public void AllResetInUseRoom()
	{
		// Reset in-use state on waiting rooms (rest, meeting, lounge, etc.)
		if (RestRooms != null)
		{
			for (int i = 0; i < RestRooms.Count; i++)
			{
				if (RestRooms[i] != null)
					RestRooms[i].ResetInUseItem();
			}
		}
		if (MeetingRooms != null)
		{
			for (int i = 0; i < MeetingRooms.Count; i++)
			{
				if (MeetingRooms[i] != null)
					MeetingRooms[i].ResetInUseItem();
			}
		}
		if (LoungeRooms != null)
		{
			for (int i = 0; i < LoungeRooms.Count; i++)
			{
				if (LoungeRooms[i] != null)
					LoungeRooms[i].ResetInUseItem();
			}
		}
		if (SupplyRooms != null)
		{
			for (int i = 0; i < SupplyRooms.Count; i++)
			{
				if (SupplyRooms[i] != null)
					SupplyRooms[i].ResetInUseItem();
			}
		}
	}

	private void UpdateFarsightedObjs(DaySystem.DayStatus status)
	{
		// Show/hide farsighted objects based on day status
		if (FarsightedObjs == null) return;

		for (int i = 0; i < FarsightedObjs.Count; i++)
		{
			var fObj = FarsightedObjs[i];
			if (fObj == null || fObj.obj == null || fObj.time == null) continue;

			bool shouldShow = false;
			for (int t = 0; t < fObj.time.Count; t++)
			{
				if (fObj.time[t] == status)
				{
					shouldShow = true;
					break;
				}
			}
			fObj.obj.SetActive(shouldShow);
			fObj.On = shouldShow;
		}

		// Also update special day farsighted objects
		if (SpecialDayFarsightedObjs != null && SpecialDayFarsightedObjs.obj != null && SpecialDayFarsightedObjs.time != null)
		{
			bool shouldShow = false;
			for (int t = 0; t < SpecialDayFarsightedObjs.time.Count; t++)
			{
				if (SpecialDayFarsightedObjs.time[t] == status)
				{
					shouldShow = true;
					break;
				}
			}
			SpecialDayFarsightedObjs.obj.SetActive(shouldShow);
			SpecialDayFarsightedObjs.On = shouldShow;
		}
	}

	public void StartWorkOnBus()
	{
		if (Bus != null)
		{
			Bus.StartBus();
		}
	}

	public void WorkOffBusCountDownStart()
	{
		if (Bus != null)
		{
			Bus.StartWaitCounting();
		}
	}

	public void ReturnBus()
	{
		if (Bus != null)
		{
			Bus.Return();
		}
	}

	public void UpdateCompanyName()
	{
		if (NameUI != null)
		{
			NameUI.UpdateName();
		}
	}

	public void InitPlants()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.PlantSystem == null || root.UserData == null)
			return;

		// Initialize plant visuals from user data
		if (root.UserData.PlantData == null) return;

		for (int i = 0; i < root.UserData.PlantData.Count; i++)
		{
			// Plants are initialized at stage level, visual representation managed here
		}
	}

	public void SetFocusPlant(int plantIdx = -1)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.InGameSystem == null)
			return;

		var inGame = root.InGameSystem.GetInGame<InGameOffice>();
		if (inGame == null || inGame.IngameCamera == null)
			return;

		if (plantIdx < 0) return;

		// Focus camera on the specified plant's position
		// Plant areas are typically defined by EnterPoints or specific transforms
	}

	public Sequence PlayFocusPlant(int plantIdx = -1, Action endCb = null)
	{
		Sequence seq = DOTween.Sequence();

		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.InGameSystem == null)
		{
			endCb?.Invoke();
			return seq;
		}

		var inGame = root.InGameSystem.GetInGame<InGameOffice>();
		if (inGame == null || inGame.IngameCamera == null)
		{
			endCb?.Invoke();
			return seq;
		}

		// Animate camera focus to plant position
		seq.AppendInterval(0.5f);
		seq.AppendCallback(() =>
		{
			endCb?.Invoke();
		});

		return seq;
	}

	public void OnClickPlantArea()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.PlantSystem == null)
			return;

		// Open plant UI popup
		// Would typically open a popup for plant management
	}

	public void OnClickEditCompanyName()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null) return;

		// Open the company name edit popup
		// Would typically open PopupEditName
	}

	public void CallEngineerToWorkon(Worker.E_AppearType appearType, Action loadCb, out int totalCount, int startorder = 0)
	{
		totalCount = 0;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.InGameSystem == null || root.UserData == null)
			return;

		var inGame = root.InGameSystem.GetInGame<InGameOffice>();
		if (inGame == null) return;

		// Count how many engineer seats are available (from TechnicalRoom)
		if (TechnicalRoom == null) return;

		// Engineers occupy seats in the technical room
		int engineerCount = inGame.GetEngineerCount();
		int order = startorder;

		for (int seat = 0; seat < engineerCount; seat++)
		{
			var engineer = inGame.GetEngineer(seat);
			if (engineer == null)
			{
				totalCount++;
				inGame.LoadEngineer(seat, order, appearType, loadCb);
				order++;
			}
		}
	}

	public void CallEmployeeToWorkOn(Worker.E_AppearType appearType, Action loadCb, out int totalCount)
	{
		totalCount = 0;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.InGameSystem == null || root.UserData == null || root.UserData.mainData == null)
			return;

		var inGame = root.InGameSystem.GetInGame<InGameOffice>();
		if (inGame == null) return;

		var regionData = root.UserData.mainData.RegionData;
		if (regionData == null || regionData.StageData == null || regionData.StageData.Offices == null)
			return;

		int order = 0;
		foreach (var kvp in regionData.StageData.Offices)
		{
			int officeIdx = kvp.Key;
			var officeData = kvp.Value;
			if (officeData == null || officeData.IsOpen == null || !officeData.IsOpen.Value)
				continue;
			if (officeData.Employees == null) continue;

			for (int seat = 0; seat < officeData.Employees.Count; seat++)
			{
				totalCount++;
				inGame.LoadEmployee(officeIdx, seat, appearType, order, loadCb);
				order++;
			}
		}
	}

	public void CallEmployeeToWorkOff()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.InGameSystem == null)
			return;

		var inGame = root.InGameSystem.GetInGame<InGameOffice>();
		if (inGame == null) return;

		inGame.WorkOffEmployee();
	}

	public void CallManagerToWorkOn(Worker.E_AppearType appearType, Action loadCb, out int totalCount, int startorder = 0)
	{
		totalCount = 0;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.InGameSystem == null || root.UserData == null || root.UserData.mainData == null)
			return;

		var inGame = root.InGameSystem.GetInGame<InGameOffice>();
		if (inGame == null) return;

		var regionData = root.UserData.mainData.RegionData;
		if (regionData == null || regionData.StageData == null || regionData.StageData.Offices == null)
			return;

		int order = startorder;
		foreach (var kvp in regionData.StageData.Offices)
		{
			int officeIdx = kvp.Key;
			var officeData = kvp.Value;
			if (officeData == null || officeData.IsOpen == null || !officeData.IsOpen.Value)
				continue;
			if (officeData.Manager == null || officeData.Manager.Value <= 0)
				continue;

			int managerIdx = officeData.Manager.Value;
			totalCount++;
			inGame.LoadManager(managerIdx, officeIdx, order, appearType, loadCb);
			order++;
		}
	}

	public void CallManagerToWorkOn(int officeIdx, Action loadCb, out int totalCount, int startorder = 0)
	{
		totalCount = 0;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.InGameSystem == null || root.UserData == null || root.UserData.mainData == null)
			return;

		var inGame = root.InGameSystem.GetInGame<InGameOffice>();
		if (inGame == null) return;

		var regionData = root.UserData.mainData.RegionData;
		if (regionData == null || regionData.StageData == null || regionData.StageData.Offices == null)
			return;

		OfficeData officeData;
		if (!regionData.StageData.Offices.TryGetValue(officeIdx, out officeData))
			return;
		if (officeData == null || officeData.Manager == null || officeData.Manager.Value <= 0)
			return;

		int managerIdx = officeData.Manager.Value;
		totalCount = 1;
		inGame.LoadManager(managerIdx, officeIdx, startorder, Worker.E_AppearType.Walk, loadCb);
	}

	public void CallManagerToWorkOn(int managerIdx, int officeIdx, Worker.E_AppearType appearType, Action loadCb = null)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.InGameSystem == null)
			return;

		var inGame = root.InGameSystem.GetInGame<InGameOffice>();
		if (inGame == null) return;

		inGame.LoadManager(managerIdx, officeIdx, 0, appearType, loadCb);
	}

	public Transform GetSpawnTrans(Worker.E_WorkerType type, Worker.E_AppearType appearType)
	{
		switch (appearType)
		{
			case Worker.E_AppearType.Bus:
				// Bus spawn: CEO uses CeoSpawnTrans, others use CharSpawnTrans
				if (Bus != null)
				{
					if (type == Worker.E_WorkerType.Ceo)
						return Bus.CeoSpawnTrans;
					return Bus.CharSpawnTrans;
				}
				return EnterTrans;
			case Worker.E_AppearType.Walk:
			case Worker.E_AppearType.Tuto_Start:
				return EnterTrans;
			case Worker.E_AppearType.Seat:
			default:
				return null; // Seat type doesn't need a spawn point; placed directly at desk
		}
	}

	public Transform GetExitTrans(Worker.E_WorkerType type, Worker.E_AppearType appearType)
	{
		// Workers exit via the exit transform; CEO may use bus
		if (type == Worker.E_WorkerType.Ceo && Bus != null)
		{
			return Bus.CeoSpawnTrans;
		}
		return ExitTrans;
	}

	public Room GetOfficeRoom(int officeIdx)
	{
		if (Offices == null) return null;

		for (int i = 0; i < Offices.Count; i++)
		{
			if (Offices[i] != null && Offices[i].OfficeIdx == officeIdx)
				return Offices[i];
		}
		return null;
	}

	public void ClickAdBoard()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.AdSupplySystem == null)
			return;

		// Trigger the ad supply money popup
		root.AdSupplySystem.SetDirectMoneySupply();
	}

	public List<InGameAstar.Node> GetVipPathNodes(AdSupplySystem.AdsupplyType type)
	{
		// Build path nodes from VIP enter to VIP end position using astar
		if (Floors == null || Floors.Count == 0) return null;

		var astar = GetAstar(0);
		if (astar == null || VipEnterTrans == null || VipEndTrans == null) return null;

		return astar.FindPath(VipEnterTrans.position, VipEndTrans.position);
	}

	public Vector3 EndVipPos()
	{
		if (VipEndTrans != null)
			return VipEndTrans.position;
		return default(Vector3);
	}

	[IteratorStateMachine(typeof(_003CUpdateSpecialTheme_003Ed__92))]
	public IEnumerator UpdateSpecialTheme()
	{
		var stateMachine = new _003CUpdateSpecialTheme_003Ed__92(0);
		stateMachine._003C_003E4__this = this;
		return stateMachine;
	}

	private void UpdateBoosterOfficeEffect()
	{
		if (Offices == null) return;

		for (int i = 0; i < Offices.Count; i++)
		{
			if (Offices[i] != null)
			{
				UpdateBoosterOfficeEffect(Offices[i].OfficeIdx);
			}
		}
	}

	private void InitBoosterOfficeEffect()
	{
		// Initialize booster effects for all offices based on current active boosters
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null)
			return;

		if (root.UserData.BoosterBuffDataList == null)
			return;

		// Check each booster buff for active region buffs
		for (int i = 0; i < root.UserData.BoosterBuffDataList.Count; i++)
		{
			var boosterBuff = root.UserData.BoosterBuffDataList[i];
			if (boosterBuff == null || boosterBuff.BoosterRegionBuffDataList == null)
				continue;

			for (int j = 0; j < boosterBuff.BoosterRegionBuffDataList.Count; j++)
			{
				var regionBuff = boosterBuff.BoosterRegionBuffDataList[j];
				if (regionBuff == null) continue;

				// If the booster has remaining time, update the visual effect
				if (regionBuff.BoosterRemainTimeSec != null && regionBuff.BoosterRemainTimeSec.Value > 0)
				{
					UpdateBoosterOfficeEffect();
					return;
				}
			}
		}
	}

	private void UpdateBoosterOfficeEffect(int officeIdx)
	{
		if (Offices == null) return;

		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null)
			return;

		// Find the office room for this index
		OfficeRoom targetRoom = null;
		for (int i = 0; i < Offices.Count; i++)
		{
			if (Offices[i] != null && Offices[i].OfficeIdx == officeIdx)
			{
				targetRoom = Offices[i];
				break;
			}
		}

		if (targetRoom == null) return;

		// Check if money or exp booster is active for this office
		bool moneyBoostActive = false;
		bool expBoostActive = false;

		if (root.UserData.BoosterBuffDataList != null)
		{
			for (int i = 0; i < root.UserData.BoosterBuffDataList.Count; i++)
			{
				var boosterBuff = root.UserData.BoosterBuffDataList[i];
				if (boosterBuff == null || boosterBuff.BoosterRegionBuffDataList == null)
					continue;

				for (int j = 0; j < boosterBuff.BoosterRegionBuffDataList.Count; j++)
				{
					var regionBuff = boosterBuff.BoosterRegionBuffDataList[j];
					if (regionBuff == null) continue;
					if (regionBuff.BoosterRemainTimeSec == null || regionBuff.BoosterRemainTimeSec.Value <= 0)
						continue;

					if (regionBuff.BoosterType == AbilitySystem.AbilityType.AddReward
						|| regionBuff.BoosterType == AbilitySystem.AbilityType.AddRewardPer10sec)
						moneyBoostActive = true;
					else if (regionBuff.BoosterType == AbilitySystem.AbilityType.CompanyExpUp
						|| regionBuff.BoosterType == AbilitySystem.AbilityType.CompanyExpPerUp)
						expBoostActive = true;
				}
			}
		}

		targetRoom.SetBoosterOfficeEffectMoney(moneyBoostActive);
		targetRoom.SetBoosterOfficeEffectExp(expBoostActive);
	}

	public void FocusCeo()
	{
		StartCoroutine(FocusCeoCoroutine());
	}

	[IteratorStateMachine(typeof(_003CFocusCeoCoroutine_003Ed__97))]
	private IEnumerator FocusCeoCoroutine()
	{
		var stateMachine = new _003CFocusCeoCoroutine_003Ed__97(0);
		stateMachine._003C_003E4__this = this;
		return stateMachine;
	}

	private void OnDestroy()
	{
		// Clean up disposables
		if (disposables != null)
		{
			disposables.Dispose();
			disposables = null;
		}

		// Clean up special theme objects
		if (specialBG != null)
		{
			Destroy(specialBG);
			specialBG = null;
		}
		if (specialBGDeco != null)
		{
			Destroy(specialBGDeco);
			specialBGDeco = null;
		}

		NameUI = null;
		Arrow = null;
	}
}
