using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class StageUnitDataT
	{
		[JsonProperty("worker")]
		public UnitDataT Worker { get; set; }

		[JsonProperty("planter")]
		public UnitDataT Planter { get; set; }
	}
}
