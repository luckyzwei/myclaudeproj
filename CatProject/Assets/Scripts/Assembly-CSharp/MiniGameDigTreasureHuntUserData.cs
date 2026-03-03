using System.Collections.Generic;
using Google.FlatBuffers;
using Treeplla.Data;

public class MiniGameDigTreasureHuntUserData
{
	public int ScheduleIdx { get; set; }

	public int EventIdx { get; set; }

	public int StageIdx { get; set; }

	public MiniGameDigTreasureHuntCellData[,] Grid { get; set; }

	public List<bool> ProgressRewardClaimed { get; set; }

	public bool ClaimProgressReward(int index)
	{
		return false;
	}

	public bool IsProgressRewardClaimed(int index)
	{
		return false;
	}

	public static MiniGameDigTreasureHuntUserData MakeDefaultData(int scheduleIdx, int eventIdx)
	{
		return null;
	}

	public static MiniGameDigTreasureHuntUserData FromFlatBuffer(DigTreasureHuntData? data)
	{
		return null;
	}

	public static Offset<DigTreasureHuntData> ToFlatBuffer(FlatBufferBuilder builder, MiniGameDigTreasureHuntUserData userData)
	{
		return default(Offset<DigTreasureHuntData>);
	}
}
