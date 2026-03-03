using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class StaffDataT
	{
		[JsonProperty("type")]
		public int Type { get; set; }

		[JsonProperty("count")]
		public int Count { get; set; }

		[JsonProperty("speed")]
		public float Speed { get; set; }
	}
}
