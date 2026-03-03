using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class SeasonalWorkerDataT
	{
		[JsonProperty("workeridx")]
		public int Workeridx { get; set; }

		[JsonProperty("assignedbuildingidx")]
		public int Assignedbuildingidx { get; set; }

		[JsonProperty("assignedbuildingtransformidx")]
		public int Assignedbuildingtransformidx { get; set; }

		[JsonProperty("mood")]
		public int Mood { get; set; }

		[JsonProperty("lastuserestauranttime")]
		public long Lastuserestauranttime { get; set; }
	}
}
