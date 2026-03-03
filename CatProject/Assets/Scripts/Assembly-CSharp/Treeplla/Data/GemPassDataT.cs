using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class GemPassDataT
	{
		[JsonProperty("normal")]
		public List<int> Normal { get; set; }

		[JsonProperty("premium")]
		public List<int> Premium { get; set; }
	}
}
