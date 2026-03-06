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

	private static TpAnalyticsProp GetAnalytics()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.PluginSystem == null) return null;
		return root.PluginSystem.AnalyticsProp;
	}

	public static void SendAnalytics_UserLevelUp(int stageIdx, int mainStageIdx, int userLv, int rich)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "user_level_up", stageIdx, mainStageIdx, userLv, rich);
	}

	public static void SendAnalytics_SpecialDay_Roulette(int useType, int multiple)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "specialday_roulette", GetCurStageIdx(), GetUserLevel(), useType, multiple);
	}

	public static void SendAnalytics_SpecialDay_Roulette_Bonus(int getValue)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "specialday_roulette_bonus", GetCurStageIdx(), GetUserLevel(), getValue);
	}

	public static void SendAnalytics_SpecialDay_Attendance(bool isReplace, bool isCompleteReward)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "specialday_attendance", GetCurStageIdx(), GetUserLevel(), isReplace ? 1 : 0, isCompleteReward ? 1 : 0);
	}

	public static void SendAnalytics_SpecialDay_Mission_Clear(int missionIdx)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "specialday_mission_clear", GetCurStageIdx(), GetUserLevel(), missionIdx);
	}

	public static void SendAnalytics_SpecialDay_Mission_Reroll(int beforeIdx, int afterIdx)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "specialday_mission_reroll", GetCurStageIdx(), GetUserLevel(), beforeIdx, afterIdx);
	}

	public static void SendAnalytics_SpecialDay_Shop_Trade(int shopIdx, int buyCount, int useCurrencyValue)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "specialday_shop_trade", GetCurStageIdx(), GetUserLevel(), shopIdx, buyCount, useCurrencyValue);
	}

	public static void SendAnalytics_FreeProduct(int goodsIdx)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "free_product", GetCurStageIdx(), GetUserLevel(), goodsIdx);
	}

	public static void SendAnalytics_Sale_Enter(Config.E_ShopSaleListType saleType)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "sale_enter", GetCurStageIdx(), GetUserLevel(), GetSaleTypeLogString(saleType));
	}

	private static string GetSaleTypeLogString(Config.E_ShopSaleListType saleType)
	{
		return saleType.ToString();
	}

	public static void SendAnalytics_OfflineReward(int offlineTimeSec, bool isReceiveAll)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "offline_reward", GetCurStageIdx(), GetUserLevel(), offlineTimeSec, isReceiveAll ? 1 : 0);
	}

	private static int IsBuyGameSpeedPackage()
	{
		var userData = Singleton<GameRoot>.Instance.UserData;
		if (userData == null || userData.BuyInappIds == null) return 0;
		return 0;
	}

	private static int GetBizAcqClearStageIdx()
	{
		return 0;
	}

	public static void SendAnalytics_BizAcqStageClear(int clearStageIdx)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "bizacq_stage_clear", GetCurStageIdx(), GetUserLevel(), clearStageIdx);
	}

	public static void SendAnalytics_BizAcqStageFail(int stageIdx, int enemyDieCount)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "bizacq_stage_fail", GetCurStageIdx(), GetUserLevel(), stageIdx, enemyDieCount);
	}

	public static void SendAnalytics_BizAcqClaimIdleReward(int idleTimeSec, bool isReceiveAll)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "bizacq_claim_idle_reward", GetCurStageIdx(), GetUserLevel(), idleTimeSec, isReceiveAll ? 1 : 0);
	}

	public static void SendAnalytics_BizAcqClaimPassReward(int passIdx, bool isPremium, bool isAdsReward, RewardItemData rewardItemData)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "bizacq_claim_pass_reward", GetCurStageIdx(), GetUserLevel(), passIdx, isPremium ? 1 : 0, isAdsReward ? 1 : 0);
	}

	public static void SendAnalytics_BizAcqClaimAllPassReward(int lastPassIdx, List<RewardItemData> rewardItemDataList)
	{
		int rewardCount = rewardItemDataList != null ? rewardItemDataList.Count : 0;
		GetAnalytics()?.AllEvent(IngameEventType.None, "bizacq_claim_all_pass_reward", GetCurStageIdx(), GetUserLevel(), lastPassIdx, rewardCount);
	}

	public static void SendAnalytics_BizAcqDetail(int clearMainStageIdx)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "bizacq_detail", GetCurStageIdx(), GetUserLevel(), clearMainStageIdx);
	}

	public static void SendAnalytics_BizAcqJewelryBox(ShopSystem.InAppPurchaseLocation enterPlace, int boxLv, int upgradeLv)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "bizacq_jewelry_box", GetCurStageIdx(), GetUserLevel(), (int)enterPlace, boxLv, upgradeLv);
	}

	public static void SendAnalytics_SubMissionClear(int missionIdx, bool isAdsReward)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, GetSubMissionEventName(missionIdx), GetCurStageIdx(), GetUserLevel(), missionIdx, isAdsReward ? 1 : 0);
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
		GetAnalytics()?.AllEvent(IngameEventType.None, "mission_milestone_claim", GetCurStageIdx(), GetUserLevel(), orderIdx);
	}

	public static void SendAnalytics_ReinforceManager(int managerIdx, int reinforceLv)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "reinforce_manager", GetCurStageIdx(), GetUserLevel(), managerIdx, reinforceLv);
	}

	public static void SendAnalytics_SkillUpManager(int managerIdx, int skillLv)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "skill_up_manager", GetCurStageIdx(), GetUserLevel(), managerIdx, skillLv);
	}

	public static void SendAnalytics_ReinforceResetManager(int managerIdx, int prevLv, bool isFreeReset)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "reinforce_reset_manager", GetCurStageIdx(), GetUserLevel(), managerIdx, prevLv, isFreeReset ? 1 : 0);
	}

	public static void SendAnalytics_GemPassClaim(int order, bool isBuyPass, bool isAdsReward, BigInteger getGemValue)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "gem_pass_claim", GetCurStageIdx(), GetUserLevel(), order, isBuyPass ? 1 : 0, isAdsReward ? 1 : 0, getGemValue.ToString());
	}

	public static void SendAnalytics_GemPassClaimAll(int lastOrder, bool isBuyPass, BigInteger getGemValue)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "gem_pass_claim_all", GetCurStageIdx(), GetUserLevel(), lastOrder, isBuyPass ? 1 : 0, getGemValue.ToString());
	}

	public static void SendAnalytics_EndlessRewardGet(ShopSystem.InAppPurchaseLocation enterPlace, int offerIdx, int buyCount)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "endless_reward_get", GetCurStageIdx(), GetUserLevel(), (int)enterPlace, offerIdx, buyCount);
	}

	public static void SendAnalytics_UseExpTicket(int useItemIdx, int useItemCnt, int companyGrade, int beforeLv, int afterLv)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "use_exp_ticket", GetCurStageIdx(), GetUserLevel(), useItemIdx, useItemCnt, companyGrade, beforeLv, afterLv);
	}

	public static void SendAnalytics_UseBooster(int boosterIdx, int useType, PageOfficeManagement.E_OpenType openType)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "use_booster", GetCurStageIdx(), GetUserLevel(), boosterIdx, useType, (int)openType);
	}

	public static void SendAnalytics_CeoCostumeGet(int costumeIdx, E_CeoCostumeGetType costumeGetType)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "ceo_costume_get", GetCurStageIdx(), GetUserLevel(), costumeIdx, (int)costumeGetType);
	}

	public static void SendAnalytics_FactorySlotOpen(int slotIdx, Config.E_FactoryEnterType enterType)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "factory_slot_open", GetCurStageIdx(), GetUserLevel(), slotIdx, (int)enterType);
	}

	public static void SendAnalytics_FactoryRefreshOrder(int itemIdx, int count)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "factory_refresh_order", GetCurStageIdx(), GetUserLevel(), itemIdx, count);
	}

	public static void SendAnalytics_FactoryRejectOrder(int productIdx, int count, Config.E_FactoryEnterType enterType)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "factory_reject_order", GetCurStageIdx(), GetUserLevel(), productIdx, count, (int)enterType);
	}

	public static void SendAnalytics_FactorySkipOrderWait(bool isFree, int remainTimeSec, Config.E_FactoryEnterType enterType)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "factory_skip_order_wait", GetCurStageIdx(), GetUserLevel(), isFree ? 1 : 0, remainTimeSec, (int)enterType);
	}

	public static void SendAnalytics_FactoryCompleteOrder(int productIdx, int count, Config.E_FactoryEnterType enterType)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "factory_complete_order", GetCurStageIdx(), GetUserLevel(), productIdx, count, (int)enterType);
	}

	public static void SendAnalytics_FactoryItemUse(int factoryIdx, int itemIdx)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "factory_item_use", GetCurStageIdx(), GetUserLevel(), factoryIdx, itemIdx);
	}

	public static void SendAnalytics_FactoryLevelUp(int factoryIdx, int factoryLv)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "factory_level_up", GetCurStageIdx(), GetUserLevel(), factoryIdx, factoryLv);
	}

	public static void SendAnalytics_FactoryMissionComplete(int missionIdx, int missionSlot, int gameTimeElapsedSec, int completeTimeElapsedSec)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "factory_mission_complete", GetCurStageIdx(), GetUserLevel(), missionIdx, missionSlot, gameTimeElapsedSec, completeTimeElapsedSec);
	}

	public static void SendAnalytics_FactoryConditionMissionClaim(int missionIdx, int missionSlot, int gameTimeElapsedSec, int claimTimeElapsedSec)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "factory_condition_mission_claim", GetCurStageIdx(), GetUserLevel(), missionIdx, missionSlot, gameTimeElapsedSec, claimTimeElapsedSec);
	}

	public static void SendAnalytics_GetAuctionPassBonus(int eventIdx, int gemValue)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "auction_pass_bonus", GetCurStageIdx(), GetUserLevel(), eventIdx, gemValue);
	}

	public static void SendAnalytics_FreecashPage(ShopSystem.InAppPurchaseLocation enterPlace)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "freecash_page", GetCurStageIdx(), GetUserLevel(), (int)enterPlace);
	}

	public static void SendAnalytics_FreecashLink(ShopSystem.InAppPurchaseLocation enterPlace)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "freecash_link", GetCurStageIdx(), GetUserLevel(), (int)enterPlace);
	}

	public static void SendAnalytics_AuctionPassPurchase(int eventIdx, int point)
	{
		GetAnalytics()?.AllEvent(IngameEventType.None, "auction_pass_purchase", GetCurStageIdx(), GetUserLevel(), eventIdx, point);
	}
}
