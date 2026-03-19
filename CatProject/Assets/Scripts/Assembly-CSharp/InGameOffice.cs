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
	private string hudMoney = "$ 1,000";
	private string hudIncome = "Income: $0";
	private string hudLevel = "Lv.1";
	private string hudTime = "09:00";
	private float levelUpDisplayTime;
	private int levelUpNewLevel;
	private string unlockText;
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
			// Let PanAndZoom handle camera - don't override
			Debug.Log("[InGameOffice] Camera set: ortho=10, pos=(-3,6,-10)");
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
			Ceo = go.GetComponent<CEO>();
		CompCb?.Invoke();
	}

	public void LoadSecretary(Worker.E_AppearType appearType, int order, Action CompCb)
	{
		var go = LoadPrefabDirect("Secretary", CharacterRoot);
		if (go != null)
			Secretary = go.GetComponent<Secretary>();
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

		// Start all employees working (state = Work, but no animation triggers)
		if (EmployeeList != null)
		{
			for (int i = 0; i < EmployeeList.Count; i++)
			{
				if (EmployeeList[i] != null)
					EmployeeList[i].WorkStart();
			}
		}

		Debug.Log("[InGameOffice] LoadUI complete, useIMGUI=" + useIMGUI);
	}

	private void OnGUI()
	{
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
}
