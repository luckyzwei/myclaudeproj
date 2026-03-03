using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct UserData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public string Money => null;

		public int Cash => 0;

		public int Power => 0;

		public int Level => 0;

		public string Buyinappids => null;

		public string Tutorial => null;

		public long Lastlogintime => 0L;

		public int RecordvalueLength => 0;

		public int RecordcountLength => 0;

		public OptionData? Optiondata => null;

		public string Gamenotifications => null;

		public long Firststarttime => 0L;

		public int Stageidx => 0;

		public int CompanylistLength => 0;

		public int CompaniesLength => 0;

		public int OfficesLength => 0;

		public int MissionsLength => 0;

		public long Companyrefreshtime => 0L;

		public int OpenzoneLength => 0;

		public int OpenbuildingLength => 0;

		public RouletteData? Roulette => null;

		public int ChatdatasLength => 0;

		public UserCharData? Chardata => null;

		public BankData? Bankdata => null;

		public OfflineData? Offlinedata => null;

		public long Adsupplytime => 0L;

		public int ItemsLength => 0;

		public int PlantsLength => 0;

		public GemPassData? Gempass => null;

		public ShopData? Shopdata => null;

		public int UnlockcompanyLength => 0;

		public DailyQuestData? Dailyquestdata => null;

		public int BuildingdatasLength => 0;

		public int Point => 0;

		public int CardatasLength => 0;

		public int Equipcar => 0;

		public int CatstadatasLength => 0;

		public int Permission => 0;

		public OneTimeEventData? Onetimeeventdata => null;

		public FactoryData? Factorydata => null;

		public MoneySafeData? Moneysafedata => null;

		public int BuffobjectsLength => 0;

		public long Expadresettime => 0L;

		public int Expadviewcount => 0;

		public InvestData? Investdata => null;

		public int OnetimeeventhistorydataLength => 0;

		public int ParkinglotsLength => 0;

		public InviteData? Invitedata => null;

		public int Abtestdata => 0;

		public int ManagerdataLength => 0;

		public int RegionstagedataLength => 0;

		public int Activeregion => 0;

		public long Commonlastlogintime => 0L;

		public ManagerKeyAddData? Managerkeyadddata => null;

		public RouletteData? Specialdayroulette => null;

		public int SuperstaffLength => 0;

		public SeasonalData? Seasonaldata => null;

		public TarotData? Tarot => null;

		public AuctionData? Auction => null;

		public SpecialDayData? Specialday => null;

		public AdsupplyPiggy? Adsupplypiggy => null;

		public int AbilityinvestdataLength => 0;

		public RichAchieve? Richachieve => null;

		public int CatstaeventdataLength => 0;

		public double Cheataddtimesec => 0.0;

		public int Recommentcompanyidx => 0;

		public AnniversaryEventData? Anniversaryeventdata => null;

		public int AttendanceeventdataLength => 0;

		public int ContentsmissiondataLength => 0;

		public int BuyparkinglotdataLength => 0;

		public RichWayData? Richwaydata => null;

		public BizAcqData? Bizacqdata => null;

		public int CurrencydataLength => 0;

		public int SubmissiondataLength => 0;

		public SegmentData? Segmentdata => null;

		public AdpassData? Adpassdata => null;

		public int BoosterbuffdataLength => 0;

		public int SpecialpackagedataLength => 0;

		public CeoCostumeOwnedData? Ceocostumeowneddata => null;

		public MiniGameData? Minigamedata => null;

		public CompanyListRefreshData? Companylistrefreshdata => null;

		public RegionMissionData? Region1missiondata => null;

		public static void ValidateVersion()
		{
		}

		public static UserData GetRootAsUserData(ByteBuffer _bb)
		{
			return default(UserData);
		}

		public static UserData GetRootAsUserData(ByteBuffer _bb, UserData obj)
		{
			return default(UserData);
		}

		public static bool VerifyUserData(ByteBuffer _bb)
		{
			return false;
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public UserData __assign(int _i, ByteBuffer _bb)
		{
			return default(UserData);
		}

		public ArraySegment<byte>? GetMoneyBytes()
		{
			return null;
		}

		public byte[] GetMoneyArray()
		{
			return null;
		}

		public bool MutateCash(int cash)
		{
			return false;
		}

		public bool MutatePower(int power)
		{
			return false;
		}

		public bool MutateLevel(int level)
		{
			return false;
		}

		public ArraySegment<byte>? GetBuyinappidsBytes()
		{
			return null;
		}

		public byte[] GetBuyinappidsArray()
		{
			return null;
		}

		public ArraySegment<byte>? GetTutorialBytes()
		{
			return null;
		}

		public byte[] GetTutorialArray()
		{
			return null;
		}

		public bool MutateLastlogintime(long lastlogintime)
		{
			return false;
		}

		public RecordValue? Recordvalue(int j)
		{
			return null;
		}

		public RecordCount? Recordcount(int j)
		{
			return null;
		}

		public ArraySegment<byte>? GetGamenotificationsBytes()
		{
			return null;
		}

		public byte[] GetGamenotificationsArray()
		{
			return null;
		}

		public bool MutateFirststarttime(long firststarttime)
		{
			return false;
		}

		public bool MutateStageidx(int stageidx)
		{
			return false;
		}

		public int Companylist(int j)
		{
			return 0;
		}

		public ArraySegment<byte>? GetCompanylistBytes()
		{
			return null;
		}

		public int[] GetCompanylistArray()
		{
			return null;
		}

		public bool MutateCompanylist(int j, int companylist)
		{
			return false;
		}

		public CompanyData? Companies(int j)
		{
			return null;
		}

		public OfficeData? Offices(int j)
		{
			return null;
		}

		public MissionData? Missions(int j)
		{
			return null;
		}

		public bool MutateCompanyrefreshtime(long companyrefreshtime)
		{
			return false;
		}

		public int Openzone(int j)
		{
			return 0;
		}

		public ArraySegment<byte>? GetOpenzoneBytes()
		{
			return null;
		}

		public int[] GetOpenzoneArray()
		{
			return null;
		}

		public bool MutateOpenzone(int j, int openzone)
		{
			return false;
		}

		public int Openbuilding(int j)
		{
			return 0;
		}

		public ArraySegment<byte>? GetOpenbuildingBytes()
		{
			return null;
		}

		public int[] GetOpenbuildingArray()
		{
			return null;
		}

		public bool MutateOpenbuilding(int j, int openbuilding)
		{
			return false;
		}

		public ChatData? Chatdatas(int j)
		{
			return null;
		}

		public bool MutateAdsupplytime(long adsupplytime)
		{
			return false;
		}

		public ItemData? Items(int j)
		{
			return null;
		}

		public PlantData? Plants(int j)
		{
			return null;
		}

		public int Unlockcompany(int j)
		{
			return 0;
		}

		public ArraySegment<byte>? GetUnlockcompanyBytes()
		{
			return null;
		}

		public int[] GetUnlockcompanyArray()
		{
			return null;
		}

		public bool MutateUnlockcompany(int j, int unlockcompany)
		{
			return false;
		}

		public BuildingData? Buildingdatas(int j)
		{
			return null;
		}

		public bool MutatePoint(int point)
		{
			return false;
		}

		public CarData? Cardatas(int j)
		{
			return null;
		}

		public bool MutateEquipcar(int equipcar)
		{
			return false;
		}

		public CatstaData? Catstadatas(int j)
		{
			return null;
		}

		public bool MutatePermission(int permission)
		{
			return false;
		}

		public ItemData? Buffobjects(int j)
		{
			return null;
		}

		public bool MutateExpadresettime(long expadresettime)
		{
			return false;
		}

		public bool MutateExpadviewcount(int expadviewcount)
		{
			return false;
		}

		public OneTimeEventHistoryData? Onetimeeventhistorydata(int j)
		{
			return null;
		}

		public int Parkinglots(int j)
		{
			return 0;
		}

		public ArraySegment<byte>? GetParkinglotsBytes()
		{
			return null;
		}

		public int[] GetParkinglotsArray()
		{
			return null;
		}

		public bool MutateParkinglots(int j, int parkinglots)
		{
			return false;
		}

		public bool MutateAbtestdata(int abtestdata)
		{
			return false;
		}

		public ManagerData? Managerdata(int j)
		{
			return null;
		}

		public RegionStageData? Regionstagedata(int j)
		{
			return null;
		}

		public bool MutateActiveregion(int activeregion)
		{
			return false;
		}

		public bool MutateCommonlastlogintime(long commonlastlogintime)
		{
			return false;
		}

		public SuperStaffData? Superstaff(int j)
		{
			return null;
		}

		public InvestData? Abilityinvestdata(int j)
		{
			return null;
		}

		public CatstaEventData? Catstaeventdata(int j)
		{
			return null;
		}

		public bool MutateCheataddtimesec(double cheataddtimesec)
		{
			return false;
		}

		public bool MutateRecommentcompanyidx(int recommentcompanyidx)
		{
			return false;
		}

		public AttendanceEventData? Attendanceeventdata(int j)
		{
			return null;
		}

		public ContentsMissionData? Contentsmissiondata(int j)
		{
			return null;
		}

		public BuyParkingLotData? Buyparkinglotdata(int j)
		{
			return null;
		}

		public CurrencyData? Currencydata(int j)
		{
			return null;
		}

		public SubMissionData? Submissiondata(int j)
		{
			return null;
		}

		public BoosterBuffData? Boosterbuffdata(int j)
		{
			return null;
		}

		public SpecialPackageData? Specialpackagedata(int j)
		{
			return null;
		}

		public static Offset<UserData> CreateUserData(FlatBufferBuilder builder, StringOffset moneyOffset = default(StringOffset), int cash = 0, int power = 0, int level = 0, StringOffset buyinappidsOffset = default(StringOffset), StringOffset tutorialOffset = default(StringOffset), long lastlogintime = 0L, VectorOffset recordvalueOffset = default(VectorOffset), VectorOffset recordcountOffset = default(VectorOffset), Offset<OptionData> optiondataOffset = default(Offset<OptionData>), StringOffset gamenotificationsOffset = default(StringOffset), long firststarttime = 0L, int stageidx = 0, VectorOffset companylistOffset = default(VectorOffset), VectorOffset companiesOffset = default(VectorOffset), VectorOffset officesOffset = default(VectorOffset), VectorOffset missionsOffset = default(VectorOffset), long companyrefreshtime = 0L, VectorOffset openzoneOffset = default(VectorOffset), VectorOffset openbuildingOffset = default(VectorOffset), Offset<RouletteData> rouletteOffset = default(Offset<RouletteData>), VectorOffset chatdatasOffset = default(VectorOffset), Offset<UserCharData> chardataOffset = default(Offset<UserCharData>), Offset<BankData> bankdataOffset = default(Offset<BankData>), Offset<OfflineData> offlinedataOffset = default(Offset<OfflineData>), long adsupplytime = 0L, VectorOffset itemsOffset = default(VectorOffset), VectorOffset plantsOffset = default(VectorOffset), Offset<GemPassData> gempassOffset = default(Offset<GemPassData>), Offset<ShopData> shopdataOffset = default(Offset<ShopData>), VectorOffset unlockcompanyOffset = default(VectorOffset), Offset<DailyQuestData> dailyquestdataOffset = default(Offset<DailyQuestData>), VectorOffset buildingdatasOffset = default(VectorOffset), int point = 0, VectorOffset cardatasOffset = default(VectorOffset), int equipcar = -1, VectorOffset catstadatasOffset = default(VectorOffset), int permission = 0, Offset<OneTimeEventData> onetimeeventdataOffset = default(Offset<OneTimeEventData>), Offset<FactoryData> factorydataOffset = default(Offset<FactoryData>), Offset<MoneySafeData> moneysafedataOffset = default(Offset<MoneySafeData>), VectorOffset buffobjectsOffset = default(VectorOffset), long expadresettime = 0L, int expadviewcount = 0, Offset<InvestData> investdataOffset = default(Offset<InvestData>), VectorOffset onetimeeventhistorydataOffset = default(VectorOffset), VectorOffset parkinglotsOffset = default(VectorOffset), Offset<InviteData> invitedataOffset = default(Offset<InviteData>), int abtestdata = -1, VectorOffset managerdataOffset = default(VectorOffset), VectorOffset regionstagedataOffset = default(VectorOffset), int activeregion = 1, long commonlastlogintime = 0L, Offset<ManagerKeyAddData> managerkeyadddataOffset = default(Offset<ManagerKeyAddData>), Offset<RouletteData> specialdayrouletteOffset = default(Offset<RouletteData>), VectorOffset superstaffOffset = default(VectorOffset), Offset<SeasonalData> seasonaldataOffset = default(Offset<SeasonalData>), Offset<TarotData> tarotOffset = default(Offset<TarotData>), Offset<AuctionData> auctionOffset = default(Offset<AuctionData>), Offset<SpecialDayData> specialdayOffset = default(Offset<SpecialDayData>), Offset<AdsupplyPiggy> adsupplypiggyOffset = default(Offset<AdsupplyPiggy>), VectorOffset abilityinvestdataOffset = default(VectorOffset), Offset<RichAchieve> richachieveOffset = default(Offset<RichAchieve>), VectorOffset catstaeventdataOffset = default(VectorOffset), double cheataddtimesec = 0.0, int recommentcompanyidx = 0, Offset<AnniversaryEventData> anniversaryeventdataOffset = default(Offset<AnniversaryEventData>), VectorOffset attendanceeventdataOffset = default(VectorOffset), VectorOffset contentsmissiondataOffset = default(VectorOffset), VectorOffset buyparkinglotdataOffset = default(VectorOffset), Offset<RichWayData> richwaydataOffset = default(Offset<RichWayData>), Offset<BizAcqData> bizacqdataOffset = default(Offset<BizAcqData>), VectorOffset currencydataOffset = default(VectorOffset), VectorOffset submissiondataOffset = default(VectorOffset), Offset<SegmentData> segmentdataOffset = default(Offset<SegmentData>), Offset<AdpassData> adpassdataOffset = default(Offset<AdpassData>), VectorOffset boosterbuffdataOffset = default(VectorOffset), VectorOffset specialpackagedataOffset = default(VectorOffset), Offset<CeoCostumeOwnedData> ceocostumeowneddataOffset = default(Offset<CeoCostumeOwnedData>), Offset<MiniGameData> minigamedataOffset = default(Offset<MiniGameData>), Offset<CompanyListRefreshData> companylistrefreshdataOffset = default(Offset<CompanyListRefreshData>), Offset<RegionMissionData> region1missiondataOffset = default(Offset<RegionMissionData>))
		{
			return default(Offset<UserData>);
		}

		public static void StartUserData(FlatBufferBuilder builder)
		{
		}

		public static void AddMoney(FlatBufferBuilder builder, StringOffset moneyOffset)
		{
		}

		public static void AddCash(FlatBufferBuilder builder, int cash)
		{
		}

		public static void AddPower(FlatBufferBuilder builder, int power)
		{
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
		}

		public static void AddBuyinappids(FlatBufferBuilder builder, StringOffset buyinappidsOffset)
		{
		}

		public static void AddTutorial(FlatBufferBuilder builder, StringOffset tutorialOffset)
		{
		}

		public static void AddLastlogintime(FlatBufferBuilder builder, long lastlogintime)
		{
		}

		public static void AddRecordvalue(FlatBufferBuilder builder, VectorOffset recordvalueOffset)
		{
		}

		public static VectorOffset CreateRecordvalueVector(FlatBufferBuilder builder, Offset<RecordValue>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateRecordvalueVectorBlock(FlatBufferBuilder builder, Offset<RecordValue>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateRecordvalueVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<RecordValue>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateRecordvalueVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartRecordvalueVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddRecordcount(FlatBufferBuilder builder, VectorOffset recordcountOffset)
		{
		}

		public static VectorOffset CreateRecordcountVector(FlatBufferBuilder builder, Offset<RecordCount>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateRecordcountVectorBlock(FlatBufferBuilder builder, Offset<RecordCount>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateRecordcountVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<RecordCount>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateRecordcountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartRecordcountVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddOptiondata(FlatBufferBuilder builder, Offset<OptionData> optiondataOffset)
		{
		}

		public static void AddGamenotifications(FlatBufferBuilder builder, StringOffset gamenotificationsOffset)
		{
		}

		public static void AddFirststarttime(FlatBufferBuilder builder, long firststarttime)
		{
		}

		public static void AddStageidx(FlatBufferBuilder builder, int stageidx)
		{
		}

		public static void AddCompanylist(FlatBufferBuilder builder, VectorOffset companylistOffset)
		{
		}

		public static VectorOffset CreateCompanylistVector(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCompanylistVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCompanylistVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCompanylistVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartCompanylistVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddCompanies(FlatBufferBuilder builder, VectorOffset companiesOffset)
		{
		}

		public static VectorOffset CreateCompaniesVector(FlatBufferBuilder builder, Offset<CompanyData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCompaniesVectorBlock(FlatBufferBuilder builder, Offset<CompanyData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCompaniesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<CompanyData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCompaniesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartCompaniesVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddOffices(FlatBufferBuilder builder, VectorOffset officesOffset)
		{
		}

		public static VectorOffset CreateOfficesVector(FlatBufferBuilder builder, Offset<OfficeData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateOfficesVectorBlock(FlatBufferBuilder builder, Offset<OfficeData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateOfficesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<OfficeData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateOfficesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartOfficesVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddMissions(FlatBufferBuilder builder, VectorOffset missionsOffset)
		{
		}

		public static VectorOffset CreateMissionsVector(FlatBufferBuilder builder, Offset<MissionData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateMissionsVectorBlock(FlatBufferBuilder builder, Offset<MissionData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateMissionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<MissionData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateMissionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartMissionsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddCompanyrefreshtime(FlatBufferBuilder builder, long companyrefreshtime)
		{
		}

		public static void AddOpenzone(FlatBufferBuilder builder, VectorOffset openzoneOffset)
		{
		}

		public static VectorOffset CreateOpenzoneVector(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateOpenzoneVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateOpenzoneVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateOpenzoneVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartOpenzoneVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddOpenbuilding(FlatBufferBuilder builder, VectorOffset openbuildingOffset)
		{
		}

		public static VectorOffset CreateOpenbuildingVector(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateOpenbuildingVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateOpenbuildingVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateOpenbuildingVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartOpenbuildingVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddRoulette(FlatBufferBuilder builder, Offset<RouletteData> rouletteOffset)
		{
		}

		public static void AddChatdatas(FlatBufferBuilder builder, VectorOffset chatdatasOffset)
		{
		}

		public static VectorOffset CreateChatdatasVector(FlatBufferBuilder builder, Offset<ChatData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateChatdatasVectorBlock(FlatBufferBuilder builder, Offset<ChatData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateChatdatasVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ChatData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateChatdatasVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartChatdatasVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddChardata(FlatBufferBuilder builder, Offset<UserCharData> chardataOffset)
		{
		}

		public static void AddBankdata(FlatBufferBuilder builder, Offset<BankData> bankdataOffset)
		{
		}

		public static void AddOfflinedata(FlatBufferBuilder builder, Offset<OfflineData> offlinedataOffset)
		{
		}

		public static void AddAdsupplytime(FlatBufferBuilder builder, long adsupplytime)
		{
		}

		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
		}

		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<ItemData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, Offset<ItemData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ItemData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddPlants(FlatBufferBuilder builder, VectorOffset plantsOffset)
		{
		}

		public static VectorOffset CreatePlantsVector(FlatBufferBuilder builder, Offset<PlantData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreatePlantsVectorBlock(FlatBufferBuilder builder, Offset<PlantData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreatePlantsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<PlantData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreatePlantsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartPlantsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddGempass(FlatBufferBuilder builder, Offset<GemPassData> gempassOffset)
		{
		}

		public static void AddShopdata(FlatBufferBuilder builder, Offset<ShopData> shopdataOffset)
		{
		}

		public static void AddUnlockcompany(FlatBufferBuilder builder, VectorOffset unlockcompanyOffset)
		{
		}

		public static VectorOffset CreateUnlockcompanyVector(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateUnlockcompanyVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateUnlockcompanyVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateUnlockcompanyVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartUnlockcompanyVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddDailyquestdata(FlatBufferBuilder builder, Offset<DailyQuestData> dailyquestdataOffset)
		{
		}

		public static void AddBuildingdatas(FlatBufferBuilder builder, VectorOffset buildingdatasOffset)
		{
		}

		public static VectorOffset CreateBuildingdatasVector(FlatBufferBuilder builder, Offset<BuildingData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateBuildingdatasVectorBlock(FlatBufferBuilder builder, Offset<BuildingData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateBuildingdatasVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<BuildingData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateBuildingdatasVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartBuildingdatasVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddPoint(FlatBufferBuilder builder, int point)
		{
		}

		public static void AddCardatas(FlatBufferBuilder builder, VectorOffset cardatasOffset)
		{
		}

		public static VectorOffset CreateCardatasVector(FlatBufferBuilder builder, Offset<CarData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCardatasVectorBlock(FlatBufferBuilder builder, Offset<CarData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCardatasVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<CarData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCardatasVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartCardatasVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddEquipcar(FlatBufferBuilder builder, int equipcar)
		{
		}

		public static void AddCatstadatas(FlatBufferBuilder builder, VectorOffset catstadatasOffset)
		{
		}

		public static VectorOffset CreateCatstadatasVector(FlatBufferBuilder builder, Offset<CatstaData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCatstadatasVectorBlock(FlatBufferBuilder builder, Offset<CatstaData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCatstadatasVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<CatstaData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCatstadatasVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartCatstadatasVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddPermission(FlatBufferBuilder builder, int permission)
		{
		}

		public static void AddOnetimeeventdata(FlatBufferBuilder builder, Offset<OneTimeEventData> onetimeeventdataOffset)
		{
		}

		public static void AddFactorydata(FlatBufferBuilder builder, Offset<FactoryData> factorydataOffset)
		{
		}

		public static void AddMoneysafedata(FlatBufferBuilder builder, Offset<MoneySafeData> moneysafedataOffset)
		{
		}

		public static void AddBuffobjects(FlatBufferBuilder builder, VectorOffset buffobjectsOffset)
		{
		}

		public static VectorOffset CreateBuffobjectsVector(FlatBufferBuilder builder, Offset<ItemData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateBuffobjectsVectorBlock(FlatBufferBuilder builder, Offset<ItemData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateBuffobjectsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ItemData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateBuffobjectsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartBuffobjectsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddExpadresettime(FlatBufferBuilder builder, long expadresettime)
		{
		}

		public static void AddExpadviewcount(FlatBufferBuilder builder, int expadviewcount)
		{
		}

		public static void AddInvestdata(FlatBufferBuilder builder, Offset<InvestData> investdataOffset)
		{
		}

		public static void AddOnetimeeventhistorydata(FlatBufferBuilder builder, VectorOffset onetimeeventhistorydataOffset)
		{
		}

		public static VectorOffset CreateOnetimeeventhistorydataVector(FlatBufferBuilder builder, Offset<OneTimeEventHistoryData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateOnetimeeventhistorydataVectorBlock(FlatBufferBuilder builder, Offset<OneTimeEventHistoryData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateOnetimeeventhistorydataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<OneTimeEventHistoryData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateOnetimeeventhistorydataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartOnetimeeventhistorydataVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddParkinglots(FlatBufferBuilder builder, VectorOffset parkinglotsOffset)
		{
		}

		public static VectorOffset CreateParkinglotsVector(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateParkinglotsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateParkinglotsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateParkinglotsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartParkinglotsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddInvitedata(FlatBufferBuilder builder, Offset<InviteData> invitedataOffset)
		{
		}

		public static void AddAbtestdata(FlatBufferBuilder builder, int abtestdata)
		{
		}

		public static void AddManagerdata(FlatBufferBuilder builder, VectorOffset managerdataOffset)
		{
		}

		public static VectorOffset CreateManagerdataVector(FlatBufferBuilder builder, Offset<ManagerData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateManagerdataVectorBlock(FlatBufferBuilder builder, Offset<ManagerData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateManagerdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ManagerData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateManagerdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartManagerdataVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddRegionstagedata(FlatBufferBuilder builder, VectorOffset regionstagedataOffset)
		{
		}

		public static VectorOffset CreateRegionstagedataVector(FlatBufferBuilder builder, Offset<RegionStageData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateRegionstagedataVectorBlock(FlatBufferBuilder builder, Offset<RegionStageData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateRegionstagedataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<RegionStageData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateRegionstagedataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartRegionstagedataVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddActiveregion(FlatBufferBuilder builder, int activeregion)
		{
		}

		public static void AddCommonlastlogintime(FlatBufferBuilder builder, long commonlastlogintime)
		{
		}

		public static void AddManagerkeyadddata(FlatBufferBuilder builder, Offset<ManagerKeyAddData> managerkeyadddataOffset)
		{
		}

		public static void AddSpecialdayroulette(FlatBufferBuilder builder, Offset<RouletteData> specialdayrouletteOffset)
		{
		}

		public static void AddSuperstaff(FlatBufferBuilder builder, VectorOffset superstaffOffset)
		{
		}

		public static VectorOffset CreateSuperstaffVector(FlatBufferBuilder builder, Offset<SuperStaffData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateSuperstaffVectorBlock(FlatBufferBuilder builder, Offset<SuperStaffData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateSuperstaffVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<SuperStaffData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateSuperstaffVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartSuperstaffVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddSeasonaldata(FlatBufferBuilder builder, Offset<SeasonalData> seasonaldataOffset)
		{
		}

		public static void AddTarot(FlatBufferBuilder builder, Offset<TarotData> tarotOffset)
		{
		}

		public static void AddAuction(FlatBufferBuilder builder, Offset<AuctionData> auctionOffset)
		{
		}

		public static void AddSpecialday(FlatBufferBuilder builder, Offset<SpecialDayData> specialdayOffset)
		{
		}

		public static void AddAdsupplypiggy(FlatBufferBuilder builder, Offset<AdsupplyPiggy> adsupplypiggyOffset)
		{
		}

		public static void AddAbilityinvestdata(FlatBufferBuilder builder, VectorOffset abilityinvestdataOffset)
		{
		}

		public static VectorOffset CreateAbilityinvestdataVector(FlatBufferBuilder builder, Offset<InvestData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateAbilityinvestdataVectorBlock(FlatBufferBuilder builder, Offset<InvestData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateAbilityinvestdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<InvestData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateAbilityinvestdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartAbilityinvestdataVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddRichachieve(FlatBufferBuilder builder, Offset<RichAchieve> richachieveOffset)
		{
		}

		public static void AddCatstaeventdata(FlatBufferBuilder builder, VectorOffset catstaeventdataOffset)
		{
		}

		public static VectorOffset CreateCatstaeventdataVector(FlatBufferBuilder builder, Offset<CatstaEventData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCatstaeventdataVectorBlock(FlatBufferBuilder builder, Offset<CatstaEventData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCatstaeventdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<CatstaEventData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCatstaeventdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartCatstaeventdataVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddCheataddtimesec(FlatBufferBuilder builder, double cheataddtimesec)
		{
		}

		public static void AddRecommentcompanyidx(FlatBufferBuilder builder, int recommentcompanyidx)
		{
		}

		public static void AddAnniversaryeventdata(FlatBufferBuilder builder, Offset<AnniversaryEventData> anniversaryeventdataOffset)
		{
		}

		public static void AddAttendanceeventdata(FlatBufferBuilder builder, VectorOffset attendanceeventdataOffset)
		{
		}

		public static VectorOffset CreateAttendanceeventdataVector(FlatBufferBuilder builder, Offset<AttendanceEventData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateAttendanceeventdataVectorBlock(FlatBufferBuilder builder, Offset<AttendanceEventData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateAttendanceeventdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<AttendanceEventData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateAttendanceeventdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartAttendanceeventdataVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddContentsmissiondata(FlatBufferBuilder builder, VectorOffset contentsmissiondataOffset)
		{
		}

		public static VectorOffset CreateContentsmissiondataVector(FlatBufferBuilder builder, Offset<ContentsMissionData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateContentsmissiondataVectorBlock(FlatBufferBuilder builder, Offset<ContentsMissionData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateContentsmissiondataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ContentsMissionData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateContentsmissiondataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartContentsmissiondataVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddBuyparkinglotdata(FlatBufferBuilder builder, VectorOffset buyparkinglotdataOffset)
		{
		}

		public static VectorOffset CreateBuyparkinglotdataVector(FlatBufferBuilder builder, Offset<BuyParkingLotData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateBuyparkinglotdataVectorBlock(FlatBufferBuilder builder, Offset<BuyParkingLotData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateBuyparkinglotdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<BuyParkingLotData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateBuyparkinglotdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartBuyparkinglotdataVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddRichwaydata(FlatBufferBuilder builder, Offset<RichWayData> richwaydataOffset)
		{
		}

		public static void AddBizacqdata(FlatBufferBuilder builder, Offset<BizAcqData> bizacqdataOffset)
		{
		}

		public static void AddCurrencydata(FlatBufferBuilder builder, VectorOffset currencydataOffset)
		{
		}

		public static VectorOffset CreateCurrencydataVector(FlatBufferBuilder builder, Offset<CurrencyData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCurrencydataVectorBlock(FlatBufferBuilder builder, Offset<CurrencyData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCurrencydataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<CurrencyData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCurrencydataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartCurrencydataVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddSubmissiondata(FlatBufferBuilder builder, VectorOffset submissiondataOffset)
		{
		}

		public static VectorOffset CreateSubmissiondataVector(FlatBufferBuilder builder, Offset<SubMissionData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateSubmissiondataVectorBlock(FlatBufferBuilder builder, Offset<SubMissionData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateSubmissiondataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<SubMissionData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateSubmissiondataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartSubmissiondataVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddSegmentdata(FlatBufferBuilder builder, Offset<SegmentData> segmentdataOffset)
		{
		}

		public static void AddAdpassdata(FlatBufferBuilder builder, Offset<AdpassData> adpassdataOffset)
		{
		}

		public static void AddBoosterbuffdata(FlatBufferBuilder builder, VectorOffset boosterbuffdataOffset)
		{
		}

		public static VectorOffset CreateBoosterbuffdataVector(FlatBufferBuilder builder, Offset<BoosterBuffData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateBoosterbuffdataVectorBlock(FlatBufferBuilder builder, Offset<BoosterBuffData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateBoosterbuffdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<BoosterBuffData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateBoosterbuffdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartBoosterbuffdataVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddSpecialpackagedata(FlatBufferBuilder builder, VectorOffset specialpackagedataOffset)
		{
		}

		public static VectorOffset CreateSpecialpackagedataVector(FlatBufferBuilder builder, Offset<SpecialPackageData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateSpecialpackagedataVectorBlock(FlatBufferBuilder builder, Offset<SpecialPackageData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateSpecialpackagedataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<SpecialPackageData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateSpecialpackagedataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartSpecialpackagedataVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddCeocostumeowneddata(FlatBufferBuilder builder, Offset<CeoCostumeOwnedData> ceocostumeowneddataOffset)
		{
		}

		public static void AddMinigamedata(FlatBufferBuilder builder, Offset<MiniGameData> minigamedataOffset)
		{
		}

		public static void AddCompanylistrefreshdata(FlatBufferBuilder builder, Offset<CompanyListRefreshData> companylistrefreshdataOffset)
		{
		}

		public static void AddRegion1missiondata(FlatBufferBuilder builder, Offset<RegionMissionData> region1missiondataOffset)
		{
		}

		public static Offset<UserData> EndUserData(FlatBufferBuilder builder)
		{
			return default(Offset<UserData>);
		}

		public static void FinishUserDataBuffer(FlatBufferBuilder builder, Offset<UserData> offset)
		{
		}

		public static void FinishSizePrefixedUserDataBuffer(FlatBufferBuilder builder, Offset<UserData> offset)
		{
		}

		public UserDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(UserDataT _o)
		{
		}

		public static Offset<UserData> Pack(FlatBufferBuilder builder, UserDataT _o)
		{
			return default(Offset<UserData>);
		}
	}
}
