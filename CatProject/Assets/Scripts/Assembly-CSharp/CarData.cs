using System;

public class CarData : IReadOnlyData, ICloneable
{
	public int Idx;

	public int ParkingZone;

	public int ParkingSpace;

	public int GetRegion()
	{
		// Region is derived from car index range
		return Idx / 1000;
	}

	public int GetBrandIdx()
	{
		// Brand is derived from car index
		return Idx % 1000;
	}

	public bool IsSpecial()
	{
		return Idx >= 90000;
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
