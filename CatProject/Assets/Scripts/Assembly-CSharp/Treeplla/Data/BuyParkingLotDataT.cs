using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class BuyParkingLotDataT
	{
		[JsonProperty("buyparkinglotidx")]
		public int Buyparkinglotidx { get; set; }

		[JsonProperty("buyparkinglotitems")]
		public List<BuyParkingLotItemT> Buyparkinglotitems { get; set; }
	}
}
