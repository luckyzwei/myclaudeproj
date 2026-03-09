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

	public bool Enabled => false;

	public int PlayerScore => 0;

	public int PlayerNewScore => 0;

	public int Rank => 0;

	public LeaguesSettings LeagueSettings => null;

	public SharedSettings SharedSettings => null;

	public int CurrentLeague
	{
		get
		{
			return 0;
		}
		private set
		{
		}
	}

	public long DebugTimeOffset { get; set; }

	public bool HasLeagueEnded()
	{
		return false;
	}

	public BotScore GetBot(int index)
	{
		return null;
	}

	public bool DidPlayerChangedZoneThisSession()
	{
		return false;
	}

	public void ShowLeaguesScreen(Action finished)
	{
	}

	protected override void Init()
	{
	}

	private void BalancyBootstrapEventsOnProfileWasReset()
	{
	}

	private void StartNewLeague(int leagueIndex)
	{
	}

	public void AddPlayerScore(int playerScore)
	{
	}

	public void SettleScore()
	{
	}

	public Reward GetCurrentLeagueReward(int rank)
	{
		return null;
	}

	public Reward GetLeagueReward(int leagueIndex, int rank)
	{
		return null;
	}

	private void ResetPlayerScoreData()
	{
	}

	private bool IsVeryFirstLeague()
	{
		return false;
	}

	public bool IsLastLeague()
	{
		return false;
	}

	public void SetLeagueTimeStamp()
	{
	}

	public LeagueDataConfig GetCurrentLeagueData()
	{
		return null;
	}

	public LeagueDataConfig GetLeagueData(int leagueIndex)
	{
		return null;
	}

	public long GetLeagueTimeElapsedMS()
	{
		return 0L;
	}

	public void ForceEndLeague()
	{
	}

	public bool CalculateAIScores()
	{
		return false;
	}

	private void DeserializeBots()
	{
	}

	private void SerializeBots()
	{
	}

	private void CreateBotsAndInitialScoreDistribution()
	{
	}

	private void SortBots()
	{
	}

	private void CalculateBotTimeBank()
	{
	}

	private bool ConsumeBotTimeBank()
	{
		return false;
	}

	private void DoBotsScoring()
	{
	}

	private void ScoreBotZone(BotBehabiourZoneConfig zone, int zoneStart, int zoneEnd)
	{
	}

	public int GetPlayerRank()
	{
		return 0;
	}

	public int GetPlayerRank(int score)
	{
		return 0;
	}

	public LeagueResult GetLeagueResult()
	{
		return default(LeagueResult);
	}

	public LeagueResult GetLeagueResult(int playerRank)
	{
		return default(LeagueResult);
	}

	private void ExecutePromotionsDemotions()
	{
	}

	public void UserTriggeredEndOfLeague()
	{
	}

	public void ResetLeagues()
	{
	}
}
