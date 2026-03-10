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
			[DebuggerHidden] get { return _003C_003E2__current; }
		}

		object IEnumerator.Current
		{
			[DebuggerHidden] get { return _003C_003E2__current; }
		}

		[DebuggerHidden]
		public _003CGameOverSequence_003Ed__45(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose() { }

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
				case 0:
					_003C_003E1__state = -1;
					_003C_003E2__current = new WaitForSeconds(1f);
					_003C_003E1__state = 1;
					return true;
				case 1:
					_003C_003E1__state = -1;
					if (GameManager.Instance != null)
						GameManager.Instance.GameOver();
					return false;
				default:
					return false;
			}
		}

		bool IEnumerator.MoveNext()
		{
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset() { }
	}

	[CompilerGenerated]
	private sealed class _003CWinSequence_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;
		private object _003C_003E2__current;
		public QueensGameController _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden] get { return _003C_003E2__current; }
		}

		object IEnumerator.Current
		{
			[DebuggerHidden] get { return _003C_003E2__current; }
		}

		[DebuggerHidden]
		public _003CWinSequence_003Ed__44(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose() { }

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
				case 0:
					_003C_003E1__state = -1;
					if (_003C_003E4__this.m_grid != null)
						_003C_003E4__this.m_grid.DisableInput();
					_003C_003E2__current = new WaitForSeconds(1.5f);
					_003C_003E1__state = 1;
					return true;
				case 1:
					_003C_003E1__state = -1;
					if (GameManager.Instance != null)
						GameManager.Instance.LevelComplete();
					return false;
				default:
					return false;
			}
		}

		bool IEnumerator.MoveNext()
		{
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset() { }
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

	public QueensGrid Grid => m_grid;

	public int CurrentLifeAmount => m_currentLifeAmount;

	public bool IsRevived => m_isRevived;

	public static QueenSFX CurrentSFX => Instance != null ? Instance.m_sfxSet : null;

	public bool IsPaused => m_isPaused;

	public int NumSequentialLosses => m_numSequentialLosses;

	private void Awake()
	{
		Instance = this;
		m_openPopupsHashCodes = new HashSet<int>();
	}

	private long GetTimeNow()
	{
		return System.DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
	}

	public float GetElapsedTimeSeconds(bool forceLiveTime = false)
	{
		long endTime = (m_finishedTimeStamp > 0 && !forceLiveTime) ? m_finishedTimeStamp : GetTimeNow();
		long elapsed = endTime - m_startTimeStamp - m_totalPausedTime;
		return elapsed / 1000f;
	}

	public void PauseTimer()
	{
		if (m_isPaused) return;
		m_isPaused = true;
		m_pauseStartTimeStamp = GetTimeNow();
	}

	public void ResumeTimer()
	{
		if (!m_isPaused) return;
		m_isPaused = false;
		m_totalPausedTime += GetTimeNow() - m_pauseStartTimeStamp;
	}

	public void StartLevelTimer()
	{
		m_startTimeStamp = GetTimeNow();
		m_finishedTimeStamp = 0;
		m_totalPausedTime = 0;
		m_isPaused = false;
	}

	public void StartGame(LevelData levelData, bool pauseTimerForPopups)
	{
		m_levelData = levelData;
		m_pauseTimerForPopups = pauseTimerForPopups;
		m_isRevived = false;
		m_numSequentialLosses = 0;

		// Determine hearts based on difficulty
		m_currentLifeAmount = NumOfHeartsFromDifficulty(levelData.levelDifficulty);
		if (m_overridenHearts > 0)
			m_currentLifeAmount = m_overridenHearts;

		// Configure grid
		if (m_grid != null)
		{
			m_grid.QueenMarked -= OnQueenMarked;
			m_grid.LifeLost -= OnLifeLost;
			m_grid.QueenMarked += OnQueenMarked;
			m_grid.LifeLost += OnLifeLost;
			m_grid.Configure(levelData);
			m_grid.EnableLosingLife(true);
			m_grid.EnableInput();
		}

		StartLevelTimer();
		ApplySFX();
	}

	private void OnQueenMarked(int cellIndex)
	{
		if (m_grid != null && m_grid.GetRemainingQueens() == 0)
			LevelSolved();
	}

	private void OnLifeLost(int cellIndex)
	{
		LoseLife();
	}

	private void OnPopupShown(PopUpBase obj)
	{
		if (obj == null) return;
		int hash = obj.GetHashCode();
		m_openPopupsHashCodes.Add(hash);
		if (m_pauseTimerForPopups)
			PauseTimer();
	}

	private void OnPopupClosed(PopUpBase obj)
	{
		if (obj == null) return;
		int hash = obj.GetHashCode();
		m_openPopupsHashCodes.Remove(hash);
		if (m_pauseTimerForPopups && m_openPopupsHashCodes.Count == 0)
			ResumeTimer();
	}

	private void QueenSkinChanged()
	{
		ApplySFX();
	}

	private void ApplySFX()
	{
		var skinSfx = SkinSFX.Instance;
		if (skinSfx != null && skinSfx.m_sfxList != null && skinSfx.m_sfxList.Count > 0)
			m_sfxSet = skinSfx.m_sfxList[0]; // Use default SFX set
	}

	public void Revive()
	{
		m_isRevived = true;
		m_currentLifeAmount = 1;
		if (m_grid != null)
		{
			m_grid.EnableInput();
			m_grid.EnableLosingLife(true);
		}
		ResumeTimer();
	}

	public void LevelSolved()
	{
		m_finishedTimeStamp = GetTimeNow();
		m_numSequentialLosses = 0;
		if (m_grid != null)
			m_grid.DisableInput();
		StartCoroutine(WinSequence());
	}

	public bool LoseLife()
	{
		m_currentLifeAmount--;
		LifeLostEvent?.Invoke();

		if (m_currentLifeAmount <= 0)
		{
			m_numSequentialLosses++;
			m_finishedTimeStamp = GetTimeNow();
			if (m_grid != null)
				m_grid.DisableInput();
			StartCoroutine(GameOverSequence());
			return true;
		}
		return false;
	}

	public int NumLivesInThisLevel()
	{
		if (m_levelData == null) return 3;
		return NumOfHeartsFromDifficulty(m_levelData.levelDifficulty);
	}

	private int NumOfHeartsFromDifficulty(LevelDifficulty levelDifficulty)
	{
		switch (levelDifficulty)
		{
			case LevelDifficulty.NORMAL:
				return 3;
			case LevelDifficulty.HARD:
				return 2;
			default:
				return 3;
		}
	}

	[IteratorStateMachine(typeof(_003CWinSequence_003Ed__44))]
	private IEnumerator WinSequence()
	{
		var d = new _003CWinSequence_003Ed__44(0);
		d._003C_003E4__this = this;
		return d;
	}

	[IteratorStateMachine(typeof(_003CGameOverSequence_003Ed__45))]
	private IEnumerator GameOverSequence()
	{
		return new _003CGameOverSequence_003Ed__45(0);
	}

	public bool HasPermanentAutoX()
	{
		// Auto-X is an unlockable feature, off by default
		return false;
	}

	public bool IsAutoXAvailable()
	{
		return HasPermanentAutoX() || IsAutoXActiveOnlyForThisLevel();
	}

	public bool IsAutoXActiveOnlyForThisLevel()
	{
		return false;
	}

	public void UnlockedAutoXForCurrentLevel()
	{
		// Temporary auto-X for this level only
	}

	public float GetTotalPausedTime()
	{
		return m_totalPausedTime / 1000f;
	}
}
