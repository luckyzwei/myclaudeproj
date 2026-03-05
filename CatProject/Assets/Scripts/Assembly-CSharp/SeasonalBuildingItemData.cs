using System.Collections.Generic;
using SeasonalDef;

public class SeasonalBuildingItemData
{
	public int FacilityIdx;
	public int BuildingIdx;
	public string FacilityName;
	public string FacilityIcon;
	public E_BuildingFacilityAbilityType AbilityType;
	public int MaxLevel;
	public int ShowIndex;
	public List<int> DisplayLevelRangeList;
	public List<string> DisplayNameList;
	public List<string> DisplayIconList;
	public int HireWorkerManagerLevelCondition;
	public List<int> HireWorkerManagerLevelConditionList;
}
