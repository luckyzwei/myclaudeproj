using System.Collections.Generic;

public class Skill_AttackNextEvadeCommand : BattleCommand
{
	public Skill_AttackNextEvadeCommand(BizAcqCharacterData caster, List<BizAcqCharacterData> targets)
	{
		Caster = caster;
		Targets = targets;
	}
}
