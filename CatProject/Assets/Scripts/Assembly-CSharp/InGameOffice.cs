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

	public List<BuffObjectComponent> BuffObjects { get { return null; } }

	public InGameOfficeStage Stage { get { return null; } }

	public BizAcqStage BizAcqStage { get; private set; }

	public bool IsBizAcqMode { get; private set; }

	public override void Load()
	{
	}

	public BuffObjectComponent GetBuffObject(int idx)
	{
		return null;
	}

	public void AddBuffObject(BuffObjectComponent component)
	{
	}

	public void RemoveBuffObject(BuffObjectComponent component)
	{
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
	}

	public void ReturnAllEmployee()
	{
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
		return false;
	}

	public bool HaveToLoadChar(int office_idx)
	{
		return false;
	}

	public int GetOfficeCatCount(int office)
	{
		return 0;
	}

	public void WorkOffStartBus()
	{
	}

	public void WorkStartEmployee(int office)
	{
	}

	public void WaitAllWorkOff(Action Cb)
	{
	}

	[IteratorStateMachine(typeof(_003CWaitAllWorkOff_Coroutine_003Ed__57))]
	private IEnumerator WaitAllWorkOff_Coroutine(Action Cb)
	{
		yield break;
	}

	public void WorkOffEmployee()
	{
	}

	public void CompanyOutEmployee(int office, bool isListPage)
	{
	}

	public List<Employee> GetEmployees(int office = -1)
	{
		return null;
	}

	public int GetEngineerCount()
	{
		return 0;
	}

	public Engineer GetEngineer(int seat)
	{
		return null;
	}

	public List<Engineer> GetEngineers()
	{
		return null;
	}

	public void RemoveSecretary()
	{
	}

	public void WorkOffManager(int managerIdx)
	{
	}

	public override void UnLoad()
	{
	}

	public void UnLoadChar()
	{
	}

	public override void LoadUI()
	{
	}

	private void OnDestroy()
	{
	}
}
