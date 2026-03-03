using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class CatstaEventDataT
	{
		[JsonProperty("idx")]
		public int Idx { get; set; }

		[JsonProperty("value")]
		public int Value { get; set; }

		[JsonProperty("like")]
		public bool Like { get; set; }

		[JsonProperty("reward")]
		public bool Reward { get; set; }
	}
}
