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
		Slot = slot;
		Idx = idx;
		Value = new ReactiveProperty<BigInteger>(value);
	}

	public void Create()
	{
		if (Value == null) Value = new ReactiveProperty<BigInteger>();
	}

	public virtual object Clone()
	{
		MissionData clone = (MissionData)MemberwiseClone();
		clone.Create();
		return clone;
	}
}
