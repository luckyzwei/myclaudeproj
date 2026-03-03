using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class DigTreasureHuntCellDataT
	{
		[JsonProperty("itemindex")]
		public int Itemindex { get; set; }

		[JsonProperty("isopened")]
		public bool Isopened { get; set; }
	}
}
