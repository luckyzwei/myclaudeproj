using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class CompanyDataT
	{
		[JsonProperty("idx")]
		public int Idx { get; set; }

		[JsonProperty("level")]
		public int Level { get; set; }

		[JsonProperty("exp")]
		public string Exp { get; set; }

		[JsonProperty("maxreward")]
		public bool Maxreward { get; set; }
	}
}
