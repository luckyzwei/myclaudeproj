using System.Numerics;
using Google.FlatBuffers;
using Treeplla.Data;

public class SingleMissionUserData
{
	public int SlotIdx;

	public int MissionIdx;

	public BigInteger CurrentValue;

	public bool IsCompleted;

	public bool IsRewarded;

	public SingleMissionUserData()
	{
	}

	public SingleMissionUserData(SingleMissionBase mission)
	{
		MissionIdx = mission != null ? mission.MissionIdx : 0;
	}

	public void CopyFrom(SingleMissionBase source)
	{
		// TODO
	}

	public static SingleMissionUserData FromFlatBuffer(SingleMissionData data)
	{
		var result = new SingleMissionUserData();
		return result;
	}

	public static Offset<SingleMissionData> ToFlatBuffer(SingleMissionUserData source, FlatBufferBuilder builder)
	{
		return default(Offset<SingleMissionData>);
	}
}
