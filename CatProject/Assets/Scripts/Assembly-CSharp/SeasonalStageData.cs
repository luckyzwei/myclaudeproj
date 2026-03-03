using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Numerics;
using SeasonalDef;
using Treeplla;
using Treeplla.Data;
using UniRx;

public class SeasonalStageData
{
	public int MaxWorkerCount;

	public IReactiveProperty<int> ActiveWorkerCount;

	public IReactiveProperty<int> FreeWorkerCount;

	private Dictionary<int, SeasonalWorkerData> workerDataMap;

	public ReadOnlyDictionary<int, SeasonalWorkerData> WorkerDataMap;

	public SeasonalDistributorData DistributorData;

	public SeasonalArcadeMachineData ArcadeMachineData;

	private Dictionary<int, SeasonalBuildingData> buildingDataMap;

	private Dictionary<E_BuildingType, List<int>> BuildingOpenOrder;

	public SeasonalMilestoneData MilestoneData;

	private Dictionary<int, BigInteger> currencyInventoryMap_PerMile;

	public ReadOnlyDictionary<int, BigInteger> CurrencyInventoryMap_PerMile;

	public List<Dictionary<int, BigInteger>> DelayedRewardInventory;

	public IReactiveCollection<int> CompleteLvList;

	public DateTime AdsupplyCountResetTime;

	public AdsSupplyBankData AdsSupplyBankData;

	private Dictionary<int, SeasonalSkillData> seasonalSkillDataMap;

	public Dictionary<int, SeasonalMissionSaveData> MissionSaveDataMap;

	public DateTime DayStartDateTime;

	public DateTime LastLoginDateTime;

	public IReactiveProperty<bool> IsActiveOvertimeWork;

	public IReactiveProperty<int> SeasonPoint;

	public Subject<Unit> OnChangedAnyWorkerMoodState;

	public DateTime SlotCoinBuffEndTime;

	public DateTime MissionBuffEndTime;

	public SeasonalCoinRankData CoinRankData;

	public bool UseABTest;

	public bool ABTestType;

	public bool IsShownSeasonEndNotice;

	public bool IsShownSeasonStartNotice;

	public int SeasonInfoIdx { get; private set; }

	public int SeasonThemeIdx { get; private set; }

	public int SeasonResourceIdx { get; private set; }

	public int SeasonRewardGroup { get; private set; }

	public DateTime SeasonEndDateTime { get; private set; }

	public ReadOnlyDictionary<int, SeasonalBuildingData> BuildingDataMap { get; private set; }

	public Dictionary<E_BuildingType, IReactiveProperty<int>> OpenableBuildingIdxMap { get; private set; }

	public Dictionary<E_CurrencyType, int> SeasonUseCurrencyMap { get; private set; }

	public Dictionary<int, int> ProductWorkshopIdxMap { get; private set; }

	public DateTime NextAdsupplyTime { get; set; }

	public int AdsupplyShowCount { get; set; }

	public Dictionary<int, Subject<(int currencyIdx, BigInteger currencyValue, BigInteger changeValue)>> CurrencyUpdateEventMap { get; private set; }

	public ReadOnlyDictionary<int, SeasonalSkillData> SeasonalSkillDataMap { get; private set; }

	public DateTime GameStartDateTime { get; private set; }

	public bool IsFirstEnter => false;

	public SeasonalStageData()
	{
	}

	public SeasonalStageData(int seasonInfoIdx)
	{
	}

	public void UpdateData(Treeplla.Data.SeasonalStageData stageFBData)
	{
	}

	public void OnFirstEnterStage()
	{
	}

	public void OnOpenNewBuilding(E_BuildingType buildingType, int openBuildingIdx)
	{
	}

	public void UpdateWorkerCount()
	{
	}

	public ReadOnlyCollection<int> GetBuildingOpenOrder(E_BuildingType buildingType)
	{
		return null;
	}

	public BigInteger GetProductLimitHasCount(int productIdx)
	{
		return default(BigInteger);
	}

	public bool IsEnoughHasCurrency(int currencyIdx, BigInteger value)
	{
		return false;
	}

	public void IncreaseHasCurrency(int currencyIdx, BigInteger increaseValue)
	{
	}

	public void DecreaseHasCurrency(int currencyIdx, BigInteger value)
	{
	}

	public void UpdateHasCurrency(Dictionary<int, BigInteger> currency_PerMile)
	{
	}

	public void LevelUpSkill(int orderIdx)
	{
	}

	private void PutDefaultCurrency(SeasonalInfoData seasonInfoTable)
	{
	}

	private void InitWorkerDataMap()
	{
	}

	private void InitBuildingOpenOrder()
	{
	}

	private void InitOpenableBuildingIdxMap()
	{
	}

	private void InitSkillLevelMap()
	{
	}

	private void UpdateSkillInfo(SeasonalSkillData skillData, SeasonalSkillInfoData skillInfoTable, int newLevel)
	{
	}

	private void InitArcadeMachineData(int level)
	{
	}

	private void InitDistributorProductsData()
	{
	}

	private void PutNewProductToInventory(int idx, BigInteger value, bool bAllowOverWrite)
	{
	}

	private void RecoveryUnSyncWorkerData()
	{
	}
}
