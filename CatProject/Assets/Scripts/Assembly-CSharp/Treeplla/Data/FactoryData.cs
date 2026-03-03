using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct FactoryData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int BuildingsLength => 0;

		public int ItemsLength => 0;

		public int OrderslotsLength => 0;

		public long Orderadstime => 0L;

		public int Orderadscount => 0;

		public int ItemadsLength => 0;

		public int Dailyorderfreerefreshcount => 0;

		public long Dailyorderfreerefreshresettime => 0L;

		public static void ValidateVersion()
		{
		}

		public static FactoryData GetRootAsFactoryData(ByteBuffer _bb)
		{
			return default(FactoryData);
		}

		public static FactoryData GetRootAsFactoryData(ByteBuffer _bb, FactoryData obj)
		{
			return default(FactoryData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public FactoryData __assign(int _i, ByteBuffer _bb)
		{
			return default(FactoryData);
		}

		public FactoryBuilding? Buildings(int j)
		{
			return null;
		}

		public FactoryItem? Items(int j)
		{
			return null;
		}

		public FactoryOrderSlot? Orderslots(int j)
		{
			return null;
		}

		public bool MutateOrderadstime(long orderadstime)
		{
			return false;
		}

		public bool MutateOrderadscount(int orderadscount)
		{
			return false;
		}

		public FactoryAdsItem? Itemads(int j)
		{
			return null;
		}

		public bool MutateDailyorderfreerefreshcount(int dailyorderfreerefreshcount)
		{
			return false;
		}

		public bool MutateDailyorderfreerefreshresettime(long dailyorderfreerefreshresettime)
		{
			return false;
		}

		public static Offset<FactoryData> CreateFactoryData(FlatBufferBuilder builder, VectorOffset buildingsOffset = default(VectorOffset), VectorOffset itemsOffset = default(VectorOffset), VectorOffset orderslotsOffset = default(VectorOffset), long orderadstime = 0L, int orderadscount = 0, VectorOffset itemadsOffset = default(VectorOffset), int dailyorderfreerefreshcount = 0, long dailyorderfreerefreshresettime = 0L)
		{
			return default(Offset<FactoryData>);
		}

		public static void StartFactoryData(FlatBufferBuilder builder)
		{
		}

		public static void AddBuildings(FlatBufferBuilder builder, VectorOffset buildingsOffset)
		{
		}

		public static VectorOffset CreateBuildingsVector(FlatBufferBuilder builder, Offset<FactoryBuilding>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateBuildingsVectorBlock(FlatBufferBuilder builder, Offset<FactoryBuilding>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateBuildingsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<FactoryBuilding>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateBuildingsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartBuildingsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
		}

		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FactoryItem>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, Offset<FactoryItem>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<FactoryItem>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddOrderslots(FlatBufferBuilder builder, VectorOffset orderslotsOffset)
		{
		}

		public static VectorOffset CreateOrderslotsVector(FlatBufferBuilder builder, Offset<FactoryOrderSlot>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateOrderslotsVectorBlock(FlatBufferBuilder builder, Offset<FactoryOrderSlot>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateOrderslotsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<FactoryOrderSlot>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateOrderslotsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartOrderslotsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddOrderadstime(FlatBufferBuilder builder, long orderadstime)
		{
		}

		public static void AddOrderadscount(FlatBufferBuilder builder, int orderadscount)
		{
		}

		public static void AddItemads(FlatBufferBuilder builder, VectorOffset itemadsOffset)
		{
		}

		public static VectorOffset CreateItemadsVector(FlatBufferBuilder builder, Offset<FactoryAdsItem>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateItemadsVectorBlock(FlatBufferBuilder builder, Offset<FactoryAdsItem>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateItemadsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<FactoryAdsItem>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateItemadsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartItemadsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddDailyorderfreerefreshcount(FlatBufferBuilder builder, int dailyorderfreerefreshcount)
		{
		}

		public static void AddDailyorderfreerefreshresettime(FlatBufferBuilder builder, long dailyorderfreerefreshresettime)
		{
		}

		public static Offset<FactoryData> EndFactoryData(FlatBufferBuilder builder)
		{
			return default(Offset<FactoryData>);
		}

		public FactoryDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(FactoryDataT _o)
		{
		}

		public static Offset<FactoryData> Pack(FlatBufferBuilder builder, FactoryDataT _o)
		{
			return default(Offset<FactoryData>);
		}
	}
}
