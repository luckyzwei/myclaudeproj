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
		BOSS_STAGE_IDX_MULTIPLIER = 10;
		WIN_REWARD_MULTIPLE_VALUE = 3;
		WIN_REWARD_MULTIPLE_NEED_CASH = 50;
		WIN_REWARD_MULTIPLE_PLUS_CASH = 10;
		MAX_STAGE_IDX = 100;
		ADDITIONAL_BATTLE_SPEED_VALUE = 3;
		SPEED_TRIAL_START_STAGE = 1;
		SPEED_TRIAL_END_STAGE = 5;
		ADDITIONAL_REWARD_TIME_SEC = 3600;

		BuffEffectList = new List<SkillStatusEffectType>
		{
			SkillStatusEffectType.PowerUp,
			SkillStatusEffectType.SkillChanceUp,
			SkillStatusEffectType.RemoveDebuff
		};

		DebuffEffectList = new List<SkillStatusEffectType>
		{
			SkillStatusEffectType.PowerDown,
			SkillStatusEffectType.Evade,
			SkillStatusEffectType.RemoveBuff
		};

		SkillActivationTypePrefixMap = new Dictionary<Config.ManagerSkillActivationType, string>
		{
			{ Config.ManagerSkillActivationType.Passive, "passive_" },
			{ Config.ManagerSkillActivationType.OnAttack, "onattack_" }
		};
	}

	public static bool IsBuffEffect(SkillStatusEffectType statusEffectType)
	{
		if (BuffEffectList == null) return false;
		return BuffEffectList.Contains(statusEffectType);
	}

	public static bool IsDebuffEffect(SkillStatusEffectType statusEffectType)
	{
		if (DebuffEffectList == null) return false;
		return DebuffEffectList.Contains(statusEffectType);
	}

	public static string GetSkillDesc(int skillIdx, int skillLevel)
	{
		return string.Empty;
	}

	public static string GetSkillValueDesc(int skillidx, int skillvalue)
	{
		return string.Empty;
	}

	public static Config.ManagerSkillContentsType GetSkillContentsType(int skillIdx)
	{
		return Config.ManagerSkillContentsType.None;
	}

	public static bool IsPercentAbility(Config.ManagerSkillType skillType)
	{
		switch (skillType)
		{
			case Config.ManagerSkillType.AddDamage:
			case Config.ManagerSkillType.AddDefense:
			case Config.ManagerSkillType.AddCritical:
				return true;
			default:
				return false;
		}
	}

	public static bool IsBossStageIdx(int stageIdx)
	{
		if (BOSS_STAGE_IDX_MULTIPLIER <= 0) return false;
		return stageIdx > 0 && stageIdx % BOSS_STAGE_IDX_MULTIPLIER == 0;
	}

	public static int GetMultipleRewardNeedCash(int getCount)
	{
		return WIN_REWARD_MULTIPLE_NEED_CASH + getCount * WIN_REWARD_MULTIPLE_PLUS_CASH;
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
