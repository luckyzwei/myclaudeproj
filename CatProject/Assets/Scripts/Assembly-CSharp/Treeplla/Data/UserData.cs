using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct UserData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public string Money { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }

		public int Cash { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Power { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Level { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public string Buyinappids { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }

		public string Tutorial { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }

		public long Lastlogintime { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public int RecordvalueLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int RecordcountLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }

		public OptionData? Optiondata { get { int o = __p.__offset(22); return o != 0 ? (new OptionData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public string Gamenotifications { get { int o = __p.__offset(24); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }

		public long Firststarttime { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public int Stageidx { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int CompanylistLength { get { int o = __p.__offset(30); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int CompaniesLength { get { int o = __p.__offset(32); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int OfficesLength { get { int o = __p.__offset(34); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int MissionsLength { get { int o = __p.__offset(36); return o != 0 ? __p.__vector_len(o) : 0; } }

		public long Companyrefreshtime { get { int o = __p.__offset(38); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public int OpenzoneLength { get { int o = __p.__offset(40); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int OpenbuildingLength { get { int o = __p.__offset(42); return o != 0 ? __p.__vector_len(o) : 0; } }

		public RouletteData? Roulette { get { int o = __p.__offset(44); return o != 0 ? (new RouletteData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public int ChatdatasLength { get { int o = __p.__offset(46); return o != 0 ? __p.__vector_len(o) : 0; } }

		public UserCharData? Chardata { get { int o = __p.__offset(48); return o != 0 ? (new UserCharData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public BankData? Bankdata { get { int o = __p.__offset(50); return o != 0 ? (new BankData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public OfflineData? Offlinedata { get { int o = __p.__offset(52); return o != 0 ? (new OfflineData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public long Adsupplytime { get { int o = __p.__offset(54); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public int ItemsLength { get { int o = __p.__offset(56); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int PlantsLength { get { int o = __p.__offset(58); return o != 0 ? __p.__vector_len(o) : 0; } }

		public GemPassData? Gempass { get { int o = __p.__offset(60); return o != 0 ? (new GemPassData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public ShopData? Shopdata { get { int o = __p.__offset(62); return o != 0 ? (new ShopData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public int UnlockcompanyLength { get { int o = __p.__offset(64); return o != 0 ? __p.__vector_len(o) : 0; } }

		public DailyQuestData? Dailyquestdata { get { int o = __p.__offset(66); return o != 0 ? (new DailyQuestData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public int BuildingdatasLength { get { int o = __p.__offset(68); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int Point { get { int o = __p.__offset(70); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int CardatasLength { get { int o = __p.__offset(72); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int Equipcar { get { int o = __p.__offset(74); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int CatstadatasLength { get { int o = __p.__offset(76); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int Permission { get { int o = __p.__offset(78); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public OneTimeEventData? Onetimeeventdata { get { int o = __p.__offset(80); return o != 0 ? (new OneTimeEventData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public FactoryData? Factorydata { get { int o = __p.__offset(82); return o != 0 ? (new FactoryData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public MoneySafeData? Moneysafedata { get { int o = __p.__offset(84); return o != 0 ? (new MoneySafeData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public int BuffobjectsLength { get { int o = __p.__offset(86); return o != 0 ? __p.__vector_len(o) : 0; } }

		public long Expadresettime { get { int o = __p.__offset(88); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public int Expadviewcount { get { int o = __p.__offset(90); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public InvestData? Investdata { get { int o = __p.__offset(92); return o != 0 ? (new InvestData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public int OnetimeeventhistorydataLength { get { int o = __p.__offset(94); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int ParkinglotsLength { get { int o = __p.__offset(96); return o != 0 ? __p.__vector_len(o) : 0; } }

		public InviteData? Invitedata { get { int o = __p.__offset(98); return o != 0 ? (new InviteData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public int Abtestdata { get { int o = __p.__offset(100); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int ManagerdataLength { get { int o = __p.__offset(102); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int RegionstagedataLength { get { int o = __p.__offset(104); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int Activeregion { get { int o = __p.__offset(106); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public long Commonlastlogintime { get { int o = __p.__offset(108); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public ManagerKeyAddData? Managerkeyadddata { get { int o = __p.__offset(110); return o != 0 ? (new ManagerKeyAddData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public RouletteData? Specialdayroulette { get { int o = __p.__offset(112); return o != 0 ? (new RouletteData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public int SuperstaffLength { get { int o = __p.__offset(114); return o != 0 ? __p.__vector_len(o) : 0; } }

		public SeasonalData? Seasonaldata { get { int o = __p.__offset(116); return o != 0 ? (new SeasonalData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public TarotData? Tarot { get { int o = __p.__offset(118); return o != 0 ? (new TarotData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public AuctionData? Auction { get { int o = __p.__offset(120); return o != 0 ? (new AuctionData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public SpecialDayData? Specialday { get { int o = __p.__offset(122); return o != 0 ? (new SpecialDayData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public AdsupplyPiggy? Adsupplypiggy { get { int o = __p.__offset(124); return o != 0 ? (new AdsupplyPiggy()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public int AbilityinvestdataLength { get { int o = __p.__offset(126); return o != 0 ? __p.__vector_len(o) : 0; } }

		public RichAchieve? Richachieve { get { int o = __p.__offset(128); return o != 0 ? (new RichAchieve()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public int CatstaeventdataLength { get { int o = __p.__offset(130); return o != 0 ? __p.__vector_len(o) : 0; } }

		public double Cheataddtimesec { get { int o = __p.__offset(132); return o != 0 ? __p.bb.GetDouble(o + __p.bb_pos) : (double)0.0; } }

		public int Recommentcompanyidx { get { int o = __p.__offset(134); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public AnniversaryEventData? Anniversaryeventdata { get { int o = __p.__offset(136); return o != 0 ? (new AnniversaryEventData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public int AttendanceeventdataLength { get { int o = __p.__offset(138); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int ContentsmissiondataLength { get { int o = __p.__offset(140); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int BuyparkinglotdataLength { get { int o = __p.__offset(142); return o != 0 ? __p.__vector_len(o) : 0; } }

		public RichWayData? Richwaydata { get { int o = __p.__offset(144); return o != 0 ? (new RichWayData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public BizAcqData? Bizacqdata { get { int o = __p.__offset(146); return o != 0 ? (new BizAcqData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public int CurrencydataLength { get { int o = __p.__offset(148); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int SubmissiondataLength { get { int o = __p.__offset(150); return o != 0 ? __p.__vector_len(o) : 0; } }

		public SegmentData? Segmentdata { get { int o = __p.__offset(152); return o != 0 ? (new SegmentData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public AdpassData? Adpassdata { get { int o = __p.__offset(154); return o != 0 ? (new AdpassData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public int BoosterbuffdataLength { get { int o = __p.__offset(156); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int SpecialpackagedataLength { get { int o = __p.__offset(158); return o != 0 ? __p.__vector_len(o) : 0; } }

		public CeoCostumeOwnedData? Ceocostumeowneddata { get { int o = __p.__offset(160); return o != 0 ? (new CeoCostumeOwnedData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public MiniGameData? Minigamedata { get { int o = __p.__offset(162); return o != 0 ? (new MiniGameData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public CompanyListRefreshData? Companylistrefreshdata { get { int o = __p.__offset(164); return o != 0 ? (new CompanyListRefreshData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public RegionMissionData? Region1missiondata { get { int o = __p.__offset(166); return o != 0 ? (new RegionMissionData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static UserData GetRootAsUserData(ByteBuffer _bb)
		{
			return GetRootAsUserData(_bb, new UserData());
		}

		public static UserData GetRootAsUserData(ByteBuffer _bb, UserData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public static bool VerifyUserData(ByteBuffer _bb)
		{
			return false;
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public UserData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public ArraySegment<byte>? GetMoneyBytes()
		{
			return __p.__vector_as_arraysegment(4);
		}

		public byte[] GetMoneyArray()
		{
			return __p.__vector_as_array<byte>(4);
		}

		public bool MutateCash(int cash)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, cash);
				return true;
			}
			return false;
		}

		public bool MutatePower(int power)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, power);
				return true;
			}
			return false;
		}

		public bool MutateLevel(int level)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, level);
				return true;
			}
			return false;
		}

		public ArraySegment<byte>? GetBuyinappidsBytes()
		{
			return __p.__vector_as_arraysegment(12);
		}

		public byte[] GetBuyinappidsArray()
		{
			return __p.__vector_as_array<byte>(12);
		}

		public ArraySegment<byte>? GetTutorialBytes()
		{
			return __p.__vector_as_arraysegment(14);
		}

		public byte[] GetTutorialArray()
		{
			return __p.__vector_as_array<byte>(14);
		}

		public bool MutateLastlogintime(long lastlogintime)
		{
			int o = __p.__offset(16);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, lastlogintime);
				return true;
			}
			return false;
		}

		public RecordValue? Recordvalue(int j)
		{
			int o = __p.__offset(18);
			return o != 0 ? (new RecordValue()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public RecordCount? Recordcount(int j)
		{
			int o = __p.__offset(20);
			return o != 0 ? (new RecordCount()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public ArraySegment<byte>? GetGamenotificationsBytes()
		{
			return __p.__vector_as_arraysegment(24);
		}

		public byte[] GetGamenotificationsArray()
		{
			return __p.__vector_as_array<byte>(24);
		}

		public bool MutateFirststarttime(long firststarttime)
		{
			int o = __p.__offset(26);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, firststarttime);
				return true;
			}
			return false;
		}

		public bool MutateStageidx(int stageidx)
		{
			int o = __p.__offset(28);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, stageidx);
				return true;
			}
			return false;
		}

		public int Companylist(int j)
		{
			int o = __p.__offset(30);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetCompanylistBytes()
		{
			return __p.__vector_as_arraysegment(172);
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
			int o = __p.__offset(32);
			return o != 0 ? (new CompanyData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public OfficeData? Offices(int j)
		{
			int o = __p.__offset(34);
			return o != 0 ? (new OfficeData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public MissionData? Missions(int j)
		{
			int o = __p.__offset(36);
			return o != 0 ? (new MissionData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public bool MutateCompanyrefreshtime(long companyrefreshtime)
		{
			int o = __p.__offset(38);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, companyrefreshtime);
				return true;
			}
			return false;
		}

		public int Openzone(int j)
		{
			int o = __p.__offset(40);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetOpenzoneBytes()
		{
			return __p.__vector_as_arraysegment(180);
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
			int o = __p.__offset(42);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetOpenbuildingBytes()
		{
			return __p.__vector_as_arraysegment(182);
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
			int o = __p.__offset(46);
			return o != 0 ? (new ChatData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public bool MutateAdsupplytime(long adsupplytime)
		{
			int o = __p.__offset(54);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, adsupplytime);
				return true;
			}
			return false;
		}

		public ItemData? Items(int j)
		{
			int o = __p.__offset(56);
			return o != 0 ? (new ItemData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public PlantData? Plants(int j)
		{
			int o = __p.__offset(58);
			return o != 0 ? (new PlantData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public int Unlockcompany(int j)
		{
			int o = __p.__offset(64);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetUnlockcompanyBytes()
		{
			return __p.__vector_as_arraysegment(190);
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
			int o = __p.__offset(68);
			return o != 0 ? (new BuildingData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public bool MutatePoint(int point)
		{
			int o = __p.__offset(70);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, point);
				return true;
			}
			return false;
		}

		public CarData? Cardatas(int j)
		{
			int o = __p.__offset(72);
			return o != 0 ? (new CarData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public bool MutateEquipcar(int equipcar)
		{
			int o = __p.__offset(74);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, equipcar);
				return true;
			}
			return false;
		}

		public CatstaData? Catstadatas(int j)
		{
			int o = __p.__offset(76);
			return o != 0 ? (new CatstaData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public bool MutatePermission(int permission)
		{
			int o = __p.__offset(78);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, permission);
				return true;
			}
			return false;
		}

		public ItemData? Buffobjects(int j)
		{
			int o = __p.__offset(86);
			return o != 0 ? (new ItemData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public bool MutateExpadresettime(long expadresettime)
		{
			int o = __p.__offset(88);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, expadresettime);
				return true;
			}
			return false;
		}

		public bool MutateExpadviewcount(int expadviewcount)
		{
			int o = __p.__offset(90);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, expadviewcount);
				return true;
			}
			return false;
		}

		public OneTimeEventHistoryData? Onetimeeventhistorydata(int j)
		{
			int o = __p.__offset(94);
			return o != 0 ? (new OneTimeEventHistoryData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public int Parkinglots(int j)
		{
			int o = __p.__offset(96);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetParkinglotsBytes()
		{
			return __p.__vector_as_arraysegment(202);
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
			int o = __p.__offset(100);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, abtestdata);
				return true;
			}
			return false;
		}

		public ManagerData? Managerdata(int j)
		{
			int o = __p.__offset(102);
			return o != 0 ? (new ManagerData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public RegionStageData? Regionstagedata(int j)
		{
			int o = __p.__offset(104);
			return o != 0 ? (new RegionStageData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public bool MutateActiveregion(int activeregion)
		{
			int o = __p.__offset(106);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, activeregion);
				return true;
			}
			return false;
		}

		public bool MutateCommonlastlogintime(long commonlastlogintime)
		{
			int o = __p.__offset(108);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, commonlastlogintime);
				return true;
			}
			return false;
		}

		public SuperStaffData? Superstaff(int j)
		{
			int o = __p.__offset(114);
			return o != 0 ? (new SuperStaffData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public InvestData? Abilityinvestdata(int j)
		{
			int o = __p.__offset(126);
			return o != 0 ? (new InvestData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public CatstaEventData? Catstaeventdata(int j)
		{
			int o = __p.__offset(130);
			return o != 0 ? (new CatstaEventData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public bool MutateCheataddtimesec(double cheataddtimesec)
		{
			int o = __p.__offset(132);
			if (o != 0)
			{
				__p.bb.PutDouble(o + __p.bb_pos, cheataddtimesec);
				return true;
			}
			return false;
		}

		public bool MutateRecommentcompanyidx(int recommentcompanyidx)
		{
			int o = __p.__offset(134);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, recommentcompanyidx);
				return true;
			}
			return false;
		}

		public AttendanceEventData? Attendanceeventdata(int j)
		{
			int o = __p.__offset(138);
			return o != 0 ? (new AttendanceEventData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public ContentsMissionData? Contentsmissiondata(int j)
		{
			int o = __p.__offset(140);
			return o != 0 ? (new ContentsMissionData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public BuyParkingLotData? Buyparkinglotdata(int j)
		{
			int o = __p.__offset(142);
			return o != 0 ? (new BuyParkingLotData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public CurrencyData? Currencydata(int j)
		{
			int o = __p.__offset(148);
			return o != 0 ? (new CurrencyData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public SubMissionData? Submissiondata(int j)
		{
			int o = __p.__offset(150);
			return o != 0 ? (new SubMissionData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public BoosterBuffData? Boosterbuffdata(int j)
		{
			int o = __p.__offset(156);
			return o != 0 ? (new BoosterBuffData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public SpecialPackageData? Specialpackagedata(int j)
		{
			int o = __p.__offset(158);
			return o != 0 ? (new SpecialPackageData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public static Offset<UserData> CreateUserData(FlatBufferBuilder builder, StringOffset moneyOffset = default(StringOffset), int cash = 0, int power = 0, int level = 0, StringOffset buyinappidsOffset = default(StringOffset), StringOffset tutorialOffset = default(StringOffset), long lastlogintime = 0L, VectorOffset recordvalueOffset = default(VectorOffset), VectorOffset recordcountOffset = default(VectorOffset), Offset<OptionData> optiondataOffset = default(Offset<OptionData>), StringOffset gamenotificationsOffset = default(StringOffset), long firststarttime = 0L, int stageidx = 0, VectorOffset companylistOffset = default(VectorOffset), VectorOffset companiesOffset = default(VectorOffset), VectorOffset officesOffset = default(VectorOffset), VectorOffset missionsOffset = default(VectorOffset), long companyrefreshtime = 0L, VectorOffset openzoneOffset = default(VectorOffset), VectorOffset openbuildingOffset = default(VectorOffset), Offset<RouletteData> rouletteOffset = default(Offset<RouletteData>), VectorOffset chatdatasOffset = default(VectorOffset), Offset<UserCharData> chardataOffset = default(Offset<UserCharData>), Offset<BankData> bankdataOffset = default(Offset<BankData>), Offset<OfflineData> offlinedataOffset = default(Offset<OfflineData>), long adsupplytime = 0L, VectorOffset itemsOffset = default(VectorOffset), VectorOffset plantsOffset = default(VectorOffset), Offset<GemPassData> gempassOffset = default(Offset<GemPassData>), Offset<ShopData> shopdataOffset = default(Offset<ShopData>), VectorOffset unlockcompanyOffset = default(VectorOffset), Offset<DailyQuestData> dailyquestdataOffset = default(Offset<DailyQuestData>), VectorOffset buildingdatasOffset = default(VectorOffset), int point = 0, VectorOffset cardatasOffset = default(VectorOffset), int equipcar = -1, VectorOffset catstadatasOffset = default(VectorOffset), int permission = 0, Offset<OneTimeEventData> onetimeeventdataOffset = default(Offset<OneTimeEventData>), Offset<FactoryData> factorydataOffset = default(Offset<FactoryData>), Offset<MoneySafeData> moneysafedataOffset = default(Offset<MoneySafeData>), VectorOffset buffobjectsOffset = default(VectorOffset), long expadresettime = 0L, int expadviewcount = 0, Offset<InvestData> investdataOffset = default(Offset<InvestData>), VectorOffset onetimeeventhistorydataOffset = default(VectorOffset), VectorOffset parkinglotsOffset = default(VectorOffset), Offset<InviteData> invitedataOffset = default(Offset<InviteData>), int abtestdata = -1, VectorOffset managerdataOffset = default(VectorOffset), VectorOffset regionstagedataOffset = default(VectorOffset), int activeregion = 1, long commonlastlogintime = 0L, Offset<ManagerKeyAddData> managerkeyadddataOffset = default(Offset<ManagerKeyAddData>), Offset<RouletteData> specialdayrouletteOffset = default(Offset<RouletteData>), VectorOffset superstaffOffset = default(VectorOffset), Offset<SeasonalData> seasonaldataOffset = default(Offset<SeasonalData>), Offset<TarotData> tarotOffset = default(Offset<TarotData>), Offset<AuctionData> auctionOffset = default(Offset<AuctionData>), Offset<SpecialDayData> specialdayOffset = default(Offset<SpecialDayData>), Offset<AdsupplyPiggy> adsupplypiggyOffset = default(Offset<AdsupplyPiggy>), VectorOffset abilityinvestdataOffset = default(VectorOffset), Offset<RichAchieve> richachieveOffset = default(Offset<RichAchieve>), VectorOffset catstaeventdataOffset = default(VectorOffset), double cheataddtimesec = 0.0, int recommentcompanyidx = 0, Offset<AnniversaryEventData> anniversaryeventdataOffset = default(Offset<AnniversaryEventData>), VectorOffset attendanceeventdataOffset = default(VectorOffset), VectorOffset contentsmissiondataOffset = default(VectorOffset), VectorOffset buyparkinglotdataOffset = default(VectorOffset), Offset<RichWayData> richwaydataOffset = default(Offset<RichWayData>), Offset<BizAcqData> bizacqdataOffset = default(Offset<BizAcqData>), VectorOffset currencydataOffset = default(VectorOffset), VectorOffset submissiondataOffset = default(VectorOffset), Offset<SegmentData> segmentdataOffset = default(Offset<SegmentData>), Offset<AdpassData> adpassdataOffset = default(Offset<AdpassData>), VectorOffset boosterbuffdataOffset = default(VectorOffset), VectorOffset specialpackagedataOffset = default(VectorOffset), Offset<CeoCostumeOwnedData> ceocostumeowneddataOffset = default(Offset<CeoCostumeOwnedData>), Offset<MiniGameData> minigamedataOffset = default(Offset<MiniGameData>), Offset<CompanyListRefreshData> companylistrefreshdataOffset = default(Offset<CompanyListRefreshData>), Offset<RegionMissionData> region1missiondataOffset = default(Offset<RegionMissionData>))
		{
			builder.StartTable(82);
			AddRegion1missiondata(builder, region1missiondataOffset);
			AddCompanylistrefreshdata(builder, companylistrefreshdataOffset);
			AddMinigamedata(builder, minigamedataOffset);
			AddCeocostumeowneddata(builder, ceocostumeowneddataOffset);
			AddSpecialpackagedata(builder, specialpackagedataOffset);
			AddBoosterbuffdata(builder, boosterbuffdataOffset);
			AddAdpassdata(builder, adpassdataOffset);
			AddSegmentdata(builder, segmentdataOffset);
			AddSubmissiondata(builder, submissiondataOffset);
			AddCurrencydata(builder, currencydataOffset);
			AddBizacqdata(builder, bizacqdataOffset);
			AddRichwaydata(builder, richwaydataOffset);
			AddBuyparkinglotdata(builder, buyparkinglotdataOffset);
			AddContentsmissiondata(builder, contentsmissiondataOffset);
			AddAttendanceeventdata(builder, attendanceeventdataOffset);
			AddAnniversaryeventdata(builder, anniversaryeventdataOffset);
			AddRecommentcompanyidx(builder, recommentcompanyidx);
			AddCheataddtimesec(builder, cheataddtimesec);
			AddCatstaeventdata(builder, catstaeventdataOffset);
			AddRichachieve(builder, richachieveOffset);
			AddAbilityinvestdata(builder, abilityinvestdataOffset);
			AddAdsupplypiggy(builder, adsupplypiggyOffset);
			AddSpecialday(builder, specialdayOffset);
			AddAuction(builder, auctionOffset);
			AddTarot(builder, tarotOffset);
			AddSeasonaldata(builder, seasonaldataOffset);
			AddSuperstaff(builder, superstaffOffset);
			AddSpecialdayroulette(builder, specialdayrouletteOffset);
			AddManagerkeyadddata(builder, managerkeyadddataOffset);
			AddCommonlastlogintime(builder, commonlastlogintime);
			AddActiveregion(builder, activeregion);
			AddRegionstagedata(builder, regionstagedataOffset);
			AddManagerdata(builder, managerdataOffset);
			AddAbtestdata(builder, abtestdata);
			AddInvitedata(builder, invitedataOffset);
			AddParkinglots(builder, parkinglotsOffset);
			AddOnetimeeventhistorydata(builder, onetimeeventhistorydataOffset);
			AddInvestdata(builder, investdataOffset);
			AddExpadviewcount(builder, expadviewcount);
			AddExpadresettime(builder, expadresettime);
			AddBuffobjects(builder, buffobjectsOffset);
			AddMoneysafedata(builder, moneysafedataOffset);
			AddFactorydata(builder, factorydataOffset);
			AddOnetimeeventdata(builder, onetimeeventdataOffset);
			AddPermission(builder, permission);
			AddCatstadatas(builder, catstadatasOffset);
			AddEquipcar(builder, equipcar);
			AddCardatas(builder, cardatasOffset);
			AddPoint(builder, point);
			AddBuildingdatas(builder, buildingdatasOffset);
			AddDailyquestdata(builder, dailyquestdataOffset);
			AddUnlockcompany(builder, unlockcompanyOffset);
			AddShopdata(builder, shopdataOffset);
			AddGempass(builder, gempassOffset);
			AddPlants(builder, plantsOffset);
			AddItems(builder, itemsOffset);
			AddAdsupplytime(builder, adsupplytime);
			AddOfflinedata(builder, offlinedataOffset);
			AddBankdata(builder, bankdataOffset);
			AddChardata(builder, chardataOffset);
			AddChatdatas(builder, chatdatasOffset);
			AddRoulette(builder, rouletteOffset);
			AddOpenbuilding(builder, openbuildingOffset);
			AddOpenzone(builder, openzoneOffset);
			AddCompanyrefreshtime(builder, companyrefreshtime);
			AddMissions(builder, missionsOffset);
			AddOffices(builder, officesOffset);
			AddCompanies(builder, companiesOffset);
			AddCompanylist(builder, companylistOffset);
			AddStageidx(builder, stageidx);
			AddFirststarttime(builder, firststarttime);
			AddGamenotifications(builder, gamenotificationsOffset);
			AddOptiondata(builder, optiondataOffset);
			AddRecordcount(builder, recordcountOffset);
			AddRecordvalue(builder, recordvalueOffset);
			AddLastlogintime(builder, lastlogintime);
			AddTutorial(builder, tutorialOffset);
			AddBuyinappids(builder, buyinappidsOffset);
			AddLevel(builder, level);
			AddPower(builder, power);
			AddCash(builder, cash);
			AddMoney(builder, moneyOffset);
			return EndUserData(builder);
		}

		public static void StartUserData(FlatBufferBuilder builder)
		{
			builder.StartTable(112);
		}

		public static void AddMoney(FlatBufferBuilder builder, StringOffset moneyOffset)
		{
			builder.AddOffset(0, moneyOffset.Value, 0);
		}

		public static void AddCash(FlatBufferBuilder builder, int cash)
		{
			builder.AddInt(1, cash, 0);
		}

		public static void AddPower(FlatBufferBuilder builder, int power)
		{
			builder.AddInt(2, power, 0);
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(3, level, 0);
		}

		public static void AddBuyinappids(FlatBufferBuilder builder, StringOffset buyinappidsOffset)
		{
			builder.AddOffset(4, buyinappidsOffset.Value, 0);
		}

		public static void AddTutorial(FlatBufferBuilder builder, StringOffset tutorialOffset)
		{
			builder.AddOffset(5, tutorialOffset.Value, 0);
		}

		public static void AddLastlogintime(FlatBufferBuilder builder, long lastlogintime)
		{
			builder.AddLong(6, lastlogintime, 0);
		}

		public static void AddRecordvalue(FlatBufferBuilder builder, VectorOffset recordvalueOffset)
		{
			builder.AddOffset(7, recordvalueOffset.Value, 0);
		}

		public static VectorOffset CreateRecordvalueVector(FlatBufferBuilder builder, Offset<RecordValue>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateRecordvalueVectorBlock(FlatBufferBuilder builder, Offset<RecordValue>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateRecordvalueVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<RecordValue>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateRecordvalueVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartRecordvalueVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddRecordcount(FlatBufferBuilder builder, VectorOffset recordcountOffset)
		{
			builder.AddOffset(8, recordcountOffset.Value, 0);
		}

		public static VectorOffset CreateRecordcountVector(FlatBufferBuilder builder, Offset<RecordCount>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateRecordcountVectorBlock(FlatBufferBuilder builder, Offset<RecordCount>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateRecordcountVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<RecordCount>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateRecordcountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartRecordcountVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddOptiondata(FlatBufferBuilder builder, Offset<OptionData> optiondataOffset)
		{
			builder.AddOffset(9, optiondataOffset.Value, 0);
		}

		public static void AddGamenotifications(FlatBufferBuilder builder, StringOffset gamenotificationsOffset)
		{
			builder.AddOffset(10, gamenotificationsOffset.Value, 0);
		}

		public static void AddFirststarttime(FlatBufferBuilder builder, long firststarttime)
		{
			builder.AddLong(11, firststarttime, 0);
		}

		public static void AddStageidx(FlatBufferBuilder builder, int stageidx)
		{
			builder.AddInt(12, stageidx, 0);
		}

		public static void AddCompanylist(FlatBufferBuilder builder, VectorOffset companylistOffset)
		{
			builder.AddOffset(13, companylistOffset.Value, 0);
		}

		public static VectorOffset CreateCompanylistVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateCompanylistVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddInt(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateCompanylistVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddInt(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateCompanylistVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartCompanylistVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddCompanies(FlatBufferBuilder builder, VectorOffset companiesOffset)
		{
			builder.AddOffset(14, companiesOffset.Value, 0);
		}

		public static VectorOffset CreateCompaniesVector(FlatBufferBuilder builder, Offset<CompanyData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateCompaniesVectorBlock(FlatBufferBuilder builder, Offset<CompanyData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateCompaniesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<CompanyData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateCompaniesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartCompaniesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddOffices(FlatBufferBuilder builder, VectorOffset officesOffset)
		{
			builder.AddOffset(15, officesOffset.Value, 0);
		}

		public static VectorOffset CreateOfficesVector(FlatBufferBuilder builder, Offset<OfficeData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateOfficesVectorBlock(FlatBufferBuilder builder, Offset<OfficeData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateOfficesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<OfficeData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateOfficesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartOfficesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddMissions(FlatBufferBuilder builder, VectorOffset missionsOffset)
		{
			builder.AddOffset(16, missionsOffset.Value, 0);
		}

		public static VectorOffset CreateMissionsVector(FlatBufferBuilder builder, Offset<MissionData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateMissionsVectorBlock(FlatBufferBuilder builder, Offset<MissionData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateMissionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<MissionData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateMissionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartMissionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddCompanyrefreshtime(FlatBufferBuilder builder, long companyrefreshtime)
		{
			builder.AddLong(17, companyrefreshtime, 0);
		}

		public static void AddOpenzone(FlatBufferBuilder builder, VectorOffset openzoneOffset)
		{
			builder.AddOffset(18, openzoneOffset.Value, 0);
		}

		public static VectorOffset CreateOpenzoneVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateOpenzoneVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddInt(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateOpenzoneVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddInt(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateOpenzoneVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartOpenzoneVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddOpenbuilding(FlatBufferBuilder builder, VectorOffset openbuildingOffset)
		{
			builder.AddOffset(19, openbuildingOffset.Value, 0);
		}

		public static VectorOffset CreateOpenbuildingVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateOpenbuildingVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddInt(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateOpenbuildingVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddInt(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateOpenbuildingVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartOpenbuildingVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddRoulette(FlatBufferBuilder builder, Offset<RouletteData> rouletteOffset)
		{
			builder.AddOffset(20, rouletteOffset.Value, 0);
		}

		public static void AddChatdatas(FlatBufferBuilder builder, VectorOffset chatdatasOffset)
		{
			builder.AddOffset(21, chatdatasOffset.Value, 0);
		}

		public static VectorOffset CreateChatdatasVector(FlatBufferBuilder builder, Offset<ChatData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateChatdatasVectorBlock(FlatBufferBuilder builder, Offset<ChatData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateChatdatasVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ChatData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateChatdatasVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartChatdatasVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddChardata(FlatBufferBuilder builder, Offset<UserCharData> chardataOffset)
		{
			builder.AddOffset(22, chardataOffset.Value, 0);
		}

		public static void AddBankdata(FlatBufferBuilder builder, Offset<BankData> bankdataOffset)
		{
			builder.AddOffset(23, bankdataOffset.Value, 0);
		}

		public static void AddOfflinedata(FlatBufferBuilder builder, Offset<OfflineData> offlinedataOffset)
		{
			builder.AddOffset(24, offlinedataOffset.Value, 0);
		}

		public static void AddAdsupplytime(FlatBufferBuilder builder, long adsupplytime)
		{
			builder.AddLong(25, adsupplytime, 0);
		}

		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(26, itemsOffset.Value, 0);
		}

		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<ItemData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, Offset<ItemData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ItemData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddPlants(FlatBufferBuilder builder, VectorOffset plantsOffset)
		{
			builder.AddOffset(27, plantsOffset.Value, 0);
		}

		public static VectorOffset CreatePlantsVector(FlatBufferBuilder builder, Offset<PlantData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreatePlantsVectorBlock(FlatBufferBuilder builder, Offset<PlantData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreatePlantsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<PlantData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreatePlantsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartPlantsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddGempass(FlatBufferBuilder builder, Offset<GemPassData> gempassOffset)
		{
			builder.AddOffset(28, gempassOffset.Value, 0);
		}

		public static void AddShopdata(FlatBufferBuilder builder, Offset<ShopData> shopdataOffset)
		{
			builder.AddOffset(29, shopdataOffset.Value, 0);
		}

		public static void AddUnlockcompany(FlatBufferBuilder builder, VectorOffset unlockcompanyOffset)
		{
			builder.AddOffset(30, unlockcompanyOffset.Value, 0);
		}

		public static VectorOffset CreateUnlockcompanyVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateUnlockcompanyVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddInt(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateUnlockcompanyVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddInt(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateUnlockcompanyVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartUnlockcompanyVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddDailyquestdata(FlatBufferBuilder builder, Offset<DailyQuestData> dailyquestdataOffset)
		{
			builder.AddOffset(31, dailyquestdataOffset.Value, 0);
		}

		public static void AddBuildingdatas(FlatBufferBuilder builder, VectorOffset buildingdatasOffset)
		{
			builder.AddOffset(32, buildingdatasOffset.Value, 0);
		}

		public static VectorOffset CreateBuildingdatasVector(FlatBufferBuilder builder, Offset<BuildingData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateBuildingdatasVectorBlock(FlatBufferBuilder builder, Offset<BuildingData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateBuildingdatasVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<BuildingData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateBuildingdatasVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartBuildingdatasVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddPoint(FlatBufferBuilder builder, int point)
		{
			builder.AddInt(33, point, 0);
		}

		public static void AddCardatas(FlatBufferBuilder builder, VectorOffset cardatasOffset)
		{
			builder.AddOffset(34, cardatasOffset.Value, 0);
		}

		public static VectorOffset CreateCardatasVector(FlatBufferBuilder builder, Offset<CarData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateCardatasVectorBlock(FlatBufferBuilder builder, Offset<CarData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateCardatasVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<CarData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateCardatasVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartCardatasVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddEquipcar(FlatBufferBuilder builder, int equipcar)
		{
			builder.AddInt(35, equipcar, 0);
		}

		public static void AddCatstadatas(FlatBufferBuilder builder, VectorOffset catstadatasOffset)
		{
			builder.AddOffset(36, catstadatasOffset.Value, 0);
		}

		public static VectorOffset CreateCatstadatasVector(FlatBufferBuilder builder, Offset<CatstaData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateCatstadatasVectorBlock(FlatBufferBuilder builder, Offset<CatstaData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateCatstadatasVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<CatstaData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateCatstadatasVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartCatstadatasVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddPermission(FlatBufferBuilder builder, int permission)
		{
			builder.AddInt(37, permission, 0);
		}

		public static void AddOnetimeeventdata(FlatBufferBuilder builder, Offset<OneTimeEventData> onetimeeventdataOffset)
		{
			builder.AddOffset(38, onetimeeventdataOffset.Value, 0);
		}

		public static void AddFactorydata(FlatBufferBuilder builder, Offset<FactoryData> factorydataOffset)
		{
			builder.AddOffset(39, factorydataOffset.Value, 0);
		}

		public static void AddMoneysafedata(FlatBufferBuilder builder, Offset<MoneySafeData> moneysafedataOffset)
		{
			builder.AddOffset(40, moneysafedataOffset.Value, 0);
		}

		public static void AddBuffobjects(FlatBufferBuilder builder, VectorOffset buffobjectsOffset)
		{
			builder.AddOffset(41, buffobjectsOffset.Value, 0);
		}

		public static VectorOffset CreateBuffobjectsVector(FlatBufferBuilder builder, Offset<ItemData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateBuffobjectsVectorBlock(FlatBufferBuilder builder, Offset<ItemData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateBuffobjectsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ItemData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateBuffobjectsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartBuffobjectsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddExpadresettime(FlatBufferBuilder builder, long expadresettime)
		{
			builder.AddLong(42, expadresettime, 0);
		}

		public static void AddExpadviewcount(FlatBufferBuilder builder, int expadviewcount)
		{
			builder.AddInt(43, expadviewcount, 0);
		}

		public static void AddInvestdata(FlatBufferBuilder builder, Offset<InvestData> investdataOffset)
		{
			builder.AddOffset(44, investdataOffset.Value, 0);
		}

		public static void AddOnetimeeventhistorydata(FlatBufferBuilder builder, VectorOffset onetimeeventhistorydataOffset)
		{
			builder.AddOffset(45, onetimeeventhistorydataOffset.Value, 0);
		}

		public static VectorOffset CreateOnetimeeventhistorydataVector(FlatBufferBuilder builder, Offset<OneTimeEventHistoryData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateOnetimeeventhistorydataVectorBlock(FlatBufferBuilder builder, Offset<OneTimeEventHistoryData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateOnetimeeventhistorydataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<OneTimeEventHistoryData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateOnetimeeventhistorydataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartOnetimeeventhistorydataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddParkinglots(FlatBufferBuilder builder, VectorOffset parkinglotsOffset)
		{
			builder.AddOffset(46, parkinglotsOffset.Value, 0);
		}

		public static VectorOffset CreateParkinglotsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateParkinglotsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddInt(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateParkinglotsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddInt(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateParkinglotsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartParkinglotsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddInvitedata(FlatBufferBuilder builder, Offset<InviteData> invitedataOffset)
		{
			builder.AddOffset(47, invitedataOffset.Value, 0);
		}

		public static void AddAbtestdata(FlatBufferBuilder builder, int abtestdata)
		{
			builder.AddInt(48, abtestdata, 0);
		}

		public static void AddManagerdata(FlatBufferBuilder builder, VectorOffset managerdataOffset)
		{
			builder.AddOffset(49, managerdataOffset.Value, 0);
		}

		public static VectorOffset CreateManagerdataVector(FlatBufferBuilder builder, Offset<ManagerData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateManagerdataVectorBlock(FlatBufferBuilder builder, Offset<ManagerData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateManagerdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ManagerData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateManagerdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartManagerdataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddRegionstagedata(FlatBufferBuilder builder, VectorOffset regionstagedataOffset)
		{
			builder.AddOffset(50, regionstagedataOffset.Value, 0);
		}

		public static VectorOffset CreateRegionstagedataVector(FlatBufferBuilder builder, Offset<RegionStageData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateRegionstagedataVectorBlock(FlatBufferBuilder builder, Offset<RegionStageData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateRegionstagedataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<RegionStageData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateRegionstagedataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartRegionstagedataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddActiveregion(FlatBufferBuilder builder, int activeregion)
		{
			builder.AddInt(51, activeregion, 0);
		}

		public static void AddCommonlastlogintime(FlatBufferBuilder builder, long commonlastlogintime)
		{
			builder.AddLong(52, commonlastlogintime, 0);
		}

		public static void AddManagerkeyadddata(FlatBufferBuilder builder, Offset<ManagerKeyAddData> managerkeyadddataOffset)
		{
			builder.AddOffset(53, managerkeyadddataOffset.Value, 0);
		}

		public static void AddSpecialdayroulette(FlatBufferBuilder builder, Offset<RouletteData> specialdayrouletteOffset)
		{
			builder.AddOffset(54, specialdayrouletteOffset.Value, 0);
		}

		public static void AddSuperstaff(FlatBufferBuilder builder, VectorOffset superstaffOffset)
		{
			builder.AddOffset(55, superstaffOffset.Value, 0);
		}

		public static VectorOffset CreateSuperstaffVector(FlatBufferBuilder builder, Offset<SuperStaffData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateSuperstaffVectorBlock(FlatBufferBuilder builder, Offset<SuperStaffData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateSuperstaffVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<SuperStaffData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateSuperstaffVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartSuperstaffVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddSeasonaldata(FlatBufferBuilder builder, Offset<SeasonalData> seasonaldataOffset)
		{
			builder.AddOffset(56, seasonaldataOffset.Value, 0);
		}

		public static void AddTarot(FlatBufferBuilder builder, Offset<TarotData> tarotOffset)
		{
			builder.AddOffset(57, tarotOffset.Value, 0);
		}

		public static void AddAuction(FlatBufferBuilder builder, Offset<AuctionData> auctionOffset)
		{
			builder.AddOffset(58, auctionOffset.Value, 0);
		}

		public static void AddSpecialday(FlatBufferBuilder builder, Offset<SpecialDayData> specialdayOffset)
		{
			builder.AddOffset(59, specialdayOffset.Value, 0);
		}

		public static void AddAdsupplypiggy(FlatBufferBuilder builder, Offset<AdsupplyPiggy> adsupplypiggyOffset)
		{
			builder.AddOffset(60, adsupplypiggyOffset.Value, 0);
		}

		public static void AddAbilityinvestdata(FlatBufferBuilder builder, VectorOffset abilityinvestdataOffset)
		{
			builder.AddOffset(61, abilityinvestdataOffset.Value, 0);
		}

		public static VectorOffset CreateAbilityinvestdataVector(FlatBufferBuilder builder, Offset<InvestData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateAbilityinvestdataVectorBlock(FlatBufferBuilder builder, Offset<InvestData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateAbilityinvestdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<InvestData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateAbilityinvestdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartAbilityinvestdataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddRichachieve(FlatBufferBuilder builder, Offset<RichAchieve> richachieveOffset)
		{
			builder.AddOffset(62, richachieveOffset.Value, 0);
		}

		public static void AddCatstaeventdata(FlatBufferBuilder builder, VectorOffset catstaeventdataOffset)
		{
			builder.AddOffset(63, catstaeventdataOffset.Value, 0);
		}

		public static VectorOffset CreateCatstaeventdataVector(FlatBufferBuilder builder, Offset<CatstaEventData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateCatstaeventdataVectorBlock(FlatBufferBuilder builder, Offset<CatstaEventData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateCatstaeventdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<CatstaEventData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateCatstaeventdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartCatstaeventdataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddCheataddtimesec(FlatBufferBuilder builder, double cheataddtimesec)
		{
			builder.AddDouble(64, cheataddtimesec, 0.0);
		}

		public static void AddRecommentcompanyidx(FlatBufferBuilder builder, int recommentcompanyidx)
		{
			builder.AddInt(65, recommentcompanyidx, 0);
		}

		public static void AddAnniversaryeventdata(FlatBufferBuilder builder, Offset<AnniversaryEventData> anniversaryeventdataOffset)
		{
			builder.AddOffset(66, anniversaryeventdataOffset.Value, 0);
		}

		public static void AddAttendanceeventdata(FlatBufferBuilder builder, VectorOffset attendanceeventdataOffset)
		{
			builder.AddOffset(67, attendanceeventdataOffset.Value, 0);
		}

		public static VectorOffset CreateAttendanceeventdataVector(FlatBufferBuilder builder, Offset<AttendanceEventData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateAttendanceeventdataVectorBlock(FlatBufferBuilder builder, Offset<AttendanceEventData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateAttendanceeventdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<AttendanceEventData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateAttendanceeventdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartAttendanceeventdataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddContentsmissiondata(FlatBufferBuilder builder, VectorOffset contentsmissiondataOffset)
		{
			builder.AddOffset(68, contentsmissiondataOffset.Value, 0);
		}

		public static VectorOffset CreateContentsmissiondataVector(FlatBufferBuilder builder, Offset<ContentsMissionData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateContentsmissiondataVectorBlock(FlatBufferBuilder builder, Offset<ContentsMissionData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateContentsmissiondataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ContentsMissionData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateContentsmissiondataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartContentsmissiondataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddBuyparkinglotdata(FlatBufferBuilder builder, VectorOffset buyparkinglotdataOffset)
		{
			builder.AddOffset(69, buyparkinglotdataOffset.Value, 0);
		}

		public static VectorOffset CreateBuyparkinglotdataVector(FlatBufferBuilder builder, Offset<BuyParkingLotData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateBuyparkinglotdataVectorBlock(FlatBufferBuilder builder, Offset<BuyParkingLotData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateBuyparkinglotdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<BuyParkingLotData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateBuyparkinglotdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartBuyparkinglotdataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddRichwaydata(FlatBufferBuilder builder, Offset<RichWayData> richwaydataOffset)
		{
			builder.AddOffset(70, richwaydataOffset.Value, 0);
		}

		public static void AddBizacqdata(FlatBufferBuilder builder, Offset<BizAcqData> bizacqdataOffset)
		{
			builder.AddOffset(71, bizacqdataOffset.Value, 0);
		}

		public static void AddCurrencydata(FlatBufferBuilder builder, VectorOffset currencydataOffset)
		{
			builder.AddOffset(72, currencydataOffset.Value, 0);
		}

		public static VectorOffset CreateCurrencydataVector(FlatBufferBuilder builder, Offset<CurrencyData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateCurrencydataVectorBlock(FlatBufferBuilder builder, Offset<CurrencyData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateCurrencydataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<CurrencyData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateCurrencydataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartCurrencydataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddSubmissiondata(FlatBufferBuilder builder, VectorOffset submissiondataOffset)
		{
			builder.AddOffset(73, submissiondataOffset.Value, 0);
		}

		public static VectorOffset CreateSubmissiondataVector(FlatBufferBuilder builder, Offset<SubMissionData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateSubmissiondataVectorBlock(FlatBufferBuilder builder, Offset<SubMissionData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateSubmissiondataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<SubMissionData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateSubmissiondataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartSubmissiondataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddSegmentdata(FlatBufferBuilder builder, Offset<SegmentData> segmentdataOffset)
		{
			builder.AddOffset(74, segmentdataOffset.Value, 0);
		}

		public static void AddAdpassdata(FlatBufferBuilder builder, Offset<AdpassData> adpassdataOffset)
		{
			builder.AddOffset(75, adpassdataOffset.Value, 0);
		}

		public static void AddBoosterbuffdata(FlatBufferBuilder builder, VectorOffset boosterbuffdataOffset)
		{
			builder.AddOffset(76, boosterbuffdataOffset.Value, 0);
		}

		public static VectorOffset CreateBoosterbuffdataVector(FlatBufferBuilder builder, Offset<BoosterBuffData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateBoosterbuffdataVectorBlock(FlatBufferBuilder builder, Offset<BoosterBuffData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateBoosterbuffdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<BoosterBuffData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateBoosterbuffdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartBoosterbuffdataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddSpecialpackagedata(FlatBufferBuilder builder, VectorOffset specialpackagedataOffset)
		{
			builder.AddOffset(77, specialpackagedataOffset.Value, 0);
		}

		public static VectorOffset CreateSpecialpackagedataVector(FlatBufferBuilder builder, Offset<SpecialPackageData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateSpecialpackagedataVectorBlock(FlatBufferBuilder builder, Offset<SpecialPackageData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateSpecialpackagedataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<SpecialPackageData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateSpecialpackagedataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartSpecialpackagedataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddCeocostumeowneddata(FlatBufferBuilder builder, Offset<CeoCostumeOwnedData> ceocostumeowneddataOffset)
		{
			builder.AddOffset(78, ceocostumeowneddataOffset.Value, 0);
		}

		public static void AddMinigamedata(FlatBufferBuilder builder, Offset<MiniGameData> minigamedataOffset)
		{
			builder.AddOffset(79, minigamedataOffset.Value, 0);
		}

		public static void AddCompanylistrefreshdata(FlatBufferBuilder builder, Offset<CompanyListRefreshData> companylistrefreshdataOffset)
		{
			builder.AddOffset(80, companylistrefreshdataOffset.Value, 0);
		}

		public static void AddRegion1missiondata(FlatBufferBuilder builder, Offset<RegionMissionData> region1missiondataOffset)
		{
			builder.AddOffset(81, region1missiondataOffset.Value, 0);
		}

		public static Offset<UserData> EndUserData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<UserData>(o);
		}

		public static void FinishUserDataBuffer(FlatBufferBuilder builder, Offset<UserData> offset)
		{
		}

		public static void FinishSizePrefixedUserDataBuffer(FlatBufferBuilder builder, Offset<UserData> offset)
		{
		}

		public UserDataT UnPack()
		{
			var _o = new UserDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(UserDataT _o)
		{
			_o.Money = this.Money;
			_o.Cash = this.Cash;
			_o.Power = this.Power;
			_o.Level = this.Level;
			_o.Buyinappids = this.Buyinappids;
			_o.Tutorial = this.Tutorial;
			_o.Lastlogintime = this.Lastlogintime;
			_o.Recordvalue = new List<RecordValueT>();
			for (var _j = 0; _j < this.RecordvalueLength; ++_j)
				_o.Recordvalue.Add(this.Recordvalue(_j).HasValue ? this.Recordvalue(_j).Value.UnPack() : null);
			_o.Recordcount = new List<RecordCountT>();
			for (var _j = 0; _j < this.RecordcountLength; ++_j)
				_o.Recordcount.Add(this.Recordcount(_j).HasValue ? this.Recordcount(_j).Value.UnPack() : null);
			_o.Optiondata = this.Optiondata.HasValue ? this.Optiondata.Value.UnPack() : null;
			_o.Gamenotifications = this.Gamenotifications;
			_o.Firststarttime = this.Firststarttime;
			_o.Stageidx = this.Stageidx;
			_o.Companylist = new List<int>();
			for (var _j = 0; _j < this.CompanylistLength; ++_j)
				_o.Companylist.Add(this.Companylist(_j));
			_o.Companies = new List<CompanyDataT>();
			for (var _j = 0; _j < this.CompaniesLength; ++_j)
				_o.Companies.Add(this.Companies(_j).HasValue ? this.Companies(_j).Value.UnPack() : null);
			_o.Offices = new List<OfficeDataT>();
			for (var _j = 0; _j < this.OfficesLength; ++_j)
				_o.Offices.Add(this.Offices(_j).HasValue ? this.Offices(_j).Value.UnPack() : null);
			_o.Missions = new List<MissionDataT>();
			for (var _j = 0; _j < this.MissionsLength; ++_j)
				_o.Missions.Add(this.Missions(_j).HasValue ? this.Missions(_j).Value.UnPack() : null);
			_o.Companyrefreshtime = this.Companyrefreshtime;
			_o.Openzone = new List<int>();
			for (var _j = 0; _j < this.OpenzoneLength; ++_j)
				_o.Openzone.Add(this.Openzone(_j));
			_o.Openbuilding = new List<int>();
			for (var _j = 0; _j < this.OpenbuildingLength; ++_j)
				_o.Openbuilding.Add(this.Openbuilding(_j));
			_o.Roulette = this.Roulette.HasValue ? this.Roulette.Value.UnPack() : null;
			_o.Chatdatas = new List<ChatDataT>();
			for (var _j = 0; _j < this.ChatdatasLength; ++_j)
				_o.Chatdatas.Add(this.Chatdatas(_j).HasValue ? this.Chatdatas(_j).Value.UnPack() : null);
			_o.Chardata = this.Chardata.HasValue ? this.Chardata.Value.UnPack() : null;
			_o.Bankdata = this.Bankdata.HasValue ? this.Bankdata.Value.UnPack() : null;
			_o.Offlinedata = this.Offlinedata.HasValue ? this.Offlinedata.Value.UnPack() : null;
			_o.Adsupplytime = this.Adsupplytime;
			_o.Items = new List<ItemDataT>();
			for (var _j = 0; _j < this.ItemsLength; ++_j)
				_o.Items.Add(this.Items(_j).HasValue ? this.Items(_j).Value.UnPack() : null);
			_o.Plants = new List<PlantDataT>();
			for (var _j = 0; _j < this.PlantsLength; ++_j)
				_o.Plants.Add(this.Plants(_j).HasValue ? this.Plants(_j).Value.UnPack() : null);
			_o.Gempass = this.Gempass.HasValue ? this.Gempass.Value.UnPack() : null;
			_o.Shopdata = this.Shopdata.HasValue ? this.Shopdata.Value.UnPack() : null;
			_o.Unlockcompany = new List<int>();
			for (var _j = 0; _j < this.UnlockcompanyLength; ++_j)
				_o.Unlockcompany.Add(this.Unlockcompany(_j));
			_o.Dailyquestdata = this.Dailyquestdata.HasValue ? this.Dailyquestdata.Value.UnPack() : null;
			_o.Buildingdatas = new List<BuildingDataT>();
			for (var _j = 0; _j < this.BuildingdatasLength; ++_j)
				_o.Buildingdatas.Add(this.Buildingdatas(_j).HasValue ? this.Buildingdatas(_j).Value.UnPack() : null);
			_o.Point = this.Point;
			_o.Cardatas = new List<CarDataT>();
			for (var _j = 0; _j < this.CardatasLength; ++_j)
				_o.Cardatas.Add(this.Cardatas(_j).HasValue ? this.Cardatas(_j).Value.UnPack() : null);
			_o.Equipcar = this.Equipcar;
			_o.Catstadatas = new List<CatstaDataT>();
			for (var _j = 0; _j < this.CatstadatasLength; ++_j)
				_o.Catstadatas.Add(this.Catstadatas(_j).HasValue ? this.Catstadatas(_j).Value.UnPack() : null);
			_o.Permission = this.Permission;
			_o.Onetimeeventdata = this.Onetimeeventdata.HasValue ? this.Onetimeeventdata.Value.UnPack() : null;
			_o.Factorydata = this.Factorydata.HasValue ? this.Factorydata.Value.UnPack() : null;
			_o.Moneysafedata = this.Moneysafedata.HasValue ? this.Moneysafedata.Value.UnPack() : null;
			_o.Buffobjects = new List<ItemDataT>();
			for (var _j = 0; _j < this.BuffobjectsLength; ++_j)
				_o.Buffobjects.Add(this.Buffobjects(_j).HasValue ? this.Buffobjects(_j).Value.UnPack() : null);
			_o.Expadresettime = this.Expadresettime;
			_o.Expadviewcount = this.Expadviewcount;
			_o.Investdata = this.Investdata.HasValue ? this.Investdata.Value.UnPack() : null;
			_o.Onetimeeventhistorydata = new List<OneTimeEventHistoryDataT>();
			for (var _j = 0; _j < this.OnetimeeventhistorydataLength; ++_j)
				_o.Onetimeeventhistorydata.Add(this.Onetimeeventhistorydata(_j).HasValue ? this.Onetimeeventhistorydata(_j).Value.UnPack() : null);
			_o.Parkinglots = new List<int>();
			for (var _j = 0; _j < this.ParkinglotsLength; ++_j)
				_o.Parkinglots.Add(this.Parkinglots(_j));
			_o.Invitedata = this.Invitedata.HasValue ? this.Invitedata.Value.UnPack() : null;
			_o.Abtestdata = this.Abtestdata;
			_o.Managerdata = new List<ManagerDataT>();
			for (var _j = 0; _j < this.ManagerdataLength; ++_j)
				_o.Managerdata.Add(this.Managerdata(_j).HasValue ? this.Managerdata(_j).Value.UnPack() : null);
			_o.Regionstagedata = new List<RegionStageDataT>();
			for (var _j = 0; _j < this.RegionstagedataLength; ++_j)
				_o.Regionstagedata.Add(this.Regionstagedata(_j).HasValue ? this.Regionstagedata(_j).Value.UnPack() : null);
			_o.Activeregion = this.Activeregion;
			_o.Commonlastlogintime = this.Commonlastlogintime;
			_o.Managerkeyadddata = this.Managerkeyadddata.HasValue ? this.Managerkeyadddata.Value.UnPack() : null;
			_o.Specialdayroulette = this.Specialdayroulette.HasValue ? this.Specialdayroulette.Value.UnPack() : null;
			_o.Superstaff = new List<SuperStaffDataT>();
			for (var _j = 0; _j < this.SuperstaffLength; ++_j)
				_o.Superstaff.Add(this.Superstaff(_j).HasValue ? this.Superstaff(_j).Value.UnPack() : null);
			_o.Seasonaldata = this.Seasonaldata.HasValue ? this.Seasonaldata.Value.UnPack() : null;
			_o.Tarot = this.Tarot.HasValue ? this.Tarot.Value.UnPack() : null;
			_o.Auction = this.Auction.HasValue ? this.Auction.Value.UnPack() : null;
			_o.Specialday = this.Specialday.HasValue ? this.Specialday.Value.UnPack() : null;
			_o.Adsupplypiggy = this.Adsupplypiggy.HasValue ? this.Adsupplypiggy.Value.UnPack() : null;
			_o.Abilityinvestdata = new List<InvestDataT>();
			for (var _j = 0; _j < this.AbilityinvestdataLength; ++_j)
				_o.Abilityinvestdata.Add(this.Abilityinvestdata(_j).HasValue ? this.Abilityinvestdata(_j).Value.UnPack() : null);
			_o.Richachieve = this.Richachieve.HasValue ? this.Richachieve.Value.UnPack() : null;
			_o.Catstaeventdata = new List<CatstaEventDataT>();
			for (var _j = 0; _j < this.CatstaeventdataLength; ++_j)
				_o.Catstaeventdata.Add(this.Catstaeventdata(_j).HasValue ? this.Catstaeventdata(_j).Value.UnPack() : null);
			_o.Cheataddtimesec = this.Cheataddtimesec;
			_o.Recommentcompanyidx = this.Recommentcompanyidx;
			_o.Anniversaryeventdata = this.Anniversaryeventdata.HasValue ? this.Anniversaryeventdata.Value.UnPack() : null;
			_o.Attendanceeventdata = new List<AttendanceEventDataT>();
			for (var _j = 0; _j < this.AttendanceeventdataLength; ++_j)
				_o.Attendanceeventdata.Add(this.Attendanceeventdata(_j).HasValue ? this.Attendanceeventdata(_j).Value.UnPack() : null);
			_o.Contentsmissiondata = new List<ContentsMissionDataT>();
			for (var _j = 0; _j < this.ContentsmissiondataLength; ++_j)
				_o.Contentsmissiondata.Add(this.Contentsmissiondata(_j).HasValue ? this.Contentsmissiondata(_j).Value.UnPack() : null);
			_o.Buyparkinglotdata = new List<BuyParkingLotDataT>();
			for (var _j = 0; _j < this.BuyparkinglotdataLength; ++_j)
				_o.Buyparkinglotdata.Add(this.Buyparkinglotdata(_j).HasValue ? this.Buyparkinglotdata(_j).Value.UnPack() : null);
			_o.Richwaydata = this.Richwaydata.HasValue ? this.Richwaydata.Value.UnPack() : null;
			_o.Bizacqdata = this.Bizacqdata.HasValue ? this.Bizacqdata.Value.UnPack() : null;
			_o.Currencydata = new List<CurrencyDataT>();
			for (var _j = 0; _j < this.CurrencydataLength; ++_j)
				_o.Currencydata.Add(this.Currencydata(_j).HasValue ? this.Currencydata(_j).Value.UnPack() : null);
			_o.Submissiondata = new List<SubMissionDataT>();
			for (var _j = 0; _j < this.SubmissiondataLength; ++_j)
				_o.Submissiondata.Add(this.Submissiondata(_j).HasValue ? this.Submissiondata(_j).Value.UnPack() : null);
			_o.Segmentdata = this.Segmentdata.HasValue ? this.Segmentdata.Value.UnPack() : null;
			_o.Adpassdata = this.Adpassdata.HasValue ? this.Adpassdata.Value.UnPack() : null;
			_o.Boosterbuffdata = new List<BoosterBuffDataT>();
			for (var _j = 0; _j < this.BoosterbuffdataLength; ++_j)
				_o.Boosterbuffdata.Add(this.Boosterbuffdata(_j).HasValue ? this.Boosterbuffdata(_j).Value.UnPack() : null);
			_o.Specialpackagedata = new List<SpecialPackageDataT>();
			for (var _j = 0; _j < this.SpecialpackagedataLength; ++_j)
				_o.Specialpackagedata.Add(this.Specialpackagedata(_j).HasValue ? this.Specialpackagedata(_j).Value.UnPack() : null);
			_o.Ceocostumeowneddata = this.Ceocostumeowneddata.HasValue ? this.Ceocostumeowneddata.Value.UnPack() : null;
			_o.Minigamedata = this.Minigamedata.HasValue ? this.Minigamedata.Value.UnPack() : null;
			_o.Companylistrefreshdata = this.Companylistrefreshdata.HasValue ? this.Companylistrefreshdata.Value.UnPack() : null;
			_o.Region1missiondata = this.Region1missiondata.HasValue ? this.Region1missiondata.Value.UnPack() : null;
		}

		public static Offset<UserData> Pack(FlatBufferBuilder builder, UserDataT _o)
		{
			if (_o == null) return default(Offset<UserData>);
			var _money = _o.Money == null ? default(StringOffset) : builder.CreateString(_o.Money);
			var _buyinappids = _o.Buyinappids == null ? default(StringOffset) : builder.CreateString(_o.Buyinappids);
			var _tutorial = _o.Tutorial == null ? default(StringOffset) : builder.CreateString(_o.Tutorial);
			var _recordvalue = default(VectorOffset);
			if (_o.Recordvalue != null)
			{
				var __recordvalue = new Offset<RecordValue>[_o.Recordvalue.Count];
				for (var _j = 0; _j < _o.Recordvalue.Count; ++_j)
					__recordvalue[_j] = RecordValue.Pack(builder, _o.Recordvalue[_j]);
				_recordvalue = CreateRecordvalueVector(builder, __recordvalue);
			}
			var _recordcount = default(VectorOffset);
			if (_o.Recordcount != null)
			{
				var __recordcount = new Offset<RecordCount>[_o.Recordcount.Count];
				for (var _j = 0; _j < _o.Recordcount.Count; ++_j)
					__recordcount[_j] = RecordCount.Pack(builder, _o.Recordcount[_j]);
				_recordcount = CreateRecordcountVector(builder, __recordcount);
			}
			var _optiondata = _o.Optiondata == null ? default(Offset<OptionData>) : OptionData.Pack(builder, _o.Optiondata);
			var _gamenotifications = _o.Gamenotifications == null ? default(StringOffset) : builder.CreateString(_o.Gamenotifications);
			var _companylist = default(VectorOffset);
			if (_o.Companylist != null)
			{
				var __companylist = _o.Companylist.ToArray();
				_companylist = CreateCompanylistVector(builder, __companylist);
			}
			var _companies = default(VectorOffset);
			if (_o.Companies != null)
			{
				var __companies = new Offset<CompanyData>[_o.Companies.Count];
				for (var _j = 0; _j < _o.Companies.Count; ++_j)
					__companies[_j] = CompanyData.Pack(builder, _o.Companies[_j]);
				_companies = CreateCompaniesVector(builder, __companies);
			}
			var _offices = default(VectorOffset);
			if (_o.Offices != null)
			{
				var __offices = new Offset<OfficeData>[_o.Offices.Count];
				for (var _j = 0; _j < _o.Offices.Count; ++_j)
					__offices[_j] = OfficeData.Pack(builder, _o.Offices[_j]);
				_offices = CreateOfficesVector(builder, __offices);
			}
			var _missions = default(VectorOffset);
			if (_o.Missions != null)
			{
				var __missions = new Offset<MissionData>[_o.Missions.Count];
				for (var _j = 0; _j < _o.Missions.Count; ++_j)
					__missions[_j] = MissionData.Pack(builder, _o.Missions[_j]);
				_missions = CreateMissionsVector(builder, __missions);
			}
			var _openzone = default(VectorOffset);
			if (_o.Openzone != null)
			{
				var __openzone = _o.Openzone.ToArray();
				_openzone = CreateOpenzoneVector(builder, __openzone);
			}
			var _openbuilding = default(VectorOffset);
			if (_o.Openbuilding != null)
			{
				var __openbuilding = _o.Openbuilding.ToArray();
				_openbuilding = CreateOpenbuildingVector(builder, __openbuilding);
			}
			var _roulette = _o.Roulette == null ? default(Offset<RouletteData>) : RouletteData.Pack(builder, _o.Roulette);
			var _chatdatas = default(VectorOffset);
			if (_o.Chatdatas != null)
			{
				var __chatdatas = new Offset<ChatData>[_o.Chatdatas.Count];
				for (var _j = 0; _j < _o.Chatdatas.Count; ++_j)
					__chatdatas[_j] = ChatData.Pack(builder, _o.Chatdatas[_j]);
				_chatdatas = CreateChatdatasVector(builder, __chatdatas);
			}
			var _chardata = _o.Chardata == null ? default(Offset<UserCharData>) : UserCharData.Pack(builder, _o.Chardata);
			var _bankdata = _o.Bankdata == null ? default(Offset<BankData>) : BankData.Pack(builder, _o.Bankdata);
			var _offlinedata = _o.Offlinedata == null ? default(Offset<OfflineData>) : OfflineData.Pack(builder, _o.Offlinedata);
			var _items = default(VectorOffset);
			if (_o.Items != null)
			{
				var __items = new Offset<ItemData>[_o.Items.Count];
				for (var _j = 0; _j < _o.Items.Count; ++_j)
					__items[_j] = ItemData.Pack(builder, _o.Items[_j]);
				_items = CreateItemsVector(builder, __items);
			}
			var _plants = default(VectorOffset);
			if (_o.Plants != null)
			{
				var __plants = new Offset<PlantData>[_o.Plants.Count];
				for (var _j = 0; _j < _o.Plants.Count; ++_j)
					__plants[_j] = PlantData.Pack(builder, _o.Plants[_j]);
				_plants = CreatePlantsVector(builder, __plants);
			}
			var _gempass = _o.Gempass == null ? default(Offset<GemPassData>) : GemPassData.Pack(builder, _o.Gempass);
			var _shopdata = _o.Shopdata == null ? default(Offset<ShopData>) : ShopData.Pack(builder, _o.Shopdata);
			var _unlockcompany = default(VectorOffset);
			if (_o.Unlockcompany != null)
			{
				var __unlockcompany = _o.Unlockcompany.ToArray();
				_unlockcompany = CreateUnlockcompanyVector(builder, __unlockcompany);
			}
			var _dailyquestdata = _o.Dailyquestdata == null ? default(Offset<DailyQuestData>) : DailyQuestData.Pack(builder, _o.Dailyquestdata);
			var _buildingdatas = default(VectorOffset);
			if (_o.Buildingdatas != null)
			{
				var __buildingdatas = new Offset<BuildingData>[_o.Buildingdatas.Count];
				for (var _j = 0; _j < _o.Buildingdatas.Count; ++_j)
					__buildingdatas[_j] = BuildingData.Pack(builder, _o.Buildingdatas[_j]);
				_buildingdatas = CreateBuildingdatasVector(builder, __buildingdatas);
			}
			var _cardatas = default(VectorOffset);
			if (_o.Cardatas != null)
			{
				var __cardatas = new Offset<CarData>[_o.Cardatas.Count];
				for (var _j = 0; _j < _o.Cardatas.Count; ++_j)
					__cardatas[_j] = CarData.Pack(builder, _o.Cardatas[_j]);
				_cardatas = CreateCardatasVector(builder, __cardatas);
			}
			var _catstadatas = default(VectorOffset);
			if (_o.Catstadatas != null)
			{
				var __catstadatas = new Offset<CatstaData>[_o.Catstadatas.Count];
				for (var _j = 0; _j < _o.Catstadatas.Count; ++_j)
					__catstadatas[_j] = CatstaData.Pack(builder, _o.Catstadatas[_j]);
				_catstadatas = CreateCatstadatasVector(builder, __catstadatas);
			}
			var _onetimeeventdata = _o.Onetimeeventdata == null ? default(Offset<OneTimeEventData>) : OneTimeEventData.Pack(builder, _o.Onetimeeventdata);
			var _factorydata = _o.Factorydata == null ? default(Offset<FactoryData>) : FactoryData.Pack(builder, _o.Factorydata);
			var _moneysafedata = _o.Moneysafedata == null ? default(Offset<MoneySafeData>) : MoneySafeData.Pack(builder, _o.Moneysafedata);
			var _buffobjects = default(VectorOffset);
			if (_o.Buffobjects != null)
			{
				var __buffobjects = new Offset<ItemData>[_o.Buffobjects.Count];
				for (var _j = 0; _j < _o.Buffobjects.Count; ++_j)
					__buffobjects[_j] = ItemData.Pack(builder, _o.Buffobjects[_j]);
				_buffobjects = CreateBuffobjectsVector(builder, __buffobjects);
			}
			var _investdata = _o.Investdata == null ? default(Offset<InvestData>) : InvestData.Pack(builder, _o.Investdata);
			var _onetimeeventhistorydata = default(VectorOffset);
			if (_o.Onetimeeventhistorydata != null)
			{
				var __onetimeeventhistorydata = new Offset<OneTimeEventHistoryData>[_o.Onetimeeventhistorydata.Count];
				for (var _j = 0; _j < _o.Onetimeeventhistorydata.Count; ++_j)
					__onetimeeventhistorydata[_j] = OneTimeEventHistoryData.Pack(builder, _o.Onetimeeventhistorydata[_j]);
				_onetimeeventhistorydata = CreateOnetimeeventhistorydataVector(builder, __onetimeeventhistorydata);
			}
			var _parkinglots = default(VectorOffset);
			if (_o.Parkinglots != null)
			{
				var __parkinglots = _o.Parkinglots.ToArray();
				_parkinglots = CreateParkinglotsVector(builder, __parkinglots);
			}
			var _invitedata = _o.Invitedata == null ? default(Offset<InviteData>) : InviteData.Pack(builder, _o.Invitedata);
			var _managerdata = default(VectorOffset);
			if (_o.Managerdata != null)
			{
				var __managerdata = new Offset<ManagerData>[_o.Managerdata.Count];
				for (var _j = 0; _j < _o.Managerdata.Count; ++_j)
					__managerdata[_j] = ManagerData.Pack(builder, _o.Managerdata[_j]);
				_managerdata = CreateManagerdataVector(builder, __managerdata);
			}
			var _regionstagedata = default(VectorOffset);
			if (_o.Regionstagedata != null)
			{
				var __regionstagedata = new Offset<RegionStageData>[_o.Regionstagedata.Count];
				for (var _j = 0; _j < _o.Regionstagedata.Count; ++_j)
					__regionstagedata[_j] = RegionStageData.Pack(builder, _o.Regionstagedata[_j]);
				_regionstagedata = CreateRegionstagedataVector(builder, __regionstagedata);
			}
			var _managerkeyadddata = _o.Managerkeyadddata == null ? default(Offset<ManagerKeyAddData>) : ManagerKeyAddData.Pack(builder, _o.Managerkeyadddata);
			var _specialdayroulette = _o.Specialdayroulette == null ? default(Offset<RouletteData>) : RouletteData.Pack(builder, _o.Specialdayroulette);
			var _superstaff = default(VectorOffset);
			if (_o.Superstaff != null)
			{
				var __superstaff = new Offset<SuperStaffData>[_o.Superstaff.Count];
				for (var _j = 0; _j < _o.Superstaff.Count; ++_j)
					__superstaff[_j] = SuperStaffData.Pack(builder, _o.Superstaff[_j]);
				_superstaff = CreateSuperstaffVector(builder, __superstaff);
			}
			var _seasonaldata = _o.Seasonaldata == null ? default(Offset<SeasonalData>) : SeasonalData.Pack(builder, _o.Seasonaldata);
			var _tarot = _o.Tarot == null ? default(Offset<TarotData>) : TarotData.Pack(builder, _o.Tarot);
			var _auction = _o.Auction == null ? default(Offset<AuctionData>) : AuctionData.Pack(builder, _o.Auction);
			var _specialday = _o.Specialday == null ? default(Offset<SpecialDayData>) : SpecialDayData.Pack(builder, _o.Specialday);
			var _adsupplypiggy = _o.Adsupplypiggy == null ? default(Offset<AdsupplyPiggy>) : AdsupplyPiggy.Pack(builder, _o.Adsupplypiggy);
			var _abilityinvestdata = default(VectorOffset);
			if (_o.Abilityinvestdata != null)
			{
				var __abilityinvestdata = new Offset<InvestData>[_o.Abilityinvestdata.Count];
				for (var _j = 0; _j < _o.Abilityinvestdata.Count; ++_j)
					__abilityinvestdata[_j] = InvestData.Pack(builder, _o.Abilityinvestdata[_j]);
				_abilityinvestdata = CreateAbilityinvestdataVector(builder, __abilityinvestdata);
			}
			var _richachieve = _o.Richachieve == null ? default(Offset<RichAchieve>) : RichAchieve.Pack(builder, _o.Richachieve);
			var _catstaeventdata = default(VectorOffset);
			if (_o.Catstaeventdata != null)
			{
				var __catstaeventdata = new Offset<CatstaEventData>[_o.Catstaeventdata.Count];
				for (var _j = 0; _j < _o.Catstaeventdata.Count; ++_j)
					__catstaeventdata[_j] = CatstaEventData.Pack(builder, _o.Catstaeventdata[_j]);
				_catstaeventdata = CreateCatstaeventdataVector(builder, __catstaeventdata);
			}
			var _anniversaryeventdata = _o.Anniversaryeventdata == null ? default(Offset<AnniversaryEventData>) : AnniversaryEventData.Pack(builder, _o.Anniversaryeventdata);
			var _attendanceeventdata = default(VectorOffset);
			if (_o.Attendanceeventdata != null)
			{
				var __attendanceeventdata = new Offset<AttendanceEventData>[_o.Attendanceeventdata.Count];
				for (var _j = 0; _j < _o.Attendanceeventdata.Count; ++_j)
					__attendanceeventdata[_j] = AttendanceEventData.Pack(builder, _o.Attendanceeventdata[_j]);
				_attendanceeventdata = CreateAttendanceeventdataVector(builder, __attendanceeventdata);
			}
			var _contentsmissiondata = default(VectorOffset);
			if (_o.Contentsmissiondata != null)
			{
				var __contentsmissiondata = new Offset<ContentsMissionData>[_o.Contentsmissiondata.Count];
				for (var _j = 0; _j < _o.Contentsmissiondata.Count; ++_j)
					__contentsmissiondata[_j] = ContentsMissionData.Pack(builder, _o.Contentsmissiondata[_j]);
				_contentsmissiondata = CreateContentsmissiondataVector(builder, __contentsmissiondata);
			}
			var _buyparkinglotdata = default(VectorOffset);
			if (_o.Buyparkinglotdata != null)
			{
				var __buyparkinglotdata = new Offset<BuyParkingLotData>[_o.Buyparkinglotdata.Count];
				for (var _j = 0; _j < _o.Buyparkinglotdata.Count; ++_j)
					__buyparkinglotdata[_j] = BuyParkingLotData.Pack(builder, _o.Buyparkinglotdata[_j]);
				_buyparkinglotdata = CreateBuyparkinglotdataVector(builder, __buyparkinglotdata);
			}
			var _richwaydata = _o.Richwaydata == null ? default(Offset<RichWayData>) : RichWayData.Pack(builder, _o.Richwaydata);
			var _bizacqdata = _o.Bizacqdata == null ? default(Offset<BizAcqData>) : BizAcqData.Pack(builder, _o.Bizacqdata);
			var _currencydata = default(VectorOffset);
			if (_o.Currencydata != null)
			{
				var __currencydata = new Offset<CurrencyData>[_o.Currencydata.Count];
				for (var _j = 0; _j < _o.Currencydata.Count; ++_j)
					__currencydata[_j] = CurrencyData.Pack(builder, _o.Currencydata[_j]);
				_currencydata = CreateCurrencydataVector(builder, __currencydata);
			}
			var _submissiondata = default(VectorOffset);
			if (_o.Submissiondata != null)
			{
				var __submissiondata = new Offset<SubMissionData>[_o.Submissiondata.Count];
				for (var _j = 0; _j < _o.Submissiondata.Count; ++_j)
					__submissiondata[_j] = SubMissionData.Pack(builder, _o.Submissiondata[_j]);
				_submissiondata = CreateSubmissiondataVector(builder, __submissiondata);
			}
			var _segmentdata = _o.Segmentdata == null ? default(Offset<SegmentData>) : SegmentData.Pack(builder, _o.Segmentdata);
			var _adpassdata = _o.Adpassdata == null ? default(Offset<AdpassData>) : AdpassData.Pack(builder, _o.Adpassdata);
			var _boosterbuffdata = default(VectorOffset);
			if (_o.Boosterbuffdata != null)
			{
				var __boosterbuffdata = new Offset<BoosterBuffData>[_o.Boosterbuffdata.Count];
				for (var _j = 0; _j < _o.Boosterbuffdata.Count; ++_j)
					__boosterbuffdata[_j] = BoosterBuffData.Pack(builder, _o.Boosterbuffdata[_j]);
				_boosterbuffdata = CreateBoosterbuffdataVector(builder, __boosterbuffdata);
			}
			var _specialpackagedata = default(VectorOffset);
			if (_o.Specialpackagedata != null)
			{
				var __specialpackagedata = new Offset<SpecialPackageData>[_o.Specialpackagedata.Count];
				for (var _j = 0; _j < _o.Specialpackagedata.Count; ++_j)
					__specialpackagedata[_j] = SpecialPackageData.Pack(builder, _o.Specialpackagedata[_j]);
				_specialpackagedata = CreateSpecialpackagedataVector(builder, __specialpackagedata);
			}
			var _ceocostumeowneddata = _o.Ceocostumeowneddata == null ? default(Offset<CeoCostumeOwnedData>) : CeoCostumeOwnedData.Pack(builder, _o.Ceocostumeowneddata);
			var _minigamedata = _o.Minigamedata == null ? default(Offset<MiniGameData>) : MiniGameData.Pack(builder, _o.Minigamedata);
			var _companylistrefreshdata = _o.Companylistrefreshdata == null ? default(Offset<CompanyListRefreshData>) : CompanyListRefreshData.Pack(builder, _o.Companylistrefreshdata);
			var _region1missiondata = _o.Region1missiondata == null ? default(Offset<RegionMissionData>) : RegionMissionData.Pack(builder, _o.Region1missiondata);
			StartUserData(builder);
			AddMoney(builder, _money);
			AddCash(builder, _o.Cash);
			AddPower(builder, _o.Power);
			AddLevel(builder, _o.Level);
			AddBuyinappids(builder, _buyinappids);
			AddTutorial(builder, _tutorial);
			AddLastlogintime(builder, _o.Lastlogintime);
			AddRecordvalue(builder, _recordvalue);
			AddRecordcount(builder, _recordcount);
			AddOptiondata(builder, _optiondata);
			AddGamenotifications(builder, _gamenotifications);
			AddFirststarttime(builder, _o.Firststarttime);
			AddStageidx(builder, _o.Stageidx);
			AddCompanylist(builder, _companylist);
			AddCompanies(builder, _companies);
			AddOffices(builder, _offices);
			AddMissions(builder, _missions);
			AddCompanyrefreshtime(builder, _o.Companyrefreshtime);
			AddOpenzone(builder, _openzone);
			AddOpenbuilding(builder, _openbuilding);
			AddRoulette(builder, _roulette);
			AddChatdatas(builder, _chatdatas);
			AddChardata(builder, _chardata);
			AddBankdata(builder, _bankdata);
			AddOfflinedata(builder, _offlinedata);
			AddAdsupplytime(builder, _o.Adsupplytime);
			AddItems(builder, _items);
			AddPlants(builder, _plants);
			AddGempass(builder, _gempass);
			AddShopdata(builder, _shopdata);
			AddUnlockcompany(builder, _unlockcompany);
			AddDailyquestdata(builder, _dailyquestdata);
			AddBuildingdatas(builder, _buildingdatas);
			AddPoint(builder, _o.Point);
			AddCardatas(builder, _cardatas);
			AddEquipcar(builder, _o.Equipcar);
			AddCatstadatas(builder, _catstadatas);
			AddPermission(builder, _o.Permission);
			AddOnetimeeventdata(builder, _onetimeeventdata);
			AddFactorydata(builder, _factorydata);
			AddMoneysafedata(builder, _moneysafedata);
			AddBuffobjects(builder, _buffobjects);
			AddExpadresettime(builder, _o.Expadresettime);
			AddExpadviewcount(builder, _o.Expadviewcount);
			AddInvestdata(builder, _investdata);
			AddOnetimeeventhistorydata(builder, _onetimeeventhistorydata);
			AddParkinglots(builder, _parkinglots);
			AddInvitedata(builder, _invitedata);
			AddAbtestdata(builder, _o.Abtestdata);
			AddManagerdata(builder, _managerdata);
			AddRegionstagedata(builder, _regionstagedata);
			AddActiveregion(builder, _o.Activeregion);
			AddCommonlastlogintime(builder, _o.Commonlastlogintime);
			AddManagerkeyadddata(builder, _managerkeyadddata);
			AddSpecialdayroulette(builder, _specialdayroulette);
			AddSuperstaff(builder, _superstaff);
			AddSeasonaldata(builder, _seasonaldata);
			AddTarot(builder, _tarot);
			AddAuction(builder, _auction);
			AddSpecialday(builder, _specialday);
			AddAdsupplypiggy(builder, _adsupplypiggy);
			AddAbilityinvestdata(builder, _abilityinvestdata);
			AddRichachieve(builder, _richachieve);
			AddCatstaeventdata(builder, _catstaeventdata);
			AddCheataddtimesec(builder, _o.Cheataddtimesec);
			AddRecommentcompanyidx(builder, _o.Recommentcompanyidx);
			AddAnniversaryeventdata(builder, _anniversaryeventdata);
			AddAttendanceeventdata(builder, _attendanceeventdata);
			AddContentsmissiondata(builder, _contentsmissiondata);
			AddBuyparkinglotdata(builder, _buyparkinglotdata);
			AddRichwaydata(builder, _richwaydata);
			AddBizacqdata(builder, _bizacqdata);
			AddCurrencydata(builder, _currencydata);
			AddSubmissiondata(builder, _submissiondata);
			AddSegmentdata(builder, _segmentdata);
			AddAdpassdata(builder, _adpassdata);
			AddBoosterbuffdata(builder, _boosterbuffdata);
			AddSpecialpackagedata(builder, _specialpackagedata);
			AddCeocostumeowneddata(builder, _ceocostumeowneddata);
			AddMinigamedata(builder, _minigamedata);
			AddCompanylistrefreshdata(builder, _companylistrefreshdata);
			AddRegion1missiondata(builder, _region1missiondata);
			return EndUserData(builder);
		}
	}
}
