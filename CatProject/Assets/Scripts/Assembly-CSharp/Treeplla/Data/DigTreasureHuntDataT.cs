using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class DigTreasureHuntDataT
	{
		[JsonProperty("eventidx")]
		public int Eventidx { get; set; }

		[JsonProperty("stageidx")]
		public int Stageidx { get; set; }

		[JsonProperty("grid")]
		public List<DigTreasureHuntCellDataT> Grid { get; set; }

		[JsonProperty("progressrewardclaimed")]
		public List<bool> Progressrewardclaimed { get; set; }

		[JsonProperty("scheduleidx")]
		public int Scheduleidx { get; set; }
	}
}
