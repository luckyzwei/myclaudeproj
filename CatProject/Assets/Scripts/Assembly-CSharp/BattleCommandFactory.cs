using System.Collections.Generic;
using BizAcqDef;

public static class BattleCommandFactory
{
	public static BattleCommand CreateAttackCommand(BizAcqCharacterData caster, BizAcqCharacterData target)
	{
		if (caster == null || target == null) return null;
		var cmd = new AttackCommand(caster, target);
		cmd.DamageValue = caster.DealPower;
		cmd.IsHit = true;
		return cmd;
	}

	public static BattleCommand CreateAdditionalAttackCommand(BizAcqCharacterData caster, BizAcqCharacterData target)
	{
		if (caster == null || target == null) return null;
		var cmd = new AdditionalAttackCommand(caster, target);
		cmd.DamageValue = caster.DealPower / 2;
		cmd.IsHit = true;
		return cmd;
	}

	public static BattleCommand CreateSkillCommand(BizAcqCharacterData caster)
	{
		if (caster == null || caster.SkillData == null) return null;
		return null;
	}

	private static List<BizAcqCharacterData> GetSameTeamTargets(BizAcqCharacterData caster)
	{
		if (caster == null) return null;
		var battleSystem = GameRoot.Instance?.BizAcqBattleSystem;
		if (battleSystem == null) return null;
		var team = battleSystem.GetTeam(caster.TeamType);
		if (team == null || team.Characters == null) return null;
		var result = new List<BizAcqCharacterData>();
		for (int i = 0; i < team.Characters.Count; i++)
		{
			if (team.Characters[i] != null && !team.Characters[i].IsDead())
				result.Add(team.Characters[i]);
		}
		return result;
	}

	private static List<BizAcqCharacterData> GetOppositeTeamTargets(BizAcqCharacterData caster)
	{
		if (caster == null) return null;
		var battleSystem = GameRoot.Instance?.BizAcqBattleSystem;
		if (battleSystem == null) return null;
		TeamType oppositeType = caster.TeamType == TeamType.Player ? TeamType.Enemy : TeamType.Player;
		var team = battleSystem.GetTeam(oppositeType);
		if (team == null || team.Characters == null) return null;
		var result = new List<BizAcqCharacterData>();
		for (int i = 0; i < team.Characters.Count; i++)
		{
			if (team.Characters[i] != null && !team.Characters[i].IsDead())
				result.Add(team.Characters[i]);
		}
		return result;
	}

	private static BizAcqCharacterData GetOppositeTeamTarget(BizAcqCharacterData caster)
	{
		var targets = GetOppositeTeamTargets(caster);
		if (targets == null || targets.Count == 0) return null;
		return targets[0];
	}
}
