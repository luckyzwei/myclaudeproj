using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class KeyValueLongT
	{
		[JsonProperty("key")]
		public int Key { get; set; }

		[JsonProperty("value")]
		public long Value { get; set; }
	}
}
