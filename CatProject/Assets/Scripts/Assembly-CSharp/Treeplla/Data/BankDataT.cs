using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class BankDataT
	{
		[JsonProperty("moneybanklevel")]
		public int Moneybanklevel { get; set; }

		[JsonProperty("moneybanklevels")]
		public List<KeyValueT> Moneybanklevels { get; set; }
	}
}
