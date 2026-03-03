using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class StorageRowDataT
	{
		[JsonProperty("row")]
		public int Row { get; set; }

		[JsonProperty("treedata")]
		public List<TreeDataT> Treedata { get; set; }
	}
}
