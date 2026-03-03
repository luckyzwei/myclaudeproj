using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class OfflineDataT
	{
		[JsonProperty("totalofflinetime")]
		public int Totalofflinetime { get; set; }

		[JsonProperty("totalofflinemoney")]
		public string Totalofflinemoney { get; set; }

		[JsonProperty("onstrike")]
		public bool Onstrike { get; set; }

		[JsonProperty("notstrike")]
		public bool Notstrike { get; set; }
	}
}
