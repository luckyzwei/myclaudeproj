using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class AnniversaryEventDataT
	{
		[JsonProperty("anniversaryyear")]
		public int Anniversaryyear { get; set; }

		[JsonProperty("shownguide")]
		public bool Shownguide { get; set; }

		[JsonProperty("anniversarycoin")]
		public int Anniversarycoin { get; set; }

		[JsonProperty("anniversaryrouletteticket")]
		public int Anniversaryrouletteticket { get; set; }

		[JsonProperty("roulettemultipleindex")]
		public int Roulettemultipleindex { get; set; }

		[JsonProperty("roulettplaycount")]
		public int Roulettplaycount { get; set; }

		[JsonProperty("receivedplaybonuscount")]
		public int Receivedplaybonuscount { get; set; }

		[JsonProperty("eventshopdata")]
		public List<AnniversaryEventShopDataT> Eventshopdata { get; set; }
	}
}
