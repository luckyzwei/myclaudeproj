using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Numerics;

public class SeasonalOfflineResultData
{
	public Dictionary<int, BigInteger> OfflineCurrencyResult_PerMile;

	public Dictionary<int, BigInteger> OfflineRevenue_PerMile { get; private set; }

	public BigInteger GetHasCurrencyValue_PerMile(int currencyIdx)
	{
		if (OfflineCurrencyResult_PerMile != null && OfflineCurrencyResult_PerMile.TryGetValue(currencyIdx, out var value))
			return value;
		return BigInteger.Zero;
	}

	public void IncreaseHasCurrency_PerMile(int currencyIdx, BigInteger value)
	{
		if (OfflineCurrencyResult_PerMile == null)
			OfflineCurrencyResult_PerMile = new Dictionary<int, BigInteger>();
		if (OfflineCurrencyResult_PerMile.ContainsKey(currencyIdx))
			OfflineCurrencyResult_PerMile[currencyIdx] += value;
		else
			OfflineCurrencyResult_PerMile[currencyIdx] = value;
	}

	public void DecreaseHasCurrency_PerMile(int currencyIdx, BigInteger value)
	{
		if (OfflineCurrencyResult_PerMile == null)
			OfflineCurrencyResult_PerMile = new Dictionary<int, BigInteger>();
		if (OfflineCurrencyResult_PerMile.ContainsKey(currencyIdx))
		{
			OfflineCurrencyResult_PerMile[currencyIdx] -= value;
			if (OfflineCurrencyResult_PerMile[currencyIdx] < BigInteger.Zero)
				OfflineCurrencyResult_PerMile[currencyIdx] = BigInteger.Zero;
		}
	}

	public void UpdateOfflineRevenue(ReadOnlyDictionary<int, BigInteger> originCurrencyMap)
	{
		if (originCurrencyMap == null) return;
		if (OfflineRevenue_PerMile == null)
			OfflineRevenue_PerMile = new Dictionary<int, BigInteger>();
		OfflineRevenue_PerMile.Clear();
		foreach (var kvp in originCurrencyMap)
		{
			BigInteger current = GetHasCurrencyValue_PerMile(kvp.Key);
			BigInteger diff = current - kvp.Value;
			if (diff > BigInteger.Zero)
				OfflineRevenue_PerMile[kvp.Key] = diff;
		}
	}
}
