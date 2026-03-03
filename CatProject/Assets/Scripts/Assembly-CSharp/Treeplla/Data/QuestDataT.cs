using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class QuestDataT
	{
		[JsonProperty("order")]
		public int Order { get; set; }

		[JsonProperty("value")]
		public string Value { get; set; }

		[JsonProperty("recevied")]
		public bool Recevied { get; set; }
	}
}
