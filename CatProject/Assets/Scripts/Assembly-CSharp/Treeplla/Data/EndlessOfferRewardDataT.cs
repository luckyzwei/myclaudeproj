using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class EndlessOfferRewardDataT
	{
		[JsonProperty("endlessidx")]
		public int Endlessidx { get; set; }

		[JsonProperty("orderidx")]
		public int Orderidx { get; set; }

		[JsonProperty("isbuy")]
		public bool Isbuy { get; set; }
	}
}
