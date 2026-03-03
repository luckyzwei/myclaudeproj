using System;
using System.Collections.Generic;
using Treeplla;
using UniRx;

public class ShopSystem
{
	public enum PackageShowGameType
	{
		None = -1,
		Main = 0,
		Seasonal = 1,
		Factory = 2
	}

	public enum PackageShowType
	{
		None = -1,
		Shop = 1,
		ShopAndHud = 2,
		Hud = 3,
		BizAcquisition = 4
	}

	public enum InAppPurchaseLocation
	{
		none = -1,
		shop = 0,
		popup = 1,
		hud = 2,
		other = 3,
		nomoney = 4,
		banner = 5,
		hud_acq = 6,
		s_enter = 7,
		popup_chain = 8,
		hud_order = 9,
		mission = 10,
		station = 11,
		banner_assign = 12,
		banner_result = 13,
		reward = 14,
		repopup = 100,
		fail = 101
	}

	public enum PackageGroup
	{
		Starter = 1,
		Move = 100,
		MoveHigh = 201,
		DevPack1 = 202,
		DEVPACK_MAX = 299,
		SeasonalAllinOne = 300,
		Uniform2 = 501,
		UNIFORM_MAX = 599,
		Manager = 1000,
		Desk = 1001,
		SeasonalSpecial = 1003,
		Normal = 2000,
		BizAcquisition = 2001,
		NoTimeLimit = 3001
	}

	public static class PackageGroupHelper
	{
		public static bool IsMovePackage(int packageGroup)
		{
			return false;
		}

		public static int GetMovePackageRegionIdx(int packageGroup)
		{
			return 0;
		}

		public static bool IsDevPackPackage(int packageGroup)
		{
			return false;
		}

		public static int GetDevPackRegionIdx(int packageGroup)
		{
			return 0;
		}

		public static bool IsUniformPackage(int packageGroup)
		{
			return false;
		}

		public static int GetNowStageMovePackageIdx()
		{
			return 0;
		}
	}

	public enum SeasonalPackageMatchType
	{
		NONE = 0,
		COIN = 1,
		SKILLBOOK = 2,
		LEVELUP = 3
	}

	private bool noAds;

	public const int ShopPackageFactorySlotIdx = 1001;

	public const int NormalKey_ShopGoodsIdx = 10001;

	public const int PremiumKey_ShopGoodsIdx = 10002;

	public const int NormalKey_ShopSpecialIdx = 13;

	public const int PremiumKey_ShopSpecialIdx = 14;

	public const int ShopSaleIdx_AcqWeeklyShop = 1000;

	public const string ManagerLevelUp5ProductId = "officecat_ceo_levelup_1";

	public List<int> InGemPass;

	public bool InMultiRevenue;

	public bool InMaxOfflineAdd;

	public bool InMaxOfflineAddNew;

	public bool InBuyBizAcqBattleSpeedSpecialPackage;

	public List<bool> InBuyBizStagePassSpecialPackageList;

	public bool IsPackagInit;

	public Subject<bool> OnNoAdsChanged;

	public InAppPurchaseLocation curLocation;

	public Dictionary<int, IReactiveProperty<int>> FreeItemTimes;

	public bool InMultiRevenueSale;

	private DateTime EndMRSaleTime;

	public IReactiveProperty<int> RemainMRSaleTime;

	private DateTime NextNoAdsSaleTime;

	public IReactiveProperty<int> RemainNoAdsSaleTime;

	public IReactiveProperty<int> RemainPlayerLvPassSaleTime;

	public static readonly int StartPackageIdx;

	public static readonly int StartHighPackageIdx;

	public static readonly int ManagerOpenPackageIdx;

	public static readonly int CompanyExpTicketPackageIdx;

	private bool isHighStarterPackageBuy;

	public Subject<int> SeasonalFreeCoinReset;

	public IReactiveProperty<int> SeasonalFreeCoinResetRemainTimeSec;

	private DateTime SeasonalFreeCoinNextResetDateTime;

	private DateTime SeasonalFreeCoinDayResetDateTime;

	private int SeasonalFreeCoinProductIdx;

	private int seasonal_shop_free_coin_cooltime;

	public static readonly int SeasonalCoinPackageIdx;

	public static readonly int SeasonalNewStartPackageIdx;

	public static readonly int SeasonalCoinPackage2Idx;

	public Dictionary<SeasonalPackageMatchType, List<int>> SeasonalPackageMatchMap;

	private int CurSeasonalThemeIdx;

	private int HighestSeasonalPackage;

	public IReactiveProperty<int> RemainADManagerBoxCoolTime;

	public IReactiveProperty<int> RemainADManagerBoxResetTime;

	private DateTime NextShopSaleStartTime;

	private CompositeDisposable noadsDisposables;

	private CompositeDisposable playerlvpassDisposables;

	private CompositeDisposable managerDisposables;

	private CompositeDisposable NotificationDisposables;

	public Subject<(int purchaseIdx, int count)> OnPurchaseSuccess;

	public bool NoAds => false;

	public ShopState state { get; private set; }

	public bool ExpireNoAdsSale { get; private set; }

	public bool InNoAdsSale { get; private set; }

	public int noads_sale_start_player_lv { get; private set; }

	public int noads_sale_time { get; private set; }

	public int ads_sale_onemoretime { get; private set; }

	public int ads_sale_onemoretime2 { get; private set; }

	public bool ExpirePlayerLvPassSale { get; private set; }

	public bool InPlayerLvPassSale { get; private set; }

	public int playerlvpass_sale_start_player_lv { get; private set; }

	public int playerlvpass_sale_time { get; private set; }

	public Queue<int> WaitPackagePopups { get; private set; }

	public List<int> SeasonalEnablePackages { get; private set; }

	public int shop_ceo_box_normal_key_1_gem_price { get; private set; }

	public int shop_ceo_box_premium_key_1_gem_price { get; private set; }

	public int shop_ceo_box_normal_case_gem_price => 0;

	public int shop_ceo_box_premium_case_gem_price => 0;

	public int CurShopSaleIdx { get; private set; }

	public Config.E_ShopSaleListType CurShopSaleType { get; private set; }

	public IReactiveProperty<int> RemainShopSaleTime { get; private set; }

	public DateTime ShopSaleEndTime { get; private set; }

	public List<int> CurOpenShopSaleItems { get; private set; }

	public bool ShopSalePage1Noti { get; set; }

	public List<int> OpenedEndlessOfferIdxList { get; private set; }

	public int noads_popup_daily_count { get; private set; }

	public void Init(bool init = false, bool skipCheckPackage = false)
	{
	}

	public void InitShopSpecial()
	{
	}

	public void UpdateNoAds()
	{
	}

	public void SetMultiRevenue(bool value)
	{
	}

	public void SetMultiRevenueSale()
	{
	}

	private void SubscribeMultiRevenue()
	{
	}

	public void SetNoAdsSale(bool showPackage)
	{
	}

	private void CheckNoAdsSaleAndShowPopup()
	{
	}

	public void CheckNoAdsSale(bool showPopup = false)
	{
	}

	public void SetPlayerLvPassSale()
	{
	}

	public void KillPlayerLvPassSubscirbe()
	{
	}

	private void CheckPlayerLvPassSaleAndShowPopup()
	{
	}

	public void CheckPlayerLvPassSale()
	{
	}

	public void SubscribePackage()
	{
	}

	private void AddManagerLevelUpPackage(int managerIdx)
	{
	}

	public void SubscribeSpecialPackage()
	{
	}

	private void SubscribeManagerPackage()
	{
	}

	public void AllocFactorySlotPackage(Action packageOpenCb)
	{
	}

	public int AddDeskPackage(int level)
	{
		return 0;
	}

	private void SubscribeDeskPackage()
	{
	}

	private bool IgnoreSubscribePackage(int package_contents_open)
	{
		return false;
	}

	private void CheckExpiredPackageGroup()
	{
	}

	private void CheckSequencePackage()
	{
	}

	public void AllocManagerOpenPackage()
	{
	}

	public void UpdateSpecialPackage()
	{
	}

	public void UpdatePackage()
	{
	}

	public void CheckAndOpenPackageOffer(Config.E_PackageOfferType offerType, Action onComplete)
	{
	}

	public bool IsOpenPackage(int packageIdx)
	{
		return false;
	}

	public bool IsExistAnyPackageGroup(int packageGroup)
	{
		return false;
	}

	public bool IsBuyPackage(int packageIdx)
	{
		return false;
	}

	public void ChangeHighStarterPackage()
	{
	}

	public void ShowNextWaitPackagePopup(Action OnEnd = null)
	{
	}

	public static void GetPackageReward(ShopPackageData Info, Action OnEnd = null, bool ShowPageReward = true)
	{
	}

	public void InitSeasonalPackageMatch()
	{
	}

	public void AddSeasonalPackage(ContentsOpenSystem.OpenConditionType type, int value)
	{
	}

	public void AddSeasonalPackage(ContentsOpenSystem.OpenConditionSeasonalExceptionType type)
	{
	}

	public void AddSeasonalPackage(List<ShopPackageData> packageInfos)
	{
	}

	public bool ShowSeasonalPackageIgnoreGroup(int packageIdx)
	{
		return false;
	}

	public int GetMaxTimeLevelUpPackageIdx(int workshopIdx)
	{
		return 0;
	}

	private void SetFreeItems()
	{
	}

	public void GetFreeItem(int idx, Action cb)
	{
	}

	private void SetSeasonalFreeItem()
	{
	}

	public void ConsumeSeasonalFreeCoin()
	{
	}

	public void SetCycleLimitedShopGoods()
	{
	}

	private void SetADManagerBox()
	{
	}

	private void SetShopSale()
	{
	}

	private int GetCurShopSaleIdx()
	{
		return 0;
	}

	private DateTime GetNextShopSaleStartTime()
	{
		return default(DateTime);
	}

	private void SetShopSaleInfo()
	{
	}

	private void InitShopSaleItemContentsOpen()
	{
	}

	public void UpdateOpenShopSaleItems()
	{
	}

	public bool IsOpenShopSaleList(int idx)
	{
		return false;
	}

	private void InitShopSaleItemList()
	{
	}

	public void UpdateShopSalePackageResetTime(int idx, DateTime tryTime)
	{
	}

	public bool IsRemainSaleItemPurchaseTime(int idx)
	{
		return false;
	}

	public static void GetSalePackageReward(ShopSaleItemData Info, Action OnEnd = null)
	{
	}

	private void InitEndlessOfferList()
	{
	}

	private void UpdateEndlessOfferOpen()
	{
	}

	private void UpdateEndlessOffer()
	{
	}

	private void InitEndlessOffer(int offerIdx)
	{
	}

	public void UpdateOneSecond()
	{
	}

	private void UpdateOneSecondSeasonal(DateTime curTime)
	{
	}

	public void InappPurchase(string product_id, int itemIdx, Action OnSuccess, Action OnFailed = null)
	{
	}
}
