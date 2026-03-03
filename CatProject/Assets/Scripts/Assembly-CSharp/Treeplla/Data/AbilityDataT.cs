using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class AbilityDataT
	{
		[JsonProperty("index")]
		public int Index { get; set; }

		[JsonProperty("level")]
		public int Level { get; set; }
	}
}
