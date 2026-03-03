using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class PassReceiveDataT
	{
		[JsonProperty("normal")]
		public List<int> Normal { get; set; }

		[JsonProperty("premium")]
		public List<int> Premium { get; set; }
	}
}
