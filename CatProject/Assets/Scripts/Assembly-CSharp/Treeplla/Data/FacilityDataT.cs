using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class FacilityDataT
	{
		[JsonProperty("index")]
		public int Index { get; set; }

		[JsonProperty("level")]
		public int Level { get; set; }

		[JsonProperty("speedlevel")]
		public int Speedlevel { get; set; }
	}
}
