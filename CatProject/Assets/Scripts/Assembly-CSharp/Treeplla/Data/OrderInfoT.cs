using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class OrderInfoT
	{
		[JsonProperty("rewardtype")]
		public int Rewardtype { get; set; }

		[JsonProperty("ordertype")]
		public int Ordertype { get; set; }

		[JsonProperty("orderstate")]
		public int Orderstate { get; set; }

		[JsonProperty("profilepath")]
		public int Profilepath { get; set; }

		[JsonProperty("ordermentionidx")]
		public int Ordermentionidx { get; set; }

		[JsonProperty("refusementionidx")]
		public int Refusementionidx { get; set; }

		[JsonProperty("treegrade")]
		public int Treegrade { get; set; }

		[JsonProperty("treecount")]
		public int Treecount { get; set; }

		[JsonProperty("rewardcoin")]
		public int Rewardcoin { get; set; }

		[JsonProperty("rewardbiz")]
		public int Rewardbiz { get; set; }

		[JsonProperty("rewardnail")]
		public int Rewardnail { get; set; }

		[JsonProperty("rewardpaint")]
		public int Rewardpaint { get; set; }

		[JsonProperty("estimatedvalue")]
		public int Estimatedvalue { get; set; }
	}
}
