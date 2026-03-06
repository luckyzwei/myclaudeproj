using System;
using System.Numerics;

public class MoneySafeData : IReadOnlyData, ICloneable
{
	public int Count;

	public BigInteger Money;

	public void Create()
	{
		// TODO
	}

	public virtual object Clone()
	{
		MoneySafeData clone = (MoneySafeData)MemberwiseClone();
		clone.Create();
		return clone;
	}
}
