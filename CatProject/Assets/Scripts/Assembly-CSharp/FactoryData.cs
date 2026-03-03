using System;
using System.Collections.Generic;
using UniRx;

public class FactoryData : IClientData
{
	public Dictionary<int, FactoryItemData> FactoryItems;

	public Dictionary<int, FactoryAdsItemData> FactoryAdsItems;

	public List<FactoryBuildingData> Factoris;

	public List<FactoryOrderSlotData> OrderSlots;

	public IReactiveProperty<int> OrderSlotAdCount;

	public DateTime OrderSlotAdTime;

	public IReactiveProperty<int> DailyOrderFreeRefreshCount;

	public DateTime DailyOrderFreeRefreshResetTime;
}
