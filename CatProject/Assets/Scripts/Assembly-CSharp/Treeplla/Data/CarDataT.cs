using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class CarDataT
	{
		[JsonProperty("idx")]
		public int Idx { get; set; }

		[JsonProperty("parkingidx")]
		public int Parkingidx { get; set; }

		[JsonProperty("parkingzone")]
		public int Parkingzone { get; set; }
	}
}
