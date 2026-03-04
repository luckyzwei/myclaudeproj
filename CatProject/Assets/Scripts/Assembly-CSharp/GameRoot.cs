using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.U2D;

public class GameRoot : Singleton<GameRoot>
{
	[CompilerGenerated]
	private sealed class _003CLoadGameData_003Ed__255 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameRoot _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public _003CLoadGameData_003Ed__255(int _003C_003E1__state)
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
	private sealed class _003CStart_003Ed__251 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameRoot _003C_003E4__this;

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
		public _003CStart_003Ed__251(int _003C_003E1__state)
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
	private sealed class _003CwaitAndOpenUICoroutine_003Ed__270<T> : IEnumerator<object>, IEnumerator, IDisposable where T : UIBase
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameRoot _003C_003E4__this;

		public Action<T> OnLoad;

		public Action OnClose;

		public bool caching;

		public int targetEventStage;

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
		public _003CwaitAndOpenUICoroutine_003Ed__270(int _003C_003E1__state)
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
	private sealed class _003CwaitCustomYieldInstruction_003Ed__268 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CustomYieldInstruction cyi;

		public Action callback;

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
		public _003CwaitCustomYieldInstruction_003Ed__268(int _003C_003E1__state)
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
	private sealed class _003CwaitEndFrame_003Ed__266 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action callback;

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
		public _003CwaitEndFrame_003Ed__266(int _003C_003E1__state)
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
	private sealed class _003CwaitGameIdleStateCoroutine_003Ed__271 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameRoot _003C_003E4__this;

		public Action callback;

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
		public _003CwaitGameIdleStateCoroutine_003Ed__271(int _003C_003E1__state)
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
	private sealed class _003CwaitStageAndCallback_003Ed__269 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float time;

		public Action callback;

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
		public _003CwaitStageAndCallback_003Ed__269(int _003C_003E1__state)
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
	private sealed class _003CwaitTimeAndCallback_003Ed__267 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float time;

		public Action callback;

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
		public _003CwaitTimeAndCallback_003Ed__267(int _003C_003E1__state)
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

	[SerializeField]
	private Transform MainUITrans;

	[SerializeField]
	private Transform HUDUITrans;

	[SerializeField]
	private Canvas MainCanvas;

	[SerializeField]
	private Canvas WorldCanvas;

	[SerializeField]
	private GameObject CheatWindow;

	[SerializeField]
	private GameObject DebugObj;

	public List<SystemBase> SystemHolder;

	public UnityMainThreadDispatcher MainThreadDispatcher;

	public ExceptionManager ExceptionManager;

	public GameObject BasicDim;

	[HideInInspector]
	public LoadingBasic Loading;

	[HideInInspector]
	public LoadingRenovate RenovateLoading;

	[HideInInspector]
	public LoadingNextChapter ChapterLoading;

	[HideInInspector]
	public LoadingSeasonal SeasonalLoading;

	public GameObject UILock;

	public GameObject GameLock;

	private static bool InitTry;

	private float deltaTime;

	private float logStageTime;

	private float logSeasonalTime;

	[HideInInspector]
	public bool checkOfflineReward;

	private Queue<Action> PauseActions;

	private bool requestAtlas;

	private int loadingCnt;

	private int tryLoadCnt;

	private bool isLastVersionCheck;

	public GameObject _CheatWindow { get { return CheatWindow; } }

	public RectTransform GetMainCanvasTR { get { return MainCanvas != null ? MainCanvas.GetComponent<RectTransform>() : null; } }

	public UISystem UISystem { get; private set; }

	public UserDataSystem UserData { get; private set; }

	public InGameSystem InGameSystem { get; private set; }

	public EffectSystem EffectSystem { get; private set; }

	public TimeSystem TimeSystem { get; private set; }

	public TimerSystem TimerSystem { get; private set; }

	public BuffSystem BuffSystem { get; private set; }

	public SnapshotCamera SnapshotCam { get; private set; }

	public GameNotificationSystem GameNotification { get; private set; }

	public InAppPurchaseManager InAppPurchaseManager { get; private set; }

	public PluginSystem PluginSystem { get; private set; }

	public UserSegmentSystem UserSegmentSystem { get; private set; }

	public TutorialSystem TutorialSystem { get; private set; }

	public AdSupplySystem AdSupplySystem { get; private set; }

	public SceneSystem SceneSystem { get; private set; }

	public ShopSystem ShopSystem { get; private set; }

	public DaySystem DaySystem { get; private set; }

	public RentalFeeSystem RentalFeeSystem { get; private set; }

	public CompanySystem CompanySystem { get; private set; }

	public MissionSystem MissionSystem { get; private set; }

	public EmployeeMoodSystem MoodSystem { get; private set; }

	public ElectricWorkSystem ElectricWorkSystem { get; private set; }

	public ContentsOpenSystem ContentsOpenSystem { get; private set; }

	public RouletteSystem RouletteSystem { get; private set; }

	public MassengerSystem MassengerSystem { get; private set; }

	public AbilitySystem AbilitySystem { get; private set; }

	public PlantSystem PlantSystem { get; private set; }

	public DailyQuestSystem DailyQuestSystem { get; private set; }

	public InfraSystem InfraSystem { get; private set; }

	public RankingSystem RankSystem { get; private set; }

	public FactorySystem FactorySystem { get; private set; }

	public OneTimeEventSystem OneTimeEventSystem { get; private set; }

	public InvestSystem InvestSystem { get; private set; }

	public ABTestSystem ABTestSystem { get; private set; }

	public ManagerCardSystem ManagerCardSystem { get; private set; }

	public SeasonalSystem SeasonalSystem { get; private set; }

	public TarotSystem TarotSystem { get; private set; }

	public AuctionSystem AuctionSystem { get; private set; }

	public SpecialDaySystem SpecialDaySystem { get; private set; }

	public RichAchieveSystem RichAchieveSystem { get; private set; }

	public StrikeSystem StrikeSystem { get; private set; }

	public AttendanceSystem AttendanceSystem { get; private set; }

	public ContentsMissionSystem ContentsMissionSystem { get; private set; }

	public BizAcqBattleSystem BizAcqBattleSystem { get; private set; }

	public SubMissionSystem SubMissionSystem { get; private set; }

	public AdPassSystem AdPassSystem { get; private set; }

	public MiniGameSystem MiniGameSystem { get; private set; }

	public InterstitialSystem InterstitialSystem { get; private set; }

	public FreecashSystem FreecashSystem { get; private set; }

	public List<IAdTimeContents> AdsContentsList { get; private set; }

	public static bool LoadComplete { get; private set; }

	public GameType CurGameType { get; private set; }

	public IReactiveProperty<int> GamePlayTimeSec { get; private set; }

	public int OriginScreenWidth { get; private set; }

	public int OriginScreenHeight { get; private set; }

	public static bool IsInit()
	{
		return InitTry;
	}

	public static void Load()
	{
		InitTry = true;
	}

	private void Update()
	{
	}

	public void InitGameType()
	{
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__251))]
	private IEnumerator Start()
	{
		yield break;
	}

	[IteratorStateMachine(typeof(_003CLoadGameData_003Ed__255))]
	private IEnumerator LoadGameData()
	{
		yield break;
	}

	private void GiveBackHouseAddPoint()
	{
	}

	private void InitUILoading()
	{
	}

	private void InitRequestAtlas()
	{
	}

	private void InitLastVersionCheck()
	{
	}

	private void InitSystem()
	{
		UserData = new UserDataSystem();
		UserData.InitDataState();
		TimeSystem = new TimeSystem();
		TimerSystem = new TimerSystem();
		DaySystem = new DaySystem();
		DaySystem.Init();
		BuffSystem = new BuffSystem();
		BuffSystem.Create();
		EffectSystem = new EffectSystem();
		AbilitySystem = new AbilitySystem();
		AbilitySystem.Init();
		GameNotification = new GameNotificationSystem();
		ManagerCardSystem = new ManagerCardSystem();
		ManagerCardSystem.Init();
		SystemHolder = new List<SystemBase>();
		AdsContentsList = new List<IAdTimeContents>();
		PauseActions = new Queue<Action>();
		GamePlayTimeSec = new ReactiveProperty<int>();
		LoadComplete = true;
	}

	private void OnAtlasRequest(string tag, Action<SpriteAtlas> callback)
	{
	}

	public void ChangeGameType(GameType type, bool changeData = false, Action callBackAction = null, bool isForce = false)
	{
	}

	private void SetNativeLanguage()
	{
	}

	public void SetCheatWindow(bool value)
	{
	}

	public void RemoveDelayAdTimeContents()
	{
	}

	[IteratorStateMachine(typeof(_003CwaitEndFrame_003Ed__266))]
	private IEnumerator waitEndFrame(Action callback)
	{
		yield break;
	}

	[IteratorStateMachine(typeof(_003CwaitTimeAndCallback_003Ed__267))]
	private IEnumerator waitTimeAndCallback(float time, Action callback)
	{
		yield break;
	}

	[IteratorStateMachine(typeof(_003CwaitCustomYieldInstruction_003Ed__268))]
	private IEnumerator waitCustomYieldInstruction(CustomYieldInstruction cyi, Action callback)
	{
		yield break;
	}

	[IteratorStateMachine(typeof(_003CwaitStageAndCallback_003Ed__269))]
	private IEnumerator waitStageAndCallback(float time, Action callback)
	{
		yield break;
	}

	[IteratorStateMachine(typeof(_003CwaitAndOpenUICoroutine_003Ed__270<>))]
	private IEnumerator waitAndOpenUICoroutine<T>(Action<T> OnLoad = null, Action OnClose = null, bool caching = true, int targetEventStage = -1) where T : UIBase
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CwaitGameIdleStateCoroutine_003Ed__271))]
	private IEnumerator waitGameIdleStateCoroutine(Action callback)
	{
		yield break;
	}

	public void WaitEndFrameCallback(Action callback)
	{
		StartCoroutine(waitEndFrame(callback));
	}

	public Coroutine WaitTimeAndCallback(float time, Action callback)
	{
		return StartCoroutine(waitTimeAndCallback(time, callback));
	}

	public Coroutine WaitCustomYieldInstruction(CustomYieldInstruction cyi, Action callback)
	{
		return StartCoroutine(waitCustomYieldInstruction(cyi, callback));
	}

	public Coroutine WaitAndOpenUICoroutine<T>(Action<T> OnLoad = null, Action OnClose = null, bool caching = true, int targetEventStage = -1) where T : UIBase
	{
		return StartCoroutine(waitAndOpenUICoroutine<T>(OnLoad, OnClose, caching, targetEventStage));
	}

	public Coroutine WaitGameIdleStateCoroutine(Action callback)
	{
		return StartCoroutine(waitGameIdleStateCoroutine(callback));
	}

	public void RefreshHUD(HUDBase.E_RefreshType refreshType)
	{
	}

	public Vector3 GetRewardEndPos(HUDBase.E_HUDPosType type, int rewardType = 0, int rewardIdx = 0)
	{
		return default(Vector3);
	}

	private HUDBase GetHUDBase()
	{
		return null;
	}

	public Vector3 GetRewardEndPos(int rewardType, int rewardIdx, bool ispopup = false)
	{
		return default(Vector3);
	}

	private void CheckHeartBeat()
	{
	}

	public void SetUserSegmentType(SegmentType type)
	{
		if (UserData != null) UserData.UserSegmentType = type;
	}

	public void CheatCall_OnApplicationPause(bool bPause)
	{
	}

	private void OnApplicationPause(bool pause)
	{
	}

	private bool ForceUpdateByAppVersion(out bool ishard)
	{
		ishard = default(bool);
		return false;
	}

	public void ConvertUserData()
	{
	}

	public bool IsAnyLoadingActive()
	{
		return false;
	}
}
