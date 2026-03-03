using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class UserDataT
	{
		[JsonProperty("money")]
		public string Money { get; set; }

		[JsonProperty("cash")]
		public int Cash { get; set; }

		[JsonProperty("power")]
		public int Power { get; set; }

		[JsonProperty("level")]
		public int Level { get; set; }

		[JsonProperty("buyinappids")]
		public string Buyinappids { get; set; }

		[JsonProperty("tutorial")]
		public string Tutorial { get; set; }

		[JsonProperty("lastlogintime")]
		public long Lastlogintime { get; set; }

		[JsonProperty("recordvalue")]
		public List<RecordValueT> Recordvalue { get; set; }

		[JsonProperty("recordcount")]
		public List<RecordCountT> Recordcount { get; set; }

		[JsonProperty("optiondata")]
		public OptionDataT Optiondata { get; set; }

		[JsonProperty("gamenotifications")]
		public string Gamenotifications { get; set; }

		[JsonProperty("firststarttime")]
		public long Firststarttime { get; set; }

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

		[JsonProperty("companyrefreshtime")]
		public long Companyrefreshtime { get; set; }

		[JsonProperty("openzone")]
		public List<int> Openzone { get; set; }

		[JsonProperty("openbuilding")]
		public List<int> Openbuilding { get; set; }

		[JsonProperty("roulette")]
		public RouletteDataT Roulette { get; set; }

		[JsonProperty("chatdatas")]
		public List<ChatDataT> Chatdatas { get; set; }

		[JsonProperty("chardata")]
		public UserCharDataT Chardata { get; set; }

		[JsonProperty("bankdata")]
		public BankDataT Bankdata { get; set; }

		[JsonProperty("offlinedata")]
		public OfflineDataT Offlinedata { get; set; }

		[JsonProperty("adsupplytime")]
		public long Adsupplytime { get; set; }

		[JsonProperty("items")]
		public List<ItemDataT> Items { get; set; }

		[JsonProperty("plants")]
		public List<PlantDataT> Plants { get; set; }

		[JsonProperty("gempass")]
		public GemPassDataT Gempass { get; set; }

		[JsonProperty("shopdata")]
		public ShopDataT Shopdata { get; set; }

		[JsonProperty("unlockcompany")]
		public List<int> Unlockcompany { get; set; }

		[JsonProperty("dailyquestdata")]
		public DailyQuestDataT Dailyquestdata { get; set; }

		[JsonProperty("buildingdatas")]
		public List<BuildingDataT> Buildingdatas { get; set; }

		[JsonProperty("point")]
		public int Point { get; set; }

		[JsonProperty("cardatas")]
		public List<CarDataT> Cardatas { get; set; }

		[JsonProperty("equipcar")]
		public int Equipcar { get; set; }

		[JsonProperty("catstadatas")]
		public List<CatstaDataT> Catstadatas { get; set; }

		[JsonProperty("permission")]
		public int Permission { get; set; }

		[JsonProperty("onetimeeventdata")]
		public OneTimeEventDataT Onetimeeventdata { get; set; }

		[JsonProperty("factorydata")]
		public FactoryDataT Factorydata { get; set; }

		[JsonProperty("moneysafedata")]
		public MoneySafeDataT Moneysafedata { get; set; }

		[JsonProperty("buffobjects")]
		public List<ItemDataT> Buffobjects { get; set; }

		[JsonProperty("expadresettime")]
		public long Expadresettime { get; set; }

		[JsonProperty("expadviewcount")]
		public int Expadviewcount { get; set; }

		[JsonProperty("investdata")]
		public InvestDataT Investdata { get; set; }

		[JsonProperty("onetimeeventhistorydata")]
		public List<OneTimeEventHistoryDataT> Onetimeeventhistorydata { get; set; }

		[JsonProperty("parkinglots")]
		public List<int> Parkinglots { get; set; }

		[JsonProperty("invitedata")]
		public InviteDataT Invitedata { get; set; }

		[JsonProperty("abtestdata")]
		public int Abtestdata { get; set; }

		[JsonProperty("managerdata")]
		public List<ManagerDataT> Managerdata { get; set; }

		[JsonProperty("regionstagedata")]
		public List<RegionStageDataT> Regionstagedata { get; set; }

		[JsonProperty("activeregion")]
		public int Activeregion { get; set; }

		[JsonProperty("commonlastlogintime")]
		public long Commonlastlogintime { get; set; }

		[JsonProperty("managerkeyadddata")]
		public ManagerKeyAddDataT Managerkeyadddata { get; set; }

		[JsonProperty("specialdayroulette")]
		public RouletteDataT Specialdayroulette { get; set; }

		[JsonProperty("superstaff")]
		public List<SuperStaffDataT> Superstaff { get; set; }

		[JsonProperty("seasonaldata")]
		public SeasonalDataT Seasonaldata { get; set; }

		[JsonProperty("tarot")]
		public TarotDataT Tarot { get; set; }

		[JsonProperty("auction")]
		public AuctionDataT Auction { get; set; }

		[JsonProperty("specialday")]
		public SpecialDayDataT Specialday { get; set; }

		[JsonProperty("adsupplypiggy")]
		public AdsupplyPiggyT Adsupplypiggy { get; set; }

		[JsonProperty("abilityinvestdata")]
		public List<InvestDataT> Abilityinvestdata { get; set; }

		[JsonProperty("richachieve")]
		public RichAchieveT Richachieve { get; set; }

		[JsonProperty("catstaeventdata")]
		public List<CatstaEventDataT> Catstaeventdata { get; set; }

		[JsonProperty("cheataddtimesec")]
		public double Cheataddtimesec { get; set; }

		[JsonProperty("recommentcompanyidx")]
		public int Recommentcompanyidx { get; set; }

		[JsonProperty("anniversaryeventdata")]
		public AnniversaryEventDataT Anniversaryeventdata { get; set; }

		[JsonProperty("attendanceeventdata")]
		public List<AttendanceEventDataT> Attendanceeventdata { get; set; }

		[JsonProperty("contentsmissiondata")]
		public List<ContentsMissionDataT> Contentsmissiondata { get; set; }

		[JsonProperty("buyparkinglotdata")]
		public List<BuyParkingLotDataT> Buyparkinglotdata { get; set; }

		[JsonProperty("richwaydata")]
		public RichWayDataT Richwaydata { get; set; }

		[JsonProperty("bizacqdata")]
		public BizAcqDataT Bizacqdata { get; set; }

		[JsonProperty("currencydata")]
		public List<CurrencyDataT> Currencydata { get; set; }

		[JsonProperty("submissiondata")]
		public List<SubMissionDataT> Submissiondata { get; set; }

		[JsonProperty("segmentdata")]
		public SegmentDataT Segmentdata { get; set; }

		[JsonProperty("adpassdata")]
		public AdpassDataT Adpassdata { get; set; }

		[JsonProperty("boosterbuffdata")]
		public List<BoosterBuffDataT> Boosterbuffdata { get; set; }

		[JsonProperty("specialpackagedata")]
		public List<SpecialPackageDataT> Specialpackagedata { get; set; }

		[JsonProperty("ceocostumeowneddata")]
		public CeoCostumeOwnedDataT Ceocostumeowneddata { get; set; }

		[JsonProperty("minigamedata")]
		public MiniGameDataT Minigamedata { get; set; }

		[JsonProperty("companylistrefreshdata")]
		public CompanyListRefreshDataT Companylistrefreshdata { get; set; }

		[JsonProperty("region1missiondata")]
		public RegionMissionDataT Region1missiondata { get; set; }

		public static UserDataT DeserializeFromJson(string jsonText)
		{
			return null;
		}

		public string SerializeToJson()
		{
			return null;
		}

		public static UserDataT DeserializeFromBinary(byte[] fbBuffer)
		{
			return null;
		}

		public byte[] SerializeToBinary()
		{
			return null;
		}
	}
}
