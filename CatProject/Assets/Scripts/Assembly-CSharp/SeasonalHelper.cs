using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Numerics;
using SeasonalDef;

public static class SeasonalHelper
{
	public static readonly int TEN_FACTOR;

	public static readonly int HUNDRED_FACTOR;

	public static readonly int MILE_FACTOR;

	public static SeasonalSystem SeasonalSystem => null;

	public static InGameSeasonalData SeasonalData => null;

	public static SeasonalStageData SeasonalStageData => null;

	public static ReadOnlyDictionary<int, SeasonalBuildingData> SeasonalBuildingData => null;

	public static SeasonalShopData SeasonalShopData => null;

	public static InGameSeasonal InGameSeasonalMode => null;

	public static InGameSeasonalStage InGameSeasonalStage => null;

	public static bool IsPremiumPassActive(int seasonInfoIdx)
	{
		return false;
	}

	public static List<T> GetBuildingDataOfType<T>() where T : SeasonalBuildingData
	{
		return null;
	}

	public static int GetPrevOrderBuildingIdx(int curBuildingIdx)
	{
		return 0;
	}

	public static SeasonalWorkshopData FindProductionWorkshop(int productIdx)
	{
		return null;
	}

	public static (SeasonalWorkshopData, SeasonalBuildingFacilityData) FindWorkshopProductionFacility(int facilityIdx)
	{
		return default((SeasonalWorkshopData, SeasonalBuildingFacilityData));
	}

	public static SeasonalWorkshopData FindLastOpenedWorkshop()
	{
		return null;
	}

	public static bool IsStageUseSkill(E_SkillBookAbilityType abilityType)
	{
		return false;
	}

	public static int GetSkillLevel(E_SkillBookAbilityType abilityType, int targetIdx)
	{
		return 0;
	}

	public static BigInteger GetSkillAbilityValue_Per(E_SkillBookAbilityType abilityType, int targetIdx)
	{
		return default(BigInteger);
	}

	public static int GetStatueAbilityValue_Per(E_StatueAbilityType abilityType)
	{
		return 0;
	}

	public static int GetNowBuildingConstructionCount()
	{
		return 0;
	}

	public static int GetMaxBuildingProgressCount()
	{
		return 0;
	}

	public static bool IsApplyBuildingSlotLimit(int seasonIdx)
	{
		return false;
	}

	public static int GetTotalWorkingWorkers()
	{
		return 0;
	}

	public static bool IsAllDormitoryMaxLevel()
	{
		return false;
	}

	public static bool IsAllSkillBookMaxLevel()
	{
		return false;
	}

	public static SeasonalWorkShopProductionCostInfo CalcWorkshopProductionCostInfo(SeasonalWorkshopData workshopData)
	{
		return null;
	}

	public static SeasonalWorkShopProductionCostInfo CalcWorkshopProductionCostInfo(SeasonalWorkshopData workshopData, ReadOnlyDictionary<int, BigInteger> currencyInventoryMap_PerMile)
	{
		return null;
	}

	public static bool IsSkillBookType(E_CurrencyType currencyType, bool includeRandom)
	{
		return false;
	}

	public static HashSet<E_CurrencyType> GetSkillBookTypes(bool includeRandom)
	{
		return null;
	}

	public static bool IsUsedSeasonCurrencyType(E_CurrencyType currencyType)
	{
		return false;
	}

	public static E_CurrencyType GetSeasonCurrencyType(int currencyIdx)
	{
		return default(E_CurrencyType);
	}

	public static int GetSeasonCurrencyIdx(E_CurrencyType currencyType)
	{
		return 0;
	}

	public static BigInteger GetHasCurrencyValue_PerMile(E_CurrencyType currencyType)
	{
		return default(BigInteger);
	}

	public static BigInteger GetHasCurrencyValue_PerMile(int currencyIdx)
	{
		return default(BigInteger);
	}

	public static bool IsEnoughHasCurrency_PerMile(E_CurrencyType currencyType, BigInteger value)
	{
		return false;
	}

	public static bool IsEnoughHasCurrency_PerMile(int currencyIdx, BigInteger value)
	{
		return false;
	}

	public static BigInteger CalculateCurrencyAddableLimit_PerMile(int currencyIdx, BigInteger addValue)
	{
		return default(BigInteger);
	}

	public static void IncreaseHasCurrency_PerMile(E_CurrencyType currencyType, BigInteger value)
	{
	}

	public static Dictionary<E_CurrencyType, BigInteger> PickRandomSkillBook_PerMile(int peekCount)
	{
		return null;
	}

	public static void IncreaseHasCurrency_PerMile(int currencyIdx, BigInteger value)
	{
	}

	public static void DecreaseHasCurrency_PerMile(E_CurrencyType currencyType, BigInteger value)
	{
	}

	public static void DecreaseHasCurrency_PerMile(int currencyIdx, BigInteger value)
	{
	}

	public static int GetNowSeasonShopGoodsIdx(int shopGoodsIdx)
	{
		return 0;
	}

	public static float CalcMilestoneCurStepProgressRatio()
	{
		return 0f;
	}

	public static bool IsSeasonalOfflineRewardMax()
	{
		return false;
	}

	public static E_WorkshopManagerAbilityType ParseToManagerAbility(E_BuildingFacilityAbilityType facilityType)
	{
		return default(E_WorkshopManagerAbilityType);
	}

	public static E_CurrencyType ParseStatueBuffCurrencyType(E_StatueAbilityType abilityType)
	{
		return default(E_CurrencyType);
	}

	public static string GetHasCurrencyTextColorKey(bool bEnough)
	{
		return null;
	}

	public static string GetMissionMainIcon(SeasonalMissionData missionData)
	{
		return null;
	}

	public static string MakeMissionDescText(SeasonalMissionData missionData)
	{
		return null;
	}

	public static int MakeWorkerIdx(int buildingIdx, int workerTransformIdx)
	{
		return 0;
	}

	public static bool IsTimeValue(int type)
	{
		return false;
	}
}
