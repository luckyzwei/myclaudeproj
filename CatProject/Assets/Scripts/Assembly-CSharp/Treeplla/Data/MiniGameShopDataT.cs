using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class MiniGameShopDataT
	{
		[JsonProperty("eventidx")]
		public int Eventidx { get; set; }

		[JsonProperty("adsfreeitemdata")]
		public AdsFreeViewDataT Adsfreeitemdata { get; set; }

		[JsonProperty("exchangeitemdata")]
		public List<ExchangeShopDataT> Exchangeitemdata { get; set; }

		[JsonProperty("scheduleidx")]
		public int Scheduleidx { get; set; }
	}
}
