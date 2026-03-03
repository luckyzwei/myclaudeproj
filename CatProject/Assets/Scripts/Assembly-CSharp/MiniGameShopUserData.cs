using System.Collections.Generic;
using Google.FlatBuffers;
using Treeplla.Data;

public class MiniGameShopUserData
{
	public int ScheduleIdx { get; private set; }

	public int EventIdx { get; private set; }

	public AdsViewUserData AdsFreeItemData { get; private set; }

	public List<ExchangeShopUserData> ExchangeItemDataList { get; private set; }

	public MiniGameShopUserData(int scheduleIdx, int eventIdx)
	{
	}

	public static MiniGameShopUserData MakeDefaultData(int scheduleIdx, int eventIdx)
	{
		return null;
	}

	public static MiniGameShopUserData FromFlatBuffer(MiniGameShopData data)
	{
		return null;
	}

	public static Offset<MiniGameShopData> ToFlatBuffer(FlatBufferBuilder builder, MiniGameShopUserData userData)
	{
		return default(Offset<MiniGameShopData>);
	}
}
