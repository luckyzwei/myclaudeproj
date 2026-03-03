using System;
using System.Collections.Generic;
using UniRx;

public class ContentsOpenSystem
{
	public enum OpenConditionType
	{
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

	public enum OpenConditionSeasonalExceptionType
	{
		FirstSlotCoinBuff = 101,
		NeedSkillBook = 102,
		NeedManagerExp = 103,
		SecondRankingStart = 104
	}

	private struct ContentsOpenGroup
	{
		public OpenConditionType Type;

		public Dictionary<int, Action> SubscribeFuncs;
	}

	private CompositeDisposable disposables;

	private CompositeDisposable SeasonalDisposables;

	private List<ContentsOpenGroup> SubscribeGroups;

	private bool isSeasonalOn;

	public void Init()
	{
	}

	public void InitSeasonalContents()
	{
	}

	public void ReleaseSeasonalContents()
	{
	}

	public void Subscribe(List<int> openTypeList, Action action)
	{
	}

	public void Subscribe(int opentypeidx, Action action)
	{
	}

	public void Subscribe(Config.ContentsOpenType opentype, Action action)
	{
	}

	public void UnScribe(int opentypeidx, Action action)
	{
	}

	public void UnScribe(Config.ContentsOpenType opentype, Action action)
	{
	}

	public bool IsContentsOpen(List<int> openTypeList)
	{
		return false;
	}

	public bool isContentsOpen(Config.ContentsOpenType opentype)
	{
		return false;
	}

	public bool IsContentsOpen(OpenConditionType conditionType, int conditionValue)
	{
		return false;
	}

	private void SubscribeReview()
	{
	}

	private void SubscribeInhouse()
	{
	}

	public void ManualNotifyContentsOpen(OpenConditionType conditionType)
	{
	}

	private void SubscribeSeasonal()
	{
	}

	public void ClearEventAndSubscribe()
	{
	}

	public void RunSeasonalRankReward(int type_value)
	{
	}

	public void RunSeasonalSkillHighLevel()
	{
	}

	public void SubscribeSeasonalManagerExpRequire()
	{
	}
}
