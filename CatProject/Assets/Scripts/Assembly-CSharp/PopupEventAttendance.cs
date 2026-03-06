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
		return HUDTopInfo;
	}

	protected override void Awake()
	{
		base.Awake();
	}

	public void Init()
	{
		UpdateEventEndTime();
		UpdateTodayResetTime();
		SetEventSlots();
		Show();
	}

	private void SetEventSlots()
	{
		if (ItemAttendanceList == null) return;
		for (int i = 0; i < ItemAttendanceList.Count; i++)
		{
			if (ItemAttendanceList[i] != null)
				ItemAttendanceList[i].gameObject.SetActive(true);
		}
		if (ItemAttendanceComplete != null)
			ItemAttendanceComplete.gameObject.SetActive(true);
	}

	private void SetEventEndLayout()
	{
		// Show event ended state
	}

	private void UpdateEventEndTime()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		EventEndTime = DateTime.MaxValue;
	}

	private void UpdateTodayResetTime()
	{
		TodayResetTime = DateTime.Today.AddDays(1);
	}

	private void Update()
	{
		if (DateTime.Now >= EventEndTime)
		{
			SetEventEndLayout();
			return;
		}
		if (RemainTimeText != null)
		{
			int remainSec = (int)(EventEndTime - DateTime.Now).TotalSeconds;
			if (remainSec < 0) remainSec = 0;
			RemainTimeText.text = ProjectUtility.GetTimeStringFormattingShort(remainSec);
		}
	}
}
