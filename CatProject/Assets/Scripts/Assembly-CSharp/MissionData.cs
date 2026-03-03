using System;
using System.Numerics;
using UniRx;

public class MissionData : IReadOnlyData, ICloneable
{
	public int Idx;

	public IReactiveProperty<BigInteger> Value;

	public bool IsShowCompleteNotice;

	public int Slot { get; private set; }

	public MissionData(int slot, int idx, BigInteger value)
	{
	}

	public void Create()
	{
	}

	public virtual object Clone()
	{
		return null;
	}
}
