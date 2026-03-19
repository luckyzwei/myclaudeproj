using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Debug = UnityEngine.Debug;
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

	private new void Awake()
	{
		if (instance == null)
		{
			instance = this;
			DontDestroyOnLoad(gameObject);
		}
		else if (instance != this)
		{
			Destroy(gameObject);
		}
	}

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
		deltaTime += Time.unscaledDeltaTime;
		if (deltaTime >= 1f)
		{
			deltaTime -= 1f;
			if (GamePlayTimeSec != null)
				GamePlayTimeSec.Value++;
		}

		// Drive game systems each frame
		if (RentalFeeSystem != null)
			RentalFeeSystem.Update();
		if (DaySystem != null)
			DaySystem.Update();
	}

	public void InitGameType()
	{
		CurGameType = GameType.Main;
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__251))]
	private IEnumerator Start()
	{
		Debug.Log("[GameRoot] Start() begin");
		SetNativeLanguage();
		InitUILoading();
		InitRequestAtlas();
		InitLastVersionCheck();
		InitSystem();
		InitGameType();
		Debug.Log("[GameRoot] InitSystem done, starting LoadGameData...");
		yield return StartCoroutine(LoadGameData());
		Debug.Log("[GameRoot] LoadGameData done");
		GiveBackHouseAddPoint();
	}

	[IteratorStateMachine(typeof(_003CLoadGameData_003Ed__255))]
	private IEnumerator LoadGameData()
	{
		Debug.Log("[GameRoot] LoadGameData Phase 1: ProjectUtility.Init");
		// Phase 1: Initialize utility and config
		ProjectUtility.Init();

		Debug.Log("[GameRoot] LoadGameData Phase 2: UserData.Load");
		// Phase 2: Try loading user save data
		UserData.Load();

		// Phase 3: If no save data exists, create fresh new-game data
		if (UserData.mainData == null)
		{
			var mainData = new UserDataMain();
			mainData.Init();
			mainData.InitFirstRegion();
			UserData.mainData = mainData;
			UserData.CurMode = mainData;
			UserData.Level.Value = 1;
			UserData.CommonLastLoginTime = System.DateTime.UtcNow;
			UserData.FirstLoginTime = System.DateTime.UtcNow;

			// --- Initial game state (tutorial prefabs don't exist) ---
			SetupInitialGameState(mainData);
		}

		yield return null;

		Debug.Log("[GameRoot] LoadGameData Phase 4: InitSubSystems");
		// Phase 4: Initialize all remaining subsystems
		InitSubSystems();

		yield return null;

		Debug.Log("[GameRoot] LoadGameData Phase 5: Create InGameSystem/SceneSystem");
		// Phase 5: Create InGameSystem and SceneSystem
		InGameSystem = new InGameSystem();
		SceneSystem = new SceneSystem();

		Debug.Log("[GameRoot] LoadGameData Phase 6: StartFirstGame");
		// Phase 6: Start the main game mode (Office scene)
		bool sceneLoaded = false;
		InGameSystem.StartFirstGame(GameType.Main, () => { sceneLoaded = true; Debug.Log("[GameRoot] Scene loaded callback fired"); });

		// Wait for scene load
		while (!sceneLoaded)
			yield return null;

		yield return null;

		// Phase 7: Hide loading screen
		if (Loading != null && Loading.gameObject.activeSelf)
			Loading.WaitStageLoadHide();

		// Phase 8: Post-load initialization
		if (DaySystem != null)
		{
			// Start at work time (9:00 AM) so employees are visible
			DaySystem.CalcCheatTime(9);
		}

		if (RentalFeeSystem != null)
			RentalFeeSystem.CalculateRentalFee();

		if (UserData != null)
			UserData.CommonLastLoginTime = System.DateTime.UtcNow;

		Debug.Log("[GameRoot] LoadGameData complete. Game is running.");
	}

	private void SetupInitialGameState(UserDataMain mainData)
	{
		Debug.Log("[GameRoot] Setting up initial game state for new player");

		var stageData = mainData.StageData;
		if (stageData == null) return;

		// Starting money matches original game (~38,800)
		UserData.HUDMoney.Value = new System.Numerics.BigInteger(38800);
		stageData.Money.Value = new System.Numerics.BigInteger(38800);
		UserData.Level.Value = 0; // Original starts at Level 0
		UserData.HUDPower.Value = 86;

		// Create 3 offices — first one open but EMPTY (no company, no employees)
		// Player will buy desks and sign contracts via tutorial
		for (int i = 0; i < 3; i++)
		{
			var office = new OfficeData();
			office.Create();
			bool shouldOpen = (i == 0); // Only first office is open (but empty)
			office.IsOpen = new ReactiveProperty<bool>(shouldOpen);
			office.IsOpen.Value = shouldOpen;
			office.Level.Value = 1;
			office.Exp.Value = 0;
			office.Employees = new System.Collections.Generic.List<EmployeeData>();
			// No company assigned, no employees — player does this via tutorial

			stageData.Offices[i] = office;
		}

		// Companies available for contract (player picks from list)
		stageData.UnLockCompanyList.Add(1);
		stageData.CompanyList.Add(1);
		stageData.CompanyList.Add(2);
		stageData.CompanyList.Add(3);

		Debug.Log("[GameRoot] Initial state: 1 empty office open, $38800, Level 0 — tutorial will guide");
	}

	private void InitSubSystems()
	{
		// Systems that need UserData to be loaded first
		ShopSystem = new ShopSystem();
		ShopSystem.Init();

		CompanySystem = new CompanySystem();
		CompanySystem.Init();

		RentalFeeSystem = new RentalFeeSystem();
		RentalFeeSystem.Init();

		MissionSystem = new MissionSystem();
		MissionSystem.Init();

		// EmployeeMoodSystem is MonoBehaviour — find it in scene or create on GameRoot
		MoodSystem = GetComponentInChildren<EmployeeMoodSystem>(true);
		if (MoodSystem == null)
		{
			var moodObj = new GameObject("EmployeeMoodSystem");
			moodObj.transform.SetParent(transform);
			MoodSystem = moodObj.AddComponent<EmployeeMoodSystem>();
		}
		MoodSystem.Init();
		ElectricWorkSystem = new ElectricWorkSystem();
		ElectricWorkSystem.Init();

		ContentsOpenSystem = new ContentsOpenSystem();
		ContentsOpenSystem.Init();

		RouletteSystem = new RouletteSystem();
		RouletteSystem.Init();
		MassengerSystem = new MassengerSystem();
		MassengerSystem.Init();
		PlantSystem = new PlantSystem();
		PlantSystem.Init();
		DailyQuestSystem = new DailyQuestSystem();
		DailyQuestSystem.Init();
		InfraSystem = new InfraSystem();
		InfraSystem.Init();
		FactorySystem = new FactorySystem();
		FactorySystem.Init();

		InvestSystem = new InvestSystem();
		InvestSystem.Init();
		OneTimeEventSystem = new OneTimeEventSystem();
		OneTimeEventSystem.Init();
		TutorialSystem = new TutorialSystem();
		TutorialSystem.Init();
		AdSupplySystem = new AdSupplySystem();
		AdSupplySystem.Init();

		ABTestSystem = new ABTestSystem();
		ABTestSystem.Init();
		SeasonalSystem = new SeasonalSystem();
		SeasonalSystem.Init();
		TarotSystem = new TarotSystem();
		TarotSystem.Init();
		AuctionSystem = new AuctionSystem();
		AuctionSystem.Init();
		SpecialDaySystem = new SpecialDaySystem();
		SpecialDaySystem.Init();
		RichAchieveSystem = new RichAchieveSystem();
		RichAchieveSystem.Init();
		StrikeSystem = new StrikeSystem();
		StrikeSystem.Init();
		AttendanceSystem = new AttendanceSystem();
		ContentsMissionSystem = new ContentsMissionSystem();
		BizAcqBattleSystem = new BizAcqBattleSystem();
		BizAcqBattleSystem.InitSystem();
		SubMissionSystem = new SubMissionSystem();
		SubMissionSystem.Init();
		AdPassSystem = new AdPassSystem();
		AdPassSystem.Init();
		MiniGameSystem = new MiniGameSystem();
		MiniGameSystem.InitSystem();
		InterstitialSystem = new InterstitialSystem();
		InterstitialSystem.InitSystem();
		FreecashSystem = new FreecashSystem();
		UserSegmentSystem = new UserSegmentSystem();
		PluginSystem = new PluginSystem();
		PluginSystem.Init();
		RankSystem = new RankingSystem();
		RankSystem.Init();
	}

	private void GiveBackHouseAddPoint()
	{
		if (AbilitySystem != null)
			AbilitySystem.UpdateAbility();
	}

	private void InitUILoading()
	{
		Loading = GetComponentInChildren<LoadingBasic>(true);
		RenovateLoading = GetComponentInChildren<LoadingRenovate>(true);
		ChapterLoading = GetComponentInChildren<LoadingNextChapter>(true);
		SeasonalLoading = GetComponentInChildren<LoadingSeasonal>(true);
	}

	private void InitRequestAtlas()
	{
		if (!requestAtlas)
		{
			requestAtlas = true;
			SpriteAtlasManager.atlasRequested += OnAtlasRequest;
		}
	}

	private void InitLastVersionCheck()
	{
		isLastVersionCheck = false;
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
		// TODO
	}

	public void ChangeGameType(GameType type, bool changeData = false, Action callBackAction = null, bool isForce = false)
	{
		if (CurGameType == type && !isForce)
		{
			callBackAction?.Invoke();
			return;
		}
		CurGameType = type;
		if (InGameSystem != null)
			InGameSystem.ChangeMode(type, callBackAction);
	}

	private void SetNativeLanguage()
	{
		// Update display
	}

	public void SetCheatWindow(bool value)
	{
		if (CheatWindow != null)
			CheatWindow.SetActive(value);
	}

	public void RemoveDelayAdTimeContents()
	{
		if (AdsContentsList != null)
			AdsContentsList.RemoveAll(x => x == null);
	}

	[IteratorStateMachine(typeof(_003CwaitEndFrame_003Ed__266))]
	private IEnumerator waitEndFrame(Action callback)
	{
		yield return new WaitForEndOfFrame();
		callback?.Invoke();
	}

	[IteratorStateMachine(typeof(_003CwaitTimeAndCallback_003Ed__267))]
	private IEnumerator waitTimeAndCallback(float time, Action callback)
	{
		yield return new WaitForSeconds(time);
		callback?.Invoke();
	}

	[IteratorStateMachine(typeof(_003CwaitCustomYieldInstruction_003Ed__268))]
	private IEnumerator waitCustomYieldInstruction(CustomYieldInstruction cyi, Action callback)
	{
		yield return cyi;
		callback?.Invoke();
	}

	[IteratorStateMachine(typeof(_003CwaitStageAndCallback_003Ed__269))]
	private IEnumerator waitStageAndCallback(float time, Action callback)
	{
		yield return new WaitForSeconds(time);
		callback?.Invoke();
	}

	[IteratorStateMachine(typeof(_003CwaitAndOpenUICoroutine_003Ed__270<>))]
	private IEnumerator waitAndOpenUICoroutine<T>(Action<T> OnLoad = null, Action OnClose = null, bool caching = true, int targetEventStage = -1) where T : UIBase
	{
		yield return null;
		OnLoad?.Invoke(default(T));
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
		var hud = GetHUDBase();
		if (hud != null)
			hud.Refresh(refreshType);
	}

	public Vector3 GetRewardEndPos(HUDBase.E_HUDPosType type, int rewardType = 0, int rewardIdx = 0)
	{
		var hud = GetHUDBase();
		if (hud != null)
			return hud.GetHUDPos(type, rewardType, rewardIdx);
		return default(Vector3);
	}

	private HUDBase GetHUDBase()
	{
		if (HUDUITrans != null)
			return HUDUITrans.GetComponentInChildren<HUDBase>();
		return null;
	}

	public Vector3 GetRewardEndPos(int rewardType, int rewardIdx, bool ispopup = false)
	{
		return GetRewardEndPos(HUDBase.E_HUDPosType.RentalFee, rewardType, rewardIdx);
	}

	private void CheckHeartBeat()
	{
		logStageTime += Time.unscaledDeltaTime;
		logSeasonalTime += Time.unscaledDeltaTime;
	}

	public void SetUserSegmentType(SegmentType type)
	{
		if (UserData != null) UserData.UserSegmentType = type;
	}

	public void CheatCall_OnApplicationPause(bool bPause)
	{
		OnApplicationPause(bPause);
	}

	private void OnApplicationPause(bool pause)
	{
		if (pause)
		{
			if (UserData != null)
				UserData.Save();
			if (GameNotification != null)
				GameNotification.ClearAllScheduledCategories();
		}
		else
		{
			while (PauseActions != null && PauseActions.Count > 0)
			{
				var action = PauseActions.Dequeue();
				action?.Invoke();
			}
		}
	}

	private bool ForceUpdateByAppVersion(out bool ishard)
	{
		ishard = default(bool);
		return false;
	}

	public void ConvertUserData()
	{
		if (UserData != null)
			UserData.Save();
	}

	public bool IsAnyLoadingActive()
	{
		if (Loading != null && Loading.gameObject.activeSelf) return true;
		if (RenovateLoading != null && RenovateLoading.gameObject.activeSelf) return true;
		if (ChapterLoading != null && ChapterLoading.gameObject.activeSelf) return true;
		if (SeasonalLoading != null && SeasonalLoading.gameObject.activeSelf) return true;
		return false;
	}
}
