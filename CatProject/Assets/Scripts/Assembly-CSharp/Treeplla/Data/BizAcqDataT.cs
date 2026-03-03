using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class BizAcqDataT
	{
		[JsonProperty("curstageidx")]
		public int Curstageidx { get; set; }

		[JsonProperty("teamdata")]
		public BizAcqTeamDataT Teamdata { get; set; }

		[JsonProperty("lastrewardgettime")]
		public long Lastrewardgettime { get; set; }

		[JsonProperty("laststagecleartime")]
		public long Laststagecleartime { get; set; }

		[JsonProperty("accumulaterewards")]
		public List<CurrencyDataT> Accumulaterewards { get; set; }

		[JsonProperty("autoplayguideshowntime")]
		public long Autoplayguideshowntime { get; set; }

		[JsonProperty("multiplerewardgetcount")]
		public int Multiplerewardgetcount { get; set; }

		[JsonProperty("multiplerewardlastgettime")]
		public long Multiplerewardlastgettime { get; set; }

		[JsonProperty("passreceive")]
		public List<PassReceiveDataT> Passreceive { get; set; }

		[JsonProperty("autoplayon")]
		public bool Autoplayon { get; set; }

		[JsonProperty("battlespeedindex")]
		public int Battlespeedindex { get; set; }

		[JsonProperty("accumulatereinstone")]
		public string Accumulatereinstone { get; set; }

		[JsonProperty("lastrewardaccumulatetime")]
		public long Lastrewardaccumulatetime { get; set; }

		[JsonProperty("weeklyshopshowntime")]
		public long Weeklyshopshowntime { get; set; }

		[JsonProperty("jewelryboxvalue")]
		public string Jewelryboxvalue { get; set; }

		[JsonProperty("jewelryboxlevel")]
		public int Jewelryboxlevel { get; set; }

		[JsonProperty("jewelryboxstagestep")]
		public int Jewelryboxstagestep { get; set; }

		[JsonProperty("jewelryboxstagelastshownstep")]
		public int Jewelryboxstagelastshownstep { get; set; }

		[JsonProperty("activespeedtrial")]
		public bool Activespeedtrial { get; set; }
	}
}
