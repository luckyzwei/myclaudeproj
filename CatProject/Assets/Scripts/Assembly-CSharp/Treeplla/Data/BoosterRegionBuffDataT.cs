using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class BoosterRegionBuffDataT
	{
		[JsonProperty("boosteridx")]
		public int Boosteridx { get; set; }

		[JsonProperty("boosteractiveregionidx")]
		public int Boosteractiveregionidx { get; set; }

		[JsonProperty("boosterremaintimesec")]
		public int Boosterremaintimesec { get; set; }

		[JsonProperty("boosternextresettime")]
		public long Boosternextresettime { get; set; }

		[JsonProperty("boosterdailyusecount")]
		public int Boosterdailyusecount { get; set; }
	}
}
