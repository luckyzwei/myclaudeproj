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
		var result = new AttendanceEventData();
		result.EventIdx = data.Eventidx;
		result.EventType = (E_AttendanceEventType)data.Eventtype;
		result.LastPopupShownTime = data.Lastshowntime != 0
			? DateTimeOffset.FromUnixTimeSeconds(data.Lastshowntime).UtcDateTime
			: DateTime.MinValue;
		result.AttendanceDataList = new List<AttendanceData>();
		for (int i = 0; i < data.AttendancedataLength; i++)
		{
			var fbAttendanceData = data.Attendancedata(i);
			if (fbAttendanceData.HasValue)
			{
				var attendanceData = AttendanceData.FromFlatBuffer(fbAttendanceData.Value);
				if (attendanceData != null)
					result.AttendanceDataList.Add(attendanceData);
			}
		}
		return result;
	}

	public static VectorOffset ToFlatBufferVector(List<AttendanceEventData> source, FlatBufferBuilder builder)
	{
		if (source == null || source.Count == 0)
			return default(VectorOffset);
		var offsets = new Offset<Treeplla.Data.AttendanceEventData>[source.Count];
		for (int i = 0; i < source.Count; i++)
		{
			offsets[i] = ToFlatBuffer(source[i], builder);
		}
		return builder.CreateVectorOfTables(offsets);
	}

	private static Offset<Treeplla.Data.AttendanceEventData> ToFlatBuffer(AttendanceEventData source, FlatBufferBuilder builder)
	{
		if (source == null) return default(Offset<Treeplla.Data.AttendanceEventData>);
		var attendanceDataOffset = AttendanceData.ToFlatBufferVector(source.AttendanceDataList, builder);
		long lastShownTimestamp = source.LastPopupShownTime != DateTime.MinValue
			? new DateTimeOffset(source.LastPopupShownTime).ToUnixTimeSeconds()
			: 0;
		return Treeplla.Data.AttendanceEventData.CreateAttendanceEventData(
			builder,
			source.EventIdx,
			(int)source.EventType,
			attendanceDataOffset,
			lastShownTimestamp
		);
	}
}
