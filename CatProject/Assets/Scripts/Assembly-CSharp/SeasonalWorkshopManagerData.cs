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

	public bool IsMaxLevel { get { return false; } }

	public BigInteger GetManagerAbility_PerMile(E_WorkshopManagerAbilityType abilityType)
	{
		return default(BigInteger);
	}

	public void PutManagerAbility(E_WorkshopManagerAbilityType abilityType, BigInteger value_PerMile)
	{
	}

	public bool IsValid()
	{
		return false;
	}

	public void ClearAbilityMap()
	{
	}
}
