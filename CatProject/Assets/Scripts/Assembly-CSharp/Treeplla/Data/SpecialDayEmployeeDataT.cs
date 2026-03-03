using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class SpecialDayEmployeeDataT
	{
		[JsonProperty("employee")]
		public int Employee { get; set; }

		[JsonProperty("specialdayemployee")]
		public int Specialdayemployee { get; set; }
	}
}
