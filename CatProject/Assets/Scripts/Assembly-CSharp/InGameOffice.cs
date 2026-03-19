using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class InGameOffice : InGameMode
{
	[CompilerGenerated]
	private sealed class _003CWaitAllWorkOff_Coroutine_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InGameOffice _003C_003E4__this;

		public Action Cb;

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
		public _003CWaitAllWorkOff_Coroutine_003Ed__57(int _003C_003E1__state)
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
	private Transform CharacterRoot;

	[SerializeField]
	private AssetReference CharacterPref;

	[SerializeField]
	private AssetReference AdsupplyVipPref;

	[SerializeField]
	private AssetReference NightSkipPref;

	[SerializeField]
	private AssetReference CeoPref;

	[SerializeField]
	private AssetReference EngineerPref;

	[SerializeField]
	private AssetReference SecretaryPref;

	[SerializeField]
	private AssetReference ManagerPref;

	[SerializeField]
	private AssetReference BizAcqStagePref;

	[HideInInspector]
	public AdSupplyVIP AdsupplyMoneyVip;

	[HideInInspector]
	public NightSkipVIP NightSkipVip;

	[HideInInspector]
	public CEO Ceo;

	[HideInInspector]
	public Secretary Secretary;

	private List<Engineer> EngineerList;

	private int CurEngineerCount;

	private List<BuffObjectComponent> buffObjects;

	private List<Employee> EmployeeList;

	private Dictionary<int, int> CurEmployeeCnt;

	private List<Manager> ManagerList;

	private InGameOfficeStage stage;

	public MoneyFxPool MoneyFxPool;

	public Subject<bool> OnAllLoadComplete;

	public List<BuffObjectComponent> BuffObjects { get { return buffObjects; } }

	public InGameOfficeStage Stage { get { return stage; } }

	public BizAcqStage BizAcqStage { get; private set; }

	public bool IsBizAcqMode { get; private set; }

	// Runtime HUD state (IMGUI-based, no font dependencies)
	private string hudMoney = "$ 38,800";
	private string hudIncome = "";
	private string hudLevel = "Lv.0";
	private string hudTime = "09:00";
	private float levelUpDisplayTime;
	private int levelUpNewLevel;
	private string unlockText;

	// === TUTORIAL SYSTEM ===
	private enum TutorialStep
	{
		// --- Pre-game sequence (fullscreen overlays) ---
		ChooseCEO,         // 2D: "What do I look like? Choose!" + left/right CEO select
		EnterName,         // "Give Name" input
		PhoneCall,         // Chairman office + phone ringing
		SecretaryCall,     // Secretary Pepper dialogue
		TransitionToOffice,// Fade to 3D office
		// --- In-office tutorial ---
		Welcome,           // "Welcome! I'll help you manage..."
		TapOffice,         // "Tap Office Room 101"
		OfficePanelOpen,   // Buy Desk panel
		BuyingDesks,       // Buying 4 desks
		SearchCompany,     // "Search for Companies"
		CompanyList,       // Company selection
		ContractSigned,    // "Contract signed!"
		EmployeesWorking,  // Employees arrived
		TutorialDone       // Free play
	}
	private bool tutAutoPlay = true; // Auto-advance for testing
	private TutorialStep tutStep = TutorialStep.ChooseCEO;
	private float tutTimer;
	private string tutDialogue = "";
	private int desksOwned;
	private bool officePanelOpen;
	private bool companyListOpen;
	private int selectedCompanyIdx;
	private string[] companyNames = { "Catpedia", "CATSEGAE", "CatTarot", "CaiotGames", "MewTube" };
	private int[] companyRents = { 182, 164, 195, 148, 210 };
	// CEO selection
	private int ceoTypeIdx; // 0, 1, 2
	private string[] ceoTypeNames = { "Business Cat", "Cool Cat", "Cute Cat" };
	// Use Employee character prefabs for CEO preview (CEO prefabs have broken sprite atlas refs)
	private string[] ceoPrefabKeys = { "Character/Employee_0", "Character/Employee_2", "Character/Employee_4" };
	private GameObject ceoPreviewInstance;
	private int ceoPreviewLoadedIdx = -1;
	private string playerName = "";
	private bool nameInputActive;
	// Dialogue sequence
	private int dialogueIdx;
	private string[] chairmanLines = {
		"Oh, Pepper! The new CEO I mentioned\nlast time will get there soon.",
		"Don't judge a book by its cover — and\nmake sure to give that fellow as much\nhelp as you can! Meow!"
	};
	private string[] secretaryLines = {
		"Yes, of course.",
		"Sir, it's Pepper.",
		"I'm your secretary, and I'll help you\nmanage your real estate properties.\nMeow~"
	};
	private float unlockDisplayTime;
	private CompositeDisposable hudDisposables;
	private GUIStyle hudStyleLarge;
	private GUIStyle hudStyleSmall;
	private GUIStyle hudStylePopup;
	// Floating income popup
	private struct IncomePopup { public float y; public float alpha; public string text; public float time; }
	private List<IncomePopup> incomePopups = new List<IncomePopup>();
	private float lastIncomeTime;

	private void Start()
	{
		// Auto-bootstrap: if GameRoot doesn't exist (running InGameOffice scene directly),
		// create it and initialize the full game stack
		var root = Singleton<GameRoot>.Instance;
		if (root == null)
		{
			Debug.Log("[InGameOffice] No GameRoot found - bootstrapping from InGameOffice scene");
			var go = new GameObject("GameRoot");
			var gameRoot = go.AddComponent<GameRoot>();
			UnityEngine.Object.DontDestroyOnLoad(go);
			GameRoot.Load();
			// GameRoot.LoadGameData coroutine will eventually call InGameSystem.StartFirstGame
			// which loads this scene again - but since it's already loaded, OnSceneLoaded
			// will find this InGameOffice and call Load()/LoadUI()
		}
		else if (root.InGameSystem == null || root.InGameSystem.CurInGame == null)
		{
			// GameRoot exists but hasn't registered us yet - self-register and init
			Debug.Log("[InGameOffice] GameRoot exists but InGame not registered - self-initializing");
			if (root.InGameSystem != null)
				root.InGameSystem.RegisteInGame(this);
			Load();
			LoadUI();
		}
	}

	public override void Load()
	{
		EmployeeList = new List<Employee>();
		ManagerList = new List<Manager>();
		EngineerList = new List<Engineer>();
		CurEmployeeCnt = new Dictionary<int, int>();
		buffObjects = new List<BuffObjectComponent>();
		CurEngineerCount = 0;
		OnAllLoadComplete = new Subject<bool>();

		if (MainCamera != null)
		{
			MainCamera.backgroundColor = new Color(0.53f, 0.81f, 0.92f, 1f);
			MainCamera.clearFlags = CameraClearFlags.SolidColor;
			// Start camera far from building for CEO selection (clean background)
			if (tutStep <= TutorialStep.TransitionToOffice)
			{
				MainCamera.orthographicSize = 1.5f;
				MainCamera.transform.position = new UnityEngine.Vector3(200f, 200f, -10f);
			}
			else
			{
				MainCamera.orthographicSize = 5f;
				MainCamera.transform.position = new UnityEngine.Vector3(-4f, 8f, -10f);
			}
			Debug.Log("[InGameOffice] Camera set: ortho=6, pos=(-2,7,-10)");
		}

		// Find stage prefab instance in scene
		stage = FindObjectOfType<InGameOfficeStage>();
		Debug.Log("[InGameOffice] Load complete. Stage found: " + (stage != null));

		// Initialize stage with game data
		if (stage != null)
		{
			StartCoroutine(stage.Set(() =>
			{
				Debug.Log("[InGameOffice] Stage.Set complete");

				// During tutorial, hide CEO and Secretary (they're too prominent)
				if (tutStep != TutorialStep.TutorialDone)
				{
					if (Ceo != null) Ceo.gameObject.SetActive(false);
					if (Secretary != null) Secretary.gameObject.SetActive(false);
				}

				if (OnAllLoadComplete != null)
					OnAllLoadComplete.OnNext(true);
			}));
		}
	}


	public BuffObjectComponent GetBuffObject(int idx)
	{
		if (buffObjects == null) return null;
		for (int i = 0; i < buffObjects.Count; i++)
		{
			if (buffObjects[i] != null && buffObjects[i].BuffObjectIdx == idx)
				return buffObjects[i];
		}
		return null;
	}

	public void AddBuffObject(BuffObjectComponent component)
	{
		if (buffObjects != null && component != null)
			buffObjects.Add(component);
	}

	public void RemoveBuffObject(BuffObjectComponent component)
	{
		if (buffObjects != null && component != null)
			buffObjects.Remove(component);
	}

	public void UpdateStatues()
	{
		if (EmployeeList == null) return;
		for (int i = 0; i < EmployeeList.Count; i++)
		{
			if (EmployeeList[i] != null)
				EmployeeList[i].gameObject.SetActive(true);
		}
	}

	// Direct prefab paths (bypasses broken Addressables)
	private static readonly Dictionary<string, string> PrefabPaths = new Dictionary<string, string>
	{
		{ "Employee", "Assets/Arts/Prefabs/Ingame/Employee.prefab" },
		{ "Ceo", "Assets/Arts/Prefabs/Ingame/Ceo.prefab" },
		{ "Engineer", "Assets/Arts/Prefabs/Ingame/Engineer.prefab" },
		{ "Secretary", "Assets/Arts/Prefabs/Ingame/Secretary.prefab" },
		{ "Manager", "Assets/Arts/Prefabs/Ingame/Manager.prefab" },
	};

	private GameObject LoadPrefabDirect(string prefabKey, Transform parent)
	{
		if (!PrefabPaths.TryGetValue(prefabKey, out string path)) return null;
		var prefab = AddressableShim.LoadAsset<GameObject>(path);
		if (prefab != null)
		{
			var go = Instantiate(prefab, parent);
			Debug.Log($"[InGameOffice] Loaded {prefabKey} from {path}");
			return go;
		}
		Debug.LogWarning($"[InGameOffice] Failed to load {prefabKey} from {path}");
		return null;
	}

	public void LoadAdsupplyVip(Action<AdSupplyVIP> CompCb)
	{
		// AdSupplyVIP not critical for basic gameplay - skip
		CompCb?.Invoke(null);
	}

	public void LoadNightSkip(Action<NightSkipVIP> CompCb)
	{
		// NightSkipVIP not critical for basic gameplay - skip
		CompCb?.Invoke(null);
	}

	public void LoadBizAcqStage(Action compCb, bool isActive)
	{
		// BizAcq stage loaded on demand
		compCb?.Invoke();
	}

	public void MoveBizAcqStage(Action compCb)
	{
		IsBizAcqMode = true;
		if (BizAcqStage != null)
			BizAcqStage.gameObject.SetActive(true);
		compCb?.Invoke();
	}

	public void ReturnBizAcqStage()
	{
		IsBizAcqMode = false;
		if (BizAcqStage != null)
			BizAcqStage.gameObject.SetActive(false);
	}

	public void ReturnEmployees(bool clearEmployeeList = false)
	{
		if (EmployeeList == null) return;
		for (int i = EmployeeList.Count - 1; i >= 0; i--)
		{
			if (EmployeeList[i] != null)
				EmployeeList[i].Return();
		}
		if (clearEmployeeList)
			EmployeeList.Clear();
	}

	public void ReturnAllEmployee()
	{
		ReturnEmployees(true);
		if (ManagerList != null)
		{
			for (int i = ManagerList.Count - 1; i >= 0; i--)
			{
				if (ManagerList[i] != null)
					ManagerList[i].Return();
			}
			ManagerList.Clear();
		}
	}

	public void LoadEmployee(int office, int seat, Worker.E_AppearType appearType, int order, Action CompCb)
	{
		var go = LoadPrefabDirect("Employee", CharacterRoot);
		if (go != null)
		{
			var employee = go.GetComponent<Employee>();
			if (employee != null)
			{
				employee.Init(office, seat, appearType, order);
				EmployeeList.Add(employee);
				if (!CurEmployeeCnt.ContainsKey(office)) CurEmployeeCnt[office] = 0;
				CurEmployeeCnt[office]++;

				// Position at desk seat FIRST
				if (stage != null && office < stage.OfficeRoomCount)
				{
					var seatTrans = stage.GetOfficeSeat(office, seat);
					if (seatTrans != null)
						go.transform.position = seatTrans.position;
				}

				// Load character sprite model
				int viewIdx = seat % 8;
				employee.LoadChar(viewIdx, null);
				Debug.Log($"[InGameOffice] Employee o={office} s={seat} pos={go.transform.position}");
			}
		}
		CompCb?.Invoke();
	}

	public void LoadCeo(Worker.E_AppearType appearType, int order, Action CompCb)
	{
		var go = LoadPrefabDirect("Ceo", CharacterRoot);
		if (go != null)
		{
			Ceo = go.GetComponent<CEO>();
			// Disable Animator to prevent crash (sprite atlas refs broken)
			var ani = go.GetComponent<Animator>();
			if (ani != null) ani.enabled = false;
			// Hide during tutorial
			if (tutStep != TutorialStep.TutorialDone)
				go.SetActive(false);
		}
		CompCb?.Invoke();
	}

	public void LoadSecretary(Worker.E_AppearType appearType, int order, Action CompCb)
	{
		var go = LoadPrefabDirect("Secretary", CharacterRoot);
		if (go != null)
		{
			Secretary = go.GetComponent<Secretary>();
			var ani = go.GetComponent<Animator>();
			if (ani != null) ani.enabled = false;
			if (tutStep != TutorialStep.TutorialDone)
				go.SetActive(false);
		}
		CompCb?.Invoke();
	}

	public void LoadEngineer(int seat, int order, Worker.E_AppearType appearType, Action CompCb)
	{
		var go = LoadPrefabDirect("Engineer", CharacterRoot);
		if (go != null)
		{
			var engineer = go.GetComponent<Engineer>();
			if (engineer != null)
			{
				EngineerList.Add(engineer);
				CurEngineerCount++;
			}
		}
		CompCb?.Invoke();
	}

	public void LoadManager(int managerIdx, int officeIdx, int order, Worker.E_AppearType appearType, Action CompCb = null)
	{
		var go = LoadPrefabDirect("Manager", CharacterRoot);
		if (go != null)
		{
			var manager = go.GetComponent<Manager>();
			if (manager != null)
				ManagerList.Add(manager);
		}
		CompCb?.Invoke();
	}

	public bool HaveToLoadChar()
	{
		if (EmployeeList == null) return false;
		return EmployeeList.Count > 0;
	}

	public bool HaveToLoadChar(int office_idx)
	{
		if (EmployeeList == null) return false;
		for (int i = 0; i < EmployeeList.Count; i++)
		{
			if (EmployeeList[i] != null && EmployeeList[i].OfficeIdx == office_idx)
				return true;
		}
		return false;
	}

	public int GetOfficeCatCount(int office)
	{
		if (CurEmployeeCnt != null && CurEmployeeCnt.TryGetValue(office, out int cnt))
			return cnt;
		return 0;
	}

	public void WorkOffStartBus()
	{
		WorkOffEmployee();
	}

	public void WorkStartEmployee(int office)
	{
		if (EmployeeList == null) return;
		for (int i = 0; i < EmployeeList.Count; i++)
		{
			if (EmployeeList[i] != null && EmployeeList[i].OfficeIdx == office)
				EmployeeList[i].WorkStart();
		}
	}

	public void WaitAllWorkOff(Action Cb)
	{
		StartCoroutine(WaitAllWorkOff_Coroutine(Cb));
	}

	[IteratorStateMachine(typeof(_003CWaitAllWorkOff_Coroutine_003Ed__57))]
	private IEnumerator WaitAllWorkOff_Coroutine(Action Cb)
	{
		yield return new WaitForSeconds(1.0f);
		Cb?.Invoke();
	}

	public void WorkOffEmployee()
	{
		if (EmployeeList == null) return;
		for (int i = 0; i < EmployeeList.Count; i++)
		{
			if (EmployeeList[i] != null)
				EmployeeList[i].WorkOut(i);
		}
	}

	public void CompanyOutEmployee(int office, bool isListPage)
	{
		if (EmployeeList == null) return;
		for (int i = EmployeeList.Count - 1; i >= 0; i--)
		{
			if (EmployeeList[i] != null && EmployeeList[i].OfficeIdx == office)
			{
				EmployeeList[i].WorkOut(i, true);
			}
		}
	}

	public List<Employee> GetEmployees(int office = -1)
	{
		if (EmployeeList == null) return null;
		if (office < 0) return EmployeeList;
		var result = new List<Employee>();
		for (int i = 0; i < EmployeeList.Count; i++)
		{
			if (EmployeeList[i] != null && EmployeeList[i].OfficeIdx == office)
				result.Add(EmployeeList[i]);
		}
		return result;
	}

	public int GetEngineerCount()
	{
		return CurEngineerCount;
	}

	public Engineer GetEngineer(int seat)
	{
		if (EngineerList == null) return null;
		for (int i = 0; i < EngineerList.Count; i++)
		{
			if (EngineerList[i] != null && EngineerList[i].SeatIdx == seat)
				return EngineerList[i];
		}
		return null;
	}

	public List<Engineer> GetEngineers()
	{
		return EngineerList;
	}

	public void RemoveSecretary()
	{
		if (Secretary != null)
		{
			Secretary.Return();
			Secretary = null;
		}
	}

	public void WorkOffManager(int managerIdx)
	{
		if (ManagerList == null) return;
		for (int i = ManagerList.Count - 1; i >= 0; i--)
		{
			if (ManagerList[i] != null && ManagerList[i].ManagerIdx == managerIdx)
			{
				ManagerList[i].WorkOut(i, false);
				ManagerList.RemoveAt(i);
				break;
			}
		}
	}

	public override void UnLoad()
	{
		UnLoadChar();
		if (buffObjects != null) buffObjects.Clear();
		if (OnAllLoadComplete != null) OnAllLoadComplete.Dispose();
	}

	public void UnLoadChar()
	{
		ReturnAllEmployee();
		RemoveSecretary();
		if (EngineerList != null)
		{
			for (int i = 0; i < EngineerList.Count; i++)
			{
				if (EngineerList[i] != null)
					EngineerList[i].Return();
			}
			EngineerList.Clear();
		}
		CurEngineerCount = 0;
		if (Ceo != null)
		{
			Ceo.Return();
			Ceo = null;
		}
	}

	private bool useIMGUI = true;
	private GameObject hudTotalInstance;
	private HUDTotal hudTotalComp;

	public override void LoadUI()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root != null)
		{
			var hudPrefab = AddressableShim.LoadAsset<GameObject>("Assets/Arts/Prefabs/HUD/HUDTotal.prefab");
			if (hudPrefab != null)
			{
				hudTotalInstance = Instantiate(hudPrefab);
				hudTotalInstance.name = "HUDTotal";
				DontDestroyOnLoad(hudTotalInstance);

				// Ensure Canvas is set up for overlay rendering
				var canvas = hudTotalInstance.GetComponent<Canvas>();
				if (canvas != null)
				{
					canvas.renderMode = RenderMode.ScreenSpaceOverlay;
					canvas.sortingOrder = 100;
				}
				var scaler = hudTotalInstance.GetComponent<UnityEngine.UI.CanvasScaler>();
				if (scaler == null) scaler = hudTotalInstance.AddComponent<UnityEngine.UI.CanvasScaler>();
				scaler.uiScaleMode = UnityEngine.UI.CanvasScaler.ScaleMode.ScaleWithScreenSize;
				scaler.referenceResolution = new UnityEngine.Vector2(750, 1334);
				scaler.matchWidthOrHeight = 0.5f;

				// Get the HUDTotal component (should be on the prefab root from serialization)
				hudTotalComp = hudTotalInstance.GetComponent<HUDTotal>();
				if (hudTotalComp != null)
				{
					// Initialize the HUD with game data
					try
					{
						hudTotalComp.OnShowBefore();
						Debug.Log("[InGameOffice] HUDTotal component initialized via OnShowBefore()");
					}
					catch (System.Exception ex)
					{
						Debug.LogWarning($"[InGameOffice] HUDTotal.OnShowBefore() error (non-fatal): {ex.Message}");
					}
					useIMGUI = false;
				}
				else
				{
					Debug.LogWarning("[InGameOffice] HUDTotal component not found on prefab - using IMGUI fallback");
				}

				// Log sprite status for debugging
				var images = hudTotalInstance.GetComponentsInChildren<UnityEngine.UI.Image>(true);
				int validImages = 0;
				for (int i = 0; i < images.Length; i++)
				{
					if (images[i].sprite != null) validImages++;
				}
				Debug.Log($"[InGameOffice] HUDTotal: {images.Length} Images, {validImages} with sprites, useIMGUI={useIMGUI}");
			}
		}
		SubscribeToGameSystems();

		Debug.Log("[InGameOffice] LoadUI complete, useIMGUI=" + useIMGUI);
	}

	private void OnGUI()
	{
		// Always draw tutorial UI (even when UGUI HUD active)
		if (tutStep != TutorialStep.TutorialDone)
			DrawTutorialGUI();

		if (!useIMGUI) return; // Real HUD loaded, skip IMGUI
		if (hudStyleLarge == null)
		{
			hudStyleLarge = new GUIStyle(GUI.skin.label);
			hudStyleLarge.fontSize = 22;
			hudStyleLarge.fontStyle = FontStyle.Bold;
			hudStyleSmall = new GUIStyle(GUI.skin.label);
			hudStyleSmall.fontSize = 14;
			hudStylePopup = new GUIStyle(GUI.skin.label);
			hudStylePopup.fontSize = 18;
			hudStylePopup.fontStyle = FontStyle.Bold;
			hudStylePopup.alignment = TextAnchor.MiddleCenter;
		}

		float w = Screen.width;
		float h = Screen.height;

		// === TOP HUD BAR ===
		GUI.color = new Color(0.15f, 0.15f, 0.2f, 0.85f);
		GUI.DrawTexture(new Rect(0, 0, w, 70), Texture2D.whiteTexture);
		GUI.color = Color.white;

		// Money (top-left, coin icon style)
		hudStyleLarge.normal.textColor = new Color(1f, 0.85f, 0.2f);
		GUI.Label(new Rect(15, 5, 300, 30), hudMoney, hudStyleLarge);

		// Income rate (below money)
		hudStyleSmall.normal.textColor = new Color(0.5f, 1f, 0.5f);
		GUI.Label(new Rect(15, 35, 300, 25), hudIncome, hudStyleSmall);

		// Level (center)
		hudStyleSmall.normal.textColor = Color.white;
		hudStyleSmall.alignment = TextAnchor.MiddleCenter;
		GUI.Label(new Rect(w / 2 - 50, 5, 100, 25), hudLevel, hudStyleSmall);
		hudStyleSmall.alignment = TextAnchor.MiddleLeft;

		// Time + Day status (top-right)
		hudStyleLarge.normal.textColor = new Color(0.7f, 0.9f, 1f);
		hudStyleLarge.alignment = TextAnchor.MiddleRight;
		GUI.Label(new Rect(w - 160, 5, 145, 30), hudTime, hudStyleLarge);
		hudStyleLarge.alignment = TextAnchor.MiddleLeft;

		// === BOTTOM NAV BAR ===
		GUI.color = new Color(0.15f, 0.15f, 0.2f, 0.85f);
		GUI.DrawTexture(new Rect(0, h - 50, w, 50), Texture2D.whiteTexture);
		GUI.color = Color.white;
		hudStyleSmall.normal.textColor = Color.white;
		hudStyleSmall.alignment = TextAnchor.MiddleCenter;
		float btnW = w / 5;
		string[] navLabels = { "Office", "Company", "Shop", "Mission", "More" };
		for (int i = 0; i < navLabels.Length; i++)
		{
			GUI.Label(new Rect(i * btnW, h - 45, btnW, 40), navLabels[i], hudStyleSmall);
		}
		hudStyleSmall.alignment = TextAnchor.MiddleLeft;

		// === FLOATING INCOME POPUPS ===
		for (int i = incomePopups.Count - 1; i >= 0; i--)
		{
			var popup = incomePopups[i];
			hudStylePopup.normal.textColor = new Color(0.2f, 1f, 0.3f, popup.alpha);
			float px = w * 0.3f + (i % 3) * 80;
			float py = h * 0.4f - popup.y;
			GUI.Label(new Rect(px, py, 200, 30), popup.text, hudStylePopup);
		}

		// === LEVEL UP DISPLAY ===
		if (levelUpDisplayTime > 0)
		{
			float alpha = Mathf.Clamp01(levelUpDisplayTime);
			var lvStyle = new GUIStyle(GUI.skin.label);
			lvStyle.fontSize = 36;
			lvStyle.fontStyle = FontStyle.Bold;
			lvStyle.alignment = TextAnchor.MiddleCenter;
			lvStyle.normal.textColor = new Color(1f, 0.85f, 0.1f, alpha);
			GUI.Label(new Rect(0, h * 0.3f, w, 50), "LEVEL UP!", lvStyle);
			lvStyle.fontSize = 24;
			lvStyle.normal.textColor = new Color(1f, 1f, 1f, alpha);
			GUI.Label(new Rect(0, h * 0.3f + 50, w, 35), "Lv." + levelUpNewLevel, lvStyle);
		}

		// === UNLOCK TEXT ===
		if (unlockDisplayTime > 0)
		{
			float alpha = Mathf.Clamp01(unlockDisplayTime);
			var ulStyle = new GUIStyle(GUI.skin.label);
			ulStyle.fontSize = 20;
			ulStyle.fontStyle = FontStyle.Bold;
			ulStyle.alignment = TextAnchor.MiddleCenter;
			ulStyle.normal.textColor = new Color(0.3f, 1f, 0.5f, alpha);
			GUI.Label(new Rect(0, h * 0.45f, w, 30), unlockText, ulStyle);
		}
	}

	private void SubscribeToGameSystems()
	{
		hudDisposables = new CompositeDisposable();
		var root = Singleton<GameRoot>.Instance;
		if (root == null) return;

		// Subscribe to money changes
		if (root.UserData != null && root.UserData.HUDMoney != null)
		{
			root.UserData.HUDMoney
				.Subscribe(val => { hudMoney = "$ " + FormatBigNumber(val); })
				.AddTo(hudDisposables);
		}

		// Subscribe to rental fee (income per period)
		if (root.RentalFeeSystem != null)
		{
			if (root.RentalFeeSystem.RentalFeeValue != null)
			{
				root.RentalFeeSystem.RentalFeeValue
					.Subscribe(val =>
					{
						int time = (root.RentalFeeSystem.RunTimeGetMoneyTime != null)
							? root.RentalFeeSystem.RunTimeGetMoneyTime.Value : 10;
						hudIncome = "Income: $" + FormatBigNumber(val) + " / " + time + "s";
					})
					.AddTo(hudDisposables);
			}

			// Subscribe to RuntimeRentalFeeValue to add to HUDMoney + spawn popup
			if (root.RentalFeeSystem.RuntimeRentalFeeValue != null)
			{
				root.RentalFeeSystem.RuntimeRentalFeeValue
					.Subscribe(val =>
					{
						if (val > BigInteger.Zero && root.UserData != null && root.UserData.HUDMoney != null)
						{
							root.UserData.HUDMoney.Value += val;
							// Grant XP from income
							int xpGain = System.Math.Max(1, (int)val); // 1:1 income to XP
							root.UserData.AddExp(xpGain);

							// IMGUI popup
							if (incomePopups != null)
							{
								incomePopups.Add(new IncomePopup
								{
									y = 0, alpha = 1f,
									text = "+" + FormatBigNumber(val),
									time = 0
								});
							}
							// UGUI earn toast
							if (hudTotalComp != null)
							{
								hudTotalComp.ShowEarnToast();
								hudTotalComp.UpdateRentalFeeProgress(0f);
							}
							root.RentalFeeSystem.RuntimeRentalFeeValue.Value = BigInteger.Zero;
							Debug.Log($"[InGameOffice] Income applied: +{val}, total money now={root.UserData.HUDMoney.Value}");
						}
					})
					.AddTo(hudDisposables);
			}
		}

		// Subscribe to level changes — update display + refresh HUD buttons
		if (root.UserData != null && root.UserData.Level != null)
		{
			root.UserData.Level
				.Subscribe(val =>
				{
					hudLevel = "Lv." + val;
					if (val > 1)
					{
						levelUpDisplayTime = 3f;
						levelUpNewLevel = val;
					}
					// Refresh UGUI HUD button visibility
					if (hudTotalComp != null)
						hudTotalComp.RefreshFeatureGating();
				})
				.AddTo(hudDisposables);
		}

		// Subscribe to XP for display
		if (root.UserData != null && root.UserData.Exp != null)
		{
			root.UserData.Exp
				.Subscribe(val =>
				{
					int nextLevelExp = UserDataSystem.GetExpForLevel(root.UserData.Level.Value + 1);
					hudLevel = "Lv." + root.UserData.Level.Value + " (" + val + "/" + nextLevelExp + ")";
				})
				.AddTo(hudDisposables);
		}

		// Subscribe to day time - update every frame in Update instead
		// Calculate initial rental fee
		if (root.RentalFeeSystem != null)
		{
			root.RentalFeeSystem.CalculateRentalFee();
		}

		Debug.Log("[InGameOffice] Subscribed to game systems");
	}

	protected override void Update()
	{
		base.Update();
		var root = Singleton<GameRoot>.Instance;
		if (root == null) return;

		// === TUTORIAL STATE MACHINE ===
		UpdateTutorial(root);

		// Update time display
		if (root.DaySystem != null)
		{
			int hour = (int)root.DaySystem.DayTime;
			int min = (int)((root.DaySystem.DayTime - hour) * 60);
			var status = root.DaySystem.CurTimeStatus != null ? root.DaySystem.CurTimeStatus.Value : DaySystem.DayStatus.NotSet;
			hudTime = hour.ToString("D2") + ":" + min.ToString("D2") + " " + status;
		}

		// Update rental fee progress bar on UGUI HUD
		if (hudTotalComp != null && root.RentalFeeSystem != null)
		{
			int moneyTime = root.RentalFeeSystem.RunTimeGetMoneyTime != null
				? root.RentalFeeSystem.RunTimeGetMoneyTime.Value : 10;
			if (moneyTime > 0)
			{
				float progress = root.RentalFeeSystem.DeltaTime / moneyTime;
				hudTotalComp.UpdateRentalFeeProgress(Mathf.Clamp01(progress));
			}
		}

		// Countdown level-up / unlock displays
		if (levelUpDisplayTime > 0) levelUpDisplayTime -= Time.unscaledDeltaTime;
		if (unlockDisplayTime > 0) unlockDisplayTime -= Time.unscaledDeltaTime;

		// Animate income popups (IMGUI fallback)
		if (incomePopups != null)
		{
			float dt = Time.unscaledDeltaTime;
			for (int i = incomePopups.Count - 1; i >= 0; i--)
			{
				var p = incomePopups[i];
				p.time += dt;
				p.y += dt * 60f;
				p.alpha = Mathf.Max(0, 1f - p.time / 2f);
				incomePopups[i] = p;
				if (p.alpha <= 0) incomePopups.RemoveAt(i);
			}
		}
	}

	private string FormatBigNumber(BigInteger val)
	{
		if (val < 1000) return val.ToString();
		if (val < 1000000) return (val / 1000).ToString() + "K";
		if (val < 1000000000) return (val / 1000000).ToString() + "M";
		return (val / 1000000000).ToString() + "B";
	}

	private void OnDestroy()
	{
		UnLoad();
		if (hudDisposables != null)
		{
			hudDisposables.Dispose();
			hudDisposables = null;
		}
	}

	// =====================================================
	// TUTORIAL SYSTEM
	// =====================================================
	private void UpdateTutorial(GameRoot root)
	{
		try { UpdateTutorialInner(root); }
		catch (System.Exception ex) { Debug.LogWarning($"[Tutorial] Error: {ex.Message}"); }
	}

	private void UpdateTutorialInner(GameRoot root)
	{
		tutTimer += Time.deltaTime;

		// Force camera position during pre-game (PanAndZoom keeps resetting it)
		if (tutStep <= TutorialStep.SecretaryCall && MainCamera != null)
		{
			MainCamera.orthographicSize = 1.5f;
			MainCamera.transform.position = new UnityEngine.Vector3(200f, 200f, -10f);
		}
		// Auto-play mode: advance through interactive steps automatically
		if (tutAutoPlay && tutTimer > 2.5f)
		{
			var prevStep = tutStep;
			switch (tutStep)
			{
				case TutorialStep.ChooseCEO:
					playerName = "TestCEO";
					tutStep = TutorialStep.PhoneCall;
					dialogueIdx = 0;
					tutTimer = 0;
					if (ceoPreviewInstance != null) { Destroy(ceoPreviewInstance); ceoPreviewInstance = null; }
					break;
				case TutorialStep.EnterName:
					playerName = "TestCEO";
					tutStep = TutorialStep.PhoneCall;
					dialogueIdx = 0;
					tutTimer = 0;
					break;
				case TutorialStep.TapOffice:
					tutStep = TutorialStep.OfficePanelOpen;
					officePanelOpen = true;
					tutTimer = 0;
					break;
				case TutorialStep.OfficePanelOpen:
				case TutorialStep.BuyingDesks:
					desksOwned = 4;
					var r = Singleton<GameRoot>.Instance;
					if (r != null && r.UserData != null)
						r.UserData.HUDMoney.Value -= 12000; // 4 desks * $3000
					tutStep = TutorialStep.SearchCompany;
					tutDialogue = "Great! Now search for a company.";
					tutTimer = 0;
					break;
				case TutorialStep.SearchCompany:
					tutStep = TutorialStep.CompanyList;
					companyListOpen = true;
					officePanelOpen = false;
					tutTimer = 0;
					break;
				case TutorialStep.CompanyList:
					selectedCompanyIdx = 1;
					companyListOpen = false;
					tutStep = TutorialStep.ContractSigned;
					tutDialogue = "Contract signed with Catpedia!";
					tutTimer = 0;
					break;
			}
			if (prevStep != tutStep)
				Debug.Log($"[Tutorial] AutoPlay: {prevStep} -> {tutStep}");
		}

		switch (tutStep)
		{
			case TutorialStep.ChooseCEO:
				// CEO preview via IMGUI (sprite atlas refs broken)
				break;
			case TutorialStep.EnterName:
				break;
			case TutorialStep.PhoneCall:
				// Auto-advance through Chairman dialogue
				if (tutTimer > 3f)
				{
					dialogueIdx++;
					tutTimer = 0;
					if (dialogueIdx >= chairmanLines.Length)
					{
						tutStep = TutorialStep.SecretaryCall;
						dialogueIdx = 0;
					}
				}
				break;
			case TutorialStep.SecretaryCall:
				if (tutTimer > 3f)
				{
					dialogueIdx++;
					tutTimer = 0;
					if (dialogueIdx >= secretaryLines.Length)
					{
						tutStep = TutorialStep.TransitionToOffice;
						tutTimer = 0;
					}
				}
				break;
			case TutorialStep.TransitionToOffice:
				// Remove CEO preview and move camera to building
				if (ceoPreviewInstance != null)
				{
					Destroy(ceoPreviewInstance);
					ceoPreviewInstance = null;
					ceoPreviewLoadedIdx = -1;
				}
				if (MainCamera != null)
				{
					MainCamera.orthographicSize = 5f;
					MainCamera.transform.position = new UnityEngine.Vector3(-4f, 8f, -10f);
				}
				if (tutTimer > 1f)
				{
					tutStep = TutorialStep.Welcome;
					tutDialogue = "Welcome, " + (string.IsNullOrEmpty(playerName) ? "CEO" : playerName) + "!\nLet's learn about real estate management.";
					tutTimer = 0;
				}
				break;
			case TutorialStep.Welcome:
				if (tutTimer > 3f)
				{
					tutStep = TutorialStep.TapOffice;
					tutDialogue = "First, let's set up Office Room 101.\nTap on the office to begin!";
					tutTimer = 0;
				}
				break;
			case TutorialStep.TapOffice:
				// Waiting for player to click — handled in OnGUI
				break;
			case TutorialStep.OfficePanelOpen:
				tutDialogue = "You need 4 desks for employees to work.\nBuy desks to get started!";
				break;
			case TutorialStep.BuyingDesks:
				if (desksOwned >= 4)
				{
					tutStep = TutorialStep.SearchCompany;
					tutDialogue = "Great! Now search for a company to sign a contract.";
					tutTimer = 0;
				}
				break;
			case TutorialStep.SearchCompany:
				// Waiting for player click
				break;
			case TutorialStep.CompanyList:
				// Player selecting company
				break;
			case TutorialStep.ContractSigned:
				tutDialogue = "Contract signed! Employees are on their way!";
				if (tutTimer > 2f)
				{
					// Spawn employees
					SpawnTutorialEmployees(root, 0, selectedCompanyIdx);
					tutStep = TutorialStep.EmployeesWorking;
					tutDialogue = "Your employees are working!\nYou'll receive rent every 10 seconds.";
					tutTimer = 0;
					// Level up to 1
					if (root.UserData != null && root.UserData.Level != null)
						root.UserData.Level.Value = 1;
				}
				break;
			case TutorialStep.EmployeesWorking:
				if (tutTimer > 4f)
				{
					tutStep = TutorialStep.TutorialDone;
					tutDialogue = "";
					tutTimer = 0;
				}
				break;
			case TutorialStep.TutorialDone:
				break;
		}
	}

	private void SpawnTutorialEmployees(GameRoot root, int officeIdx, int companyIdx)
	{
		if (root.UserData == null) return;
		var curMode = root.UserData.CurMode;
		if (curMode == null || curMode.StageData == null) return;
		if (!curMode.StageData.Offices.TryGetValue(officeIdx, out var officeData)) return;

		// Set company on office
		officeData.CompanyIdx.Value = companyIdx;
		officeData.RentalFee = new BigInteger(companyRents[companyIdx - 1]);
		officeData.CompanyEndTime = System.DateTime.UtcNow.AddHours(3);

		// Create company data
		var company = new CompanyData(companyIdx, 1, BigInteger.Zero, false);
		company.MaxLevel = 50;
		company.Create();
		curMode.StageData.Companies.Add(company);

		// Create 4 employees
		officeData.Employees.Clear();
		for (int e = 0; e < 4; e++)
		{
			var emp = new EmployeeData();
			emp.Idx = e;
			emp.Seat = e;
			emp.ViewIdx = e;
			emp.Create();
			officeData.Employees.Add(emp);
			LoadEmployee(officeIdx, e, Worker.E_AppearType.Seat, 0, null);
		}

		// Recalculate income
		if (root.RentalFeeSystem != null)
			root.RentalFeeSystem.CalculateRentalFee();

		hudIncome = "Income: $" + companyRents[companyIdx - 1] + " / 10s";
		Debug.Log($"[Tutorial] Employees spawned for office {officeIdx}, company {companyIdx}");
	}

	private void UpdateCeoPreview()
	{
		if (ceoPreviewLoadedIdx == ceoTypeIdx) return;

		// Destroy old
		if (ceoPreviewInstance != null)
		{
			Destroy(ceoPreviewInstance);
			ceoPreviewInstance = null;
		}

		// Load character via AddressableShim (Employee chars work; CEO chars have broken atlas)
		var prefab = AddressableShim.LoadAsset<GameObject>(ceoPrefabKeys[ceoTypeIdx]);
		if (prefab != null)
		{
			ceoPreviewInstance = Instantiate(prefab);
			ceoPreviewInstance.name = "CeoPreview";
			if (MainCamera != null)
			{
				var camPos = MainCamera.transform.position;
				ceoPreviewInstance.transform.position = new UnityEngine.Vector3(camPos.x, camPos.y - 0.3f, 0f);
				ceoPreviewInstance.transform.localScale = UnityEngine.Vector3.one;
			}
			ceoPreviewInstance.SetActive(true);
			foreach (Transform child in ceoPreviewInstance.transform)
				child.gameObject.SetActive(true);

			var ani = ceoPreviewInstance.GetComponent<Animator>();
			if (ani != null)
			{
				ani.enabled = true;
				try { ani.SetBool("Hide", false); ani.Play("Idle", 0, 0); } catch { }
			}
			Debug.Log($"[Tutorial] CEO preview loaded: {ceoPrefabKeys[ceoTypeIdx]}, pos={ceoPreviewInstance.transform.position}");
		}
		else
		{
			Debug.LogWarning($"[Tutorial] Failed to load: {ceoPrefabKeys[ceoTypeIdx]}");
		}
		ceoPreviewLoadedIdx = ceoTypeIdx;
	}

	private void DrawPreGameGUI(float w, float h)
	{
		var titleStyle = new GUIStyle(GUI.skin.label);
		titleStyle.fontSize = 22;
		titleStyle.fontStyle = FontStyle.Bold;
		titleStyle.alignment = TextAnchor.MiddleCenter;
		titleStyle.normal.textColor = Color.white;

		var btnStyle = new GUIStyle(GUI.skin.button);
		btnStyle.fontSize = 16;
		btnStyle.fontStyle = FontStyle.Bold;

		var textStyle = new GUIStyle(GUI.skin.label);
		textStyle.fontSize = 16;
		textStyle.alignment = TextAnchor.MiddleCenter;
		textStyle.normal.textColor = new Color(0.15f, 0.15f, 0.15f);
		textStyle.wordWrap = true;

		if (tutStep == TutorialStep.ChooseCEO)
		{
			// --- CEO Selection Screen (IMGUI, full overlay) ---
			GUI.color = new Color(0.55f, 0.75f, 0.85f, 1f);
			GUI.DrawTexture(new Rect(0, 0, w, h), Texture2D.whiteTexture);
			GUI.color = Color.white;

			// Speech bubble
			GUI.DrawTexture(new Rect(w * 0.08f, h * 0.06f, w * 0.84f, 50), Texture2D.whiteTexture);
			titleStyle.normal.textColor = Color.black;
			titleStyle.fontSize = 18;
			GUI.Label(new Rect(0, h * 0.06f, w, 50), "What do I look like? Choose!", titleStyle);

			// Cat body (oval shape using layered rects)
			float cx = w * 0.5f;
			float cy = h * 0.38f;
			float catW = w * 0.3f;
			float catH = catW * 1.2f;
			Color[] catBodyColors = { new Color(1f, 0.72f, 0.42f), new Color(0.65f, 0.72f, 0.88f), new Color(1f, 0.82f, 0.88f) };
			Color catColor = catBodyColors[ceoTypeIdx];

			// Ears (triangles approximated with small rects)
			GUI.color = catColor;
			GUI.DrawTexture(new Rect(cx - catW * 0.4f, cy - catH * 0.45f, catW * 0.25f, catW * 0.3f), Texture2D.whiteTexture);
			GUI.DrawTexture(new Rect(cx + catW * 0.15f, cy - catH * 0.45f, catW * 0.25f, catW * 0.3f), Texture2D.whiteTexture);
			// Head
			GUI.DrawTexture(new Rect(cx - catW * 0.45f, cy - catH * 0.3f, catW * 0.9f, catW * 0.7f), Texture2D.whiteTexture);
			// Body
			GUI.DrawTexture(new Rect(cx - catW * 0.4f, cy + catW * 0.2f, catW * 0.8f, catH * 0.45f), Texture2D.whiteTexture);

			// Face details
			GUI.color = Color.black;
			float eyeY = cy - catH * 0.08f;
			GUI.DrawTexture(new Rect(cx - catW * 0.18f, eyeY, 8, 8), Texture2D.whiteTexture); // Left eye
			GUI.DrawTexture(new Rect(cx + catW * 0.1f, eyeY, 8, 8), Texture2D.whiteTexture);  // Right eye
			GUI.DrawTexture(new Rect(cx - 3, eyeY + 15, 6, 4), Texture2D.whiteTexture);       // Nose
			// Whiskers
			GUI.DrawTexture(new Rect(cx - catW * 0.4f, eyeY + 18, catW * 0.25f, 1), Texture2D.whiteTexture);
			GUI.DrawTexture(new Rect(cx + catW * 0.15f, eyeY + 18, catW * 0.25f, 1), Texture2D.whiteTexture);
			GUI.DrawTexture(new Rect(cx - catW * 0.38f, eyeY + 24, catW * 0.22f, 1), Texture2D.whiteTexture);
			GUI.DrawTexture(new Rect(cx + catW * 0.16f, eyeY + 24, catW * 0.22f, 1), Texture2D.whiteTexture);

			// Cushion under cat
			GUI.color = new Color(0.85f, 0.7f, 0.45f);
			GUI.DrawTexture(new Rect(cx - catW * 0.5f, cy + catH * 0.48f, catW, catW * 0.2f), Texture2D.whiteTexture);
			GUI.color = Color.white;

			// Cat name
			textStyle.fontSize = 16;
			textStyle.normal.textColor = Color.white;
			GUI.Label(new Rect(0, cy + catH * 0.55f, w, 25), ceoTypeNames[ceoTypeIdx], textStyle);

			// Left/Right arrows
			float arrowY = cy;
			if (GUI.Button(new Rect(w * 0.04f, arrowY, 45, 45), "<", btnStyle))
				ceoTypeIdx = (ceoTypeIdx + ceoTypeNames.Length - 1) % ceoTypeNames.Length;
			if (GUI.Button(new Rect(w * 0.96f - 45, arrowY, 45, 45), ">", btnStyle))
				ceoTypeIdx = (ceoTypeIdx + 1) % ceoTypeNames.Length;

			// Confirm button
			GUI.color = new Color(0.4f, 0.85f, 0.5f);
			if (GUI.Button(new Rect(w * 0.3f, h * 0.88f, w * 0.4f, 40), "Confirm"))
			{
				tutStep = TutorialStep.EnterName;
				tutTimer = 0;
			}
			GUI.color = Color.white;
			return;
		}
		else if (tutStep == TutorialStep.EnterName)
		{
			// --- Name Input Screen --- (full blue BG)
			GUI.color = new Color(0.55f, 0.75f, 0.85f, 1f);
			GUI.DrawTexture(new Rect(0, 0, w, h), Texture2D.whiteTexture);
			GUI.color = Color.white;
			GUI.DrawTexture(new Rect(w * 0.1f, h * 0.05f, w * 0.8f, 50), Texture2D.whiteTexture);
			titleStyle.normal.textColor = Color.black;
			titleStyle.fontSize = 18;
			GUI.Label(new Rect(0, h * 0.05f, w, 50), "What do I look like? Choose!", titleStyle);

			// Give Name panel
			float panelY = h * 0.35f;
			GUI.color = new Color(0.7f, 0.9f, 1f, 1f);
			GUI.DrawTexture(new Rect(w * 0.1f, panelY, w * 0.8f, 35), Texture2D.whiteTexture);
			GUI.color = Color.white;
			titleStyle.normal.textColor = Color.black;
			titleStyle.fontSize = 16;
			GUI.Label(new Rect(0, panelY, w, 35), "Give Name", titleStyle);

			// Input hint
			textStyle.fontSize = 14;
			textStyle.normal.textColor = new Color(0.5f, 0.5f, 0.5f);
			GUI.Label(new Rect(0, panelY + 40, w, 25), "Enter your character's name", textStyle);

			// Text input
			playerName = GUI.TextField(new Rect(w * 0.15f, panelY + 70, w * 0.55f, 30), playerName, 16);

			// OK button
			if (GUI.Button(new Rect(w * 0.72f, panelY + 70, 50, 30), "OK") && playerName.Length > 0)
			{
				tutStep = TutorialStep.PhoneCall;
				dialogueIdx = 0;
				tutTimer = 0;
			}

			// Confirm button (bottom)
			GUI.color = new Color(0.4f, 0.85f, 0.5f);
			if (GUI.Button(new Rect(w * 0.3f, h * 0.85f, w * 0.4f, 45), "Confirm") && playerName.Length > 0)
			{
				tutStep = TutorialStep.PhoneCall;
				dialogueIdx = 0;
				tutTimer = 0;
			}
			GUI.color = Color.white;
		}
		else if (tutStep == TutorialStep.PhoneCall)
		{
			// --- Chairman Office Scene ---
			// Warm office background
			GUI.color = new Color(0.85f, 0.75f, 0.65f, 1f);
			GUI.DrawTexture(new Rect(0, 0, w, h), Texture2D.whiteTexture);

			// Window (top area)
			GUI.color = new Color(0.7f, 0.85f, 1f, 1f);
			GUI.DrawTexture(new Rect(w * 0.15f, h * 0.05f, w * 0.7f, h * 0.35f), Texture2D.whiteTexture);

			// Red curtains
			GUI.color = new Color(0.7f, 0.15f, 0.15f, 0.8f);
			GUI.DrawTexture(new Rect(w * 0.05f, h * 0.02f, w * 0.15f, h * 0.45f), Texture2D.whiteTexture);
			GUI.DrawTexture(new Rect(w * 0.8f, h * 0.02f, w * 0.15f, h * 0.45f), Texture2D.whiteTexture);

			// Desk
			GUI.color = new Color(0.5f, 0.35f, 0.2f, 1f);
			GUI.DrawTexture(new Rect(w * 0.2f, h * 0.55f, w * 0.6f, h * 0.15f), Texture2D.whiteTexture);
			GUI.color = Color.white;

			// Chairman dialogue at bottom
			float barH = 90;
			float barY = h - barH;
			GUI.color = new Color(0.96f, 0.95f, 0.88f, 0.97f);
			GUI.DrawTexture(new Rect(0, barY, w, barH), Texture2D.whiteTexture);
			GUI.color = new Color(0.3f, 0.5f, 0.7f, 1f);
			GUI.DrawTexture(new Rect(0, barY + 2, 120, 26), Texture2D.whiteTexture);
			GUI.color = Color.white;
			var nameStyle = new GUIStyle(GUI.skin.label);
			nameStyle.fontSize = 13;
			nameStyle.fontStyle = FontStyle.Bold;
			nameStyle.normal.textColor = Color.white;
			GUI.Label(new Rect(8, barY + 3, 110, 24), "Chairman", nameStyle);

			textStyle.alignment = TextAnchor.UpperLeft;
			textStyle.normal.textColor = new Color(0.15f, 0.15f, 0.15f);
			int idx = Mathf.Min(dialogueIdx, chairmanLines.Length - 1);
			GUI.Label(new Rect(12, barY + 32, w - 24, barH - 38), chairmanLines[idx], textStyle);
		}
		else if (tutStep == TutorialStep.SecretaryCall)
		{
			// --- Secretary Phone Scene ---
			// Same warm background
			GUI.color = new Color(0.85f, 0.75f, 0.65f, 1f);
			GUI.DrawTexture(new Rect(0, 0, w, h), Texture2D.whiteTexture);

			// Phone display (center)
			GUI.color = new Color(0.8f, 0.9f, 1f, 1f);
			GUI.DrawTexture(new Rect(w * 0.2f, h * 0.15f, w * 0.6f, h * 0.5f), Texture2D.whiteTexture);
			GUI.color = Color.white;

			// Secretary name on phone
			textStyle.alignment = TextAnchor.MiddleCenter;
			textStyle.normal.textColor = Color.black;
			textStyle.fontSize = 16;
			GUI.Label(new Rect(0, h * 0.45f, w, 30), "Secretary Pepper", textStyle);

			// Green phone icon placeholder
			GUI.color = new Color(0.3f, 0.8f, 0.4f, 1f);
			GUI.DrawTexture(new Rect(w * 0.42f, h * 0.35f, w * 0.16f, w * 0.16f), Texture2D.whiteTexture);
			GUI.color = Color.white;

			// Dialogue bar
			float barH = 90;
			float barY = h - barH;
			GUI.color = new Color(0.96f, 0.95f, 0.88f, 0.97f);
			GUI.DrawTexture(new Rect(0, barY, w, barH), Texture2D.whiteTexture);
			GUI.color = new Color(0.35f, 0.7f, 0.5f, 1f);
			GUI.DrawTexture(new Rect(0, barY + 2, 160, 26), Texture2D.whiteTexture);
			GUI.color = Color.white;
			var nameStyle = new GUIStyle(GUI.skin.label);
			nameStyle.fontSize = 13;
			nameStyle.fontStyle = FontStyle.Bold;
			nameStyle.normal.textColor = Color.white;
			GUI.Label(new Rect(8, barY + 3, 150, 24), "Secretary Pepper", nameStyle);

			textStyle.alignment = TextAnchor.UpperLeft;
			textStyle.normal.textColor = new Color(0.15f, 0.15f, 0.15f);
			int idx = Mathf.Min(dialogueIdx, secretaryLines.Length - 1);
			GUI.Label(new Rect(12, barY + 32, w - 24, barH - 38), secretaryLines[idx], textStyle);
		}
		else if (tutStep == TutorialStep.TransitionToOffice)
		{
			// Fade out overlay
			float alpha = Mathf.Clamp01(1f - tutTimer);
			GUI.color = new Color(0.55f, 0.75f, 0.85f, alpha);
			GUI.DrawTexture(new Rect(0, 0, w, h), Texture2D.whiteTexture);
			GUI.color = Color.white;
		}

		// Skip button on all pre-game screens
		GUI.color = Color.white;
		var skipBtnStyle = new GUIStyle(GUI.skin.button);
		skipBtnStyle.fontSize = 12;
		if (GUI.Button(new Rect(w - 80, 10, 70, 25), "Skip >", skipBtnStyle))
		{
			tutStep = TutorialStep.Welcome;
			tutTimer = 0;
			if (string.IsNullOrEmpty(playerName)) playerName = "CEO";
			tutDialogue = "Welcome, " + playerName + "!\nLet's learn about real estate management.";
			// Clean up CEO preview + move camera to building
			if (ceoPreviewInstance != null) { Destroy(ceoPreviewInstance); ceoPreviewInstance = null; ceoPreviewLoadedIdx = -1; }
			if (MainCamera != null) { MainCamera.orthographicSize = 5f; MainCamera.transform.position = new UnityEngine.Vector3(-4f, 8f, -10f); }
		}
	}

	// Draw tutorial UI (dialogue bar + panels)
	private void DrawTutorialGUI()
	{
		float w = Screen.width;
		float h = Screen.height;

		// === FULLSCREEN PRE-GAME STEPS (CEO select, name, phone call) ===
		if (tutStep <= TutorialStep.TransitionToOffice)
		{
			DrawPreGameGUI(w, h);
			return; // Don't draw office tutorial UI during pre-game
		}

		// === SKIP BUTTON (top-right) ===
		var skipStyle = new GUIStyle(GUI.skin.button);
		skipStyle.fontSize = 14;
		skipStyle.fontStyle = FontStyle.Bold;
		if (GUI.Button(new Rect(w - 90, 55, 80, 30), "Skip >", skipStyle))
		{
			tutStep = TutorialStep.TutorialDone;
			tutDialogue = "";
			officePanelOpen = false;
			companyListOpen = false;
			// Auto-setup: give company + employees so game is playable
			var root = Singleton<GameRoot>.Instance;
			if (root != null && root.UserData != null)
			{
				root.UserData.Level.Value = 1;
				SpawnTutorialEmployees(root, 0, 1);
				if (Ceo != null) Ceo.gameObject.SetActive(true);
				if (Secretary != null) Secretary.gameObject.SetActive(true);
			}
		}

		// === SECRETARY DIALOGUE BAR (bottom) ===
		if (!string.IsNullOrEmpty(tutDialogue))
		{
			float barH = 90;
			float barY = h - barH;

			// Background
			GUI.color = new Color(0.96f, 0.95f, 0.88f, 0.97f);
			GUI.DrawTexture(new Rect(0, barY, w, barH), Texture2D.whiteTexture);

			// Top border line
			GUI.color = new Color(0.8f, 0.75f, 0.6f, 1f);
			GUI.DrawTexture(new Rect(0, barY, w, 2), Texture2D.whiteTexture);

			// Secretary name label (green background like original)
			GUI.color = new Color(0.35f, 0.7f, 0.5f, 1f);
			GUI.DrawTexture(new Rect(0, barY + 2, 160, 26), Texture2D.whiteTexture);
			GUI.color = Color.white;
			var nameStyle = new GUIStyle(GUI.skin.label);
			nameStyle.fontSize = 13;
			nameStyle.fontStyle = FontStyle.Bold;
			nameStyle.normal.textColor = Color.white;
			GUI.Label(new Rect(8, barY + 3, 150, 24), "Secretary Pepper", nameStyle);

			// Dialogue text
			GUI.color = Color.white;
			var dlgStyle = new GUIStyle(GUI.skin.label);
			dlgStyle.fontSize = 15;
			dlgStyle.normal.textColor = new Color(0.15f, 0.15f, 0.15f);
			dlgStyle.wordWrap = true;
			GUI.Label(new Rect(12, barY + 32, w - 24, barH - 38), tutDialogue, dlgStyle);
		}

		// === OFFICE PANEL (when tapped) ===
		if (officePanelOpen && tutStep >= TutorialStep.OfficePanelOpen && tutStep <= TutorialStep.SearchCompany)
		{
			float panelH = h * 0.4f;
			float panelY = h - panelH - 85;
			GUI.color = new Color(1f, 1f, 1f, 0.95f);
			GUI.DrawTexture(new Rect(0, panelY, w, panelH), Texture2D.whiteTexture);
			GUI.color = Color.white;

			var titleStyle = new GUIStyle(GUI.skin.label);
			titleStyle.fontSize = 18;
			titleStyle.fontStyle = FontStyle.Bold;
			titleStyle.alignment = TextAnchor.MiddleCenter;
			titleStyle.normal.textColor = Color.black;
			GUI.Label(new Rect(0, panelY + 5, w, 30), "Office Room 101", titleStyle);

			var infoStyle = new GUIStyle(GUI.skin.label);
			infoStyle.fontSize = 14;
			infoStyle.normal.textColor = new Color(0.3f, 0.3f, 0.3f);
			infoStyle.alignment = TextAnchor.MiddleCenter;
			GUI.Label(new Rect(0, panelY + 35, w, 25), "Requires at least 4 seat(s)", infoStyle);
			GUI.Label(new Rect(0, panelY + 55, w, 25), "Desks owned: " + desksOwned + " / 4", infoStyle);

			// Buy Desk button
			if (desksOwned < 4)
			{
				int deskCost = 3000;
				var root = Singleton<GameRoot>.Instance;
				bool canAfford = root != null && root.UserData != null && root.UserData.HUDMoney.Value >= deskCost;
				string btnText = "Buy Desk  $" + deskCost;
				if (GUI.Button(new Rect(w / 2 - 80, panelY + 90, 160, 40), btnText) && canAfford)
				{
					desksOwned++;
					root.UserData.HUDMoney.Value -= deskCost;
					if (desksOwned >= 4 && tutStep == TutorialStep.OfficePanelOpen)
						tutStep = TutorialStep.BuyingDesks;
					Debug.Log($"[Tutorial] Bought desk {desksOwned}/4");
				}
			}

			// Search for Companies button (after 4 desks)
			if (desksOwned >= 4 && tutStep == TutorialStep.SearchCompany)
			{
				if (GUI.Button(new Rect(w / 2 - 100, panelY + 90, 200, 40), "Search for Companies"))
				{
					tutStep = TutorialStep.CompanyList;
					companyListOpen = true;
					officePanelOpen = false;
				}
			}
		}

		// === COMPANY LIST ===
		if (companyListOpen && tutStep == TutorialStep.CompanyList)
		{
			float panelH = h * 0.55f;
			float panelY = h * 0.2f;
			GUI.color = new Color(0.95f, 0.97f, 1f, 0.98f);
			GUI.DrawTexture(new Rect(20, panelY, w - 40, panelH), Texture2D.whiteTexture);
			GUI.color = Color.white;

			var titleStyle = new GUIStyle(GUI.skin.label);
			titleStyle.fontSize = 16;
			titleStyle.fontStyle = FontStyle.Bold;
			titleStyle.alignment = TextAnchor.MiddleCenter;
			titleStyle.normal.textColor = Color.black;
			GUI.Label(new Rect(20, panelY + 5, w - 40, 30), "Company List", titleStyle);

			var itemStyle = new GUIStyle(GUI.skin.label);
			itemStyle.fontSize = 14;
			itemStyle.normal.textColor = Color.black;

			for (int i = 0; i < companyNames.Length; i++)
			{
				float iy = panelY + 45 + i * 55;
				// Company name + rent
				GUI.Label(new Rect(40, iy, 200, 25), companyNames[i] + "  D", itemStyle);
				GUI.Label(new Rect(40, iy + 22, 200, 20), "Rent: $" + companyRents[i] + "/10s", itemStyle);

				// Contract button
				if (GUI.Button(new Rect(w - 130, iy + 5, 90, 35), "Contract"))
				{
					selectedCompanyIdx = i + 1;
					companyListOpen = false;
					tutStep = TutorialStep.ContractSigned;
					tutTimer = 0;
					tutDialogue = "Contract signed with " + companyNames[i] + "!";
					Debug.Log($"[Tutorial] Contracted company {companyNames[i]}");
				}
			}
		}

		// === TAP PROMPT (arrow/highlight) ===
		if (tutStep == TutorialStep.TapOffice)
		{
			// Draw pulsing "TAP HERE" indicator over office area
			float pulse = 0.5f + 0.5f * Mathf.Sin(Time.time * 3f);
			GUI.color = new Color(1f, 1f, 0f, pulse);
			var arrowStyle = new GUIStyle(GUI.skin.label);
			arrowStyle.fontSize = 22;
			arrowStyle.fontStyle = FontStyle.Bold;
			arrowStyle.alignment = TextAnchor.MiddleCenter;
			arrowStyle.normal.textColor = new Color(1f, 0.8f, 0f, pulse);
			GUI.Label(new Rect(w * 0.2f, h * 0.35f, w * 0.6f, 40), ">>> Tap Office <<<", arrowStyle);
			GUI.color = Color.white;

			// Detect click on office area
			if (Event.current.type == EventType.MouseDown && Event.current.button == 0)
			{
				UnityEngine.Vector2 mp = Event.current.mousePosition;
				if (mp.y > h * 0.2f && mp.y < h * 0.65f) // Rough office area
				{
					tutStep = TutorialStep.OfficePanelOpen;
					officePanelOpen = true;
					tutTimer = 0;
					Event.current.Use();
				}
			}
		}
	}
}
