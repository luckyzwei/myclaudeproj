using System.Collections.Generic;
using BizAcqDef;

public static class BizAcqHelper
{
	public static Dictionary<Config.ManagerSkillActivationType, string> SkillActivationTypePrefixMap;

	public static int BOSS_STAGE_IDX_MULTIPLIER { get; private set; }

	public static int WIN_REWARD_MULTIPLE_VALUE { get; private set; }

	public static int WIN_REWARD_MULTIPLE_NEED_CASH { get; private set; }

	public static int WIN_REWARD_MULTIPLE_PLUS_CASH { get; private set; }

	public static int MAX_STAGE_IDX { get; private set; }

	public static int ADDITIONAL_BATTLE_SPEED_VALUE { get; private set; }

	public static int SPEED_TRIAL_START_STAGE { get; private set; }

	public static int SPEED_TRIAL_END_STAGE { get; private set; }

	public static int ADDITIONAL_REWARD_TIME_SEC { get; private set; }

	public static List<SkillStatusEffectType> BuffEffectList { get; private set; }

	public static List<SkillStatusEffectType> DebuffEffectList { get; private set; }

	public static void Init()
	{
	}

	public static bool IsBuffEffect(SkillStatusEffectType statusEffectType)
	{
		return false;
	}

	public static bool IsDebuffEffect(SkillStatusEffectType statusEffectType)
	{
		return false;
	}

	public static string GetSkillDesc(int skillIdx, int skillLevel)
	{
		return null;
	}

	public static string GetSkillValueDesc(int skillidx, int skillvalue)
	{
		return null;
	}

	public static Config.ManagerSkillContentsType GetSkillContentsType(int skillIdx)
	{
		return default(Config.ManagerSkillContentsType);
	}

	public static bool IsPercentAbility(Config.ManagerSkillType skillType)
	{
		return false;
	}

	public static bool IsBossStageIdx(int stageIdx)
	{
		return false;
	}

	public static int GetMultipleRewardNeedCash(int getCount)
	{
		return 0;
	}

	public static bool IsMoneyLimit(int stageIdx)
	{
		return false;
	}

	private static RewardItemData GetStageMoneyReward(int stageIdx)
	{
		return null;
	}
}
