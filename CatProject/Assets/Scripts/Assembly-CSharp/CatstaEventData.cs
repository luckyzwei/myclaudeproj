using System;

public class CatstaEventData : IReadOnlyData, ICloneable
{
	public int Idx;

	public int Value;

	public bool Like;

	public bool GetReward;

	public void Create()
	{
	}

	public virtual object Clone()
	{
		CatstaEventData clone = (CatstaEventData)MemberwiseClone();
		clone.Create();
		return clone;
	}
}
