using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class RichRichAchieveT
	{
		[JsonProperty("achievecount")]
		public int Achievecount { get; set; }

		[JsonProperty("missionreceivedidxs")]
		public List<int> Missionreceivedidxs { get; set; }

		[JsonProperty("achievereceivedidxs")]
		public List<int> Achievereceivedidxs { get; set; }
	}
}
