using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class FactoryAdsItemT
	{
		[JsonProperty("idx")]
		public int Idx { get; set; }

		[JsonProperty("resettime")]
		public long Resettime { get; set; }

		[JsonProperty("count")]
		public int Count { get; set; }
	}
}
