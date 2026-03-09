using System.Collections.Generic;
using Balancy.Models.RoyalTournament;

public class RoyalTournamentBotLeaderboardController
{
	private enum PlayerStatus
	{
		LAST = 0,
		LOST = 1,
		DEFFO_QUALIFY = 2,
		DESIRED = 3
	}

	private LeaderboardData m_botLeaderboard;

	private PlayerStatus m_playerStatus;

	private BotSettings BotSettings => null;

	private LeaderboardData LeaderboardData => null;

	public LeaderboardData GetLeaderboardData(string leaderboardId)
	{
		return null;
	}

	public int GetPlayerTime(string leadeboardId)
	{
		return 0;
	}

	public int GetUserTime(string leadeboardId, int position)
	{
		return 0;
	}

	public LeaderboardData.User GetUserData(string leadeboardId, int position)
	{
		return null;
	}

	public int GetPlayerPosition(string leadeboardId)
	{
		return 0;
	}

	public void GenerateBotLeaderboard(string leaderBoardId)
	{
	}

	public void Score(string leaderboardId, long score)
	{
	}

	private void CalculateBotTimesAndPosition(int playerPosition, int playerTime)
	{
	}

	private void CalculateBotTimesWhenPlayerIsOutOfLives(int playerPosition)
	{
	}

	private void CalculateBotTimesNormal(int playerPosition, int playerTime)
	{
	}

	private void UpdateBotScore(int index, int score)
	{
	}

	private int CalculatePlayerPosition(long score)
	{
		return 0;
	}

	private int CalculatePlayerPosition(BotRound round)
	{
		return 0;
	}

	private void OutOfLivesPositionCalculations()
	{
	}

	private void SemiShuffle(List<LeaderboardData.User> list, int range)
	{
	}

	private void CutSize()
	{
	}
}
