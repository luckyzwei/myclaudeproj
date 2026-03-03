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
	}

	public void CopyFrom(SingleMissionBase source)
	{
	}

	public static SingleMissionUserData FromFlatBuffer(SingleMissionData data)
	{
		return null;
	}

	public static Offset<SingleMissionData> ToFlatBuffer(SingleMissionUserData source, FlatBufferBuilder builder)
	{
		return default(Offset<SingleMissionData>);
	}
}
