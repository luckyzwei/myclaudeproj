using System.Collections.Generic;
using UniRx;

public class WorldmapData : IClientData
{
	public List<int> ZoneList;

	public IReactiveCollection<int> BuildingList;

	public List<BuildingData> BuildingData;

	public IReactiveCollection<CarData> CarData;

	public List<int> ParkingLotData;
}
