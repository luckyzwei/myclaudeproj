using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Treeplla;
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
		public _003CWait_003Ed__64(int _003C_003E1__state)
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
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
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
		public _003CWaitAndStartTutorialCoroutine_003Ed__63(int _003C_003E1__state)
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
					// Wait until the current game type matches the expected type
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				case 1:
					_003C_003E1__state = -1;
					var root = Singleton<GameRoot>.Instance;
					if (root.CurGameType != gameType)
					{
						_003C_003E2__current = null;
						_003C_003E1__state = 1;
						return true;
					}
					_003C_003E4__this.StartTutorial(_key, initCallback);
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

	[CompilerGenerated]
	private Action _OnEndTutorialEvent;

	public event Action OnEndTutorialEvent
	{
		[CompilerGenerated]
		add
		{
			Action current = _OnEndTutorialEvent;
			Action updated;
			do
			{
				updated = current;
				Action combined = (Action)Delegate.Combine(updated, value);
				current = Interlocked.CompareExchange(ref _OnEndTutorialEvent, combined, updated);
			}
			while (current != updated);
		}
		[CompilerGenerated]
		remove
		{
			Action current = _OnEndTutorialEvent;
			Action updated;
			do
			{
				updated = current;
				Action removed = (Action)Delegate.Remove(updated, value);
				current = Interlocked.CompareExchange(ref _OnEndTutorialEvent, removed, updated);
			}
			while (current != updated);
		}
	}

	public void Init()
	{
		registerDic = new Dictionary<TutorialIdent, TutorialRegister>();
		scenarioMap = new List<Map>();
		LoadMapData = new Dictionary<int, string>();
		WaitTutorials = new Queue<WaitTuto>();
		CheatPlayTutorialList = new List<int>();

		LoadMapData[Tutorial_Start1] = "Tutorial/TutoScenario_Start1";
		LoadMapData[Tutorial_Start2] = "Tutorial/TutoScenario_Start2";
		LoadMapData[Tutorial_Office2Contact] = "Tutorial/TutoScenario_Office2Contact";
		LoadMapData[Tutorial_Mission] = "Tutorial/TutoScenario_Mission";
		LoadMapData[Tutorial_Maintenance] = "Tutorial/TutoScenario_Maintenance";
		LoadMapData[Tutorial_LeakPower] = "Tutorial/TutoScenario_LeakPower";
		LoadMapData[Tutorial_Adsupply] = "Tutorial/TutoScenario_Adsupply";
		LoadMapData[Tutorial_Levelup] = "Tutorial/TutoScenario_Levelup";
		LoadMapData[Tutorial_C_GradeCompany] = "Tutorial/TutoScenario_CGradeCompany";
		LoadMapData[Tutorial_Worldmap] = "Tutorial/TutoScenario_Worldmap";
		LoadMapData[Tutorial_Plant] = "Tutorial/TutoScenario_Plant";
		LoadMapData[Tutorial_NextStage2] = "Tutorial/TutoScenario_NextStage2";
		LoadMapData[Tutorial_RefreshCompanyList] = "Tutorial/TutoScenario_RefreshCompanyList";
		LoadMapData[Tutorial_NextStage3] = "Tutorial/TutoScenario_NextStage3";
		LoadMapData[Tutorial_Factory] = "Tutorial/TutoScenario_Factory";
		LoadMapData[Tutorial_WorldmapBank] = "Tutorial/TutoScenario_WorldmapBank";
		LoadMapData[Tutorial_Manager] = "Tutorial/TutoScenario_Manager";
		LoadMapData[Tutorial_Office_Item_Button_Press_Upgrade] = "Tutorial/TutoScenario_OfficeItemUpgrade";
		LoadMapData[Tutorial_Strike] = "Tutorial/TutoScenario_Strike";
		LoadMapData[Tutorial_HouseMove] = "Tutorial/TutoScenario_HouseMove";
		LoadMapData[Tutorial_FirstRichPoint] = "Tutorial/TutoScenario_FirstRichPoint";
		LoadMapData[Tutorial_RichPointLeak] = "Tutorial/TutoScenario_RichPointLeak";
		LoadMapData[Tutorial_BizAcq_Open] = "Tutorial/TutoScenario_BizAcqOpen";
		LoadMapData[Tutorial_BizAcq_Battle_Speed] = "Tutorial/TutoScenario_BizAcqBattleSpeed";
		LoadMapData[Tutorial_NewHouse] = "Tutorial/TutoScenario_NewHouse";
		LoadMapData[Tutorial_NewCar] = "Tutorial/TutoScenario_NewCar";
		LoadMapData[Tutorial_CarCollection] = "Tutorial/TutoScenario_CarCollection";
		LoadMapData[Tutorial_BizAcq_Reinforce] = "Tutorial/TutoScenario_BizAcqReinforce";
		LoadMapData[Tutorial_Booster] = "Tutorial/TutoScenario_Booster";
		LoadMapData[Tutorial_CompanyExpTicket] = "Tutorial/TutoScenario_CompanyExpTicket";
		LoadMapData[Tutorial_FactoryItem] = "Tutorial/TutoScenario_FactoryItem";
		LoadMapData[Tutorial_Seasonal_Open] = "Tutorial/TutoScenario_SeasonalOpen";
		LoadMapData[Tutorial_Seasonal_Enter10001] = "Tutorial/TutoScenario_SeasonalEnter";
		LoadMapData[Tutorial_Seasonal_SkillBook] = "Tutorial/TutoScenario_SeasonalSkillBook";
		LoadMapData[Tutorial_Seasonal_MilestoneReward] = "Tutorial/TutoScenario_SeasonalMilestoneReward";
	}

	public bool IsActive(int compareKey = -1)
	{
		if (!IsTuto)
			return false;
		if (compareKey < 0)
			return true;
		return ActiveTutorialKey == compareKey;
	}

	public bool IsClearTuto(int key)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null || root.UserData.Tutorial == null)
			return false;

		if (CheatPlayTutorialList != null && CheatPlayTutorialList.Contains(key))
			return true;

		string keyStr = key.ToString();
		return root.UserData.Tutorial.Contains(keyStr);
	}

	public void ClearRegisiter()
	{
		if (registerDic != null)
			registerDic.Clear();
	}

	public void RemoveRegister(TutorialIdent _index)
	{
		if (registerDic != null && registerDic.ContainsKey(_index))
			registerDic.Remove(_index);
	}

	public void AddRegister(TutorialIdent _index, TutorialRegister _register)
	{
		if (registerDic == null)
			registerDic = new Dictionary<TutorialIdent, TutorialRegister>();

		registerDic[_index] = _register;
	}

	public TutorialRegister GetRegister(TutorialIdent _index)
	{
		if (registerDic == null)
			return null;
		TutorialRegister reg;
		if (registerDic.TryGetValue(_index, out reg))
			return reg;
		return null;
	}

	public bool IsWaitTutorial()
	{
		return WaitTutorials != null && WaitTutorials.Count > 0;
	}

	public void InitTuto(string key)
	{
		GameObject prefab = Resources.Load<GameObject>(key);
		if (prefab == null)
			return;

		GameObject inst = UnityEngine.Object.Instantiate(prefab);
		if (inst != null)
		{
			Active_ScenarioMap = inst;
		}
	}

	public void StartTutorial(int _key, Action cb)
	{
		OnActiveTutoEndCb = cb;
		StartTutorial(_key, false);
	}

	public void StartTutorial(int _key, bool initCallback = false)
	{
		if (IsTuto)
		{
			// Already running a tutorial, queue this one
			WaitTuto wait = new WaitTuto();
			wait.id = _key;
			wait.EndCb = OnActiveTutoEndCb;
			if (WaitTutorials == null)
				WaitTutorials = new Queue<WaitTuto>();
			WaitTutorials.Enqueue(wait);
			return;
		}

		if (IsClearTuto(_key))
			return;

		if (!CheckTutorialStartCondition(_key))
			return;

		IsTuto = true;
		ActiveTutorialKey = _key;

		string path;
		if (LoadMapData != null && LoadMapData.TryGetValue(_key, out path))
		{
			InitTuto(path);
		}

		if (initCallback)
		{
			OnActiveTutoEndCb = null;
		}
	}

	public void WaitAndStartTutorial(int _key, GameType gameType, bool initCallback = false)
	{
		if (IsClearTuto(_key))
			return;

		var root = Singleton<GameRoot>.Instance;
		if (root == null)
			return;

		if (root.CurGameType == gameType)
		{
			StartTutorial(_key, initCallback);
		}
		else
		{
			if (WaitAndStartCoroutine != null)
			{
				root.StopCoroutine(WaitAndStartCoroutine);
			}
			WaitAndStartCoroutine = root.StartCoroutine(WaitAndStartTutorialCoroutine(_key, gameType, initCallback));
		}
	}

	[IteratorStateMachine(typeof(_003CWaitAndStartTutorialCoroutine_003Ed__63))]
	private IEnumerator WaitAndStartTutorialCoroutine(int _key, GameType gameType, bool initCallback = false)
	{
		var d = new _003CWaitAndStartTutorialCoroutine_003Ed__63(0);
		d._003C_003E4__this = this;
		d._key = _key;
		d.gameType = gameType;
		d.initCallback = initCallback;
		return d;
	}

	[IteratorStateMachine(typeof(_003CWait_003Ed__64))]
	private IEnumerator Wait()
	{
		var d = new _003CWait_003Ed__64(0);
		d._003C_003E4__this = this;
		return d;
	}

	public void TutoClear(int _key)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null)
			return;

		string keyStr = _key.ToString();
		if (!root.UserData.Tutorial.Contains(keyStr))
		{
			root.UserData.Tutorial.Add(keyStr);
		}

		root.UserData.Save();
	}

	public void EndTuto()
	{
		if (!IsTuto)
			return;

		IsTuto = false;
		int clearedKey = ActiveTutorialKey;
		ActiveTutorialKey = 0;

		if (Active_ScenarioMap != null)
		{
			UnityEngine.Object.Destroy(Active_ScenarioMap);
			Active_ScenarioMap = null;
		}

		Action cb = OnActiveTutoEndCb;
		OnActiveTutoEndCb = null;
		if (cb != null)
			cb.Invoke();

		if (_OnEndTutorialEvent != null)
			_OnEndTutorialEvent.Invoke();

		if (WaitTutorials != null && WaitTutorials.Count > 0)
		{
			WaitTuto next = WaitTutorials.Dequeue();
			OnActiveTutoEndCb = next.EndCb;
			StartTutorial(next.id, false);
		}
	}

	public bool CheckTutorialStartCondition(int key)
	{
		if (IsClearTuto(key))
			return false;

		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null)
			return false;

		switch (key)
		{
			case Tutorial_Start1:
				// First tutorial, always available
				return true;

			case Tutorial_Start2:
				// Requires Tutorial_Start1 cleared
				return IsClearTuto(Tutorial_Start1);

			case Tutorial_Office2Contact:
				return IsClearTuto(Tutorial_Start2);

			case Tutorial_Mission:
				return IsClearTuto(Tutorial_Office2Contact);

			case Tutorial_Maintenance:
				return IsClearTuto(Tutorial_Mission);

			case Tutorial_LeakPower:
				return IsClearTuto(Tutorial_Maintenance);

			case Tutorial_Adsupply:
				return IsClearTuto(Tutorial_LeakPower);

			case Tutorial_Levelup:
				return IsClearTuto(Tutorial_Adsupply);

			case Tutorial_C_GradeCompany:
				return IsClearTuto(Tutorial_Levelup);

			case Tutorial_Worldmap:
				return IsClearTuto(Tutorial_C_GradeCompany);

			case Tutorial_Plant:
				return IsClearTuto(Tutorial_Worldmap);

			case Tutorial_NextStage2:
				return IsClearTuto(Tutorial_Plant);

			case Tutorial_RefreshCompanyList:
				return IsClearTuto(Tutorial_NextStage2);

			case Tutorial_NextStage3:
				return IsClearTuto(Tutorial_RefreshCompanyList);

			case Tutorial_Factory:
				return IsClearTuto(Tutorial_NextStage3);

			case Tutorial_WorldmapBank:
				return IsClearTuto(Tutorial_Factory);

			case Tutorial_Manager:
				return IsClearTuto(Tutorial_WorldmapBank);

			case Tutorial_Office_Item_Button_Press_Upgrade:
				return IsClearTuto(Tutorial_Manager);

			case Tutorial_Strike:
				return IsClearTuto(Tutorial_Office_Item_Button_Press_Upgrade);

			case Tutorial_HouseMove:
				return IsClearTuto(Tutorial_Strike);

			case Tutorial_FirstRichPoint:
				return IsClearTuto(Tutorial_HouseMove);

			case Tutorial_RichPointLeak:
				return IsClearTuto(Tutorial_FirstRichPoint);

			case Tutorial_BizAcq_Open:
				return IsClearTuto(Tutorial_RichPointLeak);

			case Tutorial_BizAcq_Battle_Speed:
				return IsClearTuto(Tutorial_BizAcq_Open);

			case Tutorial_NewHouse:
				return IsClearTuto(Tutorial_BizAcq_Battle_Speed);

			case Tutorial_NewCar:
				return IsClearTuto(Tutorial_NewHouse);

			case Tutorial_CarCollection:
				return IsClearTuto(Tutorial_NewCar);

			case Tutorial_BizAcq_Reinforce:
				return IsClearTuto(Tutorial_CarCollection);

			case Tutorial_Booster:
				return IsClearTuto(Tutorial_BizAcq_Reinforce);

			case Tutorial_CompanyExpTicket:
				return IsClearTuto(Tutorial_Booster);

			case Tutorial_FactoryItem:
				return IsClearTuto(Tutorial_CompanyExpTicket);

			case Tutorial_Seasonal_Open:
				return IsClearTuto(Tutorial_Start2);

			case Tutorial_Seasonal_Enter10001:
				return IsClearTuto(Tutorial_Seasonal_Open);

			case Tutorial_Seasonal_SkillBook:
				return IsClearTuto(Tutorial_Seasonal_Enter10001);

			case Tutorial_Seasonal_MilestoneReward:
				return IsClearTuto(Tutorial_Seasonal_SkillBook);

			default:
				return true;
		}
	}

	public bool IsDynamaicTarget(TutorialIdent id)
	{
		switch (id)
		{
			case TutorialIdent.TutoStart_FirstOfficeDesk:
			case TutorialIdent.TutoStart_DeskItem:
			case TutorialIdent.TutoMaintenance_Room:
			case TutorialIdent.TutoMaintenance_RoomUI:
			case TutorialIdent.TutoMaintenance_EngineerRoom:
			case TutorialIdent.TutoMaintenance_TargetOffice:
			case TutorialIdent.TutoMaintenance_Ceo:
			case TutorialIdent.TutoLeakPower_PowerRoom:
			case TutorialIdent.TutoLevelUp_Room:
			case TutorialIdent.TutoLevelUp_RoomUI:
			case TutorialIdent.TutoFactory_FirstFactory:
			case TutorialIdent.TutoFactory_OrderBuilding:
			case TutorialIdent.TutoFactory_FocusHighestProductionFactory:
			case TutorialIdent.TutoManager_FirstManagerDesk:
			case TutorialIdent.TutoManager_FirstManagerCard:
			case TutorialIdent.TutoBizAcq_StageBuilding:
			case TutorialIdent.TutoBizAcq_EnemyTeam:
			case TutorialIdent.TutoBizAcq_ReinforceManagerCard:
			case TutorialIdent.TutoWorldmap_FirstZoneBank:
			case TutorialIdent.TutoWorldmap_SecondZone:
			case TutorialIdent.TutoStrike_AGradeCompanyObj:
			case TutorialIdent.TutoFirstRichPoint_Bank5:
			case TutorialIdent.TutoSeasonal_FirstDormitory:
			case TutorialIdent.TutoSeasonal_FirstWorkShop:
			case TutorialIdent.TutoSeasonal_Restaurant:
			case TutorialIdent.TutoSeasonal_Distributor:
			case TutorialIdent.TutoSeasonal_ArcadeMachine:
			case TutorialIdent.TutoCarCollection_FirstBrand:
				return true;
			default:
				return false;
		}
	}

	public GameObject GetTarget(TutorialIdent id, int targetIdx = -1, int targetSubIdx = -1)
	{
		if (registerDic == null)
			return null;

		TutorialRegister reg;
		if (!registerDic.TryGetValue(id, out reg))
			return null;

		if (reg == null)
			return null;

		return reg.Target;
	}
}
