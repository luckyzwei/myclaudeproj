using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class ItemDataT
	{
		[JsonProperty("idx")]
		public int Idx { get; set; }

		[JsonProperty("count")]
		public int Count { get; set; }
	}
}
