using System;
using System.Collections.Generic;
using Google.FlatBuffers;
using Treeplla.Data;

public class AttendanceEventData
{
	public int EventIdx;

	public E_AttendanceEventType EventType;

	public List<AttendanceData> AttendanceDataList;

	public DateTime LastPopupShownTime;

	public static AttendanceEventData FromFlatBuffer(Treeplla.Data.AttendanceEventData data)
	{
		return null;
	}

	public static VectorOffset ToFlatBufferVector(List<AttendanceEventData> source, FlatBufferBuilder builder)
	{
		return default(VectorOffset);
	}
}
