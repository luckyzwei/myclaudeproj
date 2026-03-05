using System.Collections.Generic;
using System.Numerics;
using SeasonalDef;
using UniRx;

public class SeasonalWorkshopManagerData
{
	public int ManagerIdx;

	public IReactiveProperty<int> Level;

	private Dictionary<E_WorkshopManagerAbilityType, BigInteger> ManagerAbilityMap;

	public BigInteger LevelUpNeedCost;

	public bool IsMaxLevel
	{
		get
		{
			if (Level == null) return false;
			int maxLevel = SeasonalTableHelper.CalcManagerMaxLevel();
			return Level.Value >= maxLevel;
		}
	}

	public BigInteger GetManagerAbility_PerMile(E_WorkshopManagerAbilityType abilityType)
	{
		if (ManagerAbilityMap != null && ManagerAbilityMap.TryGetValue(abilityType, out var value))
			return value;
		return BigInteger.Zero;
	}

	public void PutManagerAbility(E_WorkshopManagerAbilityType abilityType, BigInteger value_PerMile)
	{
		if (ManagerAbilityMap == null)
			ManagerAbilityMap = new Dictionary<E_WorkshopManagerAbilityType, BigInteger>();
		ManagerAbilityMap[abilityType] = value_PerMile;
	}

	public bool IsValid()
	{
		return Level != null && Level.Value > 0;
	}

	public void ClearAbilityMap()
	{
		if (ManagerAbilityMap != null)
			ManagerAbilityMap.Clear();
	}
}
