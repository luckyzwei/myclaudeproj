using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class SingleMissionDataT
	{
		[JsonProperty("slotidx")]
		public int Slotidx { get; set; }

		[JsonProperty("missionidx")]
		public int Missionidx { get; set; }

		[JsonProperty("currentvalue")]
		public string Currentvalue { get; set; }

		[JsonProperty("iscomplete")]
		public bool Iscomplete { get; set; }

		[JsonProperty("isrewarded")]
		public bool Isrewarded { get; set; }
	}
}
