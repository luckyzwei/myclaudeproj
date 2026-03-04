using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct MiniGameShopData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Eventidx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public AdsFreeViewData? Adsfreeitemdata { get { int o = __p.__offset(6); return o != 0 ? (new AdsFreeViewData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public int ExchangeitemdataLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int Scheduleidx { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static MiniGameShopData GetRootAsMiniGameShopData(ByteBuffer _bb)
		{
			return GetRootAsMiniGameShopData(_bb, new MiniGameShopData());
		}

		public static MiniGameShopData GetRootAsMiniGameShopData(ByteBuffer _bb, MiniGameShopData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public MiniGameShopData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateEventidx(int eventidx)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, eventidx);
				return true;
			}
			return false;
		}

		public ExchangeShopData? Exchangeitemdata(int j)
		{
			int o = __p.__offset(8);
			return o != 0 ? (new ExchangeShopData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public bool MutateScheduleidx(int scheduleidx)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, scheduleidx);
				return true;
			}
			return false;
		}

		public static Offset<MiniGameShopData> CreateMiniGameShopData(FlatBufferBuilder builder, int eventidx = 0, Offset<AdsFreeViewData> adsfreeitemdataOffset = default(Offset<AdsFreeViewData>), VectorOffset exchangeitemdataOffset = default(VectorOffset), int scheduleidx = 0)
		{
			builder.StartTable(4);
			AddScheduleidx(builder, scheduleidx);
			AddExchangeitemdata(builder, exchangeitemdataOffset);
			AddAdsfreeitemdata(builder, adsfreeitemdataOffset);
			AddEventidx(builder, eventidx);
			return EndMiniGameShopData(builder);
		}

		public static void StartMiniGameShopData(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		public static void AddEventidx(FlatBufferBuilder builder, int eventidx)
		{
			builder.AddInt(0, eventidx, 0);
		}

		public static void AddAdsfreeitemdata(FlatBufferBuilder builder, Offset<AdsFreeViewData> adsfreeitemdataOffset)
		{
			builder.AddOffset(1, adsfreeitemdataOffset.Value, 0);
		}

		public static void AddExchangeitemdata(FlatBufferBuilder builder, VectorOffset exchangeitemdataOffset)
		{
			builder.AddOffset(2, exchangeitemdataOffset.Value, 0);
		}

		public static VectorOffset CreateExchangeitemdataVector(FlatBufferBuilder builder, Offset<ExchangeShopData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateExchangeitemdataVectorBlock(FlatBufferBuilder builder, Offset<ExchangeShopData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateExchangeitemdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ExchangeShopData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateExchangeitemdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartExchangeitemdataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddScheduleidx(FlatBufferBuilder builder, int scheduleidx)
		{
			builder.AddInt(3, scheduleidx, 0);
		}

		public static Offset<MiniGameShopData> EndMiniGameShopData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<MiniGameShopData>(o);
		}

		public MiniGameShopDataT UnPack()
		{
			var _o = new MiniGameShopDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(MiniGameShopDataT _o)
		{
			_o.Eventidx = this.Eventidx;
			_o.Adsfreeitemdata = this.Adsfreeitemdata.HasValue ? this.Adsfreeitemdata.Value.UnPack() : null;
			_o.Exchangeitemdata = new List<ExchangeShopDataT>();
			for (var _j = 0; _j < this.ExchangeitemdataLength; ++_j)
				_o.Exchangeitemdata.Add(this.Exchangeitemdata(_j).HasValue ? this.Exchangeitemdata(_j).Value.UnPack() : null);
			_o.Scheduleidx = this.Scheduleidx;
		}

		public static Offset<MiniGameShopData> Pack(FlatBufferBuilder builder, MiniGameShopDataT _o)
		{
			if (_o == null) return default(Offset<MiniGameShopData>);
			var _adsfreeitemdata = _o.Adsfreeitemdata == null ? default(Offset<AdsFreeViewData>) : AdsFreeViewData.Pack(builder, _o.Adsfreeitemdata);
			var _exchangeitemdata = default(VectorOffset);
			if (_o.Exchangeitemdata != null)
			{
				var __exchangeitemdata = new Offset<ExchangeShopData>[_o.Exchangeitemdata.Count];
				for (var _j = 0; _j < _o.Exchangeitemdata.Count; ++_j)
					__exchangeitemdata[_j] = ExchangeShopData.Pack(builder, _o.Exchangeitemdata[_j]);
				_exchangeitemdata = CreateExchangeitemdataVector(builder, __exchangeitemdata);
			}
			StartMiniGameShopData(builder);
			AddEventidx(builder, _o.Eventidx);
			AddAdsfreeitemdata(builder, _adsfreeitemdata);
			AddExchangeitemdata(builder, _exchangeitemdata);
			AddScheduleidx(builder, _o.Scheduleidx);
			return EndMiniGameShopData(builder);
		}
	}
}
