using System.Collections.Generic;
using System.Numerics;
using Treeplla;

public static class InGameLogHelper
{
	public enum E_CeoCostumeGetType
	{
		None = 0,
		InApp = 1,
		Gem = 2,
		OneTime = 3
	}

	private static int GetCurStageIdx()
	{
		var userData = Singleton<GameRoot>.Instance.UserData;
		if (userData == null || userData.mainData == null) return 0;
		var stageData = userData.mainData.StageData;
		return stageData != null ? stageData.StageIdx : 0;
	}

	private static int GetMainStageIdx()
	{
		return GetCurStageIdx();
	}

	private static int GetUserLevel()
	{
		var userData = Singleton<GameRoot>.Instance.UserData;
		if (userData == null || userData.Level == null) return 0;
		return userData.Level.Value;
	}

	public static void SendAnalytics_UserLevelUp(int stageIdx, int mainStageIdx, int userLv, int rich)
	{
	}

	public static void SendAnalytics_SpecialDay_Roulette(int useType, int multiple)
	{
	}

	public static void SendAnalytics_SpecialDay_Roulette_Bonus(int getValue)
	{
	}

	public static void SendAnalytics_SpecialDay_Attendance(bool isReplace, bool isCompleteReward)
	{
	}

	public static void SendAnalytics_SpecialDay_Mission_Clear(int missionIdx)
	{
	}

	public static void SendAnalytics_SpecialDay_Mission_Reroll(int beforeIdx, int afterIdx)
	{
	}

	public static void SendAnalytics_SpecialDay_Shop_Trade(int shopIdx, int buyCount, int useCurrencyValue)
	{
	}

	public static void SendAnalytics_FreeProduct(int goodsIdx)
	{
	}

	public static void SendAnalytics_Sale_Enter(Config.E_ShopSaleListType saleType)
	{
	}

	private static string GetSaleTypeLogString(Config.E_ShopSaleListType saleType)
	{
		return saleType.ToString();
	}

	public static void SendAnalytics_OfflineReward(int offlineTimeSec, bool isReceiveAll)
	{
	}

	private static int IsBuyGameSpeedPackage()
	{
		var userData = Singleton<GameRoot>.Instance.UserData;
		if (userData == null || userData.BuyInappIds == null) return 0;
		// Check if user bought game speed package
		return 0;
	}

	private static int GetBizAcqClearStageIdx()
	{
		// Get BizAcq clear stage index from user data
		return 0;
	}

	public static void SendAnalytics_BizAcqStageClear(int clearStageIdx)
	{
	}

	public static void SendAnalytics_BizAcqStageFail(int stageIdx, int enemyDieCount)
	{
	}

	public static void SendAnalytics_BizAcqClaimIdleReward(int idleTimeSec, bool isReceiveAll)
	{
	}

	public static void SendAnalytics_BizAcqClaimPassReward(int passIdx, bool isPremium, bool isAdsReward, RewardItemData rewardItemData)
	{
	}

	public static void SendAnalytics_BizAcqClaimAllPassReward(int lastPassIdx, List<RewardItemData> rewardItemDataList)
	{
	}

	public static void SendAnalytics_BizAcqDetail(int clearMainStageIdx)
	{
	}

	public static void SendAnalytics_BizAcqJewelryBox(ShopSystem.InAppPurchaseLocation enterPlace, int boxLv, int upgradeLv)
	{
	}

	public static void SendAnalytics_SubMissionClear(int missionIdx, bool isAdsReward)
	{
	}

	private static string GetSubMissionEventName(int missionIdx)
	{
		return "sub_mission_" + missionIdx;
	}

	public static TpMaxProp.AdRewardType GetSubMissionAdType(int missionType)
	{
		return default(TpMaxProp.AdRewardType);
	}

	public static void SendAnalytics_MissionMilestoneClaimReward(int orderIdx)
	{
	}

	public static void SendAnalytics_ReinforceManager(int managerIdx, int reinforceLv)
	{
	}

	public static void SendAnalytics_SkillUpManager(int managerIdx, int skillLv)
	{
	}

	public static void SendAnalytics_ReinforceResetManager(int managerIdx, int prevLv, bool isFreeReset)
	{
	}

	public static void SendAnalytics_GemPassClaim(int order, bool isBuyPass, bool isAdsReward, BigInteger getGemValue)
	{
	}

	public static void SendAnalytics_GemPassClaimAll(int lastOrder, bool isBuyPass, BigInteger getGemValue)
	{
	}

	public static void SendAnalytics_EndlessRewardGet(ShopSystem.InAppPurchaseLocation enterPlace, int offerIdx, int buyCount)
	{
	}

	public static void SendAnalytics_UseExpTicket(int useItemIdx, int useItemCnt, int companyGrade, int beforeLv, int afterLv)
	{
	}

	public static void SendAnalytics_UseBooster(int boosterIdx, int useType, PageOfficeManagement.E_OpenType openType)
	{
	}

	public static void SendAnalytics_CeoCostumeGet(int costumeIdx, E_CeoCostumeGetType costumeGetType)
	{
	}

	public static void SendAnalytics_FactorySlotOpen(int slotIdx, Config.E_FactoryEnterType enterType)
	{
	}

	public static void SendAnalytics_FactoryRefreshOrder(int itemIdx, int count)
	{
	}

	public static void SendAnalytics_FactoryRejectOrder(int productIdx, int count, Config.E_FactoryEnterType enterType)
	{
	}

	public static void SendAnalytics_FactorySkipOrderWait(bool isFree, int remainTimeSec, Config.E_FactoryEnterType enterType)
	{
	}

	public static void SendAnalytics_FactoryCompleteOrder(int productIdx, int count, Config.E_FactoryEnterType enterType)
	{
	}

	public static void SendAnalytics_FactoryItemUse(int factoryIdx, int itemIdx)
	{
	}

	public static void SendAnalytics_FactoryLevelUp(int factoryIdx, int factoryLv)
	{
	}

	public static void SendAnalytics_FactoryMissionComplete(int missionIdx, int missionSlot, int gameTimeElapsedSec, int completeTimeElapsedSec)
	{
	}

	public static void SendAnalytics_FactoryConditionMissionClaim(int missionIdx, int missionSlot, int gameTimeElapsedSec, int claimTimeElapsedSec)
	{
	}

	public static void SendAnalytics_GetAuctionPassBonus(int eventIdx, int gemValue)
	{
	}

	public static void SendAnalytics_FreecashPage(ShopSystem.InAppPurchaseLocation enterPlace)
	{
	}

	public static void SendAnalytics_FreecashLink(ShopSystem.InAppPurchaseLocation enterPlace)
	{
	}

	public static void SendAnalytics_AuctionPassPurchase(int eventIdx, int point)
	{
	}
}
