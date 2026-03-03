using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class SpecialPackageDataT
	{
		[JsonProperty("idx")]
		public int Idx { get; set; }

		[JsonProperty("expire")]
		public bool Expire { get; set; }

		[JsonProperty("param")]
		public List<int> Param { get; set; }

		[JsonProperty("purchase")]
		public bool Purchase { get; set; }

		[JsonProperty("limitttime")]
		public long Limitttime { get; set; }

		[JsonProperty("packageofferdata")]
		public List<PackageOfferDataT> Packageofferdata { get; set; }
	}
}
