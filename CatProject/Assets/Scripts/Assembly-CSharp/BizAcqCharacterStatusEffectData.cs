using BizAcqDef;

public class BizAcqCharacterStatusEffectData
{
	public SkillStatusEffectType EffectType { get; private set; }

	public float EffectValue { get; private set; }

	public BizAcqCharacterStatusEffectData()
	{
	}

	public BizAcqCharacterStatusEffectData(SkillStatusEffectType effectType, float effectValue)
	{
	}
}
