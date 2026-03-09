using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Balancy.Models;
using KWCore.UI;
using UnityEngine;

public class QueensGameController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CGameOverSequence_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CGameOverSequence_003Ed__45(int _003C_003E1__state)
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
	private sealed class _003CWinSequence_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public QueensGameController _003C_003E4__this;

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
		public _003CWinSequence_003Ed__44(int _003C_003E1__state)
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

	public static QueensGameController Instance;

	[SerializeField]
	private QueensGrid m_grid;

	public static Action LifeLostEvent;

	private int m_currentLifeAmount;

	private bool m_isRevived;

	private LevelData m_levelData;

	private int m_numSequentialLosses;

	private int m_overridenHearts;

	private QueenSFX m_sfxSet;

	private HashSet<int> m_openPopupsHashCodes;

	private long m_startTimeStamp;

	private long m_finishedTimeStamp;

	private long m_totalPausedTime;

	private long m_pauseStartTimeStamp;

	private bool m_isPaused;

	private bool m_pauseTimerForPopups;

	public QueensGrid Grid => null;

	public int CurrentLifeAmount => 0;

	public bool IsRevived => false;

	public static QueenSFX CurrentSFX => null;

	public bool IsPaused => false;

	public int NumSequentialLosses => 0;

	private void Awake()
	{
	}

	private long GetTimeNow()
	{
		return 0L;
	}

	public float GetElapsedTimeSeconds(bool forceLiveTime = false)
	{
		return 0f;
	}

	public void PauseTimer()
	{
	}

	public void ResumeTimer()
	{
	}

	public void StartLevelTimer()
	{
	}

	public void StartGame(LevelData levelData, bool pauseTimerForPopups)
	{
	}

	private void OnPopupShown(PopUpBase obj)
	{
	}

	private void OnPopupClosed(PopUpBase obj)
	{
	}

	private void QueenSkinChanged()
	{
	}

	private void ApplySFX()
	{
	}

	public void Revive()
	{
	}

	public void LevelSolved()
	{
	}

	public bool LoseLife()
	{
		return false;
	}

	public int NumLivesInThisLevel()
	{
		return 0;
	}

	private int NumOfHeartsFromDifficulty(LevelDifficulty levelDifficulty)
	{
		return 0;
	}

	[IteratorStateMachine(typeof(_003CWinSequence_003Ed__44))]
	private IEnumerator WinSequence()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CGameOverSequence_003Ed__45))]
	private IEnumerator GameOverSequence()
	{
		return null;
	}

	public bool HasPermanentAutoX()
	{
		return false;
	}

	public bool IsAutoXAvailable()
	{
		return false;
	}

	public bool IsAutoXActiveOnlyForThisLevel()
	{
		return false;
	}

	public void UnlockedAutoXForCurrentLevel()
	{
	}

	public float GetTotalPausedTime()
	{
		return 0f;
	}
}
