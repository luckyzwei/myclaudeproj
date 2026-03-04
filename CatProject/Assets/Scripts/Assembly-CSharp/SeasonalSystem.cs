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

	public int Seasonal_Office_BuildCost_Skip_Time { get { return 0; } }

	public int Seasonal_Office_BuildCost_Skip_Cash { get { return 0; } }

	public int Seasonal_statue_buff_slot_count { get { return 0; } }

	public int Seasonal_statue_buff_reward_skill_book { get { return 0; } }

	public bool bNeedForceUpdate { get; private set; }

	public void Init()
	{
	}

	public void OnChangeScene()
	{
	}

	public bool IsPlayingSeasonal()
	{
		return false;
	}

	public void SetNewSeasonInfo()
	{
	}

	private void SetSeasonalScheduleInfo()
	{
	}

	public void OnApplicationPause(bool bPause)
	{
	}

	public void ResetAllSeasonalInfo()
	{
	}

	private void InitSeasonScheduleList()
	{
	}

	private SeasonScheduleInfo FindNowSeasonScheduleInfo()
	{
		return null;
	}

	private SeasonScheduleInfo FindNearlySeasonScheduleInfo()
	{
		return null;
	}

	public SeasonScheduleInfo GetPrevPlayedSeasonScheduleInfo()
	{
		return null;
	}

	private void NotifySeasonChanged()
	{
	}

	public bool CheckPrevSeasonReward()
	{
		return false;
	}

	public bool CheckNeedOpenSeasonDonePopup()
	{
		return false;
	}

	public bool CheckNeedOpenSeasonStartPopup()
	{
		return false;
	}

	public void Update()
	{
	}

	public void UpdateOneSeconds()
	{
	}

	private void UpdateWorkshop(DateTime curDateTime)
	{
	}

	private void UpdateDistributor(DateTime curDateTime)
	{
	}

	private void UpdateScheduleOneSeconds()
	{
	}

	public void ReqEnterSeasonalStage(int seasonalIdx)
	{
	}

	public void ReadySeasonalGame()
	{
	}

	public void OnEnterSeasonalGame()
	{
	}

	public void StartSeasonalGame()
	{
	}

	public void ReqExitSeasonalStage()
	{
	}

	private void ResetInstanceData()
	{
	}

	public bool ReqConstructBuilding(int buildingIdx)
	{
		return false;
	}

	public bool ReqBuildingUpgradeConstruct(int buildingIdx)
	{
		return false;
	}

	private void ReqCompleteBuildingConstruction(SeasonalBuildingData buildingData)
	{
	}

	public bool ReqBuildingFacilityLevelUp(int buildingIdx, int facilityIdx)
	{
		return false;
	}

	public bool ReqWorkshopManagerLevelUp(int workshopIdx)
	{
		return false;
	}

	public void ReqBuildingHiredWorker(int buildingIdx)
	{
	}

	public void ReqBuildingFiredWorker(int buildingIdx)
	{
	}

	public void ReqSelectBuilding(E_BuildingType buildingType, int buildingIdx, Action onSelectedBuilding)
	{
	}

	public void ReqUnselectBuilding(bool bHideUI)
	{
	}

	public void ResetBuildingSelectInfo()
	{
	}

	public void ReqSelectToNextBuilding(E_BuildingType type, int curBuildingIdx)
	{
	}

	public void ReqSelectToPrevBuilding(E_BuildingType type, int curBuildingIdx)
	{
	}

	public void ReqAutoSelectDormitory()
	{
	}

	public bool ReqBuildingUpgradeImmediatelyComplete(int buildingIdx)
	{
		return false;
	}

	public void ReqSetProductSelling(int productIdx, bool isSelling)
	{
	}

	public bool ReqUpgradeProduct(int productIdx)
	{
		return false;
	}

	public void ReqMilestoneRewardClaim(int rewardTableIdx, bool bPremium)
	{
	}

	public void ReqPrevSeasonMilestoneRewardAllClaim()
	{
	}

	public List<(int, bool)> GetReceivableRewardList(int seasonInfoIdx)
	{
		return null;
	}

	public int ReqPlayArcadeRoulette(int multipleValue, out int delayRewardMapIndex, out Dictionary<int, BigInteger> getRewards, Action<Dictionary<int, BigInteger>> statueCb = null)
	{
		delayRewardMapIndex = default(int);
		getRewards = null;
		return 0;
	}

	public bool ReqCheckArcadeMachineFreeChance()
	{
		return false;
	}

	public bool ReqArcadeMachineLevelUp()
	{
		return false;
	}

	public void ReqArcadeMachineMultipleValueChange(int multipleBettingValue)
	{
	}

	public bool ReqSkillLevelUp(int orderIdx)
	{
		return false;
	}

	public Dictionary<int, BigInteger> ReqMissionClaimReward(int slotIndex)
	{
		return null;
	}

	public bool ReqOvertimeWorkActivate()
	{
		return false;
	}

	public bool ReqWorkerEatRestaurantFood(int workerIdx)
	{
		return false;
	}

	public void ReqSetSeasonEndNoticeShown(int seasonInfoIdx)
	{
	}

	public void ReqSetSeasonStartNoticeShown(int seasonInfoIdx)
	{
	}

	public int InsertDelayedCurrencyInventory_PerMile(Dictionary<int, BigInteger> rewardMap)
	{
		return 0;
	}

	public void UpdateDelayedCurrencyInventory(int index)
	{
	}

	private void CheckBuffTime(DateTime curTime)
	{
	}

	private void UpdateCoinRank(DateTime curTime, Action DoneAction = null)
	{
	}

	public void InitCoinRankData(Action DoneAction)
	{
	}

	public void RefreshRankData()
	{
	}

	private Func<float, float> ConvertRankGraphValue(int graphType, int graphPower)
	{
		return null;
	}

	private void DoneCoinRank(Action DoneAction = null)
	{
	}

	public void AllocCoinRankData(int multi, Action OnHide = null)
	{
	}

	private void ResetCoinRankData(Action OnHide)
	{
	}

	private string GetRandomNickName()
	{
		return null;
	}

	public void OnWorkshopGoToRestaurant(int workshopIdx)
	{
	}

	public void OnWorkshopBackToWork(int workshopIdx)
	{
	}

	private void ReqWorkshopProduction(SeasonalWorkshopData workshopData)
	{
	}

	private void ReqSellingProduct(SeasonalDistributorData distributorData, int productIdx)
	{
	}

	private void OnChangeDayActivityState(E_DayActivityStatus dayActivityStatus)
	{
	}

	private void OnChangeTodayTimeHour(int hour)
	{
	}

	private void OnEndAllEmployeeWorkOff()
	{
	}

	private void OnChangeDormitoryMaxWorkerCount(int buildingIdx, int prevMaxWorkerCount, int nowMaxWorkerCount)
	{
	}

	private int PickArcadeRouletteRewardIdx()
	{
		return 0;
	}

	private Dictionary<E_CurrencyType, int> PickRandomSkillBooks(int peekCount)
	{
		return null;
	}

	private void CheckSeasonalEnterTutorial(Action OnClosed)
	{
	}

	private void CheckSeasonalMilestoneTutorial(Action OnClosed)
	{
	}

	private void CheckAndOpenOfflineRewardPopup(Action OnClosed)
	{
	}

	private void CheckSeasonalStatue(Action OnClosed)
	{
	}

	private void CheckSeasonalNewStartPackage(Action OnClosed)
	{
	}

	public void OpenSeasonDonePopup(int seasonInfoIdx, bool nowPlayingSeasonal, Action onClosePopup)
	{
	}

	public void OpenSeasonStartPopup(int seasonInfoIdx, Action onClosePopup)
	{
	}

	private bool CheckHideUIChangedSelectBuilding(E_BuildingType curBuildingType, E_BuildingType nextBuildingType)
	{
		return false;
	}

	private void AddCatstaEventMissionValue(bool isFirstRank, int rankIdx)
	{
	}

	public void AddOneHour()
	{
	}

	public void ForceOpenSeasonal()
	{
	}

	private void PrintProbabilityDebugLog()
	{
	}
}
