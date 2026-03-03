using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class SeasonalDataT
	{
		[JsonProperty("activeseasonidx")]
		public int Activeseasonidx { get; set; }

		[JsonProperty("seasonalstagedata")]
		public List<SeasonalStageDataT> Seasonalstagedata { get; set; }

		[JsonProperty("playedseasoninfoidxlist")]
		public List<int> Playedseasoninfoidxlist { get; set; }

		[JsonProperty("seasonalshopdata")]
		public List<SeasonalShopDataT> Seasonalshopdata { get; set; }
	}
}
