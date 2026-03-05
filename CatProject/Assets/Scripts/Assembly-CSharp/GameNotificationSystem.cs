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
		var data = GetData(category, -1, -1);
		return data != null && data.type == NotificationType.Passive;
	}

	public NotificationData GetData(NotificationCategory _key, int _targetIdx, int _targetSubIdx)
	{
		if (notifications == null) return null;
		if (!notifications.TryGetValue(_key, out var list)) return null;

		for (int i = 0; i < list.Count; i++)
		{
			var data = list[i];
			if ((_targetIdx < 0 || data.targetIdx == _targetIdx) &&
				(_targetSubIdx < 0 || data.targetSubIdx == _targetSubIdx))
			{
				return data;
			}
		}
		return null;
	}

	public bool IsOn(NotificationCategory _key, int _targetIdx, int _targetSubIdx)
	{
		var data = GetData(_key, _targetIdx, _targetSubIdx);
		if (data?.on != null)
			return data.on.Value;
		return false;
	}

	public void Clear()
	{
		if (notifications != null)
			notifications.Clear();
		if (ScheduledCategories != null)
			ScheduledCategories.Clear();
		if (ScheduledEvent != null)
			ScheduledEvent.Clear();
	}

	public void Create()
	{
		notifications = new Dictionary<NotificationCategory, List<NotificationData>>();
		disposables = new CompositeDisposable();
		ScheduledCategories = new Dictionary<int, HashSet<NotificationCategory>>();
		ScheduledEvent = new Dictionary<int, Subject<int>>();
		buffEventDic = new Dictionary<BuffSystem.BuffType, Action>();
		LastCheckTime = DateTime.UtcNow;
	}

	public void UpdateNotification(NotificationCategory category)
	{
		// Would recalculate notification state for the given category
	}

	public void CheckChangeOnceNotification(NotificationCategory category, bool value, int targetIdx = -1)
	{
		var data = GetData(category, targetIdx, -1);
		if (data != null && data.type == NotificationType.Once)
		{
			if (data.on != null)
				data.on.Value = value;
		}
	}

	public void ChangeOnceNotification(NotificationCategory category, bool value, int targetIdx = -1)
	{
		var data = GetData(category, targetIdx, -1);
		if (data != null)
		{
			if (data.on != null)
				data.on.Value = value;
		}
		else
		{
			AddNotification(category, targetIdx);
			data = GetData(category, targetIdx, -1);
			if (data?.on != null)
				data.on.Value = value;
		}
	}

	public void AddNotification(NotificationCategory category, int targetIdx = -1)
	{
		if (notifications == null) return;

		if (!notifications.TryGetValue(category, out var list))
		{
			list = new List<NotificationData>();
			notifications[category] = list;
		}

		var data = new NotificationData
		{
			type = NotificationType.Once,
			category = category,
			targetIdx = targetIdx,
			targetSubIdx = -1,
			on = new ReactiveProperty<bool>(false),
			onCount = new ReactiveProperty<int>(0)
		};
		list.Add(data);
	}

	public void DelNotifiaction(NotificationCategory category, int targetIdx = -1)
	{
		if (notifications == null) return;
		if (!notifications.TryGetValue(category, out var list)) return;

		for (int i = list.Count - 1; i >= 0; i--)
		{
			if (targetIdx < 0 || list[i].targetIdx == targetIdx)
			{
				list.RemoveAt(i);
			}
		}
	}

	public void UpdateOneSeconds()
	{
		DateTime now = DateTime.UtcNow;
		var passedHours = GetPassedHours(LastCheckTime, now);
		if (passedHours != null && passedHours.Count > 0)
		{
			foreach (int hour in passedHours)
			{
				// Trigger scheduled categories for this hour
				if (ScheduledCategories.TryGetValue(hour, out var categories))
				{
					foreach (var cat in categories)
					{
						UpdateNotification(cat);
					}
				}
				// Trigger scheduled events
				if (ScheduledEvent.TryGetValue(hour, out var subject))
				{
					subject.OnNext(hour);
				}
			}
		}
		LastCheckTime = now;
	}

	private List<int> GetPassedHours(DateTime lastCheckTime, DateTime nowTime)
	{
		var result = new List<int>();
		int lastHour = lastCheckTime.Hour;
		int nowHour = nowTime.Hour;

		if (nowHour == lastHour && (nowTime - lastCheckTime).TotalHours < 1)
			return result;

		if (nowHour > lastHour)
		{
			for (int h = lastHour + 1; h <= nowHour; h++)
				result.Add(h);
		}
		else if (nowHour < lastHour)
		{
			// Crossed midnight
			for (int h = lastHour + 1; h < 24; h++)
				result.Add(h);
			for (int h = 0; h <= nowHour; h++)
				result.Add(h);
		}

		return result;
	}

	public void RegisterScheduledCategory(int hour, NotificationCategory category)
	{
		if (ScheduledCategories == null) return;

		if (!ScheduledCategories.TryGetValue(hour, out var set))
		{
			set = new HashSet<NotificationCategory>();
			ScheduledCategories[hour] = set;
		}
		set.Add(category);
	}

	public IDisposable RegisterScheduledEvent(int hour, Action<int> action)
	{
		if (ScheduledEvent == null) return null;

		if (!ScheduledEvent.TryGetValue(hour, out var subject))
		{
			subject = new Subject<int>();
			ScheduledEvent[hour] = subject;
		}
		return subject.Subscribe(action);
	}

	public void UnregisterScheduledCategory(int hour, NotificationCategory category)
	{
		if (ScheduledCategories != null && ScheduledCategories.TryGetValue(hour, out var set))
		{
			set.Remove(category);
		}
	}

	public void ClearAllScheduledCategories()
	{
		if (ScheduledCategories != null)
			ScheduledCategories.Clear();
	}
}
