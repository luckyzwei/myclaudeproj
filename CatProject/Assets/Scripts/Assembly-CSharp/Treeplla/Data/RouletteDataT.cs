using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class RouletteDataT
	{
		[JsonProperty("nextspintime")]
		public long Nextspintime { get; set; }

		[JsonProperty("luckydrawcount")]
		public int Luckydrawcount { get; set; }

		[JsonProperty("havefreespin")]
		public bool Havefreespin { get; set; }
	}
}
