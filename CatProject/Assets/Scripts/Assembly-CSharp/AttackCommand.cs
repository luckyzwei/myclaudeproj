public class AttackCommand : BattleCommand
{
	public AttackCommand(BizAcqCharacterData caster, BizAcqCharacterData target)
	{
		Caster = caster;
		Targets = new System.Collections.Generic.List<BizAcqCharacterData> { target };
	}
}
