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
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	public int GetFocusMissionIdx(int regionIdx)
	{
		if (dic_RichAchieveRigion == null || !dic_RichAchieveRigion.TryGetValue(regionIdx, out var regionData))
			return 0;
		return regionData.startIdx;
	}

	public int GetMissionMaxCount(int regionIdx)
	{
		if (dic_RichAchieveRigion == null || !dic_RichAchieveRigion.TryGetValue(regionIdx, out var regionData))
			return 0;
		return regionData.endIdx - regionData.startIdx + 1;
	}

	public bool IsCheckClear(int missionIdx)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return false;
		return false;
	}

	public int GetMissionClearValue(int missionIdx)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return 0;
		return 0;
	}

	public bool CheckRichAchieveGuideInit()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return false;
		return false;
	}

	public bool IsRichAchieveBtnActive(int activeRegionIdx)
	{
		if (dic_RichAchieveRigion == null) return false;
		return dic_RichAchieveRigion.ContainsKey(activeRegionIdx);
	}

	public bool IsRegionCheck(int regionIdx)
	{
		if (dic_RichAchieveRigion == null) return false;
		return dic_RichAchieveRigion.ContainsKey(regionIdx);
	}

	public void SubscribeContentOpen()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null) return;
	}

	public bool IsGetAchieveReward(int activeRegionIdx)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return false;
		return false;
	}
}
