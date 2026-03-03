using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class InvestDataT
	{
		[JsonProperty("selectcompany")]
		public int Selectcompany { get; set; }

		[JsonProperty("rewardmoney")]
		public string Rewardmoney { get; set; }

		[JsonProperty("refreshtime")]
		public long Refreshtime { get; set; }

		[JsonProperty("startttime")]
		public long Startttime { get; set; }

		[JsonProperty("multiplevalue")]
		public int Multiplevalue { get; set; }

		[JsonProperty("startinvesttime")]
		public long Startinvesttime { get; set; }

		[JsonProperty("investmoney")]
		public string Investmoney { get; set; }
	}
}
