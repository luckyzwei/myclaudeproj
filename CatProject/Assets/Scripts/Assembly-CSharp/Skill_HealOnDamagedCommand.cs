using System.Collections.Generic;

public class Skill_HealOnDamagedCommand : BattleCommand
{
	public Skill_HealOnDamagedCommand(BizAcqCharacterData caster, List<BizAcqCharacterData> targets)
	{
		Caster = caster;
		Targets = targets;
	}
}
