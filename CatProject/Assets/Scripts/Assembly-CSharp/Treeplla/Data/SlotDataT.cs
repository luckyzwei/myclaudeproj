using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class SlotDataT
	{
		[JsonProperty("index")]
		public int Index { get; set; }

		[JsonProperty("openslot")]
		public int Openslot { get; set; }

		[JsonProperty("level")]
		public int Level { get; set; }

		[JsonProperty("cooltime")]
		public float Cooltime { get; set; }

		[JsonProperty("buffvalue")]
		public int Buffvalue { get; set; }
	}
}
