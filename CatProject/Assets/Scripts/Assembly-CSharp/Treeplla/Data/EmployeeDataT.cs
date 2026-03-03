using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class EmployeeDataT
	{
		[JsonProperty("seat")]
		public int Seat { get; set; }

		[JsonProperty("idx")]
		public int Idx { get; set; }

		[JsonProperty("viewidx")]
		public int Viewidx { get; set; }
	}
}
