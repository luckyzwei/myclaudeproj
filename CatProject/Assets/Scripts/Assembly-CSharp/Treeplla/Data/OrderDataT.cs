using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class OrderDataT
	{
		[JsonProperty("estimatedcoin")]
		public int Estimatedcoin { get; set; }

		[JsonProperty("ordersystemstate")]
		public int Ordersystemstate { get; set; }

		[JsonProperty("autoorderstate")]
		public int Autoorderstate { get; set; }

		[JsonProperty("ownedorderdata")]
		public List<OrderInfoT> Ownedorderdata { get; set; }

		[JsonProperty("deliveryorderdata")]
		public OrderInfoT Deliveryorderdata { get; set; }

		[JsonProperty("autoorderdata")]
		public OrderInfoT Autoorderdata { get; set; }

		[JsonProperty("endtime")]
		public long Endtime { get; set; }

		[JsonProperty("autoorderendtime")]
		public long Autoorderendtime { get; set; }
	}
}
