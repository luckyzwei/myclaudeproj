using BizAcqDef;

public class BizAcqCharacterSkillData
{
	public int SkillIdx { get; private set; }

	public int SkillLevel { get; private set; }

	public Config.ManagerSkillActivationType ActivationType { get; private set; }

	public Config.ManagerSkillType SkillType { get; private set; }

	public SkillExecutionType SkillExecutionType { get; private set; }

	public float TriggerChance_Origin { get; private set; }

	public float TriggerChance { get; private set; }

	public float EffectValue { get; private set; }

	public bool IsTriggered { get; private set; }

	public BizAcqCharacterSkillData(int skillIdx, int skillLevel)
	{
	}

	public void UpdateSkillData(int skillLevel)
	{
	}

	public void SetAddedTriggerChanceRatio(float value)
	{
	}

	public void SetTriggered(bool isTriggered)
	{
	}

	public void Reset()
	{
	}
}
