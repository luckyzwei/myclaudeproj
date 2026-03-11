using System;
using KWAnalytics.Analytics;
using KWCore.SaveData;
using KWCore.Stats;

namespace KWGameCore.Progress
{
	public class ProgressManager
	{
		private long m_levelStartTime;

		private long m_levelDurationUntilPause;

		private long m_levelProgressTime;

		private long m_totalLevelAdWatchedDuration;

		private long m_lastSavedLevelAdWatchedDuration;

		private long m_lastSavedLevelProgressDuration;

		private long m_totalLevelProgressDuration;

		private long m_adWatchedDurationPerLevel;

		private bool m_stageStarted;

		private string m_currentLevelId;

		private UseStatsManager m_useStatsManager;

		public int CurrentLevel
		{
			get { return BucketGameCore.GetProgressManagerLevelIndex(); }
			set { BucketGameCore.SetProgressManagerLevelIndex(value); }
		}

		public int CurrentStage
		{
			get { return BucketGameCore.GetProgressManagerStageIndex(); }
			set { BucketGameCore.SetProgressManagerStageIndex(value); }
		}

		public int LastActiveLevel
		{
			get { return BucketGameCore.GetLastActiveProgressManagerLevelIndex(); }
			set { BucketGameCore.SetLastActiveProgressManagerLevelIndex(value); }
		}

		public int LastActiveStage
		{
			get { return BucketGameCore.GetLastActiveProgressManagerStageIndex(); }
			set { BucketGameCore.SetLastActiveProgressManagerStageIndex(value); }
		}

		public void StartStage(int stageNumber = -1, int levelNumber = -1, string levelId = null, bool hasStages = false)
		{
			if (levelNumber >= 0)
			{
				CurrentLevel = levelNumber;
			}
			if (stageNumber >= 0)
			{
				CurrentStage = stageNumber;
			}

			LastActiveLevel = CurrentLevel;
			LastActiveStage = CurrentStage;

			m_currentLevelId = levelId ?? BucketGameCore.GetLevelClientId();
			m_stageStarted = true;
			m_levelStartTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
			m_levelDurationUntilPause = 0L;
			m_totalLevelAdWatchedDuration = 0L;
			m_totalLevelProgressDuration = 0L;
			m_adWatchedDurationPerLevel = 0L;

			BucketGameCore.SetCurrentLevelDuration(0L);
			BucketGameCore.SetCurrentLevelAdWatchedDuration(0L);
			BucketGameCore.SetLastStageCompleted(false);

			SetupUseStatsManager();

			SendLevelProgressEvent(CurrentLevel, CurrentStage, GameLevelProgressSchema.ProgressState.START, 0L, 0L, -1, m_currentLevelId);
		}

		public bool CompleteStage(int levelSize = 1, int score = -1, int stageNumber = -1, string levelId = null)
		{
			if (!m_stageStarted)
				return false;

			m_stageStarted = false;

			CalculateTotalLevelProgressAndAdWatchedDuration();

			string usedLevelId = levelId ?? m_currentLevelId;

			SendLevelProgressEvent(CurrentLevel, CurrentStage, GameLevelProgressSchema.ProgressState.COMPLETE,
				m_totalLevelProgressDuration, m_totalLevelAdWatchedDuration, score, usedLevelId);

			SaveLevelProgressDataOnQuit();

			BucketGameCore.SetLastStageCompleted(true);

			// Advance level
			BucketGameCore.IncrementAndSetProgressManagerLevelIndex(levelSize);
			BucketGameCore.SetProgressManagerStageIndex(0);

			LastActiveLevel = CurrentLevel;
			LastActiveStage = CurrentStage;

			return true;
		}

		public void FailStage(int score = -1, int stageNumber = -1, string levelId = null, bool hasStages = false)
		{
			if (!m_stageStarted)
				return;

			m_stageStarted = false;

			CalculateTotalLevelProgressAndAdWatchedDuration();

			string usedLevelId = levelId ?? m_currentLevelId;

			SendLevelProgressEvent(CurrentLevel, CurrentStage, GameLevelProgressSchema.ProgressState.FAIL,
				m_totalLevelProgressDuration, m_totalLevelAdWatchedDuration, score, usedLevelId);

			SaveLevelProgressDataOnQuit();

			BucketGameCore.SetLastStageCompleted(false);
		}

		public void FailedLevel(int levelNumber = -1)
		{
			if (levelNumber >= 0)
			{
				CurrentLevel = levelNumber;
			}
			BucketGameCore.SetLastStageCompleted(false);
		}

		public void ContinueLevel(int levelNumber = -1, string continueContext = null)
		{
			if (levelNumber >= 0)
			{
				CurrentLevel = levelNumber;
			}
			LastActiveLevel = CurrentLevel;
		}

		public void ContinueStage(int levelNumber = -1, int stageNumber = -1, string continueContext = null)
		{
			if (levelNumber >= 0)
			{
				CurrentLevel = levelNumber;
			}
			if (stageNumber >= 0)
			{
				CurrentStage = stageNumber;
			}
			LastActiveLevel = CurrentLevel;
			LastActiveStage = CurrentStage;
		}

		public void QuitStage(int score = -1, int stageNumber = -1, string levelId = null)
		{
			if (!m_stageStarted)
				return;

			m_stageStarted = false;

			CalculateTotalLevelProgressAndAdWatchedDuration();

			string usedLevelId = levelId ?? m_currentLevelId;

			SendLevelProgressEvent(CurrentLevel, CurrentStage, GameLevelProgressSchema.ProgressState.QUIT,
				m_totalLevelProgressDuration, m_totalLevelAdWatchedDuration, score, usedLevelId);

			SaveLevelProgressDataOnQuit();
		}

		public void OverrideLevel(int level)
		{
			CurrentLevel = level;
			LastActiveLevel = level;
		}

		public void OverrideStage(int stage)
		{
			CurrentStage = stage;
			LastActiveStage = stage;
		}

		public void OverrideLastActiveLevel(int level)
		{
			LastActiveLevel = level;
		}

		public void DoOnApplicationPause(bool pause)
		{
			if (pause)
			{
				SaveLevelProgressOnPause();
			}
			else
			{
				// Resuming from pause - reset level start time
				if (m_stageStarted)
				{
					m_levelStartTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
				}
			}
		}

		private void CalculateTotalLevelProgressAndAdWatchedDuration()
		{
			long now = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
			long elapsed = now - m_levelStartTime;
			m_totalLevelProgressDuration = m_levelDurationUntilPause + elapsed;
			m_totalLevelAdWatchedDuration = m_adWatchedDurationPerLevel;
		}

		private void SaveLevelProgressDataOnQuit()
		{
			BucketGameCore.SetCurrentLevelDuration(m_totalLevelProgressDuration);
			BucketGameCore.SetCurrentLevelAdWatchedDuration(m_totalLevelAdWatchedDuration);
			m_lastSavedLevelProgressDuration = m_totalLevelProgressDuration;
			m_lastSavedLevelAdWatchedDuration = m_totalLevelAdWatchedDuration;
		}

		private void SaveLevelProgressOnPause()
		{
			if (!m_stageStarted)
				return;

			CalculateTotalLevelProgressAndAdWatchedDuration();
			m_levelDurationUntilPause = m_totalLevelProgressDuration;

			BucketGameCore.SetCurrentLevelDuration(m_totalLevelProgressDuration);
			BucketGameCore.SetCurrentLevelAdWatchedDuration(m_totalLevelAdWatchedDuration);
		}

		private void SendLevelProgressEvent(int level, int stage, GameLevelProgressSchema.ProgressState state, long levelProgressDuration = 0L, long levelAdWatchedDuration = 0L, int score = -1, string levelId = null)
		{
			int attemptCount = GetLevelAttemptCount(levelId, state);
		}

		private void HandleAdWatchedEvent(long adWatchedDuration)
		{
			m_adWatchedDurationPerLevel += adWatchedDuration;
			m_totalLevelAdWatchedDuration += adWatchedDuration;
		}

		private void MigrateOldProgressManager()
		{
		}

		private void SetupUseStatsManager()
		{
			if (m_useStatsManager != null && m_currentLevelId != null)
			{
				m_useStatsManager.SetLevelClientID(m_currentLevelId);
			}
		}

		private int GetLevelAttemptCount(string levelId, GameLevelProgressSchema.ProgressState state)
		{
			if (string.IsNullOrEmpty(levelId))
				return 0;

			if (state == GameLevelProgressSchema.ProgressState.START)
			{
				return BucketGameCore.IncrementAndSetLevelAttemptCount(levelId);
			}
			return BucketGameCore.GetLevelAttemptCount(levelId);
		}

		public bool IsStageActive()
		{
			return m_stageStarted;
		}
	}
}
