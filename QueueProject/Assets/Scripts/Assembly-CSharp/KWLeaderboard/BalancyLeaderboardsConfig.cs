using KPFCore;
using UnityEngine;

namespace KWLeaderboard
{
	[CreateAssetMenu(fileName = "BalancyLeaderboardsConfig", menuName = "KPF/Configs/Create Balancy Leaderboards Config")]
	public class BalancyLeaderboardsConfig : LeaderboardConfigBase, ILeaderboardConfig, IConfig
	{
		public override int Limit => 0;

		public override int LimitAroundOwner => 0;

		public override long CacheDurationInSeconds => 0L;
	}
}
