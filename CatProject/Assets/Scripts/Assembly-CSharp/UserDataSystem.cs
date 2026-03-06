using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using Google.FlatBuffers;
using Treeplla;
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

	public bool IsMainState { get { return DataState == DataState.Main; } }

	public int ABTestValue { get; set; }

	public ManagerKeyAddData ManagerKeyAddData { get; private set; }

	public UserDataEvent CurEventData { get { return eventData; } }

	public void Update()
	{
		if (saving) return;
		deltaTime += UnityEngine.Time.deltaTime;
		if (deltaTime >= saveWaitStandardTime)
		{
			deltaTime = 0f;
			Save();
		}
	}

	public string GetSaveFilePath()
	{
		return UnityEngine.Application.persistentDataPath + "/" + dataFileName;
	}

	public string GetBackUpSaveFilePath(string backupformat)
	{
		return UnityEngine.Application.persistentDataPath + "/" + string.Format(backupformat, System.DateTime.Now.ToString("yyyyMMdd"));
	}

	public void InitDataState()
	{
		HUDMoney = new ReactiveProperty<BigInteger>();
		HUDCash = new ReactiveProperty<int>();
		HUDPower = new ReactiveProperty<int>();
		HUDPermission = new ReactiveProperty<int>();
		Cash = new ReactiveProperty<int>();
		Permission = new ReactiveProperty<int>();
		Level = new ReactiveProperty<int>();
		BuyInappIds = new ReactiveCollection<string>();
		GameNotifications = new ReactiveCollection<string>();
		ItemData = new ReactiveCollection<ItemData>();
		CurrencyDataList = new ReactiveCollection<CurrencyUserData>();
		PlantData = new ReactiveCollection<PlantData>();
		SuperStaffData = new ReactiveCollection<SuperStaffCardData>();
		ManagerData = new ReactiveCollection<ManagerCardData>();
		Tutorial = new List<string>();
		RecordCount = new Dictionary<string, int>();
		RecordValue = new Dictionary<string, long>();
		RewardSetDelegateMap = new Dictionary<int, RewardSetDelegate>();
		RandomSeeds = new Queue<int>();
		CouponList = new List<string>();
		CatstaData = new List<CatstaData>();
		CatstaEventData = new List<CatstaEventData>();
		SubMissionSaveDataMap = new Dictionary<int, SubMissionSaveData>();
		BuyParkingLotData = new List<BuyParkingLotData>();
		BoosterBuffDataList = new List<BoosterBuffUserData>();
		OneTimeEventHistoryData = new List<OneTimeEventHistoryData>();
		AttendanceEventList = new List<AttendanceEventData>();
		ContentsMissionDataMap = new Dictionary<E_ContentsMissionType, ContentsMissionUserData>();
		DataState = DataState.Main;
	}

	public void Load()
	{
		string path = GetSaveFilePath();
		if (!File.Exists(path))
		{
			LoadBackupFile();
			return;
		}
		try
		{
			byte[] bytes = File.ReadAllBytes(path);
			ByteBuffer bb = new ByteBuffer(bytes);
			flatBufferUserData = UserData.GetRootAsUserData(bb);
			InitClientData();
			ConnectReadOnlyDatas();
			isSafeData = true;
		}
		catch (Exception)
		{
			LoadBackupFile();
		}
	}

	private void LoadBackupFile()
	{
		string backupPath = GetBackUpSaveFilePath(backupFormat);
		if (!File.Exists(backupPath)) return;
		try
		{
			byte[] bytes = File.ReadAllBytes(backupPath);
			ByteBuffer bb = new ByteBuffer(bytes);
			flatBufferUserData = UserData.GetRootAsUserData(bb);
			InitClientData();
			ConnectReadOnlyDatas();
			isSafeData = true;
		}
		catch (Exception)
		{
			// backup load failed
		}
	}

	public void Save(bool Immediately = false)
	{
		if (Immediately)
		{
			SaveFile();
			return;
		}
		saving = true;
		SaveFile();
		saving = false;
	}

	private void SaveFile()
	{
		try
		{
			string path = GetSaveFilePath();
			FlatBufferBuilder builder = new FlatBufferBuilder(1024);
			// serialize user data to flatbuffer and write
			byte[] data = builder.SizedByteArray();
			File.WriteAllBytes(path, data);
			isSafeData = true;
		}
		catch (Exception)
		{
			// save failed
		}
	}

	private void InitClientData()
	{
		if (flatBufferUserData == null) return;
		InitDataState();
		// Populate client data from flatbuffer
		CurMode = mainData;
	}

	private void ConnectReadOnlyDatas()
	{
		SyncHUDCurrency();
	}

	public void ChangeDataMode(DataState state)
	{
		DataState = state;
	}

	private void SnycCollectionToDB<T, U>(IList<T> db, IEnumerable<U> collector) where T : class
	{
		if (db == null || collector == null) return;
		db.Clear();
		foreach (var item in collector)
		{
			db.Add(item as T);
		}
	}

	private void SnycCollectionToClient<T, U>(IList<T> db, IEnumerable<U> collector) where T : class, IReadOnlyData where U : class, IReadOnlyData
	{
		if (db == null || collector == null) return;
		db.Clear();
		foreach (var item in collector)
		{
			var clone = item.Clone() as T;
			if (clone != null)
				db.Add(clone);
		}
	}

	public void SetRecordValue(Config.RecordKeys key, long value, params object[] objs)
	{
		if (RecordValue == null) RecordValue = new Dictionary<string, long>();
		string k = key.ToString();
		if (objs != null && objs.Length > 0) k += "_" + string.Join("_", objs);
		RecordValue[k] = value;
	}

	public long GetRecordValue(Config.RecordKeys key, params object[] objs)
	{
		if (RecordValue == null) return 0L;
		string k = key.ToString();
		if (objs != null && objs.Length > 0) k += "_" + string.Join("_", objs);
		long v;
		return RecordValue.TryGetValue(k, out v) ? v : 0L;
	}

	public void ResetRecordCount(Config.RecordCountKeys idx, params object[] objs)
	{
		SetRecordCount(idx, 0, objs);
	}

	public void AddRecordCount(Config.RecordCountKeys idx, int count, params object[] objs)
	{
		SetRecordCount(idx, GetRecordCount(idx, objs) + count, objs);
	}

	public void SubtractRecordCount(Config.RecordCountKeys idx, int count, params object[] objs)
	{
		SetRecordCount(idx, GetRecordCount(idx, objs) - count, objs);
	}

	public int GetRecordCount(Config.RecordCountKeys idx, params object[] objs)
	{
		if (RecordCount == null) return 0;
		string k = idx.ToString();
		if (objs != null && objs.Length > 0) k += "_" + string.Join("_", objs);
		int v;
		return RecordCount.TryGetValue(k, out v) ? v : 0;
	}

	public void SetRecordCount(Config.RecordCountKeys idx, int count, params object[] objs)
	{
		if (RecordCount == null) RecordCount = new Dictionary<string, int>();
		string k = idx.ToString();
		if (objs != null && objs.Length > 0) k += "_" + string.Join("_", objs);
		RecordCount[k] = count;
	}

	public void SyncHUDCurrency(int currencyID = -1)
	{
		if (CurMode == null) return;
		if (currencyID < 0 || currencyID == (int)Config.CurrencyID.Cash)
		{
			if (Cash != null && HUDCash != null) HUDCash.Value = Cash.Value;
		}
		if (currencyID < 0 || currencyID == (int)Config.CurrencyID.Permission)
		{
			if (Permission != null && HUDPermission != null) HUDPermission.Value = Permission.Value;
		}
	}

	public void SetReward(IRewardItemData rewardItemData, bool hudRefresh = true, bool limitignore = false)
	{
		if (rewardItemData == null) return;
		if (!rewardItemData.EnableReward()) return;
		// Delegate to typed SetReward with extracted reward info
	}

	public void SetReward(int rewardType, int rewardIdx, Config.RegionType rewardRegion, BigInteger rewardValue, bool hudRefresh = true, bool limitignore = false)
	{
		SetReward(rewardType, rewardIdx, (int)rewardRegion, rewardValue, hudRefresh, limitignore);
	}

	public void SetReward(int rewardType, int rewardIdx, int rewardRegion, BigInteger rewardValue, bool hudRefresh = true, bool limitignore = false)
	{
		if (rewardValue <= BigInteger.Zero) return;
		BigInteger resultCnt = BigInteger.Zero;

		switch ((Config.RewardType)rewardType)
		{
			case Config.RewardType.Currency:
				if (rewardIdx == (int)Config.CurrencyID.Cash)
				{
					Cash.Value += (int)rewardValue;
					resultCnt = new BigInteger(Cash.Value);
				}
				else if (rewardIdx == (int)Config.CurrencyID.Permission)
				{
					Permission.Value += (int)rewardValue;
					resultCnt = new BigInteger(Permission.Value);
				}
				break;
			case Config.RewardType.Item:
				NotifySetItem(rewardIdx);
				break;
			case Config.RewardType.Manager:
				var root = Singleton<GameRoot>.Instance;
				if (root != null && root.ManagerCardSystem != null)
					root.ManagerCardSystem.AddManager(rewardIdx, (int)rewardValue);
				break;
		}

		NotifySetReward(rewardType, rewardIdx, rewardValue, resultCnt);

		if (hudRefresh)
			SyncHUDCurrency();
	}

	private void SetReward_Seasonal(int rewardType, BigInteger rewardValue)
	{
		if (rewardValue <= BigInteger.Zero) return;
		SetReward(rewardType, 0, Config.RegionType.None, rewardValue);
	}

	public int AddPiggyCash(Config.E_PiggyGetType piggyGetType)
	{
		return 0;
	}

	public void ResetDaily()
	{
		ResetRecordCount(Config.RecordCountKeys.DailyAdWatchCount);
		WatchCount = 0;
	}

	public void RemoveEventData()
	{
		eventData = null;
	}

	public void AddUpdateRewardNotify(in int rewardType, in RewardSetDelegate callBack)
	{
		if (RewardSetDelegateMap == null) RewardSetDelegateMap = new Dictionary<int, RewardSetDelegate>();
		if (RewardSetDelegateMap.ContainsKey(rewardType))
			RewardSetDelegateMap[rewardType] += callBack;
		else
			RewardSetDelegateMap[rewardType] = callBack;
	}

	public void RemoveUpdateRewardNotify(in int rewardType, in RewardSetDelegate callBack)
	{
		if (RewardSetDelegateMap == null) return;
		if (RewardSetDelegateMap.ContainsKey(rewardType))
		{
			RewardSetDelegateMap[rewardType] -= callBack;
			if (RewardSetDelegateMap[rewardType] == null)
				RewardSetDelegateMap.Remove(rewardType);
		}
	}

	private void NotifySetReward(in int rewardType, in int rewardIdx, in BigInteger rewardCnt, in BigInteger resultCnt)
	{
		if (RewardSetDelegateMap == null) return;
		RewardSetDelegate del;
		if (RewardSetDelegateMap.TryGetValue(rewardType, out del))
			del?.Invoke(rewardType, rewardIdx, rewardCnt, resultCnt);
	}

	private void NotifySetItem(int itemIdx)
	{
	}
}
