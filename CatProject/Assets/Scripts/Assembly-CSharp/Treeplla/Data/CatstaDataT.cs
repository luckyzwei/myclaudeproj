using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class CatstaDataT
	{
		[JsonProperty("order")]
		public int Order { get; set; }

		[JsonProperty("type")]
		public int Type { get; set; }

		[JsonProperty("idx")]
		public int Idx { get; set; }

		[JsonProperty("like")]
		public bool Like { get; set; }

		[JsonProperty("reward")]
		public bool Reward { get; set; }
	}
}
