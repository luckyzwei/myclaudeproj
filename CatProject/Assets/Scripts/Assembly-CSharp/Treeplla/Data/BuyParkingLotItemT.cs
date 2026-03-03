using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class BuyParkingLotItemT
	{
		[JsonProperty("parkinglotspaceidx")]
		public int Parkinglotspaceidx { get; set; }

		[JsonProperty("isbuy")]
		public bool Isbuy { get; set; }
	}
}
