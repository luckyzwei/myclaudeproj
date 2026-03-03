using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class AttendanceDataT
	{
		[JsonProperty("eventtype")]
		public int Eventtype { get; set; }

		[JsonProperty("dayindx")]
		public int Dayindx { get; set; }

		[JsonProperty("isattended")]
		public bool Isattended { get; set; }
	}
}
