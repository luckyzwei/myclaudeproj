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
		TeamType = teamType;
		CeoIdx = ceoIdx;
		TeamIdx = teamIdx;
		DealPower_Origin = power;
		DealPower = power;
		MaxHp_Origin = maxHp;
		CurrentHp = maxHp;
		State = CharacterState.Idle;
		SkillData = new BizAcqCharacterSkillData(skillIdx, skillLevel);
		StatusEffectList = new List<BizAcqCharacterStatusEffectData>();
	}

	public void UpdateCharacterData(int power, int maxHp, int skillLevel)
	{
		DealPower_Origin = power;
		DealPower = power;
		MaxHp_Origin = maxHp;
		CurrentHp = maxHp;
		UpdateStatusEffect();
	}

	public void TakeDamage(int damage)
	{
		if (damage <= 0) return;
		CurrentHp -= damage;
		if (CurrentHp <= 0)
		{
			CurrentHp = 0;
			SetState(CharacterState.Dead);
		}
	}

	public void Heal(int amount)
	{
		if (amount <= 0) return;
		CurrentHp += amount;
		if (CurrentHp > MaxHp_Origin)
			CurrentHp = MaxHp_Origin;
	}

	public int AddStatusEffect(BizAcqCharacterStatusEffectData statusEffectData)
	{
		if (statusEffectData == null) return 0;
		if (StatusEffectList == null)
			StatusEffectList = new List<BizAcqCharacterStatusEffectData>();
		StatusEffectList.Add(statusEffectData);
		UpdateStatusEffect();
		return StatusEffectList.Count;
	}

	public void RemoveStatusEffect(SkillStatusEffectType statusEffectType)
	{
		if (StatusEffectList == null) return;
		for (int i = StatusEffectList.Count - 1; i >= 0; i--)
		{
			if (StatusEffectList[i] != null && StatusEffectList[i].EffectType == statusEffectType)
			{
				StatusEffectList.RemoveAt(i);
			}
		}
		UpdateStatusEffect();
	}

	public bool IsAppliedBuffType()
	{
		if (StatusEffectList == null) return false;
		for (int i = 0; i < StatusEffectList.Count; i++)
		{
			if (StatusEffectList[i] != null && BizAcqHelper.IsBuffEffect(StatusEffectList[i].EffectType))
				return true;
		}
		return false;
	}

	public bool IsAppliedDebuffType()
	{
		if (StatusEffectList == null) return false;
		for (int i = 0; i < StatusEffectList.Count; i++)
		{
			if (StatusEffectList[i] != null && BizAcqHelper.IsDebuffEffect(StatusEffectList[i].EffectType))
				return true;
		}
		return false;
	}

	public bool IsStatusEffectApplied(SkillStatusEffectType statusEffectType)
	{
		if (StatusEffectList == null) return false;
		for (int i = 0; i < StatusEffectList.Count; i++)
		{
			if (StatusEffectList[i] != null && StatusEffectList[i].EffectType == statusEffectType)
				return true;
		}
		return false;
	}

	public bool IsDead()
	{
		return CurrentHp <= 0 || State == CharacterState.Dead;
	}

	public void SetState(CharacterState newState)
	{
		State = newState;
	}

	public void ChangeTeamIdx(int newTeamIdx)
	{
		TeamIdx = newTeamIdx;
	}

	public void Reset()
	{
		CurrentHp = MaxHp_Origin;
		DealPower = DealPower_Origin;
		State = CharacterState.Idle;
		if (StatusEffectList != null)
			StatusEffectList.Clear();
	}

	private void UpdateStatusEffect()
	{
		// Recalculate DealPower based on active status effects
		DealPower = DealPower_Origin;
		if (StatusEffectList == null) return;
		for (int i = 0; i < StatusEffectList.Count; i++)
		{
			var effect = StatusEffectList[i];
			if (effect == null) continue;
			if (effect.EffectType == SkillStatusEffectType.PowerUp)
				DealPower += (int)effect.EffectValue;
			else if (effect.EffectType == SkillStatusEffectType.PowerDown)
				DealPower -= (int)effect.EffectValue;
		}
		if (DealPower < 0) DealPower = 0;
	}
}
