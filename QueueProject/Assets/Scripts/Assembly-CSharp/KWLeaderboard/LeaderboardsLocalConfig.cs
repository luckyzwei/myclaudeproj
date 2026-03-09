using KPFCore;
using UnityEngine;

namespace KWLeaderboard
{
	[CreateAssetMenu(fileName = "LocalLeaderboardsConfig", menuName = "KPF/Configs/Create Local Leaderboards Config")]
	public class LeaderboardsLocalConfig : LeaderboardConfigBase, ILeaderboardConfig, IConfig
	{
		public const string REGIONAL_LEADERBOARD_FORMAT = "{0}-{1}";

		[SerializeField]
		private int m_limit;

		[SerializeField]
		private int m_limitAroundOwner;

		[SerializeField]
		private long m_cacheDurationInSeconds;

		public override int Limit => 0;

		public override int LimitAroundOwner => 0;

		public override long CacheDurationInSeconds => 0L;

		public void SetValues(int limit = 1000, long cacheDurationInSeconds = 1800L)
		{
		}
	}
}
