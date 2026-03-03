using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class CeoCostumeOwnedDataT
	{
		[JsonProperty("defaultcostumeidx")]
		public int Defaultcostumeidx { get; set; }

		[JsonProperty("equippedcostumeidx")]
		public int Equippedcostumeidx { get; set; }

		[JsonProperty("ownedcostumeidxlist")]
		public List<CeoCostumeDataT> Ownedcostumeidxlist { get; set; }
	}
}
