using System;
using System.Runtime.CompilerServices;
using KWGameCore.Interface;

namespace KWGameCore.Events
{
	public class GameCoreEvents
	{
		private static Action _LevelCompleted;
		public static event Action LevelCompleted
		{
			add { _LevelCompleted += value; }
			remove { _LevelCompleted -= value; }
		}

		private static Action<int, bool> _GameStageStarted;
		public static event Action<int, bool> GameStageStarted
		{
			add { _GameStageStarted += value; }
			remove { _GameStageStarted -= value; }
		}

		private static Action _GameplayLevelCompleted;
		public static event Action GameplayLevelCompleted
		{
			add { _GameplayLevelCompleted += value; }
			remove { _GameplayLevelCompleted -= value; }
		}

		private static Action _GameplayStageComplete;
		public static event Action GameplayStageComplete
		{
			add { _GameplayStageComplete += value; }
			remove { _GameplayStageComplete -= value; }
		}

		private static Action _GameOver;
		public static event Action GameOver
		{
			add { _GameOver += value; }
			remove { _GameOver -= value; }
		}

		private static Action _GameRestarted;
		public static event Action GameRestarted
		{
			add { _GameRestarted += value; }
			remove { _GameRestarted -= value; }
		}

		private static Action _GameStarted;
		public static event Action GameStarted
		{
			add { _GameStarted += value; }
			remove { _GameStarted -= value; }
		}

		private static Action _LevelGeneratedEvent;
		public static event Action LevelGeneratedEvent
		{
			add { _LevelGeneratedEvent += value; }
			remove { _LevelGeneratedEvent -= value; }
		}

		private static Action<long, string, long> _MoneyValueChanged;
		public static event Action<long, string, long> MoneyValueChanged
		{
			add { _MoneyValueChanged += value; }
			remove { _MoneyValueChanged -= value; }
		}

		private static Action<string, bool> _BankVisibilityToggleEvent;
		public static event Action<string, bool> BankVisibilityToggleEvent
		{
			add { _BankVisibilityToggleEvent += value; }
			remove { _BankVisibilityToggleEvent -= value; }
		}

		private static Action<IProgressRewardable> _NewProgressRewardable;
		public static event Action<IProgressRewardable> NewProgressRewardable
		{
			add { _NewProgressRewardable += value; }
			remove { _NewProgressRewardable -= value; }
		}

		private static Action<int, bool> _GameStageCompleted;
		public static event Action<int, bool> GameStageCompleted
		{
			add { _GameStageCompleted += value; }
			remove { _GameStageCompleted -= value; }
		}

		private static Action<int, bool> _GameStageFailed;
		public static event Action<int, bool> GameStageFailed
		{
			add { _GameStageFailed += value; }
			remove { _GameStageFailed -= value; }
		}

		private static Action<int> _GameLevelFailed;
		public static event Action<int> GameLevelFailed
		{
			add { _GameLevelFailed += value; }
			remove { _GameLevelFailed -= value; }
		}

		private static Action<int, string> _GameLevelContinued;
		public static event Action<int, string> GameLevelContinued
		{
			add { _GameLevelContinued += value; }
			remove { _GameLevelContinued -= value; }
		}

		private static Action<int, int, string> _GameStageContinued;
		public static event Action<int, int, string> GameStageContinued
		{
			add { _GameStageContinued += value; }
			remove { _GameStageContinued -= value; }
		}

		public static void SendLevelCompletedEvent()
		{
			_LevelCompleted?.Invoke();
		}

		public static void SendGameStageStartedEvent(int stageNumber, bool hasStages = false)
		{
			_GameStageStarted?.Invoke(stageNumber, hasStages);
		}

		public static void SendGameplayLevelCompletedEvent()
		{
			_GameplayLevelCompleted?.Invoke();
		}

		public static void SendGameplayStageCompleteEvent()
		{
			_GameplayStageComplete?.Invoke();
		}

		public static void SendGameOverEvent()
		{
			_GameOver?.Invoke();
		}

		public static void SendGameRestartedEvent()
		{
			_GameRestarted?.Invoke();
		}

		public static void SendGameStartedEvent()
		{
			_GameStarted?.Invoke();
		}

		public static void SendLevelGeneratedEvent()
		{
			_LevelGeneratedEvent?.Invoke();
		}

		public static void SendMoneyValueChanged(long rewardAmount, string currencyID = null, long diffAmount = 0L)
		{
			_MoneyValueChanged?.Invoke(rewardAmount, currencyID, diffAmount);
		}

		public static void SendBankVisibilityToggleEvent(string currencyID, bool visible)
		{
			_BankVisibilityToggleEvent?.Invoke(currencyID, visible);
		}

		public static void SendNewProgressRewardable(IProgressRewardable progressRewardable)
		{
			_NewProgressRewardable?.Invoke(progressRewardable);
		}

		public static void SendGameStageCompletedEvent(int stageNumber, bool hasStages = false)
		{
			_GameStageCompleted?.Invoke(stageNumber, hasStages);
		}

		public static void SendGameStageFailedEvent(int stageNumber, bool hasStages = false)
		{
			_GameStageFailed?.Invoke(stageNumber, hasStages);
		}

		public static void SendGameLevelFailedEvent(int levelNumber)
		{
			_GameLevelFailed?.Invoke(levelNumber);
		}

		public static void SendGameLevelContinuedEvent(int levelNumber, string continueContext)
		{
			_GameLevelContinued?.Invoke(levelNumber, continueContext);
		}

		public static void SendGameStageContinuedEvent(int levelNumber, int stageNumber, string continueContext)
		{
			_GameStageContinued?.Invoke(levelNumber, stageNumber, continueContext);
		}
	}
}
