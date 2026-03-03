using System;
using System.Collections.Generic;
using SeasonalDef;
using UniRx;

public class SeasonalDaySystem
{
	public static readonly int ONE_DAY_HOUR;

	public static readonly int WORK_START_HOUR;

	public static readonly int WORK_OFF_HOUR;

	public static readonly int WORK_ON_ONE_HOUR_REAL_SECOND;

	public static readonly int WORK_OFF_ONE_HOUR_REAL_SECOND;

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

	public void Init(bool bActiveOvertimeWork)
	{
	}

	public void OnStartGame()
	{
	}

	public void Reset()
	{
	}

	public void Update()
	{
	}

	public void SkipNight()
	{
	}

	public void SetActiveOvertimeWork()
	{
	}

	public string GetNowGameTimeString()
	{
		return null;
	}

	public bool IsWorkTime()
	{
		return false;
	}

	public float NowActivityRemainTimeSec()
	{
		return 0f;
	}

	public E_DayWorkTimeType GetDayWorkTimeType()
	{
		return default(E_DayWorkTimeType);
	}

	public void SetTodayTimeInfo()
	{
	}

	public double CalcTodayElapsedTimeSec(DateTime nowDateTime)
	{
		return 0.0;
	}

	public E_DayActivityStatus FindCurActivityStatus(double todayElapsedTimeSec)
	{
		return default(E_DayActivityStatus);
	}

	private DaySystem.DayStatus FindCurDayViewStatus(int todayElapsedTimeHour)
	{
		return default(DaySystem.DayStatus);
	}

	public double CalcTodayElapsedHour()
	{
		return 0.0;
	}
}
