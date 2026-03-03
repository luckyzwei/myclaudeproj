using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class CycleLimitedShopGoodsT
	{
		[JsonProperty("shopgoodsidx")]
		public int Shopgoodsidx { get; set; }

		[JsonProperty("nextresettime")]
		public long Nextresettime { get; set; }

		[JsonProperty("buycount")]
		public int Buycount { get; set; }
	}
}
