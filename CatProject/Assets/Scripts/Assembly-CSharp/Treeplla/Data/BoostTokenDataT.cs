using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class BoostTokenDataT
	{
		[JsonProperty("tokeidx")]
		public int Tokeidx { get; set; }

		[JsonProperty("endtime")]
		public long Endtime { get; set; }
	}
}
