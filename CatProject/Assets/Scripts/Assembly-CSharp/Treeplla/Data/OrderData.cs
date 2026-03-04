using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct OrderData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Estimatedcoin { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Ordersystemstate { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Autoorderstate { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int OwnedorderdataLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }

		public OrderInfo? Deliveryorderdata { get { int o = __p.__offset(12); return o != 0 ? (new OrderInfo()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public OrderInfo? Autoorderdata { get { int o = __p.__offset(14); return o != 0 ? (new OrderInfo()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public long Endtime { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public long Autoorderendtime { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static OrderData GetRootAsOrderData(ByteBuffer _bb)
		{
			return GetRootAsOrderData(_bb, new OrderData());
		}

		public static OrderData GetRootAsOrderData(ByteBuffer _bb, OrderData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public OrderData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateEstimatedcoin(int estimatedcoin)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, estimatedcoin);
				return true;
			}
			return false;
		}

		public bool MutateOrdersystemstate(int ordersystemstate)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, ordersystemstate);
				return true;
			}
			return false;
		}

		public bool MutateAutoorderstate(int autoorderstate)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, autoorderstate);
				return true;
			}
			return false;
		}

		public OrderInfo? Ownedorderdata(int j)
		{
			int o = __p.__offset(10);
			return o != 0 ? (new OrderInfo()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public bool MutateEndtime(long endtime)
		{
			int o = __p.__offset(16);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, endtime);
				return true;
			}
			return false;
		}

		public bool MutateAutoorderendtime(long autoorderendtime)
		{
			int o = __p.__offset(18);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, autoorderendtime);
				return true;
			}
			return false;
		}

		public static Offset<OrderData> CreateOrderData(FlatBufferBuilder builder, int estimatedcoin = 0, int ordersystemstate = 0, int autoorderstate = 0, VectorOffset ownedorderdataOffset = default(VectorOffset), Offset<OrderInfo> deliveryorderdataOffset = default(Offset<OrderInfo>), Offset<OrderInfo> autoorderdataOffset = default(Offset<OrderInfo>), long endtime = 0L, long autoorderendtime = 0L)
		{
			builder.StartTable(8);
			AddAutoorderendtime(builder, autoorderendtime);
			AddEndtime(builder, endtime);
			AddAutoorderdata(builder, autoorderdataOffset);
			AddDeliveryorderdata(builder, deliveryorderdataOffset);
			AddOwnedorderdata(builder, ownedorderdataOffset);
			AddAutoorderstate(builder, autoorderstate);
			AddOrdersystemstate(builder, ordersystemstate);
			AddEstimatedcoin(builder, estimatedcoin);
			return EndOrderData(builder);
		}

		public static void StartOrderData(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		public static void AddEstimatedcoin(FlatBufferBuilder builder, int estimatedcoin)
		{
			builder.AddInt(0, estimatedcoin, 0);
		}

		public static void AddOrdersystemstate(FlatBufferBuilder builder, int ordersystemstate)
		{
			builder.AddInt(1, ordersystemstate, 0);
		}

		public static void AddAutoorderstate(FlatBufferBuilder builder, int autoorderstate)
		{
			builder.AddInt(2, autoorderstate, 0);
		}

		public static void AddOwnedorderdata(FlatBufferBuilder builder, VectorOffset ownedorderdataOffset)
		{
			builder.AddOffset(3, ownedorderdataOffset.Value, 0);
		}

		public static VectorOffset CreateOwnedorderdataVector(FlatBufferBuilder builder, Offset<OrderInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateOwnedorderdataVectorBlock(FlatBufferBuilder builder, Offset<OrderInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateOwnedorderdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<OrderInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateOwnedorderdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartOwnedorderdataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddDeliveryorderdata(FlatBufferBuilder builder, Offset<OrderInfo> deliveryorderdataOffset)
		{
			builder.AddOffset(4, deliveryorderdataOffset.Value, 0);
		}

		public static void AddAutoorderdata(FlatBufferBuilder builder, Offset<OrderInfo> autoorderdataOffset)
		{
			builder.AddOffset(5, autoorderdataOffset.Value, 0);
		}

		public static void AddEndtime(FlatBufferBuilder builder, long endtime)
		{
			builder.AddLong(6, endtime, 0);
		}

		public static void AddAutoorderendtime(FlatBufferBuilder builder, long autoorderendtime)
		{
			builder.AddLong(7, autoorderendtime, 0);
		}

		public static Offset<OrderData> EndOrderData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<OrderData>(o);
		}

		public OrderDataT UnPack()
		{
			var _o = new OrderDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(OrderDataT _o)
		{
			_o.Estimatedcoin = this.Estimatedcoin;
			_o.Ordersystemstate = this.Ordersystemstate;
			_o.Autoorderstate = this.Autoorderstate;
			_o.Ownedorderdata = new List<OrderInfoT>();
			for (var _j = 0; _j < this.OwnedorderdataLength; ++_j)
				_o.Ownedorderdata.Add(this.Ownedorderdata(_j).HasValue ? this.Ownedorderdata(_j).Value.UnPack() : null);
			_o.Deliveryorderdata = this.Deliveryorderdata.HasValue ? this.Deliveryorderdata.Value.UnPack() : null;
			_o.Autoorderdata = this.Autoorderdata.HasValue ? this.Autoorderdata.Value.UnPack() : null;
			_o.Endtime = this.Endtime;
			_o.Autoorderendtime = this.Autoorderendtime;
		}

		public static Offset<OrderData> Pack(FlatBufferBuilder builder, OrderDataT _o)
		{
			if (_o == null) return default(Offset<OrderData>);
			var _ownedorderdata = default(VectorOffset);
			if (_o.Ownedorderdata != null)
			{
				var __ownedorderdata = new Offset<OrderInfo>[_o.Ownedorderdata.Count];
				for (var _j = 0; _j < _o.Ownedorderdata.Count; ++_j)
					__ownedorderdata[_j] = OrderInfo.Pack(builder, _o.Ownedorderdata[_j]);
				_ownedorderdata = CreateOwnedorderdataVector(builder, __ownedorderdata);
			}
			var _deliveryorderdata = _o.Deliveryorderdata == null ? default(Offset<OrderInfo>) : OrderInfo.Pack(builder, _o.Deliveryorderdata);
			var _autoorderdata = _o.Autoorderdata == null ? default(Offset<OrderInfo>) : OrderInfo.Pack(builder, _o.Autoorderdata);
			StartOrderData(builder);
			AddEstimatedcoin(builder, _o.Estimatedcoin);
			AddOrdersystemstate(builder, _o.Ordersystemstate);
			AddAutoorderstate(builder, _o.Autoorderstate);
			AddOwnedorderdata(builder, _ownedorderdata);
			AddDeliveryorderdata(builder, _deliveryorderdata);
			AddAutoorderdata(builder, _autoorderdata);
			AddEndtime(builder, _o.Endtime);
			AddAutoorderendtime(builder, _o.Autoorderendtime);
			return EndOrderData(builder);
		}
	}
}
