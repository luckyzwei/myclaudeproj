using System;
using SeasonalDef;

[Serializable]
public struct TopInfoData
{
	public Config.CurrencyGameType GameType;

	public int RewardType;

	public int RewardIdx;

	public int RegionType;

	public static TopInfoData MakeCommonData(Config.CurrencyGameType gameType, int rewardType, int rewardIdx, int regionType)
	{
		return default(TopInfoData);
	}

	public static TopInfoData MakeSeasonalData(E_CurrencyType currencyType)
	{
		return default(TopInfoData);
	}
}
