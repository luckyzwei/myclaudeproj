using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class TarotDataT
	{
		[JsonProperty("tarotbasicticket")]
		public int Tarotbasicticket { get; set; }

		[JsonProperty("tarotspecialticket")]
		public int Tarotspecialticket { get; set; }

		[JsonProperty("tarotrewardlist")]
		public List<int> Tarotrewardlist { get; set; }

		[JsonProperty("tarotregiondata")]
		public List<TarotRegionDataT> Tarotregiondata { get; set; }

		[JsonProperty("lastfreerefreshtime")]
		public long Lastfreerefreshtime { get; set; }
	}
}
