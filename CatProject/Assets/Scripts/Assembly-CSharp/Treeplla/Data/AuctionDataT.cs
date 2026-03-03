using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class AuctionDataT
	{
		[JsonProperty("stamina")]
		public int Stamina { get; set; }

		[JsonProperty("staminachargetime")]
		public long Staminachargetime { get; set; }

		[JsonProperty("staminafreetime")]
		public long Staminafreetime { get; set; }

		[JsonProperty("staminaadtime")]
		public long Staminaadtime { get; set; }

		[JsonProperty("staminaadview")]
		public int Staminaadview { get; set; }

		[JsonProperty("passactive")]
		public bool Passactive { get; set; }

		[JsonProperty("passreceivelist")]
		public List<int> Passreceivelist { get; set; }

		[JsonProperty("passpremiumreceivelist")]
		public List<int> Passpremiumreceivelist { get; set; }

		[JsonProperty("organizemanager")]
		public List<KeyValueT> Organizemanager { get; set; }

		[JsonProperty("organizecoin")]
		public List<KeyValueT> Organizecoin { get; set; }

		[JsonProperty("enemyidx")]
		public int Enemyidx { get; set; }

		[JsonProperty("enemys")]
		public List<int> Enemys { get; set; }

		[JsonProperty("level")]
		public int Level { get; set; }

		[JsonProperty("tier")]
		public int Tier { get; set; }

		[JsonProperty("firstguideview")]
		public bool Firstguideview { get; set; }

		[JsonProperty("score")]
		public int Score { get; set; }

		[JsonProperty("firstguideview2")]
		public bool Firstguideview2 { get; set; }

		[JsonProperty("usecoin")]
		public int Usecoin { get; set; }

		[JsonProperty("passpremiumbonusreceived")]
		public bool Passpremiumbonusreceived { get; set; }

		[JsonProperty("eventidx")]
		public int Eventidx { get; set; }
	}
}
