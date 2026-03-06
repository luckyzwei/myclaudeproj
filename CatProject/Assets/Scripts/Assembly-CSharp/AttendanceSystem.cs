using System;
using System.Collections.Generic;
using UniRx;

public class AttendanceSystem
{
	private Dictionary<E_AttendanceEventType, AttendanceEvent> AttendanceEventMap;

	private Dictionary<E_AttendanceEventType, List<AttendanceData>> AttendanceDataMap;

	private Dictionary<E_AttendanceEventType, AttendanceData> CompleteRewardMap;

	private Dictionary<E_AttendanceEventType, bool> ShownPopupMap;

	public Subject<AttendanceData> OnAttended;

	private bool bOpenPopup;

	public void Reset()
	{
		if (AttendanceEventMap != null)
			AttendanceEventMap.Clear();
		if (AttendanceDataMap != null)
			AttendanceDataMap.Clear();
		if (CompleteRewardMap != null)
			CompleteRewardMap.Clear();
		if (ShownPopupMap != null)
			ShownPopupMap.Clear();
		bOpenPopup = false;
	}

	public void UpdateOneSeconds()
	{
		if (AttendanceEventMap == null) return;
		DateTime now = DateTime.UtcNow;
		foreach (var kvp in AttendanceEventMap)
		{
			var evt = kvp.Value;
			if (evt == null) continue;
			if (now >= evt.AttendanceEndTime)
			{
				// Event expired
				continue;
			}
		}
	}

	public bool IsExistEvent(E_AttendanceEventType eventType)
	{
		if (AttendanceEventMap == null) return false;
		return AttendanceEventMap.ContainsKey(eventType);
	}

	public void AddEvent(E_AttendanceEventType eventType)
	{
		if (AttendanceEventMap == null)
			AttendanceEventMap = new Dictionary<E_AttendanceEventType, AttendanceEvent>();
		if (AttendanceDataMap == null)
			AttendanceDataMap = new Dictionary<E_AttendanceEventType, List<AttendanceData>>();
		if (CompleteRewardMap == null)
			CompleteRewardMap = new Dictionary<E_AttendanceEventType, AttendanceData>();
		if (ShownPopupMap == null)
			ShownPopupMap = new Dictionary<E_AttendanceEventType, bool>();
		if (OnAttended == null)
			OnAttended = new Subject<AttendanceData>();

		if (AttendanceEventMap.ContainsKey(eventType)) return;

		var attendanceEvent = new AttendanceEvent();
		attendanceEvent.AttendanceEventType = eventType;
		AttendanceEventMap[eventType] = attendanceEvent;
		AttendanceDataMap[eventType] = new List<AttendanceData>();
		ShownPopupMap[eventType] = false;

		if (eventType == E_AttendanceEventType.Anniversary)
			InitSystem_SpecialDayAnniversaryAttendance(attendanceEvent);
	}

	private void InitSystem_SpecialDayAnniversaryAttendance(AttendanceEvent attendanceEvent)
	{
		if (attendanceEvent == null) return;
	}

	public void SetShownAttendancePopup(E_AttendanceEventType eventType)
	{
		if (!IsExistEvent(eventType)) return;
		ShownPopupMap[eventType] = true;
		bOpenPopup = true;
	}

	public bool IsNeedShowAttendanceFirstPopup(E_AttendanceEventType eventType)
	{
		if (!IsExistEvent(eventType)) return false;
		if (ShownPopupMap != null && ShownPopupMap.TryGetValue(eventType, out bool shown))
			return !shown;
		return true;
	}

	private int GetTodayIndex(E_AttendanceEventType eventType)
	{
		if (!IsExistEvent(eventType)) return -1;
		var evt = AttendanceEventMap[eventType];
		if (evt == null) return -1;
		int dayIdx = (int)(DateTime.UtcNow - evt.AttendanceStartTime).TotalDays;
		return Math.Max(0, dayIdx);
	}

	public RewardItemData ClaimTodayAttendance(E_AttendanceEventType eventType)
	{
		if (!AttendanceDataMap.TryGetValue(eventType, out var dataList)) return null;
		if (dataList == null) return null;

		int todayIdx = GetTodayIndex(eventType);
		if (todayIdx < 0 || todayIdx >= dataList.Count) return null;

		var data = dataList[todayIdx];
		if (data == null) return null;
		if (data.IsAttended != null && data.IsAttended.Value) return null;

		if (data.IsAttended != null)
			data.IsAttended.Value = true;
		OnAttended?.OnNext(data);
		return data.RewardItemData;
	}

	public RewardItemData ClaimPassedAttendance(E_AttendanceEventType eventType, int dayIndex)
	{
		if (!AttendanceDataMap.TryGetValue(eventType, out var dataList)) return null;
		if (dataList == null) return null;
		if (dayIndex < 0 || dayIndex >= dataList.Count) return null;

		var data = dataList[dayIndex];
		if (data == null) return null;
		if (data.IsAttended != null && data.IsAttended.Value) return null;

		if (data.IsAttended != null)
			data.IsAttended.Value = true;
		OnAttended?.OnNext(data);
		return data.RewardItemData;
	}

	public List<AttendanceData> GetAttendanceDataList(E_AttendanceEventType eventType)
	{
		if (AttendanceDataMap == null) return null;
		if (AttendanceDataMap.TryGetValue(eventType, out var dataList))
			return dataList;
		return null;
	}

	public AttendanceData GetAttendanceData(E_AttendanceEventType eventType, int dayIndex)
	{
		var dataList = GetAttendanceDataList(eventType);
		if (dataList == null) return null;
		if (dayIndex < 0 || dayIndex >= dataList.Count) return null;
		return dataList[dayIndex];
	}

	public AttendanceData GetTodayAttendanceData(E_AttendanceEventType eventType)
	{
		int todayIdx = GetTodayIndex(eventType);
		return GetAttendanceData(eventType, todayIdx);
	}

	public AttendanceData GetCompleteAttendanceData(E_AttendanceEventType eventType)
	{
		if (CompleteRewardMap == null) return null;
		if (CompleteRewardMap.TryGetValue(eventType, out var data))
			return data;
		return null;
	}

	public bool IsAttendedDay(E_AttendanceEventType eventType, int dayIndex)
	{
		var data = GetAttendanceData(eventType, dayIndex);
		if (data == null || data.IsAttended == null) return false;
		return data.IsAttended.Value;
	}

	public bool IsReceivableCompleteAttendance(E_AttendanceEventType eventType)
	{
		var dataList = GetAttendanceDataList(eventType);
		if (dataList == null || dataList.Count == 0) return false;

		for (int i = 0; i < dataList.Count; i++)
		{
			if (dataList[i] == null || dataList[i].IsAttended == null || !dataList[i].IsAttended.Value)
				return false;
		}

		var completeData = GetCompleteAttendanceData(eventType);
		if (completeData == null) return false;
		if (completeData.IsAttended != null && completeData.IsAttended.Value) return false;
		return true;
	}

	public DateTime GetAttendanceStartTime(E_AttendanceEventType eventType)
	{
		if (!IsExistEvent(eventType)) return DateTime.MinValue;
		var evt = AttendanceEventMap[eventType];
		return evt != null ? evt.AttendanceStartTime : DateTime.MinValue;
	}

	public DateTime GetAttendanceEndTime(E_AttendanceEventType eventType)
	{
		if (!IsExistEvent(eventType)) return DateTime.MinValue;
		var evt = AttendanceEventMap[eventType];
		return evt != null ? evt.AttendanceEndTime : DateTime.MinValue;
	}
}
