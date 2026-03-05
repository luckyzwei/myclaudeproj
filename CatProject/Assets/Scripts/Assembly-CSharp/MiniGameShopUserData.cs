using System.Collections.Generic;
using Google.FlatBuffers;
using Treeplla.Data;

public class MiniGameShopUserData
{
	public int ScheduleIdx { get; private set; }

	public int EventIdx { get; private set; }

	public AdsViewUserData AdsFreeItemData { get; private set; }

	public List<ExchangeShopUserData> ExchangeItemDataList { get; private set; }

	private MiniGameShopUserData() { }

	public MiniGameShopUserData(int scheduleIdx, int eventIdx)
	{
		ScheduleIdx = scheduleIdx;
		EventIdx = eventIdx;
	}

	public static MiniGameShopUserData MakeDefaultData(int scheduleIdx, int eventIdx)
	{
		var data = new MiniGameShopUserData(scheduleIdx, eventIdx);
		data.ExchangeItemDataList = new List<ExchangeShopUserData>();
		return data;
	}

	public static MiniGameShopUserData FromFlatBuffer(MiniGameShopData data)
	{
		var result = new MiniGameShopUserData();
		result.ExchangeItemDataList = new List<ExchangeShopUserData>();
		return result;
	}

	public static Offset<MiniGameShopData> ToFlatBuffer(FlatBufferBuilder builder, MiniGameShopUserData userData)
	{
		if (userData == null) return default(Offset<MiniGameShopData>);
		return default(Offset<MiniGameShopData>);
	}
}
