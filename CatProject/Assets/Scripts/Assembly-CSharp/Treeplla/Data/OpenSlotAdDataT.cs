using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class OpenSlotAdDataT
	{
		[JsonProperty("reward")]
		public int Reward { get; set; }

		[JsonProperty("opentime")]
		public long Opentime { get; set; }

		[JsonProperty("opentimedictkey")]
		public List<int> Opentimedictkey { get; set; }

		[JsonProperty("opentimedictvalue")]
		public List<long> Opentimedictvalue { get; set; }
	}
}
