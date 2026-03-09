using Newtonsoft.Json;

namespace KWAttribution.Attribution
{
	public class ProductData
	{
		[JsonProperty("success")]
		public bool Success { get; set; }

		[JsonProperty("productPurchase")]
		public ReceiptData ReceiptData { get; set; }

		[JsonProperty("subscriptionPurchase")]
		private ReceiptData subscriptionPurchase
		{
			set
			{
			}
		}
	}
}
