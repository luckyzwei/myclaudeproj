using UniRx;

public class SuperStaffCardData : IClientData
{
	public int StaffIdx;

	public IReactiveProperty<int> StaffLevel;
}
