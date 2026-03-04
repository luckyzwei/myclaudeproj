using System.Collections.Generic;

public class Skill_BuffClearCommand : BattleCommand
{
	public Skill_BuffClearCommand(BizAcqCharacterData caster, List<BizAcqCharacterData> targets)
	{
		Caster = caster;
		Targets = targets;
	}
}
