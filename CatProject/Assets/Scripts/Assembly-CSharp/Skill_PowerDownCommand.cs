using System.Collections.Generic;

public class Skill_PowerDownCommand : BattleCommand
{
	public Skill_PowerDownCommand(BizAcqCharacterData caster, List<BizAcqCharacterData> targets)
	{
		Caster = caster;
		Targets = targets;
	}
}
