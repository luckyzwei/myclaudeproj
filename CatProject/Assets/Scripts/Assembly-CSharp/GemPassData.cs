using System;
using System.Collections.Generic;

public class GemPassData : IReadOnlyData, ICloneable
{
	public List<int> NormalReward;

	public List<int> PremiumReward;

	public void Create()
	{
	}

	public virtual object Clone()
	{
		GemPassData clone = (GemPassData)MemberwiseClone();
		clone.Create();
		return clone;
	}
}
