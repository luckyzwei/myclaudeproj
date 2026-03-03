using System.Numerics;
using Treeplla;

public static class SeasonalFormulaHelper
{
	public static bool bPrintLog;

	public static int COST_INSTANT_PURCHASE_GEM_VALUE_SEASONAL;

	public static int FIRST_FREE_SPIN_CHANCE_COUNT;

	public static void InitStaticData()
	{
	}

	public static int CalcBuildingFastConstructNeedCash(int remainTimeSec)
	{
		return 0;
	}

	public static BigInteger CalcBuildingCost_PerMile(BigInteger needCost_Origin_PerMile)
	{
		return default(BigInteger);
	}

	public static BigInteger CalcWorkshopProduction_PerMile(SeasonalWorkshopData workshopData, int possibleWorkerCnt)
	{
		return default(BigInteger);
	}

	public static BigInteger CalcWorkShopProductionOnceCost_PerMile(SeasonalWorkshopData workshopData, int costScaleFactor)
	{
		return default(BigInteger);
	}

	public static BigInteger CalcWorkshopManagerExpProductionValue_PerMile(SeasonalWorkshopData workshopData, int possibleWorkerCnt)
	{
		return default(BigInteger);
	}

	public static BigInteger CalcWorkshopManagerExpProductionValue_PerMile(BigInteger outputValue_PerMile, int possibleWorkerCnt)
	{
		return default(BigInteger);
	}

	public static BigInteger CalcManagerLevelUpCost(BigInteger originUpgradeCost)
	{
		return default(BigInteger);
	}

	public static BigInteger CalcProductOnceDistributeCount_PerMile(int productIdx)
	{
		return default(BigInteger);
	}

	public static BigInteger CalcProductOnceDistributeCount_PerMile(int productIdx, int productLevel)
	{
		return default(BigInteger);
	}

	public static BigInteger CalcProductOnceDistributeRevenue_PerMile(int productIdx)
	{
		return default(BigInteger);
	}

	public static BigInteger CalcProductDistributeRevenue_PerMile(int productIdx, BigInteger distributeCnt_PerMile)
	{
		return default(BigInteger);
	}

	public static BigInteger CalcProductDistributeRevenue_PerMile(SeasonalBuildingSellingData sellingData, BigInteger distributeCnt_PerMile)
	{
		return default(BigInteger);
	}

	public static BigInteger CalcOneSecondManagerExpProduction_PerMile()
	{
		return default(BigInteger);
	}

	public static BigInteger CalcBonusRewardMoneyRevenue_PerMile(int timeSec)
	{
		return default(BigInteger);
	}

	public static BigInteger Calc_NextUpgrade_TransValue_PerMile(int productIdx)
	{
		return default(BigInteger);
	}

	public static BigInteger Calc_NextUpgrade_RevenueValue_PerMile(int themeIdx, int productIdx)
	{
		return default(BigInteger);
	}

	public static BigInteger Calc_DistributorProduct_UpgradeValue_PerMile(int productLevel)
	{
		return default(BigInteger);
	}

	public static BigInteger CalcBonusRewardManagerExpRevenue_PerMile(int timeSec)
	{
		return default(BigInteger);
	}

	public static int GetOfflineRevenueMaxTimeSec()
	{
		return 0;
	}

	public static long CalcPossibleOfflineRevenueTimeSec(long offlineTimeSec)
	{
		return 0L;
	}

	private static (BigInteger, BigInteger) CalcOfflineMoneyRevenue_PerMile(int timeSec, int productIdx, SeasonalOfflineResultData offlineResultData)
	{
		return default((BigInteger, BigInteger));
	}

	public static BigInteger CalcOfflineManagerExpRevenue_PerMile(int timeSec)
	{
		return default(BigInteger);
	}

	public static SeasonalOfflineResultData CalcOfflineRevenue_PerMile(int timeSec)
	{
		return null;
	}

	public static BigInteger CalcOfflineFoodProduction_PerMile(int timeSec)
	{
		return default(BigInteger);
	}

	public static int ArcadeRouletteNeedCoin()
	{
		return 0;
	}

	public static int GetMaxTimeToUnlockNextEmployee()
	{
		return 0;
	}

	public static int GetMaxTimeToUnlockNextEmployee(int buildingIdx)
	{
		return 0;
	}

	public static BigInteger CalcInstantPurchaseGemManagerExp(BigInteger needCount)
	{
		return default(BigInteger);
	}

	public static bool IsGetArcadeMachineFreeChance()
	{
		return false;
	}
}
