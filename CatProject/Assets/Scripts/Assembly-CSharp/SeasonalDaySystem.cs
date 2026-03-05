using System;
using System.Collections.Generic;
using SeasonalDef;
using UniRx;

public class SeasonalDaySystem
{
	public static readonly int ONE_DAY_HOUR = 24;

	public static readonly int WORK_START_HOUR = 8;

	public static readonly int WORK_OFF_HOUR = 22;

	public static readonly int WORK_ON_ONE_HOUR_REAL_SECOND = 60;

	public static readonly int WORK_OFF_ONE_HOUR_REAL_SECOND = 15;

	public static readonly int ONE_DAY_REAL_SECOND;

	private static readonly int WORK_OFF_DAWN_TIME_SEC;

	private static readonly int WORK_ON_TIME_SEC;

	private static readonly int WORK_OFF_NIGHT_TIME_SEC;

	public static readonly int MORNING_WORK_START_TIME_SEC;

	public static readonly int LAUNCH_START_TIME_SEC;

	public static readonly int AFTERNOON_WORK_START_TIME_SEC;

	public static readonly int DINNER_START_TIME_SEC;

	public static readonly int NIGHT_WORK_START_TIME_SEC;

	public static readonly int WORK_OFF_START_TIME_SEC;

	private List<(float startTimeSec, E_DayActivityStatus dayStatus)> DayActivityScheduleList;

	private List<DaySystem.DayStatus> DayViewScheduleList;

	private bool bStartGame;

	public double TodayElapsedTimeSec { get; private set; }

	public IReactiveProperty<int> TodayElapsedTimeHour { get; private set; }

	public IReactiveProperty<E_DayActivityStatus> NowActivityStatus { get; private set; }

	public IReactiveProperty<DaySystem.DayStatus> NowDayStatus { get; private set; }

	public float StartActivityTime { get; private set; }

	public float EndActivityTime { get; private set; }

	public bool isActiveOvertimeWork { get; private set; }

	static SeasonalDaySystem()
	{
		int workOnHours = WORK_OFF_HOUR - WORK_START_HOUR;
		int workOffHours = ONE_DAY_HOUR - workOnHours;
		WORK_ON_TIME_SEC = workOnHours * WORK_ON_ONE_HOUR_REAL_SECOND;
		WORK_OFF_DAWN_TIME_SEC = WORK_START_HOUR * WORK_OFF_ONE_HOUR_REAL_SECOND;
		WORK_OFF_NIGHT_TIME_SEC = (ONE_DAY_HOUR - WORK_OFF_HOUR) * WORK_OFF_ONE_HOUR_REAL_SECOND;
		ONE_DAY_REAL_SECOND = WORK_OFF_DAWN_TIME_SEC + WORK_ON_TIME_SEC + WORK_OFF_NIGHT_TIME_SEC;

		MORNING_WORK_START_TIME_SEC = WORK_START_HOUR * WORK_OFF_ONE_HOUR_REAL_SECOND;
		LAUNCH_START_TIME_SEC = MORNING_WORK_START_TIME_SEC + 4 * WORK_ON_ONE_HOUR_REAL_SECOND;
		AFTERNOON_WORK_START_TIME_SEC = LAUNCH_START_TIME_SEC + 1 * WORK_ON_ONE_HOUR_REAL_SECOND;
		DINNER_START_TIME_SEC = AFTERNOON_WORK_START_TIME_SEC + 4 * WORK_ON_ONE_HOUR_REAL_SECOND;
		NIGHT_WORK_START_TIME_SEC = DINNER_START_TIME_SEC + 1 * WORK_ON_ONE_HOUR_REAL_SECOND;
		WORK_OFF_START_TIME_SEC = MORNING_WORK_START_TIME_SEC + workOnHours * WORK_ON_ONE_HOUR_REAL_SECOND;
	}

	public void Init(bool bActiveOvertimeWork)
	{
		isActiveOvertimeWork = bActiveOvertimeWork;
		TodayElapsedTimeSec = 0.0;
		TodayElapsedTimeHour = new ReactiveProperty<int>(0);
		NowActivityStatus = new ReactiveProperty<E_DayActivityStatus>(E_DayActivityStatus.None);
		NowDayStatus = new ReactiveProperty<DaySystem.DayStatus>(DaySystem.DayStatus.NotSet);
		bStartGame = false;

		DayActivityScheduleList = new List<(float, E_DayActivityStatus)>
		{
			(0f, E_DayActivityStatus.WorkOff),
			(MORNING_WORK_START_TIME_SEC, E_DayActivityStatus.Work),
			(LAUNCH_START_TIME_SEC, E_DayActivityStatus.GoToMeal),
			(LAUNCH_START_TIME_SEC + 10f, E_DayActivityStatus.Meal),
			(AFTERNOON_WORK_START_TIME_SEC - 10f, E_DayActivityStatus.EndMeal),
			(AFTERNOON_WORK_START_TIME_SEC, E_DayActivityStatus.Work),
			(DINNER_START_TIME_SEC, E_DayActivityStatus.GoToMeal),
			(DINNER_START_TIME_SEC + 10f, E_DayActivityStatus.Meal),
			(NIGHT_WORK_START_TIME_SEC - 10f, E_DayActivityStatus.EndMeal),
			(NIGHT_WORK_START_TIME_SEC, E_DayActivityStatus.Work),
			(WORK_OFF_START_TIME_SEC, E_DayActivityStatus.WorkOff)
		};

		DayViewScheduleList = new List<DaySystem.DayStatus>
		{
			DaySystem.DayStatus.Midnight,
			DaySystem.DayStatus.GotoWork,
			DaySystem.DayStatus.InWork,
			DaySystem.DayStatus.InWorkSunset,
			DaySystem.DayStatus.InWorkNight,
			DaySystem.DayStatus.GetOffWorkTime,
			DaySystem.DayStatus.Rest
		};

		SetTodayTimeInfo();
	}

	public void OnStartGame()
	{
		bStartGame = true;
		SetTodayTimeInfo();
	}

	public void Reset()
	{
		TodayElapsedTimeSec = 0.0;
		TodayElapsedTimeHour.Value = 0;
		NowActivityStatus.Value = E_DayActivityStatus.None;
		NowDayStatus.Value = DaySystem.DayStatus.NotSet;
		bStartGame = false;
	}

	public void Update()
	{
		if (!bStartGame) return;

		double prevTime = TodayElapsedTimeSec;
		TodayElapsedTimeSec += UnityEngine.Time.deltaTime;

		if (TodayElapsedTimeSec >= ONE_DAY_REAL_SECOND)
		{
			TodayElapsedTimeSec -= ONE_DAY_REAL_SECOND;
		}

		int curHour = (int)CalcTodayElapsedHour();
		if (TodayElapsedTimeHour.Value != curHour)
		{
			TodayElapsedTimeHour.Value = curHour;
			NowDayStatus.Value = FindCurDayViewStatus(curHour);
		}

		var curActivity = FindCurActivityStatus(TodayElapsedTimeSec);
		if (NowActivityStatus.Value != curActivity)
		{
			NowActivityStatus.Value = curActivity;
			UpdateActivityTimeRange(curActivity);
		}
	}

	public void SkipNight()
	{
		if (NowActivityStatus.Value == E_DayActivityStatus.WorkOff)
		{
			TodayElapsedTimeSec = MORNING_WORK_START_TIME_SEC;
			int curHour = (int)CalcTodayElapsedHour();
			TodayElapsedTimeHour.Value = curHour;
			NowDayStatus.Value = FindCurDayViewStatus(curHour);
			NowActivityStatus.Value = FindCurActivityStatus(TodayElapsedTimeSec);
			UpdateActivityTimeRange(NowActivityStatus.Value);
		}
	}

	public void SetActiveOvertimeWork()
	{
		isActiveOvertimeWork = true;
	}

	public string GetNowGameTimeString()
	{
		double hour = CalcTodayElapsedHour();
		int h = (int)hour;
		int m = (int)((hour - h) * 60);
		return $"{h:D2}:{m:D2}";
	}

	public bool IsWorkTime()
	{
		var status = NowActivityStatus.Value;
		return status == E_DayActivityStatus.Work ||
		       status == E_DayActivityStatus.GoToMeal ||
		       status == E_DayActivityStatus.Meal ||
		       status == E_DayActivityStatus.EndMeal;
	}

	public float NowActivityRemainTimeSec()
	{
		float remain = EndActivityTime - (float)TodayElapsedTimeSec;
		return remain > 0f ? remain : 0f;
	}

	public E_DayWorkTimeType GetDayWorkTimeType()
	{
		double hour = CalcTodayElapsedHour();
		if (hour >= WORK_START_HOUR && hour < 13)
			return E_DayWorkTimeType.Work_Morning;
		if (hour >= 13 && hour < WORK_OFF_HOUR)
			return E_DayWorkTimeType.Work_Afternoon;
		return E_DayWorkTimeType.None;
	}

	public void SetTodayTimeInfo()
	{
		int curHour = (int)CalcTodayElapsedHour();
		TodayElapsedTimeHour.Value = curHour;
		NowDayStatus.Value = FindCurDayViewStatus(curHour);
		var curActivity = FindCurActivityStatus(TodayElapsedTimeSec);
		NowActivityStatus.Value = curActivity;
		UpdateActivityTimeRange(curActivity);
	}

	public double CalcTodayElapsedTimeSec(DateTime nowDateTime)
	{
		return TodayElapsedTimeSec;
	}

	public E_DayActivityStatus FindCurActivityStatus(double todayElapsedTimeSec)
	{
		if (DayActivityScheduleList == null || DayActivityScheduleList.Count == 0)
			return E_DayActivityStatus.None;

		E_DayActivityStatus result = DayActivityScheduleList[0].dayStatus;
		for (int i = 0; i < DayActivityScheduleList.Count; i++)
		{
			if (todayElapsedTimeSec >= DayActivityScheduleList[i].startTimeSec)
				result = DayActivityScheduleList[i].dayStatus;
			else
				break;
		}
		return result;
	}

	private DaySystem.DayStatus FindCurDayViewStatus(int todayElapsedTimeHour)
	{
		if (todayElapsedTimeHour >= 24) return DaySystem.DayStatus.Rest;
		if (todayElapsedTimeHour >= 23) return DaySystem.DayStatus.GetOffWorkTime;
		if (todayElapsedTimeHour >= 20) return DaySystem.DayStatus.InWorkNight;
		if (todayElapsedTimeHour >= 16) return DaySystem.DayStatus.InWorkSunset;
		if (todayElapsedTimeHour >= 9) return DaySystem.DayStatus.InWork;
		if (todayElapsedTimeHour >= 8) return DaySystem.DayStatus.GotoWork;
		return DaySystem.DayStatus.Midnight;
	}

	public double CalcTodayElapsedHour()
	{
		double timeSec = TodayElapsedTimeSec;
		if (timeSec < MORNING_WORK_START_TIME_SEC)
		{
			return timeSec / WORK_OFF_ONE_HOUR_REAL_SECOND;
		}
		double workTimeSec = timeSec - MORNING_WORK_START_TIME_SEC;
		if (workTimeSec < WORK_ON_TIME_SEC)
		{
			return WORK_START_HOUR + workTimeSec / WORK_ON_ONE_HOUR_REAL_SECOND;
		}
		double nightTimeSec = timeSec - MORNING_WORK_START_TIME_SEC - WORK_ON_TIME_SEC;
		return WORK_OFF_HOUR + nightTimeSec / WORK_OFF_ONE_HOUR_REAL_SECOND;
	}

	private void UpdateActivityTimeRange(E_DayActivityStatus status)
	{
		if (DayActivityScheduleList == null) return;
		for (int i = 0; i < DayActivityScheduleList.Count; i++)
		{
			if (DayActivityScheduleList[i].dayStatus == status)
			{
				StartActivityTime = DayActivityScheduleList[i].startTimeSec;
				EndActivityTime = (i + 1 < DayActivityScheduleList.Count)
					? DayActivityScheduleList[i + 1].startTimeSec
					: ONE_DAY_REAL_SECOND;
				return;
			}
		}
	}
}
