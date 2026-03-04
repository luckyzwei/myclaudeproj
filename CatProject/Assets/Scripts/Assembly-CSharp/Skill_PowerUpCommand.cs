using System.Collections.Generic;

public class Skill_PowerUpCommand : BattleCommand
{
	public Skill_PowerUpCommand(BizAcqCharacterData caster, List<BizAcqCharacterData> targets)
	{
		Caster = caster;
		Targets = targets;
	}
}
