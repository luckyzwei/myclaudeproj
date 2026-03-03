using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class TarotRegionDataT
	{
		[JsonProperty("tarotstarttype")]
		public int Tarotstarttype { get; set; }

		[JsonProperty("tarotresettime")]
		public long Tarotresettime { get; set; }

		[JsonProperty("tarotcardlist")]
		public List<int> Tarotcardlist { get; set; }

		[JsonProperty("tarotcardgetlist")]
		public List<int> Tarotcardgetlist { get; set; }
	}
}
