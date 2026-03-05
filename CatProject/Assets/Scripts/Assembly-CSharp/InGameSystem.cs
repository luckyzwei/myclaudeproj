using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

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

	private void StartGame(GameType type, Action loadCallback = null, bool isNewRegion = false)
	{
		// Would load the game scene for the given type
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
		// Would initialize and show queued popups
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
		// Would create and initialize a new RegionData for the given stage
		return null;
	}

	private void InitStageData(int stage)
	{
		// Would load stage configuration data
	}

	public void CloseWorldmap(Action cb = null)
	{
		if (CurOutGame != null)
		{
			// Would close the worldmap UI
		}
		cb?.Invoke();
	}

	public void CloseOutGame(Action cb = null)
	{
		if (CurOutGame != null)
		{
			// Would close the current out-game mode
		}
		cb?.Invoke();
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
		// Would play stage background music via SoundSystem
	}

	public void PlayOutGameBgm(GameType gameType)
	{
		// Would play out-game background music based on type
	}

	private void UnLoadCurGameMode()
	{
		if (CurInGame != null)
		{
			// Would unload the current in-game mode's resources
			CurInGame = null;
		}
	}

	private void UnLoadCurStage()
	{
		UnLoadCurGameMode();
	}

	private int CalculatePoint(int stageIdx)
	{
		// Would calculate stage points based on configuration
		return stageIdx * 100;
	}

	public bool IsInOutGame(GameType type)
	{
		if (CurOutGame == null)
			return false;

		// Check if currently in the specified out-game type
		return CurOutGame.gameObject.activeInHierarchy;
	}
}
