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
		BoosterRegionBuffDataList = new List<BoosterRegionBuffUserData>();
	}

	public bool IsFree()
	{
		return BoosterFreeCount > 0;
	}

	public static BoosterBuffUserData FromFlatBuffer(BoosterBuffData? data)
	{
		if (!data.HasValue) return null;
		var d = data.Value;
		var result = new BoosterBuffUserData(d.Boosteridx, d.Totalusecount, d.Boosterticketuseactive);
		return result;
	}

	public static Offset<BoosterBuffData> ToFlatBuffer(FlatBufferBuilder builder, BoosterBuffUserData data)
	{
		if (data == null) return default(Offset<BoosterBuffData>);
		var regionBuffOffset = BoosterRegionBuffUserData.ToFlatBufferVector(builder, data.BoosterRegionBuffDataList);
		return BoosterBuffData.CreateBoosterBuffData(builder, data.BoosterIdx, data.BoosterTotalUseCount, regionBuffOffset, data.BoosterTicketUseActive);
	}

	public static VectorOffset ToFlatBufferVector(FlatBufferBuilder builder, List<BoosterBuffUserData> dataList)
	{
		if (dataList == null || dataList.Count == 0)
			return default(VectorOffset);
		var offsets = new Offset<BoosterBuffData>[dataList.Count];
		for (int i = 0; i < dataList.Count; i++)
		{
			offsets[i] = ToFlatBuffer(builder, dataList[i]);
		}
		return builder.CreateVectorOfTables(offsets);
	}
}
