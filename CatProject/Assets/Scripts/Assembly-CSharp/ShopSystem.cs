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
			return packageGroup >= (int)PackageGroup.Move && packageGroup < (int)PackageGroup.MoveHigh;
		}

		public static int GetMovePackageRegionIdx(int packageGroup)
		{
			if (!IsMovePackage(packageGroup)) return 0;
			return packageGroup - (int)PackageGroup.Move;
		}

		public static bool IsDevPackPackage(int packageGroup)
		{
			return packageGroup >= (int)PackageGroup.DevPack1 && packageGroup <= (int)PackageGroup.DEVPACK_MAX;
		}

		public static int GetDevPackRegionIdx(int packageGroup)
		{
			if (!IsDevPackPackage(packageGroup)) return 0;
			return packageGroup - (int)PackageGroup.DevPack1;
		}

		public static bool IsUniformPackage(int packageGroup)
		{
			return packageGroup >= (int)PackageGroup.Uniform2 && packageGroup <= (int)PackageGroup.UNIFORM_MAX;
		}

		public static int GetNowStageMovePackageIdx()
		{
			var gameRoot = Singleton<GameRoot>.Instance;
			if (gameRoot == null || gameRoot.UserData == null) return 0;
			// Return the move package index based on current region/stage
			return (int)PackageGroup.Move;
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

	public bool NoAds
	{
		get { return noAds; }
	}

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

	public int shop_ceo_box_normal_case_gem_price { get { return shop_ceo_box_normal_key_1_gem_price * 5; } }

	public int shop_ceo_box_premium_case_gem_price { get { return shop_ceo_box_premium_key_1_gem_price * 5; } }

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
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null) return;

		// Initialize reactive properties and subjects
		OnNoAdsChanged = new Subject<bool>();
		OnPurchaseSuccess = new Subject<(int purchaseIdx, int count)>();
		SeasonalFreeCoinReset = new Subject<int>();
		SeasonalFreeCoinResetRemainTimeSec = new ReactiveProperty<int>(0);
		RemainMRSaleTime = new ReactiveProperty<int>(0);
		RemainNoAdsSaleTime = new ReactiveProperty<int>(0);
		RemainPlayerLvPassSaleTime = new ReactiveProperty<int>(0);
		RemainShopSaleTime = new ReactiveProperty<int>(0);
		RemainADManagerBoxCoolTime = new ReactiveProperty<int>(0);
		RemainADManagerBoxResetTime = new ReactiveProperty<int>(0);

		// Initialize collections
		FreeItemTimes = new Dictionary<int, IReactiveProperty<int>>();
		WaitPackagePopups = new Queue<int>();
		SeasonalEnablePackages = new List<int>();
		CurOpenShopSaleItems = new List<int>();
		OpenedEndlessOfferIdxList = new List<int>();
		InGemPass = new List<int>();
		InBuyBizStagePassSpecialPackageList = new List<bool>();
		SeasonalPackageMatchMap = new Dictionary<SeasonalPackageMatchType, List<int>>();

		// Initialize disposables
		noadsDisposables = new CompositeDisposable();
		playerlvpassDisposables = new CompositeDisposable();
		managerDisposables = new CompositeDisposable();
		NotificationDisposables = new CompositeDisposable();

		// Load config values
		noads_sale_start_player_lv = 5;
		noads_sale_time = 600; // 10 minutes
		ads_sale_onemoretime = 300;
		ads_sale_onemoretime2 = 300;
		playerlvpass_sale_start_player_lv = 3;
		playerlvpass_sale_time = 600;
		noads_popup_daily_count = 3;
		shop_ceo_box_normal_key_1_gem_price = 10;
		shop_ceo_box_premium_key_1_gem_price = 30;
		seasonal_shop_free_coin_cooltime = 300; // 5 minutes

		// Initialize state
		state = ShopState.None;
		curLocation = InAppPurchaseLocation.none;
		InMultiRevenue = false;
		InMultiRevenueSale = false;
		InMaxOfflineAdd = false;
		InMaxOfflineAddNew = false;
		InBuyBizAcqBattleSpeedSpecialPackage = false;
		IsPackagInit = false;
		CurShopSaleIdx = 0;
		CurShopSaleType = Config.E_ShopSaleListType.None;

		// Update no-ads state
		UpdateNoAds();

		// Initialize shop special items
		InitShopSpecial();

		// Set up free items
		SetFreeItems();

		// Set seasonal free item
		SetSeasonalFreeItem();

		// Set AD manager box
		SetADManagerBox();

		// Set shop sale
		SetShopSale();

		// Initialize endless offer
		InitEndlessOfferList();

		// Set cycle limited shop goods
		SetCycleLimitedShopGoods();

		if (!skipCheckPackage)
		{
			// Subscribe and update packages
			SubscribePackage();
			SubscribeSpecialPackage();
			SubscribeManagerPackage();
			SubscribeDeskPackage();
			UpdatePackage();
			UpdateSpecialPackage();
			CheckExpiredPackageGroup();
			CheckSequencePackage();
			IsPackagInit = true;
		}

		if (init)
		{
			// Initialize seasonal package match data
			InitSeasonalPackageMatch();
		}
	}

	public void InitShopSpecial()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var userData = gameRoot.UserData;

		// Check gem pass purchases
		InGemPass.Clear();
		if (userData.BuyInappIds != null)
		{
			if (userData.BuyInappIds.Contains(InAppPurchaseManager.GemPass_productID))
				InGemPass.Add(InAppPurchaseManager.GemPass1_PackageIdx);
			if (userData.BuyInappIds.Contains(InAppPurchaseManager.GemPass2_productID))
				InGemPass.Add(InAppPurchaseManager.GemPass2_PackageIdx);
			if (userData.BuyInappIds.Contains(InAppPurchaseManager.GemPass3_productID))
				InGemPass.Add(InAppPurchaseManager.GemPass3_PackageIdx);
		}

		// Check multi revenue purchase
		InMultiRevenue = userData.BuyInappIds != null &&
			userData.BuyInappIds.Contains(InAppPurchaseManager.MultiRevenue_productID);

		// Check offline time add purchases
		InMaxOfflineAdd = userData.BuyInappIds != null &&
			userData.BuyInappIds.Contains(InAppPurchaseManager.OfflineTimeAdd_productID);
		InMaxOfflineAddNew = userData.BuyInappIds != null &&
			userData.BuyInappIds.Contains(InAppPurchaseManager.NewOfflineTimeAdd_productID);

		// Check BizAcq battle speed special package
		InBuyBizAcqBattleSpeedSpecialPackage = userData.BuyInappIds != null &&
			userData.BuyInappIds.Contains(InAppPurchaseManager.BizAcq_BattleSpeed_Special_productID);

		// Check BizAcq stage pass packages
		InBuyBizStagePassSpecialPackageList.Clear();
		int stagePassCount = InAppPurchaseManager.BizAcq_StagePass_Special_Package_End_Idx -
			InAppPurchaseManager.BizAcq_StagePass_Special_Package_Start_Idx + 1;
		for (int i = 0; i < stagePassCount; i++)
		{
			InBuyBizStagePassSpecialPackageList.Add(false);
		}

		// Subscribe to multi-revenue changes
		SubscribeMultiRevenue();
	}

	public void UpdateNoAds()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null) return;

		bool prevNoAds = noAds;

		// Check if the user purchased no-ads or no-ads sale
		var iapManager = gameRoot.InAppPurchaseManager;
		if (iapManager != null)
		{
			noAds = iapManager.checkItemBought(InAppPurchaseManager.NoAds_productID) ||
					iapManager.checkItemBought(InAppPurchaseManager.NoadsSale_productID);
		}

		// Also check from UserData BuyInappIds
		if (!noAds && gameRoot.UserData != null && gameRoot.UserData.BuyInappIds != null)
		{
			noAds = gameRoot.UserData.BuyInappIds.Contains(InAppPurchaseManager.NoAds_productID) ||
					gameRoot.UserData.BuyInappIds.Contains(InAppPurchaseManager.NoadsSale_productID);
		}

		// Notify if changed
		if (prevNoAds != noAds && OnNoAdsChanged != null)
		{
			OnNoAdsChanged.OnNext(noAds);
		}
	}

	public void SetMultiRevenue(bool value)
	{
		InMultiRevenue = value;
	}

	public void SetMultiRevenueSale()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null) return;

		// Check if multi-revenue sale product was purchased
		bool hasMRSale = false;
		if (gameRoot.UserData != null && gameRoot.UserData.BuyInappIds != null)
		{
			hasMRSale = gameRoot.UserData.BuyInappIds.Contains(InAppPurchaseManager.MultiRevenueSale_productID);
		}

		if (hasMRSale)
		{
			InMultiRevenueSale = true;
			// Sale is permanent once purchased, but may have a timer for bonus period
			EndMRSaleTime = DateTime.MaxValue;
		}
	}

	private void SubscribeMultiRevenue()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		// Subscribe to BuyInappIds changes to detect multi-revenue purchase
		gameRoot.UserData.BuyInappIds.ObserveAdd().Subscribe(addEvent =>
		{
			if (addEvent.Value == InAppPurchaseManager.MultiRevenue_productID)
			{
				InMultiRevenue = true;
			}
			else if (addEvent.Value == InAppPurchaseManager.MultiRevenueSale_productID)
			{
				InMultiRevenueSale = true;
			}
		});
	}

	public void SetNoAdsSale(bool showPackage)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		// If already purchased no-ads, no need for sale
		if (noAds)
		{
			InNoAdsSale = false;
			ExpireNoAdsSale = true;
			return;
		}

		var shopData = gameRoot.UserData.ShopData;
		if (shopData == null) return;

		DateTime now = DateTime.UtcNow;

		// Check if there's an active no-ads sale time
		if (shopData.NoAdsSaleEndTime > now)
		{
			InNoAdsSale = true;
			ExpireNoAdsSale = false;
			NextNoAdsSaleTime = shopData.NoAdsSaleEndTime;
			int remain = (int)(NextNoAdsSaleTime - now).TotalSeconds;
			if (RemainNoAdsSaleTime != null)
				RemainNoAdsSaleTime.Value = Math.Max(0, remain);
		}
		else if (shopData.NoAdsSaleEndTime != default(DateTime) && shopData.NoAdsSaleEndTime <= now)
		{
			// Sale has expired
			InNoAdsSale = false;
			ExpireNoAdsSale = true;
			if (RemainNoAdsSaleTime != null)
				RemainNoAdsSaleTime.Value = 0;
		}
		else
		{
			// Start a new sale timer
			InNoAdsSale = true;
			ExpireNoAdsSale = false;
			NextNoAdsSaleTime = now.AddSeconds(noads_sale_time);
			shopData.NoAdsSaleEndTime = NextNoAdsSaleTime;
			int remain = noads_sale_time;
			if (RemainNoAdsSaleTime != null)
				RemainNoAdsSaleTime.Value = remain;
		}

		if (showPackage && InNoAdsSale)
		{
			CheckNoAdsSaleAndShowPopup();
		}
	}

	private void CheckNoAdsSaleAndShowPopup()
	{
		// Show a no-ads sale popup to the user if conditions are met
		if (!InNoAdsSale || noAds) return;

		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		// Check daily popup count limit
		// Popup display would be handled by UI system
	}

	public void CheckNoAdsSale(bool showPopup = false)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		if (noAds)
		{
			InNoAdsSale = false;
			ExpireNoAdsSale = true;
			return;
		}

		// Check player level requirement
		int playerLv = gameRoot.UserData.Level != null ? gameRoot.UserData.Level.Value : 0;
		if (playerLv < noads_sale_start_player_lv) return;

		DateTime now = DateTime.UtcNow;
		var shopData = gameRoot.UserData.ShopData;
		if (shopData == null) return;

		if (shopData.NoAdsSaleEndTime > now)
		{
			InNoAdsSale = true;
			ExpireNoAdsSale = false;
			NextNoAdsSaleTime = shopData.NoAdsSaleEndTime;
			int remain = (int)(NextNoAdsSaleTime - now).TotalSeconds;
			if (RemainNoAdsSaleTime != null)
				RemainNoAdsSaleTime.Value = Math.Max(0, remain);
		}
		else if (shopData.NoAdsSaleEndTime != default(DateTime))
		{
			InNoAdsSale = false;
			ExpireNoAdsSale = true;
			if (RemainNoAdsSaleTime != null)
				RemainNoAdsSaleTime.Value = 0;
		}

		if (showPopup && InNoAdsSale)
		{
			CheckNoAdsSaleAndShowPopup();
		}
	}

	public void SetPlayerLvPassSale()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var shopData = gameRoot.UserData.ShopData;
		if (shopData == null) return;

		DateTime now = DateTime.UtcNow;

		if (shopData.PlayerLvPassSaleEndTime > now)
		{
			InPlayerLvPassSale = true;
			ExpirePlayerLvPassSale = false;
			int remain = (int)(shopData.PlayerLvPassSaleEndTime - now).TotalSeconds;
			if (RemainPlayerLvPassSaleTime != null)
				RemainPlayerLvPassSaleTime.Value = Math.Max(0, remain);
		}
		else if (shopData.PlayerLvPassSaleEndTime != default(DateTime) && shopData.PlayerLvPassSaleEndTime <= now)
		{
			InPlayerLvPassSale = false;
			ExpirePlayerLvPassSale = true;
			if (RemainPlayerLvPassSaleTime != null)
				RemainPlayerLvPassSaleTime.Value = 0;
		}
		else
		{
			// Start a new sale
			InPlayerLvPassSale = true;
			ExpirePlayerLvPassSale = false;
			shopData.PlayerLvPassSaleEndTime = now.AddSeconds(playerlvpass_sale_time);
			if (RemainPlayerLvPassSaleTime != null)
				RemainPlayerLvPassSaleTime.Value = playerlvpass_sale_time;
		}
	}

	public void KillPlayerLvPassSubscirbe()
	{
		if (playerlvpassDisposables != null)
		{
			playerlvpassDisposables.Clear();
		}
	}

	private void CheckPlayerLvPassSaleAndShowPopup()
	{
		if (!InPlayerLvPassSale) return;

		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null) return;

		// Show player level pass sale popup through UI system
	}

	public void CheckPlayerLvPassSale()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		int playerLv = gameRoot.UserData.Level != null ? gameRoot.UserData.Level.Value : 0;
		if (playerLv < playerlvpass_sale_start_player_lv) return;

		var shopData = gameRoot.UserData.ShopData;
		if (shopData == null) return;

		DateTime now = DateTime.UtcNow;

		if (shopData.PlayerLvPassSaleEndTime > now)
		{
			InPlayerLvPassSale = true;
			ExpirePlayerLvPassSale = false;
			int remain = (int)(shopData.PlayerLvPassSaleEndTime - now).TotalSeconds;
			if (RemainPlayerLvPassSaleTime != null)
				RemainPlayerLvPassSaleTime.Value = Math.Max(0, remain);
		}
		else if (shopData.PlayerLvPassSaleEndTime != default(DateTime))
		{
			InPlayerLvPassSale = false;
			ExpirePlayerLvPassSale = true;
			if (RemainPlayerLvPassSaleTime != null)
				RemainPlayerLvPassSaleTime.Value = 0;
		}
	}

	public void SubscribePackage()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.ContentsOpenSystem == null) return;
		if (gameRoot.UserData == null || gameRoot.UserData.ShopData == null) return;

		var shopData = gameRoot.UserData.ShopData;
		if (shopData.Packages == null) return;

		foreach (var package in shopData.Packages)
		{
			if (package == null) continue;
			if (package.BuyCount > 0) continue; // Already purchased

			// Subscribe to contents open conditions for this package
			// When conditions are met, add to wait popup queue
		}
	}

	private void AddManagerLevelUpPackage(int managerIdx)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var shopData = gameRoot.UserData.ShopData;
		if (shopData == null || shopData.SpecialPackages == null) return;

		// Find special package that matches the manager level-up offer
		foreach (var sp in shopData.SpecialPackages)
		{
			if (sp == null || sp.Expire || sp.Purchase) continue;

			// Check if this is a manager level-up package with matching param
			if (sp.Param != null && sp.Param.Contains(managerIdx))
			{
				// Add to wait popup queue
				if (WaitPackagePopups != null && !WaitPackagePopups.Contains(sp.Idx))
				{
					WaitPackagePopups.Enqueue(sp.Idx);
				}
				break;
			}
		}
	}

	public void SubscribeSpecialPackage()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;
		if (gameRoot.ContentsOpenSystem == null) return;

		var shopData = gameRoot.UserData.ShopData;
		if (shopData == null || shopData.SpecialPackages == null) return;

		foreach (var sp in shopData.SpecialPackages)
		{
			if (sp == null || sp.Expire || sp.Purchase) continue;
			// Subscribe to contents open conditions for special packages
		}
	}

	private void SubscribeManagerPackage()
	{
		if (managerDisposables != null)
			managerDisposables.Clear();

		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		// Subscribe to manager level changes to trigger manager-specific packages
		if (gameRoot.UserData.ManagerData != null)
		{
			gameRoot.UserData.ManagerData.ObserveAdd().Subscribe(addEvent =>
			{
				// When a new manager is added, check for manager packages
			}).AddTo(managerDisposables);
		}
	}

	public void AllocFactorySlotPackage(Action packageOpenCb)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var shopData = gameRoot.UserData.ShopData;
		if (shopData == null) return;

		// Check if factory slot package exists and is not purchased
		bool found = false;
		if (shopData.Packages != null)
		{
			foreach (var package in shopData.Packages)
			{
				if (package != null && package.PackageIdx == ShopPackageFactorySlotIdx)
				{
					found = true;
					break;
				}
			}
		}

		if (!found)
		{
			// Create the factory slot package entry
			var newPackage = new PackageData(ShopPackageFactorySlotIdx, 0, 0);
			newPackage.Create();
			if (shopData.Packages == null)
				shopData.Packages = new List<PackageData>();
			shopData.Packages.Add(newPackage);
		}

		packageOpenCb?.Invoke();
	}

	public int AddDeskPackage(int level)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return 0;

		var shopData = gameRoot.UserData.ShopData;
		if (shopData == null) return 0;

		// Create a desk package based on the level
		int packageIdx = (int)PackageGroup.Desk + level;

		if (shopData.Packages == null)
			shopData.Packages = new List<PackageData>();

		// Check if already exists
		foreach (var p in shopData.Packages)
		{
			if (p != null && p.PackageIdx == packageIdx) return packageIdx;
		}

		var newPackage = new PackageData(packageIdx, 0, 0);
		newPackage.Create();
		shopData.Packages.Add(newPackage);

		return packageIdx;
	}

	private void SubscribeDeskPackage()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.ContentsOpenSystem == null) return;

		// Subscribe to desk/office open events to trigger desk package offers
	}

	private bool IgnoreSubscribePackage(int package_contents_open)
	{
		// Some package types should not have their contents open subscribed
		// e.g., NoTimeLimit packages or already expired/purchased ones
		if (package_contents_open <= 0) return true;

		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.ContentsOpenSystem == null) return true;

		return false;
	}

	private void CheckExpiredPackageGroup()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var shopData = gameRoot.UserData.ShopData;
		if (shopData == null) return;

		DateTime now = DateTime.UtcNow;

		// Check and expire timed packages
		if (shopData.Packages != null)
		{
			foreach (var package in shopData.Packages)
			{
				if (package == null) continue;
				if (package.BuyCount > 0) continue; // Already bought
				if (package.EndTime != default(DateTime) && package.EndTime < now)
				{
					// Package has expired, add to expire list
					if (shopData.ExpirePackage == null)
						shopData.ExpirePackage = new List<int>();
					if (!shopData.ExpirePackage.Contains(package.PackageIdx))
						shopData.ExpirePackage.Add(package.PackageIdx);
				}
			}
		}

		// Check special packages
		if (shopData.SpecialPackages != null)
		{
			foreach (var sp in shopData.SpecialPackages)
			{
				if (sp == null || sp.Expire || sp.Purchase) continue;
				if (sp.LimitTime != default(DateTime) && sp.LimitTime < now)
				{
					sp.ExpirePackage();
				}
			}
		}
	}

	private void CheckSequencePackage()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var shopData = gameRoot.UserData.ShopData;
		if (shopData == null || shopData.Packages == null) return;

		// Check if there are sequence packages that need to advance
		// (e.g., after buying package step 1, unlock step 2)
	}

	public void AllocManagerOpenPackage()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var shopData = gameRoot.UserData.ShopData;
		if (shopData == null) return;

		if (shopData.SpecialPackages == null)
			shopData.SpecialPackages = new List<SpecialPackageData>();

		// Check if manager open package already exists
		bool found = false;
		foreach (var sp in shopData.SpecialPackages)
		{
			if (sp != null && sp.Idx == ManagerOpenPackageIdx)
			{
				found = true;
				break;
			}
		}

		if (!found)
		{
			var newPackage = new SpecialPackageData(ManagerOpenPackageIdx);
			shopData.SpecialPackages.Add(newPackage);
		}
	}

	public void UpdateSpecialPackage()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var shopData = gameRoot.UserData.ShopData;
		if (shopData == null || shopData.SpecialPackages == null) return;

		DateTime now = DateTime.UtcNow;

		// Update special package states
		foreach (var sp in shopData.SpecialPackages)
		{
			if (sp == null || sp.Expire || sp.Purchase) continue;

			// Check time limit
			if (sp.LimitTime != default(DateTime) && sp.LimitTime < now)
			{
				sp.ExpirePackage();
			}
		}
	}

	public void UpdatePackage()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var shopData = gameRoot.UserData.ShopData;
		if (shopData == null || shopData.Packages == null) return;

		DateTime now = DateTime.UtcNow;

		// Update remaining time on packages
		foreach (var package in shopData.Packages)
		{
			if (package == null) continue;
			if (package.BuyCount > 0) continue;

			if (package.EndTime != default(DateTime))
			{
				int remain = (int)(package.EndTime - now).TotalSeconds;
				if (package.RemainTimeProperty != null)
					package.RemainTimeProperty.Value = Math.Max(0, remain);
			}
		}
	}

	public void CheckAndOpenPackageOffer(Config.E_PackageOfferType offerType, Action onComplete)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null)
		{
			onComplete?.Invoke();
			return;
		}

		var shopData = gameRoot.UserData.ShopData;
		if (shopData == null || shopData.SpecialPackages == null)
		{
			onComplete?.Invoke();
			return;
		}

		// Find special packages that match the offer type and haven't been shown yet
		bool found = false;
		foreach (var sp in shopData.SpecialPackages)
		{
			if (sp == null || sp.Expire || sp.Purchase) continue;

			if (!sp.IsOfferTime(offerType, true))
			{
				// Update offer time and queue for display
				sp.UpdateOfferTime(offerType);
				if (WaitPackagePopups != null && !WaitPackagePopups.Contains(sp.Idx))
				{
					WaitPackagePopups.Enqueue(sp.Idx);
					found = true;
				}
			}
		}

		if (found)
		{
			ShowNextWaitPackagePopup(onComplete);
		}
		else
		{
			onComplete?.Invoke();
		}
	}

	public bool IsOpenPackage(int packageIdx)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return false;

		var shopData = gameRoot.UserData.ShopData;
		if (shopData == null) return false;

		// Check in regular packages
		if (shopData.Packages != null)
		{
			foreach (var package in shopData.Packages)
			{
				if (package != null && package.PackageIdx == packageIdx)
				{
					// Package is open if it exists and hasn't expired
					if (package.BuyCount > 0) return false; // Already bought
					if (package.EndTime != default(DateTime) && package.EndTime < DateTime.UtcNow)
						return false; // Expired
					return true;
				}
			}
		}

		// Check in special packages
		if (shopData.SpecialPackages != null)
		{
			foreach (var sp in shopData.SpecialPackages)
			{
				if (sp != null && sp.Idx == packageIdx)
				{
					return !sp.Expire && !sp.Purchase;
				}
			}
		}

		return false;
	}

	public bool IsExistAnyPackageGroup(int packageGroup)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return false;

		var shopData = gameRoot.UserData.ShopData;
		if (shopData == null) return false;

		// Check if any package in the specified group exists and is available
		if (shopData.Packages != null)
		{
			foreach (var package in shopData.Packages)
			{
				if (package == null) continue;
				if (package.BuyCount > 0) continue;
				// Heuristic: packages in a group share the same group range
				// packageGroup is the base group ID
				if (IsOpenPackage(package.PackageIdx))
					return true;
			}
		}

		return false;
	}

	public bool IsBuyPackage(int packageIdx)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return false;

		var shopData = gameRoot.UserData.ShopData;
		if (shopData == null) return false;

		// Check regular packages
		if (shopData.Packages != null)
		{
			foreach (var package in shopData.Packages)
			{
				if (package != null && package.PackageIdx == packageIdx)
					return package.BuyCount > 0;
			}
		}

		// Check special packages
		if (shopData.SpecialPackages != null)
		{
			foreach (var sp in shopData.SpecialPackages)
			{
				if (sp != null && sp.Idx == packageIdx)
					return sp.Purchase;
			}
		}

		return false;
	}

	public void ChangeHighStarterPackage()
	{
		if (isHighStarterPackageBuy) return;

		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var shopData = gameRoot.UserData.ShopData;
		if (shopData == null || shopData.Packages == null) return;

		// Replace starter package with high starter package
		for (int i = 0; i < shopData.Packages.Count; i++)
		{
			if (shopData.Packages[i] != null && shopData.Packages[i].PackageIdx == StartPackageIdx)
			{
				// Swap to high starter package
				var highPackage = new PackageData(StartHighPackageIdx, 0, 0);
				highPackage.Create();
				shopData.Packages[i] = highPackage;
				isHighStarterPackageBuy = true;
				break;
			}
		}
	}

	public void ShowNextWaitPackagePopup(Action OnEnd = null)
	{
		if (WaitPackagePopups == null || WaitPackagePopups.Count == 0)
		{
			OnEnd?.Invoke();
			return;
		}

		int nextIdx = WaitPackagePopups.Dequeue();

		// Show the package popup through UI system
		// When popup closes, recursively show the next one
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UISystem == null)
		{
			OnEnd?.Invoke();
			return;
		}

		// The popup would be shown via UISystem, and on close would call ShowNextWaitPackagePopup
		// For now, continue to next
		ShowNextWaitPackagePopup(OnEnd);
	}

	public static void GetPackageReward(ShopPackageData Info, Action OnEnd = null, bool ShowPageReward = true)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || Info == null)
		{
			OnEnd?.Invoke();
			return;
		}

		// Process package rewards through the reward system
		// Typically adds currencies, items, managers, etc. to UserData
		OnEnd?.Invoke();
	}

	public void InitSeasonalPackageMatch()
	{
		if (SeasonalPackageMatchMap == null)
			SeasonalPackageMatchMap = new Dictionary<SeasonalPackageMatchType, List<int>>();
		SeasonalPackageMatchMap.Clear();

		// Initialize match type lists
		SeasonalPackageMatchMap[SeasonalPackageMatchType.COIN] = new List<int>();
		SeasonalPackageMatchMap[SeasonalPackageMatchType.SKILLBOOK] = new List<int>();
		SeasonalPackageMatchMap[SeasonalPackageMatchType.LEVELUP] = new List<int>();
	}

	public void AddSeasonalPackage(ContentsOpenSystem.OpenConditionType type, int value)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var shopData = gameRoot.UserData.ShopData;
		if (shopData == null) return;

		if (SeasonalEnablePackages == null)
			SeasonalEnablePackages = new List<int>();

		// Based on the open condition type, determine which seasonal packages to enable
		switch (type)
		{
			case ContentsOpenSystem.OpenConditionType.SeasonalPackage_AverageSkillLevel:
				// Enable seasonal packages matching skill level threshold
				if (SeasonalPackageMatchMap != null && SeasonalPackageMatchMap.ContainsKey(SeasonalPackageMatchType.SKILLBOOK))
				{
					foreach (int idx in SeasonalPackageMatchMap[SeasonalPackageMatchType.SKILLBOOK])
					{
						if (!SeasonalEnablePackages.Contains(idx))
							SeasonalEnablePackages.Add(idx);
					}
				}
				break;
			case ContentsOpenSystem.OpenConditionType.SeasonalPackage_ManagerLevel:
				if (SeasonalPackageMatchMap != null && SeasonalPackageMatchMap.ContainsKey(SeasonalPackageMatchType.LEVELUP))
				{
					foreach (int idx in SeasonalPackageMatchMap[SeasonalPackageMatchType.LEVELUP])
					{
						if (!SeasonalEnablePackages.Contains(idx))
							SeasonalEnablePackages.Add(idx);
					}
				}
				break;
		}
	}

	public void AddSeasonalPackage(ContentsOpenSystem.OpenConditionSeasonalExceptionType type)
	{
		if (SeasonalEnablePackages == null)
			SeasonalEnablePackages = new List<int>();

		switch (type)
		{
			case ContentsOpenSystem.OpenConditionSeasonalExceptionType.FirstSlotCoinBuff:
				if (SeasonalPackageMatchMap != null && SeasonalPackageMatchMap.ContainsKey(SeasonalPackageMatchType.COIN))
				{
					foreach (int idx in SeasonalPackageMatchMap[SeasonalPackageMatchType.COIN])
					{
						if (!SeasonalEnablePackages.Contains(idx))
							SeasonalEnablePackages.Add(idx);
					}
				}
				break;
			case ContentsOpenSystem.OpenConditionSeasonalExceptionType.NeedSkillBook:
				if (SeasonalPackageMatchMap != null && SeasonalPackageMatchMap.ContainsKey(SeasonalPackageMatchType.SKILLBOOK))
				{
					foreach (int idx in SeasonalPackageMatchMap[SeasonalPackageMatchType.SKILLBOOK])
					{
						if (!SeasonalEnablePackages.Contains(idx))
							SeasonalEnablePackages.Add(idx);
					}
				}
				break;
		}
	}

	public void AddSeasonalPackage(List<ShopPackageData> packageInfos)
	{
		if (packageInfos == null) return;
		if (SeasonalEnablePackages == null)
			SeasonalEnablePackages = new List<int>();

		// Add packages from the provided list to seasonal enabled packages
	}

	public bool ShowSeasonalPackageIgnoreGroup(int packageIdx)
	{
		// Some seasonal package groups should be ignored for display purposes
		// e.g., SeasonalAllinOne packages
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return false;

		var shopData = gameRoot.UserData.ShopData;
		if (shopData == null || shopData.SpecialPackages == null) return false;

		foreach (var sp in shopData.SpecialPackages)
		{
			if (sp != null && sp.Idx == packageIdx)
			{
				// If this package is part of SeasonalAllinOne group, ignore
				return sp.Purchase || sp.Expire;
			}
		}

		return false;
	}

	public int GetMaxTimeLevelUpPackageIdx(int workshopIdx)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return 0;

		var shopData = gameRoot.UserData.ShopData;
		if (shopData == null || shopData.SpecialPackages == null) return 0;

		int maxIdx = 0;

		// Find the highest level-up package index for the given workshop
		foreach (var sp in shopData.SpecialPackages)
		{
			if (sp == null || sp.Expire || sp.Purchase) continue;
			if (sp.Param != null && sp.Param.Contains(workshopIdx))
			{
				if (sp.Idx > maxIdx)
					maxIdx = sp.Idx;
			}
		}

		return maxIdx;
	}

	private void SetFreeItems()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var shopData = gameRoot.UserData.ShopData;
		if (shopData == null) return;

		if (FreeItemTimes == null)
			FreeItemTimes = new Dictionary<int, IReactiveProperty<int>>();
		FreeItemTimes.Clear();

		if (shopData.FreeTimes == null)
			shopData.FreeTimes = new Dictionary<int, DateTime>();

		DateTime now = DateTime.UtcNow;

		// Set up free item cooldown timers from saved data
		foreach (var kvp in shopData.FreeTimes)
		{
			int idx = kvp.Key;
			DateTime nextFreeTime = kvp.Value;
			int remain = Math.Max(0, (int)(nextFreeTime - now).TotalSeconds);
			FreeItemTimes[idx] = new ReactiveProperty<int>(remain);
		}
	}

	public void GetFreeItem(int idx, Action cb)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null)
		{
			cb?.Invoke();
			return;
		}

		var shopData = gameRoot.UserData.ShopData;
		if (shopData == null)
		{
			cb?.Invoke();
			return;
		}

		// Check if free item is available (cooldown expired)
		if (FreeItemTimes != null && FreeItemTimes.ContainsKey(idx))
		{
			if (FreeItemTimes[idx].Value > 0)
			{
				// Still on cooldown
				cb?.Invoke();
				return;
			}
		}

		// Grant the free item reward
		// Set cooldown timer
		DateTime nextFreeTime = DateTime.UtcNow.AddSeconds(seasonal_shop_free_coin_cooltime);
		if (shopData.FreeTimes == null)
			shopData.FreeTimes = new Dictionary<int, DateTime>();
		shopData.FreeTimes[idx] = nextFreeTime;

		if (FreeItemTimes == null)
			FreeItemTimes = new Dictionary<int, IReactiveProperty<int>>();

		if (!FreeItemTimes.ContainsKey(idx))
			FreeItemTimes[idx] = new ReactiveProperty<int>(seasonal_shop_free_coin_cooltime);
		else
			FreeItemTimes[idx].Value = seasonal_shop_free_coin_cooltime;

		cb?.Invoke();
	}

	private void SetSeasonalFreeItem()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.SeasonalSystem == null) return;

		var seasonalSystem = gameRoot.SeasonalSystem;
		if (!seasonalSystem.IsPlayingSeasonal()) return;

		// Set up seasonal free coin with cooldown
		DateTime now = DateTime.UtcNow;
		SeasonalFreeCoinProductIdx = 0;

		// Set day reset time (next midnight UTC)
		SeasonalFreeCoinDayResetDateTime = now.Date.AddDays(1);

		// Check saved cooldown
		var shopData = gameRoot.UserData?.ShopData;
		if (shopData != null && shopData.FreeTimes != null)
		{
			int seasonalFreeKey = -1; // Special key for seasonal free coin
			if (shopData.FreeTimes.ContainsKey(seasonalFreeKey))
			{
				SeasonalFreeCoinNextResetDateTime = shopData.FreeTimes[seasonalFreeKey];
				int remain = Math.Max(0, (int)(SeasonalFreeCoinNextResetDateTime - now).TotalSeconds);
				if (SeasonalFreeCoinResetRemainTimeSec != null)
					SeasonalFreeCoinResetRemainTimeSec.Value = remain;
			}
		}
	}

	public void ConsumeSeasonalFreeCoin()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		// Set cooldown for seasonal free coin
		DateTime now = DateTime.UtcNow;
		SeasonalFreeCoinNextResetDateTime = now.AddSeconds(seasonal_shop_free_coin_cooltime);

		if (SeasonalFreeCoinResetRemainTimeSec != null)
			SeasonalFreeCoinResetRemainTimeSec.Value = seasonal_shop_free_coin_cooltime;

		// Save to ShopData
		var shopData = gameRoot.UserData.ShopData;
		if (shopData != null)
		{
			if (shopData.FreeTimes == null)
				shopData.FreeTimes = new Dictionary<int, DateTime>();
			shopData.FreeTimes[-1] = SeasonalFreeCoinNextResetDateTime;
		}

		if (SeasonalFreeCoinReset != null)
			SeasonalFreeCoinReset.OnNext(SeasonalFreeCoinProductIdx);
	}

	public void SetCycleLimitedShopGoods()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var shopData = gameRoot.UserData.ShopData;
		if (shopData == null) return;

		if (shopData.CycleLimitedShopGoodsMap == null)
			shopData.CycleLimitedShopGoodsMap = new Dictionary<int, CycleLimitedShopGoodsData>();

		DateTime now = DateTime.UtcNow;

		// Reset cycle-limited goods whose reset time has passed
		var keysToReset = new List<int>();
		foreach (var kvp in shopData.CycleLimitedShopGoodsMap)
		{
			if (kvp.Value != null && kvp.Value.NextResetTime != default(DateTime) && kvp.Value.NextResetTime <= now)
			{
				keysToReset.Add(kvp.Key);
			}
		}

		foreach (int key in keysToReset)
		{
			shopData.CycleLimitedShopGoodsMap[key].BuyCount = 0;
			// Set next reset time based on the goods' cycle
		}
	}

	private void SetADManagerBox()
	{
		// Initialize AD manager box cooldown and reset timers
		if (RemainADManagerBoxCoolTime == null)
			RemainADManagerBoxCoolTime = new ReactiveProperty<int>(0);
		if (RemainADManagerBoxResetTime == null)
			RemainADManagerBoxResetTime = new ReactiveProperty<int>(0);
	}

	private void SetShopSale()
	{
		CurShopSaleIdx = GetCurShopSaleIdx();

		if (CurShopSaleIdx <= 0)
		{
			CurShopSaleType = Config.E_ShopSaleListType.None;
			return;
		}

		NextShopSaleStartTime = GetNextShopSaleStartTime();
		SetShopSaleInfo();
		InitShopSaleItemContentsOpen();
		InitShopSaleItemList();
		UpdateOpenShopSaleItems();
	}

	private int GetCurShopSaleIdx()
	{
		// Determine the current shop sale index based on time/schedule
		// The sale idx rotates on a schedule
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null) return 0;

		// Default: use ShopSaleIdx_AcqWeeklyShop for BizAcquisition
		return 0;
	}

	private DateTime GetNextShopSaleStartTime()
	{
		// Calculate the next shop sale start time
		DateTime now = DateTime.UtcNow;

		// Shop sales typically rotate weekly
		// Next Monday at midnight UTC
		int daysUntilMonday = ((int)DayOfWeek.Monday - (int)now.DayOfWeek + 7) % 7;
		if (daysUntilMonday == 0) daysUntilMonday = 7;

		return now.Date.AddDays(daysUntilMonday);
	}

	private void SetShopSaleInfo()
	{
		if (CurShopSaleIdx <= 0) return;

		// Set the sale end time based on the rotation schedule
		ShopSaleEndTime = NextShopSaleStartTime;

		DateTime now = DateTime.UtcNow;
		int remain = Math.Max(0, (int)(ShopSaleEndTime - now).TotalSeconds);
		if (RemainShopSaleTime != null)
			RemainShopSaleTime.Value = remain;
	}

	private void InitShopSaleItemContentsOpen()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.ContentsOpenSystem == null) return;

		// Subscribe to contents open conditions for shop sale items
	}

	public void UpdateOpenShopSaleItems()
	{
		if (CurOpenShopSaleItems == null)
			CurOpenShopSaleItems = new List<int>();
		CurOpenShopSaleItems.Clear();

		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var shopData = gameRoot.UserData.ShopData;
		if (shopData == null || shopData.ShopSaleItemMap == null) return;

		// Add items that are currently available in the sale
		foreach (var kvp in shopData.ShopSaleItemMap)
		{
			if (IsOpenShopSaleList(kvp.Key))
			{
				CurOpenShopSaleItems.Add(kvp.Key);
			}
		}
	}

	public bool IsOpenShopSaleList(int idx)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return false;

		var shopData = gameRoot.UserData.ShopData;
		if (shopData == null || shopData.ShopSaleItemMap == null) return false;

		if (!shopData.ShopSaleItemMap.ContainsKey(idx)) return false;

		var saleItem = shopData.ShopSaleItemMap[idx];
		if (saleItem == null) return false;

		DateTime now = DateTime.UtcNow;

		// Check if the sale item is within its active time window
		if (saleItem.StartTime != default(DateTime) && saleItem.StartTime > now) return false;
		if (saleItem.EndTime != default(DateTime) && saleItem.EndTime < now) return false;

		return true;
	}

	private void InitShopSaleItemList()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var shopData = gameRoot.UserData.ShopData;
		if (shopData == null) return;

		if (shopData.ShopSaleItemMap == null)
			shopData.ShopSaleItemMap = new Dictionary<int, ShopSaleItemUserData>();
	}

	public void UpdateShopSalePackageResetTime(int idx, DateTime tryTime)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var shopData = gameRoot.UserData.ShopData;
		if (shopData == null || shopData.ShopSaleItemMap == null) return;

		if (shopData.ShopSaleItemMap.ContainsKey(idx))
		{
			var saleItem = shopData.ShopSaleItemMap[idx];
			if (saleItem != null)
			{
				saleItem.ResetTime = tryTime;
			}
		}
	}

	public bool IsRemainSaleItemPurchaseTime(int idx)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return false;

		var shopData = gameRoot.UserData.ShopData;
		if (shopData == null || shopData.ShopSaleItemMap == null) return false;

		if (!shopData.ShopSaleItemMap.ContainsKey(idx)) return false;

		var saleItem = shopData.ShopSaleItemMap[idx];
		if (saleItem == null) return false;

		DateTime now = DateTime.UtcNow;

		// Check if the purchase reset time hasn't passed yet
		if (saleItem.ResetTime != default(DateTime) && saleItem.ResetTime > now)
			return true;

		return false;
	}

	public static void GetSalePackageReward(ShopSaleItemData Info, Action OnEnd = null)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || Info == null)
		{
			OnEnd?.Invoke();
			return;
		}

		// Process sale package rewards
		OnEnd?.Invoke();
	}

	private void InitEndlessOfferList()
	{
		if (OpenedEndlessOfferIdxList == null)
			OpenedEndlessOfferIdxList = new List<int>();
		OpenedEndlessOfferIdxList.Clear();

		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var shopData = gameRoot.UserData.ShopData;
		if (shopData == null) return;

		if (shopData.EndlessOfferMap == null)
			shopData.EndlessOfferMap = new Dictionary<int, EndlessOfferUserData>();

		// Initialize all known endless offers
		UpdateEndlessOfferOpen();
	}

	private void UpdateEndlessOfferOpen()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var shopData = gameRoot.UserData.ShopData;
		if (shopData == null || shopData.EndlessOfferMap == null) return;

		if (OpenedEndlessOfferIdxList == null)
			OpenedEndlessOfferIdxList = new List<int>();
		OpenedEndlessOfferIdxList.Clear();

		DateTime now = DateTime.UtcNow;

		// Check which endless offers are currently open
		foreach (var kvp in shopData.EndlessOfferMap)
		{
			var offerData = kvp.Value;
			if (offerData == null) continue;

			// Offer is open if end time is in the future
			if (offerData.EndTime > now)
			{
				OpenedEndlessOfferIdxList.Add(kvp.Key);
			}
		}
	}

	private void UpdateEndlessOffer()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var shopData = gameRoot.UserData.ShopData;
		if (shopData == null || shopData.EndlessOfferMap == null) return;

		DateTime now = DateTime.UtcNow;

		// Check for expired offers and notify
		var expiredKeys = new List<int>();
		foreach (var kvp in shopData.EndlessOfferMap)
		{
			var offerData = kvp.Value;
			if (offerData == null) continue;

			if (offerData.EndTime != default(DateTime) && offerData.EndTime <= now)
			{
				expiredKeys.Add(kvp.Key);
			}
		}

		// Handle expired offers - reset or remove
		foreach (int key in expiredKeys)
		{
			var offerData = shopData.EndlessOfferMap[key];
			if (offerData.OnResetEndlessOffer != null)
				offerData.OnResetEndlessOffer.OnNext(true);
		}

		// Update the open list
		UpdateEndlessOfferOpen();
	}

	private void InitEndlessOffer(int offerIdx)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var shopData = gameRoot.UserData.ShopData;
		if (shopData == null) return;

		if (shopData.EndlessOfferMap == null)
			shopData.EndlessOfferMap = new Dictionary<int, EndlessOfferUserData>();

		if (!shopData.EndlessOfferMap.ContainsKey(offerIdx))
		{
			var newOffer = new EndlessOfferUserData
			{
				EndlessIdx = offerIdx,
				CurOrderIdx = 0,
				EndTime = DateTime.UtcNow.AddDays(7), // Default 7-day duration
				BuyCount = 0,
				OnResetEndlessOffer = new Subject<bool>()
			};
			shopData.EndlessOfferMap[offerIdx] = newOffer;
		}

		if (OpenedEndlessOfferIdxList != null && !OpenedEndlessOfferIdxList.Contains(offerIdx))
		{
			OpenedEndlessOfferIdxList.Add(offerIdx);
		}
	}

	public void UpdateOneSecond()
	{
		DateTime now = DateTime.UtcNow;

		// Update multi-revenue sale timer
		if (InMultiRevenueSale && EndMRSaleTime != DateTime.MaxValue)
		{
			int remain = (int)(EndMRSaleTime - now).TotalSeconds;
			if (remain <= 0)
			{
				InMultiRevenueSale = false;
				remain = 0;
			}
			if (RemainMRSaleTime != null)
				RemainMRSaleTime.Value = Math.Max(0, remain);
		}

		// Update no-ads sale timer
		if (InNoAdsSale)
		{
			int remain = (int)(NextNoAdsSaleTime - now).TotalSeconds;
			if (remain <= 0)
			{
				InNoAdsSale = false;
				ExpireNoAdsSale = true;
				remain = 0;
			}
			if (RemainNoAdsSaleTime != null)
				RemainNoAdsSaleTime.Value = Math.Max(0, remain);
		}

		// Update player level pass sale timer
		if (InPlayerLvPassSale)
		{
			var gameRoot = Singleton<GameRoot>.Instance;
			if (gameRoot != null && gameRoot.UserData != null && gameRoot.UserData.ShopData != null)
			{
				int remain = (int)(gameRoot.UserData.ShopData.PlayerLvPassSaleEndTime - now).TotalSeconds;
				if (remain <= 0)
				{
					InPlayerLvPassSale = false;
					ExpirePlayerLvPassSale = true;
					remain = 0;
				}
				if (RemainPlayerLvPassSaleTime != null)
					RemainPlayerLvPassSaleTime.Value = Math.Max(0, remain);
			}
		}

		// Update shop sale timer
		if (CurShopSaleIdx > 0 && ShopSaleEndTime != default(DateTime))
		{
			int remain = (int)(ShopSaleEndTime - now).TotalSeconds;
			if (remain <= 0)
			{
				// Sale period ended, refresh
				SetShopSale();
				remain = 0;
			}
			if (RemainShopSaleTime != null)
				RemainShopSaleTime.Value = Math.Max(0, remain);
		}

		// Update free item cooldowns
		if (FreeItemTimes != null)
		{
			foreach (var kvp in FreeItemTimes)
			{
				if (kvp.Value != null && kvp.Value.Value > 0)
				{
					kvp.Value.Value = Math.Max(0, kvp.Value.Value - 1);
				}
			}
		}

		// Update seasonal timers
		UpdateOneSecondSeasonal(now);

		// Update package timers
		UpdatePackage();

		// Update endless offers
		UpdateEndlessOffer();
	}

	private void UpdateOneSecondSeasonal(DateTime curTime)
	{
		// Update seasonal free coin cooldown
		if (SeasonalFreeCoinResetRemainTimeSec != null && SeasonalFreeCoinResetRemainTimeSec.Value > 0)
		{
			int remain = (int)(SeasonalFreeCoinNextResetDateTime - curTime).TotalSeconds;
			remain = Math.Max(0, remain);
			SeasonalFreeCoinResetRemainTimeSec.Value = remain;

			if (remain <= 0 && SeasonalFreeCoinReset != null)
			{
				SeasonalFreeCoinReset.OnNext(SeasonalFreeCoinProductIdx);
			}
		}

		// Check seasonal day reset
		if (SeasonalFreeCoinDayResetDateTime != default(DateTime) && curTime >= SeasonalFreeCoinDayResetDateTime)
		{
			// Day reset - recalculate next day reset
			SeasonalFreeCoinDayResetDateTime = curTime.Date.AddDays(1);
			SeasonalFreeCoinNextResetDateTime = default(DateTime);
			if (SeasonalFreeCoinResetRemainTimeSec != null)
				SeasonalFreeCoinResetRemainTimeSec.Value = 0;
		}
	}

	public void InappPurchase(string product_id, int itemIdx, Action OnSuccess, Action OnFailed = null)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.InAppPurchaseManager == null)
		{
			OnFailed?.Invoke();
			return;
		}

		if (state == ShopState.Purchasing)
		{
			OnFailed?.Invoke();
			return;
		}

		state = ShopState.Purchasing;

		gameRoot.InAppPurchaseManager.BuyProductID(product_id, itemIdx, (result) =>
		{
			state = ShopState.None;

			if (result == InAppPurchaseManager.Result.Success)
			{
				// Add to purchased list
				if (gameRoot.UserData != null && gameRoot.UserData.BuyInappIds != null)
				{
					if (!gameRoot.UserData.BuyInappIds.Contains(product_id))
						gameRoot.UserData.BuyInappIds.Add(product_id);
				}

				// Update no-ads state
				UpdateNoAds();

				// Notify purchase success
				if (OnPurchaseSuccess != null)
					OnPurchaseSuccess.OnNext((itemIdx, 1));

				OnSuccess?.Invoke();
			}
			else
			{
				OnFailed?.Invoke();
			}
		});
	}
}
