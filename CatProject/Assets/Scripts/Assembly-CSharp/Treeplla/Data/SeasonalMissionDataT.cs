using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class SeasonalMissionDataT
	{
		[JsonProperty("missionidx")]
		public int Missionidx { get; set; }

		[JsonProperty("missionvalue")]
		public List<string> Missionvalue { get; set; }

		[JsonProperty("missioncomplete")]
		public List<bool> Missioncomplete { get; set; }

		[JsonProperty("missionneedvalue")]
		public List<string> Missionneedvalue { get; set; }

		[JsonProperty("needupdatetargetrequirevalue")]
		public List<bool> Needupdatetargetrequirevalue { get; set; }
	}
}
