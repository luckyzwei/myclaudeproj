using KPFCore;

public interface ILeaderboardConfig : IConfig
{
	int Limit { get; }

	int LimitAroundOwner { get; }

	long CacheDurationInSeconds { get; }
}
