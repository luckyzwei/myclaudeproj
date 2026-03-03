using Google.FlatBuffers;
using Treeplla.Data;

public class ExchangeShopUserData
{
	public int ItemIdx { get; private set; }

	public int ItemBuyCount { get; private set; }

	public ExchangeShopUserData(int itemIdx, int itemBuyCount)
	{
	}

	public void AddItemBuyCount(int buyCount)
	{
	}

	public static ExchangeShopUserData FromFlatBuffer(ExchangeShopData data)
	{
		return null;
	}

	public static Offset<ExchangeShopData> ToFlatBuffer(FlatBufferBuilder builder, ExchangeShopUserData userData)
	{
		return default(Offset<ExchangeShopData>);
	}
}
