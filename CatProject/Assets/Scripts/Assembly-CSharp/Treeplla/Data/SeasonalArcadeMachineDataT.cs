using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class SeasonalArcadeMachineDataT
	{
		[JsonProperty("level")]
		public int Level { get; set; }

		[JsonProperty("bettingmultiplevalue")]
		public int Bettingmultiplevalue { get; set; }

		[JsonProperty("receivedfirstfixedreward")]
		public bool Receivedfirstfixedreward { get; set; }

		[JsonProperty("roulettecount")]
		public int Roulettecount { get; set; }

		[JsonProperty("usefirstfreechance")]
		public bool Usefirstfreechance { get; set; }

		[JsonProperty("firstfreechancecheckcount")]
		public int Firstfreechancecheckcount { get; set; }
	}
}
