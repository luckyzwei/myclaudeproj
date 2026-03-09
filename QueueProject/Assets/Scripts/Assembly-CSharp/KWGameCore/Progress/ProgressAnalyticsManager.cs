using KWCore.Stats;

namespace KWGameCore.Progress
{
	public class ProgressAnalyticsManager
	{
		private ProgressManager m_progressManager;

		private UseStatsManager m_useStatsManager;

		public ProgressAnalyticsManager(ProgressManager progressManager, UseStatsManager useStatsManager)
		{
		}

		private void HandleLevelCompletedEvent()
		{
		}

		private void HandleGameStageCompletedEvent(int stageNumber, bool hasStages = false)
		{
		}

		private void HandleGameStageFailedEvent(int stageNumber, bool hasStages = false)
		{
		}

		private void HandleGameLevelFailedEvent(int levelNumber)
		{
		}

		private void HandleGameLevelContinuedEvent(int levelNumber, string continueContext)
		{
		}

		private void HandleGameStageContinuedEvent(int levelNumber, int stageNumber, string continueContext)
		{
		}

		private void HandleGameStageStartedEvent(int stageNumber, bool hasStages = false)
		{
		}
	}
}
