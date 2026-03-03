using Treeplla;
using Treeplla.Data;

public class SeasonalDormitoryData : SeasonalBuildingData
{
	public int WorkerFullCapacity { get; private set; }

	public override void Init(Treeplla.SeasonalBuildingData buildingTable)
	{
	}

	protected override void UpdateFacilityData(Treeplla.Data.SeasonalBuildingData buildingFBData)
	{
	}

	public override void OnUpdateFacilityLevel()
	{
	}
}
