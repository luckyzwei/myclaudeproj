using System;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class DaySystem
{
	public enum DayStatus
	{
		NotSet = -1,
		Midnight = 0,
		GotoWork = 8,
		InWork = 9,
		InWorkSunset = 16,
		InWorkNight = 20,
		GetOffWorkTime = 23,
		Rest = 24
	}

	[Serializable]
	public class FarsightedObject
	{
		public List<DayStatus> time;

		public GameObject obj;

		public bool On;
	}

	public IReactiveProperty<DayStatus> CurTimeStatus;

	private double timer;

	private double work_one_min;

	private double workoff_one_min;

	private double one_min;

	private int work_one_hour_second;

	private int workoff_one_hour_second;

	public readonly int DayStartTime;

	public Dictionary<int, Action> TimeSubscribe;

	public Dictionary<int, Action> CompanyTimeSubscribe;

	private Dictionary<DayStatus, int> StatusSeconds;

	public DateTime CurDayStartTime { get; private set; }

	public float DayTime { get; private set; }

	public void Init()
	{
	}

	public void CalcCurTime()
	{
	}

	public void CompanySubscribe(int time, Action timeevent)
	{
	}

	public void ResetCompanySubscirbe()
	{
	}

	public void Subscribe(int time, Action timeevent)
	{
	}

	public void SetDayFirstStart()
	{
	}

	public bool isWorkTime()
	{
		return false;
	}

	private void ResetTime()
	{
	}

	public void SkipNight()
	{
	}

	public double CalcNightSkipRealTimeSec()
	{
		return 0.0;
	}

	public void Update()
	{
	}

	public void CalcCheatTime(int cheatTime)
	{
	}
}
