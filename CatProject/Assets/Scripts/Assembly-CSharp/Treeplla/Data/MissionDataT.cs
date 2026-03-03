using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class MissionDataT
	{
		[JsonProperty("slot")]
		public int Slot { get; set; }

		[JsonProperty("order")]
		public int Order { get; set; }

		[JsonProperty("value")]
		public string Value { get; set; }
	}
}
