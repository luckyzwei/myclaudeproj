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
		if (CompanyIdx == null) CompanyIdx = new ReactiveProperty<int>();
		if (Level == null) Level = new ReactiveProperty<int>();
		if (Exp == null) Exp = new ReactiveProperty<int>();
		if (IsOpen == null) IsOpen = new ReactiveProperty<bool>();
		if (OpenRemainTime == null) OpenRemainTime = new ReactiveProperty<int>();
		if (CompanyRemainTime == null) CompanyRemainTime = new ReactiveProperty<int>();
		if (MaintenanceRemainTime == null) MaintenanceRemainTime = new ReactiveProperty<int>();
		if (RepaireGuardRemainTime == null) RepaireGuardRemainTime = new ReactiveProperty<int>();
		if (inMaintenance == null) inMaintenance = new ReactiveProperty<bool>();
		if (inRepair == null) inRepair = new ReactiveProperty<bool>();
		if (Manager == null) Manager = new ReactiveProperty<int>();
		if (EnableStrike == null) EnableStrike = new ReactiveProperty<bool>();
		if (OnNegotiation == null) OnNegotiation = new ReactiveProperty<bool>();
		if (Items == null) Items = new ReactiveCollection<OfficeItemData>();
		if (Employees == null) Employees = new List<EmployeeData>();
		if (OnEndCompanyContract == null) OnEndCompanyContract = new Subject<bool>();
	}

	public virtual object Clone()
	{
		OfficeData clone = (OfficeData)MemberwiseClone();
		clone.Create();
		return clone;
	}

	public bool IsOnStrike()
	{
		return false;
	}
}
