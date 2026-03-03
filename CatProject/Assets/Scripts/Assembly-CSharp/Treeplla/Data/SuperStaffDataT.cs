using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class SuperStaffDataT
	{
		[JsonProperty("idx")]
		public int Idx { get; set; }

		[JsonProperty("level")]
		public int Level { get; set; }
	}
}
