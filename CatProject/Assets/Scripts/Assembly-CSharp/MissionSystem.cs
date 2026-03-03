using System.Collections.Generic;
using System.Numerics;
using Treeplla;
using UniRx;

public class MissionSystem
{
	public enum E_MissionType
	{
		BUILD_OFFICE = 1,
		CONTRACT_COMPANY = 2,
		REACH_PLAYER_LEVEL = 3,
		UPGRADE_OFFICE_ITEM = 4,
		UPGRADE_ITEM = 5,
		VIEW_ADSUPPLY = 6,
		MOVE_STAGE = 7,
		LEVELUP_COMPANY = 8,
		LEVELUP_GRADE_COMPANY = 9,
		OWN_CAR = 10,
		OWN_PLANT = 11,
		LEVELUP_PLANT = 12,
		OWN_COMPANY = 13,
		CONTRACT_SPEC_COMPANY = 14,
		LEVELUP_SPEC_COMPANY = 15,
		OWN_BUFFOBJECT = 16,
		EVENT_CONSUME_REWARD = 17,
		EVENT_JOIN = 18,
		EVENT_DECO = 19,
		EVENT_PLAY_TAROT = 20,
		EVENT_WIN_AUCTION = 21,
		SEASONAL_JOIN = 22,
		SEASONAL_MILESTONE = 23,
		SEASONAL_CONSUME_REWARD = 24,
		SEASONAL_STATUE = 25,
		SEASONAL_COINRANK = 26,
		SEASONAL_JACKPOT = 27,
		ANNIVERSARY_ATTENDANCE = 28,
		ANY_COMPANY_LEVELUP = 29,
		FACTORY_ORDER_COMPLETE = 30,
		ANY_PLANT_USE_TONIC = 31,
		CURRENCY_GET_REGION = 32,
		CURRENCY_USE_REGION = 33,
		ANY_COMPANY_CONTRACT = 34,
		ANY_COMPANY_EXTEND = 35,
		ANY_CEO_LEVELUP = 36,
		PLAY_TIME = 37,
		ANY_HIRE_CEO = 38,
		PLAYER_LEVELUP = 39,
		COMPANY_INVEST = 40,
		ANY_CAR_BUY = 41,
		ANY_CAR_SELL = 42,
		USE_TAROT = 43,
		PLANT_UPGRADE = 44,
		ANY_VIEW_AD = 45,
		SPIN_ROULETTE = 46,
		UPGRADE_GEM_FACILITY = 47,
		SHOP_GOODS_BUY = 48,
		USE_GEM = 49,
		EVENT_ANY_CATSTAGRAM = 50,
		OWN_MANAGER = 51,
		LEVELUP_MANAGER = 52,
		BIZ_ACQ_STAGE_START = 53,
		BIZ_ACQ_STAGE_CLEAR = 54,
		BIZ_ACQ_STAGE_TRY = 66,
		USE_ANY_BOOSTER = 67,
		BIZ_ACQ_IDLE_REWARD_GET = 68,
		BUY_DAILY_SKILL_STONE = 69,
		FACTORY_FACILITY_CONSTRUCT = 71,
		FACTORY_FACILITY_UPGRADE = 72,
		FACTORY_PRODUCTION_COMPLETE = 73
	}

	public readonly int MISSION_SLOT_CNT;

	private CompositeDisposable[] missionDisposables;

	private Dictionary<E_MissionType, List<CatstaEventData>> CatstaEventDataMap;

	private Dictionary<int, CompositeDisposable> CatstagramEventDisposables;

	public readonly int MilestoneGroupCount;

	private Dictionary<int, MissionMilestoneData> MissionMilestoneDataMap;

	public Subject<Unit> OnMissionClear;

	public Subject<Unit> OnMissionMilestoneRewarded;

	public void Init()
	{
	}

	private void Create()
	{
	}

	public void ClearMission(int slot, int isdouble)
	{
	}

	public void SubscribeMission(int slot)
	{
	}

	public void UpdateMission(E_MissionType type)
	{
	}

	public string GetMissionDesc(int type, params object[] args)
	{
		return null;
	}

	private void InitCatstaEvent()
	{
	}

	private void AddCatstaEventMap(E_MissionType type, CatstaEventData data)
	{
	}

	private void SubscribeCatstaEventMap(E_MissionType type)
	{
	}

	private void UpdateCatstaEventMap(E_MissionType type)
	{
	}

	private void SetEventJoinMission(int specialDayIdx)
	{
	}

	private void InitCatstagramDisposable(int idx)
	{
	}

	private void ClearCatstagramDisposable(int idx)
	{
	}

	public void AddCatstaEventMissionValue(E_MissionType type, BigInteger value, int condition1 = -1, int condition2 = -1, int condition3 = -1)
	{
	}

	private Config.RecordKeys GetRecordKey(E_MissionType type)
	{
		return default(Config.RecordKeys);
	}

	public static int GetMissionRequireValue_AB(MissionInfoData missionInfo)
	{
		return 0;
	}

	private void ClearEventJoinMission(int targetIdx = -1)
	{
	}

	private void ClearSeasonalJoinMission()
	{
	}

	private void ClearEventAnyCatstagramMission(int targetIdx = -1)
	{
	}

	private void ClearSeasonalStatueMission()
	{
	}

	public void ClearSeasonalMileStoneMission(int seasonInfoIdx)
	{
	}

	private void InitMissionMilestoneData()
	{
	}

	public bool ReqClaimAllMilestoneReward(int regionIdx)
	{
		return false;
	}

	public bool ReqClaimMilestoneReward(int orderIdx, bool isMultipleClaim)
	{
		return false;
	}

	public bool IsExistClaimableMilestone(int regionIdx)
	{
		return false;
	}

	public bool IsClaimedMilestone(int orderIdx)
	{
		return false;
	}

	public bool IsAllMilestoneCleared(int regionIdx)
	{
		return false;
	}

	public MissionMilestoneData GetMilestoneData(int regionIdx)
	{
		return null;
	}

	public MissionMilestoneStepData GetRewardableMissionMilestoneStepData(int regionIdx)
	{
		return null;
	}

	public List<MissionMilestoneStepData> GetHudMissionMilestoneGroupData()
	{
		return null;
	}

	public float GetMilestoneStepProgress(int orderIdx)
	{
		return 0f;
	}

	public int GetClearedMissionCount(int regionIdx)
	{
		return 0;
	}

	public int GetMilestoneRegionIdx(int orderIdx)
	{
		return 0;
	}
}
