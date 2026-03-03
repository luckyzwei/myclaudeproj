using System;
using SeasonalDef;
using UniRx;

public class SeasonalWorkerData
{
	public int WorkerIdx;

	public int AssignedDormitoryIdx;

	public int AssignedDormitoryTransformIdx;

	public IReactiveProperty<int> AssignedBuildingIdx;

	public int AssignedBuildingTransformIdx;

	public IReactiveProperty<E_EmployeeMoodState> MoodState;

	public bool bActiveWorker;

	public DateTime LastRestaurantUseTime;
}
