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
		OnMissionClear = new Subject<Unit>();
		OnMissionMilestoneRewarded = new Subject<Unit>();
		CatstaEventDataMap = new Dictionary<E_MissionType, List<CatstaEventData>>();
		CatstagramEventDisposables = new Dictionary<int, CompositeDisposable>();
		MissionMilestoneDataMap = new Dictionary<int, MissionMilestoneData>();
		missionDisposables = new CompositeDisposable[MISSION_SLOT_CNT];
		for (int i = 0; i < MISSION_SLOT_CNT; i++)
		{
			missionDisposables[i] = new CompositeDisposable();
		}
		Create();
		InitCatstaEvent();
		InitMissionMilestoneData();
	}

	private void Create()
	{
		// 각 미션 슬롯의 미션 데이터를 로드하고 구독 설정
		var userData = Singleton<GameRoot>.Instance.UserData;
		if (userData == null || userData.mainData == null) return;
		var stageData = userData.mainData.StageData;
		if (stageData == null || stageData.Missions == null) return;
		for (int i = 0; i < stageData.Missions.Length && i < MISSION_SLOT_CNT; i++)
		{
			SubscribeMission(i);
		}
	}

	public void ClearMission(int slot, int isdouble)
	{
		// 미션 클리어 처리: 보상 지급, 다음 미션 할당
		var userData = Singleton<GameRoot>.Instance.UserData;
		if (userData == null || userData.mainData == null) return;
		var stageData = userData.mainData.StageData;
		if (stageData == null || stageData.Missions == null) return;
		if (slot < 0 || slot >= stageData.Missions.Length) return;
		// 보상을 지급하고 다음 미션을 할당
		OnMissionClear.OnNext(Unit.Default);
		SubscribeMission(slot);
	}

	public void SubscribeMission(int slot)
	{
		if (missionDisposables == null || slot < 0 || slot >= missionDisposables.Length) return;
		missionDisposables[slot]?.Clear();
		missionDisposables[slot] = new CompositeDisposable();
		// 미션 조건 구독 설정
	}

	public void UpdateMission(E_MissionType type)
	{
		// 특정 미션 타입의 진행 업데이트
		var userData = Singleton<GameRoot>.Instance.UserData;
		if (userData == null || userData.mainData == null) return;
		var stageData = userData.mainData.StageData;
		if (stageData == null || stageData.Missions == null) return;
		// 해당 타입의 미션이 있으면 값 업데이트
	}

	public string GetMissionDesc(int type, params object[] args)
	{
		// 미션 설명 문자열 생성
		return string.Empty;
	}

	private void InitCatstaEvent()
	{
		if (CatstaEventDataMap == null)
			CatstaEventDataMap = new Dictionary<E_MissionType, List<CatstaEventData>>();
		CatstaEventDataMap.Clear();
	}

	private void AddCatstaEventMap(E_MissionType type, CatstaEventData data)
	{
		if (data == null) return;
		if (!CatstaEventDataMap.TryGetValue(type, out var list))
		{
			list = new List<CatstaEventData>();
			CatstaEventDataMap[type] = list;
		}
		list.Add(data);
	}

	private void SubscribeCatstaEventMap(E_MissionType type)
	{
		// 캣스타 이벤트 구독
	}

	private void UpdateCatstaEventMap(E_MissionType type)
	{
		if (!CatstaEventDataMap.TryGetValue(type, out var list)) return;
		if (list == null) return;
		// 캣스타 이벤트 진행도 업데이트
	}

	private void SetEventJoinMission(int specialDayIdx)
	{
		// 이벤트 참여 미션 설정
	}

	private void InitCatstagramDisposable(int idx)
	{
		if (CatstagramEventDisposables == null)
			CatstagramEventDisposables = new Dictionary<int, CompositeDisposable>();
		if (!CatstagramEventDisposables.ContainsKey(idx))
			CatstagramEventDisposables[idx] = new CompositeDisposable();
	}

	private void ClearCatstagramDisposable(int idx)
	{
		if (CatstagramEventDisposables == null) return;
		if (CatstagramEventDisposables.TryGetValue(idx, out var disposable))
		{
			disposable?.Clear();
			CatstagramEventDisposables.Remove(idx);
		}
	}

	public void AddCatstaEventMissionValue(E_MissionType type, BigInteger value, int condition1 = -1, int condition2 = -1, int condition3 = -1)
	{
		if (!CatstaEventDataMap.TryGetValue(type, out var list)) return;
		if (list == null) return;
		for (int i = 0; i < list.Count; i++)
		{
			var eventData = list[i];
			if (eventData == null) continue;
			// 조건 확인 후 이벤트 미션 값 추가
		}
	}

	private Config.RecordKeys GetRecordKey(E_MissionType type)
	{
		return (Config.RecordKeys)((int)type + 10000);
	}

	public static int GetMissionRequireValue_AB(MissionInfoData missionInfo)
	{
		if (missionInfo == null) return 0;
		// AB 테스트에 따른 미션 요구 값 반환
		return 0;
	}

	private void ClearEventJoinMission(int targetIdx = -1)
	{
		// 이벤트 참여 미션 클리어
	}

	private void ClearSeasonalJoinMission()
	{
		// 시즌 참여 미션 클리어
	}

	private void ClearEventAnyCatstagramMission(int targetIdx = -1)
	{
		// 캣스타그램 이벤트 미션 클리어
	}

	private void ClearSeasonalStatueMission()
	{
		// 시즌 조각상 미션 클리어
	}

	public void ClearSeasonalMileStoneMission(int seasonInfoIdx)
	{
		// 시즌 마일스톤 미션 클리어
	}

	private void InitMissionMilestoneData()
	{
		if (MissionMilestoneDataMap == null)
			MissionMilestoneDataMap = new Dictionary<int, MissionMilestoneData>();
		MissionMilestoneDataMap.Clear();
		// 마일스톤 테이블 데이터 로드
	}

	public bool ReqClaimAllMilestoneReward(int regionIdx)
	{
		// 리전의 모든 클레임 가능한 마일스톤 보상 수령
		var milestoneData = GetMilestoneData(regionIdx);
		if (milestoneData == null || milestoneData.StepDataList == null) return false;
		bool claimed = false;
		for (int i = 0; i < milestoneData.StepDataList.Count; i++)
		{
			if (ReqClaimMilestoneReward(milestoneData.StepDataList[i].Order, true))
				claimed = true;
		}
		if (claimed)
			OnMissionMilestoneRewarded.OnNext(Unit.Default);
		return claimed;
	}

	public bool ReqClaimMilestoneReward(int orderIdx, bool isMultipleClaim)
	{
		// 특정 마일스톤 보상 수령
		int regionIdx = GetMilestoneRegionIdx(orderIdx);
		var milestoneData = GetMilestoneData(regionIdx);
		if (milestoneData == null) return false;
		int clearedCount = milestoneData.ClearedMissionCount;
		// 마일스톤 단계의 필요 미션수 충족 여부 확인
		if (!isMultipleClaim)
			OnMissionMilestoneRewarded.OnNext(Unit.Default);
		return true;
	}

	public bool IsExistClaimableMilestone(int regionIdx)
	{
		var milestoneData = GetMilestoneData(regionIdx);
		if (milestoneData == null || milestoneData.StepDataList == null) return false;
		int clearedCount = milestoneData.ClearedMissionCount;
		for (int i = 0; i < milestoneData.StepDataList.Count; i++)
		{
			var step = milestoneData.StepDataList[i];
			if (step != null && clearedCount >= step.TotalNeedCount)
			{
				if (!IsClaimedMilestone(step.Order))
					return true;
			}
		}
		return false;
	}

	public bool IsClaimedMilestone(int orderIdx)
	{
		// 마일스톤 보상 수령 여부 (레코드로 관리)
		var userData = Singleton<GameRoot>.Instance.UserData;
		if (userData == null || userData.RecordCount == null) return false;
		string key = "milestone_claimed_" + orderIdx;
		return userData.RecordCount.ContainsKey(key);
	}

	public bool IsAllMilestoneCleared(int regionIdx)
	{
		var milestoneData = GetMilestoneData(regionIdx);
		if (milestoneData == null || milestoneData.StepDataList == null) return false;
		for (int i = 0; i < milestoneData.StepDataList.Count; i++)
		{
			if (!IsClaimedMilestone(milestoneData.StepDataList[i].Order))
				return false;
		}
		return true;
	}

	public MissionMilestoneData GetMilestoneData(int regionIdx)
	{
		if (MissionMilestoneDataMap == null) return null;
		MissionMilestoneDataMap.TryGetValue(regionIdx, out var data);
		return data;
	}

	public MissionMilestoneStepData GetRewardableMissionMilestoneStepData(int regionIdx)
	{
		var milestoneData = GetMilestoneData(regionIdx);
		if (milestoneData == null || milestoneData.StepDataList == null) return null;
		int clearedCount = milestoneData.ClearedMissionCount;
		for (int i = 0; i < milestoneData.StepDataList.Count; i++)
		{
			var step = milestoneData.StepDataList[i];
			if (step != null && clearedCount >= step.TotalNeedCount && !IsClaimedMilestone(step.Order))
				return step;
		}
		return null;
	}

	public List<MissionMilestoneStepData> GetHudMissionMilestoneGroupData()
	{
		// HUD에 표시할 마일스톤 그룹 데이터
		var result = new List<MissionMilestoneStepData>();
		if (MissionMilestoneDataMap == null) return result;
		foreach (var kvp in MissionMilestoneDataMap)
		{
			var rewardable = GetRewardableMissionMilestoneStepData(kvp.Key);
			if (rewardable != null)
				result.Add(rewardable);
		}
		return result;
	}

	public float GetMilestoneStepProgress(int orderIdx)
	{
		int regionIdx = GetMilestoneRegionIdx(orderIdx);
		var milestoneData = GetMilestoneData(regionIdx);
		if (milestoneData == null || milestoneData.StepDataList == null) return 0f;
		for (int i = 0; i < milestoneData.StepDataList.Count; i++)
		{
			var step = milestoneData.StepDataList[i];
			if (step != null && step.Order == orderIdx)
			{
				if (step.TotalNeedCount <= 0) return 1f;
				return (float)milestoneData.ClearedMissionCount / step.TotalNeedCount;
			}
		}
		return 0f;
	}

	public int GetClearedMissionCount(int regionIdx)
	{
		var milestoneData = GetMilestoneData(regionIdx);
		if (milestoneData == null) return 0;
		return milestoneData.ClearedMissionCount;
	}

	public int GetMilestoneRegionIdx(int orderIdx)
	{
		if (MissionMilestoneDataMap == null) return 0;
		foreach (var kvp in MissionMilestoneDataMap)
		{
			var data = kvp.Value;
			if (data == null || data.StepDataList == null) continue;
			for (int i = 0; i < data.StepDataList.Count; i++)
			{
				if (data.StepDataList[i] != null && data.StepDataList[i].Order == orderIdx)
					return kvp.Key;
			}
		}
		return 0;
	}
}
