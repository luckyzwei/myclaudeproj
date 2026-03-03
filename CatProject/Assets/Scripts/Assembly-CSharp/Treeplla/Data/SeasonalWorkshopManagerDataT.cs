using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class SeasonalWorkshopManagerDataT
	{
		[JsonProperty("manageridx")]
		public int Manageridx { get; set; }

		[JsonProperty("level")]
		public int Level { get; set; }
	}
}
