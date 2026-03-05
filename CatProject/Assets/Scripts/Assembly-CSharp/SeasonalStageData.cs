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

	public bool IsFirstEnter { get { return GameStartDateTime == DateTime.MinValue; } }

	public SeasonalStageData()
	{
		buildingDataMap = new Dictionary<int, SeasonalBuildingData>();
		BuildingDataMap = new ReadOnlyDictionary<int, SeasonalBuildingData>(buildingDataMap);
		currencyInventoryMap_PerMile = new Dictionary<int, BigInteger>();
		CurrencyInventoryMap_PerMile = new ReadOnlyDictionary<int, BigInteger>(currencyInventoryMap_PerMile);
		workerDataMap = new Dictionary<int, SeasonalWorkerData>();
		WorkerDataMap = new ReadOnlyDictionary<int, SeasonalWorkerData>(workerDataMap);
		seasonalSkillDataMap = new Dictionary<int, SeasonalSkillData>();
		SeasonalSkillDataMap = new ReadOnlyDictionary<int, SeasonalSkillData>(seasonalSkillDataMap);
		BuildingOpenOrder = new Dictionary<E_BuildingType, List<int>>();
		OpenableBuildingIdxMap = new Dictionary<E_BuildingType, IReactiveProperty<int>>();
		SeasonUseCurrencyMap = new Dictionary<E_CurrencyType, int>();
		ProductWorkshopIdxMap = new Dictionary<int, int>();
		CurrencyUpdateEventMap = new Dictionary<int, Subject<(int, BigInteger, BigInteger)>>();
		MissionSaveDataMap = new Dictionary<int, SeasonalMissionSaveData>();
		DelayedRewardInventory = new List<Dictionary<int, BigInteger>>();
		CompleteLvList = new ReactiveCollection<int>();
		ActiveWorkerCount = new ReactiveProperty<int>(0);
		FreeWorkerCount = new ReactiveProperty<int>(0);
		IsActiveOvertimeWork = new ReactiveProperty<bool>(false);
		SeasonPoint = new ReactiveProperty<int>(0);
		OnChangedAnyWorkerMoodState = new Subject<Unit>();
	}

	public SeasonalStageData(int seasonInfoIdx) : this()
	{
		SeasonInfoIdx = seasonInfoIdx;
	}

	public void UpdateData(Treeplla.Data.SeasonalStageData stageFBData)
	{
		SeasonInfoIdx = stageFBData.Seasoninfoidx;

		if (stageFBData.Adsupplytime > 0)
			NextAdsupplyTime = new DateTime(stageFBData.Adsupplytime * TimeSpan.TicksPerSecond);
		if (stageFBData.Adsupplyresettime > 0)
			AdsupplyCountResetTime = new DateTime(stageFBData.Adsupplyresettime * TimeSpan.TicksPerSecond);
		AdsupplyShowCount = stageFBData.Adsupplycount;

		if (stageFBData.Gamestarttime > 0)
			GameStartDateTime = new DateTime(stageFBData.Gamestarttime * TimeSpan.TicksPerSecond);
		if (stageFBData.Lastlogintime > 0)
			LastLoginDateTime = new DateTime(stageFBData.Lastlogintime * TimeSpan.TicksPerSecond);
		if (stageFBData.Daystarttime > 0)
			DayStartDateTime = new DateTime(stageFBData.Daystarttime * TimeSpan.TicksPerSecond);

		IsActiveOvertimeWork.Value = stageFBData.Overtimeworkactive;
		SeasonPoint.Value = stageFBData.Seasonpoint;

		if (stageFBData.Slotcoinbufftime > 0)
			SlotCoinBuffEndTime = new DateTime(stageFBData.Slotcoinbufftime * TimeSpan.TicksPerSecond);
		if (stageFBData.Missioncoinbufftime > 0)
			MissionBuffEndTime = new DateTime(stageFBData.Missioncoinbufftime * TimeSpan.TicksPerSecond);

		UseABTest = stageFBData.Useabtest;
		ABTestType = stageFBData.Abtestype;
		IsShownSeasonEndNotice = stageFBData.Isshownseasonendnotice;
		IsShownSeasonStartNotice = stageFBData.Isshownseasonstartnotice;

		for (int i = 0; i < stageFBData.CurrencydataLength; i++)
		{
			var cd = stageFBData.Currencydata(i);
			if (cd.HasValue)
			{
				int idx = cd.Value.Currencyidx;
				string valStr = cd.Value.Currencyvalue;
				BigInteger val = BigInteger.Zero;
				if (!string.IsNullOrEmpty(valStr))
					BigInteger.TryParse(valStr, out val);
				currencyInventoryMap_PerMile[idx] = val;
			}
		}

		for (int i = 0; i < stageFBData.CompleterewardlistLength; i++)
		{
			int lv = stageFBData.Completerewardlist(i);
			if (!CompleteLvList.Contains(lv))
				CompleteLvList.Add(lv);
		}
	}

	public void OnFirstEnterStage()
	{
		GameStartDateTime = TimeSystem.GetCurTime();
		DayStartDateTime = GameStartDateTime;
		LastLoginDateTime = GameStartDateTime;
	}

	public void OnOpenNewBuilding(E_BuildingType buildingType, int openBuildingIdx)
	{
		if (OpenableBuildingIdxMap != null && OpenableBuildingIdxMap.TryGetValue(buildingType, out var prop))
		{
			if (BuildingOpenOrder != null && BuildingOpenOrder.TryGetValue(buildingType, out var orderList))
			{
				int curIdx = orderList.IndexOf(openBuildingIdx);
				if (curIdx >= 0 && curIdx + 1 < orderList.Count)
					prop.Value = orderList[curIdx + 1];
			}
		}
	}

	public void UpdateWorkerCount()
	{
		if (workerDataMap == null) return;
		int active = 0;
		int free = 0;
		foreach (var kvp in workerDataMap)
		{
			if (kvp.Value.bActiveWorker)
			{
				active++;
				if (kvp.Value.AssignedBuildingIdx != null && kvp.Value.AssignedBuildingIdx.Value <= 0)
					free++;
			}
		}
		ActiveWorkerCount.Value = active;
		FreeWorkerCount.Value = free;
	}

	public ReadOnlyCollection<int> GetBuildingOpenOrder(E_BuildingType buildingType)
	{
		if (BuildingOpenOrder != null && BuildingOpenOrder.TryGetValue(buildingType, out var list))
			return list.AsReadOnly();
		return null;
	}

	public BigInteger GetProductLimitHasCount(int productIdx)
	{
		return BigInteger.Zero;
	}

	public bool IsEnoughHasCurrency(int currencyIdx, BigInteger value)
	{
		if (currencyInventoryMap_PerMile == null) return false;
		if (currencyInventoryMap_PerMile.TryGetValue(currencyIdx, out var has))
			return has >= value;
		return false;
	}

	public void IncreaseHasCurrency(int currencyIdx, BigInteger increaseValue)
	{
		if (currencyInventoryMap_PerMile == null) return;
		if (currencyInventoryMap_PerMile.TryGetValue(currencyIdx, out var cur))
			currencyInventoryMap_PerMile[currencyIdx] = cur + increaseValue;
		else
			currencyInventoryMap_PerMile[currencyIdx] = increaseValue;

		NotifyCurrencyUpdate(currencyIdx, increaseValue);
	}

	public void DecreaseHasCurrency(int currencyIdx, BigInteger value)
	{
		if (currencyInventoryMap_PerMile == null) return;
		if (currencyInventoryMap_PerMile.TryGetValue(currencyIdx, out var cur))
		{
			var newVal = cur - value;
			if (newVal < BigInteger.Zero) newVal = BigInteger.Zero;
			currencyInventoryMap_PerMile[currencyIdx] = newVal;
			NotifyCurrencyUpdate(currencyIdx, -value);
		}
	}

	public void UpdateHasCurrency(Dictionary<int, BigInteger> currency_PerMile)
	{
		if (currency_PerMile == null || currencyInventoryMap_PerMile == null) return;
		foreach (var kvp in currency_PerMile)
		{
			BigInteger prev = BigInteger.Zero;
			currencyInventoryMap_PerMile.TryGetValue(kvp.Key, out prev);
			currencyInventoryMap_PerMile[kvp.Key] = kvp.Value;
			NotifyCurrencyUpdate(kvp.Key, kvp.Value - prev);
		}
	}

	public void LevelUpSkill(int orderIdx)
	{
		if (seasonalSkillDataMap == null) return;
		if (seasonalSkillDataMap.TryGetValue(orderIdx, out var skill))
		{
			if (skill.CurLevel < skill.MaxLevel)
			{
				int newLevel = skill.CurLevel + 1;
				skill.CurLevel = newLevel;
			}
		}
	}

	private void PutDefaultCurrency(SeasonalInfoData seasonInfoTable)
	{
	}

	private void InitWorkerDataMap()
	{
		if (workerDataMap == null)
			workerDataMap = new Dictionary<int, SeasonalWorkerData>();
		WorkerDataMap = new ReadOnlyDictionary<int, SeasonalWorkerData>(workerDataMap);
	}

	private void InitBuildingOpenOrder()
	{
		if (BuildingOpenOrder == null)
			BuildingOpenOrder = new Dictionary<E_BuildingType, List<int>>();
		BuildingOpenOrder.Clear();

		if (buildingDataMap == null) return;
		foreach (var kvp in buildingDataMap)
		{
			var bd = kvp.Value;
			if (!BuildingOpenOrder.TryGetValue(bd.BuildingType, out var list))
			{
				list = new List<int>();
				BuildingOpenOrder[bd.BuildingType] = list;
			}
			list.Add(bd.BuildingIdx);
		}
		foreach (var kvp in BuildingOpenOrder)
			kvp.Value.Sort();
	}

	private void InitOpenableBuildingIdxMap()
	{
		if (OpenableBuildingIdxMap == null)
			OpenableBuildingIdxMap = new Dictionary<E_BuildingType, IReactiveProperty<int>>();
		OpenableBuildingIdxMap.Clear();

		if (BuildingOpenOrder == null) return;
		foreach (var kvp in BuildingOpenOrder)
		{
			int nextOpenIdx = 0;
			for (int i = 0; i < kvp.Value.Count; i++)
			{
				int bIdx = kvp.Value[i];
				if (buildingDataMap.TryGetValue(bIdx, out var bd))
				{
					if (bd.IsOpen == null || !bd.IsOpen.Value)
					{
						nextOpenIdx = bIdx;
						break;
					}
				}
			}
			OpenableBuildingIdxMap[kvp.Key] = new ReactiveProperty<int>(nextOpenIdx);
		}
	}

	private void InitSkillLevelMap()
	{
		if (seasonalSkillDataMap == null)
			seasonalSkillDataMap = new Dictionary<int, SeasonalSkillData>();
		SeasonalSkillDataMap = new ReadOnlyDictionary<int, SeasonalSkillData>(seasonalSkillDataMap);
	}

	private void UpdateSkillInfo(SeasonalSkillData skillData, SeasonalSkillInfoData skillInfoTable, int newLevel)
	{
		if (skillData == null || skillInfoTable == null) return;
		skillData.CurLevel = newLevel;
		skillData.AbilityType = skillInfoTable.AbilityType;
		skillData.MaxLevel = skillInfoTable.MaxLevel;
		int baseValue = skillInfoTable.AbilityValue;
		int incValue = skillInfoTable.AbilityIncValue;
		skillData.AbilityValue_Per = baseValue + incValue * newLevel;
	}

	private void InitArcadeMachineData(int level)
	{
		if (ArcadeMachineData == null)
			ArcadeMachineData = new SeasonalArcadeMachineData();
		ArcadeMachineData.Level = level;
	}

	private void InitDistributorProductsData()
	{
	}

	private void PutNewProductToInventory(int idx, BigInteger value, bool bAllowOverWrite)
	{
		if (currencyInventoryMap_PerMile == null) return;
		if (bAllowOverWrite || !currencyInventoryMap_PerMile.ContainsKey(idx))
			currencyInventoryMap_PerMile[idx] = value;
	}

	private void RecoveryUnSyncWorkerData()
	{
		if (workerDataMap == null || buildingDataMap == null) return;
		foreach (var kvp in workerDataMap)
		{
			var worker = kvp.Value;
			if (worker.AssignedBuildingIdx != null && worker.AssignedBuildingIdx.Value > 0)
			{
				if (!buildingDataMap.ContainsKey(worker.AssignedBuildingIdx.Value))
				{
					worker.AssignedBuildingIdx.Value = 0;
					worker.AssignedBuildingTransformIdx = 0;
				}
			}
		}
		UpdateWorkerCount();
	}

	private void NotifyCurrencyUpdate(int currencyIdx, BigInteger changeValue)
	{
		if (CurrencyUpdateEventMap != null && CurrencyUpdateEventMap.TryGetValue(currencyIdx, out var subject))
		{
			BigInteger curValue = BigInteger.Zero;
			if (currencyInventoryMap_PerMile != null)
				currencyInventoryMap_PerMile.TryGetValue(currencyIdx, out curValue);
			subject.OnNext((currencyIdx, curValue, changeValue));
		}
	}
}
