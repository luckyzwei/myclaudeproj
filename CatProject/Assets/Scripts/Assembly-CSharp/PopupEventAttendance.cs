using System;
using System.Collections.Generic;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupEventAttendance", false, false)]
public class PopupEventAttendance : UIBase
{
	[SerializeField]
	private HUDTopInfo HUDTopInfo;

	[SerializeField]
	private Text RemainTimeText;

	[SerializeField]
	private List<ItemAttendance> ItemAttendanceList;

	[SerializeField]
	private ItemAttendanceComplete ItemAttendanceComplete;

	private DateTime EventEndTime;

	private DateTime TodayResetTime;

	private CurrencyHUDComponent AnniversaryTicketHUDComponent;

	public HUDTopInfo GetHUDTopInfo()
	{
		return null;
	}

	protected override void Awake()
	{
	}

	public void Init()
	{
	}

	private void SetEventSlots()
	{
	}

	private void SetEventEndLayout()
	{
	}

	private void UpdateEventEndTime()
	{
	}

	private void UpdateTodayResetTime()
	{
	}

	private void Update()
	{
	}
}
