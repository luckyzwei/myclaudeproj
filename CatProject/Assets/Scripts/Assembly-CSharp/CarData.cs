using System;

public class CarData : IReadOnlyData, ICloneable
{
	public int Idx;

	public int ParkingZone;

	public int ParkingSpace;

	public int GetRegion()
	{
		return 0;
	}

	public int GetBrandIdx()
	{
		return 0;
	}

	public bool IsSpecial()
	{
		return false;
	}

	public void Create()
	{
	}

	public virtual object Clone()
	{
		CarData clone = (CarData)MemberwiseClone();
		clone.Create();
		return clone;
	}
}
