using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class RecordCountT
	{
		[JsonProperty("idx")]
		public string Idx { get; set; }

		[JsonProperty("count")]
		public int Count { get; set; }
	}
}
