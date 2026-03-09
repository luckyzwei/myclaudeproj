using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.AddressableAssets;
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

	public override void Load()
	{
		EmployeeList = new List<Employee>();
		ManagerList = new List<Manager>();
		EngineerList = new List<Engineer>();
		CurEmployeeCnt = new Dictionary<int, int>();
		buffObjects = new List<BuffObjectComponent>();
		CurEngineerCount = 0;
		OnAllLoadComplete = new Subject<bool>();

		// Set camera to show sky blue background, keep within PanAndZoom bounds
		if (MainCamera != null)
		{
			MainCamera.backgroundColor = new Color(0.65f, 0.85f, 0.95f, 1f);
			MainCamera.clearFlags = CameraClearFlags.SolidColor;
			MainCamera.orthographicSize = 12f;
			// Position camera at center of PanAndZoom bounds (not at InGame's position)
			MainCamera.transform.position = new Vector3(9.5f, 2.5f, -10f);
			Debug.Log("[InGameOffice] Camera at (9.5, 2.5), bounds center");
		}

		// Find stage in scene (if instantiated)
		stage = FindObjectOfType<InGameOfficeStage>();

		// Load atlas textures and create visible scene at world origin
		CreateVisualScene();

		Debug.Log("[InGameOffice] Load complete. Stage found: " + (stage != null));
	}

	private void CreateVisualScene()
	{
		// Create sprites at WORLD positions (not as children of InGame which is at 216,431)
		// because PanAndZoom clamps camera to bounds (-28~47, -30~35)
		var bgTex = Resources.Load<Texture2D>("StageBG");
		var stageTex = Resources.Load<Texture2D>("StageAtlas");
		var stageTex2 = Resources.Load<Texture2D>("StageAtlas2");

		Debug.Log("[InGameOffice] StageBG: " + (bgTex != null ? bgTex.width + "x" + bgTex.height : "NULL"));
		Debug.Log("[InGameOffice] StageAtlas: " + (stageTex != null ? stageTex.width + "x" + stageTex.height : "NULL"));
		Debug.Log("[InGameOffice] StageAtlas2: " + (stageTex2 != null ? stageTex2.width + "x" + stageTex2.height : "NULL"));

		// Background - full screen at world origin
		if (bgTex != null)
		{
			var bgGO = new GameObject("Background");
			bgGO.transform.position = new Vector3(9.5f, 2.5f, 5f);
			var bgRenderer = bgGO.AddComponent<SpriteRenderer>();
			bgRenderer.sprite = Sprite.Create(bgTex,
				new Rect(0, 0, bgTex.width, bgTex.height),
				new Vector2(0.5f, 0.5f), 100f);
			bgRenderer.sortingOrder = -100;
			// Scale to cover visible area (~30 units wide)
			float scale = 30f / (bgTex.width / 100f);
			bgGO.transform.localScale = new Vector3(scale, scale, 1f);
			Debug.Log("[InGameOffice] Background created at world (9.5, 2.5)");
		}

		// Stage atlas tiles - place as office floors/items at world positions
		if (stageTex != null)
		{
			int tw = stageTex.width;
			int th = stageTex.height;
			// Tile the atlas into visible sections across the view
			int cols = Mathf.Min(tw / 256, 8);
			int rows = Mathf.Min(th / 256, 6);
			for (int r = 0; r < rows; r++)
			{
				for (int c = 0; c < cols; c++)
				{
					float wx = c * 5f - 5f;
					float wy = r * 5f - 8f;
					var rect = new Rect(c * 256, r * 256, 256, 256);
					CreateWorldSprite(stageTex, "Stage_" + r + "_" + c, rect,
						new Vector3(wx, wy, 0f), 0.08f, r * cols + c);
				}
			}
			Debug.Log("[InGameOffice] Created " + (cols * rows) + " stage tile sprites");
		}

		// Second atlas
		if (stageTex2 != null)
		{
			int tw = stageTex2.width;
			int th = stageTex2.height;
			int cols = Mathf.Min(tw / 256, 4);
			int rows = Mathf.Min(th / 256, 4);
			for (int r = 0; r < rows; r++)
			{
				for (int c = 0; c < cols; c++)
				{
					float wx = c * 5f + 20f;
					float wy = r * 5f - 8f;
					var rect = new Rect(c * 256, r * 256, 256, 256);
					CreateWorldSprite(stageTex2, "Stage2_" + r + "_" + c, rect,
						new Vector3(wx, wy, 0f), 0.08f, 100 + r * cols + c);
				}
			}
		}
	}

	private void CreateWorldSprite(Texture2D tex, string name, Rect region, Vector3 worldPos, float scale, int order)
	{
		// Clamp region to texture bounds
		region.width = Mathf.Min(region.width, tex.width - region.x);
		region.height = Mathf.Min(region.height, tex.height - region.y);
		if (region.width <= 0 || region.height <= 0) return;

		var go = new GameObject(name);
		go.transform.position = worldPos; // World position, NOT child of InGame
		go.transform.localScale = new Vector3(scale, scale, 1f);
		var renderer = go.AddComponent<SpriteRenderer>();
		renderer.sprite = Sprite.Create(tex, region, new Vector2(0.5f, 0.5f), 100f);
		renderer.sortingOrder = order;
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
		// Load office-specific floating UI elements
	}

	private void OnDestroy()
	{
		UnLoad();
	}
}
