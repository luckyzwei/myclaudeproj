using System;
using System.Collections.Generic;
using UniRx;

public class EmployeeData : IReadOnlyData, ICloneable
{
	public int Idx;

	public int Seat;

	public int ViewIdx;

	public EmployeeMoodSystem.Mood OriginMood;

	public EmployeeMoodSystem.Mood NonStrikeMood;

	public IReactiveProperty<int> CriticalExpValue;

	public IReactiveProperty<EmployeeMoodSystem.Mood> MoodStatus;

	public List<EmployeeMoodSystem.MoodBuff> MoodBuffs;

	public void Create()
	{
		if (CriticalExpValue == null) CriticalExpValue = new ReactiveProperty<int>();
		if (MoodStatus == null) MoodStatus = new ReactiveProperty<EmployeeMoodSystem.Mood>();
		if (MoodBuffs == null) MoodBuffs = new List<EmployeeMoodSystem.MoodBuff>();
	}

	public virtual object Clone()
	{
		EmployeeData clone = (EmployeeData)MemberwiseClone();
		clone.Create();
		return clone;
	}

	public string GetNameKey()
	{
		return $"employee_name_{Idx}";
	}

	public string GetIconKey()
	{
		return $"employee_icon_{ViewIdx}";
	}
}
