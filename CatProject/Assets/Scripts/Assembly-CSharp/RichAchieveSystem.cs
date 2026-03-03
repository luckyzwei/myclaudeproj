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
	}

	public void InitRichAchieveCount()
	{
	}

	public int GetRichAchieveCount(E_RichAchieveMissionActiveRegion region)
	{
		return 0;
	}

	public void AddRichAchieveCount(E_RichAchieveMissionActiveRegion region)
	{
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
