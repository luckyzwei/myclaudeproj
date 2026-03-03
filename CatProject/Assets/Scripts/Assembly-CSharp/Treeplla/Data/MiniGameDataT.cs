using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class MiniGameDataT
	{
		[JsonProperty("digtreasurehuntdata")]
		public List<DigTreasureHuntDataT> Digtreasurehuntdata { get; set; }

		[JsonProperty("shopdata")]
		public List<MiniGameShopDataT> Shopdata { get; set; }

		[JsonProperty("lastplayscheduleidx")]
		public int Lastplayscheduleidx { get; set; }

		[JsonProperty("shownopenpopup")]
		public bool Shownopenpopup { get; set; }
	}
}
