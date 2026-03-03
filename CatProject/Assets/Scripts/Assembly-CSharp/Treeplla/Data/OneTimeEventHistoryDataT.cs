using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class OneTimeEventHistoryDataT
	{
		[JsonProperty("idx")]
		public int Idx { get; set; }

		[JsonProperty("currency")]
		public int Currency { get; set; }

		[JsonProperty("level")]
		public int Level { get; set; }

		[JsonProperty("levelexp")]
		public int Levelexp { get; set; }

		[JsonProperty("receivelevel")]
		public int Receivelevel { get; set; }

		[JsonProperty("activebonustheme")]
		public bool Activebonustheme { get; set; }
	}
}
