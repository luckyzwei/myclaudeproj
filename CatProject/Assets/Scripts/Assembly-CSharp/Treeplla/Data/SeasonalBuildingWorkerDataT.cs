using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class SeasonalBuildingWorkerDataT
	{
		[JsonProperty("facilityidx")]
		public int Facilityidx { get; set; }

		[JsonProperty("hiredcount")]
		public int Hiredcount { get; set; }
	}
}
