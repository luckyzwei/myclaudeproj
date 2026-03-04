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
		public _003CGotoOutGame_Coroutin_003Ed__36(int _003C_003E1__state)
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
		return null;
	}

	public void RegisteInGame(InGameMode mode)
	{
	}

	public void RegistOutGame(OutGameMode mode)
	{
	}

	public void UpdateOutGame()
	{
	}

	private void StartGame(GameType type, Action loadCallback = null, bool isNewRegion = false)
	{
	}

	public void ChangeMode(GameType type, Action _action = null)
	{
	}

	public void InitPopups()
	{
	}

	public void EnterNewStage()
	{
	}

	public void ChangeRegionStage(int region, bool pauseInitPopups = false, bool isNewRegion = false, Action endCallBack = null)
	{
	}

	public void NextGameStage(bool Init = false, bool nextStage = false)
	{
	}

	public void ChangeToSeasonalStage()
	{
	}

	public RegionData InitNewRegionData(int stage)
	{
		return null;
	}

	private void InitStageData(int stage)
	{
	}

	public void CloseWorldmap(Action cb = null)
	{
	}

	public void CloseOutGame(Action cb = null)
	{
	}

	public void GotoOutGame(GameType gameType, Action Cb = null, string place = "popup")
	{
	}

	[IteratorStateMachine(typeof(_003CGotoOutGame_Coroutin_003Ed__36))]
	private IEnumerator GotoOutGame_Coroutin(GameType gameType, Action Cb = null)
	{
		yield break;
	}

	public void CheatGoToGameStage(int stageIdx)
	{
	}

	public void PlayStageBgm()
	{
	}

	public void PlayOutGameBgm(GameType gameType)
	{
	}

	private void UnLoadCurGameMode()
	{
	}

	private void UnLoadCurStage()
	{
	}

	private int CalculatePoint(int stageIdx)
	{
		return 0;
	}

	public bool IsInOutGame(GameType type)
	{
		return false;
	}
}
