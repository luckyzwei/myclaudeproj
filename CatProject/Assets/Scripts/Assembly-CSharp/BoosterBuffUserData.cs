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
	}

	public bool IsFree()
	{
		return false;
	}

	public static BoosterBuffUserData FromFlatBuffer(BoosterBuffData? data)
	{
		return null;
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
