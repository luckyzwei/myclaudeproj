using System;
using System.Collections.Generic;
using System.Numerics;
using SeasonalDef;
using Treeplla;
using Treeplla.Data;
using UniRx;

public class SeasonalWorkshopData : SeasonalBuildingData
{
	public IReactiveProperty<E_WorkshopState> WorkshopState;

	public DateTime LastProductionDataTime;

	public long ProductionCoolTimeMs;

	public BigInteger ProductionTotalOutputValue_PerMille;

	public BigInteger ManagerExpTotalOutputValue_PerMile;

	public IReactiveProperty<int> MaxProductionValue_PerMile;

	public bool IsMaxProduction;

	public IReactiveProperty<int> ProductionWorkerCount;

	public SeasonalWorkshopManagerData ManagerData { get; private set; }

	public List<int> ProductionOutputIdxList { get; private set; }

	public bool IsWorkshopActive { get { return false; } }

	public override void Init(Treeplla.SeasonalBuildingData buildingTable)
	{
	}

	public override void UpdateData(Treeplla.Data.SeasonalBuildingData buildingFBData)
	{
	}

	protected override void OnBeforeOpen()
	{
	}

	public override void OnUpdateFacilityLevel()
	{
	}

	private void InitManagerData(int managerIdx)
	{
	}

	private void setManagerLevelData(int level)
	{
	}
}
