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
		DayScheduleList = new List<float>();
		bInitPopup = true;
	}

	private void Update()
	{
		if (!bInitPopup) return;
	}

	private void UpdateDayActivityObjList(double gameTimeSec)
	{
		if (DayActivityObjList == null) return;
		int scheduleIdx = FindDayScheduleIndex(gameTimeSec);
		for (int i = 0; i < DayActivityObjList.Count; i++)
		{
			if (DayActivityObjList[i] != null)
				DayActivityObjList[i].SetActive(i == scheduleIdx);
		}
	}

	private void UpdateDayIcon(bool isDayTime)
	{
		if (DayIconObj != null) DayIconObj.SetActive(isDayTime);
		if (NightIconObj != null) NightIconObj.SetActive(!isDayTime);
		NowDayTime = isDayTime;
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
