using System.Collections.Generic;

public class Skill_DebuffClearCommand : BattleCommand
{
	public Skill_DebuffClearCommand(BizAcqCharacterData caster, List<BizAcqCharacterData> targets)
	{
		Caster = caster;
		Targets = targets;
	}
}
