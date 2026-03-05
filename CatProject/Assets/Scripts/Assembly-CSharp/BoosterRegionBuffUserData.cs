using System;
using System.Collections.Generic;
using Google.FlatBuffers;
using Treeplla.Data;
using UniRx;

public class BoosterRegionBuffUserData
{
	public Subject<bool> OnChangeBoosterState;

	public int BoosterIdx { get; set; }

	public int BoosterActiveRegionIdx { get; set; }

	public AbilitySystem.AbilityType BoosterType { get; set; }

	public int BoosterValue { get; set; }

	public IReactiveProperty<int> BoosterRemainTimeSec { get; set; }

	public DateTime BoosterNextResetTime { get; set; }

	public int BoosterDailyUseCount { get; set; }

	public BoosterRegionBuffUserData(int boosterIdx, int boosterActiveRegionIdx)
	{
		BoosterIdx = boosterIdx;
		BoosterActiveRegionIdx = boosterActiveRegionIdx;
		BoosterRemainTimeSec = new ReactiveProperty<int>(0);
		OnChangeBoosterState = new Subject<bool>();
	}

	public static BoosterRegionBuffUserData FromFlatBuffer(BoosterRegionBuffData? data)
	{
		if (!data.HasValue) return null;
		var d = data.Value;
		var result = new BoosterRegionBuffUserData(d.Boosteridx, d.Boosteractiveregionidx);
		result.BoosterDailyUseCount = d.Boosterdailyusecount;
		result.BoosterRemainTimeSec.Value = d.Boosterremaintimesec;
		return result;
	}

	public static VectorOffset ToFlatBufferVector(FlatBufferBuilder builder, List<BoosterRegionBuffUserData> dataList)
	{
		if (dataList == null || dataList.Count == 0)
			return default(VectorOffset);
		var offsets = new Offset<BoosterRegionBuffData>[dataList.Count];
		for (int i = 0; i < dataList.Count; i++)
		{
			offsets[i] = ToFlatBuffer(builder, dataList[i]);
		}
		return builder.CreateVectorOfTables(offsets);
	}

	public static Offset<BoosterRegionBuffData> ToFlatBuffer(FlatBufferBuilder builder, BoosterRegionBuffUserData data)
	{
		if (data == null) return default(Offset<BoosterRegionBuffData>);
		return BoosterRegionBuffData.CreateBoosterRegionBuffData(
			builder,
			data.BoosterIdx,
			data.BoosterActiveRegionIdx,
			data.BoosterRemainTimeSec != null ? data.BoosterRemainTimeSec.Value : 0,
			data.BoosterNextResetTime.Ticks,
			data.BoosterDailyUseCount
		);
	}
}
