using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class ManagerDataT
	{
		[JsonProperty("idx")]
		public int Idx { get; set; }

		[JsonProperty("level")]
		public int Level { get; set; }

		[JsonProperty("count")]
		public int Count { get; set; }

		[JsonProperty("reinforcelevel")]
		public int Reinforcelevel { get; set; }

		[JsonProperty("skilllevel")]
		public int Skilllevel { get; set; }

		[JsonProperty("reinforceresetlasttime")]
		public long Reinforceresetlasttime { get; set; }
	}
}
