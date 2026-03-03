using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class SeasonalBuildingDataT
	{
		[JsonProperty("buildingidx")]
		public int Buildingidx { get; set; }

		[JsonProperty("level")]
		public int Level { get; set; }

		[JsonProperty("constructioncompletetimeticks")]
		public long Constructioncompletetimeticks { get; set; }

		[JsonProperty("needcompletenotice")]
		public bool Needcompletenotice { get; set; }

		[JsonProperty("isopen")]
		public bool Isopen { get; set; }

		[JsonProperty("isconstruction")]
		public bool Isconstruction { get; set; }

		[JsonProperty("facilitydata")]
		public List<SeasonalBuildingFacilityDataT> Facilitydata { get; set; }

		[JsonProperty("workerdata")]
		public SeasonalBuildingWorkerDataT Workerdata { get; set; }

		[JsonProperty("managerdata")]
		public SeasonalWorkshopManagerDataT Managerdata { get; set; }
	}
}
