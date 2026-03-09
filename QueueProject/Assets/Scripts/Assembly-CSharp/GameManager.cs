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
		public _003CStart_003Ed__46(int _003C_003E1__state)
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

	public bool Boot => false;

	public GameMode CurrentGameMode => default(GameMode);

	public bool IsInGame => false;

	public LevelOrder LevelOrder => null;

	public LevelDataScriptable CurrentLevelScriptable => null;

	public LevelCompletionPercentScriptable LevelCompletionPercentScriptable => null;

	public CinemachineVirtualCamera Camera => null;

	public bool ReplayingChallenge => false;

	public bool StartedGameSuccessfully => false;

	public bool IsTimedLevel => false;

	protected override void Init()
	{
	}

	private void OnApplicationFocus(bool hasFocus)
	{
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__46))]
	private IEnumerator Start()
	{
		return null;
	}

	private void OnKwaleeSdkLoaded()
	{
	}

	public void WatchedRVForDailyChallenge()
	{
	}

	public bool StartGame(GameMode gameMode, LevelDataScriptable puzzle = null)
	{
		return false;
	}

	public LevelDataScriptable GetNextLevelScriptable(int offset = 1)
	{
		return null;
	}

	private void LoadGameplay(LevelData levelData)
	{
	}

	public void GameOver()
	{
	}

	public void TournamentRoundFinished(bool outOfLives = false)
	{
	}

	public void LevelComplete()
	{
	}

	private void GiveWeeklyLeaderboardScore(string context, int overrideScore = -1)
	{
	}

	public void SetRewardStars(int stars)
	{
	}

	public void ClearOverrideStars()
	{
	}

	public int GetLevelLeaderboardPoints()
	{
		return 0;
	}

	public void ReturnToHomeScreen()
	{
	}

	public void Restart()
	{
	}

	public void SetReplayingChallenge(bool replaying)
	{
	}

	public void SetBannerVisibility(bool show)
	{
	}

	public void StartLevelTimer()
	{
	}

	public void SetTimedLevel(bool timedLevel)
	{
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}
}
