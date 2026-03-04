using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct FactoryData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int BuildingsLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int ItemsLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int OrderslotsLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }

		public long Orderadstime { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public int Orderadscount { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int ItemadsLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int Dailyorderfreerefreshcount { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public long Dailyorderfreerefreshresettime { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static FactoryData GetRootAsFactoryData(ByteBuffer _bb)
		{
			return GetRootAsFactoryData(_bb, new FactoryData());
		}

		public static FactoryData GetRootAsFactoryData(ByteBuffer _bb, FactoryData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public FactoryData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public FactoryBuilding? Buildings(int j)
		{
			int o = __p.__offset(4);
			return o != 0 ? (new FactoryBuilding()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public FactoryItem? Items(int j)
		{
			int o = __p.__offset(6);
			return o != 0 ? (new FactoryItem()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public FactoryOrderSlot? Orderslots(int j)
		{
			int o = __p.__offset(8);
			return o != 0 ? (new FactoryOrderSlot()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public bool MutateOrderadstime(long orderadstime)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, orderadstime);
				return true;
			}
			return false;
		}

		public bool MutateOrderadscount(int orderadscount)
		{
			int o = __p.__offset(12);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, orderadscount);
				return true;
			}
			return false;
		}

		public FactoryAdsItem? Itemads(int j)
		{
			int o = __p.__offset(14);
			return o != 0 ? (new FactoryAdsItem()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public bool MutateDailyorderfreerefreshcount(int dailyorderfreerefreshcount)
		{
			int o = __p.__offset(16);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, dailyorderfreerefreshcount);
				return true;
			}
			return false;
		}

		public bool MutateDailyorderfreerefreshresettime(long dailyorderfreerefreshresettime)
		{
			int o = __p.__offset(18);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, dailyorderfreerefreshresettime);
				return true;
			}
			return false;
		}

		public static Offset<FactoryData> CreateFactoryData(FlatBufferBuilder builder, VectorOffset buildingsOffset = default(VectorOffset), VectorOffset itemsOffset = default(VectorOffset), VectorOffset orderslotsOffset = default(VectorOffset), long orderadstime = 0L, int orderadscount = 0, VectorOffset itemadsOffset = default(VectorOffset), int dailyorderfreerefreshcount = 0, long dailyorderfreerefreshresettime = 0L)
		{
			builder.StartTable(8);
			AddDailyorderfreerefreshresettime(builder, dailyorderfreerefreshresettime);
			AddDailyorderfreerefreshcount(builder, dailyorderfreerefreshcount);
			AddItemads(builder, itemadsOffset);
			AddOrderadscount(builder, orderadscount);
			AddOrderadstime(builder, orderadstime);
			AddOrderslots(builder, orderslotsOffset);
			AddItems(builder, itemsOffset);
			AddBuildings(builder, buildingsOffset);
			return EndFactoryData(builder);
		}

		public static void StartFactoryData(FlatBufferBuilder builder)
		{
			builder.StartTable(12);
		}

		public static void AddBuildings(FlatBufferBuilder builder, VectorOffset buildingsOffset)
		{
			builder.AddOffset(0, buildingsOffset.Value, 0);
		}

		public static VectorOffset CreateBuildingsVector(FlatBufferBuilder builder, Offset<FactoryBuilding>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateBuildingsVectorBlock(FlatBufferBuilder builder, Offset<FactoryBuilding>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateBuildingsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<FactoryBuilding>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateBuildingsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartBuildingsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(1, itemsOffset.Value, 0);
		}

		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FactoryItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, Offset<FactoryItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<FactoryItem>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddOrderslots(FlatBufferBuilder builder, VectorOffset orderslotsOffset)
		{
			builder.AddOffset(2, orderslotsOffset.Value, 0);
		}

		public static VectorOffset CreateOrderslotsVector(FlatBufferBuilder builder, Offset<FactoryOrderSlot>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateOrderslotsVectorBlock(FlatBufferBuilder builder, Offset<FactoryOrderSlot>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateOrderslotsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<FactoryOrderSlot>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateOrderslotsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartOrderslotsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddOrderadstime(FlatBufferBuilder builder, long orderadstime)
		{
			builder.AddLong(3, orderadstime, 0);
		}

		public static void AddOrderadscount(FlatBufferBuilder builder, int orderadscount)
		{
			builder.AddInt(4, orderadscount, 0);
		}

		public static void AddItemads(FlatBufferBuilder builder, VectorOffset itemadsOffset)
		{
			builder.AddOffset(5, itemadsOffset.Value, 0);
		}

		public static VectorOffset CreateItemadsVector(FlatBufferBuilder builder, Offset<FactoryAdsItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateItemadsVectorBlock(FlatBufferBuilder builder, Offset<FactoryAdsItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateItemadsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<FactoryAdsItem>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateItemadsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartItemadsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddDailyorderfreerefreshcount(FlatBufferBuilder builder, int dailyorderfreerefreshcount)
		{
			builder.AddInt(6, dailyorderfreerefreshcount, 0);
		}

		public static void AddDailyorderfreerefreshresettime(FlatBufferBuilder builder, long dailyorderfreerefreshresettime)
		{
			builder.AddLong(7, dailyorderfreerefreshresettime, 0);
		}

		public static Offset<FactoryData> EndFactoryData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<FactoryData>(o);
		}

		public FactoryDataT UnPack()
		{
			var _o = new FactoryDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(FactoryDataT _o)
		{
			_o.Buildings = new List<FactoryBuildingT>();
			for (var _j = 0; _j < this.BuildingsLength; ++_j)
				_o.Buildings.Add(this.Buildings(_j).HasValue ? this.Buildings(_j).Value.UnPack() : null);
			_o.Items = new List<FactoryItemT>();
			for (var _j = 0; _j < this.ItemsLength; ++_j)
				_o.Items.Add(this.Items(_j).HasValue ? this.Items(_j).Value.UnPack() : null);
			_o.Orderslots = new List<FactoryOrderSlotT>();
			for (var _j = 0; _j < this.OrderslotsLength; ++_j)
				_o.Orderslots.Add(this.Orderslots(_j).HasValue ? this.Orderslots(_j).Value.UnPack() : null);
			_o.Orderadstime = this.Orderadstime;
			_o.Orderadscount = this.Orderadscount;
			_o.Itemads = new List<FactoryAdsItemT>();
			for (var _j = 0; _j < this.ItemadsLength; ++_j)
				_o.Itemads.Add(this.Itemads(_j).HasValue ? this.Itemads(_j).Value.UnPack() : null);
			_o.Dailyorderfreerefreshcount = this.Dailyorderfreerefreshcount;
			_o.Dailyorderfreerefreshresettime = this.Dailyorderfreerefreshresettime;
		}

		public static Offset<FactoryData> Pack(FlatBufferBuilder builder, FactoryDataT _o)
		{
			if (_o == null) return default(Offset<FactoryData>);
			var _buildings = default(VectorOffset);
			if (_o.Buildings != null)
			{
				var __buildings = new Offset<FactoryBuilding>[_o.Buildings.Count];
				for (var _j = 0; _j < _o.Buildings.Count; ++_j)
					__buildings[_j] = FactoryBuilding.Pack(builder, _o.Buildings[_j]);
				_buildings = CreateBuildingsVector(builder, __buildings);
			}
			var _items = default(VectorOffset);
			if (_o.Items != null)
			{
				var __items = new Offset<FactoryItem>[_o.Items.Count];
				for (var _j = 0; _j < _o.Items.Count; ++_j)
					__items[_j] = FactoryItem.Pack(builder, _o.Items[_j]);
				_items = CreateItemsVector(builder, __items);
			}
			var _orderslots = default(VectorOffset);
			if (_o.Orderslots != null)
			{
				var __orderslots = new Offset<FactoryOrderSlot>[_o.Orderslots.Count];
				for (var _j = 0; _j < _o.Orderslots.Count; ++_j)
					__orderslots[_j] = FactoryOrderSlot.Pack(builder, _o.Orderslots[_j]);
				_orderslots = CreateOrderslotsVector(builder, __orderslots);
			}
			var _itemads = default(VectorOffset);
			if (_o.Itemads != null)
			{
				var __itemads = new Offset<FactoryAdsItem>[_o.Itemads.Count];
				for (var _j = 0; _j < _o.Itemads.Count; ++_j)
					__itemads[_j] = FactoryAdsItem.Pack(builder, _o.Itemads[_j]);
				_itemads = CreateItemadsVector(builder, __itemads);
			}
			StartFactoryData(builder);
			AddBuildings(builder, _buildings);
			AddItems(builder, _items);
			AddOrderslots(builder, _orderslots);
			AddOrderadstime(builder, _o.Orderadstime);
			AddOrderadscount(builder, _o.Orderadscount);
			AddItemads(builder, _itemads);
			AddDailyorderfreerefreshcount(builder, _o.Dailyorderfreerefreshcount);
			AddDailyorderfreerefreshresettime(builder, _o.Dailyorderfreerefreshresettime);
			return EndFactoryData(builder);
		}
	}
}
