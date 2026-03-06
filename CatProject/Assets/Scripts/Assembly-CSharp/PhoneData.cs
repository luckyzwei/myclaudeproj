using System.Collections.Generic;
using System.Numerics;

public class PhoneData : IClientData
{
	public Dictionary<int, ChatData> ChatDatas;

	public Dictionary<int, int> MoneyBankLevel;

	public Dictionary<int, BigInteger> LimitMoneys;

	public BigInteger LimitMoney
	{
		get
		{
			if (LimitMoneys == null || LimitMoneys.Count == 0)
				return BigInteger.Zero;
			BigInteger total = BigInteger.Zero;
			foreach (var kvp in LimitMoneys)
				total += kvp.Value;
			return total;
		}
	}

	public void Init()
	{
		ChatDatas = new Dictionary<int, ChatData>();
		MoneyBankLevel = new Dictionary<int, int>();
		LimitMoneys = new Dictionary<int, BigInteger>();
	}

	public void CalcLimitMoney(int region = -1)
	{
		if (LimitMoneys == null)
			LimitMoneys = new Dictionary<int, BigInteger>();
	}

	public void MoneyBankLevelUp()
	{
		CalcLimitMoney();
	}

	public BigInteger GetLimitMoneyByRegion(int region)
	{
		if (LimitMoneys != null && LimitMoneys.TryGetValue(region, out var value))
			return value;
		return BigInteger.Zero;
	}
}
