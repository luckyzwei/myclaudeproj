using System.Collections.Generic;
using System.Collections.ObjectModel;
using Treeplla.Data;

public class InGameSeasonalData
{
	private Dictionary<int, SeasonalStageData> seasonalStageDataMap;

	private Dictionary<int, SeasonalShopData> seasonalShopDataMap;

	public int MaxPiggyBankLevel;

	public int LastActiveSeasonIdx { get; private set; }

	public int ActiveSeasonIdx { get; private set; }

	public int ActiveSeasonThemeIdx { get; private set; }

	public ReadOnlyDictionary<int, SeasonalStageData> SeasonalStageDataMap { get; private set; }

	public List<int> PlayedSeasonInfoIdxList { get; private set; }

	public ReadOnlyDictionary<int, SeasonalShopData> SeasonalShopDataMap { get; private set; }

	public SeasonalStageData SeasonalStageData { get { return null; } }

	public SeasonalShopData SeasonalShopData { get { return null; } }

	public void Init(SeasonalData? seasonalData)
	{
	}

	public bool AddNewSeason(int seasonInfoIdx)
	{
		return false;
	}

	public bool ChangeActiveSeason(in int seasonIdx)
	{
		return false;
	}

	public void ResetAllSeasonalInfo()
	{
	}

	private void ResetSeasonLimitInfos()
	{
	}

	private void CheckAndRemoveOlderSeasonInfo()
	{
	}
}
