using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class TreeDataT
	{
		[JsonProperty("index")]
		public int Index { get; set; }

		[JsonProperty("grade")]
		public int Grade { get; set; }
	}
}
