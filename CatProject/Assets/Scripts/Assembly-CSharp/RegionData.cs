using System.Collections.Generic;

public class RegionData : IClientData
{
	public StageData StageData;

	public int EquipCar;

	public List<BuyParkingLotData> BuyParkingLotData;

	public OfflineData OfflineData { get; set; }

	public RichWayData RichWayData { get; set; }
}
