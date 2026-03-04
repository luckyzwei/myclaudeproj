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
		CompanyIdx = new ReactiveProperty<int>();
		Level = new ReactiveProperty<int>();
		Exp = new ReactiveProperty<int>();
		IsOpen = new ReactiveProperty<bool>();
		OpenRemainTime = new ReactiveProperty<int>();
		CompanyRemainTime = new ReactiveProperty<int>();
		MaintenanceRemainTime = new ReactiveProperty<int>();
		RepaireGuardRemainTime = new ReactiveProperty<int>();
		inMaintenance = new ReactiveProperty<bool>();
		inRepair = new ReactiveProperty<bool>();
		Manager = new ReactiveProperty<int>();
		EnableStrike = new ReactiveProperty<bool>();
		OnNegotiation = new ReactiveProperty<bool>();
		Items = new ReactiveCollection<OfficeItemData>();
		OnEndCompanyContract = new Subject<bool>();
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
