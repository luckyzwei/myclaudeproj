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
	}

	public void UpdateData(Treeplla.Data.SeasonalMilestoneData milestoneData)
	{
	}

	public void AddMilestoneCurrency(int currencyIdx, BigInteger value_PerMile, bool bInitState)
	{
	}

	public bool AddReceivedRewardIdx(int rewardIdx, bool bPremium)
	{
		return false;
	}

	public int GetPrevRewardTableIndex()
	{
		return 0;
	}

	public int GetCurRewardTableIndex()
	{
		return 0;
	}

	public (int, int) GetMilestoneProgressInfo()
	{
		return default((int, int));
	}

	private void InitRewardStep(int seasonRewardGroup)
	{
	}

	private int CalcNextRewardListIndex(out bool bMaxLevel)
	{
		bMaxLevel = default(bool);
		return 0;
	}

	private void UpdateGoalAccumulationValue(int rewardTableIdx)
	{
	}
}
