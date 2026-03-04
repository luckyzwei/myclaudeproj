using System.Collections.Generic;
using System.Numerics;
using Google.FlatBuffers;
using Treeplla.Data;

public class SubMissionSaveData
{
	public int MissionIdx;

	public List<BigInteger> MissionValueList;

	public List<BigInteger> MissionNeedValueList;

	public List<bool> MissionCompleteList;

	public static VectorOffset ToFlatBufferVector(FlatBufferBuilder builder, Dictionary<int, SubMissionSaveData> missionSaveDataMap)
	{
		return default(VectorOffset);
	}

	public static SubMissionSaveData FromFlatBuffer(SubMissionData data)
	{
		var result = new SubMissionSaveData();
		return result;
	}
}
