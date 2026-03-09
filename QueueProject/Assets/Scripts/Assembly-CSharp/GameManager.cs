using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;
using KWCore.Utils;
using UnityEngine;

public class GameManager : MonoSingleton<GameManager>
{
	public enum GameMode
	{
		STANDARD = 0,
		DAILY_CHALLENGE = 1,
		TOURNAMENT = 2,
		PVP = 3,
		EXPERT_MODE = 4
	}

	[CompilerGenerated]
	private sealed class _003CStart_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;
		private object _003C_003E2__current;
		public GameManager _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden] get { return _003C_003E2__current; }
		}

		object IEnumerator.Current
		{
			[DebuggerHidden] get { return _003C_003E2__current; }
		}

		[DebuggerHidden]
		public _003CStart_003Ed__46(int _003C_003E1__state)
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
					UnityEngine.Application.targetFrameRate = TARGET_FRAME_RATE;
					_003C_003E4__this.m_boot = true;

					// Wait one frame for everything to initialize
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				case 1:
					_003C_003E1__state = -1;
					// Auto-start first level if we have a test level
					if (_003C_003E4__this.m_testLevel != null && !_003C_003E4__this.m_startedGameSuccessfully)
					{
						_003C_003E4__this.StartGame(GameMode.STANDARD, _003C_003E4__this.m_testLevel);
					}
					else if (_003C_003E4__this.m_levelOrder != null)
					{
						// Start from player's current level
						_003C_003E4__this.StartGame(GameMode.STANDARD);
					}
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

	public const ulong AUDIO_1_SEC_DELAY = 44100uL;

	private const int TARGET_FRAME_RATE = 60;

	[SerializeField]
	private LevelDataScriptable m_testLevel;

	[SerializeField]
	private LevelDataScriptable m_ftueLevel;

	[SerializeField]
	private LevelOrder m_levelOrder;

	[SerializeField]
	private QueensGameController m_queenGameController;

	[SerializeField]
	private Canvas m_canvas;

	[SerializeField]
	private LevelCompletionPercentScriptable m_levelCompletionPercent;

	[SerializeField]
	private CinemachineVirtualCamera m_camera;

	private bool m_boot;

	private LevelDataScriptable m_currentLevelScriptable;

	private PopUpLoading m_popUpLoading;

	private bool m_kwaleeSdkLoading;

	private bool m_playIntPlayed;

	private int m_leaderboardScoreThisLevel;

	private bool m_replayingChallenge;

	private bool m_startedGameSuccessfully;

	private GameMode m_gameMode;

	private int m_rewardStars;

	private bool m_overrideStars;

	private bool m_isInGame;

	private bool m_watchedRvForDC;

	private bool m_isTimedLevel;

	public bool Boot => m_boot;

	public GameMode CurrentGameMode => m_gameMode;

	public bool IsInGame => m_isInGame;

	public LevelOrder LevelOrder => m_levelOrder;

	public LevelDataScriptable CurrentLevelScriptable => m_currentLevelScriptable;

	public LevelCompletionPercentScriptable LevelCompletionPercentScriptable => m_levelCompletionPercent;

	public CinemachineVirtualCamera Camera => m_camera;

	public bool ReplayingChallenge => m_replayingChallenge;

	public bool StartedGameSuccessfully => m_startedGameSuccessfully;

	public bool IsTimedLevel => m_isTimedLevel;

	protected override void Init()
	{
		m_boot = false;
		m_isInGame = false;
		m_startedGameSuccessfully = false;
	}

	private void OnApplicationFocus(bool hasFocus)
	{
		if (!hasFocus && m_isInGame && m_queenGameController != null)
			m_queenGameController.PauseTimer();
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__46))]
	private IEnumerator Start()
	{
		var d = new _003CStart_003Ed__46(0);
		d._003C_003E4__this = this;
		return d;
	}

	private void OnKwaleeSdkLoaded()
	{
		m_kwaleeSdkLoading = false;
	}

	public void WatchedRVForDailyChallenge()
	{
		m_watchedRvForDC = true;
	}

	public bool StartGame(GameMode gameMode, LevelDataScriptable puzzle = null)
	{
		m_gameMode = gameMode;
		m_leaderboardScoreThisLevel = 0;
		m_rewardStars = 0;
		m_overrideStars = false;

		if (puzzle != null)
		{
			m_currentLevelScriptable = puzzle;
		}
		else if (m_levelOrder != null)
		{
			int currentLevel = 0;
			if (LevelManager.Exist)
				currentLevel = 0; // Would get from save data
			m_currentLevelScriptable = m_levelOrder.GetLevel(currentLevel);
		}

		if (m_currentLevelScriptable == null || m_currentLevelScriptable.data == null)
		{
			UnityEngine.Debug.LogWarning("[GameManager] No level data available");
			return false;
		}

		LoadGameplay(m_currentLevelScriptable.data);
		m_startedGameSuccessfully = true;
		return true;
	}

	public LevelDataScriptable GetNextLevelScriptable(int offset = 1)
	{
		if (m_levelOrder == null) return null;
		int currentIndex = 0;
		if (m_levelOrder.levelOrder != null && m_levelOrder.levelOrder.levels != null)
		{
			for (int i = 0; i < m_levelOrder.levelOrder.levels.Count; i++)
			{
				if (m_levelOrder.levelOrder.levels[i] == m_currentLevelScriptable)
				{
					currentIndex = i;
					break;
				}
			}
		}
		return m_levelOrder.GetLevel(currentIndex + offset);
	}

	private void LoadGameplay(LevelData levelData)
	{
		m_isInGame = true;
		if (m_queenGameController != null)
		{
			m_queenGameController.StartGame(levelData, true);
		}
	}

	public void GameOver()
	{
		m_isInGame = false;
		UnityEngine.Debug.Log("[GameManager] Game Over");
		// Show game over popup or return to home
	}

	public void TournamentRoundFinished(bool outOfLives = false)
	{
		m_isInGame = false;
	}

	public void LevelComplete()
	{
		m_isInGame = false;
		UnityEngine.Debug.Log("[GameManager] Level Complete!");
		// Show level complete screen, advance to next level
	}

	private void GiveWeeklyLeaderboardScore(string context, int overrideScore = -1)
	{
		// Skip - leaderboard
	}

	public void SetRewardStars(int stars)
	{
		m_rewardStars = stars;
		m_overrideStars = true;
	}

	public void ClearOverrideStars()
	{
		m_overrideStars = false;
		m_rewardStars = 0;
	}

	public int GetLevelLeaderboardPoints()
	{
		return m_leaderboardScoreThisLevel;
	}

	public void ReturnToHomeScreen()
	{
		m_isInGame = false;
		// Navigate to home screen
	}

	public void Restart()
	{
		if (m_currentLevelScriptable != null && m_currentLevelScriptable.data != null)
		{
			StartGame(m_gameMode, m_currentLevelScriptable);
		}
	}

	public void SetReplayingChallenge(bool replaying)
	{
		m_replayingChallenge = replaying;
	}

	public void SetBannerVisibility(bool show)
	{
		// Skip - ads
	}

	public void StartLevelTimer()
	{
		if (m_queenGameController != null)
			m_queenGameController.StartLevelTimer();
	}

	public void SetTimedLevel(bool timedLevel)
	{
		m_isTimedLevel = timedLevel;
	}

	private void OnApplicationPause(bool pauseStatus)
	{
		if (pauseStatus && m_isInGame && m_queenGameController != null)
			m_queenGameController.PauseTimer();
		else if (!pauseStatus && m_isInGame && m_queenGameController != null)
			m_queenGameController.ResumeTimer();
	}
}
