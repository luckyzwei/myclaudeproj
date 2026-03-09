using System;
using Balancy.Models.RoyalTournament;
using Balancy.Models.SmartObjects;
using KWCore.Utils;

public class RoyalTournamentManager : Singleton<RoyalTournamentManager>, IQueueableEntity
{
	private const string EVENT_ID = "RoyalTournament";

	public const string LEADEBOARD_ID = "RoyalTournamentBots";

	public const string EXIT = "EXIT";

	public const string APP_CLOSE = "APP_CLOSE";

	public const string TIME = "TIME";

	public const string OUT_OF_LIVES = "OUT_OF_LIVES";

	public static GameplayEvents.StringDelegate OnTournamentStart;

	public static GameplayEvents.BasicDelegate OnPlayerAcknowledged;

	private int m_round;

	private RoyalTournamentBotLeaderboardController m_botLeaderboardController;

	private bool m_forcePopup;

	public static int UnlockLevel => 0;

	public static RoyalTournamentBotLeaderboardController RoyalTournamentBotLeaderboardController => null;

	public static int BestPosition => 0;

	public static int TimesCompleted => 0;

	public static Rewards Rewards => null;

	public static Settings Settings => null;

	public int Round => 0;

	public int RoundCount => 0;

	protected override void Init()
	{
	}

	private void GameplayEventsOnBoardInteractedEvent(bool firstInteraction)
	{
	}

	public void StartTournament()
	{
	}

	public int GetAmountOfPlayersForRound(int round)
	{
		return 0;
	}

	public static bool IsEventActive()
	{
		return false;
	}

	public void TimeStampSession()
	{
	}

	public int GetTimeUntilNextGameInSeconds()
	{
		return 0;
	}

	public void ReduceWaitTimeForNextGame(bool finishCooldown = false)
	{
	}

	public LevelDataScriptable GetRandomLevelFromPool()
	{
		return null;
	}

	public int GetRoundCutPoint(int round)
	{
		return 0;
	}

	public int GetPlayerLeaderboardTime()
	{
		return 0;
	}

	public int GetPlayerLeaderboardPosition()
	{
		return 0;
	}

	public int GetUserLeaderboardTime(int position)
	{
		return 0;
	}

	public LeaderboardData.User GetLeaderboardPlayer(int position)
	{
		return null;
	}

	private void ProgressRound()
	{
	}

	public void TryToRegisterShowResultSummary()
	{
	}

	public void PlayerAcknowledgeResult()
	{
	}

	public Reward GetReward()
	{
		return null;
	}

	public Reward GetStars(int rank)
	{
		return null;
	}

	public void ForceLossRound()
	{
	}

	public void RoundFinished(bool outOfLives)
	{
	}

	public static string FormatTime(int milliseconds)
	{
		return null;
	}

	public static string FormatPosition(int number)
	{
		return null;
	}

	public static int GetTimeLeftUntilEventStart()
	{
		return 0;
	}

	public static int GetTimeLeftUntilEventFinish()
	{
		return 0;
	}

	public void StartProcess(Action finishCallback)
	{
	}

	public bool ShouldShowLeaderboard()
	{
		return false;
	}

	public int GetPriority()
	{
		return 0;
	}

	public int GetUnlockLocationMask()
	{
		return 0;
	}

	public void SetForcePopup(bool forcePopup)
	{
	}
}
