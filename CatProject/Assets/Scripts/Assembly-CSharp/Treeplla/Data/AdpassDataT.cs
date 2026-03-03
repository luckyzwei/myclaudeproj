using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class AdpassDataT
	{
		[JsonProperty("openvalue")]
		public int Openvalue { get; set; }

		[JsonProperty("resettime")]
		public long Resettime { get; set; }

		[JsonProperty("getrewards")]
		public List<int> Getrewards { get; set; }

		[JsonProperty("adviewcount")]
		public int Adviewcount { get; set; }
	}
}
