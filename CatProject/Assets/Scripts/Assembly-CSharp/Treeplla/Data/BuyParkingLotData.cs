using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct BuyParkingLotData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Buyparkinglotidx => 0;

		public int BuyparkinglotitemsLength => 0;

		public static void ValidateVersion()
		{
		}

		public static BuyParkingLotData GetRootAsBuyParkingLotData(ByteBuffer _bb)
		{
			return default(BuyParkingLotData);
		}

		public static BuyParkingLotData GetRootAsBuyParkingLotData(ByteBuffer _bb, BuyParkingLotData obj)
		{
			return default(BuyParkingLotData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public BuyParkingLotData __assign(int _i, ByteBuffer _bb)
		{
			return default(BuyParkingLotData);
		}

		public bool MutateBuyparkinglotidx(int buyparkinglotidx)
		{
			return false;
		}

		public BuyParkingLotItem? Buyparkinglotitems(int j)
		{
			return null;
		}

		public static Offset<BuyParkingLotData> CreateBuyParkingLotData(FlatBufferBuilder builder, int buyparkinglotidx = 0, VectorOffset buyparkinglotitemsOffset = default(VectorOffset))
		{
			return default(Offset<BuyParkingLotData>);
		}

		public static void StartBuyParkingLotData(FlatBufferBuilder builder)
		{
		}

		public static void AddBuyparkinglotidx(FlatBufferBuilder builder, int buyparkinglotidx)
		{
		}

		public static void AddBuyparkinglotitems(FlatBufferBuilder builder, VectorOffset buyparkinglotitemsOffset)
		{
		}

		public static VectorOffset CreateBuyparkinglotitemsVector(FlatBufferBuilder builder, Offset<BuyParkingLotItem>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateBuyparkinglotitemsVectorBlock(FlatBufferBuilder builder, Offset<BuyParkingLotItem>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateBuyparkinglotitemsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<BuyParkingLotItem>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateBuyparkinglotitemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartBuyparkinglotitemsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static Offset<BuyParkingLotData> EndBuyParkingLotData(FlatBufferBuilder builder)
		{
			return default(Offset<BuyParkingLotData>);
		}

		public BuyParkingLotDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(BuyParkingLotDataT _o)
		{
		}

		public static Offset<BuyParkingLotData> Pack(FlatBufferBuilder builder, BuyParkingLotDataT _o)
		{
			return default(Offset<BuyParkingLotData>);
		}
	}
}
