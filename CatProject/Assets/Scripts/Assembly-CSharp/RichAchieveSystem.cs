using System.Collections.Generic;
using Treeplla;

public class RichAchieveSystem
{
	private WorldMissionList tableMissionData;

	private WorldMissionReward tableRewardData;

	public const float TIME_ARROW_NOTI = 3f;

	public Dictionary<int, RichAchieveRegionData> dic_RichAchieveRigion;

	private Dictionary<int, int> dic_RichAchieveCount;

	public void Init()
	{
		dic_RichAchieveRigion = new Dictionary<int, RichAchieveRegionData>();
		dic_RichAchieveCount = new Dictionary<int, int>();
		InitRichAchieveCount();
	}

	public void InitRichAchieveCount()
	{
		if (dic_RichAchieveCount != null)
			dic_RichAchieveCount.Clear();
	}

	public int GetRichAchieveCount(E_RichAchieveMissionActiveRegion region)
	{
		if (dic_RichAchieveCount != null && dic_RichAchieveCount.TryGetValue((int)region, out int count))
			return count;
		return 0;
	}

	public void AddRichAchieveCount(E_RichAchieveMissionActiveRegion region)
	{
		if (dic_RichAchieveCount == null) return;
		int key = (int)region;
		if (dic_RichAchieveCount.ContainsKey(key))
			dic_RichAchieveCount[key]++;
		else
			dic_RichAchieveCount[key] = 1;
	}

	public void SetMissionIdx()
	{
	}

	public int GetFocusMissionIdx(int regionIdx)
	{
		return 0;
	}

	public int GetMissionMaxCount(int regionIdx)
	{
		return 0;
	}

	public bool IsCheckClear(int missionIdx)
	{
		return false;
	}

	public int GetMissionClearValue(int missionIdx)
	{
		return 0;
	}

	public bool CheckRichAchieveGuideInit()
	{
		return false;
	}

	public bool IsRichAchieveBtnActive(int activeRegionIdx)
	{
		return false;
	}

	public bool IsRegionCheck(int regionIdx)
	{
		return false;
	}

	public void SubscribeContentOpen()
	{
	}

	public bool IsGetAchieveReward(int activeRegionIdx)
	{
		return false;
	}
}
