using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class PackageDataT
	{
		[JsonProperty("idx")]
		public int Idx { get; set; }

		[JsonProperty("endtime")]
		public long Endtime { get; set; }

		[JsonProperty("buycount")]
		public int Buycount { get; set; }
	}
}
