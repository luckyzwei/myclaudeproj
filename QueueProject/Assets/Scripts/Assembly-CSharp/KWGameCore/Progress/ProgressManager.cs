using KWAnalytics.Analytics;
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
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int CurrentStage
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int LastActiveLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int LastActiveStage
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public void StartStage(int stageNumber = -1, int levelNumber = -1, string levelId = null, bool hasStages = false)
		{
		}

		public bool CompleteStage(int levelSize = 1, int score = -1, int stageNumber = -1, string levelId = null)
		{
			return false;
		}

		public void FailStage(int score = -1, int stageNumber = -1, string levelId = null, bool hasStages = false)
		{
		}

		public void FailedLevel(int levelNumber = -1)
		{
		}

		public void ContinueLevel(int levelNumber = -1, string continueContext = null)
		{
		}

		public void ContinueStage(int levelNumber = -1, int stageNumber = -1, string continueContext = null)
		{
		}

		public void QuitStage(int score = -1, int stageNumber = -1, string levelId = null)
		{
		}

		public void OverrideLevel(int level)
		{
		}

		public void OverrideStage(int stage)
		{
		}

		public void OverrideLastActiveLevel(int level)
		{
		}

		public void DoOnApplicationPause(bool pause)
		{
		}

		private void CalculateTotalLevelProgressAndAdWatchedDuration()
		{
		}

		private void SaveLevelProgressDataOnQuit()
		{
		}

		private void SaveLevelProgressOnPause()
		{
		}

		private void SendLevelProgressEvent(int level, int stage, GameLevelProgressSchema.ProgressState state, long levelProgressDuration = 0L, long levelAdWatchedDuration = 0L, int score = -1, string levelId = null)
		{
		}

		private void HandleAdWatchedEvent(long adWatchedDuration)
		{
		}

		private void MigrateOldProgressManager()
		{
		}

		private void SetupUseStatsManager()
		{
		}

		private int GetLevelAttemptCount(string levelId, GameLevelProgressSchema.ProgressState state)
		{
			return 0;
		}

		public bool IsStageActive()
		{
			return false;
		}
	}
}
