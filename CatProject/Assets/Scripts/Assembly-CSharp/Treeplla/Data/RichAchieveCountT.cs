using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class RichAchieveCountT
	{
		[JsonProperty("regionidx")]
		public int Regionidx { get; set; }

		[JsonProperty("count")]
		public int Count { get; set; }
	}
}
