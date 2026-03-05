using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Numerics;
using SeasonalDef;
using Treeplla;

public static class SeasonalHelper
{
	public static readonly int TEN_FACTOR = 10;

	public static readonly int HUNDRED_FACTOR = 100;

	public static readonly int MILE_FACTOR = 1000;

	public static SeasonalSystem SeasonalSystem =>
		Singleton<GameRoot>.Instance?.SeasonalSystem;

	public static InGameSeasonalData SeasonalData =>
		Singleton<GameRoot>.Instance?.UserData?.mainData?.SeasonalData;

	public static SeasonalStageData SeasonalStageData =>
		SeasonalData?.SeasonalStageData;

	public static ReadOnlyDictionary<int, SeasonalBuildingData> SeasonalBuildingData =>
		SeasonalStageData?.BuildingDataMap;

	public static SeasonalShopData SeasonalShopData =>
		SeasonalData?.SeasonalShopData;

	public static InGameSeasonal InGameSeasonalMode =>
		Singleton<GameRoot>.Instance?.InGameSystem?.GetInGame<InGameSeasonal>();

	public static InGameSeasonalStage InGameSeasonalStage =>
		InGameSeasonalMode?.SeasonalStage;

	public static bool IsPremiumPassActive(int seasonInfoIdx)
	{
		var shopDataMap = SeasonalData?.SeasonalShopDataMap;
		if (shopDataMap != null && shopDataMap.TryGetValue(seasonInfoIdx, out var shopData))
		{
			return shopData.IsPremiumPassActive != null && shopData.IsPremiumPassActive.Value;
		}
		return false;
	}

	public static List<T> GetBuildingDataOfType<T>() where T : SeasonalBuildingData
	{
		var buildingDataMap = SeasonalBuildingData;
		if (buildingDataMap == null)
			return new List<T>();

		var result = new List<T>();
		foreach (var kvp in buildingDataMap)
		{
			if (kvp.Value is T typed)
				result.Add(typed);
		}
		return result;
	}

	public static int GetPrevOrderBuildingIdx(int curBuildingIdx)
	{
		var buildingDataMap = SeasonalBuildingData;
		if (buildingDataMap == null)
			return 0;

		int prevIdx = 0;
		foreach (var kvp in buildingDataMap)
		{
			if (kvp.Value.BuildingIdx == curBuildingIdx)
				return prevIdx;

			if (kvp.Value.IsOpen != null && kvp.Value.IsOpen.Value)
				prevIdx = kvp.Value.BuildingIdx;
		}
		return prevIdx;
	}

	public static SeasonalWorkshopData FindProductionWorkshop(int productIdx)
	{
		var stageData = SeasonalStageData;
		if (stageData?.ProductWorkshopIdxMap != null &&
			stageData.ProductWorkshopIdxMap.TryGetValue(productIdx, out int workshopIdx))
		{
			var buildingDataMap = SeasonalBuildingData;
			if (buildingDataMap != null && buildingDataMap.TryGetValue(workshopIdx, out var buildingData))
			{
				return buildingData as SeasonalWorkshopData;
			}
		}
		return null;
	}

	public static (SeasonalWorkshopData, SeasonalBuildingFacilityData) FindWorkshopProductionFacility(int facilityIdx)
	{
		var workshops = GetBuildingDataOfType<SeasonalWorkshopData>();
		foreach (var workshop in workshops)
		{
			if (workshop.FacilityDataMap != null)
			{
				foreach (var kvp in workshop.FacilityDataMap)
				{
					if (kvp.Value.FacilityIdx == facilityIdx)
						return (workshop, kvp.Value);
				}
			}
		}
		return (null, null);
	}

	public static SeasonalWorkshopData FindLastOpenedWorkshop()
	{
		var workshops = GetBuildingDataOfType<SeasonalWorkshopData>();
		SeasonalWorkshopData lastOpened = null;
		foreach (var workshop in workshops)
		{
			if (workshop.IsOpen != null && workshop.IsOpen.Value)
				lastOpened = workshop;
		}
		return lastOpened;
	}

	public static bool IsStageUseSkill(E_SkillBookAbilityType abilityType)
	{
		var stageData = SeasonalStageData;
		if (stageData?.SeasonalSkillDataMap == null)
			return false;

		foreach (var kvp in stageData.SeasonalSkillDataMap)
		{
			if (kvp.Value.AbilityType == abilityType)
				return true;
		}
		return false;
	}

	public static int GetSkillLevel(E_SkillBookAbilityType abilityType, int targetIdx)
	{
		var stageData = SeasonalStageData;
		if (stageData?.SeasonalSkillDataMap == null)
			return 0;

		foreach (var kvp in stageData.SeasonalSkillDataMap)
		{
			var skill = kvp.Value;
			if (skill.AbilityType == abilityType)
			{
				if (targetIdx <= 0 || (skill.AbilityTargetList != null && skill.AbilityTargetList.Contains(targetIdx)))
					return skill.CurLevel;
			}
		}
		return 0;
	}

	public static BigInteger GetSkillAbilityValue_Per(E_SkillBookAbilityType abilityType, int targetIdx)
	{
		var stageData = SeasonalStageData;
		if (stageData?.SeasonalSkillDataMap == null)
			return BigInteger.Zero;

		foreach (var kvp in stageData.SeasonalSkillDataMap)
		{
			var skill = kvp.Value;
			if (skill.AbilityType == abilityType)
			{
				if (targetIdx <= 0 || (skill.AbilityTargetList != null && skill.AbilityTargetList.Contains(targetIdx)))
					return skill.AbilityValue_Per;
			}
		}
		return BigInteger.Zero;
	}

	public static int GetStatueAbilityValue_Per(E_StatueAbilityType abilityType)
	{
		var shopData = SeasonalShopData;
		if (shopData == null || shopData.IsStatueActive == null || !shopData.IsStatueActive.Value)
			return 0;

		var seasonalSystem = SeasonalSystem;
		if (seasonalSystem == null)
			return 0;

		int statueSlotCount = seasonalSystem.Seasonal_statue_buff_slot_count;
		if (shopData.StatueSlotCount < statueSlotCount)
			return 0;

		switch (abilityType)
		{
			case E_StatueAbilityType.IncMoney:
			case E_StatueAbilityType.IncManagerExp:
				return HUNDRED_FACTOR;
			case E_StatueAbilityType.GetSkillBook_Random:
			case E_StatueAbilityType.GetSkillBook_General:
				return seasonalSystem.Seasonal_statue_buff_reward_skill_book;
			default:
				return 0;
		}
	}

	public static int GetNowBuildingConstructionCount()
	{
		var buildingDataMap = SeasonalBuildingData;
		if (buildingDataMap == null)
			return 0;

		int count = 0;
		foreach (var kvp in buildingDataMap)
		{
			if (kvp.Value.IsConstruction != null && kvp.Value.IsConstruction.Value)
				count++;
		}
		return count;
	}

	public static int GetMaxBuildingProgressCount()
	{
		int maxCount = SeasonalTableHelper.MAX_BUILDING_PROGRESS_CNT;
		var shopData = SeasonalShopData;
		if (shopData != null && shopData.IsActivePremiumBuildingSlot != null && shopData.IsActivePremiumBuildingSlot.Value)
		{
			maxCount += SeasonalTableHelper.ADDITIONAL_BUILDING_PROGRESS_CNT;
		}
		return maxCount;
	}

	public static bool IsApplyBuildingSlotLimit(int seasonIdx)
	{
		int nowConstructionCount = GetNowBuildingConstructionCount();
		int maxCount = GetMaxBuildingProgressCount();
		return nowConstructionCount >= maxCount;
	}

	public static int GetTotalWorkingWorkers()
	{
		var stageData = SeasonalStageData;
		if (stageData?.ActiveWorkerCount != null)
			return stageData.ActiveWorkerCount.Value;
		return 0;
	}

	public static bool IsAllDormitoryMaxLevel()
	{
		var dormitories = GetBuildingDataOfType<SeasonalDormitoryData>();
		if (dormitories.Count == 0)
			return false;

		foreach (var dorm in dormitories)
		{
			if (!dorm.IsOpen.Value)
				continue;
			if (!dorm.IsMaxLevel)
				return false;
		}
		return true;
	}

	public static bool IsAllSkillBookMaxLevel()
	{
		var stageData = SeasonalStageData;
		if (stageData?.SeasonalSkillDataMap == null)
			return false;

		foreach (var kvp in stageData.SeasonalSkillDataMap)
		{
			var skill = kvp.Value;
			if (!skill.IsOpen)
				continue;
			if (skill.CurLevel < skill.MaxLevel)
				return false;
		}
		return true;
	}

	public static SeasonalWorkShopProductionCostInfo CalcWorkshopProductionCostInfo(SeasonalWorkshopData workshopData)
	{
		var stageData = SeasonalStageData;
		if (stageData == null)
			return null;
		return CalcWorkshopProductionCostInfo(workshopData, stageData.CurrencyInventoryMap_PerMile);
	}

	public static SeasonalWorkShopProductionCostInfo CalcWorkshopProductionCostInfo(SeasonalWorkshopData workshopData, ReadOnlyDictionary<int, BigInteger> currencyInventoryMap_PerMile)
	{
		if (workshopData == null || workshopData.ProductionNeedInfoMap == null)
			return null;

		var costInfo = new SeasonalWorkShopProductionCostInfo();
		costInfo.ProductionCostInfos = new List<SeasonalProductionCostInfo>();
		costInfo.bPossibleProduction = true;

		int workerCount = 0;
		if (workshopData.ProductionWorkerCount != null)
			workerCount = workshopData.ProductionWorkerCount.Value;
		costInfo.ProductionWorkerCount = workerCount;

		foreach (var kvp in workshopData.ProductionNeedInfoMap)
		{
			int needProductIdx = kvp.Key;
			int costScaleFactor = kvp.Value;

			BigInteger onceCost = SeasonalFormulaHelper.CalcWorkShopProductionOnceCost_PerMile(workshopData, costScaleFactor);

			BigInteger hasCurrency = BigInteger.Zero;
			if (currencyInventoryMap_PerMile != null && currencyInventoryMap_PerMile.TryGetValue(needProductIdx, out var val))
				hasCurrency = val;

			bool bEnough = hasCurrency >= onceCost;
			if (!bEnough)
				costInfo.bPossibleProduction = false;

			costInfo.ProductionCostInfos.Add(new SeasonalProductionCostInfo
			{
				NeedProductIdx = needProductIdx,
				ProductionOnceNeedCost_PerMile = onceCost,
				bEnoughCost = bEnough
			});
		}

		if (workerCount <= 0)
			costInfo.bPossibleProduction = false;

		return costInfo;
	}

	public static bool IsSkillBookType(E_CurrencyType currencyType, bool includeRandom)
	{
		var skillBookTypes = GetSkillBookTypes(includeRandom);
		return skillBookTypes != null && skillBookTypes.Contains(currencyType);
	}

	public static HashSet<E_CurrencyType> GetSkillBookTypes(bool includeRandom)
	{
		var types = new HashSet<E_CurrencyType>
		{
			E_CurrencyType.SkillBook_IncWorkshopProduction,
			E_CurrencyType.SkillBook_IncManagerExpProduction,
			E_CurrencyType.SkillBook_IncDistributorIncome,
			E_CurrencyType.SkillBook_General
		};
		if (includeRandom)
		{
			types.Add(E_CurrencyType.SkillBook_Random);
		}
		return types;
	}

	public static bool IsUsedSeasonCurrencyType(E_CurrencyType currencyType)
	{
		var stageData = SeasonalStageData;
		if (stageData?.SeasonUseCurrencyMap == null)
			return false;
		return stageData.SeasonUseCurrencyMap.ContainsKey(currencyType);
	}

	public static E_CurrencyType GetSeasonCurrencyType(int currencyIdx)
	{
		var stageData = SeasonalStageData;
		if (stageData?.SeasonUseCurrencyMap == null)
			return E_CurrencyType.None;

		foreach (var kvp in stageData.SeasonUseCurrencyMap)
		{
			if (kvp.Value == currencyIdx)
				return kvp.Key;
		}
		return E_CurrencyType.None;
	}

	public static int GetSeasonCurrencyIdx(E_CurrencyType currencyType)
	{
		var stageData = SeasonalStageData;
		if (stageData?.SeasonUseCurrencyMap == null)
			return 0;

		if (stageData.SeasonUseCurrencyMap.TryGetValue(currencyType, out int currencyIdx))
			return currencyIdx;
		return 0;
	}

	public static BigInteger GetHasCurrencyValue_PerMile(E_CurrencyType currencyType)
	{
		int currencyIdx = GetSeasonCurrencyIdx(currencyType);
		if (currencyIdx == 0)
			return BigInteger.Zero;
		return GetHasCurrencyValue_PerMile(currencyIdx);
	}

	public static BigInteger GetHasCurrencyValue_PerMile(int currencyIdx)
	{
		var stageData = SeasonalStageData;
		if (stageData?.CurrencyInventoryMap_PerMile == null)
			return BigInteger.Zero;

		if (stageData.CurrencyInventoryMap_PerMile.TryGetValue(currencyIdx, out var value))
			return value;
		return BigInteger.Zero;
	}

	public static bool IsEnoughHasCurrency_PerMile(E_CurrencyType currencyType, BigInteger value)
	{
		int currencyIdx = GetSeasonCurrencyIdx(currencyType);
		if (currencyIdx == 0)
			return false;
		return IsEnoughHasCurrency_PerMile(currencyIdx, value);
	}

	public static bool IsEnoughHasCurrency_PerMile(int currencyIdx, BigInteger value)
	{
		var stageData = SeasonalStageData;
		if (stageData == null)
			return false;
		return stageData.IsEnoughHasCurrency(currencyIdx, value);
	}

	public static BigInteger CalculateCurrencyAddableLimit_PerMile(int currencyIdx, BigInteger addValue)
	{
		var stageData = SeasonalStageData;
		if (stageData == null)
			return BigInteger.Zero;

		BigInteger productLimit = stageData.GetProductLimitHasCount(currencyIdx);
		if (productLimit <= BigInteger.Zero)
			return addValue;

		BigInteger currentValue = GetHasCurrencyValue_PerMile(currencyIdx);
		BigInteger remainingCapacity = productLimit - currentValue;
		if (remainingCapacity <= BigInteger.Zero)
			return BigInteger.Zero;

		return addValue < remainingCapacity ? addValue : remainingCapacity;
	}

	public static void IncreaseHasCurrency_PerMile(E_CurrencyType currencyType, BigInteger value)
	{
		int currencyIdx = GetSeasonCurrencyIdx(currencyType);
		if (currencyIdx == 0)
			return;
		IncreaseHasCurrency_PerMile(currencyIdx, value);
	}

	public static Dictionary<E_CurrencyType, BigInteger> PickRandomSkillBook_PerMile(int peekCount)
	{
		var result = new Dictionary<E_CurrencyType, BigInteger>();
		if (peekCount <= 0)
			return result;

		var skillBookTypes = GetSkillBookTypes(false);
		var typeList = new List<E_CurrencyType>(skillBookTypes);
		if (typeList.Count == 0)
			return result;

		var random = new Random();
		for (int i = 0; i < peekCount; i++)
		{
			int idx = random.Next(typeList.Count);
			E_CurrencyType pickedType = typeList[idx];
			if (result.ContainsKey(pickedType))
				result[pickedType] += MILE_FACTOR;
			else
				result[pickedType] = MILE_FACTOR;
		}
		return result;
	}

	public static void IncreaseHasCurrency_PerMile(int currencyIdx, BigInteger value)
	{
		var stageData = SeasonalStageData;
		if (stageData == null)
			return;
		stageData.IncreaseHasCurrency(currencyIdx, value);
	}

	public static void DecreaseHasCurrency_PerMile(E_CurrencyType currencyType, BigInteger value)
	{
		int currencyIdx = GetSeasonCurrencyIdx(currencyType);
		if (currencyIdx == 0)
			return;
		DecreaseHasCurrency_PerMile(currencyIdx, value);
	}

	public static void DecreaseHasCurrency_PerMile(int currencyIdx, BigInteger value)
	{
		var stageData = SeasonalStageData;
		if (stageData == null)
			return;
		stageData.DecreaseHasCurrency(currencyIdx, value);
	}

	public static int GetNowSeasonShopGoodsIdx(int shopGoodsIdx)
	{
		var seasonalData = SeasonalData;
		if (seasonalData == null)
			return shopGoodsIdx;
		return seasonalData.ActiveSeasonIdx * MILE_FACTOR + shopGoodsIdx;
	}

	public static float CalcMilestoneCurStepProgressRatio()
	{
		var milestoneData = SeasonalStageData?.MilestoneData;
		if (milestoneData == null)
			return 0f;

		var progressInfo = milestoneData.GetMilestoneProgressInfo();
		int cur = progressInfo.Item1;
		int max = progressInfo.Item2;

		if (max <= 0)
			return 0f;

		return (float)cur / (float)max;
	}

	public static bool IsSeasonalOfflineRewardMax()
	{
		var stageData = SeasonalStageData;
		if (stageData == null)
			return false;

		int maxTimeSec = SeasonalFormulaHelper.GetOfflineRevenueMaxTimeSec();
		if (maxTimeSec <= 0)
			return false;

		var milestoneData = stageData.MilestoneData;
		if (milestoneData == null)
			return false;

		return milestoneData.MilestoneStepElapsedTimeSec >= maxTimeSec;
	}

	public static E_WorkshopManagerAbilityType ParseToManagerAbility(E_BuildingFacilityAbilityType facilityType)
	{
		switch (facilityType)
		{
			case E_BuildingFacilityAbilityType.IncProductionValue:
				return E_WorkshopManagerAbilityType.IncProductionValue;
			case E_BuildingFacilityAbilityType.DecProductionTime:
				return E_WorkshopManagerAbilityType.DecProductionTime;
			default:
				return E_WorkshopManagerAbilityType.None;
		}
	}

	public static E_CurrencyType ParseStatueBuffCurrencyType(E_StatueAbilityType abilityType)
	{
		switch (abilityType)
		{
			case E_StatueAbilityType.IncMoney:
				return E_CurrencyType.Money;
			case E_StatueAbilityType.IncManagerExp:
				return E_CurrencyType.ManagerExp;
			case E_StatueAbilityType.GetSkillBook_Random:
				return E_CurrencyType.SkillBook_Random;
			case E_StatueAbilityType.GetSkillBook_General:
				return E_CurrencyType.SkillBook_General;
			default:
				return E_CurrencyType.None;
		}
	}

	public static string GetHasCurrencyTextColorKey(bool bEnough)
	{
		return bEnough ? "color_enough" : "color_not_enough";
	}

	public static string GetMissionMainIcon(SeasonalMissionData missionData)
	{
		if (missionData == null)
			return string.Empty;

		var resourceInfo = SeasonalTableHelper.GetCurrencyResourceInfo(missionData.RewardCurrencyType);
		return resourceInfo.Item2;
	}

	public static string MakeMissionDescText(SeasonalMissionData missionData)
	{
		if (missionData == null)
			return string.Empty;

		var missionInfoTable = SeasonalTableHelper.GetSeasonalMissionInfoTable(missionData.MissionIdx);
		if (missionInfoTable == null)
			return string.Empty;

		return string.Format(missionInfoTable.ToString(), missionData.TargetRequireValue);
	}

	public static int MakeWorkerIdx(int buildingIdx, int workerTransformIdx)
	{
		return buildingIdx * MILE_FACTOR + workerTransformIdx;
	}

	public static bool IsTimeValue(int type)
	{
		var facilityType = (E_BuildingFacilityAbilityType)type;
		return facilityType == E_BuildingFacilityAbilityType.DecProductionTime;
	}
}
