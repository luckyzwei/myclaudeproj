using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class BuildingDataT
	{
		[JsonProperty("idx")]
		public int Idx { get; set; }

		[JsonProperty("lv")]
		public int Lv { get; set; }

		[JsonProperty("value")]
		public string Value { get; set; }

		[JsonProperty("time")]
		public int Time { get; set; }
	}
}
