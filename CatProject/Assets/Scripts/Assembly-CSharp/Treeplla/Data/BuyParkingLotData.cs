using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct BuyParkingLotData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Buyparkinglotidx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int BuyparkinglotitemsLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static BuyParkingLotData GetRootAsBuyParkingLotData(ByteBuffer _bb)
		{
			return GetRootAsBuyParkingLotData(_bb, new BuyParkingLotData());
		}

		public static BuyParkingLotData GetRootAsBuyParkingLotData(ByteBuffer _bb, BuyParkingLotData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public BuyParkingLotData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateBuyparkinglotidx(int buyparkinglotidx)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, buyparkinglotidx);
				return true;
			}
			return false;
		}

		public BuyParkingLotItem? Buyparkinglotitems(int j)
		{
			int o = __p.__offset(6);
			return o != 0 ? (new BuyParkingLotItem()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public static Offset<BuyParkingLotData> CreateBuyParkingLotData(FlatBufferBuilder builder, int buyparkinglotidx = 0, VectorOffset buyparkinglotitemsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			AddBuyparkinglotitems(builder, buyparkinglotitemsOffset);
			AddBuyparkinglotidx(builder, buyparkinglotidx);
			return EndBuyParkingLotData(builder);
		}

		public static void StartBuyParkingLotData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		public static void AddBuyparkinglotidx(FlatBufferBuilder builder, int buyparkinglotidx)
		{
			builder.AddInt(0, buyparkinglotidx, 0);
		}

		public static void AddBuyparkinglotitems(FlatBufferBuilder builder, VectorOffset buyparkinglotitemsOffset)
		{
			builder.AddOffset(1, buyparkinglotitemsOffset.Value, 0);
		}

		public static VectorOffset CreateBuyparkinglotitemsVector(FlatBufferBuilder builder, Offset<BuyParkingLotItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateBuyparkinglotitemsVectorBlock(FlatBufferBuilder builder, Offset<BuyParkingLotItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateBuyparkinglotitemsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<BuyParkingLotItem>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateBuyparkinglotitemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartBuyparkinglotitemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static Offset<BuyParkingLotData> EndBuyParkingLotData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<BuyParkingLotData>(o);
		}

		public BuyParkingLotDataT UnPack()
		{
			var _o = new BuyParkingLotDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(BuyParkingLotDataT _o)
		{
			_o.Buyparkinglotidx = this.Buyparkinglotidx;
			_o.Buyparkinglotitems = new List<BuyParkingLotItemT>();
			for (var _j = 0; _j < this.BuyparkinglotitemsLength; ++_j)
				_o.Buyparkinglotitems.Add(this.Buyparkinglotitems(_j).HasValue ? this.Buyparkinglotitems(_j).Value.UnPack() : null);
		}

		public static Offset<BuyParkingLotData> Pack(FlatBufferBuilder builder, BuyParkingLotDataT _o)
		{
			if (_o == null) return default(Offset<BuyParkingLotData>);
			var _buyparkinglotitems = default(VectorOffset);
			if (_o.Buyparkinglotitems != null)
			{
				var __buyparkinglotitems = new Offset<BuyParkingLotItem>[_o.Buyparkinglotitems.Count];
				for (var _j = 0; _j < _o.Buyparkinglotitems.Count; ++_j)
					__buyparkinglotitems[_j] = BuyParkingLotItem.Pack(builder, _o.Buyparkinglotitems[_j]);
				_buyparkinglotitems = CreateBuyparkinglotitemsVector(builder, __buyparkinglotitems);
			}
			StartBuyParkingLotData(builder);
			AddBuyparkinglotidx(builder, _o.Buyparkinglotidx);
			AddBuyparkinglotitems(builder, _buyparkinglotitems);
			return EndBuyParkingLotData(builder);
		}
	}
}
