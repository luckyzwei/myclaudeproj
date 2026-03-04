using System.Collections.Generic;

public class Skill_MultiAttackCommand : BattleCommand
{
	public Skill_MultiAttackCommand(BizAcqCharacterData caster, List<BizAcqCharacterData> targets)
	{
		Caster = caster;
		Targets = targets;
	}
}
