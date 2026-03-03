using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class FactoryOrderSlotT
	{
		[JsonProperty("slot")]
		public int Slot { get; set; }

		[JsonProperty("isopen")]
		public bool Isopen { get; set; }

		[JsonProperty("orderproduct")]
		public int Orderproduct { get; set; }

		[JsonProperty("ordervalue")]
		public int Ordervalue { get; set; }

		[JsonProperty("refreshtime")]
		public long Refreshtime { get; set; }

		[JsonProperty("charactericonidx")]
		public int Charactericonidx { get; set; }

		[JsonProperty("charactertalkidx")]
		public int Charactertalkidx { get; set; }
	}
}
