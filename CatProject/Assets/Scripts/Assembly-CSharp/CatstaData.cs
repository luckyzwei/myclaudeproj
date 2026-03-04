using System;

public class CatstaData : IReadOnlyData, ICloneable
{
	public int Order;

	public int Type;

	public int Idx;

	public bool Like;

	public bool GetReward;

	public void Create()
	{
	}

	public virtual object Clone()
	{
		CatstaData clone = (CatstaData)MemberwiseClone();
		clone.Create();
		return clone;
	}
}
