using System;
using System.Collections.Generic;
using Balancy.Models.KWLeaderboard;
using Balancy.Models.SmartObjects;
using KWCore.Utils;
using UnityEngine;

public class LeagueManager : Singleton<LeagueManager>
{
	public enum LeagueResult
	{
		NONE = 0,
		PROMOTED = 1,
		DEMOTED = 2
	}

	public const string NOTIFICATION_WIDGET_ID = "LeaguesLeaderboard";

	private Sprite m_currentPlayerFlag;

	private bool m_enabled;

	private bool m_playerChangedZoneThisSession;

	private List<BotScore> m_botScores;

	public bool Enabled => m_enabled;

	public int PlayerScore => BucketLeaderboard.LeaguePlayerScore;

	public int PlayerNewScore => BucketLeaderboard.LeaguePlayerNewscore;

	public int Rank => BucketLeaderboard.LeaguePlayerRank;

	public LeaguesSettings LeagueSettings => null; // Loaded from Balancy

	public SharedSettings SharedSettings => null; // Loaded from Balancy

	public int CurrentLeague
	{
		get
		{
			return BucketLeaderboard.LeagueCurrentIndex;
		}
		private set
		{
			BucketLeaderboard.LeagueCurrentIndex = value;
		}
	}

	public long DebugTimeOffset { get; set; }

	public bool HasLeagueEnded()
	{
		long elapsed = GetLeagueTimeElapsedMS();
		long durationMs = 7L * 24 * 60 * 60 * 1000; // 1 week default
		return elapsed >= durationMs;
	}

	public BotScore GetBot(int index)
	{
		if (m_botScores == null || index < 0 || index >= m_botScores.Count)
			return null;
		return m_botScores[index];
	}

	public bool DidPlayerChangedZoneThisSession()
	{
		return m_playerChangedZoneThisSession;
	}

	public void ShowLeaguesScreen(Action finished)
	{
		finished?.Invoke();
	}

	protected override void Init()
	{
		m_enabled = true;
		m_botScores = new List<BotScore>();
		m_playerChangedZoneThisSession = false;
		DebugTimeOffset = 0;

		DeserializeBots();

		if (m_botScores.Count == 0)
			CreateBotsAndInitialScoreDistribution();
	}

	private void BalancyBootstrapEventsOnProfileWasReset()
	{
		ResetLeagues();
	}

	private void StartNewLeague(int leagueIndex)
	{
		CurrentLeague = leagueIndex;
		ResetPlayerScoreData();
		CreateBotsAndInitialScoreDistribution();
		SetLeagueTimeStamp();
		if (leagueIndex > BucketLeaderboard.LeaguePlayerMaxLeague)
			BucketLeaderboard.LeaguePlayerMaxLeague = leagueIndex;
	}

	public void AddPlayerScore(int playerScore)
	{
		int newScore = BucketLeaderboard.LeaguePlayerNewscore + playerScore;
		BucketLeaderboard.LeaguePlayerNewscore = newScore;
	}

	public void SettleScore()
	{
		int newScore = BucketLeaderboard.LeaguePlayerNewscore;
		BucketLeaderboard.LeaguePlayerScore = newScore;
		int rank = GetPlayerRank(newScore);
		BucketLeaderboard.LeaguePlayerRank = rank;
		if (rank > 0 && (BucketLeaderboard.LeaguePlayerMaxRanking == 0 || rank < BucketLeaderboard.LeaguePlayerMaxRanking))
			BucketLeaderboard.LeaguePlayerMaxRanking = rank;
	}

	public Reward GetCurrentLeagueReward(int rank)
	{
		return GetLeagueReward(CurrentLeague, rank);
	}

	public Reward GetLeagueReward(int leagueIndex, int rank)
	{
		// Rewards configured through Balancy
		return null;
	}

	private void ResetPlayerScoreData()
	{
		BucketLeaderboard.LeaguePlayerScore = 0;
		BucketLeaderboard.LeaguePlayerNewscore = 0;
		BucketLeaderboard.LeaguePlayerRank = 0;
	}

	private bool IsVeryFirstLeague()
	{
		return CurrentLeague == 0 && BucketLeaderboard.LeaguePlayerMaxLeague == 0;
	}

	public bool IsLastLeague()
	{
		// Default max leagues: 10
		return CurrentLeague >= 9;
	}

	public void SetLeagueTimeStamp()
	{
		BucketLeaderboard.LeagueCurrentTimestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
	}

	public LeagueDataConfig GetCurrentLeagueData()
	{
		return GetLeagueData(CurrentLeague);
	}

	public LeagueDataConfig GetLeagueData(int leagueIndex)
	{
		// League data configured through Balancy
		return null;
	}

	public long GetLeagueTimeElapsedMS()
	{
		long startTime = BucketLeaderboard.LeagueCurrentTimestamp;
		if (startTime <= 0) return 0;
		long now = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() + DebugTimeOffset;
		return now - startTime;
	}

	public void ForceEndLeague()
	{
		ExecutePromotionsDemotions();
	}

	public bool CalculateAIScores()
	{
		if (m_botScores == null || m_botScores.Count == 0) return false;

		long now = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
		long lastTimestamp = BucketLeaderboard.LeagueBotScoreTimestamp;
		if (lastTimestamp <= 0)
		{
			BucketLeaderboard.LeagueBotScoreTimestamp = now;
			return false;
		}

		bool consumed = ConsumeBotTimeBank();
		if (consumed)
		{
			DoBotsScoring();
			SortBots();
			SerializeBots();
			return true;
		}
		return false;
	}

	private void DeserializeBots()
	{
		var serialized = BucketLeaderboard.LeagueBotsScore;
		if (serialized == null || serialized.Count == 0) return;

		m_botScores = new List<BotScore>();
		for (int i = 0; i < serialized.Count; i++)
		{
			var bot = UnityEngine.JsonUtility.FromJson<BotScore>(serialized[i]);
			if (bot != null)
				m_botScores.Add(bot);
		}
	}

	private void SerializeBots()
	{
		if (m_botScores == null) return;
		var serialized = new List<string>();
		for (int i = 0; i < m_botScores.Count; i++)
			serialized.Add(UnityEngine.JsonUtility.ToJson(m_botScores[i]));
		BucketLeaderboard.LeagueBotsScore = serialized;
	}

	private void CreateBotsAndInitialScoreDistribution()
	{
		m_botScores = new List<BotScore>();
		var rng = new System.Random();
		int botCount = 30; // Default bot count

		for (int i = 0; i < botCount; i++)
		{
			var bot = new BotScore
			{
				name = "Player" + (i + 1),
				score = rng.Next(0, 50),
				isFixed = false,
				customisations = new List<int>()
			};
			m_botScores.Add(bot);
		}
		SortBots();
		SerializeBots();
	}

	private void SortBots()
	{
		if (m_botScores != null)
			m_botScores.Sort((a, b) => b.score.CompareTo(a.score));
	}

	private void CalculateBotTimeBank()
	{
		long now = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
		long lastTimestamp = BucketLeaderboard.LeagueBotScoreTimestamp;
		if (lastTimestamp > 0)
		{
			long elapsed = now - lastTimestamp;
			long currentBank = BucketLeaderboard.LeagueBotTimeBank;
			BucketLeaderboard.LeagueBotTimeBank = currentBank + elapsed;
		}
		BucketLeaderboard.LeagueBotScoreTimestamp = now;
	}

	private bool ConsumeBotTimeBank()
	{
		CalculateBotTimeBank();
		long bank = BucketLeaderboard.LeagueBotTimeBank;
		long threshold = 60000; // 1 minute threshold
		if (bank >= threshold)
		{
			BucketLeaderboard.LeagueBotTimeBank = 0;
			return true;
		}
		return false;
	}

	private void DoBotsScoring()
	{
		if (m_botScores == null) return;
		var rng = new System.Random();
		for (int i = 0; i < m_botScores.Count; i++)
		{
			if (m_botScores[i].isFixed) continue;
			// Random score increment
			int increment = rng.Next(0, 5);
			m_botScores[i].score += increment;
		}
	}

	private void ScoreBotZone(BotBehabiourZoneConfig zone, int zoneStart, int zoneEnd)
	{
		if (m_botScores == null || zone == null) return;
		var rng = new System.Random();
		for (int i = zoneStart; i < zoneEnd && i < m_botScores.Count; i++)
		{
			if (m_botScores[i].isFixed) continue;
			m_botScores[i].score += rng.Next(0, 3);
		}
	}

	public int GetPlayerRank()
	{
		return GetPlayerRank(BucketLeaderboard.LeaguePlayerScore);
	}

	public int GetPlayerRank(int score)
	{
		if (m_botScores == null) return 1;
		int rank = 1;
		for (int i = 0; i < m_botScores.Count; i++)
		{
			if (m_botScores[i].score > score)
				rank++;
		}
		return rank;
	}

	public LeagueResult GetLeagueResult()
	{
		return GetLeagueResult(GetPlayerRank());
	}

	public LeagueResult GetLeagueResult(int playerRank)
	{
		int totalPlayers = (m_botScores != null ? m_botScores.Count : 0) + 1;
		int promotionThreshold = Math.Max(1, totalPlayers / 5); // Top 20% promoted
		int demotionThreshold = totalPlayers - Math.Max(1, totalPlayers / 5); // Bottom 20% demoted

		if (playerRank <= promotionThreshold)
			return LeagueResult.PROMOTED;
		if (playerRank > demotionThreshold)
			return LeagueResult.DEMOTED;
		return LeagueResult.NONE;
	}

	private void ExecutePromotionsDemotions()
	{
		LeagueResult result = GetLeagueResult();
		m_playerChangedZoneThisSession = result != LeagueResult.NONE;

		switch (result)
		{
			case LeagueResult.PROMOTED:
				if (!IsLastLeague())
					StartNewLeague(CurrentLeague + 1);
				else
					StartNewLeague(CurrentLeague); // Stay in last league
				break;
			case LeagueResult.DEMOTED:
				if (CurrentLeague > 0)
					StartNewLeague(CurrentLeague - 1);
				else
					StartNewLeague(0);
				break;
			default:
				StartNewLeague(CurrentLeague); // Same league, reset
				break;
		}
	}

	public void UserTriggeredEndOfLeague()
	{
		if (HasLeagueEnded())
			ExecutePromotionsDemotions();
	}

	public void ResetLeagues()
	{
		CurrentLeague = 0;
		ResetPlayerScoreData();
		m_botScores = new List<BotScore>();
		m_playerChangedZoneThisSession = false;
		BucketLeaderboard.LeagueBotsScore = null;
		BucketLeaderboard.LeagueBotTimeBank = 0;
		BucketLeaderboard.LeagueBotScoreTimestamp = 0;
		BucketLeaderboard.LeaguePlayerMaxLeague = 0;
		BucketLeaderboard.LeaguePlayerMaxRanking = 0;
		BucketLeaderboard.LeagueCurrentTimestamp = 0;
	}
}
