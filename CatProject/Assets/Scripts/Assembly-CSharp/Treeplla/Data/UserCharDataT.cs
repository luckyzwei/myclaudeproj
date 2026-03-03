using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class UserCharDataT
	{
		[JsonProperty("idx")]
		public int Idx { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("companyname")]
		public string Companyname { get; set; }
	}
}
