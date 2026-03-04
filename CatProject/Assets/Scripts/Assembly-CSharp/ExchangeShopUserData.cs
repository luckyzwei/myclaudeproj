using Google.FlatBuffers;
using Treeplla.Data;

public class ExchangeShopUserData
{
	public int ItemIdx { get; private set; }

	public int ItemBuyCount { get; private set; }

	public ExchangeShopUserData(int itemIdx, int itemBuyCount)
	{
		ItemIdx = itemIdx;
		ItemBuyCount = itemBuyCount;
	}

	public void AddItemBuyCount(int buyCount)
	{
	}

	public static ExchangeShopUserData FromFlatBuffer(ExchangeShopData data)
	{
		var result = (ExchangeShopUserData)new ExchangeShopUserData(0, 0).MemberwiseClone();
		return result;
	}

	public static Offset<ExchangeShopData> ToFlatBuffer(FlatBufferBuilder builder, ExchangeShopUserData userData)
	{
		return default(Offset<ExchangeShopData>);
	}
}
