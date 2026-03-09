using System;
using System.Runtime.CompilerServices;
using KWGameCore.Interface;

namespace KWGameCore.Events
{
	public class GameCoreEvents
	{
		public static event Action LevelCompleted
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<int, bool> GameStageStarted
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action GameplayLevelCompleted
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action GameplayStageComplete
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action GameOver
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action GameRestarted
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action GameStarted
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action LevelGeneratedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<long, string, long> MoneyValueChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<string, bool> BankVisibilityToggleEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<IProgressRewardable> NewProgressRewardable
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<int, bool> GameStageCompleted
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<int, bool> GameStageFailed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<int> GameLevelFailed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<int, string> GameLevelContinued
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<int, int, string> GameStageContinued
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static void SendLevelCompletedEvent()
		{
		}

		public static void SendGameStageStartedEvent(int stageNumber, bool hasStages = false)
		{
		}

		public static void SendGameplayLevelCompletedEvent()
		{
		}

		public static void SendGameplayStageCompleteEvent()
		{
		}

		public static void SendGameOverEvent()
		{
		}

		public static void SendGameRestartedEvent()
		{
		}

		public static void SendGameStartedEvent()
		{
		}

		public static void SendLevelGeneratedEvent()
		{
		}

		public static void SendMoneyValueChanged(long rewardAmount, string currencyID = null, long diffAmount = 0L)
		{
		}

		public static void SendBankVisibilityToggleEvent(string currencyID, bool visible)
		{
		}

		public static void SendNewProgressRewardable(IProgressRewardable progressRewardable)
		{
		}

		public static void SendGameStageCompletedEvent(int stageNumber, bool hasStages = false)
		{
		}

		public static void SendGameStageFailedEvent(int stageNumber, bool hasStages = false)
		{
		}

		public static void SendGameLevelFailedEvent(int levelNumber)
		{
		}

		public static void SendGameLevelContinuedEvent(int levelNumber, string continueContext)
		{
		}

		public static void SendGameStageContinuedEvent(int levelNumber, int stageNumber, string continueContext)
		{
		}
	}
}
