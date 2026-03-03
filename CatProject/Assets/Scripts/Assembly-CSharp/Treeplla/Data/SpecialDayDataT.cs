using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class SpecialDayDataT
	{
		[JsonProperty("specialdayidx")]
		public int Specialdayidx { get; set; }

		[JsonProperty("specialdaydeco")]
		public List<ItemDataT> Specialdaydeco { get; set; }

		[JsonProperty("firstguideview")]
		public bool Firstguideview { get; set; }

		[JsonProperty("specialdayyear")]
		public int Specialdayyear { get; set; }
	}
}
