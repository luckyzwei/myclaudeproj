using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TutorialSystem
{
	public class Map
	{
		public int id;

		public GameObject inst;
	}

	public class WaitTuto
	{
		public int id;

		public Action EndCb;
	}

	public class TutorialTargetInfo
	{
		public static readonly int FACTORY_FREE_ITEM_IDX;
	}

	[CompilerGenerated]
	private sealed class _003CWait_003Ed__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TutorialSystem _003C_003E4__this;

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
		public _003CWait_003Ed__64(int _003C_003E1__state)
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
	private sealed class _003CWaitAndStartTutorialCoroutine_003Ed__63 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameType gameType;

		public TutorialSystem _003C_003E4__this;

		public int _key;

		public bool initCallback;

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
		public _003CWaitAndStartTutorialCoroutine_003Ed__63(int _003C_003E1__state)
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

	private Dictionary<TutorialIdent, TutorialRegister> registerDic;

	private List<Map> scenarioMap;

	private Dictionary<int, string> LoadMapData;

	public const int Tutorial_Start1 = 1;

	public const int Tutorial_Start2 = 2;

	public const int Tutorial_Office2Contact = 3;

	public const int Tutorial_Mission = 4;

	public const int Tutorial_Maintenance = 5;

	public const int Tutorial_LeakPower = 6;

	public const int Tutorial_Adsupply = 7;

	public const int Tutorial_Levelup = 8;

	public const int Tutorial_C_GradeCompany = 9;

	public const int Tutorial_Worldmap = 10;

	public const int Tutorial_Plant = 11;

	public const int Tutorial_NextStage2 = 12;

	public const int Tutorial_RefreshCompanyList = 13;

	public const int Tutorial_NextStage3 = 14;

	public const int Tutorial_Factory = 15;

	public const int Tutorial_WorldmapBank = 16;

	public const int Tutorial_Manager = 17;

	public const int Tutorial_Office_Item_Button_Press_Upgrade = 18;

	public const int Tutorial_Strike = 19;

	public const int Tutorial_HouseMove = 20;

	public const int Tutorial_FirstRichPoint = 21;

	public const int Tutorial_RichPointLeak = 22;

	public const int Tutorial_BizAcq_Open = 25;

	public const int Tutorial_BizAcq_Battle_Speed = 26;

	public const int Tutorial_NewHouse = 27;

	public const int Tutorial_NewCar = 28;

	public const int Tutorial_CarCollection = 29;

	public const int Tutorial_BizAcq_Reinforce = 30;

	public const int Tutorial_Booster = 32;

	public const int Tutorial_CompanyExpTicket = 33;

	public const int Tutorial_FactoryItem = 37;

	public const int Tutorial_Seasonal_Open = 1001;

	public const int Tutorial_Seasonal_Enter10001 = 1002;

	public const int Tutorial_Seasonal_SkillBook = 1003;

	public const int Tutorial_Seasonal_MilestoneReward = 1004;

	private GameObject Active_ScenarioMap;

	private Queue<WaitTuto> WaitTutorials;

	public Action OnActiveTutoEndCb;

	public int ActiveTutorialKey;

	private bool IsTuto;

	private Coroutine WaitAndStartCoroutine;

	private List<int> CheatPlayTutorialList;

	public event Action OnEndTutorialEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void Init()
	{
	}

	public bool IsActive(int compareKey = -1)
	{
		return false;
	}

	public bool IsClearTuto(int key)
	{
		return false;
	}

	public void ClearRegisiter()
	{
	}

	public void RemoveRegister(TutorialIdent _index)
	{
	}

	public void AddRegister(TutorialIdent _index, TutorialRegister _register)
	{
	}

	public TutorialRegister GetRegister(TutorialIdent _index)
	{
		return null;
	}

	public bool IsWaitTutorial()
	{
		return false;
	}

	public void InitTuto(string key)
	{
	}

	public void StartTutorial(int _key, Action cb)
	{
	}

	public void StartTutorial(int _key, bool initCallback = false)
	{
	}

	public void WaitAndStartTutorial(int _key, GameType gameType, bool initCallback = false)
	{
	}

	[IteratorStateMachine(typeof(_003CWaitAndStartTutorialCoroutine_003Ed__63))]
	private IEnumerator WaitAndStartTutorialCoroutine(int _key, GameType gameType, bool initCallback = false)
	{
		yield break;
	}

	[IteratorStateMachine(typeof(_003CWait_003Ed__64))]
	private IEnumerator Wait()
	{
		yield break;
	}

	public void TutoClear(int _key)
	{
	}

	public void EndTuto()
	{
	}

	public bool CheckTutorialStartCondition(int key)
	{
		return false;
	}

	public bool IsDynamaicTarget(TutorialIdent id)
	{
		return false;
	}

	public GameObject GetTarget(TutorialIdent id, int targetIdx = -1, int targetSubIdx = -1)
	{
		return null;
	}
}
