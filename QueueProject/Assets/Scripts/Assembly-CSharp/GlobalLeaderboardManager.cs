using System.Collections.Generic;
using Balancy.Models.KWLeaderboard;
using KWCore.Utils;

public class GlobalLeaderboardManager : Singleton<GlobalLeaderboardManager>
{
	public const string NOTIFICATION_WIDGET_ID = "GlobalLeaderboard";

	public static int DEBUG_SCORE_TO_POST;

	private bool m_enabled;

	private List<BotScore> m_botScores;

	public bool Enabled => false;

	public SharedSettings SharedSettings => null;

	public GlobalLeaderboardSettings GlobalLeaderboardSettings => null;

	public int PlayerScore => 0;

	public List<BotScore> BotScores => null;

	protected override void Init()
	{
	}

	public int GetBotsCount()
	{
		return 0;
	}

	public BotScore GetBot(int index)
	{
		return null;
	}

	public void AddPlayerScore(int score)
	{
	}

	private void TryToCreateBots(bool force = false)
	{
	}

	public bool TryToScoreBots()
	{
		return false;
	}

	private void CalculateBotTimeBank()
	{
	}

	private bool ConsumeBotTimeBank()
	{
		return false;
	}

	private void DoBotScoring()
	{
	}

	public void DeserializeBots()
	{
	}

	public void SerializeBots()
	{
	}

	private void SortBots()
	{
	}

	public int GetPlayerRank()
	{
		return 0;
	}

	public int GetPlayerLastSeenRank()
	{
		return 0;
	}

	public void SaveLastSeenRank()
	{
	}

	public void Reset()
	{
	}
}
