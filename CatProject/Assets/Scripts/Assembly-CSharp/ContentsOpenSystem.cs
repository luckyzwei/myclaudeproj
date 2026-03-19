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

	private Dictionary<int, bool> openedContents;

	private bool isSeasonalOn;

	public void Init()
	{
		disposables = new CompositeDisposable();
		SeasonalDisposables = new CompositeDisposable();
		SubscribeGroups = new List<ContentsOpenGroup>();
		openedContents = new Dictionary<int, bool>();
		SubscribeReview();
		SubscribeInhouse();
	}

	public void InitSeasonalContents()
	{
		isSeasonalOn = true;
		SubscribeSeasonal();
	}

	public void ReleaseSeasonalContents()
	{
		isSeasonalOn = false;
		if (SeasonalDisposables != null)
			SeasonalDisposables.Clear();
	}

	public void Subscribe(List<int> openTypeList, Action action)
	{
		if (openTypeList == null || action == null) return;
		foreach (var typeIdx in openTypeList)
		{
			Subscribe(typeIdx, action);
		}
	}

	public void Subscribe(int opentypeidx, Action action)
	{
		if (action == null) return;

		for (int i = 0; i < SubscribeGroups.Count; i++)
		{
			if ((int)SubscribeGroups[i].Type == opentypeidx)
			{
				int key = action.GetHashCode();
				SubscribeGroups[i].SubscribeFuncs[key] = action;
				return;
			}
		}

		var group = new ContentsOpenGroup
		{
			Type = (OpenConditionType)opentypeidx,
			SubscribeFuncs = new Dictionary<int, Action>()
		};
		group.SubscribeFuncs[action.GetHashCode()] = action;
		SubscribeGroups.Add(group);
	}

	public void Subscribe(Config.ContentsOpenType opentype, Action action)
	{
		Subscribe((int)opentype, action);
	}

	public void UnScribe(int opentypeidx, Action action)
	{
		if (action == null) return;
		for (int i = 0; i < SubscribeGroups.Count; i++)
		{
			if ((int)SubscribeGroups[i].Type == opentypeidx)
			{
				SubscribeGroups[i].SubscribeFuncs.Remove(action.GetHashCode());
				return;
			}
		}
	}

	public void UnScribe(Config.ContentsOpenType opentype, Action action)
	{
		UnScribe((int)opentype, action);
	}

	public bool IsContentsOpen(List<int> openTypeList)
	{
		if (openTypeList == null) return true;
		foreach (var typeIdx in openTypeList)
		{
			if (openedContents != null && openedContents.TryGetValue(typeIdx, out bool opened) && opened)
				continue;
			return false;
		}
		return true;
	}

	public bool isContentsOpen(Config.ContentsOpenType opentype)
	{
		int idx = (int)opentype;
		if (openedContents != null && openedContents.TryGetValue(idx, out bool opened))
			return opened;
		return false;
	}

	// Level thresholds for feature unlocks
	private static readonly Dictionary<int, int> FeatureLevelRequirements = new Dictionary<int, int>
	{
		{ (int)OpenConditionType.OfficeContract, 1 },
		{ (int)OpenConditionType.OfficeItemPurchase, 1 },
		{ (int)OpenConditionType.Level, 2 },
		{ (int)OpenConditionType.OfficeOpen, 3 },
		{ (int)OpenConditionType.OfficeOpenStart, 3 },
		{ (int)OpenConditionType.AllGradeManagerLevel, 3 },
		{ (int)OpenConditionType.Plant, 5 },
		{ (int)OpenConditionType.FactoryOrder, 5 },
		{ (int)OpenConditionType.StageMove, 7 },
		{ (int)OpenConditionType.Building, 10 },
		{ (int)OpenConditionType.BizAcquisitionStageClear, 10 },
		{ (int)OpenConditionType.ManagerLevel, 8 },
		{ (int)OpenConditionType.MaxRegionStageOpen, 15 },
		{ (int)OpenConditionType.SeasonalBuildingOpen, 15 },
	};

	public bool IsContentsOpen(OpenConditionType conditionType, int conditionValue)
	{
		int idx = (int)conditionType;
		if (openedContents != null && openedContents.TryGetValue(idx, out bool opened) && opened)
			return true;

		// Dynamic level check
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return false;
		int playerLevel = root.UserData.Level != null ? root.UserData.Level.Value : 1;
		if (FeatureLevelRequirements.TryGetValue(idx, out int required))
			return playerLevel >= required;
		return false;
	}

	/// Called by UserDataSystem.OnLevelUp to check and notify newly unlocked features
	public void EvaluateLevelUnlocks(int newLevel)
	{
		foreach (var kvp in FeatureLevelRequirements)
		{
			if (newLevel >= kvp.Value)
			{
				int idx = kvp.Key;
				bool wasOpened = openedContents != null && openedContents.TryGetValue(idx, out bool prev) && prev;
				if (!wasOpened)
				{
					if (openedContents != null) openedContents[idx] = true;
					ManualNotifyContentsOpen((OpenConditionType)idx);
				}
			}
		}
	}

	private void SubscribeReview()
	{
		if (disposables == null) return;
		// Level subscriptions handled by UserDataSystem.OnLevelUp calling EvaluateLevelUnlocks
	}

	private void SubscribeInhouse()
	{
		if (disposables == null) return;
	}

	public void ManualNotifyContentsOpen(OpenConditionType conditionType)
	{
		int typeIdx = (int)conditionType;
		if (openedContents != null)
			openedContents[typeIdx] = true;

		for (int i = 0; i < SubscribeGroups.Count; i++)
		{
			if (SubscribeGroups[i].Type == conditionType)
			{
				foreach (var kvp in SubscribeGroups[i].SubscribeFuncs)
				{
					kvp.Value?.Invoke();
				}
				break;
			}
		}
	}

	private void SubscribeSeasonal()
	{
		SubscribeSeasonalManagerExpRequire();
	}

	public void ClearEventAndSubscribe()
	{
		if (SubscribeGroups != null)
			SubscribeGroups.Clear();
		if (openedContents != null)
			openedContents.Clear();
	}

	public void RunSeasonalRankReward(int type_value)
	{
		ManualNotifyContentsOpen(OpenConditionType.SeasonalRankingRewardPopup);
	}

	public void RunSeasonalSkillHighLevel()
	{
		ManualNotifyContentsOpen(OpenConditionType.SeasonalSkillHighLevel);
	}

	public void SubscribeSeasonalManagerExpRequire()
	{
		if (SeasonalDisposables == null) return;
	}
}
