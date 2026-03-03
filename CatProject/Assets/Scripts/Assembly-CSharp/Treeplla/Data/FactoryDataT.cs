using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class FactoryDataT
	{
		[JsonProperty("buildings")]
		public List<FactoryBuildingT> Buildings { get; set; }

		[JsonProperty("items")]
		public List<FactoryItemT> Items { get; set; }

		[JsonProperty("orderslots")]
		public List<FactoryOrderSlotT> Orderslots { get; set; }

		[JsonProperty("orderadstime")]
		public long Orderadstime { get; set; }

		[JsonProperty("orderadscount")]
		public int Orderadscount { get; set; }

		[JsonProperty("itemads")]
		public List<FactoryAdsItemT> Itemads { get; set; }

		[JsonProperty("dailyorderfreerefreshcount")]
		public int Dailyorderfreerefreshcount { get; set; }

		[JsonProperty("dailyorderfreerefreshresettime")]
		public long Dailyorderfreerefreshresettime { get; set; }
	}
}
