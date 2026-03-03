using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class UnitDataT
	{
		[JsonProperty("level")]
		public int Level { get; set; }

		[JsonProperty("count")]
		public int Count { get; set; }
	}
}
