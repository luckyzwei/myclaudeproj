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

	public static string Str_minute_long => str_minute_long;

	public static string Str_second_long => str_seconds_long;

	public static void Init()
	{
		DailyResetHour = 5;
		InitStr();
		InitParkingLotData();
	}

	public static void InitStr()
	{
		str_day = "d";
		str_hour = "h";
		str_minute = "m";
		str_seconds = "s";
		str_day_long = "day";
		str_hour_long = "hour";
		str_minute_long = "min";
		str_seconds_long = "sec";
	}

	public static Vector3 GetScreenCenterPos()
	{
		var cam = Camera.main;
		if (cam == null) return Vector3.zero;
		return cam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, cam.nearClipPlane));
	}

	public static Vector2 worldToLocalUISpace(Transform parentT, Vector3 worldPos)
	{
		var cam = Camera.main;
		if (cam == null || parentT == null) return Vector2.zero;
		Vector3 screenPos = cam.WorldToScreenPoint(worldPos);
		RectTransformUtility.ScreenPointToLocalPointInRectangle(
			parentT as RectTransform, screenPos, null, out Vector2 localPoint);
		return localPoint;
	}

	public static bool IsInViewport(Vector3 worldPosition)
	{
		var cam = Camera.main;
		if (cam == null) return false;
		Vector3 viewportPoint = cam.WorldToViewportPoint(worldPosition);
		return viewportPoint.x >= 0f && viewportPoint.x <= 1f &&
		       viewportPoint.y >= 0f && viewportPoint.y <= 1f &&
		       viewportPoint.z > 0f;
	}

	public static void CreateItems<T>(Transform parent, GameObject itemPrefab, int count, bool isActive = false) where T : Component
	{
		if (parent == null || itemPrefab == null) return;
		for (int i = 0; i < count; i++)
		{
			var go = UnityEngine.Object.Instantiate(itemPrefab, parent);
			go.SetActive(isActive);
		}
	}

	public static bool EnableGetStatue(int statue_idx)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return false;
		return true;
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
		switch (grade)
		{
			case 0: return "F";
			case 1: return "E";
			case 2: return "D";
			case 3: return "C";
			case 4: return "B";
			case 5: return "A";
			case 6: return "S";
			case 7: return "SS";
			case 8: return "SSS";
			default: return "F";
		}
	}

	public static string GetCompanyGradeBGColorKey(int grade)
	{
		switch (grade)
		{
			case 0: return "company_grade_f";
			case 1: return "company_grade_e";
			case 2: return "company_grade_d";
			case 3: return "company_grade_c";
			case 4: return "company_grade_b";
			case 5: return "company_grade_a";
			case 6: return "company_grade_s";
			case 7: return "company_grade_ss";
			case 8: return "company_grade_sss";
			default: return "company_grade_f";
		}
	}

	public static void CloseActionNotiSequence(int facilityidx, int slotidx = -1)
	{
	}

	public static DateTime GetNextResetTime(DateTime date)
	{
		return GetNextResetTimeByHour(date, DailyResetHour);
	}

	public static DateTime GetNextResetTimeByHour(DateTime date, int hour)
	{
		var resetTime = new DateTime(date.Year, date.Month, date.Day, hour, 0, 0, date.Kind);
		if (date >= resetTime)
			resetTime = resetTime.AddDays(1);
		return resetTime;
	}

	public static DateTime GetNextMonday(DateTime date)
	{
		int daysUntilMonday = ((int)DayOfWeek.Monday - (int)date.DayOfWeek + 7) % 7;
		if (daysUntilMonday == 0) daysUntilMonday = 7;
		return new DateTime(date.Year, date.Month, date.Day, DailyResetHour, 0, 0, date.Kind).AddDays(daysUntilMonday);
	}

	public static DateTime GetNextWeekDay(DateTime startTime, DateTime nowTime)
	{
		int weeksPassed = GetWeeklyResetCountFromStart(startTime, nowTime);
		return startTime.AddDays((weeksPassed + 1) * 7);
	}

	public static int GetWeeklyResetCountFromStart(DateTime startTime, DateTime nowTime)
	{
		double totalDays = (nowTime - startTime).TotalDays;
		if (totalDays < 0) return 0;
		return (int)(totalDays / 7);
	}

	public static int GetCurGemPassGroup()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.ShopSystem == null || root.ShopSystem.InGemPass == null) return 0;
		var gemPass = root.ShopSystem.InGemPass;
		for (int i = gemPass.Count - 1; i >= 0; i--)
		{
			if (gemPass[i] > 0) return i;
		}
		return 0;
	}

	public static int GetOfficeFloor(int office)
	{
		return office / 100;
	}

	public static int GetOfficeNumber(int officeIdx)
	{
		return officeIdx % 100;
	}

	public static void SetLayer(GameObject go, int layer)
	{
		if (go == null) return;
		go.layer = layer;
		var transforms = go.GetComponentsInChildren<Transform>(true);
		for (int i = 0; i < transforms.Length; i++)
		{
			transforms[i].gameObject.layer = layer;
		}
	}

	public static BigInteger GetCeoRoomRentalFee(int region)
	{
		return BigInteger.Zero;
	}

	public static BigInteger GetOfficeDeskRendFee(int region, int office)
	{
		return BigInteger.Zero;
	}

	public static int GetZoneToRegion(int zone)
	{
		return zone / 100;
	}

	public static int GetBuildingToRegion(int buildingIdx)
	{
		return buildingIdx / 1000;
	}

	public static string GetTextHexColor(string colorKey)
	{
		if (string.IsNullOrEmpty(colorKey)) return "#FFFFFF";
		return "#FFFFFF";
	}

	public static string MakeColorString(string text, string colorKey)
	{
		string hex = GetTextHexColor(colorKey);
		return $"<color={hex}>{text}</color>";
	}

	public static bool EnableEnterCarMarket(int buildingIdx)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return false;
		return root.ContentsOpenSystem != null && root.ContentsOpenSystem.IsContentsOpen(new List<int> { buildingIdx });
	}

	public static string GetRegionName(int region)
	{
		return "region_name_" + region;
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
		return GetLastHouse() > 0;
	}

	public static bool IsOnParkingSetBuff(int zoneIdx)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.BuffSystem == null) return false;
		return false;
	}

	public static int GetAllCatCount()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return 0;
		return 0;
	}

	public static Config.OfficeType GetRoomType(int region, int roomIdx)
	{
		return Config.OfficeType.Normal;
	}

	public static int GetTotalPower()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return 0;
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
		return (int)(DateTime.UtcNow.Ticks & 0x7FFFFFFF);
	}

	public static void SetAbilityReward(int type, int target, int value)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.AbilitySystem == null) return;
		root.AbilitySystem.UpdateAbility((AbilitySystem.AbilityType)type);
	}

	public static void Vibrate()
	{
#if UNITY_ANDROID && !UNITY_EDITOR
		Handheld.Vibrate();
#endif
	}

	public static BigInteger CurFacilitySumValue()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return BigInteger.Zero;
		return BigInteger.Zero;
	}

	public static BigInteger GetOfflineValue(int region, int timeSeconds)
	{
		if (timeSeconds <= 0) return BigInteger.Zero;
		return BigInteger.Zero;
	}

	public static BigInteger GetOfflineExpValue(int region, int timeSeconds)
	{
		if (timeSeconds <= 0) return BigInteger.Zero;
		return BigInteger.Zero;
	}

	public static BigInteger GetOfflineExpValueWithBuff(int region, int timeSeconds)
	{
		BigInteger baseExp = GetOfflineExpValue(region, timeSeconds);
		return baseExp;
	}

	public static void SlowGraphic(bool isOn)
	{
		Application.targetFrameRate = isOn ? 30 : 60;
	}

	public static Vector3 GetMultipleRewardAlignedPos(int iconSpace, int rewardCnt, int index)
	{
		if (rewardCnt <= 0) return Vector3.zero;
		float totalWidth = (rewardCnt - 1) * iconSpace;
		float startX = -totalWidth / 2f;
		return new Vector3(startX + index * iconSpace, 0f, 0f);
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
		if (totalvalue <= 0f) return 0;
		return Mathf.RoundToInt((partvalue / totalvalue) * 100f);
	}

	public static int RemainCalculatetime(DateTime starttime, int limittime)
	{
		double elapsed = (DateTime.UtcNow - starttime).TotalSeconds;
		int remain = limittime - (int)elapsed;
		return remain > 0 ? remain : 0;
	}

	public static bool IsInterAdPage()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.ShopSystem == null) return false;
		return !root.ShopSystem.NoAds;
	}

	public static void ShowInterAdPage(TpMaxProp.AdInterType type, Action Callback)
	{
		Callback?.Invoke();
	}

	public static HUDBase GetHUDBase()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.InGameSystem == null) return null;
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
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.ContentsOpenSystem == null) return false;
		return root.ContentsOpenSystem.IsContentsOpen(new List<int> { boxidx });
	}

	public static bool ContentsOpenCheck(Config.ContentsOpenType opentype, bool checkMain = false)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.ContentsOpenSystem == null) return false;
		return root.ContentsOpenSystem.IsContentsOpen(new List<int> { (int)opentype });
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
		return GetRewardString(type, idx, (int)region, addRegionName);
	}

	public static string GetRewardString(int type, int idx, int region, bool addRegionName = false)
	{
		string name = "reward_" + type + "_" + idx;
		if (addRegionName && region > 0)
			name = GetRegionName(region) + " " + name;
		return name;
	}

	public static string GetRecordCountText(Config.RecordCountKeys key, params object[] objs)
	{
		return string.Format("record_{0}", (int)key);
	}

	public static string GetRecordValueText(Config.RecordKeys key, params object[] objs)
	{
		return string.Format("record_{0}", (int)key);
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
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.TimeSystem == null) return 0L;
		return (long)(DateTime.UtcNow - TimeSystem.GetCurTime()).TotalSeconds;
	}

	public static int CalcCompanyRentalFee(in CompanyInfoData compInfo, in CompanyLevelData compLvInfo)
	{
		if (compLvInfo == null) return 0;
		return compLvInfo.RentalFee;
	}

	public static bool IsSpecialCompany(int companyIdx)
	{
		return companyIdx >= 10000;
	}

	public static bool IsSpecialCompany(CompanyInfoData companyTable)
	{
		if (companyTable == null) return false;
		return IsSpecialCompany(companyTable.Idx);
	}

	public static bool CheckCost(int type, int idx, int region, BigInteger cost, out BigInteger needValue)
	{
		needValue = BigInteger.Zero;
		BigInteger currentAmount = GetCurrentCurrencyAmount(idx, region);
		if (currentAmount >= cost) return true;
		needValue = cost - currentAmount;
		return false;
	}

	public static BigInteger GetLimitMoneyByRegion(in Config.RegionType region)
	{
		return GetLimitMoneyByRegion((int)region);
	}

	public static BigInteger GetLimitMoneyByRegion(in int regionType)
	{
		return BigInteger.Parse("999999999999999999");
	}

	public static bool IsLimitRewardMoney(in Config.RegionType region, in BigInteger revenue)
	{
		return IsLimitRewardMoney((int)region, revenue);
	}

	public static bool IsLimitRewardMoney(in int region, in BigInteger revenue)
	{
		BigInteger limit = GetLimitMoneyByRegion(region);
		BigInteger current = GetMoneyByRegion(region);
		return current + revenue > limit;
	}

	public static BigInteger GetLimitRewardMoneyByRegion(in Config.RegionType region, in BigInteger rewardValue)
	{
		return GetLimitRewardMoneyByRegion((int)region, rewardValue);
	}

	public static BigInteger GetLimitRewardMoneyByRegion(in int regionType, in BigInteger rewardValue)
	{
		BigInteger limit = GetLimitMoneyByRegion(regionType);
		BigInteger current = GetMoneyByRegion(regionType);
		BigInteger remaining = limit - current;
		if (remaining < BigInteger.Zero) remaining = BigInteger.Zero;
		return rewardValue < remaining ? rewardValue : remaining;
	}

	public static BigInteger GetMoneyByRegion(in Config.RegionType region)
	{
		return GetMoneyByRegion((int)region);
	}

	public static BigInteger GetMoneyByRegion(in int region)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return BigInteger.Zero;
		return BigInteger.Zero;
	}

	public static int GetRegionIdxByMoneyType(Config.CurrencyID moneyType)
	{
		return (int)moneyType;
	}

	public static bool IsMoney(int rewardType, int idx)
	{
		return rewardType == (int)Config.RewardType.Currency && IsMoney(idx);
	}

	public static bool IsMoney(int idx)
	{
		return idx == (int)Config.CurrencyID.Gold;
	}

	public static bool IsPower(int idx)
	{
		return idx == (int)Config.CurrencyID.Heart;
	}

	public static bool IsPoint(int idx)
	{
		return idx == (int)Config.CurrencyID.Star;
	}

	public static int FindRegionCurHouseIdx(int region = -1)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return -1;
		return -1;
	}

	public static int FindRegionFirstHouseIdx(int region = -1)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return -1;
		return -1;
	}

	public static int GetParkingLotCount(int region = -1)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return 0;
		return 0;
	}

	public static int GetCarCount(int region = -1)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return 0;
		return 0;
	}

	public static bool GetEnableParking(out int parking_zone, out int parking_space)
	{
		parking_zone = -1;
		parking_space = -1;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return false;
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
		return data.ToString("N0");
	}

	public static BigInteger GetCurrentCurrencyAmount(int currencyID, int region)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return BigInteger.Zero;
		if (IsMoney(currencyID))
			return GetMoneyByRegion(region);
		return BigInteger.Zero;
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
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return 0;
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
		if (seconds <= 0) return "0" + str_seconds;
		int h = seconds / 3600;
		int m = (seconds % 3600) / 60;
		int s = seconds % 60;
		if (h > 0) return $"{h}{str_hour} {m:D2}{str_minute}";
		if (m > 0) return $"{m}{str_minute} {s:D2}{str_seconds}";
		return $"{s}{str_seconds}";
	}

	public static string GetTimeStringFormattingShort(int seconds)
	{
		if (seconds <= 0) return "0" + str_seconds;
		int d = seconds / 86400;
		int h = (seconds % 86400) / 3600;
		int m = (seconds % 3600) / 60;
		int s = seconds % 60;
		if (d > 0) return $"{d}{str_day} {h}{str_hour}";
		if (h > 0) return $"{h}{str_hour} {m}{str_minute}";
		if (m > 0) return $"{m}{str_minute} {s}{str_seconds}";
		return $"{s}{str_seconds}";
	}

	public static string GetTimeStringFormattingShort2(int seconds)
	{
		if (seconds <= 0) return "0" + str_seconds;
		int h = seconds / 3600;
		int m = (seconds % 3600) / 60;
		int s = seconds % 60;
		if (h > 0) return $"{h}{str_hour} {m:D2}{str_minute}";
		if (m > 0) return $"{m}{str_minute} {s:D2}{str_seconds}";
		return $"{s}{str_seconds}";
	}

	public static string GetTimeStringFormattingShort3(int milliseconds)
	{
		int totalSeconds = milliseconds / 1000;
		int ms = milliseconds % 1000;
		int m = totalSeconds / 60;
		int s = totalSeconds % 60;
		if (m > 0) return $"{m}{str_minute} {s:D2}.{(ms / 100):D1}{str_seconds}";
		return $"{s}.{(ms / 100):D1}{str_seconds}";
	}

	public static string GetAbilityValueString(AbilitySystem.AbilityType abilityType, int value)
	{
		return GetAbilityValueString((int)abilityType, value);
	}

	public static string GetAbilityValueString(int abilityType, int value)
	{
		return value + "%";
	}

	public static string GetAbilityIconName(AbilityInfoData abilityInfoData)
	{
		if (abilityInfoData == null) return "";
		return "ability_icon_" + abilityInfoData.Idx;
	}

	public static string GetTimeStringFormattingDayTimer(int seconds)
	{
		if (seconds <= 0) return $"0{str_day} 00:00:00";
		int d = seconds / 86400;
		int h = (seconds % 86400) / 3600;
		int m = (seconds % 3600) / 60;
		int s = seconds % 60;
		return $"{d}{str_day} {h:D2}:{m:D2}:{s:D2}";
	}

	public static string GetTimeStringFormattingMinSec(int seconds, char separator)
	{
		if (seconds <= 0) return $"00{separator}00";
		int m = seconds / 60;
		int s = seconds % 60;
		return $"{m:D2}{separator}{s:D2}";
	}

	public static string GetTimeStringFormattingLong(int seconds, char separator)
	{
		if (seconds <= 0) return $"00{separator}00{separator}00";
		int h = seconds / 3600;
		int m = (seconds % 3600) / 60;
		int s = seconds % 60;
		return $"{h:D2}{separator}{m:D2}{separator}{s:D2}";
	}

	public static string GetTimeStringFormattingOneDigit(int seconds)
	{
		if (seconds <= 0) return "0:00:00";
		int h = seconds / 3600;
		int m = (seconds % 3600) / 60;
		int s = seconds % 60;
		return $"{h}:{m:D2}:{s:D2}";
	}

	public static string GetTimeStringFormattingTwoDigit(int seconds)
	{
		if (seconds <= 0) return "00:00";
		int m = seconds / 60;
		int s = seconds % 60;
		return $"{m:D2}:{s:D2}";
	}

	public static string GetTimeStringFormattingTwoDigitLong(int seconds)
	{
		if (seconds <= 0) return "00:00:00";
		int h = seconds / 3600;
		int m = (seconds % 3600) / 60;
		int s = seconds % 60;
		return $"{h:D2}:{m:D2}:{s:D2}";
	}

	public static string GetTimeStringFormattingLong(int seconds, bool bShowZeroSeconds = true)
	{
		if (seconds <= 0) return bShowZeroSeconds ? $"0{str_seconds_long}" : "";
		int d = seconds / 86400;
		int h = (seconds % 86400) / 3600;
		int m = (seconds % 3600) / 60;
		int s = seconds % 60;
		string result = "";
		if (d > 0) result += $"{d}{str_day_long} ";
		if (h > 0) result += $"{h}{str_hour_long} ";
		if (m > 0) result += $"{m}{str_minute_long} ";
		if (s > 0 || bShowZeroSeconds) result += $"{s}{str_seconds_long}";
		return result.TrimEnd();
	}

	public static bool IsStarterPackageFirst(int packageIdx)
	{
		return packageIdx == ShopSystem.StartPackageIdx;
	}

	public static string GetAddDayTimeStringFormattingLong(int seconds, char separator)
	{
		if (seconds <= 0) return $"0{str_day} 00{separator}00{separator}00";
		int d = seconds / 86400;
		int h = (seconds % 86400) / 3600;
		int m = (seconds % 3600) / 60;
		int s = seconds % 60;
		return $"{d}{str_day} {h:D2}{separator}{m:D2}{separator}{s:D2}";
	}

	public static BigInteger GetWorldMapCarHouseSaleValue(BigInteger cost)
	{
		return cost / 2;
	}

	public static int GetInGameRegionByRewardRegion(int rewardRegion)
	{
		if (rewardRegion <= 0)
		{
			return 1;
		}
		return rewardRegion;
	}

	public static int GetRewardIdxByRewardRegion(int rewardType, int rewardIdx, int rewardRegion)
	{
		return rewardIdx;
	}

	public static CurrencyData GetCurrencyTableData(int currencyId, int regionIdx)
	{
		return null;
	}

	public static string GetRewardIconByRewardRegion(int rewardRegion, string rewardIcon)
	{
		if (string.IsNullOrEmpty(rewardIcon)) return "";
		return rewardIcon;
	}

	public static void RevLog(int addRev)
	{
	}

	public static void IAPUniqueLog(int addRev, string currencyCode)
	{
	}

	public static string GetOfficeItemInfoName(OfficeItemInfoData officeItemInfo)
	{
		if (officeItemInfo == null) return "";
		return officeItemInfo.NameKey ?? "";
	}

	public static string GetOfficeItemInfoDesc(OfficeItemInfoData officeItemInfo)
	{
		if (officeItemInfo == null) return "";
		return officeItemInfo.DescKey ?? "";
	}

	public static string GetOfficeItemInfoIcon(OfficeItemInfoData officeItemInfo)
	{
		if (officeItemInfo == null) return "";
		return officeItemInfo.IconKey ?? "";
	}

	public static int GetCompanyLevelNeedExp(CompanyLevelData companyLevel)
	{
		if (companyLevel == null) return 0;
		return companyLevel.NeedExp;
	}

	public static bool GetDailyQuestEnableRegion(DailyQuestListData dailyQuestListData)
	{
		if (dailyQuestListData == null) return false;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.InGameSystem == null) return false;
		return true;
	}

	public static int GetCompanyGradeStrikeCEOLv(CompanyGradeData companyGradeData, int region = -1)
	{
		if (companyGradeData == null) return 0;
		return companyGradeData.StrikeCeoLv;
	}

	public static BigInteger GetRewardAmount(int rewardType, int rewardID, int region)
	{
		return BigInteger.Zero;
	}

	public static int CalculateRewardRequiredCash(Config.RewardType rewardType, int rewardIdx, int regionType, BigInteger amount)
	{
		return 0;
	}

	public static int GetNextHouseIdx(int currentHouseIdx)
	{
		return currentHouseIdx + 1;
	}

	public static bool CheckHousePurchaseCondition(int houseIdx)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return false;
		return true;
	}

	public static bool ShouldShowConversationForHouse(int houseIdx)
	{
		return false;
	}

	public static bool CanBuyNextHouse(int currentHouseIdx)
	{
		int nextIdx = GetNextHouseIdx(currentHouseIdx);
		return CheckHousePurchaseCondition(nextIdx);
	}

	public static int GetLastCarStoreIdx()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.InGameSystem == null) return 0;
		return 0;
	}

	public static float CalculateValueRatio<T>(T curValue, T maxValue)
	{
		float cur = Convert.ToSingle(curValue);
		float max = Convert.ToSingle(maxValue);
		if (max <= 0f) return 0f;
		return Mathf.Clamp01(cur / max);
	}

	public static Config.ItemType IsItemType(int itemIdx)
	{
		return Config.ItemType.None;
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
