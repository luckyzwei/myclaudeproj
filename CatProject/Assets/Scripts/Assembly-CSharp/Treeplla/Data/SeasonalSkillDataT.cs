using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class SeasonalSkillDataT
	{
		[JsonProperty("abilitytype")]
		public int Abilitytype { get; set; }

		[JsonProperty("level")]
		public int Level { get; set; }

		[JsonProperty("orderindex")]
		public int Orderindex { get; set; }
	}
}
