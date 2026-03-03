using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class DailyQuestDataT
	{
		[JsonProperty("daypoint")]
		public int Daypoint { get; set; }

		[JsonProperty("weekpoint")]
		public int Weekpoint { get; set; }

		[JsonProperty("dayresettime")]
		public long Dayresettime { get; set; }

		[JsonProperty("weekresettime")]
		public long Weekresettime { get; set; }

		[JsonProperty("completequest")]
		public List<int> Completequest { get; set; }

		[JsonProperty("getrewards")]
		public List<int> Getrewards { get; set; }

		[JsonProperty("getweekrewards")]
		public List<int> Getweekrewards { get; set; }

		[JsonProperty("getweekreplaces")]
		public List<int> Getweekreplaces { get; set; }

		[JsonProperty("quests")]
		public List<KeyValueLongT> Quests { get; set; }
	}
}
