using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class RoyalTournamentBotLeaderboardAdapter : ILeaderboardAdapter
{
	public Task GetLeaderboardData(string leaderboardId, string region, Action<LeaderboardData> callback = null, bool aroundOwner = true, int overrideLimit = -1)
	{
		return null;
	}

	public Task PostPlayerScore(string leaderboardId, long score, string region = null, string avatarUrl = null, string displayName = null, Dictionary<string, object> metaData = null, Action<LeaderboardData.User> callback = null)
	{
		return null;
	}
}
