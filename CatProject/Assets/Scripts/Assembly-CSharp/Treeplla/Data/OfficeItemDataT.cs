using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class OfficeItemDataT
	{
		[JsonProperty("idx")]
		public int Idx { get; set; }

		[JsonProperty("type")]
		public int Type { get; set; }

		[JsonProperty("level")]
		public int Level { get; set; }
	}
}
