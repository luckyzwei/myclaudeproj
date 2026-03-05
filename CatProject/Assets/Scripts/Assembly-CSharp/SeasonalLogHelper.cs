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
		// Log seasonal enter event
	}

	public static void SendAnalytics_SeasonalMilestone()
	{
		// Log milestone view
	}

	public static void SendAnalytics_SeasonalMilestoneClaimReward(int seasonInfoIdx, int claimStepIndex, bool isNowSeason, bool isPremium)
	{
		// Log milestone reward claim
	}

	public static void SendAnalytics_SeasonalMissionRewardClaim(int clearMissionSlotIndex)
	{
		// Log mission reward claim
	}

	public static void SendAnalytics_SeasonalBuildingLevelUp(int buildingIdx, int buildingLevel)
	{
		// Log building level up
	}

	public static void SendAnalytics_SeasonalDistributorSlotLevelUp(int productIdx, int level)
	{
		// Log distributor slot level up
	}

	public static void SendAnalytics_SeasonalSkillLevelUp(int abilityTypeIdx, int level)
	{
		// Log skill level up
	}

	public static void SendAnalytics_SeasonalUseArcadeMachine(int multipleValue, bool bAllMatch, int rewardIdx)
	{
		// Log arcade machine use
	}

	public static void SendAnalytics_SeasonalArcadeMachineLevelUp(int level)
	{
		// Log arcade machine level up
	}

	public static void SendAnalytics_SeasonalQuestClaimReward(int rewardStep)
	{
		// Log quest reward claim
	}

	public static void SendAnalytics_TimeLimit(int packageIdx)
	{
		// Log time limit package event
	}

	public static void SendAnalytics_SeasonalStepRewardReceive(int idx)
	{
		// Log step reward receive
	}

	public static void SendAnalytics_SeasonalCoinRankStart(int type)
	{
		// Log coin rank start
	}

	public static void SendAnalytics_SeasonalCoinRankRewardReceive(int type, int grade, int cnt)
	{
		// Log coin rank reward receive
	}

	public static void SendAnalytics_SeasonalSuperStaffLv(int idx, int lv)
	{
		// Log super staff level up
	}

	public static void SendAnalytics_OfflineReward(int offlineTimeSec)
	{
		// Log offline reward
	}
}
