using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameSystem
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass36_0
	{
		public GameType gameType;

		public Action Cb;

		internal bool _003CGotoOutGame_Coroutin_003Eb__0()
		{
			return false;
		}

		internal void _003CGotoOutGame_Coroutin_003Eb__1()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CGotoOutGame_Coroutin_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameType gameType;

		public Action Cb;

		private _003C_003Ec__DisplayClass36_0 _003C_003E8__1;

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
		public _003CGotoOutGame_Coroutin_003Ed__36(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
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

	public bool nextStage;

	private bool firstInit;

	private bool IsEnterNewStage;

	[HideInInspector]
	public bool isNextEventNotice;

	private static readonly Dictionary<GameType, string> SceneNameMap = new Dictionary<GameType, string>
	{
		{ GameType.Main, "InGameOffice" },
		{ GameType.Factory, "InGameFactory" },
		{ GameType.House, "InGameHouse" },
		{ GameType.Seasonal, "InGameSeasonal" },
		{ GameType.WorldMap, "InGameWorldmap" },
	};

	public InGameMode CurInGame { get; private set; }

	public OutGameMode CurOutGame { get; private set; }

	public bool PauseInitPopups { get; private set; }

	public bool inInitPopups { get; private set; }

	public T GetInGame<T>() where T : InGameMode
	{
		return CurInGame as T;
	}

	public void RegisteInGame(InGameMode mode)
	{
		CurInGame = mode;
	}

	public void RegistOutGame(OutGameMode mode)
	{
		CurOutGame = mode;
	}

	public void UpdateOutGame()
	{
		if (CurOutGame != null)
		{
			// OutGame update logic handled by MonoBehaviour
		}
	}

	public void StartFirstGame(GameType type, Action loadCallback = null)
	{
		StartGame(type, loadCallback);
	}

	private void StartGame(GameType type, Action loadCallback = null, bool isNewRegion = false)
	{
		string sceneName;
		if (!SceneNameMap.TryGetValue(type, out sceneName))
		{
			loadCallback?.Invoke();
			return;
		}

		// Check if scene is already loaded
		var scene = SceneManager.GetSceneByName(sceneName);
		if (scene.isLoaded)
		{
			OnSceneLoaded(scene, type, loadCallback, isNewRegion);
			return;
		}

		// Load scene additively
		var op = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
		if (op == null)
		{
			UnityEngine.Debug.LogWarning("[InGameSystem] Failed to load scene: " + sceneName);
			loadCallback?.Invoke();
			return;
		}
		op.completed += (asyncOp) =>
		{
			var loadedScene = SceneManager.GetSceneByName(sceneName);
			OnSceneLoaded(loadedScene, type, loadCallback, isNewRegion);
		};
	}

	private void OnSceneLoaded(Scene scene, GameType type, Action loadCallback, bool isNewRegion)
	{
		if (!scene.IsValid())
		{
			loadCallback?.Invoke();
			return;
		}

		// Find InGameMode or OutGameMode in scene root objects
		var rootObjects = scene.GetRootGameObjects();
		for (int i = 0; i < rootObjects.Length; i++)
		{
			var inGame = rootObjects[i].GetComponentInChildren<InGameMode>(true);
			if (inGame != null)
			{
				CurInGame = inGame;
				inGame.Load();
				inGame.LoadUI();
				break;
			}

			var outGame = rootObjects[i].GetComponentInChildren<OutGameMode>(true);
			if (outGame != null)
			{
				CurOutGame = outGame;
				outGame.Load();
				break;
			}
		}

		loadCallback?.Invoke();
	}

	public void ChangeMode(GameType type, Action _action = null)
	{
		UnLoadCurGameMode();
		StartGame(type, _action);
	}

	public void InitPopups()
	{
		if (PauseInitPopups)
			return;

		inInitPopups = true;
		// Initialize various popups (login bonus, daily quest, etc.)
		inInitPopups = false;
	}

	public void EnterNewStage()
	{
		IsEnterNewStage = true;
		nextStage = true;
	}

	public void ChangeRegionStage(int region, bool pauseInitPopups = false, bool isNewRegion = false, Action endCallBack = null)
	{
		PauseInitPopups = pauseInitPopups;

		if (isNewRegion)
		{
			InitNewRegionData(region);
		}

		StartGame(GameType.Main, () =>
		{
			if (!pauseInitPopups)
			{
				InitPopups();
			}
			endCallBack?.Invoke();
		}, isNewRegion);
	}

	public void NextGameStage(bool Init = false, bool nextStage = false)
	{
		this.nextStage = nextStage;

		if (Init && !firstInit)
		{
			firstInit = true;
			InitPopups();
		}
	}

	public void ChangeToSeasonalStage()
	{
		ChangeMode(GameType.Seasonal);
	}

	public RegionData InitNewRegionData(int stage)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null || root.UserData.mainData == null) return null;

		var mainData = root.UserData.mainData;
		if (mainData.RegionDatas == null)
			mainData.RegionDatas = new Dictionary<int, RegionData>();

		var region = new RegionData();
		region.StageData = new StageData();
		region.StageData.Init(stage);
		region.OfflineData = new OfflineData { LastLoginTime = System.DateTime.UtcNow };
		region.BuyParkingLotData = new System.Collections.Generic.List<BuyParkingLotData>();
		mainData.RegionDatas[stage] = region;
		mainData.ActiveRegion = stage;
		return region;
	}

	private void InitStageData(int stage)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null || root.UserData.mainData == null) return;
		var mainData = root.UserData.mainData;
		mainData.ActiveRegion = stage;
	}

	public void CloseWorldmap(Action cb = null)
	{
		UnLoadOutGame();
		cb?.Invoke();
	}

	public void CloseOutGame(Action cb = null)
	{
		UnLoadOutGame();
		cb?.Invoke();
	}

	private void UnLoadOutGame()
	{
		if (CurOutGame != null)
		{
			CurOutGame.UnLoad();
			CurOutGame = null;
		}
	}

	public void GotoOutGame(GameType gameType, Action Cb = null, string place = "popup")
	{
		UnLoadCurStage();
		StartGame(gameType, Cb);
	}

	[IteratorStateMachine(typeof(_003CGotoOutGame_Coroutin_003Ed__36))]
	private IEnumerator GotoOutGame_Coroutin(GameType gameType, Action Cb = null)
	{
		yield break;
	}

	public void CheatGoToGameStage(int stageIdx)
	{
		InitStageData(stageIdx);
		ChangeMode(GameType.Main);
	}

	public void PlayStageBgm()
	{
		// Play background music for current stage
	}

	public void PlayOutGameBgm(GameType gameType)
	{
		// Play background music for out-game screen
	}

	private void UnLoadCurGameMode()
	{
		if (CurInGame != null)
		{
			CurInGame.UnLoadUI();
			CurInGame.UnLoad();

			// Unload the additive scene
			var go = CurInGame.gameObject;
			if (go != null && go.scene.IsValid() && go.scene.name != "Main")
			{
				SceneManager.UnloadSceneAsync(go.scene);
			}
			CurInGame = null;
		}
		UnLoadOutGame();
	}

	private void UnLoadCurStage()
	{
		UnLoadCurGameMode();
	}

	private int CalculatePoint(int stageIdx)
	{
		return stageIdx * 100;
	}

	public bool IsInOutGame(GameType type)
	{
		if (CurOutGame == null)
			return false;

		return CurOutGame.gameObject.activeInHierarchy;
	}
}
