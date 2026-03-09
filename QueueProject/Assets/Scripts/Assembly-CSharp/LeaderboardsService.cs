using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using KPFCore;
using KWLeaderboard;

public class LeaderboardsService : ServiceBase<LeaderboardsService>
{
	private LeaderboardsRepository m_leaderboardsRepository;

	private ILeaderboardConfig m_config;

	private string m_region;

	private bool m_postingScore;

	public bool PostingScore => false;

	public int Limit => 0;

	public static event Action<LeaderboardData> OnLeaderboardUpdated
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action<LeaderboardData> OnScorePosted
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	protected override void InitialiseLocal(IRepository dataRepository, IConfig config = null)
	{
	}

	public LeaderboardData GetLeaderboardData(string leaderboardId, string region = "", bool aroundOwner = true, bool cachedOnly = false)
	{
		return null;
	}

	public void SetLeaderboardStale(string leaderboardId)
	{
	}

	public void PostPlayerScore(string leaderboardId, int score, string avatarUrl = null, string displayName = null, Dictionary<string, object> metaData = null, bool onlyUpdateCache = false)
	{
	}

	public void SetBucketData(LeaderboardData leaderboardData, bool force = false)
	{
	}

	public void DeleteCachedData(string leaderboardId)
	{
	}

	public long GetCacheDuration(string leaderboardId)
	{
		return 0L;
	}

	public void SetPosting(bool value)
	{
	}

	public string GetRegion()
	{
		return null;
	}
}
