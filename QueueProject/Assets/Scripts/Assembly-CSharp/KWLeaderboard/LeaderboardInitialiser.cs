using System;
using KPFCore;
using UnityEngine;

namespace KWLeaderboard
{
	public class LeaderboardInitialiser : InitialiserBase
	{
		[Serializable]
		private class LeaderboardIDConfig
		{
			public string LeaderboardID;

			public LeaderboardsLocalConfig Config;
		}

		[SerializeField]
		private LeaderboardConfigBase m_defaultConfig;

		[Header("Link here any custom leaderboard configs with leaderboard IDs")]
		[SerializeField]
		private LeaderboardIDConfig[] m_customLeaderboardConfigs;

		[Header("These leaderboards will use the default adapter assigned in the repository")]
		[SerializeField]
		private string[] m_defaultAdapterLeaderboardIds;

		protected override void InitialiseLocal(MasterConfig masterConfig)
		{
		}

		protected override void RegisterConfigs()
		{
		}

		protected override void RegisterDefaultAdapters()
		{
		}
	}
}
