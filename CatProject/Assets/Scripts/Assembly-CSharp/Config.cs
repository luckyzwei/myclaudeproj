using System.Numerics;

public static class Config
{
	public enum AtlasType
	{
		None = 0,
		Common,
		Manager,
		Item,
		Currency,
		Building,
		Factory,
		Seasonal,
		Event,
		Shop
	}

	public enum CurrencyID
	{
		None = 0,
		Gold = 1,
		Cash = 2,
		Gem = 3,
		Heart = 4,
		Key = 5,
		Ticket = 6,
		Coin = 7,
		Star = 8,
		Medal = 9,
		Token = 10
	}

	public enum CurrencyGameType
	{
		None = 0,
		Main,
		Sub,
		Premium,
		Event
	}

	public enum RegionType
	{
		None = 0,
		Region1 = 1,
		Region2 = 2,
		Region3 = 3,
		Region4 = 4,
		Region5 = 5
	}

	public enum ManagerGrade
	{
		Common = 0,
		Uncommon = 1,
		Rare = 2,
		Epic = 3,
		Legend = 4,
		Special = 5
	}

	public enum ManagerCategory
	{
		None = 0,
		Office = 1,
		Factory = 2,
		Seasonal = 3,
		Event = 4
	}

	public enum ManagerSkillType
	{
		None = 0,
		AddRevenue = 1,
		ReduceTime = 2,
		AddExp = 3,
		AddDamage = 4,
		AddDefense = 5,
		AddCritical = 6,
		AddSpeed = 7,
		ReduceCost = 8
	}

	public enum ManagerSkillActivationType
	{
		None = 0,
		Passive = 1,
		OnAttack = 2,
		OnDefense = 3,
		OnBattleStart = 4,
		OnTurnStart = 5,
		OnHpLow = 6
	}

	public enum ManagerSkillContentsType
	{
		None = 0,
		Office = 1,
		Acquisition = 2,
		Dispatch = 3
	}

	public enum ContentsOpenType
	{
		None = 0,
		OfficeOpen = 1,
		Level = 2,
		OfficeItemPurchase = 3,
		OfficeContract = 4,
		OfficeOpenStart = 5,
		AllFloorOfficeItemPurchase = 6,
		StageMove = 7,
		Plant = 8,
		AllGradeManagerLevel = 9,
		PremiumGradeManagerLevel = 10,
		Building = 11,
		SeasonalBuildingLvUp = 12,
		SeasonalBuildingOpen = 13,
		ManagerLevel = 14,
		SeasonalRankingRewardPopup = 15,
		SeasonalSkillHighLevel = 16,
		SeasonalManagerExpMaxTime = 17,
		SeasonalPackage_AverageSkillLevel = 18,
		SeasonalPackage_ManagerLevel = 19,
		BizAcquisitionStageClear = 20,
		MaxRegionStageOpen = 21,
		CompanyExpTicketUse = 24,
		FactoryOrder = 27,
		Max = 28
	}

	public enum ItemIdx
	{
		None = 0
	}

	public enum ItemType
	{
		None = 0,
		Currency,
		Material,
		Consumable,
		ManagerCard,
		Costume,
		Ticket,
		Box
	}

	public enum RewardType
	{
		None = 0,
		Currency,
		Item,
		Manager,
		Costume,
		Exp,
		Building
	}

	public enum RecordKeys
	{
		None = 0
	}

	public enum RecordCountKeys
	{
		None = 0
	}

	public enum OfficeType
	{
		None = 0,
		Normal = 1,
		Premium = 2,
		Seasonal = 3
	}

	public enum BuildingType
	{
		None = 0,
		Office,
		Factory,
		House,
		Special,
		Seasonal
	}

	public enum AudienceType
	{
		None = 0,
		Normal,
		VIP,
		Special
	}

	public enum SecretaryConversationType
	{
		None = 0,
		Greeting,
		Idle,
		Event,
		Guide
	}

	public enum Language
	{
		Korean = 0,
		English,
		Japanese,
		ChineseSimplified,
		ChineseTraditional,
		German,
		French,
		Spanish,
		Portuguese,
		Russian,
		Thai,
		Indonesian,
		Vietnamese
	}

	public enum E_INHOUSE_RESERVATION
	{
		None = 0,
		Reservation1 = 1,
		Reservation2 = 2,
		Reservation3 = 3,
		Reservation4 = 4,
		Reservation5 = 5
	}

	public enum E_FactoryEnterType
	{
		None = 0,
		Normal,
		Mission,
		Event,
		Shortcut
	}

	public enum E_ShopSaleListType
	{
		None = 0,
		Normal,
		Package,
		Special,
		Event
	}

	public enum E_ShopInsufficientPlaceType
	{
		None = 0,
		Gold,
		Cash,
		Gem,
		Item
	}

	public enum E_ShopSaleItemResetType
	{
		None = 0,
		Daily,
		Weekly,
		Monthly,
		Never
	}

	public enum E_PackageOfferType
	{
		None = 0,
		LevelUp,
		StageOpen,
		Special,
		Seasonal,
		FirstPurchase
	}

	public enum E_SpecialDayEventType
	{
		None = 0,
		Holiday,
		Anniversary,
		Collaboration,
		Update
	}

	public enum E_PiggyGetType
	{
		None = 0,
		Free,
		Paid
	}

	public enum FactoryType
	{
		None = 0,
		Normal,
		Premium,
		Event
	}

	public enum FactoryUseItem
	{
		None = 0,
		SpeedUp,
		AutoComplete,
		SlotOpen
	}

	// Config.RewardItemData - alias to the standalone RewardItemData class
	// The standalone RewardItemData class already implements IRewardItemData.
	// Usage like Config.RewardItemData maps to the global RewardItemData.
	public class RewardItemData : IRewardItemData
	{
		public int rewardType;
		public int rewardIdx;
		public BigInteger rewardValue;
		public int rewardRegion;
		public string resImg;
		public AtlasType atlasType;
		public bool isTimeRevenue;
		public bool IsSpecialReward;

		public RewardItemData() { }

		public RewardItemData(int type, int idx, BigInteger value, int region = -1, string res = "", AtlasType atlas = AtlasType.None, bool bTimeRevenue = true)
		{
			rewardType = type;
			rewardIdx = idx;
			rewardValue = value;
			rewardRegion = region;
			resImg = res;
			atlasType = atlas;
			isTimeRevenue = bTimeRevenue;
		}

		public bool EnableReward()
		{
			return rewardValue > 0;
		}
	}
}
