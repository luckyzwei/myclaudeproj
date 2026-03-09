using System.Collections.Generic;

public class LeaderboardCache
{
	private const string CACHE_KEY_TOP_PLAYERS_SUFFIX = "-top";

	private readonly GenericDataCache<LeaderboardData> m_cache;

	public LeaderboardCache(string leaderboardId, long cacheDurationSeconds)
	{
	}

	public void SetStale()
	{
	}

	public void SetLeaderboard(LeaderboardData data, bool aroundOwner)
	{
	}

	public LeaderboardData GetLeaderboard(string leaderboardId, bool aroundOwner)
	{
		return null;
	}

	private string GetCacheKey(string leaderboardId, bool aroundOwner)
	{
		return null;
	}

	public LeaderboardData SetPlayerScore(string leaderboardId, int score, string avatarUrl, string displayName, Dictionary<string, object> metaData)
	{
		return null;
	}

	private LeaderboardData SetPlayerScore(LeaderboardData data, int score, string avatarUrl, string displayName, Dictionary<string, object> metaData, bool aroundOwner)
	{
		return null;
	}

	public void ClearAll()
	{
	}

	public LeaderboardData MovePlayerToTopPlayersLeaderboard(string leaderboardId, bool serverAuthoritative = true)
	{
		return null;
	}
}
