using System.Numerics;

public class RewardItemData_Seasonal : IRewardItemData
{
	public int CurrencyIdx;

	public BigInteger CurrencyValue_PerMile;

	public bool isOfflineReward;

	public string resImg;

	public RewardItemData_Seasonal(int currencyIdx, BigInteger currencyValue_PerMile, bool bOfflineReward, string res = "")
	{
		CurrencyIdx = currencyIdx;
		CurrencyValue_PerMile = currencyValue_PerMile;
		isOfflineReward = bOfflineReward;
		resImg = res;
	}

	public bool EnableReward()
	{
		return false;
	}
}
