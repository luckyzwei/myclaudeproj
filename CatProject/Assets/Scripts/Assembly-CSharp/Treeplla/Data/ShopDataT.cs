using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class ShopDataT
	{
		[JsonProperty("freeitemtimes")]
		public List<KeyValueLongT> Freeitemtimes { get; set; }

		[JsonProperty("piggyvalue")]
		public int Piggyvalue { get; set; }

		[JsonProperty("packages")]
		public List<PackageDataT> Packages { get; set; }

		[JsonProperty("expirepackage")]
		public List<int> Expirepackage { get; set; }

		[JsonProperty("piggylevel")]
		public int Piggylevel { get; set; }

		[JsonProperty("piggyreward")]
		public List<int> Piggyreward { get; set; }

		[JsonProperty("noadssaleend")]
		public long Noadssaleend { get; set; }

		[JsonProperty("playerlvpasssaleend")]
		public long Playerlvpasssaleend { get; set; }

		[JsonProperty("shopsalepackagetimes")]
		public List<KeyValueLongT> Shopsalepackagetimes { get; set; }

		[JsonProperty("cyclelimitedshopgoods")]
		public List<CycleLimitedShopGoodsT> Cyclelimitedshopgoods { get; set; }

		[JsonProperty("endlessofferdata")]
		public List<EndlessOfferDataT> Endlessofferdata { get; set; }
	}
}
