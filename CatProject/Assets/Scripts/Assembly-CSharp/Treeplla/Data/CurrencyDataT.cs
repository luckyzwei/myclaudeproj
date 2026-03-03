using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class CurrencyDataT
	{
		[JsonProperty("currencyid")]
		public int Currencyid { get; set; }

		[JsonProperty("value")]
		public string Value { get; set; }
	}
}
