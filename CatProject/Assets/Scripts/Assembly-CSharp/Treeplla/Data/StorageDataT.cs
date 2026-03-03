using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class StorageDataT
	{
		[JsonProperty("index")]
		public int Index { get; set; }

		[JsonProperty("rowdata")]
		public List<StorageRowDataT> Rowdata { get; set; }
	}
}
