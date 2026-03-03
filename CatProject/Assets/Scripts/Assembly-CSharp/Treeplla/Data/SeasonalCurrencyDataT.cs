using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class SeasonalCurrencyDataT
	{
		[JsonProperty("currencyidx")]
		public int Currencyidx { get; set; }

		[JsonProperty("currencyvalue")]
		public string Currencyvalue { get; set; }
	}
}
