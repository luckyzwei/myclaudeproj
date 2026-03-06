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

	public SeasonalStageData SeasonalStageData
	{
		get
		{
			if (seasonalStageDataMap != null && seasonalStageDataMap.TryGetValue(ActiveSeasonIdx, out var data))
				return data;
			return null;
		}
	}

	public SeasonalShopData SeasonalShopData
	{
		get
		{
			if (seasonalShopDataMap != null && seasonalShopDataMap.TryGetValue(ActiveSeasonIdx, out var data))
				return data;
			return null;
		}
	}

	public void Init(SeasonalData? seasonalData)
	{
		seasonalStageDataMap = new Dictionary<int, SeasonalStageData>();
		seasonalShopDataMap = new Dictionary<int, SeasonalShopData>();
		PlayedSeasonInfoIdxList = new List<int>();
		SeasonalStageDataMap = new ReadOnlyDictionary<int, SeasonalStageData>(seasonalStageDataMap);
		SeasonalShopDataMap = new ReadOnlyDictionary<int, SeasonalShopData>(seasonalShopDataMap);
		MaxPiggyBankLevel = 0;
		ActiveSeasonIdx = 0;
		ActiveSeasonThemeIdx = 0;
		LastActiveSeasonIdx = 0;
	}

	public bool AddNewSeason(int seasonInfoIdx)
	{
		if (PlayedSeasonInfoIdxList == null)
			PlayedSeasonInfoIdxList = new List<int>();
		if (PlayedSeasonInfoIdxList.Contains(seasonInfoIdx))
			return false;
		PlayedSeasonInfoIdxList.Add(seasonInfoIdx);
		return true;
	}

	public bool ChangeActiveSeason(in int seasonIdx)
	{
		if (seasonIdx == ActiveSeasonIdx) return false;
		LastActiveSeasonIdx = ActiveSeasonIdx;
		ActiveSeasonIdx = seasonIdx;
		return true;
	}

	public void ResetAllSeasonalInfo()
	{
		if (seasonalStageDataMap != null) seasonalStageDataMap.Clear();
		if (seasonalShopDataMap != null) seasonalShopDataMap.Clear();
		ResetSeasonLimitInfos();
	}

	private void ResetSeasonLimitInfos()
	{
		ActiveSeasonIdx = 0;
		ActiveSeasonThemeIdx = 0;
		LastActiveSeasonIdx = 0;
	}

	private void CheckAndRemoveOlderSeasonInfo()
	{
		// TODO
	}
}
