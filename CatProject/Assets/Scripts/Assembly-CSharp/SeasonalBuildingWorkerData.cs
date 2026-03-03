using UniRx;

public class SeasonalBuildingWorkerData
{
	public int FacilityIdx;

	public IReactiveProperty<int> MaxWorkerCount;

	public IReactiveProperty<int> HiredWorkerCount;

	public IReactiveProperty<int> ActiveWorkerCount;
}
