using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class TreatDataT
	{
		[JsonProperty("idx")]
		public int Idx { get; set; }

		[JsonProperty("adusetime")]
		public long Adusetime { get; set; }

		[JsonProperty("buffendtime")]
		public long Buffendtime { get; set; }

		[JsonProperty("count")]
		public int Count { get; set; }
	}
}
