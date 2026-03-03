using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class ContentsMissionDataT
	{
		[JsonProperty("contentstype")]
		public int Contentstype { get; set; }

		[JsonProperty("missionsettime")]
		public long Missionsettime { get; set; }

		[JsonProperty("missions")]
		public List<SingleMissionDataT> Missions { get; set; }

		[JsonProperty("isrefreshed")]
		public bool Isrefreshed { get; set; }

		[JsonProperty("missiongroupidx")]
		public int Missiongroupidx { get; set; }
	}
}
