using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class ManagerCardT
	{
		[JsonProperty("idx")]
		public int Idx { get; set; }

		[JsonProperty("cardcount")]
		public int Cardcount { get; set; }

		[JsonProperty("level")]
		public int Level { get; set; }

		[JsonProperty("isopen")]
		public bool Isopen { get; set; }
	}
}
