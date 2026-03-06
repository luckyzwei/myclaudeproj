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

	public bool IsWorkshopActive
	{
		get
		{
			return IsOpen != null && IsOpen.Value &&
				WorkshopState != null && WorkshopState.Value != E_WorkshopState.None;
		}
	}

	public override void Init(Treeplla.SeasonalBuildingData buildingTable)
	{
		base.Init(buildingTable);
		WorkshopState = new ReactiveProperty<E_WorkshopState>(E_WorkshopState.None);
		MaxProductionValue_PerMile = new ReactiveProperty<int>(0);
		ProductionWorkerCount = new ReactiveProperty<int>(0);
		ProductionOutputIdxList = new List<int>();
		ProductionTotalOutputValue_PerMille = BigInteger.Zero;
		ManagerExpTotalOutputValue_PerMile = BigInteger.Zero;
		InitManagerData(buildingTable.BuildingIdx);
	}

	public override void UpdateData(Treeplla.Data.SeasonalBuildingData buildingFBData)
	{
		base.UpdateData(buildingFBData);
	}

	protected override void OnBeforeOpen()
	{
		setOpenFacility();
		if (WorkshopState != null)
			WorkshopState.Value = E_WorkshopState.WorkOn;
	}

	public override void OnUpdateFacilityLevel()
	{
		base.OnUpdateFacilityLevel();
	}

	private void InitManagerData(int managerIdx)
	{
		ManagerData = new SeasonalWorkshopManagerData();
		ManagerData.ManagerIdx = managerIdx;
		ManagerData.Level = new ReactiveProperty<int>(1);
		setManagerLevelData(1);
	}

	private void setManagerLevelData(int level)
	{
		if (ManagerData == null) return;
		ManagerData.Level.Value = level;
		var levelTable = SeasonalTableHelper.GetManagerLevelTable(level);
		if (levelTable != null)
		{
			ManagerData.LevelUpNeedCost = SeasonalFormulaHelper.CalcManagerLevelUpCost(new System.Numerics.BigInteger(levelTable.UpgradeCost));
		}
	}
}
