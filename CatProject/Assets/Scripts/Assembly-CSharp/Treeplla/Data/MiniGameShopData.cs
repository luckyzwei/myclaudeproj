using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct MiniGameShopData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Eventidx => 0;

		public AdsFreeViewData? Adsfreeitemdata => null;

		public int ExchangeitemdataLength => 0;

		public int Scheduleidx => 0;

		public static void ValidateVersion()
		{
		}

		public static MiniGameShopData GetRootAsMiniGameShopData(ByteBuffer _bb)
		{
			return default(MiniGameShopData);
		}

		public static MiniGameShopData GetRootAsMiniGameShopData(ByteBuffer _bb, MiniGameShopData obj)
		{
			return default(MiniGameShopData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public MiniGameShopData __assign(int _i, ByteBuffer _bb)
		{
			return default(MiniGameShopData);
		}

		public bool MutateEventidx(int eventidx)
		{
			return false;
		}

		public ExchangeShopData? Exchangeitemdata(int j)
		{
			return null;
		}

		public bool MutateScheduleidx(int scheduleidx)
		{
			return false;
		}

		public static Offset<MiniGameShopData> CreateMiniGameShopData(FlatBufferBuilder builder, int eventidx = 0, Offset<AdsFreeViewData> adsfreeitemdataOffset = default(Offset<AdsFreeViewData>), VectorOffset exchangeitemdataOffset = default(VectorOffset), int scheduleidx = 0)
		{
			return default(Offset<MiniGameShopData>);
		}

		public static void StartMiniGameShopData(FlatBufferBuilder builder)
		{
		}

		public static void AddEventidx(FlatBufferBuilder builder, int eventidx)
		{
		}

		public static void AddAdsfreeitemdata(FlatBufferBuilder builder, Offset<AdsFreeViewData> adsfreeitemdataOffset)
		{
		}

		public static void AddExchangeitemdata(FlatBufferBuilder builder, VectorOffset exchangeitemdataOffset)
		{
		}

		public static VectorOffset CreateExchangeitemdataVector(FlatBufferBuilder builder, Offset<ExchangeShopData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateExchangeitemdataVectorBlock(FlatBufferBuilder builder, Offset<ExchangeShopData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateExchangeitemdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ExchangeShopData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateExchangeitemdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartExchangeitemdataVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddScheduleidx(FlatBufferBuilder builder, int scheduleidx)
		{
		}

		public static Offset<MiniGameShopData> EndMiniGameShopData(FlatBufferBuilder builder)
		{
			return default(Offset<MiniGameShopData>);
		}

		public MiniGameShopDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(MiniGameShopDataT _o)
		{
		}

		public static Offset<MiniGameShopData> Pack(FlatBufferBuilder builder, MiniGameShopDataT _o)
		{
			return default(Offset<MiniGameShopData>);
		}
	}
}
