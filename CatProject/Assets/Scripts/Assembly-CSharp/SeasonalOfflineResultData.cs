using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Numerics;

public class SeasonalOfflineResultData
{
	public Dictionary<int, BigInteger> OfflineCurrencyResult_PerMile;

	public Dictionary<int, BigInteger> OfflineRevenue_PerMile { get; private set; }

	public BigInteger GetHasCurrencyValue_PerMile(int currencyIdx)
	{
		return default(BigInteger);
	}

	public void IncreaseHasCurrency_PerMile(int currencyIdx, BigInteger value)
	{
	}

	public void DecreaseHasCurrency_PerMile(int currencyIdx, BigInteger value)
	{
	}

	public void UpdateOfflineRevenue(ReadOnlyDictionary<int, BigInteger> originCurrencyMap)
	{
	}
}
