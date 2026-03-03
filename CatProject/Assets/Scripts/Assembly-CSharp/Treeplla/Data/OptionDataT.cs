using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class OptionDataT
	{
		[JsonProperty("language")]
		public string Language { get; set; }

		[JsonProperty("bgm")]
		public bool Bgm { get; set; }

		[JsonProperty("effect")]
		public bool Effect { get; set; }

		[JsonProperty("slowgraphic")]
		public bool Slowgraphic { get; set; }

		[JsonProperty("vibration")]
		public bool Vibration { get; set; }

		[JsonProperty("companylvupatonce")]
		public bool Companylvupatonce { get; set; }
	}
}
