using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class SellerDataT
	{
		[JsonProperty("idx")]
		public int Idx { get; set; }

		[JsonProperty("itemidx")]
		public int Itemidx { get; set; }

		[JsonProperty("grade")]
		public int Grade { get; set; }

		[JsonProperty("offorder")]
		public int Offorder { get; set; }

		[JsonProperty("soldout")]
		public bool Soldout { get; set; }
	}
}
