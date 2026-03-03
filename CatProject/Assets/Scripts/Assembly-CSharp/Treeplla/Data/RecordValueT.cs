using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class RecordValueT
	{
		[JsonProperty("idx")]
		public string Idx { get; set; }

		[JsonProperty("value")]
		public long Value { get; set; }
	}
}
