using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class ChatDataT
	{
		[JsonProperty("group")]
		public int Group { get; set; }

		[JsonProperty("curchat")]
		public int Curchat { get; set; }

		[JsonProperty("curchatorder")]
		public int Curchatorder { get; set; }

		[JsonProperty("completechat")]
		public List<int> Completechat { get; set; }

		[JsonProperty("isnew")]
		public bool Isnew { get; set; }

		[JsonProperty("nextgrouporder")]
		public int Nextgrouporder { get; set; }

		[JsonProperty("waitchat")]
		public List<int> Waitchat { get; set; }
	}
}
