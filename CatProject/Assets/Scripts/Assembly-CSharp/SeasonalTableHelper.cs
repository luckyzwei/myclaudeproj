using System.Collections.Generic;
using System.Numerics;
using SeasonalDef;
using Treeplla;

public static class SeasonalTableHelper
{
	private static int SeasonInfoIdx;

	private static int SeasonThemeIdx;

	private static Dictionary<int, int> ManagerMaxLevelData;

	public static int OFFLINE_REWARD_MIN_TIME_SEC;

	public static int OFFLINE_REWARD_MAX_TIME_SEC;

	public static int ARCADE_ROULETTE_NEED_COIN { get; private set; }

	public static int FINAL_ARCADE_ROULETTE_NEED_COIN => 0;

	public static int REMAIN_REWARDS_GET_TIME_LIMIT { get; private set; }

	public static int OFFLINE_REWARD_CORRECTION_VALUE { get; private set; }

	public static int BONUS_MONEY_CORRECTION_VALUE { get; private set; }

	public static int BONUS_MANAGER_EXP_CORRECTION_VALUE { get; private set; }

	public static int PREV_SEASON_REWARDS_GET_LIMIT_TIME_SEC { get; private set; }

	public static int OFFLINE_REWARD_AD_MULTIPLE { get; private set; }

	public static int OVERTIME_GEM_COST { get; private set; }

	public static int NIGHT_SKIP_END_HOUR { get; private set; }

	public static int BAD_MOOD_DEBUFF_VALUE { get; private set; }

	public static int MAX_BUILDING_PROGRESS_CNT { get; private set; }

	public static int ADDITIONAL_BUILDING_PROGRESS_CNT { get; private set; }

	public static int DISTRIBUTOR_CARRYING_CAPACITY_INVENTORY_DIFFERENCE { get; private set; }

	public static bool COIN_RANK_CUSTOM_SEASON { get; private set; }

	public static int COIN_RANK_COOL_TIME { get; private set; }

	public static int COIN_RANK_ACCUMULATE_CNT { get; private set; }

	public static int COIN_RANK_RETRY_RANK_LIMIT { get; private set; }

	public static int RANK_TYPE_START_VALUE { get; private set; }

	public static List<int> SEASONAL_MINE_RANK_POINT_MAGNIFICATION_LIST { get; private set; }

	public static Dictionary<int, (int startWeight, int endWeight)> ArcadeRouletteProbabilityMap { get; private set; }

	public static Dictionary<(int buildingIdx, int facilityIdx), List<int>> FacilityAbilityMassIncLvMap { get; private set; }

	// Cached table data dictionaries
	private static Dictionary<int, SeasonalInfoData> seasonalInfoDataMap;
	private static Dictionary<int, SeasonalCurrencyData> seasonalCurrencyDataMap;
	private static Dictionary<E_CurrencyType, SeasonalCurrencyData> seasonalCurrencyTypeMap;
	private static Dictionary<int, Treeplla.SeasonalBuildingData> seasonalBuildingTableMap;
	private static Dictionary<int, SeasonalBuildingItemData> seasonalFacilityDataMap;
	private static Dictionary<int, SeasonalManagerLevelData> seasonalManagerLevelDataMap;
	private static Dictionary<(int, int), SeasonalBuildingItemLevelData> seasonalFacilityLevelDataMap;
	private static Dictionary<int, SeasonalRewardData> seasonalRewardDataMap;
	private static Dictionary<(int, int), SeasonalRewardData> seasonalRewardGroupDataMap;
	private static Dictionary<int, SeasonalRouletteRewardData> seasonalRouletteRewardDataMap;
	private static Dictionary<int, SeasonalMissionInfoData> seasonalMissionInfoDataMap;
	private static Dictionary<int, SeasonalStatueData> seasonalStatueDataMap;

	public static void InitStaticData()
	{
		seasonalInfoDataMap = new Dictionary<int, SeasonalInfoData>();
		seasonalCurrencyDataMap = new Dictionary<int, SeasonalCurrencyData>();
		seasonalCurrencyTypeMap = new Dictionary<E_CurrencyType, SeasonalCurrencyData>();
		seasonalBuildingTableMap = new Dictionary<int, Treeplla.SeasonalBuildingData>();
		seasonalFacilityDataMap = new Dictionary<int, SeasonalBuildingItemData>();
		seasonalManagerLevelDataMap = new Dictionary<int, SeasonalManagerLevelData>();
		seasonalFacilityLevelDataMap = new Dictionary<(int, int), SeasonalBuildingItemLevelData>();
		seasonalRewardDataMap = new Dictionary<int, SeasonalRewardData>();
		seasonalRewardGroupDataMap = new Dictionary<(int, int), SeasonalRewardData>();
		seasonalRouletteRewardDataMap = new Dictionary<int, SeasonalRouletteRewardData>();
		seasonalMissionInfoDataMap = new Dictionary<int, SeasonalMissionInfoData>();
		seasonalStatueDataMap = new Dictionary<int, SeasonalStatueData>();
		ManagerMaxLevelData = new Dictionary<int, int>();
		ArcadeRouletteProbabilityMap = new Dictionary<int, (int startWeight, int endWeight)>();
		FacilityAbilityMassIncLvMap = new Dictionary<(int buildingIdx, int facilityIdx), List<int>>();
		SEASONAL_MINE_RANK_POINT_MAGNIFICATION_LIST = new List<int>();
	}

	public static void InitSeasonData(int seasonInfoIdx)
	{
		SeasonInfoIdx = seasonInfoIdx;

		var seasonInfo = GetSeasonalInfoTable(seasonInfoIdx);
		if (seasonInfo == null)
			return;

		SeasonThemeIdx = seasonInfo.SeasonThemeIdx;

		OFFLINE_REWARD_MIN_TIME_SEC = seasonInfo.OfflineRewardMinTimeSec;
		OFFLINE_REWARD_MAX_TIME_SEC = seasonInfo.OfflineRewardMaxTimeSec;
		OFFLINE_REWARD_CORRECTION_VALUE = seasonInfo.OfflineRewardCorrectionValue;
		BONUS_MONEY_CORRECTION_VALUE = seasonInfo.BonusMoneyCorrectionValue;
		BONUS_MANAGER_EXP_CORRECTION_VALUE = seasonInfo.BonusManagerExpCorrectionValue;
		PREV_SEASON_REWARDS_GET_LIMIT_TIME_SEC = seasonInfo.PrevSeasonRewardsGetLimitTimeSec;
		OFFLINE_REWARD_AD_MULTIPLE = seasonInfo.OfflineRewardAdMultiple;
		OVERTIME_GEM_COST = seasonInfo.OvertimeGemCost;
		NIGHT_SKIP_END_HOUR = seasonInfo.NightSkipEndHour;
		BAD_MOOD_DEBUFF_VALUE = seasonInfo.BadMoodDebuffValue;
		MAX_BUILDING_PROGRESS_CNT = seasonInfo.MaxBuildingProgressCnt;
		ADDITIONAL_BUILDING_PROGRESS_CNT = seasonInfo.AdditionalBuildingProgressCnt;
		DISTRIBUTOR_CARRYING_CAPACITY_INVENTORY_DIFFERENCE = seasonInfo.DistributorCarryingCapacityInventoryDifference;
		REMAIN_REWARDS_GET_TIME_LIMIT = seasonInfo.RemainRewardsGetTimeLimit;
		ARCADE_ROULETTE_NEED_COIN = seasonInfo.ArcadeRouletteNeedCoin;
		COIN_RANK_CUSTOM_SEASON = seasonInfo.CoinRankCustomSeason;
		COIN_RANK_COOL_TIME = seasonInfo.CoinRankCoolTime;
		COIN_RANK_ACCUMULATE_CNT = seasonInfo.CoinRankAccumulateCnt;
		COIN_RANK_RETRY_RANK_LIMIT = seasonInfo.CoinRankRetryRankLimit;
		RANK_TYPE_START_VALUE = seasonInfo.RankTypeStartValue;

		if (seasonInfo.MineRankPointMagnificationList != null)
		{
			SEASONAL_MINE_RANK_POINT_MAGNIFICATION_LIST = new List<int>(seasonInfo.MineRankPointMagnificationList);
		}

		InitArcadeRouletteProbabilityMap(SeasonThemeIdx);
		InitBuildingAbilityMassIncLvInfos(SeasonThemeIdx);
	}

	public static SeasonalInfoData GetSeasonalInfoTable(int seasonInfoIdx)
	{
		if (seasonalInfoDataMap != null && seasonalInfoDataMap.TryGetValue(seasonInfoIdx, out var data))
			return data;
		return null;
	}

	public static SeasonalCurrencyData GetSeasonalCurrencyData(int currencyIdx)
	{
		if (seasonalCurrencyDataMap != null && seasonalCurrencyDataMap.TryGetValue(currencyIdx, out var data))
			return data;
		return null;
	}

	public static SeasonalCurrencyData GetSeasonalCurrencyData(E_CurrencyType currencyType)
	{
		if (seasonalCurrencyTypeMap != null && seasonalCurrencyTypeMap.TryGetValue(currencyType, out var data))
			return data;
		return null;
	}

	public static Treeplla.SeasonalBuildingData GetBuildingTable(int buildingIdx)
	{
		if (seasonalBuildingTableMap != null && seasonalBuildingTableMap.TryGetValue(buildingIdx, out var data))
			return data;
		return null;
	}

	public static SeasonalBuildingItemData GetFacilityTable(int facilityIdx)
	{
		if (seasonalFacilityDataMap != null && seasonalFacilityDataMap.TryGetValue(facilityIdx, out var data))
			return data;
		return null;
	}

	public static SeasonalManagerLevelData GetManagerLevelTable(int managerLv)
	{
		if (seasonalManagerLevelDataMap != null && seasonalManagerLevelDataMap.TryGetValue(managerLv, out var data))
			return data;
		return null;
	}

	public static SeasonalBuildingItemLevelData GetFacilityLevelTable(int buildingIdx, int facilityIdx)
	{
		var key = (buildingIdx, facilityIdx);
		if (seasonalFacilityLevelDataMap != null && seasonalFacilityLevelDataMap.TryGetValue(key, out var data))
			return data;
		return null;
	}

	public static SeasonalRewardData GetSeasonalRewardTable(int rewardGroup, int rewardIdx)
	{
		var key = (rewardGroup, rewardIdx);
		if (seasonalRewardGroupDataMap != null && seasonalRewardGroupDataMap.TryGetValue(key, out var data))
			return data;
		return null;
	}

	public static SeasonalRewardData GetSeasonalRewardTable(int rewardIdx)
	{
		if (seasonalRewardDataMap != null && seasonalRewardDataMap.TryGetValue(rewardIdx, out var data))
			return data;
		return null;
	}

	public static SeasonalRouletteRewardData GetSeasonalRouletteRewardTable(int rewardIdx)
	{
		if (seasonalRouletteRewardDataMap != null && seasonalRouletteRewardDataMap.TryGetValue(rewardIdx, out var data))
			return data;
		return null;
	}

	public static SeasonalMissionInfoData GetSeasonalMissionInfoTable(int tableIdx)
	{
		if (seasonalMissionInfoDataMap != null && seasonalMissionInfoDataMap.TryGetValue(tableIdx, out var data))
			return data;
		return null;
	}

	public static SeasonalStatueData GetSeasonalStatueTable(int resourceIdx)
	{
		if (seasonalStatueDataMap != null && seasonalStatueDataMap.TryGetValue(resourceIdx, out var data))
			return data;
		return null;
	}

	public static (string, string) GetCurrencyResourceInfo(E_CurrencyType currencyType)
	{
		var currencyData = GetSeasonalCurrencyData(currencyType);
		if (currencyData == null)
			return (string.Empty, string.Empty);
		return (currencyData.CurrencyName ?? string.Empty, currencyData.CurrencyIcon ?? string.Empty);
	}

	public static (string, string) GetCurrencyResourceInfo(int currencyIdx)
	{
		var currencyData = GetSeasonalCurrencyData(currencyIdx);
		if (currencyData == null)
			return (string.Empty, string.Empty);
		return (currencyData.CurrencyName ?? string.Empty, currencyData.CurrencyIcon ?? string.Empty);
	}

	public static int CalcManagerMaxLevel()
	{
		if (ManagerMaxLevelData == null || ManagerMaxLevelData.Count == 0)
			return 1;

		int maxLevel = 1;
		foreach (var kvp in ManagerMaxLevelData)
		{
			if (kvp.Value > maxLevel)
				maxLevel = kvp.Value;
		}
		return maxLevel;
	}

	public static int GetHireWorkerManagerLevelCondition(int buildingIdx, int facilityIdx, int hiredWorkerCount)
	{
		var facilityTable = GetFacilityTable(facilityIdx);
		if (facilityTable == null)
			return 0;

		if (facilityTable.HireWorkerManagerLevelConditionList != null &&
			hiredWorkerCount >= 0 && hiredWorkerCount < facilityTable.HireWorkerManagerLevelConditionList.Count)
		{
			return facilityTable.HireWorkerManagerLevelConditionList[hiredWorkerCount];
		}

		return facilityTable.HireWorkerManagerLevelCondition;
	}

	public static long CalcFacilityNextLevelUpgradeAddedValue_PerMile(int buildingIdx, int facilityIdx, int curFacilityLevel)
	{
		var levelData = GetFacilityLevelTable(buildingIdx, facilityIdx);
		if (levelData == null)
			return 0L;

		return levelData.UpgradeAddedValue_PerMile;
	}

	public static BigInteger CalcFacilityTotalUpgradeValue_PerMile(int buildingIdx, int facilityIdx, int facilityLevel)
	{
		var levelData = GetFacilityLevelTable(buildingIdx, facilityIdx);
		if (levelData == null)
			return BigInteger.Zero;

		// Total upgrade value is the sum of all upgrade values from level 1 to current level
		// Base formula: upgradeAddedValue * level
		BigInteger totalValue = new BigInteger(levelData.UpgradeAddedValue_PerMile) * facilityLevel;
		return totalValue;
	}

	public static int CalcFacilityNextLevelUpgradeCostMultiply_PerMile(int buildingIdx, int facilityIdx, int facilityLevel)
	{
		var levelData = GetFacilityLevelTable(buildingIdx, facilityIdx);
		if (levelData == null)
			return 0;

		return levelData.UpgradeCostMultiply_PerMile;
	}

	public static BigInteger CalcFacilityTotalUpgradeCost_PerMile(int buildingIdx, int facilityIdx, int facilityLevel)
	{
		var levelData = GetFacilityLevelTable(buildingIdx, facilityIdx);
		if (levelData == null)
			return BigInteger.Zero;

		// Total cost increases with level using the cost multiplier
		// Base formula: baseCost * (costMultiply ^ level) / 1000
		BigInteger baseCost = new BigInteger(levelData.UpgradeCostMultiply_PerMile);
		BigInteger totalCost = baseCost * facilityLevel;
		return totalCost;
	}

	public static int GetBuildingFacilityMaxLevel(int buildingIdx, int facilityIdx)
	{
		var levelData = GetFacilityLevelTable(buildingIdx, facilityIdx);
		if (levelData != null)
			return levelData.MaxLevel;

		var facilityTable = GetFacilityTable(facilityIdx);
		if (facilityTable != null)
			return facilityTable.MaxLevel;

		return 0;
	}

	public static (string, string) GetWorkshopFacilityNameAndIcon(int facilityIdx, int facilityLevel)
	{
		var facilityTable = GetFacilityTable(facilityIdx);
		if (facilityTable == null)
			return (string.Empty, string.Empty);

		int displayIndex = FindFacilityDisplayLevelRangeIndex(facilityTable, facilityLevel);

		string name = facilityTable.FacilityName ?? string.Empty;
		string icon = facilityTable.FacilityIcon ?? string.Empty;

		if (facilityTable.DisplayNameList != null && displayIndex >= 0 && displayIndex < facilityTable.DisplayNameList.Count)
			name = facilityTable.DisplayNameList[displayIndex];

		if (facilityTable.DisplayIconList != null && displayIndex >= 0 && displayIndex < facilityTable.DisplayIconList.Count)
			icon = facilityTable.DisplayIconList[displayIndex];

		return (name, icon);
	}

	public static int FindFacilityDisplayLevelRangeIndex(SeasonalBuildingItemData facilityTable, int facilityLevel)
	{
		if (facilityTable == null || facilityTable.DisplayLevelRangeList == null || facilityTable.DisplayLevelRangeList.Count == 0)
			return 0;

		int index = 0;
		for (int i = 0; i < facilityTable.DisplayLevelRangeList.Count; i++)
		{
			if (facilityLevel >= facilityTable.DisplayLevelRangeList[i])
				index = i;
			else
				break;
		}
		return index;
	}

	public static int CalcBuildingLevelupNeedFacilityLevel(int buildingIdx, int buildingLv)
	{
		var levelData = GetFacilityLevelTable(buildingIdx, 0);
		if (levelData != null)
			return levelData.BuildingLevelupNeedFacilityLevel;

		// Default formula: each building level requires a certain facility level
		// Typically building level * some base requirement
		return buildingLv * 10;
	}

	public static KeyValuePair<int, int> CalcBuildingFacilityUpgradeLevelRange(int buildingIdx, int buildingLv, int facilityIdx, int facilityLevel)
	{
		int currentMinLevel = facilityLevel;
		int needLevel = CalcBuildingLevelupNeedFacilityLevel(buildingIdx, buildingLv);
		int maxLevel = GetBuildingFacilityMaxLevel(buildingIdx, facilityIdx);

		int targetLevel = needLevel;
		if (targetLevel > maxLevel)
			targetLevel = maxLevel;

		return new KeyValuePair<int, int>(currentMinLevel, targetLevel);
	}

	public static SeasonalProductionMassIncInfo CalcBuildingFacilityMileStoneAbilityInfo(int buildingIdx, int facilityIdx, int facilityLevel)
	{
		var result = new SeasonalProductionMassIncInfo();

		var key = (buildingIdx, facilityIdx);
		if (FacilityAbilityMassIncLvMap == null || !FacilityAbilityMassIncLvMap.TryGetValue(key, out var massIncLvList))
			return result;

		if (massIncLvList == null || massIncLvList.Count == 0)
			return result;

		// Find the next milestone level above the current facility level
		int nextIncLevel = 0;
		for (int i = 0; i < massIncLvList.Count; i++)
		{
			if (massIncLvList[i] > facilityLevel)
			{
				nextIncLevel = massIncLvList[i];
				break;
			}
		}

		if (nextIncLevel <= 0)
			return result;

		var levelData = GetFacilityLevelTable(buildingIdx, facilityIdx);
		if (levelData == null)
			return result;

		result.NextIncLevel = nextIncLevel;
		result.IncValue = levelData.AbilityMassIncValue;
		result.IncValueSignType = levelData.ValueSignType;
		result.IncAbilityType = levelData.AbilityType;

		return result;
	}

	private static void InitArcadeRouletteProbabilityMap(int seasonThemeIdx)
	{
		if (ArcadeRouletteProbabilityMap == null)
			ArcadeRouletteProbabilityMap = new Dictionary<int, (int startWeight, int endWeight)>();
		else
			ArcadeRouletteProbabilityMap.Clear();

		if (seasonalRouletteRewardDataMap == null)
			return;

		int accumulatedWeight = 0;
		foreach (var kvp in seasonalRouletteRewardDataMap)
		{
			var rewardData = kvp.Value;
			if (rewardData.SeasonThemeIdx != seasonThemeIdx)
				continue;

			int startWeight = accumulatedWeight;
			accumulatedWeight += rewardData.Weight;
			int endWeight = accumulatedWeight;

			ArcadeRouletteProbabilityMap[kvp.Key] = (startWeight, endWeight);
		}
	}

	private static void InitBuildingAbilityMassIncLvInfos(int seasonThemeIdx)
	{
		if (FacilityAbilityMassIncLvMap == null)
			FacilityAbilityMassIncLvMap = new Dictionary<(int buildingIdx, int facilityIdx), List<int>>();
		else
			FacilityAbilityMassIncLvMap.Clear();

		if (seasonalFacilityLevelDataMap == null)
			return;

		foreach (var kvp in seasonalFacilityLevelDataMap)
		{
			var levelData = kvp.Value;
			if (levelData.AbilityMassIncLevel <= 0)
				continue;

			var key = (levelData.BuildingIdx, levelData.FacilityIdx);
			if (!FacilityAbilityMassIncLvMap.TryGetValue(key, out var lvList))
			{
				lvList = new List<int>();
				FacilityAbilityMassIncLvMap[key] = lvList;
			}

			if (!lvList.Contains(levelData.AbilityMassIncLevel))
			{
				lvList.Add(levelData.AbilityMassIncLevel);
			}
		}

		// Sort each list
		foreach (var kvp in FacilityAbilityMassIncLvMap)
		{
			kvp.Value.Sort();
		}
	}

	public static int GetCoinRankFinalScore(SeasonalRankInfoData rankTable)
	{
		if (rankTable == null)
			return 0;

		return rankTable.Score + rankTable.BonusScore;
	}
}
