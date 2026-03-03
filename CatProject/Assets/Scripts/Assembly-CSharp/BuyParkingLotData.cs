using System.Collections.Generic;

public class BuyParkingLotData : IClientData
{
	public int ParkingZone;

	public Dictionary<int, bool> ParkingSpace;

	public bool IsOpen()
	{
		return false;
	}
}
