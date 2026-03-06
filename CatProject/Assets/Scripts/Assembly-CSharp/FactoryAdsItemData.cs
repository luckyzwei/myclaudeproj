using System;

public class FactoryAdsItemData : IReadOnlyData, ICloneable
{
	public int Count;

	public DateTime ResetTime;

	public void Create()
	{
		// TODO
	}

	public virtual object Clone()
	{
		FactoryAdsItemData clone = (FactoryAdsItemData)MemberwiseClone();
		clone.Create();
		return clone;
	}
}
