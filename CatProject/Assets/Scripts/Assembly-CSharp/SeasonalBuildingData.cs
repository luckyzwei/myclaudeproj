using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using SeasonalDef;
using Treeplla;
using Treeplla.Data;
using UniRx;

public class SeasonalBuildingData
{
	public int BuildingNumber;

	public int MainFacilityIdx;

	public E_BuildingType BuildingType;

	public bool IsLastOpenBuilding;

	public IReactiveProperty<bool> IsOpen;

	public IReactiveProperty<bool> IsConstruction;

	public bool bNeedCompleteNotice;

	public IReactiveProperty<int> Level;

	protected Dictionary<int, SeasonalBuildingFacilityData> facilityDataMap;

	public ReadOnlyDictionary<int, SeasonalBuildingFacilityData> FacilityDataMap;

	protected int SeasonThemeIdx { get; private set; }

	public int BuildingIdx { get; private set; }

	public DateTime ConstructionCompleteDateTime { get; set; }

	public int MaxLevel { get; private set; }

	public bool IsMaxLevel { get { return Level != null && Level.Value >= MaxLevel; } }

	public SeasonalBuildingFacilityData BuildingMainFacilityData
	{
		get
		{
			if (facilityDataMap != null && facilityDataMap.TryGetValue(MainFacilityIdx, out var data))
				return data;
			return null;
		}
	}

	public SeasonalBuildingWorkerData WorkerData { get; protected set; }

	public Dictionary<int, int> ProductionNeedInfoMap { get; protected set; }

	public virtual void Init(Treeplla.SeasonalBuildingData buildingTable)
	{
		BuildingIdx = buildingTable.BuildingIdx;
		IsOpen = new ReactiveProperty<bool>(false);
		IsConstruction = new ReactiveProperty<bool>(false);
		Level = new ReactiveProperty<int>(1);
		facilityDataMap = new Dictionary<int, SeasonalBuildingFacilityData>();
		FacilityDataMap = new ReadOnlyDictionary<int, SeasonalBuildingFacilityData>(facilityDataMap);
		InitFacilityData(buildingTable);
	}

	public virtual void UpdateData(Treeplla.Data.SeasonalBuildingData buildingFBData)
	{
		Level.Value = buildingFBData.Level;
		IsOpen.Value = buildingFBData.Isopen;
		IsConstruction.Value = buildingFBData.Isconstruction;
		if (buildingFBData.Constructioncompletetimeticks > 0)
			ConstructionCompleteDateTime = new DateTime(buildingFBData.Constructioncompletetimeticks);
		UpdateFacilityData(buildingFBData);
	}

	protected virtual void UpdateFacilityData(Treeplla.Data.SeasonalBuildingData buildingFBData)
	{
		for (int i = 0; i < buildingFBData.FacilitydataLength; i++)
		{
			var fd = buildingFBData.Facilitydata(i);
			if (!fd.HasValue) continue;
			int fIdx = fd.Value.Facilityidx;
			if (facilityDataMap != null && facilityDataMap.TryGetValue(fIdx, out var facilityData))
			{
				facilityData.Level.Value = fd.Value.Level;
			}
		}
	}

	public virtual void OnUpdateFacilityLevel()
	{
		// Virtual base - override in subclass
	}

	public void SetProductionFacilityLevelData(int level, SeasonalBuildingFacilityData facilityData)
	{
		if (facilityData == null) return;
		facilityData.Level.Value = level;
		var levelUpInfo = SeasonalTableHelper.GetFacilityLevelTable(BuildingIdx, facilityData.FacilityIdx);
		if (levelUpInfo != null)
		{
			facilityData.CurLevelAbilityValue_PerMille = SeasonalTableHelper.CalcFacilityTotalUpgradeValue_PerMile(BuildingIdx, facilityData.FacilityIdx, level);
			facilityData.NextLevelCostValue_PerMile = SeasonalTableHelper.CalcFacilityTotalUpgradeCost_PerMile(BuildingIdx, facilityData.FacilityIdx, level + 1);
		}
		if (facilityData.OnUpdatedFacilityData != null)
			facilityData.OnUpdatedFacilityData.OnNext(level);
	}

	public virtual void SetOpen()
	{
		OnBeforeOpen();
		if (IsOpen != null)
			IsOpen.Value = true;
		if (IsConstruction != null)
			IsConstruction.Value = false;
	}

	protected virtual void OnBeforeOpen()
	{
		// Virtual base - override in subclass
	}

	public int GetBuildingWorkerCount()
	{
		if (WorkerData == null || WorkerData.HiredWorkerCount == null) return 0;
		return WorkerData.HiredWorkerCount.Value;
	}

	private void InitFacilityData(Treeplla.SeasonalBuildingData buildingTable)
	{
		if (facilityDataMap == null)
			facilityDataMap = new Dictionary<int, SeasonalBuildingFacilityData>();
	}

	protected void setOpenFacility()
	{
		if (facilityDataMap == null) return;
		foreach (var kvp in facilityDataMap)
		{
			if (kvp.Value.Level != null && kvp.Value.Level.Value <= 0)
				kvp.Value.Level.Value = 1;
		}
	}

	protected void setWorkerFacilityLevelData(int hiredCount)
	{
		if (WorkerData == null) return;
		if (WorkerData.HiredWorkerCount != null)
			WorkerData.HiredWorkerCount.Value = hiredCount;
	}
}
