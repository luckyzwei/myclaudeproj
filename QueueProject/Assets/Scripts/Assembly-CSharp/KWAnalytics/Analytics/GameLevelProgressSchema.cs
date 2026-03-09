using System;

namespace KWAnalytics.Analytics
{
	[Serializable]
	public class GameLevelProgressSchema : ClosedSchema
	{
		public enum ProgressState
		{
			START = 0,
			COMPLETE = 1,
			FAIL = 2,
			QUIT = 3
		}

		public GameLevelProgressSchema(int level, int stage, ProgressState progressState, int attemptCount, string gameStageId, long levelProgressDuration, long levelAdWatchedDuration)
		{
		}
	}
}
