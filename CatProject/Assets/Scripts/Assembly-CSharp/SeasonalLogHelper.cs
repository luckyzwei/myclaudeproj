using System.Text;
using Treeplla;

public static class SeasonalLogHelper
{
	private static int MILESTONE_PROGRESS_START_INDEX;

	public static int GetParameter_Stage()
	{
		var stageData = SeasonalHelper.SeasonalStageData;
		if (stageData == null) return 0;
		return stageData.SeasonInfoIdx;
	}

	public static string GetParameter_Staff()
	{
		var stageData = SeasonalHelper.SeasonalStageData;
		if (stageData == null) return string.Empty;
		var sb = new StringBuilder();
		if (stageData.ActiveWorkerCount != null)
			sb.Append(stageData.ActiveWorkerCount.Value);
		sb.Append("/");
		sb.Append(stageData.MaxWorkerCount);
		return sb.ToString();
	}

	public static int GetParameter_Grade()
	{
		var stageData = SeasonalHelper.SeasonalStageData;
		if (stageData?.MilestoneData == null) return 0;
		if (stageData.MilestoneData.CurRewardListIndex != null)
			return stageData.MilestoneData.CurRewardListIndex.Value;
		return 0;
	}

	public static int GetParameter_Buff()
	{
		var seasonalSystem = SeasonalHelper.SeasonalSystem;
		if (seasonalSystem == null) return 0;
		int buff = 0;
		if (seasonalSystem.SlotCoinBuff != null && seasonalSystem.SlotCoinBuff.Value)
			buff |= 1;
		if (seasonalSystem.MissionCoinBuff != null && seasonalSystem.MissionCoinBuff.Value)
			buff |= 2;
		return buff;
	}

	public static string GetParameter_WorkshopManagerLvList()
	{
		var buildingDataMap = SeasonalHelper.SeasonalBuildingData;
		if (buildingDataMap == null) return string.Empty;
		var sb = new StringBuilder();
		foreach (var kvp in buildingDataMap)
		{
			var workshop = kvp.Value as SeasonalWorkshopData;
			if (workshop?.ManagerData == null) continue;
			if (sb.Length > 0) sb.Append(",");
			int lv = workshop.ManagerData.Level != null ? workshop.ManagerData.Level.Value : 0;
			sb.Append(kvp.Key).Append(":").Append(lv);
		}
		return sb.ToString();
	}

	public static void SendAnalytics_SeasonalEnter()
	{
	}

	public static void SendAnalytics_SeasonalMilestone()
	{
	}

	public static void SendAnalytics_SeasonalMilestoneClaimReward(int seasonInfoIdx, int claimStepIndex, bool isNowSeason, bool isPremium)
	{
	}

	public static void SendAnalytics_SeasonalMissionRewardClaim(int clearMissionSlotIndex)
	{
	}

	public static void SendAnalytics_SeasonalBuildingLevelUp(int buildingIdx, int buildingLevel)
	{
	}

	public static void SendAnalytics_SeasonalDistributorSlotLevelUp(int productIdx, int level)
	{
	}

	public static void SendAnalytics_SeasonalSkillLevelUp(int abilityTypeIdx, int level)
	{
	}

	public static void SendAnalytics_SeasonalUseArcadeMachine(int multipleValue, bool bAllMatch, int rewardIdx)
	{
	}

	public static void SendAnalytics_SeasonalArcadeMachineLevelUp(int level)
	{
	}

	public static void SendAnalytics_SeasonalQuestClaimReward(int rewardStep)
	{
	}

	public static void SendAnalytics_TimeLimit(int packageIdx)
	{
	}

	public static void SendAnalytics_SeasonalStepRewardReceive(int idx)
	{
	}

	public static void SendAnalytics_SeasonalCoinRankStart(int type)
	{
	}

	public static void SendAnalytics_SeasonalCoinRankRewardReceive(int type, int grade, int cnt)
	{
	}

	public static void SendAnalytics_SeasonalSuperStaffLv(int idx, int lv)
	{
	}

	public static void SendAnalytics_OfflineReward(int offlineTimeSec)
	{
	}
}
