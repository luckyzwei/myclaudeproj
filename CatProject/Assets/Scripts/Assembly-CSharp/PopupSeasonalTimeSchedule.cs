using System.Collections.Generic;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Seasonal/PopupSeasonalTime", false, false)]
public class PopupSeasonalTimeSchedule : UIBase
{
	[SerializeField]
	private Text DayTimeText;

	[SerializeField]
	private GameObject HandsOfClockObj;

	[SerializeField]
	private GameObject DayIconObj;

	[SerializeField]
	private GameObject NightIconObj;

	[SerializeField]
	private List<GameObject> DayActivityObjList;

	private int NowTimeHour;

	private bool NowDayTime;

	private bool bInitPopup;

	private List<float> DayScheduleList;

	public void Init()
	{
	}

	private void Update()
	{
	}

	private void UpdateDayActivityObjList(double gameTimeSec)
	{
	}

	private void UpdateDayIcon(bool isDayTime)
	{
	}

	private bool IsDayTime()
	{
		return false;
	}

	private int FindDayScheduleIndex(double gameTimeSec)
	{
		return 0;
	}
}
