using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class RichAchieveT
	{
		[JsonProperty("missionreceivedidxs")]
		public List<int> Missionreceivedidxs { get; set; }

		[JsonProperty("achievereceivedidxs")]
		public List<int> Achievereceivedidxs { get; set; }

		[JsonProperty("isguideshow")]
		public bool Isguideshow { get; set; }

		[JsonProperty("ispageinfoshow")]
		public bool Ispageinfoshow { get; set; }
	}
}
