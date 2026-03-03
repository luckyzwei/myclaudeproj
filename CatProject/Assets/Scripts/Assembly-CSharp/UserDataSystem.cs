using System;
using System.Collections.Generic;
using System.Numerics;
using Treeplla.Data;
using UniRx;

public class UserDataSystem
{
	public delegate void RewardSetDelegate(int rewardType, int rewardIdx, BigInteger rewardCnt, BigInteger resultCnt);

	private readonly string dataFileName;

	private readonly string backupTimeKey;

	private readonly string backupFormat;

	private readonly int backupPeriod;

	private UserData flatBufferUserData;

	private float saveWaitStandardTime;

	private float deltaTime;

	private bool saving;

	private bool isSafeData;

	public bool Bgm;

	public bool Effect;

	public bool Vib;

	public bool SlowGraphic;

	public Config.Language Language;

	public bool CompanyLvUpAtOnce;

	public Queue<int> RandomSeeds;

	public List<string> CouponList;

	public IReactiveCollection<PlantData> PlantData;

	public List<CatstaData> CatstaData;

	public List<CatstaEventData> CatstaEventData;

	public AdsSupplyBankData AdsSupplyBankData;

	public RichAchieveData RichAchieveData;

	public BizAcqUserData BizAcqUserData;

	public Dictionary<int, SubMissionSaveData> SubMissionSaveDataMap;

	public List<BuyParkingLotData> BuyParkingLotData;

	public List<BoosterBuffUserData> BoosterBuffDataList;

	private UserDataEvent eventData;

	private UserDataTravel travelData;

	public int WatchCount;

	public int WatchInterval;

	public BigInteger HeartBeatCount;

	public DateTime CommonLastLoginTime;

	public DateTime FirstLoginTime;

	public GameType LastMode;

	public IReactiveProperty<BigInteger> HUDMoney;

	public IReactiveProperty<int> HUDCash;

	public IReactiveProperty<int> HUDPower;

	public IReactiveProperty<int> HUDPermission;

	public IReactiveCollection<SuperStaffCardData> SuperStaffData;

	public IReactiveCollection<ManagerCardData> ManagerData;

	public Dictionary<int, RewardSetDelegate> RewardSetDelegateMap;

	public SegmentType UserSegmentType;

	public string UserSegmentID;

	public IReactiveProperty<int> Cash { get; private set; }

	public IReactiveProperty<int> Permission { get; private set; }

	public IReactiveCollection<string> BuyInappIds { get; private set; }

	public List<string> Tutorial { get; private set; }

	public Dictionary<string, int> RecordCount { get; private set; }

	public Dictionary<string, long> RecordValue { get; private set; }

	public IReactiveCollection<string> GameNotifications { get; private set; }

	public IReactiveProperty<int> Level { get; set; }

	public IReactiveCollection<ItemData> ItemData { get; set; }

	public IReactiveCollection<CurrencyUserData> CurrencyDataList { get; set; }

	public ShopData ShopData { get; set; }

	public RouletteData RouletteData { get; set; }

	public RouletteData SpecialDayRouletteData { get; set; }

	public PhoneData PhoneData { get; set; }

	public CeoData CeoData { get; set; }

	public GemPassData GemPassData { get; set; }

	public FactoryData FactoryData { get; set; }

	public DailyQuestData DailyQuestData { get; set; }

	public WorldmapData WorldmapData { get; set; }

	public CeoCostumeUserData CeoCostumeData { get; set; }

	public OneTimeEventData OneTimeEventData { get; private set; }

	public List<OneTimeEventHistoryData> OneTimeEventHistoryData { get; private set; }

	public TarotData TarotData { get; set; }

	public AuctionData AuctionData { get; set; }

	public AnniversaryEventData AnniversaryEventData { get; private set; }

	public List<AttendanceEventData> AttendanceEventList { get; private set; }

	public Dictionary<E_ContentsMissionType, ContentsMissionUserData> ContentsMissionDataMap { get; private set; }

	public SpecialDayData SpecialDayData { get; set; }

	public InviteData InviteData { get; set; }

	public AdPassData AdPassData { get; set; }

	public IUserDataMode CurMode { get; private set; }

	public UserDataMain mainData { get; private set; }

	public EventData userEventData { get; private set; }

	public MiniGameUserData MiniGameUserData { get; private set; }

	public CompanyListRefreshUserData CompanyListRefreshData { get; private set; }

	public DataState DataState { get; private set; }

	public bool IsMainState => false;

	public int ABTestValue { get; set; }

	public ManagerKeyAddData ManagerKeyAddData { get; private set; }

	public UserDataEvent CurEventData => null;

	public void Update()
	{
	}

	public string GetSaveFilePath()
	{
		return null;
	}

	public string GetBackUpSaveFilePath(string backupformat)
	{
		return null;
	}

	public void InitDataState()
	{
	}

	public void Load()
	{
	}

	private void LoadBackupFile()
	{
	}

	public void Save(bool Immediately = false)
	{
	}

	private void SaveFile()
	{
	}

	private void InitClientData()
	{
	}

	private void ConnectReadOnlyDatas()
	{
	}

	public void ChangeDataMode(DataState state)
	{
	}

	private void SnycCollectionToDB<T, U>(IList<T> db, IEnumerable<U> collector) where T : class
	{
	}

	private void SnycCollectionToClient<T, U>(IList<T> db, IEnumerable<U> collector) where T : class, IReadOnlyData where U : class, IReadOnlyData
	{
	}

	public void SetRecordValue(Config.RecordKeys key, long value, params object[] objs)
	{
	}

	public long GetRecordValue(Config.RecordKeys key, params object[] objs)
	{
		return 0L;
	}

	public void ResetRecordCount(Config.RecordCountKeys idx, params object[] objs)
	{
	}

	public void AddRecordCount(Config.RecordCountKeys idx, int count, params object[] objs)
	{
	}

	public void SubtractRecordCount(Config.RecordCountKeys idx, int count, params object[] objs)
	{
	}

	public int GetRecordCount(Config.RecordCountKeys idx, params object[] objs)
	{
		return 0;
	}

	public void SetRecordCount(Config.RecordCountKeys idx, int count, params object[] objs)
	{
	}

	public void SyncHUDCurrency(int currencyID = -1)
	{
	}

	public void SetReward(IRewardItemData rewardItemData, bool hudRefresh = true, bool limitignore = false)
	{
	}

	public void SetReward(int rewardType, int rewardIdx, Config.RegionType rewardRegion, BigInteger rewardValue, bool hudRefresh = true, bool limitignore = false)
	{
	}

	public void SetReward(int rewardType, int rewardIdx, int rewardRegion, BigInteger rewardValue, bool hudRefresh = true, bool limitignore = false)
	{
	}

	private void SetReward_Seasonal(int rewardType, BigInteger rewardValue)
	{
	}

	public int AddPiggyCash(Config.E_PiggyGetType piggyGetType)
	{
		return 0;
	}

	public void ResetDaily()
	{
	}

	public void RemoveEventData()
	{
	}

	public void AddUpdateRewardNotify(in int rewardType, in RewardSetDelegate callBack)
	{
	}

	public void RemoveUpdateRewardNotify(in int rewardType, in RewardSetDelegate callBack)
	{
	}

	private void NotifySetReward(in int rewardType, in int rewardIdx, in BigInteger rewardCnt, in BigInteger resultCnt)
	{
	}

	private void NotifySetItem(int itemIdx)
	{
	}
}
