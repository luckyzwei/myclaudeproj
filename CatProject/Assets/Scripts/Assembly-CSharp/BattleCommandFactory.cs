using System.Collections.Generic;

public static class BattleCommandFactory
{
	public static BattleCommand CreateAttackCommand(BizAcqCharacterData caster, BizAcqCharacterData target)
	{
		return null;
	}

	public static BattleCommand CreateAdditionalAttackCommand(BizAcqCharacterData caster, BizAcqCharacterData target)
	{
		return null;
	}

	public static BattleCommand CreateSkillCommand(BizAcqCharacterData caster)
	{
		return null;
	}

	private static List<BizAcqCharacterData> GetSameTeamTargets(BizAcqCharacterData caster)
	{
		return null;
	}

	private static List<BizAcqCharacterData> GetOppositeTeamTargets(BizAcqCharacterData caster)
	{
		return null;
	}

	private static BizAcqCharacterData GetOppositeTeamTarget(BizAcqCharacterData caster)
	{
		return null;
	}
}
