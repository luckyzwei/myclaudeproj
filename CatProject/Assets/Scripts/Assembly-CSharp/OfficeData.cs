using System;
using System.Collections.Generic;
using System.Numerics;
using UniRx;

public class OfficeData : IReadOnlyData, ICloneable
{
	public DateTime OpenCompleteTime;

	public DateTime CompanyEndTime;

	public DateTime MaintenanceTime;

	public DateTime LastRepairTime;

	public IReactiveProperty<int> CompanyIdx;

	public IReactiveCollection<OfficeItemData> Items;

	public IReactiveProperty<int> Level;

	public IReactiveProperty<int> Exp;

	public IReactiveProperty<bool> IsOpen;

	public IReactiveProperty<int> OpenRemainTime;

	public IReactiveProperty<int> CompanyRemainTime;

	public Subject<bool> OnEndCompanyContract;

	public IReactiveProperty<int> MaintenanceRemainTime;

	public IReactiveProperty<int> RepaireGuardRemainTime;

	public IReactiveProperty<bool> inMaintenance;

	public IReactiveProperty<bool> inRepair;

	public List<EmployeeData> Employees;

	public BigInteger RentalFee;

	public IReactiveProperty<int> Manager;

	public IReactiveProperty<bool> EnableStrike;

	public IReactiveProperty<bool> OnNegotiation;

	public int LogStrikeNeedLv;

	public bool StrikeRandom;

	public bool StrikeAvoid;

	public void Create()
	{
	}

	public virtual object Clone()
	{
		return null;
	}

	public bool IsOnStrike()
	{
		return false;
	}
}
