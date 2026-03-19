using System.Collections.Generic;
using Google.FlatBuffers;
using Treeplla.Data;
using UniRx;

public class AnniversaryEventData
{
	public int AnniversaryYear;

	public bool ShownGuide;

	public IReactiveProperty<int> AnniversaryCoin;

	public IReactiveProperty<int> AnniversaryRouletteTicket;

	public int RouletteMultipleIndex;

	public IReactiveProperty<int> RoulettePlayCount;

	public IReactiveProperty<int> ReceivedPlayBonusCount;

	public Dictionary<int, int> EventShopItemBuyCountMap;

	public void Reset()
	{
		AnniversaryYear = 0;
		ShownGuide = false;
		if (AnniversaryCoin != null) AnniversaryCoin.Value = 0;
		if (AnniversaryRouletteTicket != null) AnniversaryRouletteTicket.Value = 0;
		RouletteMultipleIndex = 0;
		if (RoulettePlayCount != null) RoulettePlayCount.Value = 0;
		if (ReceivedPlayBonusCount != null) ReceivedPlayBonusCount.Value = 0;
		if (EventShopItemBuyCountMap != null) EventShopItemBuyCountMap.Clear();
	}

	public static AnniversaryEventData FromFlatBuffer(Treeplla.Data.AnniversaryEventData? eventDataPtr)
	{
		if (!eventDataPtr.HasValue) return null;
		var d = eventDataPtr.Value;
		var result = new AnniversaryEventData();
		result.AnniversaryYear = d.Anniversaryyear;
		result.ShownGuide = d.Shownguide;
		result.AnniversaryCoin = new ReactiveProperty<int>(d.Anniversarycoin);
		result.AnniversaryRouletteTicket = new ReactiveProperty<int>(d.Anniversaryrouletteticket);
		result.RouletteMultipleIndex = d.Roulettemultipleindex;
		result.RoulettePlayCount = new ReactiveProperty<int>(d.Roulettplaycount);
		result.ReceivedPlayBonusCount = new ReactiveProperty<int>(d.Receivedplaybonuscount);
		result.EventShopItemBuyCountMap = new Dictionary<int, int>();
		for (int i = 0; i < d.EventshopdataLength; i++)
		{
			var shopData = d.Eventshopdata(i);
			if (shopData.HasValue)
			{
				result.EventShopItemBuyCountMap[shopData.Value.Itemidx] = shopData.Value.Itembuycount;
			}
		}
		return result;
	}

	public static Offset<Treeplla.Data.AnniversaryEventData> ToFlatBuffer(AnniversaryEventData source, FlatBufferBuilder builder)
	{
		if (source == null) return default(Offset<Treeplla.Data.AnniversaryEventData>);
		var shopVectorOffset = CreateEventShopDataFlatBufferVector(source, builder);
		return Treeplla.Data.AnniversaryEventData.CreateAnniversaryEventData(
			builder,
			source.AnniversaryYear,
			source.ShownGuide,
			source.AnniversaryCoin != null ? source.AnniversaryCoin.Value : 0,
			source.AnniversaryRouletteTicket != null ? source.AnniversaryRouletteTicket.Value : 0,
			source.RouletteMultipleIndex,
			source.RoulettePlayCount != null ? source.RoulettePlayCount.Value : 0,
			source.ReceivedPlayBonusCount != null ? source.ReceivedPlayBonusCount.Value : 0,
			shopVectorOffset
		);
	}

	private static VectorOffset CreateEventShopDataFlatBufferVector(AnniversaryEventData source, FlatBufferBuilder builder)
	{
		if (source == null || source.EventShopItemBuyCountMap == null || source.EventShopItemBuyCountMap.Count == 0)
			return default(VectorOffset);
		var offsets = new Offset<AnniversaryEventShopData>[source.EventShopItemBuyCountMap.Count];
		int i = 0;
		foreach (var kvp in source.EventShopItemBuyCountMap)
		{
			offsets[i++] = AnniversaryEventShopData.CreateAnniversaryEventShopData(builder, kvp.Key, kvp.Value);
		}
		return builder.CreateVectorOfTables(offsets);
	}
}
