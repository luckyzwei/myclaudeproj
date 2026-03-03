using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class SeasonalCoinRankDataT
	{
		[JsonProperty("startranktime")]
		public long Startranktime { get; set; }

		[JsonProperty("accumulatecnt")]
		public int Accumulatecnt { get; set; }

		[JsonProperty("end")]
		public bool End { get; set; }

		[JsonProperty("userdata")]
		public List<SeasonalUserDataT> Userdata { get; set; }
	}
}
