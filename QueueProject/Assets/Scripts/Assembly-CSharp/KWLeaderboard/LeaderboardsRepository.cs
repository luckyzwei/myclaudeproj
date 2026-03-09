using System;
using System.Collections.Generic;
using KPFCore;

namespace KWLeaderboard
{
	public class LeaderboardsRepository : IRepository
	{
		private readonly ILeaderboardConfig m_defaultConfig;

		private readonly ILeaderboardAdapter m_defaultAdapter;

		private Dictionary<string, ILeaderboardConfig> m_configsDict;

		private Dictionary<string, LeaderboardCache> m_leaderboardsCacheDict;

		private Dictionary<string, ILeaderboardAdapter> m_adaptersDict;

		public LeaderboardsRepository(IConfig defaultConfig)
		{
		}

		public void RegisterConfig(string leaderboardId, ILeaderboardConfig config)
		{
		}

		public void SetLeaderboardStale(string leaderboardId)
		{
		}

		public void RegisterAdapter<T>(string leaderboardId, LeaderboardsLocalConfig config = null) where T : ILeaderboardAdapter, new()
		{
		}

		public void AssignDefaultAdapterToLeaderboard(string leaderboardId)
		{
		}

		public LeaderboardData GetLeaderboardData(string leaderboardId, string region, Action<LeaderboardData> callback, bool aroundOwner = true, bool cachedOnly = false)
		{
			return null;
		}

		private void GetLeaderboardDataFromAdapter(string leaderboardId, Action<LeaderboardData> callback, bool aroundOwner, string region)
		{
		}

		private LeaderboardData AddPlayerFromAroundPlayerToTopLeaderboard(string leaderboardId)
		{
			return null;
		}

		public void DeleteCachedData(string leaderboardId)
		{
		}

		public LeaderboardData.User PostPlayerScore(string leaderboardId, long score, out bool postingScore, string region = null, string avatarUrl = null, string displayName = null, Dictionary<string, object> metaData = null, bool onlyUpdateCache = false, Action<LeaderboardData.User> callback = null)
		{
			postingScore = default(bool);
			return null;
		}

		public ILeaderboardConfig GetLeaderboardConfig(string leaderboardId)
		{
			return null;
		}

		private ILeaderboardAdapter GetLeaderboardAdapter(string leaderboardId)
		{
			return null;
		}

		private LeaderboardCache GetLeaderboardCache(string leaderboardId)
		{
			return null;
		}

		private void UpdateCache(string leaderboardId, LeaderboardData data, bool aroundOwner)
		{
		}
	}
}
