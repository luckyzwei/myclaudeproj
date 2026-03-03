using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class SeasonalUserDataT
	{
		[JsonProperty("graphtype")]
		public int Graphtype { get; set; }

		[JsonProperty("finalscore")]
		public int Finalscore { get; set; }

		[JsonProperty("currentscore")]
		public int Currentscore { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("profile")]
		public string Profile { get; set; }

		[JsonProperty("me")]
		public bool Me { get; set; }

		[JsonProperty("graphpower")]
		public int Graphpower { get; set; }
	}
}
