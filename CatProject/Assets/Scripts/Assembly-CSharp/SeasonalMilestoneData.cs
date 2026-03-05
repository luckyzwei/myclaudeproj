using System.Collections.Generic;
using System.Numerics;
using Treeplla.Data;
using UniRx;

public class SeasonalMilestoneData
{
	public int MaxRewardListIndex;

	public float MilestoneStepElapsedTimeSec;

	public int SeasonRewardGroup { get; private set; }

	public int MilestoneCurrencyIdx { get; private set; }

	public BigInteger CurrencyAccumulationValue_PerMile { get; private set; }

	public BigInteger GoalAccumulationValue_PerMile { get; private set; }

	public IReactiveProperty<bool> bSatisfyAllSteps { get; private set; }

	public IReactiveProperty<int> CurRewardListIndex { get; private set; }

	public List<int> RewardTableIdxList { get; private set; }

	public IReactiveCollection<int> ReceivedRewardIdxList { get; private set; }

	public IReactiveCollection<int> ReceivedPremiumRewardIdxList { get; private set; }

	public void Init(int seasonRewardGroup, int currencyIdx, BigInteger accumulationValue_PerMile)
	{
		SeasonRewardGroup = seasonRewardGroup;
		MilestoneCurrencyIdx = currencyIdx;
		CurrencyAccumulationValue_PerMile = accumulationValue_PerMile;
		GoalAccumulationValue_PerMile = BigInteger.Zero;
		bSatisfyAllSteps = new ReactiveProperty<bool>(false);
		CurRewardListIndex = new ReactiveProperty<int>(0);
		RewardTableIdxList = new List<int>();
		ReceivedRewardIdxList = new ReactiveCollection<int>();
		ReceivedPremiumRewardIdxList = new ReactiveCollection<int>();
		MaxRewardListIndex = 0;
		MilestoneStepElapsedTimeSec = 0f;
		InitRewardStep(seasonRewardGroup);
	}

	public void UpdateData(Treeplla.Data.SeasonalMilestoneData milestoneData)
	{
		// milestoneData is a FlatBuffer struct
		// Update from FlatBuffer data
		bool bMax;
		int nextIdx = CalcNextRewardListIndex(out bMax);
		CurRewardListIndex.Value = nextIdx;
		bSatisfyAllSteps.Value = bMax;
		if (!bMax && nextIdx < RewardTableIdxList.Count)
			UpdateGoalAccumulationValue(RewardTableIdxList[nextIdx]);
	}

	public void AddMilestoneCurrency(int currencyIdx, BigInteger value_PerMile, bool bInitState)
	{
		if (currencyIdx != MilestoneCurrencyIdx) return;
		CurrencyAccumulationValue_PerMile += value_PerMile;
		if (!bInitState)
		{
			bool bMax;
			int nextIdx = CalcNextRewardListIndex(out bMax);
			CurRewardListIndex.Value = nextIdx;
			bSatisfyAllSteps.Value = bMax;
		}
	}

	public bool AddReceivedRewardIdx(int rewardIdx, bool bPremium)
	{
		if (bPremium)
		{
			if (ReceivedPremiumRewardIdxList.Contains(rewardIdx)) return false;
			ReceivedPremiumRewardIdxList.Add(rewardIdx);
		}
		else
		{
			if (ReceivedRewardIdxList.Contains(rewardIdx)) return false;
			ReceivedRewardIdxList.Add(rewardIdx);
		}
		return true;
	}

	public int GetPrevRewardTableIndex()
	{
		int cur = CurRewardListIndex.Value;
		if (cur <= 0) return 0;
		return cur - 1;
	}

	public int GetCurRewardTableIndex()
	{
		int cur = CurRewardListIndex.Value;
		if (RewardTableIdxList == null || cur >= RewardTableIdxList.Count) return 0;
		return RewardTableIdxList[cur];
	}

	public (int, int) GetMilestoneProgressInfo()
	{
		int cur = CurRewardListIndex.Value;
		int max = MaxRewardListIndex;
		return (cur, max);
	}

	private void InitRewardStep(int seasonRewardGroup)
	{
		// Load reward step data from config tables
		if (RewardTableIdxList == null)
			RewardTableIdxList = new List<int>();
		MaxRewardListIndex = RewardTableIdxList.Count;
	}

	private int CalcNextRewardListIndex(out bool bMaxLevel)
	{
		bMaxLevel = false;
		if (RewardTableIdxList == null || RewardTableIdxList.Count == 0)
		{
			bMaxLevel = true;
			return 0;
		}
		for (int i = 0; i < RewardTableIdxList.Count; i++)
		{
			if (CurrencyAccumulationValue_PerMile < GoalAccumulationValue_PerMile)
				return i;
			if (i + 1 < RewardTableIdxList.Count)
				UpdateGoalAccumulationValue(RewardTableIdxList[i + 1]);
		}
		bMaxLevel = true;
		return RewardTableIdxList.Count;
	}

	private void UpdateGoalAccumulationValue(int rewardTableIdx)
	{
		// Set GoalAccumulationValue_PerMile from reward table config
	}
}
