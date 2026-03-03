using System.Numerics;
using SeasonalDef;
using UniRx;

public class SeasonalBuildingFacilityData
{
	public int FacilityIdx;

	public int ShowIndex;

	public E_BuildingFacilityAbilityType FacilityAbilityType;

	public IReactiveProperty<int> Level;

	public BigInteger CurLevelAbilityValue_PerMille;

	public BigInteger NextLevelCostValue_PerMile;

	public Subject<int> OnUpdatedFacilityData;
}
