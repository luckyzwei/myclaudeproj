using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class SegmentDataT
	{
		[JsonProperty("type")]
		public int Type { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }
	}
}
