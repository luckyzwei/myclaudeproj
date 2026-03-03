using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class MainFoodDataT
	{
		[JsonProperty("foodslotidx")]
		public int Foodslotidx { get; set; }

		[JsonProperty("resettime")]
		public long Resettime { get; set; }
	}
}
