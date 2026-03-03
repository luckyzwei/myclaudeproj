using System;
using System.Numerics;

public class InvestData : IClientData
{
	public DateTime StartTime;

	public DateTime NextResetTime;

	public int CompanyIdx;

	public BigInteger originRewradMoney;

	public BigInteger InvestMoney;

	public int MultipleValue;

	public DateTime InvestStartTime;

	public BigInteger RewardMoney
	{
		get
		{
			return default(BigInteger);
		}
		set
		{
		}
	}
}
