public class AdditionalAttackCommand : BattleCommand
{
	public AdditionalAttackCommand(BizAcqCharacterData caster, BizAcqCharacterData target)
	{
		Caster = caster;
		Targets = new System.Collections.Generic.List<BizAcqCharacterData> { target };
	}
}
