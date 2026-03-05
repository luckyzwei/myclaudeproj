using System.Collections.Generic;
using SeasonalDef;

public class SeasonalRouletteRewardData
{
	public int RewardIdx;
	public int SeasonThemeIdx;
	public E_CurrencyType CurrencyType;
	public List<int> CurrencyIdxList;
	public List<int> LevelRewardValueList;
	public string RewardIcon;
	public string RewardName;
	public int Weight;
	public bool IsTimeReward;
}
