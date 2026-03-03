using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class ExchangeShopDataT
	{
		[JsonProperty("itemidx")]
		public int Itemidx { get; set; }

		[JsonProperty("itembuycount")]
		public int Itembuycount { get; set; }
	}
}
