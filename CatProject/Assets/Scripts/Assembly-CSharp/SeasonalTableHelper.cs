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

	public static void InitStaticData()
	{
	}

	public static void InitSeasonData(int seasonInfoIdx)
	{
	}

	public static SeasonalInfoData GetSeasonalInfoTable(int seasonInfoIdx)
	{
		return null;
	}

	public static SeasonalCurrencyData GetSeasonalCurrencyData(int currencyIdx)
	{
		return null;
	}

	public static SeasonalCurrencyData GetSeasonalCurrencyData(E_CurrencyType currencyType)
	{
		return null;
	}

	public static Treeplla.SeasonalBuildingData GetBuildingTable(int buildingIdx)
	{
		return null;
	}

	public static SeasonalBuildingItemData GetFacilityTable(int facilityIdx)
	{
		return null;
	}

	public static SeasonalManagerLevelData GetManagerLevelTable(int managerLv)
	{
		return null;
	}

	public static SeasonalBuildingItemLevelData GetFacilityLevelTable(int buildingIdx, int facilityIdx)
	{
		return null;
	}

	public static SeasonalRewardData GetSeasonalRewardTable(int rewardGroup, int rewardIdx)
	{
		return null;
	}

	public static SeasonalRewardData GetSeasonalRewardTable(int rewardIdx)
	{
		return null;
	}

	public static SeasonalRouletteRewardData GetSeasonalRouletteRewardTable(int rewardIdx)
	{
		return null;
	}

	public static SeasonalMissionInfoData GetSeasonalMissionInfoTable(int tableIdx)
	{
		return null;
	}

	public static SeasonalStatueData GetSeasonalStatueTable(int resourceIdx)
	{
		return null;
	}

	public static (string, string) GetCurrencyResourceInfo(E_CurrencyType currencyType)
	{
		return default((string, string));
	}

	public static (string, string) GetCurrencyResourceInfo(int currencyIdx)
	{
		return default((string, string));
	}

	public static int CalcManagerMaxLevel()
	{
		return 0;
	}

	public static int GetHireWorkerManagerLevelCondition(int buildingIdx, int facilityIdx, int hiredWorkerCount)
	{
		return 0;
	}

	public static long CalcFacilityNextLevelUpgradeAddedValue_PerMile(int buildingIdx, int facilityIdx, int curFacilityLevel)
	{
		return 0L;
	}

	public static BigInteger CalcFacilityTotalUpgradeValue_PerMile(int buildingIdx, int facilityIdx, int facilityLevel)
	{
		return default(BigInteger);
	}

	public static int CalcFacilityNextLevelUpgradeCostMultiply_PerMile(int buildingIdx, int facilityIdx, int facilityLevel)
	{
		return 0;
	}

	public static BigInteger CalcFacilityTotalUpgradeCost_PerMile(int buildingIdx, int facilityIdx, int facilityLevel)
	{
		return default(BigInteger);
	}

	public static int GetBuildingFacilityMaxLevel(int buildingIdx, int facilityIdx)
	{
		return 0;
	}

	public static (string, string) GetWorkshopFacilityNameAndIcon(int facilityIdx, int facilityLevel)
	{
		return default((string, string));
	}

	public static int FindFacilityDisplayLevelRangeIndex(SeasonalBuildingItemData facilityTable, int facilityLevel)
	{
		return 0;
	}

	public static int CalcBuildingLevelupNeedFacilityLevel(int buildingIdx, int buildingLv)
	{
		return 0;
	}

	public static KeyValuePair<int, int> CalcBuildingFacilityUpgradeLevelRange(int buildingIdx, int buildingLv, int facilityIdx, int facilityLevel)
	{
		return default(KeyValuePair<int, int>);
	}

	public static SeasonalProductionMassIncInfo CalcBuildingFacilityMileStoneAbilityInfo(int buildingIdx, int facilityIdx, int facilityLevel)
	{
		return default(SeasonalProductionMassIncInfo);
	}

	private static void InitArcadeRouletteProbabilityMap(int seasonThemeIdx)
	{
	}

	private static void InitBuildingAbilityMassIncLvInfos(int seasonThemeIdx)
	{
	}

	public static int GetCoinRankFinalScore(SeasonalRankInfoData rankTable)
	{
		return 0;
	}
}
