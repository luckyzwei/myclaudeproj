using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class CeoCostumeDataT
	{
		[JsonProperty("idx")]
		public int Idx { get; set; }

		[JsonProperty("isowned")]
		public bool Isowned { get; set; }

		[JsonProperty("showreddot")]
		public bool Showreddot { get; set; }
	}
}
