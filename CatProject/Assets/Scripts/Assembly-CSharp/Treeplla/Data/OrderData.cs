using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct OrderData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Estimatedcoin => 0;

		public int Ordersystemstate => 0;

		public int Autoorderstate => 0;

		public int OwnedorderdataLength => 0;

		public OrderInfo? Deliveryorderdata => null;

		public OrderInfo? Autoorderdata => null;

		public long Endtime => 0L;

		public long Autoorderendtime => 0L;

		public static void ValidateVersion()
		{
		}

		public static OrderData GetRootAsOrderData(ByteBuffer _bb)
		{
			return default(OrderData);
		}

		public static OrderData GetRootAsOrderData(ByteBuffer _bb, OrderData obj)
		{
			return default(OrderData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public OrderData __assign(int _i, ByteBuffer _bb)
		{
			return default(OrderData);
		}

		public bool MutateEstimatedcoin(int estimatedcoin)
		{
			return false;
		}

		public bool MutateOrdersystemstate(int ordersystemstate)
		{
			return false;
		}

		public bool MutateAutoorderstate(int autoorderstate)
		{
			return false;
		}

		public OrderInfo? Ownedorderdata(int j)
		{
			return null;
		}

		public bool MutateEndtime(long endtime)
		{
			return false;
		}

		public bool MutateAutoorderendtime(long autoorderendtime)
		{
			return false;
		}

		public static Offset<OrderData> CreateOrderData(FlatBufferBuilder builder, int estimatedcoin = 0, int ordersystemstate = 0, int autoorderstate = 0, VectorOffset ownedorderdataOffset = default(VectorOffset), Offset<OrderInfo> deliveryorderdataOffset = default(Offset<OrderInfo>), Offset<OrderInfo> autoorderdataOffset = default(Offset<OrderInfo>), long endtime = 0L, long autoorderendtime = 0L)
		{
			return default(Offset<OrderData>);
		}

		public static void StartOrderData(FlatBufferBuilder builder)
		{
		}

		public static void AddEstimatedcoin(FlatBufferBuilder builder, int estimatedcoin)
		{
		}

		public static void AddOrdersystemstate(FlatBufferBuilder builder, int ordersystemstate)
		{
		}

		public static void AddAutoorderstate(FlatBufferBuilder builder, int autoorderstate)
		{
		}

		public static void AddOwnedorderdata(FlatBufferBuilder builder, VectorOffset ownedorderdataOffset)
		{
		}

		public static VectorOffset CreateOwnedorderdataVector(FlatBufferBuilder builder, Offset<OrderInfo>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateOwnedorderdataVectorBlock(FlatBufferBuilder builder, Offset<OrderInfo>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateOwnedorderdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<OrderInfo>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateOwnedorderdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartOwnedorderdataVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddDeliveryorderdata(FlatBufferBuilder builder, Offset<OrderInfo> deliveryorderdataOffset)
		{
		}

		public static void AddAutoorderdata(FlatBufferBuilder builder, Offset<OrderInfo> autoorderdataOffset)
		{
		}

		public static void AddEndtime(FlatBufferBuilder builder, long endtime)
		{
		}

		public static void AddAutoorderendtime(FlatBufferBuilder builder, long autoorderendtime)
		{
		}

		public static Offset<OrderData> EndOrderData(FlatBufferBuilder builder)
		{
			return default(Offset<OrderData>);
		}

		public OrderDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(OrderDataT _o)
		{
		}

		public static Offset<OrderData> Pack(FlatBufferBuilder builder, OrderDataT _o)
		{
			return default(Offset<OrderData>);
		}
	}
}
