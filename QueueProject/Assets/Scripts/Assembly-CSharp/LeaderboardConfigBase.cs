using KPFCore;
using UnityEngine;

public abstract class LeaderboardConfigBase : ScriptableObject, ILeaderboardConfig, IConfig
{
	public abstract int Limit { get; }

	public abstract int LimitAroundOwner { get; }

	public abstract long CacheDurationInSeconds { get; }
}
