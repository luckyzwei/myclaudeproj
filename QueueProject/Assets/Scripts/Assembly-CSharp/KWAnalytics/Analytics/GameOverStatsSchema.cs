using System;

namespace KWAnalytics.Analytics
{
	[Serializable]
	public class GameOverStatsSchema : OpenSchema
	{
		public enum CompletedStatus
		{
			SUCCESS = 0,
			FAILED = 1,
			RETRY = 2,
			SKIPPED = 3
		}

		private const string EVENT_NAME = "game_over_stats";

		public int GameStageEnvObjectDamage
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int GameStageEnvObjectHealth
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public GameOverStatsSchema()
		{
		}

		public GameOverStatsSchema(string levelID, int levelNumber, string stageID, int stageNumber)
		{
		}

		protected override string GetUniqueKeyForJoin()
		{
			return null;
		}

		public void SetGameStageOutcome(CompletedStatus completedStatus)
		{
		}

		public void SetGameStageItem(string item)
		{
		}

		public void SetGameLevelContext(string context)
		{
		}

		public void SetGameStageContext(string context)
		{
		}

		public void SetGameStageEnvObjectID(string id)
		{
		}

		public void SetGameStageEnvObjectType(string id)
		{
		}

		public void SetGameStagePlayerObjectID(string id)
		{
		}

		public void SetGameStagePlayerObjectType(string type)
		{
		}

		public void SetGameStagePlayerObjectHealth(int value)
		{
		}

		public void SetGameStageRewardUsed(bool used)
		{
		}

		public void SetGameStageDuration(long duration)
		{
		}

		public void SetGameStageProgression(float progress)
		{
		}

		public void SetGameStageRewardID(string rewardID)
		{
		}

		public void SetGameStageRewardType(string rewardType)
		{
		}

		public void SetGameStageCount(int count)
		{
		}

		public void SetGameStageScore(int score)
		{
		}

		public void SetGameStageDistance(float distance)
		{
		}

		public void SetGameStagePlayerObjectCount(int count)
		{
		}

		public void SetGameLevelType(string levelType)
		{
		}

		public void SetGameStageEnvObjectCount(int count)
		{
		}

		public void SetGameStagePosition(int position)
		{
		}

		public void SetGameStageType(string type)
		{
		}
	}
}
