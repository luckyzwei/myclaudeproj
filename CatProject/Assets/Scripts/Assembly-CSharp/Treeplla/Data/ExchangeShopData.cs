using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct ExchangeShopData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Itemidx => 0;

		public int Itembuycount => 0;

		public static void ValidateVersion()
		{
		}

		public static ExchangeShopData GetRootAsExchangeShopData(ByteBuffer _bb)
		{
			return default(ExchangeShopData);
		}

		public static ExchangeShopData GetRootAsExchangeShopData(ByteBuffer _bb, ExchangeShopData obj)
		{
			return default(ExchangeShopData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public ExchangeShopData __assign(int _i, ByteBuffer _bb)
		{
			return default(ExchangeShopData);
		}

		public bool MutateItemidx(int itemidx)
		{
			return false;
		}

		public bool MutateItembuycount(int itembuycount)
		{
			return false;
		}

		public static Offset<ExchangeShopData> CreateExchangeShopData(FlatBufferBuilder builder, int itemidx = 0, int itembuycount = 0)
		{
			return default(Offset<ExchangeShopData>);
		}

		public static void StartExchangeShopData(FlatBufferBuilder builder)
		{
		}

		public static void AddItemidx(FlatBufferBuilder builder, int itemidx)
		{
		}

		public static void AddItembuycount(FlatBufferBuilder builder, int itembuycount)
		{
		}

		public static Offset<ExchangeShopData> EndExchangeShopData(FlatBufferBuilder builder)
		{
			return default(Offset<ExchangeShopData>);
		}

		public ExchangeShopDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(ExchangeShopDataT _o)
		{
		}

		public static Offset<ExchangeShopData> Pack(FlatBufferBuilder builder, ExchangeShopDataT _o)
		{
			return default(Offset<ExchangeShopData>);
		}
	}
}
