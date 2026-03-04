using System.Collections.Generic;

public class Skill_SkillChanceUpCommand : BattleCommand
{
	public Skill_SkillChanceUpCommand(BizAcqCharacterData caster, List<BizAcqCharacterData> targets)
	{
		Caster = caster;
		Targets = targets;
	}
}
