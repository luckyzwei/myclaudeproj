using System;
using System.Collections.Generic;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using SeasonalDef;
using UniRx;
using UnityEngine.Events;

public class SeasonalSystem
{
	public const int SeasonalStartThemeIdx = 10000;

	public const int SeasonalSlotCoinBuffItemIdx = 115;

	public const int SeasonalMissionCoinBuffItemIdx = 116;

	public List<SeasonScheduleInfo> SeasonScheduleList;

	private bool bInitSystem;

	private bool bNeedCheckSeasonalSchedule;

	public UnityAction<int, BigInteger> OnDistributeProduct;

	public Subject<(int productIdx, int productLevel)> OnDistributorUpgrade;

	public Subject<int> OnChangedSeasonEvent;

	private CompositeDisposable GameEventDisposables;

	private CompositeDisposable compositeDisposables;

	private IDisposable Tutorial_Milestone_Disposable;

	private (E_BuildingType BuildingType, int BuildingIdx) SelectedBuildingInfo;

	public Action<int> OnUpdateMyRank;

	private Action ContentPreOpenSubscribeAction;

	private Action ContentOpenSubscribeAction;

	public IReactiveProperty<bool> SlotCoinBuff;

	public IReactiveProperty<bool> MissionCoinBuff;

	public IReactiveProperty<int> SlotCoinBuffRemainTime;

	public IReactiveProperty<int> MissionCoinBuffRemainTime;

	private int seasonal_office_buildcost_skip_time;

	private int seasonal_office_buildcost_skip_cash;

	private DateTime rankUpdateTime;

	private int seasonal_statue_buff_slot_count;

	private int seasonal_statue_buff_reward_skill_book;

	public bool bNeedEnqueueSeasonDonePopup;

	public bool bNeedEnqueueSeasonStartPopup;

	private bool bPausedGame;

	private bool OnApplicationPausedPlayGameFlag;

	private DateTime OnApplicationPauseTime;

	private bool bCheckOfflineRewardMax;

	private readonly string ALPHABET;

	private List<string> countryCodeList;

	public SeasonalMissionSystem MissionSystem { get; private set; }

	public SeasonalDaySystem DaySystem { get; private set; }

	public SeasonalEmployeeSystem EmployeeSystem { get; private set; }

	public SeasonalNotificationSystem NotificationSystem { get; private set; }

	public IReactiveProperty<E_SeasonalContentsOpenState> SeasonalContentsOpenState { get; private set; }

	public IReactiveProperty<int> NowSeasonInfoIdx { get; private set; }

	public IReactiveProperty<bool> IsExistPrevSeasonReward { get; private set; }

	public IReactiveProperty<bool> IsExistNextSeasonInfo { get; private set; }

	public SeasonScheduleInfo NowSeasonScheduleInfo { get; private set; }

	public SeasonScheduleInfo PrevPlayedSeasonScheduleInfo { get; private set; }

	public SeasonScheduleInfo NextSeasonScheduleInfo { get; private set; }

	public IReactiveProperty<bool> bPlaySeasonalGame { get; private set; }

	public int seasonal_step_gem_point { get; private set; }

	public int seasonal_step_mission_point { get; private set; }

	public int seasonal_rank_loading_period { get; private set; }

	public int seasonal_rank_refresh_period { get; private set; }

	public int seasonal_rank_period_buffer { get; private set; }

	public int seasonal_rank_period { get; private set; }

	public int Seasonal_Office_BuildCost_Skip_Time { get { return seasonal_office_buildcost_skip_time; } }

	public int Seasonal_Office_BuildCost_Skip_Cash { get { return seasonal_office_buildcost_skip_cash; } }

	public int Seasonal_statue_buff_slot_count { get { return seasonal_statue_buff_slot_count; } }

	public int Seasonal_statue_buff_reward_skill_book { get { return seasonal_statue_buff_reward_skill_book; } }

	public bool bNeedForceUpdate { get; private set; }

	public void Init()
	{
		if (bInitSystem) return;
		bInitSystem = true;

		OnDistributorUpgrade = new Subject<(int, int)>();
		OnChangedSeasonEvent = new Subject<int>();
		GameEventDisposables = new CompositeDisposable();
		compositeDisposables = new CompositeDisposable();
		SeasonalContentsOpenState = new ReactiveProperty<E_SeasonalContentsOpenState>(E_SeasonalContentsOpenState.None);
		NowSeasonInfoIdx = new ReactiveProperty<int>(0);
		IsExistPrevSeasonReward = new ReactiveProperty<bool>(false);
		IsExistNextSeasonInfo = new ReactiveProperty<bool>(false);
		bPlaySeasonalGame = new ReactiveProperty<bool>(false);
		SlotCoinBuff = new ReactiveProperty<bool>(false);
		MissionCoinBuff = new ReactiveProperty<bool>(false);
		SlotCoinBuffRemainTime = new ReactiveProperty<int>(0);
		MissionCoinBuffRemainTime = new ReactiveProperty<int>(0);
		SeasonScheduleList = new List<SeasonScheduleInfo>();
		countryCodeList = new List<string>();

		seasonal_office_buildcost_skip_time = 300;
		seasonal_office_buildcost_skip_cash = 10;
		seasonal_statue_buff_slot_count = 3;
		seasonal_statue_buff_reward_skill_book = 1;
		seasonal_step_gem_point = 100;
		seasonal_step_mission_point = 50;
		seasonal_rank_loading_period = 60;
		seasonal_rank_refresh_period = 300;
		seasonal_rank_period_buffer = 600;
		seasonal_rank_period = 604800;

		InitSeasonScheduleList();
		SetSeasonalScheduleInfo();
	}

	public void OnChangeScene()
	{
		GameEventDisposables?.Clear();
		compositeDisposables?.Clear();
	}

	public bool IsPlayingSeasonal()
	{
		return bPlaySeasonalGame != null && bPlaySeasonalGame.Value;
	}

	public void SetNewSeasonInfo()
	{
		SetSeasonalScheduleInfo();
		NotifySeasonChanged();
	}

	private void SetSeasonalScheduleInfo()
	{
		NowSeasonScheduleInfo = FindNowSeasonScheduleInfo();
		PrevPlayedSeasonScheduleInfo = GetPrevPlayedSeasonScheduleInfo();
		NextSeasonScheduleInfo = FindNearlySeasonScheduleInfo();

		if (NowSeasonScheduleInfo != null)
		{
			NowSeasonInfoIdx.Value = NowSeasonScheduleInfo.SeasonIdx;
			SeasonalContentsOpenState.Value = E_SeasonalContentsOpenState.Open;
		}
		else
		{
			SeasonalContentsOpenState.Value = E_SeasonalContentsOpenState.None;
		}

		IsExistPrevSeasonReward.Value = CheckPrevSeasonReward();
		IsExistNextSeasonInfo.Value = NextSeasonScheduleInfo != null;
	}

	public void OnApplicationPause(bool bPause)
	{
		if (bPause)
		{
			bPausedGame = true;
			OnApplicationPauseTime = DateTime.UtcNow;
			OnApplicationPausedPlayGameFlag = IsPlayingSeasonal();
		}
		else
		{
			bPausedGame = false;
			if (OnApplicationPausedPlayGameFlag)
			{
				bNeedCheckSeasonalSchedule = true;
			}
		}
	}

	public void ResetAllSeasonalInfo()
	{
		bPlaySeasonalGame.Value = false;
		SelectedBuildingInfo = default;
		ResetInstanceData();
	}

	private void InitSeasonScheduleList()
	{
		if (SeasonScheduleList == null)
			SeasonScheduleList = new List<SeasonScheduleInfo>();
		SeasonScheduleList.Clear();
	}

	private SeasonScheduleInfo FindNowSeasonScheduleInfo()
	{
		if (SeasonScheduleList == null) return null;
		DateTime now = DateTime.UtcNow;
		for (int i = 0; i < SeasonScheduleList.Count; i++)
		{
			var info = SeasonScheduleList[i];
			if (info != null && now >= info.StartTime && now < info.Endtime)
				return info;
		}
		return null;
	}

	private SeasonScheduleInfo FindNearlySeasonScheduleInfo()
	{
		if (SeasonScheduleList == null) return null;
		DateTime now = DateTime.UtcNow;
		SeasonScheduleInfo nearest = null;
		for (int i = 0; i < SeasonScheduleList.Count; i++)
		{
			var info = SeasonScheduleList[i];
			if (info != null && info.StartTime > now)
			{
				if (nearest == null || info.StartTime < nearest.StartTime)
					nearest = info;
			}
		}
		return nearest;
	}

	public SeasonScheduleInfo GetPrevPlayedSeasonScheduleInfo()
	{
		if (SeasonScheduleList == null) return null;
		DateTime now = DateTime.UtcNow;
		SeasonScheduleInfo prev = null;
		for (int i = 0; i < SeasonScheduleList.Count; i++)
		{
			var info = SeasonScheduleList[i];
			if (info != null && info.Endtime <= now)
			{
				if (prev == null || info.Endtime > prev.Endtime)
					prev = info;
			}
		}
		return prev;
	}

	private void NotifySeasonChanged()
	{
		if (NowSeasonScheduleInfo != null)
			OnChangedSeasonEvent?.OnNext(NowSeasonScheduleInfo.SeasonIdx);
	}

	public bool CheckPrevSeasonReward()
	{
		if (PrevPlayedSeasonScheduleInfo == null) return false;
		var list = GetReceivableRewardList(PrevPlayedSeasonScheduleInfo.SeasonIdx);
		return list != null && list.Count > 0;
	}

	public bool CheckNeedOpenSeasonDonePopup()
	{
		return bNeedEnqueueSeasonDonePopup;
	}

	public bool CheckNeedOpenSeasonStartPopup()
	{
		return bNeedEnqueueSeasonStartPopup;
	}

	public void Update()
	{
		if (bNeedCheckSeasonalSchedule)
		{
			bNeedCheckSeasonalSchedule = false;
			SetNewSeasonInfo();
		}
	}

	public void UpdateOneSeconds()
	{
		DateTime curTime = DateTime.UtcNow;
		CheckBuffTime(curTime);
		UpdateScheduleOneSeconds();
		if (IsPlayingSeasonal())
		{
			UpdateWorkshop(curTime);
			UpdateDistributor(curTime);
			UpdateCoinRank(curTime);
		}
	}

	private void UpdateWorkshop(DateTime curDateTime)
	{
		// 워크샵 생산 업데이트
	}

	private void UpdateDistributor(DateTime curDateTime)
	{
		// 유통업체 판매 업데이트
	}

	private void UpdateScheduleOneSeconds()
	{
		// 시즌 스케줄 잔여 시간 갱신
		if (NowSeasonScheduleInfo != null)
		{
			DateTime now = DateTime.UtcNow;
			if (now >= NowSeasonScheduleInfo.Endtime)
			{
				bNeedCheckSeasonalSchedule = true;
				bNeedEnqueueSeasonDonePopup = true;
			}
		}
	}

	public void ReqEnterSeasonalStage(int seasonalIdx)
	{
		if (!IsPlayingSeasonal())
		{
			ReadySeasonalGame();
		}
	}

	public void ReadySeasonalGame()
	{
		bPlaySeasonalGame.Value = true;
	}

	public void OnEnterSeasonalGame()
	{
		StartSeasonalGame();
	}

	public void StartSeasonalGame()
	{
		bPlaySeasonalGame.Value = true;
	}

	public void ReqExitSeasonalStage()
	{
		bPlaySeasonalGame.Value = false;
		ResetInstanceData();
	}

	private void ResetInstanceData()
	{
		SelectedBuildingInfo = default;
	}

	public bool ReqConstructBuilding(int buildingIdx)
	{
		if (!IsPlayingSeasonal()) return false;
		return true;
	}

	public bool ReqBuildingUpgradeConstruct(int buildingIdx)
	{
		if (!IsPlayingSeasonal()) return false;
		return true;
	}

	private void ReqCompleteBuildingConstruction(SeasonalBuildingData buildingData)
	{
		if (buildingData == null) return;
	}

	public bool ReqBuildingFacilityLevelUp(int buildingIdx, int facilityIdx)
	{
		if (!IsPlayingSeasonal()) return false;
		return true;
	}

	public bool ReqWorkshopManagerLevelUp(int workshopIdx)
	{
		if (!IsPlayingSeasonal()) return false;
		return true;
	}

	public void ReqBuildingHiredWorker(int buildingIdx)
	{
		if (!IsPlayingSeasonal()) return;
	}

	public void ReqBuildingFiredWorker(int buildingIdx)
	{
		if (!IsPlayingSeasonal()) return;
	}

	public void ReqSelectBuilding(E_BuildingType buildingType, int buildingIdx, Action onSelectedBuilding)
	{
		SelectedBuildingInfo = (buildingType, buildingIdx);
		onSelectedBuilding?.Invoke();
	}

	public void ReqUnselectBuilding(bool bHideUI)
	{
		SelectedBuildingInfo = default;
	}

	public void ResetBuildingSelectInfo()
	{
		SelectedBuildingInfo = default;
	}

	public void ReqSelectToNextBuilding(E_BuildingType type, int curBuildingIdx)
	{
		int nextIdx = curBuildingIdx + 1;
		ReqSelectBuilding(type, nextIdx, null);
	}

	public void ReqSelectToPrevBuilding(E_BuildingType type, int curBuildingIdx)
	{
		int prevIdx = curBuildingIdx - 1;
		if (prevIdx < 0) prevIdx = 0;
		ReqSelectBuilding(type, prevIdx, null);
	}

	public void ReqAutoSelectDormitory()
	{
		// 빈 기숙사 자동 선택
	}

	public bool ReqBuildingUpgradeImmediatelyComplete(int buildingIdx)
	{
		if (!IsPlayingSeasonal()) return false;
		return true;
	}

	public void ReqSetProductSelling(int productIdx, bool isSelling)
	{
		if (!IsPlayingSeasonal()) return;
	}

	public bool ReqUpgradeProduct(int productIdx)
	{
		if (!IsPlayingSeasonal()) return false;
		return true;
	}

	public void ReqMilestoneRewardClaim(int rewardTableIdx, bool bPremium)
	{
		if (!IsPlayingSeasonal()) return;
	}

	public void ReqPrevSeasonMilestoneRewardAllClaim()
	{
		if (PrevPlayedSeasonScheduleInfo == null) return;
		var list = GetReceivableRewardList(PrevPlayedSeasonScheduleInfo.SeasonIdx);
		if (list == null) return;
		for (int i = 0; i < list.Count; i++)
		{
			ReqMilestoneRewardClaim(list[i].Item1, list[i].Item2);
		}
	}

	public List<(int, bool)> GetReceivableRewardList(int seasonInfoIdx)
	{
		var result = new List<(int, bool)>();
		return result;
	}

	public int ReqPlayArcadeRoulette(int multipleValue, out int delayRewardMapIndex, out Dictionary<int, BigInteger> getRewards, Action<Dictionary<int, BigInteger>> statueCb = null)
	{
		delayRewardMapIndex = -1;
		getRewards = new Dictionary<int, BigInteger>();
		if (!IsPlayingSeasonal()) return -1;
		int rewardIdx = PickArcadeRouletteRewardIdx();
		return rewardIdx;
	}

	public bool ReqCheckArcadeMachineFreeChance()
	{
		if (!IsPlayingSeasonal()) return false;
		return false;
	}

	public bool ReqArcadeMachineLevelUp()
	{
		if (!IsPlayingSeasonal()) return false;
		return true;
	}

	public void ReqArcadeMachineMultipleValueChange(int multipleBettingValue)
	{
		if (!IsPlayingSeasonal()) return;
	}

	public bool ReqSkillLevelUp(int orderIdx)
	{
		if (!IsPlayingSeasonal()) return false;
		return true;
	}

	public Dictionary<int, BigInteger> ReqMissionClaimReward(int slotIndex)
	{
		if (!IsPlayingSeasonal()) return null;
		var rewards = new Dictionary<int, BigInteger>();
		return rewards;
	}

	public bool ReqOvertimeWorkActivate()
	{
		if (!IsPlayingSeasonal()) return false;
		return true;
	}

	public bool ReqWorkerEatRestaurantFood(int workerIdx)
	{
		if (!IsPlayingSeasonal()) return false;
		return true;
	}

	public void ReqSetSeasonEndNoticeShown(int seasonInfoIdx)
	{
		bNeedEnqueueSeasonDonePopup = false;
	}

	public void ReqSetSeasonStartNoticeShown(int seasonInfoIdx)
	{
		bNeedEnqueueSeasonStartPopup = false;
	}

	public int InsertDelayedCurrencyInventory_PerMile(Dictionary<int, BigInteger> rewardMap)
	{
		if (rewardMap == null || rewardMap.Count == 0) return -1;
		return 0;
	}

	public void UpdateDelayedCurrencyInventory(int index)
	{
	}

	private void CheckBuffTime(DateTime curTime)
	{
		if (SlotCoinBuff.Value && SlotCoinBuffRemainTime.Value > 0)
		{
			SlotCoinBuffRemainTime.Value--;
			if (SlotCoinBuffRemainTime.Value <= 0)
				SlotCoinBuff.Value = false;
		}
		if (MissionCoinBuff.Value && MissionCoinBuffRemainTime.Value > 0)
		{
			MissionCoinBuffRemainTime.Value--;
			if (MissionCoinBuffRemainTime.Value <= 0)
				MissionCoinBuff.Value = false;
		}
	}

	private void UpdateCoinRank(DateTime curTime, Action DoneAction = null)
	{
		if ((curTime - rankUpdateTime).TotalSeconds < seasonal_rank_refresh_period) return;
		rankUpdateTime = curTime;
		DoneAction?.Invoke();
	}

	public void InitCoinRankData(Action DoneAction)
	{
		rankUpdateTime = DateTime.UtcNow;
		DoneAction?.Invoke();
	}

	public void RefreshRankData()
	{
		rankUpdateTime = DateTime.MinValue;
	}

	private Func<float, float> ConvertRankGraphValue(int graphType, int graphPower)
	{
		return (float x) => UnityEngine.Mathf.Pow(x, graphPower);
	}

	private void DoneCoinRank(Action DoneAction = null)
	{
		DoneAction?.Invoke();
	}

	public void AllocCoinRankData(int multi, Action OnHide = null)
	{
		OnHide?.Invoke();
	}

	private void ResetCoinRankData(Action OnHide)
	{
		OnHide?.Invoke();
	}

	private string GetRandomNickName()
	{
		if (ALPHABET == null || ALPHABET.Length == 0) return "Player";
		var rand = new System.Random();
		string name = "";
		int length = rand.Next(4, 9);
		for (int i = 0; i < length; i++)
		{
			name += ALPHABET[rand.Next(ALPHABET.Length)];
		}
		return name;
	}

	public void OnWorkshopGoToRestaurant(int workshopIdx)
	{
		if (!IsPlayingSeasonal()) return;
	}

	public void OnWorkshopBackToWork(int workshopIdx)
	{
		if (!IsPlayingSeasonal()) return;
	}

	private void ReqWorkshopProduction(SeasonalWorkshopData workshopData)
	{
		if (workshopData == null) return;
	}

	private void ReqSellingProduct(SeasonalDistributorData distributorData, int productIdx)
	{
		if (distributorData == null) return;
		if (OnDistributeProduct != null)
			OnDistributeProduct.Invoke(productIdx, BigInteger.Zero);
	}

	private void OnChangeDayActivityState(E_DayActivityStatus dayActivityStatus)
	{
		// 낮/밤 상태 변경 시 처리
	}

	private void OnChangeTodayTimeHour(int hour)
	{
		// 시간별 이벤트 처리
	}

	private void OnEndAllEmployeeWorkOff()
	{
		// 전체 직원 퇴근 완료 시 처리
	}

	private void OnChangeDormitoryMaxWorkerCount(int buildingIdx, int prevMaxWorkerCount, int nowMaxWorkerCount)
	{
		// 기숙사 최대 인원 변경 처리
	}

	private int PickArcadeRouletteRewardIdx()
	{
		return UnityEngine.Random.Range(0, 8);
	}

	private Dictionary<E_CurrencyType, int> PickRandomSkillBooks(int peekCount)
	{
		var result = new Dictionary<E_CurrencyType, int>();
		return result;
	}

	private void CheckSeasonalEnterTutorial(Action OnClosed)
	{
		OnClosed?.Invoke();
	}

	private void CheckSeasonalMilestoneTutorial(Action OnClosed)
	{
		OnClosed?.Invoke();
	}

	private void CheckAndOpenOfflineRewardPopup(Action OnClosed)
	{
		OnClosed?.Invoke();
	}

	private void CheckSeasonalStatue(Action OnClosed)
	{
		OnClosed?.Invoke();
	}

	private void CheckSeasonalNewStartPackage(Action OnClosed)
	{
		OnClosed?.Invoke();
	}

	public void OpenSeasonDonePopup(int seasonInfoIdx, bool nowPlayingSeasonal, Action onClosePopup)
	{
		bNeedEnqueueSeasonDonePopup = false;
		onClosePopup?.Invoke();
	}

	public void OpenSeasonStartPopup(int seasonInfoIdx, Action onClosePopup)
	{
		bNeedEnqueueSeasonStartPopup = false;
		onClosePopup?.Invoke();
	}

	private bool CheckHideUIChangedSelectBuilding(E_BuildingType curBuildingType, E_BuildingType nextBuildingType)
	{
		return curBuildingType != nextBuildingType;
	}

	private void AddCatstaEventMissionValue(bool isFirstRank, int rankIdx)
	{
		// 캣스타 이벤트 미션 값 추가
	}

	public void AddOneHour()
	{
		// 치트: 1시간 추가
		if (DaySystem != null)
		{
			// DaySystem time forward
		}
	}

	public void ForceOpenSeasonal()
	{
		SeasonalContentsOpenState.Value = E_SeasonalContentsOpenState.Open;
		bNeedForceUpdate = true;
	}

	private void PrintProbabilityDebugLog()
	{
#if UNITY_EDITOR
		UnityEngine.Debug.Log("[SeasonalSystem] Probability Debug");
#endif
	}
}
