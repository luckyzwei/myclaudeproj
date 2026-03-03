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
		return null;
	}

	public static VectorOffset ToFlatBufferVector(List<AttendanceData> source, FlatBufferBuilder builder)
	{
		return default(VectorOffset);
	}

	private static Offset<Treeplla.Data.AttendanceData> ToFlatBuffer(AttendanceData source, FlatBufferBuilder builder)
	{
		return default(Offset<Treeplla.Data.AttendanceData>);
	}
}
