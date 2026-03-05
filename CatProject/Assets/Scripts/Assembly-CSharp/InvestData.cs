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
			if (MultipleValue <= 0) return originRewradMoney;
			return originRewradMoney * MultipleValue;
		}
		set
		{
			originRewradMoney = value;
		}
	}
}
