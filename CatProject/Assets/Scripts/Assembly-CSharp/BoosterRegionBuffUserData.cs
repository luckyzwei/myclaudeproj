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
	}

	public static BoosterRegionBuffUserData FromFlatBuffer(BoosterRegionBuffData? data)
	{
		return null;
	}

	public static VectorOffset ToFlatBufferVector(FlatBufferBuilder builder, List<BoosterRegionBuffUserData> dataList)
	{
		return default(VectorOffset);
	}

	public static Offset<BoosterRegionBuffData> ToFlatBuffer(FlatBufferBuilder builder, BoosterRegionBuffUserData data)
	{
		return default(Offset<BoosterRegionBuffData>);
	}
}
