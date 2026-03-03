using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class PlantDataT
	{
		[JsonProperty("idx")]
		public int Idx { get; set; }

		[JsonProperty("exp")]
		public float Exp { get; set; }

		[JsonProperty("level")]
		public int Level { get; set; }

		[JsonProperty("fulls")]
		public List<KeyValueT> Fulls { get; set; }

		[JsonProperty("count")]
		public int Count { get; set; }

		[JsonProperty("abilitytime")]
		public long Abilitytime { get; set; }

		[JsonProperty("isnew")]
		public bool Isnew { get; set; }
	}
}
