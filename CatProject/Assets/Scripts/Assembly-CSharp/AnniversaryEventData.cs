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
		// Deactivate
	}

	public static AnniversaryEventData FromFlatBuffer(Treeplla.Data.AnniversaryEventData? eventDataPtr)
	{
		if (!eventDataPtr.HasValue) return null;
		var d = eventDataPtr.Value;
		var result = new AnniversaryEventData();
		return result;
	}

	public static Offset<Treeplla.Data.AnniversaryEventData> ToFlatBuffer(AnniversaryEventData source, FlatBufferBuilder builder)
	{
		return default(Offset<Treeplla.Data.AnniversaryEventData>);
	}

	private static VectorOffset CreateEventShopDataFlatBufferVector(AnniversaryEventData source, FlatBufferBuilder builder)
	{
		return default(VectorOffset);
	}
}
