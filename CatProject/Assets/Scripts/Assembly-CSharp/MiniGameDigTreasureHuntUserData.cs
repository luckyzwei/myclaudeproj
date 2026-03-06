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
		if (ProgressRewardClaimed == null || index < 0 || index >= ProgressRewardClaimed.Count) return false;
		if (ProgressRewardClaimed[index]) return false;
		ProgressRewardClaimed[index] = true;
		return true;
	}

	public bool IsProgressRewardClaimed(int index)
	{
		if (ProgressRewardClaimed == null || index < 0 || index >= ProgressRewardClaimed.Count) return false;
		return ProgressRewardClaimed[index];
	}

	public static MiniGameDigTreasureHuntUserData MakeDefaultData(int scheduleIdx, int eventIdx)
	{
		var data = new MiniGameDigTreasureHuntUserData();
		data.ScheduleIdx = scheduleIdx;
		data.EventIdx = eventIdx;
		data.StageIdx = 0;
		data.ProgressRewardClaimed = new List<bool>();
		return data;
	}

	public static MiniGameDigTreasureHuntUserData FromFlatBuffer(DigTreasureHuntData? data)
	{
		if (!data.HasValue) return null;
		var d = data.Value;
		var result = new MiniGameDigTreasureHuntUserData();
		result.ScheduleIdx = d.Scheduleidx;
		result.EventIdx = d.Eventidx;
		result.StageIdx = d.Stageidx;
		if (d.ProgressrewardclaimedLength > 0)
		{
			result.ProgressRewardClaimed = new List<bool>();
			for (int i = 0; i < d.ProgressrewardclaimedLength; i++)
			{
				result.ProgressRewardClaimed.Add(d.Progressrewardclaimed(i));
			}
		}
		return result;
	}

	public static Offset<DigTreasureHuntData> ToFlatBuffer(FlatBufferBuilder builder, MiniGameDigTreasureHuntUserData userData)
	{
		if (userData == null) return default(Offset<DigTreasureHuntData>);
		VectorOffset progressOffset = default(VectorOffset);
		if (userData.ProgressRewardClaimed != null && userData.ProgressRewardClaimed.Count > 0)
		{
			DigTreasureHuntData.StartProgressrewardclaimedVector(builder, userData.ProgressRewardClaimed.Count);
			for (int i = userData.ProgressRewardClaimed.Count - 1; i >= 0; i--)
			{
				builder.AddBool(userData.ProgressRewardClaimed[i]);
			}
			progressOffset = builder.EndVector();
		}
		DigTreasureHuntData.StartDigTreasureHuntData(builder);
		DigTreasureHuntData.AddEventidx(builder, userData.EventIdx);
		DigTreasureHuntData.AddStageidx(builder, userData.StageIdx);
		DigTreasureHuntData.AddScheduleidx(builder, userData.ScheduleIdx);
		if (userData.ProgressRewardClaimed != null && userData.ProgressRewardClaimed.Count > 0)
			DigTreasureHuntData.AddProgressrewardclaimed(builder, progressOffset);
		return DigTreasureHuntData.EndDigTreasureHuntData(builder);
	}
}
