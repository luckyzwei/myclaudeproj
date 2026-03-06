using System.Collections.Generic;
using System.Numerics;
using SeasonalDef;
using Treeplla;

public static class SeasonalFormulaHelper
{
	public static bool bPrintLog;

	public static int COST_INSTANT_PURCHASE_GEM_VALUE_SEASONAL;

	public static int FIRST_FREE_SPIN_CHANCE_COUNT;

	public static void InitStaticData()
	{
		COST_INSTANT_PURCHASE_GEM_VALUE_SEASONAL = 10;
		FIRST_FREE_SPIN_CHANCE_COUNT = 3;
	}

	public static int CalcBuildingFastConstructNeedCash(int remainTimeSec)
	{
		var seasonalSystem = SeasonalHelper.SeasonalSystem;
		if (seasonalSystem == null)
			return 0;

		int skipTime = seasonalSystem.Seasonal_Office_BuildCost_Skip_Time;
		int skipCash = seasonalSystem.Seasonal_Office_BuildCost_Skip_Cash;
		if (skipTime <= 0 || skipCash <= 0)
			return 0;

		int blocks = (remainTimeSec + skipTime - 1) / skipTime;
		if (blocks <= 0) blocks = 1;
		return blocks * skipCash;
	}

	public static BigInteger CalcBuildingCost_PerMile(BigInteger needCost_Origin_PerMile)
	{
		BigInteger skillValue_Per = SeasonalHelper.GetSkillAbilityValue_Per(
			E_SkillBookAbilityType.DecWorkshopCost, 0);

		BigInteger cost = needCost_Origin_PerMile;
		if (skillValue_Per > BigInteger.Zero)
		{
			// Skill reduces cost: cost = origin * (MILE - skillValue) / MILE
			int mileFactor = SeasonalHelper.MILE_FACTOR;
			BigInteger reducedRatio = mileFactor - skillValue_Per;
			if (reducedRatio < BigInteger.Zero)
				reducedRatio = BigInteger.Zero;
			cost = needCost_Origin_PerMile * reducedRatio / mileFactor;
		}

		if (cost < BigInteger.Zero)
			cost = BigInteger.Zero;

		return cost;
	}

	public static BigInteger CalcWorkshopProduction_PerMile(SeasonalWorkshopData workshopData, int possibleWorkerCnt)
	{
		if (workshopData == null || possibleWorkerCnt <= 0)
			return BigInteger.Zero;

		int mileFactor = SeasonalHelper.MILE_FACTOR;

		BigInteger baseProduction_PerMile = BigInteger.Zero;
		if (workshopData.FacilityDataMap != null)
		{
			foreach (var kvp in workshopData.FacilityDataMap)
			{
				if (kvp.Value.FacilityAbilityType == E_BuildingFacilityAbilityType.IncProductionValue)
				{
					baseProduction_PerMile += kvp.Value.CurLevelAbilityValue_PerMille;
				}
			}
		}

		if (baseProduction_PerMile <= BigInteger.Zero)
			baseProduction_PerMile = mileFactor;

		BigInteger managerBonus_PerMile = BigInteger.Zero;
		if (workshopData.ManagerData != null)
		{
			managerBonus_PerMile = workshopData.ManagerData.GetManagerAbility_PerMile(
				E_WorkshopManagerAbilityType.IncProductionValue);
		}

		BigInteger totalProduction = baseProduction_PerMile * possibleWorkerCnt;
		if (managerBonus_PerMile > BigInteger.Zero)
		{
			totalProduction = totalProduction * (mileFactor + managerBonus_PerMile) / mileFactor;
		}

		int statueBuffValue = SeasonalHelper.GetStatueAbilityValue_Per(E_StatueAbilityType.IncMoney);
		if (statueBuffValue > 0)
		{
			totalProduction = totalProduction * (mileFactor + statueBuffValue) / mileFactor;
		}

		return totalProduction;
	}

	public static BigInteger CalcWorkShopProductionOnceCost_PerMile(SeasonalWorkshopData workshopData, int costScaleFactor)
	{
		if (workshopData == null)
			return BigInteger.Zero;

		int mileFactor = SeasonalHelper.MILE_FACTOR;

		BigInteger baseCost_PerMile = new BigInteger(mileFactor);
		if (workshopData.FacilityDataMap != null)
		{
			foreach (var kvp in workshopData.FacilityDataMap)
			{
				if (kvp.Value.FacilityAbilityType == E_BuildingFacilityAbilityType.IncProductionValue)
				{
					baseCost_PerMile = kvp.Value.CurLevelAbilityValue_PerMille;
					break;
				}
			}
		}

		BigInteger onceCost = baseCost_PerMile * costScaleFactor / mileFactor;

		BigInteger skillValue_Per = SeasonalHelper.GetSkillAbilityValue_Per(
			E_SkillBookAbilityType.DecWorkshopCost, workshopData.BuildingIdx);
		if (skillValue_Per > BigInteger.Zero)
		{
			BigInteger reducedRatio = mileFactor - skillValue_Per;
			if (reducedRatio < BigInteger.Zero)
				reducedRatio = BigInteger.Zero;
			onceCost = onceCost * reducedRatio / mileFactor;
		}

		if (onceCost < BigInteger.Zero)
			onceCost = BigInteger.Zero;

		return onceCost;
	}

	public static BigInteger CalcWorkshopManagerExpProductionValue_PerMile(SeasonalWorkshopData workshopData, int possibleWorkerCnt)
	{
		if (workshopData == null || possibleWorkerCnt <= 0)
			return BigInteger.Zero;

		BigInteger outputValue_PerMile = CalcWorkshopProduction_PerMile(workshopData, possibleWorkerCnt);
		return CalcWorkshopManagerExpProductionValue_PerMile(outputValue_PerMile, possibleWorkerCnt);
	}

	public static BigInteger CalcWorkshopManagerExpProductionValue_PerMile(BigInteger outputValue_PerMile, int possibleWorkerCnt)
	{
		if (outputValue_PerMile <= BigInteger.Zero || possibleWorkerCnt <= 0)
			return BigInteger.Zero;

		int mileFactor = SeasonalHelper.MILE_FACTOR;

		BigInteger managerExp = outputValue_PerMile;

		BigInteger skillValue_Per = SeasonalHelper.GetSkillAbilityValue_Per(
			E_SkillBookAbilityType.IncManagerExpProduction, 0);
		if (skillValue_Per > BigInteger.Zero)
		{
			managerExp = managerExp * (mileFactor + skillValue_Per) / mileFactor;
		}

		int statueBuffValue = SeasonalHelper.GetStatueAbilityValue_Per(E_StatueAbilityType.IncManagerExp);
		if (statueBuffValue > 0)
		{
			managerExp = managerExp * (mileFactor + statueBuffValue) / mileFactor;
		}

		return managerExp;
	}

	public static BigInteger CalcManagerLevelUpCost(BigInteger originUpgradeCost)
	{
		if (originUpgradeCost <= BigInteger.Zero)
			return BigInteger.Zero;

		int mileFactor = SeasonalHelper.MILE_FACTOR;

		BigInteger skillValue_Per = SeasonalHelper.GetSkillAbilityValue_Per(
			E_SkillBookAbilityType.DecWorkshopCost, 0);

		BigInteger cost = originUpgradeCost * mileFactor;
		if (skillValue_Per > BigInteger.Zero)
		{
			BigInteger reducedRatio = mileFactor - skillValue_Per;
			if (reducedRatio < BigInteger.Zero)
				reducedRatio = BigInteger.Zero;
			cost = cost * reducedRatio / mileFactor;
		}

		if (cost < BigInteger.Zero)
			cost = BigInteger.Zero;

		return cost;
	}

	public static BigInteger CalcProductOnceDistributeCount_PerMile(int productIdx)
	{
		var workshopData = SeasonalHelper.FindProductionWorkshop(productIdx);
		int productLevel = 1;
		var stageData = SeasonalHelper.SeasonalStageData;
		if (stageData?.DistributorData?.SaleProductsMap != null &&
			stageData.DistributorData.SaleProductsMap.TryGetValue(productIdx, out var productData))
		{
			productLevel = productData.productLevel;
		}

		return CalcProductOnceDistributeCount_PerMile(productIdx, productLevel);
	}

	public static BigInteger CalcProductOnceDistributeCount_PerMile(int productIdx, int productLevel)
	{
		int mileFactor = SeasonalHelper.MILE_FACTOR;

		BigInteger baseCount = new BigInteger(mileFactor) * productLevel;

		BigInteger skillValue_Per = SeasonalHelper.GetSkillAbilityValue_Per(
			E_SkillBookAbilityType.IncOnceDistributeCount, productIdx);
		if (skillValue_Per > BigInteger.Zero)
		{
			baseCount = baseCount * (mileFactor + skillValue_Per) / mileFactor;
		}

		return baseCount;
	}

	public static BigInteger CalcProductOnceDistributeRevenue_PerMile(int productIdx)
	{
		BigInteger distributeCnt_PerMile = CalcProductOnceDistributeCount_PerMile(productIdx);
		return CalcProductDistributeRevenue_PerMile(productIdx, distributeCnt_PerMile);
	}

	public static BigInteger CalcProductDistributeRevenue_PerMile(int productIdx, BigInteger distributeCnt_PerMile)
	{
		if (distributeCnt_PerMile <= BigInteger.Zero)
			return BigInteger.Zero;

		int mileFactor = SeasonalHelper.MILE_FACTOR;

		var workshopData = SeasonalHelper.FindProductionWorkshop(productIdx);
		BigInteger baseProductionValue_PerMile = new BigInteger(mileFactor);
		if (workshopData != null)
		{
			int workerCnt = 1;
			if (workshopData.ProductionWorkerCount != null && workshopData.ProductionWorkerCount.Value > 0)
				workerCnt = workshopData.ProductionWorkerCount.Value;
			baseProductionValue_PerMile = CalcWorkshopProduction_PerMile(workshopData, workerCnt);
		}

		BigInteger revenue = distributeCnt_PerMile * baseProductionValue_PerMile / mileFactor;

		BigInteger skillValue_Per = SeasonalHelper.GetSkillAbilityValue_Per(
			E_SkillBookAbilityType.IncAllDistributorIncome, 0);
		if (skillValue_Per > BigInteger.Zero)
		{
			revenue = revenue * (mileFactor + skillValue_Per) / mileFactor;
		}

		BigInteger workshopSkillValue_Per = SeasonalHelper.GetSkillAbilityValue_Per(
			E_SkillBookAbilityType.IncWorkshopDistributorIncome, productIdx);
		if (workshopSkillValue_Per > BigInteger.Zero)
		{
			revenue = revenue * (mileFactor + workshopSkillValue_Per) / mileFactor;
		}

		return revenue;
	}

	public static BigInteger CalcProductDistributeRevenue_PerMile(SeasonalBuildingSellingData sellingData, BigInteger distributeCnt_PerMile)
	{
		if (sellingData == null || distributeCnt_PerMile <= BigInteger.Zero)
			return BigInteger.Zero;

		int mileFactor = SeasonalHelper.MILE_FACTOR;

		BigInteger revenue = sellingData.OnceDistributeRevenue_PerMile * distributeCnt_PerMile / mileFactor;
		return revenue;
	}

	public static BigInteger CalcOneSecondManagerExpProduction_PerMile()
	{
		int mileFactor = SeasonalHelper.MILE_FACTOR;
		BigInteger totalManagerExp = BigInteger.Zero;

		var workshops = SeasonalHelper.GetBuildingDataOfType<SeasonalWorkshopData>();
		foreach (var workshop in workshops)
		{
			if (!workshop.IsWorkshopActive)
				continue;

			int workerCnt = 0;
			if (workshop.ProductionWorkerCount != null)
				workerCnt = workshop.ProductionWorkerCount.Value;
			if (workerCnt <= 0)
				continue;

			BigInteger workshopExp = CalcWorkshopManagerExpProductionValue_PerMile(workshop, workerCnt);
			totalManagerExp += workshopExp;
		}

		return totalManagerExp;
	}

	public static BigInteger CalcBonusRewardMoneyRevenue_PerMile(int timeSec)
	{
		if (timeSec <= 0)
			return BigInteger.Zero;

		int mileFactor = SeasonalHelper.MILE_FACTOR;
		int correctionValue = SeasonalTableHelper.BONUS_MONEY_CORRECTION_VALUE;
		if (correctionValue <= 0)
			correctionValue = mileFactor;

		BigInteger totalRevenue = BigInteger.Zero;
		var workshops = SeasonalHelper.GetBuildingDataOfType<SeasonalWorkshopData>();
		foreach (var workshop in workshops)
		{
			if (!workshop.IsWorkshopActive)
				continue;

			int workerCnt = 0;
			if (workshop.ProductionWorkerCount != null)
				workerCnt = workshop.ProductionWorkerCount.Value;
			if (workerCnt <= 0)
				continue;

			BigInteger production = CalcWorkshopProduction_PerMile(workshop, workerCnt);
			totalRevenue += production;
		}

		BigInteger bonus = totalRevenue * timeSec * correctionValue / mileFactor;
		return bonus;
	}

	public static BigInteger Calc_NextUpgrade_TransValue_PerMile(int productIdx)
	{
		var stageData = SeasonalHelper.SeasonalStageData;
		int productLevel = 1;
		if (stageData?.DistributorData?.SaleProductsMap != null &&
			stageData.DistributorData.SaleProductsMap.TryGetValue(productIdx, out var productData))
		{
			productLevel = productData.productLevel;
		}

		int nextLevel = productLevel + 1;
		return CalcProductOnceDistributeCount_PerMile(productIdx, nextLevel);
	}

	public static BigInteger Calc_NextUpgrade_RevenueValue_PerMile(int themeIdx, int productIdx)
	{
		BigInteger nextDistributeCount = Calc_NextUpgrade_TransValue_PerMile(productIdx);
		return CalcProductDistributeRevenue_PerMile(productIdx, nextDistributeCount);
	}

	public static BigInteger Calc_DistributorProduct_UpgradeValue_PerMile(int productLevel)
	{
		if (productLevel <= 0)
			return BigInteger.Zero;

		int mileFactor = SeasonalHelper.MILE_FACTOR;

		BigInteger upgradeValue = new BigInteger(mileFactor) * (productLevel + 1);
		return upgradeValue;
	}

	public static BigInteger CalcBonusRewardManagerExpRevenue_PerMile(int timeSec)
	{
		if (timeSec <= 0)
			return BigInteger.Zero;

		int mileFactor = SeasonalHelper.MILE_FACTOR;
		int correctionValue = SeasonalTableHelper.BONUS_MANAGER_EXP_CORRECTION_VALUE;
		if (correctionValue <= 0)
			correctionValue = mileFactor;

		BigInteger totalManagerExp = CalcOneSecondManagerExpProduction_PerMile();

		BigInteger bonus = totalManagerExp * timeSec * correctionValue / mileFactor;
		return bonus;
	}

	public static int GetOfflineRevenueMaxTimeSec()
	{
		return SeasonalTableHelper.OFFLINE_REWARD_MAX_TIME_SEC;
	}

	public static long CalcPossibleOfflineRevenueTimeSec(long offlineTimeSec)
	{
		int minTimeSec = SeasonalTableHelper.OFFLINE_REWARD_MIN_TIME_SEC;
		int maxTimeSec = SeasonalTableHelper.OFFLINE_REWARD_MAX_TIME_SEC;

		if (offlineTimeSec < minTimeSec)
			return 0L;

		if (maxTimeSec > 0 && offlineTimeSec > maxTimeSec)
			return maxTimeSec;

		return offlineTimeSec;
	}

	private static (BigInteger, BigInteger) CalcOfflineMoneyRevenue_PerMile(int timeSec, int productIdx, SeasonalOfflineResultData offlineResultData)
	{
		if (timeSec <= 0)
			return (BigInteger.Zero, BigInteger.Zero);

		int mileFactor = SeasonalHelper.MILE_FACTOR;
		int correctionValue = SeasonalTableHelper.OFFLINE_REWARD_CORRECTION_VALUE;
		if (correctionValue <= 0)
			correctionValue = mileFactor;

		var workshopData = SeasonalHelper.FindProductionWorkshop(productIdx);
		if (workshopData == null || !workshopData.IsWorkshopActive)
			return (BigInteger.Zero, BigInteger.Zero);

		int workerCnt = 0;
		if (workshopData.ProductionWorkerCount != null)
			workerCnt = workshopData.ProductionWorkerCount.Value;
		if (workerCnt <= 0)
			return (BigInteger.Zero, BigInteger.Zero);

		BigInteger production_PerMile = CalcWorkshopProduction_PerMile(workshopData, workerCnt);
		BigInteger productionTotal = production_PerMile * timeSec * correctionValue / mileFactor;

		BigInteger distributeCount = CalcProductOnceDistributeCount_PerMile(productIdx);
		BigInteger revenue = CalcProductDistributeRevenue_PerMile(productIdx, distributeCount);
		BigInteger revenueTotal = revenue * timeSec * correctionValue / mileFactor;

		if (offlineResultData != null)
		{
			offlineResultData.IncreaseHasCurrency_PerMile(productIdx, productionTotal);
		}

		return (productionTotal, revenueTotal);
	}

	public static BigInteger CalcOfflineManagerExpRevenue_PerMile(int timeSec)
	{
		if (timeSec <= 0)
			return BigInteger.Zero;

		int mileFactor = SeasonalHelper.MILE_FACTOR;
		int correctionValue = SeasonalTableHelper.OFFLINE_REWARD_CORRECTION_VALUE;
		if (correctionValue <= 0)
			correctionValue = mileFactor;

		BigInteger totalManagerExp = CalcOneSecondManagerExpProduction_PerMile();
		BigInteger offlineExp = totalManagerExp * timeSec * correctionValue / mileFactor;
		return offlineExp;
	}

	public static SeasonalOfflineResultData CalcOfflineRevenue_PerMile(int timeSec)
	{
		var resultData = new SeasonalOfflineResultData();
		resultData.OfflineCurrencyResult_PerMile = new Dictionary<int, BigInteger>();

		if (timeSec <= 0)
			return resultData;

		int mileFactor = SeasonalHelper.MILE_FACTOR;

		int moneyCurrencyIdx = SeasonalHelper.GetSeasonCurrencyIdx(E_CurrencyType.Money);
		int managerExpCurrencyIdx = SeasonalHelper.GetSeasonCurrencyIdx(E_CurrencyType.ManagerExp);

		BigInteger totalMoneyRevenue = BigInteger.Zero;

		var workshops = SeasonalHelper.GetBuildingDataOfType<SeasonalWorkshopData>();
		foreach (var workshop in workshops)
		{
			if (!workshop.IsWorkshopActive)
				continue;

			if (workshop.ProductionOutputIdxList != null)
			{
				foreach (int productIdx in workshop.ProductionOutputIdxList)
				{
					var (production, revenue) = CalcOfflineMoneyRevenue_PerMile(timeSec, productIdx, resultData);
					totalMoneyRevenue += revenue;
				}
			}
		}

		if (moneyCurrencyIdx > 0 && totalMoneyRevenue > BigInteger.Zero)
		{
			resultData.IncreaseHasCurrency_PerMile(moneyCurrencyIdx, totalMoneyRevenue);
		}

		BigInteger offlineManagerExp = CalcOfflineManagerExpRevenue_PerMile(timeSec);
		if (managerExpCurrencyIdx > 0 && offlineManagerExp > BigInteger.Zero)
		{
			resultData.IncreaseHasCurrency_PerMile(managerExpCurrencyIdx, offlineManagerExp);
		}

		var stageData = SeasonalHelper.SeasonalStageData;
		if (stageData != null)
		{
			resultData.UpdateOfflineRevenue(stageData.CurrencyInventoryMap_PerMile);
		}

		return resultData;
	}

	public static BigInteger CalcOfflineFoodProduction_PerMile(int timeSec)
	{
		if (timeSec <= 0)
			return BigInteger.Zero;

		int mileFactor = SeasonalHelper.MILE_FACTOR;
		int correctionValue = SeasonalTableHelper.OFFLINE_REWARD_CORRECTION_VALUE;
		if (correctionValue <= 0)
			correctionValue = mileFactor;

		int activeWorkerCount = SeasonalHelper.GetTotalWorkingWorkers();
		if (activeWorkerCount <= 0)
			return BigInteger.Zero;

		BigInteger foodProduction = new BigInteger(mileFactor) * activeWorkerCount * timeSec * correctionValue / mileFactor;
		return foodProduction;
	}

	public static int ArcadeRouletteNeedCoin()
	{
		return SeasonalTableHelper.ARCADE_ROULETTE_NEED_COIN;
	}

	public static int GetMaxTimeToUnlockNextEmployee()
	{
		int maxTime = 0;
		var workshops = SeasonalHelper.GetBuildingDataOfType<SeasonalWorkshopData>();
		foreach (var workshop in workshops)
		{
			if (!workshop.IsWorkshopActive)
				continue;

			int time = GetMaxTimeToUnlockNextEmployee(workshop.BuildingIdx);
			if (time > maxTime)
				maxTime = time;
		}
		return maxTime;
	}

	public static int GetMaxTimeToUnlockNextEmployee(int buildingIdx)
	{
		var buildingDataMap = SeasonalHelper.SeasonalBuildingData;
		if (buildingDataMap == null || !buildingDataMap.TryGetValue(buildingIdx, out var buildingData))
			return 0;

		var buildingTable = SeasonalTableHelper.GetBuildingTable(buildingIdx);
		if (buildingTable != null)
			return buildingTable.DistributorCoolTimeSec;

		return 0;
	}

	public static BigInteger CalcInstantPurchaseGemManagerExp(BigInteger needCount)
	{
		if (needCount <= BigInteger.Zero)
			return BigInteger.Zero;

		int mileFactor = SeasonalHelper.MILE_FACTOR;

		BigInteger managerExp = needCount * COST_INSTANT_PURCHASE_GEM_VALUE_SEASONAL * mileFactor;
		return managerExp;
	}

	public static bool IsGetArcadeMachineFreeChance()
	{
		var stageData = SeasonalHelper.SeasonalStageData;
		if (stageData?.ArcadeMachineData == null)
			return false;

		var arcadeData = stageData.ArcadeMachineData;

		if (arcadeData.FirstFreeChanceCheckCount < FIRST_FREE_SPIN_CHANCE_COUNT)
			return true;

		BigInteger skillValue_Per = SeasonalHelper.GetSkillAbilityValue_Per(
			E_SkillBookAbilityType.ArcadeMachineFreeChanceRatio, 0);
		if (skillValue_Per > BigInteger.Zero)
		{
			return arcadeData.bFreeChance;
		}

		return false;
	}
}
