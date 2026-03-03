using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class ChapterPassDataT
	{
		[JsonProperty("receivestage")]
		public List<int> Receivestage { get; set; }

		[JsonProperty("receivebonuschapter")]
		public List<int> Receivebonuschapter { get; set; }

		[JsonProperty("receivestagenormal")]
		public List<int> Receivestagenormal { get; set; }
	}
}
