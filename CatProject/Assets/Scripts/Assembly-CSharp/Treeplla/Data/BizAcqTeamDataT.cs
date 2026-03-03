using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class BizAcqTeamDataT
	{
		[JsonProperty("teamceoidxlist")]
		public List<int> Teamceoidxlist { get; set; }
	}
}
