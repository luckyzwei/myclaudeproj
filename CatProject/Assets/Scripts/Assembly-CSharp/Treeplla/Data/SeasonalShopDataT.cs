using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class SeasonalShopDataT
	{
		[JsonProperty("seasoninfoidx")]
		public int Seasoninfoidx { get; set; }

		[JsonProperty("statueactive")]
		public bool Statueactive { get; set; }

		[JsonProperty("statuebuytime")]
		public long Statuebuytime { get; set; }

		[JsonProperty("statueslotcount")]
		public int Statueslotcount { get; set; }

		[JsonProperty("piggyvalue")]
		public int Piggyvalue { get; set; }

		[JsonProperty("packages")]
		public List<PackageDataT> Packages { get; set; }

		[JsonProperty("expirepackage")]
		public List<int> Expirepackage { get; set; }

		[JsonProperty("buildingslotactive")]
		public bool Buildingslotactive { get; set; }

		[JsonProperty("viewpackage")]
		public List<int> Viewpackage { get; set; }

		[JsonProperty("premiumpassactive")]
		public bool Premiumpassactive { get; set; }
	}
}
