public class ElectricWorkSystem
{
	private int office_maintenance_starttime;

	private int office_maintenance_cooltime;

	private int office_maintenance_probability_origin;

	private int office_repair_cooltime;

	public int ceo_repair_runtime { get; private set; }

	public void Init()
	{
	}

	public void SetNextMaintenanceTime(int office, bool isFirst = false)
	{
	}

	public bool IsNeedMaintenance(int office)
	{
		return false;
	}

	public void CallEngineer()
	{
	}

	public void MaintenanceComplete(int office)
	{
	}

	public void RepairComplete(int office)
	{
	}

	public void SetRoomsRepairState()
	{
	}

	public void UpdateOneSeconds(bool isInit = false)
	{
	}

	private bool CheckSkipMaintenance(int office)
	{
		return false;
	}
}
