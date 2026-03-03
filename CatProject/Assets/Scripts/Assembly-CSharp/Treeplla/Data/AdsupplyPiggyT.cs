using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class AdsupplyPiggyT
	{
		[JsonProperty("savecnt")]
		public int Savecnt { get; set; }

		[JsonProperty("collectmoney")]
		public string Collectmoney { get; set; }
	}
}
