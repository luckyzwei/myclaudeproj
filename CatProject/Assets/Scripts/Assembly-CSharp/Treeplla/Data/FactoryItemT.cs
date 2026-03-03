using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class FactoryItemT
	{
		[JsonProperty("idx")]
		public int Idx { get; set; }

		[JsonProperty("count")]
		public int Count { get; set; }
	}
}
