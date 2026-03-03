using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class SeasonalMilestoneDataT
	{
		[JsonProperty("currencyaccumulationvalue")]
		public string Currencyaccumulationvalue { get; set; }

		[JsonProperty("receivedrewardidxlist")]
		public List<int> Receivedrewardidxlist { get; set; }

		[JsonProperty("milestonestepelapsedtimesec")]
		public float Milestonestepelapsedtimesec { get; set; }

		[JsonProperty("receivedpreminumrewardidxlist")]
		public List<int> Receivedpreminumrewardidxlist { get; set; }
	}
}
