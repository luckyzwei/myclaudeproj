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
		TopInfoData data = new TopInfoData();
		data.GameType = gameType;
		data.RewardType = rewardType;
		data.RewardIdx = rewardIdx;
		data.RegionType = regionType;
		return data;
	}

	public static TopInfoData MakeSeasonalData(E_CurrencyType currencyType)
	{
		TopInfoData data = new TopInfoData();
		data.GameType = Config.CurrencyGameType.Event;
		data.RewardType = (int)Config.RewardType.Currency;
		data.RewardIdx = (int)currencyType;
		data.RegionType = 0;
		return data;
	}
}
