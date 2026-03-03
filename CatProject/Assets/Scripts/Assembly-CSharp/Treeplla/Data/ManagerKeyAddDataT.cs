using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class ManagerKeyAddDataT
	{
		[JsonProperty("factoryresettime")]
		public long Factoryresettime { get; set; }

		[JsonProperty("factoryorder")]
		public int Factoryorder { get; set; }

		[JsonProperty("factoryrewards")]
		public List<int> Factoryrewards { get; set; }

		[JsonProperty("usegemcount")]
		public int Usegemcount { get; set; }

		[JsonProperty("catstakeyreward")]
		public List<int> Catstakeyreward { get; set; }

		[JsonProperty("factoryrewardcontentsopen")]
		public List<bool> Factoryrewardcontentsopen { get; set; }

		[JsonProperty("factoryrewardcontentsopen2")]
		public List<bool> Factoryrewardcontentsopen2 { get; set; }
	}
}
