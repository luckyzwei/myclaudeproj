using System;
using System.Numerics;
using SeasonalDef;
using UniRx;

public class SeasonalMissionData
{
	public int MissionIdx;

	public E_MissionType MissionType;

	public int TargetIdx;

	public BigInteger TargetRequireValue;

	public IReactiveProperty<BigInteger> TargetCurValue;

	public E_CurrencyType RewardCurrencyType;

	public int RewardValue;

	public bool bComplete;

	public bool bNeedUpdateTargetRequireValue;

	public IDisposable Disposable_CompleteCondition;

	public bool bReadyToComplete => false;

	~SeasonalMissionData()
	{
	}

	public void DisposeSubscribe()
	{
	}
}
