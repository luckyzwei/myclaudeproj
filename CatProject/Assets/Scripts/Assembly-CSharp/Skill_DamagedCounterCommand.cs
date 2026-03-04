using System.Collections.Generic;

public class Skill_DamagedCounterCommand : BattleCommand
{
	public Skill_DamagedCounterCommand(BizAcqCharacterData caster, List<BizAcqCharacterData> targets)
	{
		Caster = caster;
		Targets = targets;
	}
}
