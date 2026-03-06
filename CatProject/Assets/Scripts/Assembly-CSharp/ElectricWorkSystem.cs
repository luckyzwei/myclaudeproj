using System;
using Treeplla;

public class ElectricWorkSystem
{
	private int office_maintenance_starttime;

	private int office_maintenance_cooltime;

	private int office_maintenance_probability_origin;

	private int office_repair_cooltime;

	public int ceo_repair_runtime { get; private set; }

	public void Init()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		// Load config values for maintenance timing
		office_maintenance_starttime = 300;
		office_maintenance_cooltime = 600;
		office_maintenance_probability_origin = 50;
		office_repair_cooltime = 60;
		ceo_repair_runtime = 10;
	}

	private OfficeData GetOffice(int office)
	{
		var userData = Singleton<GameRoot>.Instance.UserData;
		if (userData == null || userData.mainData == null) return null;
		var stageData = userData.mainData.StageData;
		if (stageData == null || stageData.Offices == null) return null;
		stageData.Offices.TryGetValue(office, out var officeData);
		return officeData;
	}

	public void SetNextMaintenanceTime(int office, bool isFirst = false)
	{
		var officeData = GetOffice(office);
		if (officeData == null) return;
		int cooltime = isFirst ? office_maintenance_starttime : office_maintenance_cooltime;
		officeData.MaintenanceTime = DateTime.UtcNow.AddSeconds(cooltime);
		if (officeData.MaintenanceRemainTime != null)
			officeData.MaintenanceRemainTime.Value = cooltime;
	}

	public bool IsNeedMaintenance(int office)
	{
		var officeData = GetOffice(office);
		if (officeData == null) return false;
		if (officeData.inMaintenance != null && officeData.inMaintenance.Value)
			return true;
		return false;
	}

	public void CallEngineer()
	{
	}

	public void MaintenanceComplete(int office)
	{
		var officeData = GetOffice(office);
		if (officeData == null) return;
		if (officeData.inMaintenance != null)
			officeData.inMaintenance.Value = false;
		SetNextMaintenanceTime(office);
	}

	public void RepairComplete(int office)
	{
		var officeData = GetOffice(office);
		if (officeData == null) return;
		if (officeData.inRepair != null)
			officeData.inRepair.Value = false;
		officeData.LastRepairTime = DateTime.UtcNow;
		if (officeData.RepaireGuardRemainTime != null)
			officeData.RepaireGuardRemainTime.Value = office_repair_cooltime;
	}

	public void SetRoomsRepairState()
	{
		var userData = Singleton<GameRoot>.Instance.UserData;
		if (userData == null || userData.mainData == null) return;
		var stageData = userData.mainData.StageData;
		if (stageData == null || stageData.Offices == null) return;
		foreach (var kvp in stageData.Offices)
		{
			var officeData = kvp.Value;
			if (officeData == null) continue;
			// Check and set repair state for each office
		}
	}

	public void UpdateOneSeconds(bool isInit = false)
	{
		var userData = Singleton<GameRoot>.Instance.UserData;
		if (userData == null || userData.mainData == null) return;
		var stageData = userData.mainData.StageData;
		if (stageData == null || stageData.Offices == null) return;
		var now = DateTime.UtcNow;
		foreach (var kvp in stageData.Offices)
		{
			var officeData = kvp.Value;
			if (officeData == null) continue;
			if (officeData.MaintenanceRemainTime != null)
			{
				int remain = (int)(officeData.MaintenanceTime - now).TotalSeconds;
				officeData.MaintenanceRemainTime.Value = Math.Max(0, remain);
				if (remain <= 0 && !CheckSkipMaintenance(kvp.Key))
				{
					if (officeData.inMaintenance != null)
						officeData.inMaintenance.Value = true;
				}
			}
			if (officeData.RepaireGuardRemainTime != null)
			{
				int repairRemain = (int)(officeData.LastRepairTime.AddSeconds(office_repair_cooltime) - now).TotalSeconds;
				officeData.RepaireGuardRemainTime.Value = Math.Max(0, repairRemain);
			}
		}
	}

	private bool CheckSkipMaintenance(int office)
	{
		var officeData = GetOffice(office);
		if (officeData == null) return true;
		if (officeData.IsOpen == null || !officeData.IsOpen.Value) return true;
		if (officeData.inRepair != null && officeData.inRepair.Value) return true;
		return false;
	}
}
