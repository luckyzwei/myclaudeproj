using System.Collections.Generic;
using BizAcqDef;

public class BizAcqCharacterData
{
	public TeamType TeamType { get; private set; }

	public int CeoIdx { get; private set; }

	public int TeamIdx { get; private set; }

	public string ResourcePath { get; private set; }

	public int CurrentHp { get; private set; }

	public int MaxHp_Origin { get; private set; }

	public int DealPower_Origin { get; private set; }

	public int DealPower { get; private set; }

	public CharacterState State { get; private set; }

	public BizAcqCharacterSkillData SkillData { get; private set; }

	public List<BizAcqCharacterStatusEffectData> StatusEffectList { get; private set; }

	public BizAcqCharacterData(TeamType teamType, int ceoIdx, int teamIdx, int power, int maxHp, int skillIdx, int skillLevel)
	{
	}

	public void UpdateCharacterData(int power, int maxHp, int skillLevel)
	{
	}

	public void TakeDamage(int damage)
	{
	}

	public void Heal(int amount)
	{
	}

	public int AddStatusEffect(BizAcqCharacterStatusEffectData statusEffectData)
	{
		return 0;
	}

	public void RemoveStatusEffect(SkillStatusEffectType statusEffectType)
	{
	}

	public bool IsAppliedBuffType()
	{
		return false;
	}

	public bool IsAppliedDebuffType()
	{
		return false;
	}

	public bool IsStatusEffectApplied(SkillStatusEffectType statusEffectType)
	{
		return false;
	}

	public bool IsDead()
	{
		return false;
	}

	public void SetState(CharacterState newState)
	{
	}

	public void ChangeTeamIdx(int newTeamIdx)
	{
	}

	public void Reset()
	{
	}

	private void UpdateStatusEffect()
	{
	}
}
