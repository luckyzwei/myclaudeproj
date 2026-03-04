using System;
using System.Collections.Generic;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using Vector2 = UnityEngine.Vector2;
using DG.Tweening;
using Treeplla;
using UnityEngine;

public class ProjectUtility
{
	public enum EventEnterType
	{
		icon = 0,
		popup = 1,
		popup_end = 2,
		event_clear = 3
	}

	public static readonly string SAVE_STAGE_CLEAR_TIME_KEY;

	public static readonly string SAVE_MAX_TOGGLE;

	public static readonly string SEGMENT_PROJECT_NAME;

	private static string str_day;

	private static string str_hour;

	private static string str_minute;

	private static string str_seconds;

	private static string str_day_long;

	private static string str_hour_long;

	private static string str_minute_long;

	private static string str_seconds_long;

	public static int DailyResetHour;

	public static string Str_minute_long => null;

	public static string Str_second_long => null;

	public static void Init()
	{
	}

	public static void InitStr()
	{
	}

	public static Vector3 GetScreenCenterPos()
	{
		return default(Vector3);
	}

	public static Vector2 worldToLocalUISpace(Transform parentT, Vector3 worldPos)
	{
		return default(Vector2);
	}

	public static bool IsInViewport(Vector3 worldPosition)
	{
		return false;
	}

	public static void CreateItems<T>(Transform parent, GameObject itemPrefab, int count, bool isActive = false) where T : Component
	{
	}

	public static bool EnableGetStatue(int statue_idx)
	{
		return false;
	}

	public static void InitParkingLotData()
	{
	}

	public static Sprite GetRewardIconImg(int type, int idx, int region, int order = 0)
	{
		return null;
	}

	public static Sprite GetCurrencyImg(int currencyId, int regionIdx, int resourceIdx)
	{
		return null;
	}

	public static Sprite GetItemImg(int idx)
	{
		return null;
	}

	public static Sprite GetImg(string img)
	{
		return null;
	}

	public static string GetCurrencyIconPath(int currencyId, int regionIdx, int resourceIdx)
	{
		return null;
	}

	public static string GetCompanyGradeText(int grade)
	{
		return null;
	}

	public static string GetCompanyGradeBGColorKey(int grade)
	{
		return null;
	}

	public static void CloseActionNotiSequence(int facilityidx, int slotidx = -1)
	{
	}

	public static DateTime GetNextResetTime(DateTime date)
	{
		return default(DateTime);
	}

	public static DateTime GetNextResetTimeByHour(DateTime date, int hour)
	{
		return default(DateTime);
	}

	public static DateTime GetNextMonday(DateTime date)
	{
		return default(DateTime);
	}

	public static DateTime GetNextWeekDay(DateTime startTime, DateTime nowTime)
	{
		return default(DateTime);
	}

	public static int GetWeeklyResetCountFromStart(DateTime startTime, DateTime nowTime)
	{
		return 0;
	}

	public static int GetCurGemPassGroup()
	{
		return 0;
	}

	public static int GetOfficeFloor(int office)
	{
		return 0;
	}

	public static int GetOfficeNumber(int officeIdx)
	{
		return 0;
	}

	public static void SetLayer(GameObject go, int layer)
	{
	}

	public static BigInteger GetCeoRoomRentalFee(int region)
	{
		return default(BigInteger);
	}

	public static BigInteger GetOfficeDeskRendFee(int region, int office)
	{
		return default(BigInteger);
	}

	public static int GetZoneToRegion(int zone)
	{
		return 0;
	}

	public static int GetBuildingToRegion(int buildingIdx)
	{
		return 0;
	}

	public static string GetTextHexColor(string colorKey)
	{
		return null;
	}

	public static string MakeColorString(string text, string colorKey)
	{
		return null;
	}

	public static bool EnableEnterCarMarket(int buildingIdx)
	{
		return false;
	}

	public static string GetRegionName(int region)
	{
		return null;
	}

	public static BuildingInfoData GetStageLastBuildingTable(Config.BuildingType buildingType, bool checkOpen = false)
	{
		return null;
	}

	public static int GetLastHouse()
	{
		return 0;
	}

	public static bool HasAnyHouse()
	{
		return false;
	}

	public static bool IsOnParkingSetBuff(int zoneIdx)
	{
		return false;
	}

	public static int GetAllCatCount()
	{
		return 0;
	}

	public static Config.OfficeType GetRoomType(int region, int roomIdx)
	{
		return default(Config.OfficeType);
	}

	public static int GetTotalPower()
	{
		return 0;
	}

	public static void GotoRoom(int officeIdx, int focustype = -1, int focuslevel = -1, Action Cb = null)
	{
	}

	public static string GetEventMissionText(int stage, int type, int target, int count)
	{
		return null;
	}

	public static int GetRandomSeed()
	{
		return 0;
	}

	public static void SetAbilityReward(int type, int target, int value)
	{
	}

	public static void Vibrate()
	{
	}

	public static BigInteger CurFacilitySumValue()
	{
		return default(BigInteger);
	}

	public static BigInteger GetOfflineValue(int region, int timeSeconds)
	{
		return default(BigInteger);
	}

	public static BigInteger GetOfflineExpValue(int region, int timeSeconds)
	{
		return default(BigInteger);
	}

	public static BigInteger GetOfflineExpValueWithBuff(int region, int timeSeconds)
	{
		return default(BigInteger);
	}

	public static void SlowGraphic(bool isOn)
	{
	}

	public static Vector3 GetMultipleRewardAlignedPos(int iconSpace, int rewardCnt, int index)
	{
		return default(Vector3);
	}

	public static void PlayGoodsEffect(Vector3 startPos, int rewardType, int rewardIdx, int rewardRegion, BigInteger value, bool isCenterStart = true, Action OnEnd = null, float delay = 0f, string viewText = "", bool ispopup = false, bool reward = true, bool underOrder = false, Vector3 endPos = default(Vector3))
	{
	}

	public static void PlayCurveEffect(Vector3 startPos, int rewardType, int rewardIdx, int rewardRegion, int rewardGrade, Action OnEnd = null, float delay = 0f, bool ispopup = false, bool underOrder = false)
	{
	}

	public static void GoodsGetEffect(Vector3 worldStartPos, Vector3 worldMiddlePos, Vector3 worldEndPos, int goodsType, int goodsIdx, int goodsRegion, BigInteger goodsCnt, Action OnEnd = null, float delay = 0f, string viewText = "", bool underOrder = false, string ani = "Show")
	{
	}

	public static void IconGetEffect(Vector3 worldStartPos, Vector3 worldEndPos, Config.AtlasType atlasType, string Icon, string CountText, Action OnEnd = null, bool isCenter = true, string Ani = "Show", float firstmovetime = 0.95f, Vector2 iconSize = default(Vector2))
	{
	}

	public static void PackageGetEffect(Vector3 worldEndPos, int packageIdx, Action OnEnd = null)
	{
	}

	public static void GetSeasonalPointEffect(Vector3 worldStartPos, Vector3 worldEndPos, int count)
	{
	}

	public static void PiggyGetEffect(Vector3 worldStartPos, Vector3 worldEndPos, int count)
	{
	}

	public static void HudUpdatePiggyValue()
	{
	}

	public static void OneTimeGetEffect(int curCount, Vector3 worldStartPos, Vector3 worldEndPos, Action effectCb)
	{
	}

	public static void LevelGetEffect(Vector3 worldStartPos, Action endCb = null)
	{
	}

	public static void SeasonalGetEffect(Dictionary<int, BigInteger> rewards, Vector3 worldStartPos, Vector3 worldEndPos, Action effectEndCb = null)
	{
	}

	public static void ShowRichWayProgress(int startPoint, int getPoint)
	{
	}

	public static void ShowKeyProgressByPageReward(Config.ItemIdx itemIdx, int gainKey)
	{
	}

	public static void ShowKeyProgressByPageReward(int keyIdx, int gainKey)
	{
	}

	public static void ShowKeyProgressByGoodsEffect(Vector3 startPos, int rewardType, int rewardIdx, int value, bool isReward = true)
	{
	}

	public static void SetPlantGetEffect(int plantIdx = -1)
	{
	}

	public static Sequence PlayPlantGetEffect(int plantIdx = -1)
	{
		return null;
	}

	public static int PercentCalculation(int partvalue, float totalvalue)
	{
		return 0;
	}

	public static int RemainCalculatetime(DateTime starttime, int limittime)
	{
		return 0;
	}

	public static bool IsInterAdPage()
	{
		return false;
	}

	public static void ShowInterAdPage(TpMaxProp.AdInterType type, Action Callback)
	{
	}

	public static HUDBase GetHUDBase()
	{
		return null;
	}

	public static void FriendInvite(Action successAction, Action endAction = null, bool isPopup = true)
	{
	}

	public static void ResetInviteGem()
	{
	}

	public static bool ShopContentsOpenConvert(int boxidx)
	{
		return false;
	}

	public static bool ContentsOpenCheck(Config.ContentsOpenType opentype, bool checkMain = false)
	{
		return false;
	}

	public static Dictionary<int, int> GetFixedGachaList(int shopBoxIdx)
	{
		return null;
	}

	public static List<Config.RewardItemData> GetRandomGachaList(int shopIdx)
	{
		return null;
	}

	public static Dictionary<int, int> GetRandomGachaList(int shopBoxIdx, bool fixStageManager = false)
	{
		return null;
	}

	public static string GetRewardString(int type, int idx, Config.RegionType region, bool addRegionName = false)
	{
		return null;
	}

	public static string GetRewardString(int type, int idx, int region, bool addRegionName = false)
	{
		return null;
	}

	public static string GetRecordCountText(Config.RecordCountKeys key, params object[] objs)
	{
		return null;
	}

	public static string GetRecordValueText(Config.RecordKeys key, params object[] objs)
	{
		return null;
	}

	public static void ShowBuildingArrowNoti(int buildingIdx)
	{
	}

	private static void ShowRegionArrowNoti(int zoneIdx)
	{
	}

	public static void ShowGetRichPointArrowNoti(int regionIdx)
	{
	}

	public static void OpenPhoneAndFocusCompany(int companyIdx)
	{
	}

	public static long GetDiffTimeByStageStartTime()
	{
		return 0L;
	}

	public static int CalcCompanyRentalFee(in CompanyInfoData compInfo, in CompanyLevelData compLvInfo)
	{
		return 0;
	}

	public static bool IsSpecialCompany(int companyIdx)
	{
		return false;
	}

	public static bool IsSpecialCompany(CompanyInfoData companyTable)
	{
		return false;
	}

	public static bool CheckCost(int type, int idx, int region, BigInteger cost, out BigInteger needValue)
	{
		needValue = default(BigInteger);
		return false;
	}

	public static BigInteger GetLimitMoneyByRegion(in Config.RegionType region)
	{
		return default(BigInteger);
	}

	public static BigInteger GetLimitMoneyByRegion(in int regionType)
	{
		return default(BigInteger);
	}

	public static bool IsLimitRewardMoney(in Config.RegionType region, in BigInteger revenue)
	{
		return false;
	}

	public static bool IsLimitRewardMoney(in int region, in BigInteger revenue)
	{
		return false;
	}

	public static BigInteger GetLimitRewardMoneyByRegion(in Config.RegionType region, in BigInteger rewardValue)
	{
		return default(BigInteger);
	}

	public static BigInteger GetLimitRewardMoneyByRegion(in int regionType, in BigInteger rewardValue)
	{
		return default(BigInteger);
	}

	public static BigInteger GetMoneyByRegion(in Config.RegionType region)
	{
		return default(BigInteger);
	}

	public static BigInteger GetMoneyByRegion(in int region)
	{
		return default(BigInteger);
	}

	public static int GetRegionIdxByMoneyType(Config.CurrencyID moneyType)
	{
		return 0;
	}

	public static bool IsMoney(int rewardType, int idx)
	{
		return false;
	}

	public static bool IsMoney(int idx)
	{
		return false;
	}

	public static bool IsPower(int idx)
	{
		return false;
	}

	public static bool IsPoint(int idx)
	{
		return false;
	}

	public static int FindRegionCurHouseIdx(int region = -1)
	{
		return 0;
	}

	public static int FindRegionFirstHouseIdx(int region = -1)
	{
		return 0;
	}

	public static int GetParkingLotCount(int region = -1)
	{
		return 0;
	}

	public static int GetCarCount(int region = -1)
	{
		return 0;
	}

	public static bool GetEnableParking(out int parking_zone, out int parking_space)
	{
		parking_zone = default(int);
		parking_space = default(int);
		return false;
	}

	public static void ShowPagePackage(ShopSystem.InAppPurchaseLocation location, int idx, Action hideAction = null, bool ignoreGroup = false, bool waitOtherProcess = false)
	{
	}

	public static void GotoInsufficientShop(int currencyID, int region, BigInteger needValue, Action onComplete = null)
	{
	}

	public static void GotoInsufficientShopWithParams(int currencyID, int region, BigInteger needValue, Action onComplete = null, params object[] logParams)
	{
	}

	public static void GotoInsufficientShopWithPacakge(int currencyID, int region, BigInteger needValue, Action onComplete = null, bool packageMode = false, int packageIdx = -1, params object[] logParams)
	{
	}

	private static void OpenPurchasePopup(int currencyID, int region, BigInteger needValue, Action onComplete, bool packageMode, int packageIdx, params object[] logParams)
	{
	}

	private static bool IsShopAvailable()
	{
		return false;
	}

	private static void ShowInsufficientToast()
	{
	}

	private static void OpenMoneyPurchasePopup(int region, BigInteger needValue, Action onComplete, params object[] logParams)
	{
	}

	private static void OpenGemPurchasePopup(int currencyID, int region, Action onComplete, bool packageMode = false, int packageIdx = -1)
	{
	}

	public static void LogNomoneyPopup(int rewardType, int currencyID, int regionType, BigInteger needValue, params object[] a_params)
	{
	}

	public static bool CheckCashPromotion()
	{
		return false;
	}

	public static void ConsumeCashLog(BigInteger consumeCash, TpAnalyticsProp.LogCostCashType idx, TpAnalyticsProp.LogCostCashPlace place = TpAnalyticsProp.LogCostCashPlace.None, params object[] a_params)
	{
	}

	public static string GetThousandCommaText(BigInteger data)
	{
		return null;
	}

	public static BigInteger GetCurrentCurrencyAmount(int currencyID, int region)
	{
		return default(BigInteger);
	}

	public static void PurchaseNoAdsRefundAbility7()
	{
	}

	public static void SetNoAds()
	{
	}

	public static void SetLvPass(int groupIdx)
	{
	}

	public static void UpdateNoAdsHUDs()
	{
	}

	public static int GetShopCashPromotionCount(string pid, int maxCount)
	{
		return 0;
	}

	public static void PurchaseShopCash(int itemIdx, ShopSystem.InAppPurchaseLocation purchaseLocation, Vector3 effectStartPos, Action refreshAction = null, Action completeAction = null)
	{
	}

	public static void SetSuperStaffLock(SuperStaffStatBtn btn, int abilityIdx, bool second = false)
	{
	}

	public static void ReLoadGame(bool changeQuality = false, bool converUserData = false)
	{
	}

	public static string GetTimeStringFormattingBoost(int seconds)
	{
		return null;
	}

	public static string GetTimeStringFormattingShort(int seconds)
	{
		return null;
	}

	public static string GetTimeStringFormattingShort2(int seconds)
	{
		return null;
	}

	public static string GetTimeStringFormattingShort3(int milliseconds)
	{
		return null;
	}

	public static string GetAbilityValueString(AbilitySystem.AbilityType abilityType, int value)
	{
		return null;
	}

	public static string GetAbilityValueString(int abilityType, int value)
	{
		return null;
	}

	public static string GetAbilityIconName(AbilityInfoData abilityInfoData)
	{
		return null;
	}

	public static string GetTimeStringFormattingDayTimer(int seconds)
	{
		return null;
	}

	public static string GetTimeStringFormattingMinSec(int seconds, char separator)
	{
		return null;
	}

	public static string GetTimeStringFormattingLong(int seconds, char separator)
	{
		return null;
	}

	public static string GetTimeStringFormattingOneDigit(int seconds)
	{
		return null;
	}

	public static string GetTimeStringFormattingTwoDigit(int seconds)
	{
		return null;
	}

	public static string GetTimeStringFormattingTwoDigitLong(int seconds)
	{
		return null;
	}

	public static string GetTimeStringFormattingLong(int seconds, bool bShowZeroSeconds = true)
	{
		return null;
	}

	public static bool IsStarterPackageFirst(int packageIdx)
	{
		return false;
	}

	public static string GetAddDayTimeStringFormattingLong(int seconds, char separator)
	{
		return null;
	}

	public static BigInteger GetWorldMapCarHouseSaleValue(BigInteger cost)
	{
		return default(BigInteger);
	}

	public static int GetInGameRegionByRewardRegion(int rewardRegion)
	{
		return 0;
	}

	public static int GetRewardIdxByRewardRegion(int rewardType, int rewardIdx, int rewardRegion)
	{
		return 0;
	}

	public static CurrencyData GetCurrencyTableData(int currencyId, int regionIdx)
	{
		return null;
	}

	public static string GetRewardIconByRewardRegion(int rewardRegion, string rewardIcon)
	{
		return null;
	}

	public static void RevLog(int addRev)
	{
	}

	public static void IAPUniqueLog(int addRev, string currencyCode)
	{
	}

	public static string GetOfficeItemInfoName(OfficeItemInfoData officeItemInfo)
	{
		return null;
	}

	public static string GetOfficeItemInfoDesc(OfficeItemInfoData officeItemInfo)
	{
		return null;
	}

	public static string GetOfficeItemInfoIcon(OfficeItemInfoData officeItemInfo)
	{
		return null;
	}

	public static int GetCompanyLevelNeedExp(CompanyLevelData companyLevel)
	{
		return 0;
	}

	public static bool GetDailyQuestEnableRegion(DailyQuestListData dailyQuestListData)
	{
		return false;
	}

	public static int GetCompanyGradeStrikeCEOLv(CompanyGradeData companyGradeData, int region = -1)
	{
		return 0;
	}

	public static BigInteger GetRewardAmount(int rewardType, int rewardID, int region)
	{
		return default(BigInteger);
	}

	public static int CalculateRewardRequiredCash(Config.RewardType rewardType, int rewardIdx, int regionType, BigInteger amount)
	{
		return 0;
	}

	public static int GetNextHouseIdx(int currentHouseIdx)
	{
		return 0;
	}

	public static bool CheckHousePurchaseCondition(int houseIdx)
	{
		return false;
	}

	public static bool ShouldShowConversationForHouse(int houseIdx)
	{
		return false;
	}

	public static bool CanBuyNextHouse(int currentHouseIdx)
	{
		return false;
	}

	public static int GetLastCarStoreIdx()
	{
		return 0;
	}

	public static float CalculateValueRatio<T>(T curValue, T maxValue)
	{
		return 0f;
	}

	public static Config.ItemType IsItemType(int itemIdx)
	{
		return default(Config.ItemType);
	}

	public static void SetSegmentChange()
	{
	}

	public static bool IsReceivableFreecashReward()
	{
		return false;
	}

	public static int GetFreecashRewardCount()
	{
		return 0;
	}

	public static bool IsLinkedFreecash()
	{
		return false;
	}
}
