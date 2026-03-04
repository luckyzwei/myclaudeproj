using System.Collections.Generic;
using Google.FlatBuffers;
using Treeplla.Data;

public class BoosterBuffUserData
{
	public int BoosterIdx;

	public int BoosterTotalUseCount;

	public bool BoosterTicketUseActive;

	public int BoosterFreeCount { get; private set; }

	public int BoosterUseItemIdx { get; private set; }

	public List<BoosterRegionBuffUserData> BoosterRegionBuffDataList { get; set; }

	public BoosterBuffUserData(int boosterIdx, int totalUseCount, bool boosterTicketUseActive)
	{
		BoosterIdx = boosterIdx;
		BoosterTotalUseCount = totalUseCount;
		BoosterTicketUseActive = boosterTicketUseActive;
	}

	public bool IsFree()
	{
		return false;
	}

	public static BoosterBuffUserData FromFlatBuffer(BoosterBuffData? data)
	{
		if (!data.HasValue) return null;
		var d = data.Value;
		var result = (BoosterBuffUserData)new BoosterBuffUserData(0, 0, false).MemberwiseClone();
		return result;
	}

	public static Offset<BoosterBuffData> ToFlatBuffer(FlatBufferBuilder builder, BoosterBuffUserData data)
	{
		return default(Offset<BoosterBuffData>);
	}

	public static VectorOffset ToFlatBufferVector(FlatBufferBuilder builder, List<BoosterBuffUserData> dataList)
	{
		return default(VectorOffset);
	}
}
