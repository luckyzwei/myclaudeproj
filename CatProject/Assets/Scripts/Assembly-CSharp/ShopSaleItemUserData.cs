using System;
using System.Collections.Generic;
using Google.FlatBuffers;
using Treeplla.Data;

public class ShopSaleItemUserData
{
	public int ItemIdx;

	public int SaleListIdx;

	public DateTime StartTime;

	public DateTime EndTime;

	public DateTime ResetTime;

	public Config.E_ShopSaleItemResetType ResetType;

	private ShopSaleItemUserData() { }

	public ShopSaleItemUserData(int itemIdx)
	{
		ItemIdx = itemIdx;
	}

	public static ShopSaleItemUserData FromFlatBuffer(KeyValueLong data)
	{
		var result = new ShopSaleItemUserData();
		return result;
	}

	public static VectorOffset ToFlatBufferVector(FlatBufferBuilder builder, Dictionary<int, ShopSaleItemUserData> data)
	{
		return default(VectorOffset);
	}

	private static Offset<KeyValueLong> ToFlatBuffer(FlatBufferBuilder builder, ShopSaleItemUserData data)
	{
		return default(Offset<KeyValueLong>);
	}
}
