using System;
using System.Collections.Generic;
using UniRx;

public class AttendanceSystem
{
	private Dictionary<E_AttendanceEventType, AttendanceEvent> AttendanceEventMap;

	public Subject<AttendanceData> OnAttended;

	private bool bOpenPopup;

	public void Reset()
	{
	}

	public void UpdateOneSeconds()
	{
	}

	public bool IsExistEvent(E_AttendanceEventType eventType)
	{
		return false;
	}

	public void AddEvent(E_AttendanceEventType eventType)
	{
	}

	private void InitSystem_SpecialDayAnniversaryAttendance(AttendanceEvent attendanceEvent)
	{
	}

	public void SetShownAttendancePopup(E_AttendanceEventType eventType)
	{
	}

	public bool IsNeedShowAttendanceFirstPopup(E_AttendanceEventType eventType)
	{
		return false;
	}

	public RewardItemData ClaimTodayAttendance(E_AttendanceEventType eventType)
	{
		return null;
	}

	public RewardItemData ClaimPassedAttendance(E_AttendanceEventType eventType, int dayIndex)
	{
		return null;
	}

	public List<AttendanceData> GetAttendanceDataList(E_AttendanceEventType eventType)
	{
		return null;
	}

	public AttendanceData GetAttendanceData(E_AttendanceEventType eventType, int dayIndex)
	{
		return null;
	}

	public AttendanceData GetTodayAttendanceData(E_AttendanceEventType eventType)
	{
		return null;
	}

	public AttendanceData GetCompleteAttendanceData(E_AttendanceEventType eventType)
	{
		return null;
	}

	public bool IsAttendedDay(E_AttendanceEventType eventType, int dayIndex)
	{
		return false;
	}

	public bool IsReceivableCompleteAttendance(E_AttendanceEventType eventType)
	{
		return false;
	}

	public DateTime GetAttendanceStartTime(E_AttendanceEventType eventType)
	{
		return default(DateTime);
	}

	public DateTime GetAttendanceEndTime(E_AttendanceEventType eventType)
	{
		return default(DateTime);
	}
}
