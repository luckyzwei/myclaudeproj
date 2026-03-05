using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx;
using UnityEngine;
using UnityEngine.AddressableAssets;

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
	}

	public void LoadAdsupplyVip(Action<AdSupplyVIP> CompCb)
	{
	}

	public void LoadNightSkip(Action<NightSkipVIP> CompCb)
	{
	}

	public void LoadBizAcqStage(Action compCb, bool isActive)
	{
	}

	public void MoveBizAcqStage(Action compCb)
	{
	}

	public void ReturnBizAcqStage()
	{
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
	}

	public void LoadCeo(Worker.E_AppearType appearType, int order, Action CompCb)
	{
	}

	public void LoadSecretary(Worker.E_AppearType appearType, int order, Action CompCb)
	{
	}

	public void LoadEngineer(int seat, int order, Worker.E_AppearType appearType, Action CompCb)
	{
	}

	public void LoadManager(int managerIdx, int officeIdx, int order, Worker.E_AppearType appearType, Action CompCb = null)
	{
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
		yield break;
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
		// UI loading for office mode handled by stage
	}

	private void OnDestroy()
	{
		UnLoad();
	}
}
