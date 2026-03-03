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
	}

	public virtual object Clone()
	{
		return null;
	}

	public string GetNameKey()
	{
		return null;
	}

	public string GetIconKey()
	{
		return null;
	}
}
