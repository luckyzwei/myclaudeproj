using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class KeyValueT
	{
		[JsonProperty("idx")]
		public int Idx { get; set; }

		[JsonProperty("value")]
		public float Value { get; set; }
	}
}
