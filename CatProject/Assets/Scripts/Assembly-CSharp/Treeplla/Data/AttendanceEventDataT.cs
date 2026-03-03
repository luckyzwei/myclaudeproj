using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class AttendanceEventDataT
	{
		[JsonProperty("eventidx")]
		public int Eventidx { get; set; }

		[JsonProperty("eventtype")]
		public int Eventtype { get; set; }

		[JsonProperty("attendancedata")]
		public List<AttendanceDataT> Attendancedata { get; set; }

		[JsonProperty("lastshowntime")]
		public long Lastshowntime { get; set; }
	}
}
