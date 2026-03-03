using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class VehicleDataT
	{
		[JsonProperty("index")]
		public int Index { get; set; }

		[JsonProperty("level")]
		public int Level { get; set; }

		[JsonProperty("rowdata")]
		public List<StorageRowDataT> Rowdata { get; set; }
	}
}
