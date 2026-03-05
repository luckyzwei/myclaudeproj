using System.Collections.Generic;
using SeasonalDef;

namespace Treeplla
{
	public class SeasonalBuildingData
	{
		public int BuildingIdx;
		public int SeasonThemeIdx;
		public E_BuildingType BuildingType;
		public int BuildingNumber;
		public int MainFacilityIdx;
		public int MaxLevel;
		public int ManagerIdx;
		public List<int> FacilityIdxList;
		public List<int> WorkerTransformIdxList;
		public int MaxWorkerCount;
		public int DistributorCoolTimeSec;
		public List<int> ProductionOutputIdxList;
		public Dictionary<int, int> ProductionNeedInfoMap;
	}
}
