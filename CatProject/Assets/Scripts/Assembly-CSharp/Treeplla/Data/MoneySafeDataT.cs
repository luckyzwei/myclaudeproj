using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class MoneySafeDataT
	{
		[JsonProperty("count")]
		public int Count { get; set; }

		[JsonProperty("money")]
		public string Money { get; set; }
	}
}
