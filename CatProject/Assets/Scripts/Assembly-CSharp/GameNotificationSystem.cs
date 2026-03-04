using System;
using System.Collections.Generic;
using UniRx;

public class GameNotificationSystem
{
	public enum NotificationType
	{
		Once = 0,
		Passive = 1
	}

	public enum NotificationCategory
	{
		HavePost = 0,
		CheckLogin = 1,
		MissionReward = 2,
		EnableNextStage = 3,
		RouletteCooltime = 4,
		FreeRoulette = 5,
		NewChat = 6,
		EnableBankLevelup = 7,
		EnableZoneOpen = 8,
		PlantFullZero = 9,
		PlantEnableLevelup = 10,
		PlayerLvPassReward = 11,
		FreeTonicItem = 12,
		FreeGemItem = 13,
		CompanyMaxReward = 14,
		DailyQuestReward = 15,
		EnableBuildingOpen = 16,
		EnableBuildingLevelUp = 17,
		RichRankReward = 18,
		CatstagramReward = 19,
		EnableBuildingNeedLevel = 20,
		RevenueMax = 21,
		EnableFactoryOrder = 22,
		FactoryStorageFull = 23,
		EnableMoneySafeOpen = 24,
		PlantEnableGetReward = 25,
		FirstBankReward = 26,
		Invest = 27,
		Invite = 28,
		EnableFactoryOpen = 29,
		OfferWall = 30,
		EnableNextRegion = 31,
		EnableManagerLevelUp = 32,
		NewManager = 33,
		FirstPlantPhone = 34,
		FactoryRewardKey = 35,
		EnableManagerBox = 36,
		ReservationReward = 37,
		FreeSpecialDayRoulette = 38,
		SpecialDayRouletteCooltime = 39,
		EnableSpecialDayLuckyDrawReward = 40,
		HUDOfferwall = 41,
		ShopSalePage1View = 42,
		ShopSalePage2View = 43,
		SeasonalMissionReward = 44,
		SeasonalPossibleSkillLevelUp = 45,
		AuctionPassReward = 46,
		SpecialDayDecoReward = 47,
		SeasonalPossibleUseArcadeMachine = 48,
		SeasonalMilestoneReceivableReward = 49,
		SeasonalEnableSkillBook = 50,
		WorldMapMissionRichAchieve = 51,
		SeasonalPossibleDocOpen = 52,
		SeasonalStepReward = 53,
		SeasonalArcadeMachineFreeCoin = 54,
		SuperStaffUpgrade = 55,
		OpenSuperStaff = 56,
		CatstagramEventReward = 57,
		CatstagramTotalReward = 58,
		AuctionStaminaFull = 59,
		AnniversaryPackage = 60,
		ContentsMission = 61,
		AnniversaryAttendance = 62,
		AnniversaryRouletteBonus = 63,
		AnniversaryRouletteTicket = 64,
		AnniversaryShop = 65,
		NewHouse = 66,
		SeasonalOfflineRewardMax = 67,
		CrossPromotion = 68,
		EnableHouseUpgrade = 69,
		BizAcq_Open = 70,
		BizAcq_PassReward = 71,
		CarCollectionReward = 72,
		DailyNormalSkillStone = 73,
		CarCollectionView = 74,
		SubMissionReward = 75,
		BizAcq_ManagerUpgrade = 76,
		BizAqc_IdleReward = 77,
		AdPassReward = 78,
		EndlessOffer = 79,
		OnePlusSixPackageReward = 80,
		BoosterActive = 81,
		CeoCostume = 82,
		NewPlantGet = 83,
		MiniGame_FreeItem = 84,
		BoosterTicket = 85,
		EnableMoneySafeOpenOncePerSatisfy = 86,
		Freecash = 87,
		HasCompanyExpTicket = 88
	}

	public enum HudBottomNotiTuto
	{
		Card = 1,
		Shop = 3
	}

	public class NotificationData
	{
		public NotificationType type;

		public NotificationCategory category;

		public int targetIdx;

		public int targetSubIdx;

		public int iconIdx;

		public IReactiveProperty<bool> on;

		public IReactiveProperty<int> onCount;
	}

	private Dictionary<NotificationCategory, List<NotificationData>> notifications;

	private CompositeDisposable disposables;

	private Dictionary<int, HashSet<NotificationCategory>> ScheduledCategories;

	private Dictionary<int, Subject<int>> ScheduledEvent;

	private DateTime LastCheckTime;

	private IDisposable rewardEventDispose;

	private IDisposable nextStageLevelDisposable;

	private IDisposable nextStagePointDisposable;

	private IDisposable gemPassRewardDisposable;

	private IDisposable buildingopenDisposable;

	private IDisposable houseupgradeDisposable;

	private IDisposable houseLevelDisposable;

	private IDisposable investMoneyDisposable;

	private IDisposable investRentalFeeDisposable;

	private IDisposable factoryopenDisposable;

	private Dictionary<BuffSystem.BuffType, Action> buffEventDic;

	private bool IsPassive(NotificationCategory category)
	{
		return false;
	}

	public NotificationData GetData(NotificationCategory _key, int _targetIdx, int _targetSubIdx)
	{
		return null;
	}

	public bool IsOn(NotificationCategory _key, int _targetIdx, int _targetSubIdx)
	{
		return false;
	}

	public void Clear()
	{
	}

	public void Create()
	{
		notifications = new Dictionary<NotificationCategory, List<NotificationData>>();
		disposables = new CompositeDisposable();
		ScheduledCategories = new Dictionary<int, HashSet<NotificationCategory>>();
		ScheduledEvent = new Dictionary<int, Subject<int>>();
	}

	public void UpdateNotification(NotificationCategory category)
	{
	}

	public void CheckChangeOnceNotification(NotificationCategory category, bool value, int targetIdx = -1)
	{
	}

	public void ChangeOnceNotification(NotificationCategory category, bool value, int targetIdx = -1)
	{
	}

	public void AddNotification(NotificationCategory category, int targetIdx = -1)
	{
	}

	public void DelNotifiaction(NotificationCategory category, int targetIdx = -1)
	{
	}

	public void UpdateOneSeconds()
	{
	}

	private List<int> GetPassedHours(DateTime lastCheckTime, DateTime nowTime)
	{
		return null;
	}

	public void RegisterScheduledCategory(int hour, NotificationCategory category)
	{
	}

	public IDisposable RegisterScheduledEvent(int hour, Action<int> action)
	{
		return null;
	}

	public void UnregisterScheduledCategory(int hour, NotificationCategory category)
	{
	}

	public void ClearAllScheduledCategories()
	{
	}
}
