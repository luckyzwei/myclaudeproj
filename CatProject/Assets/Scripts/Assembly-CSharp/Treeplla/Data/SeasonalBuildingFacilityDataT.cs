using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class SeasonalBuildingFacilityDataT
	{
		[JsonProperty("facilityidx")]
		public int Facilityidx { get; set; }

		[JsonProperty("level")]
		public int Level { get; set; }
	}
}
