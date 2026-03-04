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

	public bool IsMaxLevel { get { return false; } }

	public SeasonalBuildingFacilityData BuildingMainFacilityData { get { return null; } }

	public SeasonalBuildingWorkerData WorkerData { get; protected set; }

	public Dictionary<int, int> ProductionNeedInfoMap { get; protected set; }

	public virtual void Init(Treeplla.SeasonalBuildingData buildingTable)
	{
	}

	public virtual void UpdateData(Treeplla.Data.SeasonalBuildingData buildingFBData)
	{
	}

	protected virtual void UpdateFacilityData(Treeplla.Data.SeasonalBuildingData buildingFBData)
	{
	}

	public virtual void OnUpdateFacilityLevel()
	{
	}

	public void SetProductionFacilityLevelData(int level, SeasonalBuildingFacilityData facilityData)
	{
	}

	public virtual void SetOpen()
	{
	}

	protected virtual void OnBeforeOpen()
	{
	}

	public int GetBuildingWorkerCount()
	{
		return 0;
	}

	private void InitFacilityData(Treeplla.SeasonalBuildingData buildingTable)
	{
	}

	protected void setOpenFacility()
	{
	}

	protected void setWorkerFacilityLevelData(int hiredCount)
	{
	}
}
