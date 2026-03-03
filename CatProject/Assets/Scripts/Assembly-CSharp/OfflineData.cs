using System;
using System.Numerics;

public class OfflineData : IClientData
{
	public DateTime LastLoginTime { get; set; }

	public int TotalOfflineTime { get; set; }

	public BigInteger TotalOfflineReward { get; set; }

	public bool OnStrike { get; set; }

	public bool NotStrike { get; set; }
}
