using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class CompanyListRefreshDataT
	{
		[JsonProperty("remaincnt")]
		public int Remaincnt { get; set; }

		[JsonProperty("lastchargetime")]
		public long Lastchargetime { get; set; }
	}
}
