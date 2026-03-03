using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class EventStaffDataT
	{
		[JsonProperty("idx")]
		public int Idx { get; set; }

		[JsonProperty("endtime")]
		public long Endtime { get; set; }

		[JsonProperty("maxrapid")]
		public bool Maxrapid { get; set; }
	}
}
