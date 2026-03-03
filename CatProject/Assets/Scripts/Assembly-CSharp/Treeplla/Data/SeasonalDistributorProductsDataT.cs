using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class SeasonalDistributorProductsDataT
	{
		[JsonProperty("productidx")]
		public int Productidx { get; set; }

		[JsonProperty("productlevel")]
		public int Productlevel { get; set; }

		[JsonProperty("isselling")]
		public bool Isselling { get; set; }

		[JsonProperty("isupgradeopen")]
		public bool Isupgradeopen { get; set; }
	}
}
