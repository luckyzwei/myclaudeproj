using System.Collections.Generic;

public class TpAnalyticsProp
{
	public enum Analytics
	{
		Firebase = 0,
		Appsflyer = 1
	}

	public enum LogCostCashType
	{
		Roulette = 0,
		ChangeCompanyName = 1,
		FastBuild = 2,
		EndCompany = 3,
		BuyGemItem = 4,
		ShopMoney = 5,
		ShopExp = 6,
		ShopTonic = 7,
		BuyFactoryItem = 8,
		SkipFactorySlotCooltime = 9,
		BuyFactorySlot = 10,
		BuyManagerDesk = 11,
		SpecialDayRoulette = 12,
		TarotStart = 13,
		TarotChageCard = 14,
		AuctionSpy = 15,
		SeasonalShopCoin = 16,
		SeasonalShopSkillBook = 17,
		SeasonalShopHeart = 18,
		SeasonalOverTimeActive = 19,
		SeasonalFastBuild = 20,
		ShopAuctionStamina = 21,
		RefreshCompanyList = 22,
		InstantPurchaseMoney = 23,
		InstantCompanyLevelUp = 24,
		InstantOrderComplete = 25,
		InstantSeasonalHeartPurchase = 26,
		StrikeNegotiation = 27,
		ShopManagerNormalKey = 28,
		ShopManagerPremiumKey = 29,
		AnniversaryAttendanceReplace = 30,
		AnniversaryMissionReroll = 31,
		BuyManagerCard = 32,
		BuyParkingLot = 33,
		AdsSupplyUseGem = 34,
		OfflineRewardGemUse = 35,
		SeasonalOfflineRewardGemUse = 36,
		ShopReinforceStone = 37,
		ShopPremiumSkillStone = 38,
		ResetManagerReinforce = 39,
		UseBoosterGem_AddReward = 40,
		UseBoosterGem_CompanyExpPerUp = 41,
		UseBoosterGem_RentalFeeGetTime = 42,
		CeoCostumePurchase = 43,
		None = 9999
	}

	public enum LogCostCashPlace
	{
		Shop = 0,
		Nomoney = 1,
		Collection = 2,
		Office = 3,
		None = 9999
	}

	public enum LogTypeParams
	{
		None = 0,
		Office = 1,
		Invest = 2,
		Infra = 3,
		House = 4,
		Car = 5,
		Main = 6,
		Factory = 7,
		Contract = 8,
		Main_Build = 9,
		AdSupply = 10,
		Offline = 11,
		Offline_Seasonal = 12
	}

	private List<IAnalytics> analyticsList;

	public void AllEvent(IngameEventType eventType, string eventName, params object[] args)
	{
	}

	public void TargetEvent(Analytics analytics, IngameEventType eventType, string eventName, params object[] args)
	{
	}

	public void InAppPurchaseEvent(params object[] args)
	{
	}

	public void AppsflyerSendReadyLog()
	{
	}
}
