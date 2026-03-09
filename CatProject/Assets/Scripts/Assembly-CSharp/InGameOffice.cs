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
	private string hudMoney = "$ 0";
	private string hudIncome = "Income: $0";
	private string hudLevel = "Lv.1";
	private string hudTime = "09:00";
	private CompositeDisposable hudDisposables;
	private GUIStyle hudStyleLarge;
	private GUIStyle hudStyleSmall;

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

	public void LoadAdsupplyVip(Action<AdSupplyVIP> CompCb)
	{
		if (AdsupplyVipPref == null) { CompCb?.Invoke(null); return; }
		Addressables.InstantiateAsync(AdsupplyVipPref, CharacterRoot).Completed += (handle) =>
		{
			if (handle.Result != null)
			{
				AdsupplyMoneyVip = handle.Result.GetComponent<AdSupplyVIP>();
				CompCb?.Invoke(AdsupplyMoneyVip);
			}
			else CompCb?.Invoke(null);
		};
	}

	public void LoadNightSkip(Action<NightSkipVIP> CompCb)
	{
		if (NightSkipPref == null) { CompCb?.Invoke(null); return; }
		Addressables.InstantiateAsync(NightSkipPref, CharacterRoot).Completed += (handle) =>
		{
			if (handle.Result != null)
			{
				NightSkipVip = handle.Result.GetComponent<NightSkipVIP>();
				CompCb?.Invoke(NightSkipVip);
			}
			else CompCb?.Invoke(null);
		};
	}

	public void LoadBizAcqStage(Action compCb, bool isActive)
	{
		if (BizAcqStagePref == null) { compCb?.Invoke(); return; }
		Addressables.InstantiateAsync(BizAcqStagePref, CharacterRoot).Completed += (handle) =>
		{
			if (handle.Result != null)
			{
				BizAcqStage = handle.Result.GetComponent<BizAcqStage>();
				handle.Result.SetActive(isActive);
				IsBizAcqMode = isActive;
			}
			compCb?.Invoke();
		};
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
		if (CharacterPref == null) { CompCb?.Invoke(); return; }
		Addressables.InstantiateAsync(CharacterPref, CharacterRoot).Completed += (handle) =>
		{
			if (handle.Result != null)
			{
				var employee = handle.Result.GetComponent<Employee>();
				if (employee != null)
				{
					EmployeeList.Add(employee);
					if (!CurEmployeeCnt.ContainsKey(office)) CurEmployeeCnt[office] = 0;
					CurEmployeeCnt[office]++;
				}
			}
			CompCb?.Invoke();
		};
	}

	public void LoadCeo(Worker.E_AppearType appearType, int order, Action CompCb)
	{
		if (CeoPref == null) { CompCb?.Invoke(); return; }
		Addressables.InstantiateAsync(CeoPref, CharacterRoot).Completed += (handle) =>
		{
			if (handle.Result != null)
				Ceo = handle.Result.GetComponent<CEO>();
			CompCb?.Invoke();
		};
	}

	public void LoadSecretary(Worker.E_AppearType appearType, int order, Action CompCb)
	{
		if (SecretaryPref == null) { CompCb?.Invoke(); return; }
		Addressables.InstantiateAsync(SecretaryPref, CharacterRoot).Completed += (handle) =>
		{
			if (handle.Result != null)
				Secretary = handle.Result.GetComponent<Secretary>();
			CompCb?.Invoke();
		};
	}

	public void LoadEngineer(int seat, int order, Worker.E_AppearType appearType, Action CompCb)
	{
		if (EngineerPref == null) { CompCb?.Invoke(); return; }
		Addressables.InstantiateAsync(EngineerPref, CharacterRoot).Completed += (handle) =>
		{
			if (handle.Result != null)
			{
				var engineer = handle.Result.GetComponent<Engineer>();
				if (engineer != null)
				{
					EngineerList.Add(engineer);
					CurEngineerCount++;
				}
			}
			CompCb?.Invoke();
		};
	}

	public void LoadManager(int managerIdx, int officeIdx, int order, Worker.E_AppearType appearType, Action CompCb = null)
	{
		if (ManagerPref == null) { CompCb?.Invoke(); return; }
		Addressables.InstantiateAsync(ManagerPref, CharacterRoot).Completed += (handle) =>
		{
			if (handle.Result != null)
			{
				var manager = handle.Result.GetComponent<Manager>();
				if (manager != null)
					ManagerList.Add(manager);
			}
			CompCb?.Invoke();
		};
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

	public override void LoadUI()
	{
		SubscribeToGameSystems();
		Debug.Log("[InGameOffice] HUD initialized (IMGUI mode)");
	}

	private void OnGUI()
	{
		if (hudStyleLarge == null)
		{
			hudStyleLarge = new GUIStyle(GUI.skin.label);
			hudStyleLarge.fontSize = 24;
			hudStyleLarge.fontStyle = FontStyle.Bold;
			hudStyleSmall = new GUIStyle(GUI.skin.label);
			hudStyleSmall.fontSize = 16;
		}

		// Dark background panel
		GUI.color = new Color(0, 0, 0, 0.7f);
		GUI.DrawTexture(new Rect(0, 0, Screen.width, 80), Texture2D.whiteTexture);
		GUI.color = Color.white;

		// Money (left side)
		hudStyleLarge.normal.textColor = Color.yellow;
		GUI.Label(new Rect(15, 8, 400, 35), hudMoney, hudStyleLarge);

		// Income (left side, second row)
		hudStyleSmall.normal.textColor = Color.green;
		GUI.Label(new Rect(15, 45, 400, 25), hudIncome, hudStyleSmall);

		// Level (right side)
		hudStyleLarge.normal.textColor = Color.white;
		hudStyleLarge.alignment = TextAnchor.MiddleRight;
		GUI.Label(new Rect(Screen.width - 215, 8, 200, 35), hudLevel, hudStyleLarge);
		hudStyleLarge.alignment = TextAnchor.MiddleLeft;

		// Time (right side, second row)
		hudStyleSmall.normal.textColor = new Color(0.7f, 0.9f, 1f);
		hudStyleSmall.alignment = TextAnchor.MiddleRight;
		GUI.Label(new Rect(Screen.width - 215, 45, 200, 25), hudTime, hudStyleSmall);
		hudStyleSmall.alignment = TextAnchor.MiddleLeft;
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

			// Subscribe to RuntimeRentalFeeValue to add to HUDMoney
			if (root.RentalFeeSystem.RuntimeRentalFeeValue != null)
			{
				root.RentalFeeSystem.RuntimeRentalFeeValue
					.Subscribe(val =>
					{
						if (val > BigInteger.Zero && root.UserData != null && root.UserData.HUDMoney != null)
						{
							root.UserData.HUDMoney.Value += val;
							root.RentalFeeSystem.RuntimeRentalFeeValue.Value = BigInteger.Zero;
						}
					})
					.AddTo(hudDisposables);
			}
		}

		// Subscribe to level changes
		if (root.UserData != null && root.UserData.Level != null)
		{
			root.UserData.Level
				.Subscribe(val => { hudLevel = "Lv." + val; })
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
		// Update time display every frame
		var root = Singleton<GameRoot>.Instance;
		if (root != null && root.DaySystem != null)
		{
			int hour = (int)root.DaySystem.DayTime;
			int min = (int)((root.DaySystem.DayTime - hour) * 60);
			var status = root.DaySystem.CurTimeStatus != null ? root.DaySystem.CurTimeStatus.Value : DaySystem.DayStatus.NotSet;
			hudTime = hour.ToString("D2") + ":" + min.ToString("D2") + " " + status;
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
