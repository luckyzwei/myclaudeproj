using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class UniqueCustomerDataT
	{
		[JsonProperty("customer")]
		public List<bool> Customer { get; set; }

		[JsonProperty("reddot")]
		public int Reddot { get; set; }
	}
}
