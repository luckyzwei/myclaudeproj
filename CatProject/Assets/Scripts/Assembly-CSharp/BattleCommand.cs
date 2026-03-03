using System.Collections.Generic;
using BizAcqDef;

public abstract class BattleCommand
{
	public int DamageValue;

	public int EffectValue;

	public bool IsHit;

	public BizAcqCharacterData Caster { get; protected set; }

	public List<BizAcqCharacterData> Targets { get; protected set; }

	public SkillEffectType EffectType { get; protected set; }

	public SkillStatusEffectType StatusEffectType { get; protected set; }
}
