using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class AdsFreeItemDataT
	{
		[JsonProperty("itemidx")]
		public int Itemidx { get; set; }

		[JsonProperty("viewcount")]
		public int Viewcount { get; set; }

		[JsonProperty("lastviewtime")]
		public long Lastviewtime { get; set; }
	}
}
