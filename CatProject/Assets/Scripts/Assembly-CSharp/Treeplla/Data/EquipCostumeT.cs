using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class EquipCostumeT
	{
		[JsonProperty("head")]
		public int Head { get; set; }

		[JsonProperty("body")]
		public int Body { get; set; }

		[JsonProperty("hand")]
		public int Hand { get; set; }
	}
}
