using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class RegionStageDataT
	{
		[JsonProperty("region")]
		public int Region { get; set; }

		[JsonProperty("money")]
		public string Money { get; set; }

		[JsonProperty("power")]
		public int Power { get; set; }

		[JsonProperty("lastlogintime")]
		public long Lastlogintime { get; set; }

		[JsonProperty("stageidx")]
		public int Stageidx { get; set; }

		[JsonProperty("companylist")]
		public List<int> Companylist { get; set; }

		[JsonProperty("companies")]
		public List<CompanyDataT> Companies { get; set; }

		[JsonProperty("offices")]
		public List<OfficeDataT> Offices { get; set; }

		[JsonProperty("missions")]
		public List<MissionDataT> Missions { get; set; }

		[JsonProperty("offlinedata")]
		public OfflineDataT Offlinedata { get; set; }

		[JsonProperty("unlockcompany")]
		public List<int> Unlockcompany { get; set; }

		[JsonProperty("moneysafedata")]
		public MoneySafeDataT Moneysafedata { get; set; }

		[JsonProperty("investdata")]
		public InvestDataT Investdata { get; set; }

		[JsonProperty("equipcar")]
		public int Equipcar { get; set; }

		[JsonProperty("point")]
		public int Point { get; set; }

		[JsonProperty("abilityinvestdata")]
		public List<InvestDataT> Abilityinvestdata { get; set; }

		[JsonProperty("recommentcompanyidx")]
		public int Recommentcompanyidx { get; set; }

		[JsonProperty("buyparkinglotdata")]
		public List<BuyParkingLotDataT> Buyparkinglotdata { get; set; }

		[JsonProperty("richwaydata")]
		public RichWayDataT Richwaydata { get; set; }

		[JsonProperty("regionmissiondata")]
		public RegionMissionDataT Regionmissiondata { get; set; }
	}
}
