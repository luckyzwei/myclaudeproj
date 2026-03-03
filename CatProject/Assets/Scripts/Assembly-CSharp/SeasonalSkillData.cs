using System.Collections.Generic;
using System.Numerics;
using SeasonalDef;

public class SeasonalSkillData
{
	public int OrderIdx;

	public E_CurrencyType CurrencyType;

	public E_SkillBookAbilityType AbilityType;

	public List<int> AbilityTargetList;

	public BigInteger AbilityValue_Per;

	public int CurLevel;

	public int MaxLevel;

	public int UpgradeNeedValue_PerMile;

	public bool IsOpen => false;
}
