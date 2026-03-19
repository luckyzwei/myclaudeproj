using System;
using System.Collections.Generic;
using Google.FlatBuffers;
using Treeplla.Data;
using UniRx;

public class AttendanceData
{
	public int EventType;

	public int DayIndex;

	public IReactiveProperty<bool> IsAttended;

	public DateTime AttendanceStartTime;

	public DateTime AttendanceEndTime;

	public RewardItemData RewardItemData;

	public E_AttendanceRewardType AttendanceType;

	public static AttendanceData FromFlatBuffer(Treeplla.Data.AttendanceData data)
	{
		var result = new AttendanceData();
		result.EventType = data.Eventtype;
		result.DayIndex = data.Dayindx;
		result.IsAttended = new ReactiveProperty<bool>(data.Isattended);
		return result;
	}

	public static VectorOffset ToFlatBufferVector(List<AttendanceData> source, FlatBufferBuilder builder)
	{
		if (source == null || source.Count == 0)
			return default(VectorOffset);
		var offsets = new Offset<Treeplla.Data.AttendanceData>[source.Count];
		for (int i = 0; i < source.Count; i++)
		{
			offsets[i] = ToFlatBuffer(source[i], builder);
		}
		return builder.CreateVectorOfTables(offsets);
	}

	private static Offset<Treeplla.Data.AttendanceData> ToFlatBuffer(AttendanceData source, FlatBufferBuilder builder)
	{
		if (source == null) return default(Offset<Treeplla.Data.AttendanceData>);
		return Treeplla.Data.AttendanceData.CreateAttendanceData(
			builder,
			source.EventType,
			source.DayIndex,
			source.IsAttended != null && source.IsAttended.Value
		);
	}
}
