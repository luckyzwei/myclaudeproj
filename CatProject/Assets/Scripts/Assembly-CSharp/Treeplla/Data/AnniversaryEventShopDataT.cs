using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class AnniversaryEventShopDataT
	{
		[JsonProperty("itemidx")]
		public int Itemidx { get; set; }

		[JsonProperty("itembuycount")]
		public int Itembuycount { get; set; }
	}
}
