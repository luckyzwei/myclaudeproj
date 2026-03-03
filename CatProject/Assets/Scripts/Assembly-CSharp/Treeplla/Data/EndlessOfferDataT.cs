using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class EndlessOfferDataT
	{
		[JsonProperty("endlessidx")]
		public int Endlessidx { get; set; }

		[JsonProperty("curorderidx")]
		public int Curorderidx { get; set; }

		[JsonProperty("endtime")]
		public long Endtime { get; set; }

		[JsonProperty("lastautoshowtime")]
		public long Lastautoshowtime { get; set; }

		[JsonProperty("buycount")]
		public int Buycount { get; set; }
	}
}
