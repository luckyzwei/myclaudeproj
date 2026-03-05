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
		CurTimeStatus = new ReactiveProperty<DayStatus>(DayStatus.NotSet);
		TimeSubscribe = new Dictionary<int, Action>();
		CompanyTimeSubscribe = new Dictionary<int, Action>();
		StatusSeconds = new Dictionary<DayStatus, int>();

		// Initialize time constants
		work_one_min = 1.0;   // 1 real second = 1 game minute during work
		workoff_one_min = 0.5; // faster off-work
		one_min = work_one_min;
		work_one_hour_second = (int)(work_one_min * 60);
		workoff_one_hour_second = (int)(workoff_one_min * 60);

		// Build status time mapping
		StatusSeconds[DayStatus.Midnight] = 0;
		StatusSeconds[DayStatus.GotoWork] = 8;
		StatusSeconds[DayStatus.InWork] = 9;
		StatusSeconds[DayStatus.InWorkSunset] = 16;
		StatusSeconds[DayStatus.InWorkNight] = 20;
		StatusSeconds[DayStatus.GetOffWorkTime] = 23;
		StatusSeconds[DayStatus.Rest] = 24;
	}

	public void CalcCurTime()
	{
		// Calculate current game hour from timer
		int gameHour = (int)(timer / (one_min * 60));
		DayTime = (float)gameHour;

		DayStatus newStatus = DayStatus.Midnight;
		if (gameHour >= (int)DayStatus.Rest)
			newStatus = DayStatus.Rest;
		else if (gameHour >= (int)DayStatus.GetOffWorkTime)
			newStatus = DayStatus.GetOffWorkTime;
		else if (gameHour >= (int)DayStatus.InWorkNight)
			newStatus = DayStatus.InWorkNight;
		else if (gameHour >= (int)DayStatus.InWorkSunset)
			newStatus = DayStatus.InWorkSunset;
		else if (gameHour >= (int)DayStatus.InWork)
			newStatus = DayStatus.InWork;
		else if (gameHour >= (int)DayStatus.GotoWork)
			newStatus = DayStatus.GotoWork;

		if (CurTimeStatus.Value != newStatus)
		{
			CurTimeStatus.Value = newStatus;
		}

		// Trigger time subscriptions
		if (TimeSubscribe != null && TimeSubscribe.TryGetValue(gameHour, out var action))
		{
			action?.Invoke();
		}
		if (CompanyTimeSubscribe != null && CompanyTimeSubscribe.TryGetValue(gameHour, out var companyAction))
		{
			companyAction?.Invoke();
		}
	}

	public void CompanySubscribe(int time, Action timeevent)
	{
		if (CompanyTimeSubscribe == null) CompanyTimeSubscribe = new Dictionary<int, Action>();
		CompanyTimeSubscribe[time] = timeevent;
	}

	public void ResetCompanySubscirbe()
	{
		if (CompanyTimeSubscribe != null) CompanyTimeSubscribe.Clear();
	}

	public void Subscribe(int time, Action timeevent)
	{
		if (TimeSubscribe == null) TimeSubscribe = new Dictionary<int, Action>();
		TimeSubscribe[time] = timeevent;
	}

	public void SetDayFirstStart()
	{
		CurDayStartTime = TimeSystem.GetCurTime();
	}

	public bool isWorkTime()
	{
		var status = CurTimeStatus != null ? CurTimeStatus.Value : DayStatus.NotSet;
		return status == DayStatus.InWork || status == DayStatus.InWorkSunset || status == DayStatus.InWorkNight;
	}

	private void ResetTime()
	{
		timer = 0;
		DayTime = 0f;
		CurTimeStatus.Value = DayStatus.Midnight;
		CurDayStartTime = TimeSystem.GetCurTime();
	}

	public void SkipNight()
	{
		// Skip to next morning (GotoWork time)
		double targetTimerValue = (int)DayStatus.GotoWork * one_min * 60;
		if (timer < targetTimerValue)
		{
			timer = targetTimerValue;
		}
		else
		{
			// Already past morning, skip to next day
			ResetTime();
			timer = (int)DayStatus.GotoWork * one_min * 60;
		}
		CalcCurTime();
	}

	public double CalcNightSkipRealTimeSec()
	{
		// Calculate how many real seconds the night skip covers
		double curGameHour = timer / (one_min * 60);
		double targetGameHour = (int)DayStatus.GotoWork;

		if (curGameHour >= targetGameHour)
		{
			// Skip remaining day + night until next morning
			double remainingHours = ((int)DayStatus.Rest - curGameHour) + targetGameHour;
			return remainingHours * one_min * 60;
		}
		else
		{
			double hoursToSkip = targetGameHour - curGameHour;
			return hoursToSkip * one_min * 60;
		}
	}

	public void Update()
	{
		timer += Time.deltaTime;

		// Check if day cycle complete (24 game hours)
		double dayEnd = (int)DayStatus.Rest * one_min * 60;
		if (timer >= dayEnd)
		{
			ResetTime();
			return;
		}

		// Switch time speed based on work/off-work
		if (isWorkTime())
			one_min = work_one_min;
		else
			one_min = workoff_one_min;

		CalcCurTime();
	}

	public void CalcCheatTime(int cheatTime)
	{
		timer = cheatTime * one_min * 60;
		CalcCurTime();
	}
}
