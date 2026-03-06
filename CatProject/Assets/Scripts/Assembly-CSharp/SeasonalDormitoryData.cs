using Treeplla;
using Treeplla.Data;

public class SeasonalDormitoryData : SeasonalBuildingData
{
	public int WorkerFullCapacity { get; private set; }

	public override void Init(Treeplla.SeasonalBuildingData buildingTable)
	{
		base.Init(buildingTable);
		WorkerFullCapacity = buildingTable.MaxWorkerCount;
	}

	protected override void UpdateFacilityData(Treeplla.Data.SeasonalBuildingData buildingFBData)
	{
		base.UpdateFacilityData(buildingFBData);
	}

	public override void OnUpdateFacilityLevel()
	{
		base.OnUpdateFacilityLevel();
	}
}
