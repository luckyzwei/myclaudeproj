using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class BizAcquisitionDataT
	{
		[JsonProperty("curstageidx")]
		public int Curstageidx { get; set; }

		[JsonProperty("teamdata")]
		public BizAcquisitionTeamDataT Teamdata { get; set; }
	}
}
