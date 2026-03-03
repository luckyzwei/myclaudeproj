using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class SeasonalStageDataT
	{
		[JsonProperty("seasoninfoidx")]
		public int Seasoninfoidx { get; set; }

		[JsonProperty("adsupplytime")]
		public long Adsupplytime { get; set; }

		[JsonProperty("currencydata")]
		public List<SeasonalCurrencyDataT> Currencydata { get; set; }

		[JsonProperty("arcademachinedata")]
		public SeasonalArcadeMachineDataT Arcademachinedata { get; set; }

		[JsonProperty("buildingdata")]
		public List<SeasonalBuildingDataT> Buildingdata { get; set; }

		[JsonProperty("milestonedata")]
		public SeasonalMilestoneDataT Milestonedata { get; set; }

		[JsonProperty("skilldata")]
		public List<SeasonalSkillDataT> Skilldata { get; set; }

		[JsonProperty("missiondata")]
		public List<SeasonalMissionDataT> Missiondata { get; set; }

		[JsonProperty("lastlogintime")]
		public long Lastlogintime { get; set; }

		[JsonProperty("adsupplyresettime")]
		public long Adsupplyresettime { get; set; }

		[JsonProperty("adsupplycount")]
		public int Adsupplycount { get; set; }

		[JsonProperty("gamestarttime")]
		public long Gamestarttime { get; set; }

		[JsonProperty("seasonaladsupplypiggy")]
		public AdsupplyPiggyT Seasonaladsupplypiggy { get; set; }

		[JsonProperty("overtimeworkactive")]
		public bool Overtimeworkactive { get; set; }

		[JsonProperty("completerewardlist")]
		public List<int> Completerewardlist { get; set; }

		[JsonProperty("seasonpoint")]
		public int Seasonpoint { get; set; }

		[JsonProperty("workerdata")]
		public List<SeasonalWorkerDataT> Workerdata { get; set; }

		[JsonProperty("distributorproductsdata")]
		public List<SeasonalDistributorProductsDataT> Distributorproductsdata { get; set; }

		[JsonProperty("daystarttime")]
		public long Daystarttime { get; set; }

		[JsonProperty("slotcoinbufftime")]
		public long Slotcoinbufftime { get; set; }

		[JsonProperty("missioncoinbufftime")]
		public long Missioncoinbufftime { get; set; }

		[JsonProperty("useabtest")]
		public bool Useabtest { get; set; }

		[JsonProperty("abtestype")]
		public bool Abtestype { get; set; }

		[JsonProperty("coinrankdata")]
		public SeasonalCoinRankDataT Coinrankdata { get; set; }

		[JsonProperty("isshownseasonendnotice")]
		public bool Isshownseasonendnotice { get; set; }

		[JsonProperty("isshownseasonstartnotice")]
		public bool Isshownseasonstartnotice { get; set; }
	}
}
