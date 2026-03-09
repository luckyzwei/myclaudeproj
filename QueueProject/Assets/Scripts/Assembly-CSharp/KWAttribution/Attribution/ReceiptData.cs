using Newtonsoft.Json;

namespace KWAttribution.Attribution
{
	public class ReceiptData
	{
		[JsonProperty("orderId")]
		public string OriginalTransactionId { get; set; }

		[JsonProperty("latestOrderId")]
		public string CurrentTransactionId { get; set; }

		[JsonProperty("purchaseState")]
		public string PurchaseState { get; set; }

		[JsonProperty("productId")]
		public string ProductId { get; set; }

		[JsonProperty("purchaseTimeMillis")]
		public string OriginalPurchaseDateMs { get; set; }

		[JsonProperty("startTime")]
		private string StartTime
		{
			set
			{
			}
		}
	}
}
