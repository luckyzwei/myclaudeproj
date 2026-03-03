using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class PackageOfferDataT
	{
		[JsonProperty("offertype")]
		public int Offertype { get; set; }

		[JsonProperty("offertime")]
		public long Offertime { get; set; }
	}
}
