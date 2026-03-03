using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class FactoryBuildingT
	{
		[JsonProperty("idx")]
		public int Idx { get; set; }

		[JsonProperty("level")]
		public int Level { get; set; }

		[JsonProperty("makeproduct")]
		public int Makeproduct { get; set; }

		[JsonProperty("opencompletetime")]
		public long Opencompletetime { get; set; }

		[JsonProperty("batteryuseendtime")]
		public long Batteryuseendtime { get; set; }

		[JsonProperty("usebattery")]
		public int Usebattery { get; set; }
	}
}
