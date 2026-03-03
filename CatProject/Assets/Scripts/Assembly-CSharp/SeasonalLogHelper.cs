public static class SeasonalLogHelper
{
	private static int MILESTONE_PROGRESS_START_INDEX;

	public static int GetParameter_Stage()
	{
		return 0;
	}

	public static string GetParameter_Staff()
	{
		return null;
	}

	public static int GetParameter_Grade()
	{
		return 0;
	}

	public static int GetParameter_Buff()
	{
		return 0;
	}

	public static string GetParameter_WorkshopManagerLvList()
	{
		return null;
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
