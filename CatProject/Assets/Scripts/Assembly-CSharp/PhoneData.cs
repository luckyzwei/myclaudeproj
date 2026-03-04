using System.Collections.Generic;
using System.Numerics;

public class PhoneData : IClientData
{
	public Dictionary<int, ChatData> ChatDatas;

	public Dictionary<int, int> MoneyBankLevel;

	public Dictionary<int, BigInteger> LimitMoneys;

	public BigInteger LimitMoney { get { return default(BigInteger); } }

	public void Init()
	{
	}

	public void CalcLimitMoney(int region = -1)
	{
	}

	public void MoneyBankLevelUp()
	{
	}

	public BigInteger GetLimitMoneyByRegion(int region)
	{
		return default(BigInteger);
	}
}
