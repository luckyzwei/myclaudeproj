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

	public static int UnlockLevel => 10; // Default unlock level

	public static RoyalTournamentBotLeaderboardController RoyalTournamentBotLeaderboardController =>
		Instance?.m_botLeaderboardController;

	public static int BestPosition => BucketRoyalTournament.BestPosition;

	public static int TimesCompleted => BucketRoyalTournament.TimesComplete;

	public static Rewards Rewards => null; // Loaded from Balancy

	public static Settings Settings => null; // Loaded from Balancy

	public int Round => m_round;

	public int RoundCount => 3; // Default round count

	protected override void Init()
	{
		m_round = 0;
		m_botLeaderboardController = new RoyalTournamentBotLeaderboardController();
		GameplayEvents.BoardInteractedEvent += GameplayEventsOnBoardInteractedEvent;
	}

	private void GameplayEventsOnBoardInteractedEvent(bool firstInteraction)
	{
		if (firstInteraction)
			TimeStampSession();
	}

	public void StartTournament()
	{
		m_round = 0;
		m_botLeaderboardController?.GenerateBotLeaderboard(LEADEBOARD_ID);
		OnTournamentStart?.Invoke(EVENT_ID);
	}

	public int GetAmountOfPlayersForRound(int round)
	{
		// Default bracket sizes: 8 -> 4 -> 2
		switch (round)
		{
			case 0: return 8;
			case 1: return 4;
			case 2: return 2;
			default: return 8;
		}
	}

	public static bool IsEventActive()
	{
		int timeLeft = GetTimeLeftUntilEventFinish();
		return timeLeft > 0;
	}

	public void TimeStampSession()
	{
		BucketRoyalTournament.LastFinishedTimeStamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
	}

	public int GetTimeUntilNextGameInSeconds()
	{
		long lastTime = BucketRoyalTournament.LastFinishedTimeStamp;
		if (lastTime <= 0) return 0;
		long now = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
		int cooldown = 60; // Default cooldown
		int remaining = cooldown - (int)(now - lastTime);
		return remaining > 0 ? remaining : 0;
	}

	public void ReduceWaitTimeForNextGame(bool finishCooldown = false)
	{
		if (finishCooldown)
			BucketRoyalTournament.LastFinishedTimeStamp = 0;
		else
			BucketRoyalTournament.LastFinishedTimeStamp -= 30;
	}

	public LevelDataScriptable GetRandomLevelFromPool()
	{
		var pool = BucketRoyalTournament.LevelPool;
		if (pool == null || pool.Count == 0) return null;
		if (GameManager.Instance == null || GameManager.Instance.LevelOrder == null) return null;

		var levelOrder = GameManager.Instance.LevelOrder;
		if (levelOrder.royalTournament == null || levelOrder.royalTournament.levels == null) return null;

		var rng = new System.Random();
		int idx = pool[rng.Next(pool.Count)];
		if (idx >= 0 && idx < levelOrder.royalTournament.levels.Count)
			return levelOrder.royalTournament.levels[idx];
		return null;
	}

	public int GetRoundCutPoint(int round)
	{
		// Default: top half qualifies
		return GetAmountOfPlayersForRound(round) / 2;
	}

	public int GetPlayerLeaderboardTime()
	{
		if (m_botLeaderboardController == null) return 0;
		return m_botLeaderboardController.GetPlayerTime(LEADEBOARD_ID);
	}

	public int GetPlayerLeaderboardPosition()
	{
		if (m_botLeaderboardController == null) return 0;
		return m_botLeaderboardController.GetPlayerPosition(LEADEBOARD_ID);
	}

	public int GetUserLeaderboardTime(int position)
	{
		if (m_botLeaderboardController == null) return 0;
		return m_botLeaderboardController.GetUserTime(LEADEBOARD_ID, position);
	}

	public LeaderboardData.User GetLeaderboardPlayer(int position)
	{
		if (m_botLeaderboardController == null) return null;
		return m_botLeaderboardController.GetUserData(LEADEBOARD_ID, position);
	}

	private void ProgressRound()
	{
		m_round++;
		if (m_round >= RoundCount)
		{
			BucketRoyalTournament.TimesComplete = BucketRoyalTournament.TimesComplete + 1;
		}
	}

	public void TryToRegisterShowResultSummary()
	{
		m_forcePopup = true;
	}

	public void PlayerAcknowledgeResult()
	{
		m_forcePopup = false;
		OnPlayerAcknowledged?.Invoke();
	}

	public Reward GetReward()
	{
		// Rewards configured through Balancy
		return null;
	}

	public Reward GetStars(int rank)
	{
		// Star rewards configured through Balancy
		return null;
	}

	public void ForceLossRound()
	{
		BucketRoyalTournament.EliminationReason = OUT_OF_LIVES;
		RoundFinished(true);
	}

	public void RoundFinished(bool outOfLives)
	{
		int position = GetPlayerLeaderboardPosition();
		int cutPoint = GetRoundCutPoint(m_round);

		if (outOfLives || position > cutPoint)
		{
			// Player eliminated
			BucketRoyalTournament.LastResultPosition = position;
			int best = BucketRoyalTournament.BestPosition;
			if (best == 0 || m_round > best)
				BucketRoyalTournament.BestPosition = m_round;
		}
		else
		{
			// Player qualifies
			ProgressRound();
			if (m_round < RoundCount)
			{
				m_botLeaderboardController?.GenerateBotLeaderboard(LEADEBOARD_ID);
			}
		}
	}

	public static string FormatTime(int milliseconds)
	{
		int totalSeconds = milliseconds / 1000;
		int minutes = totalSeconds / 60;
		int seconds = totalSeconds % 60;
		int ms = (milliseconds % 1000) / 10;
		return string.Format("{0:D2}:{1:D2}.{2:D2}", minutes, seconds, ms);
	}

	public static string FormatPosition(int number)
	{
		if (number <= 0) return number.ToString();
		int mod100 = number % 100;
		if (mod100 >= 11 && mod100 <= 13)
			return number + "th";
		switch (number % 10)
		{
			case 1: return number + "st";
			case 2: return number + "nd";
			case 3: return number + "rd";
			default: return number + "th";
		}
	}

	public static int GetTimeLeftUntilEventStart()
	{
		// Event start is managed by Balancy, return 0 if active
		return 0;
	}

	public static int GetTimeLeftUntilEventFinish()
	{
		// Event duration managed by Balancy
		return 0;
	}

	public void StartProcess(Action finishCallback)
	{
		if (m_forcePopup && IsEventActive())
		{
			TryToRegisterShowResultSummary();
		}
		finishCallback?.Invoke();
	}

	public bool ShouldShowLeaderboard()
	{
		return IsEventActive() && m_round > 0;
	}

	public int GetPriority()
	{
		return 50;
	}

	public int GetUnlockLocationMask()
	{
		return 1; // Home screen
	}

	public void SetForcePopup(bool forcePopup)
	{
		m_forcePopup = forcePopup;
	}
}
