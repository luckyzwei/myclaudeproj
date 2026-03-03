using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class BoosterBuffDataT
	{
		[JsonProperty("boosteridx")]
		public int Boosteridx { get; set; }

		[JsonProperty("totalusecount")]
		public int Totalusecount { get; set; }

		[JsonProperty("boosterregionbuffdata")]
		public List<BoosterRegionBuffDataT> Boosterregionbuffdata { get; set; }

		[JsonProperty("boosterticketuseactive")]
		public bool Boosterticketuseactive { get; set; }
	}
}
