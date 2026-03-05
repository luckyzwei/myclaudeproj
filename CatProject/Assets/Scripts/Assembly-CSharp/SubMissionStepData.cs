using System;
using System.Numerics;
using UniRx;

public class SubMissionStepData
{
	public int MissionIdx;

	public MissionSystem.E_MissionType MissionType;

	public int TargetIdx;

	public BigInteger TargetRequireValue;

	public IReactiveProperty<BigInteger> TargetCurValue;

	public RewardItemData RewardItemData;

	public bool bComplete;

	public IDisposable Disposable_CompleteCondition;

	public bool bReadyToComplete { get { return bComplete && TargetCurValue != null && TargetCurValue.Value >= TargetRequireValue; } }

	~SubMissionStepData()
	{
	}

	public void DisposeSubscribe()
	{
		if (Disposable_CompleteCondition != null)
		{
			Disposable_CompleteCondition.Dispose();
			Disposable_CompleteCondition = null;
		}
	}
}
