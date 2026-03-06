using System.Text;
using Treeplla;

public static class SeasonalLogHelper
{
	private static int MILESTONE_PROGRESS_START_INDEX;

	private static TpAnalyticsProp GetAnalytics()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.PluginSystem == null) return null;
		return root.PluginSystem.AnalyticsProp;
	}

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
		GetAnalytics()?.AllEvent(IngameEventType.None, "seasonal_enter", GetParameter_Stage(), GetParameter_Staff(), GetParameter_Grade(), GetParameter_Buff());
	}

	public static void SendAnalytics_SeasonalMilestone()
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "seasonal_milestone", GetParameter_Stage(), GetParameter_Grade());
	}

	public static void SendAnalytics_SeasonalMilestoneClaimReward(int seasonInfoIdx, int claimStepIndex, bool isNowSeason, bool isPremium)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "seasonal_milestone_claim", seasonInfoIdx, claimStepIndex, isNowSeason ? 1 : 0, isPremium ? 1 : 0);
	}

	public static void SendAnalytics_SeasonalMissionRewardClaim(int clearMissionSlotIndex)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "seasonal_mission_reward_claim", GetParameter_Stage(), clearMissionSlotIndex);
	}

	public static void SendAnalytics_SeasonalBuildingLevelUp(int buildingIdx, int buildingLevel)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "seasonal_building_level_up", GetParameter_Stage(), buildingIdx, buildingLevel);
	}

	public static void SendAnalytics_SeasonalDistributorSlotLevelUp(int productIdx, int level)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "seasonal_distributor_slot_level_up", GetParameter_Stage(), productIdx, level);
	}

	public static void SendAnalytics_SeasonalSkillLevelUp(int abilityTypeIdx, int level)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "seasonal_skill_level_up", GetParameter_Stage(), abilityTypeIdx, level);
	}

	public static void SendAnalytics_SeasonalUseArcadeMachine(int multipleValue, bool bAllMatch, int rewardIdx)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "seasonal_use_arcade_machine", GetParameter_Stage(), multipleValue, bAllMatch ? 1 : 0, rewardIdx);
	}

	public static void SendAnalytics_SeasonalArcadeMachineLevelUp(int level)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "seasonal_arcade_machine_level_up", GetParameter_Stage(), level);
	}

	public static void SendAnalytics_SeasonalQuestClaimReward(int rewardStep)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "seasonal_quest_claim_reward", GetParameter_Stage(), rewardStep);
	}

	public static void SendAnalytics_TimeLimit(int packageIdx)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "seasonal_time_limit", GetParameter_Stage(), packageIdx);
	}

	public static void SendAnalytics_SeasonalStepRewardReceive(int idx)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "seasonal_step_reward_receive", GetParameter_Stage(), idx);
	}

	public static void SendAnalytics_SeasonalCoinRankStart(int type)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "seasonal_coin_rank_start", GetParameter_Stage(), type);
	}

	public static void SendAnalytics_SeasonalCoinRankRewardReceive(int type, int grade, int cnt)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "seasonal_coin_rank_reward_receive", GetParameter_Stage(), type, grade, cnt);
	}

	public static void SendAnalytics_SeasonalSuperStaffLv(int idx, int lv)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "seasonal_super_staff_lv", GetParameter_Stage(), idx, lv);
	}

	public static void SendAnalytics_OfflineReward(int offlineTimeSec)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "seasonal_offline_reward", GetParameter_Stage(), offlineTimeSec);
	}
}
