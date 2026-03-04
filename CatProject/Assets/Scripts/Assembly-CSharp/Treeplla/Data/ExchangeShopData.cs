using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct ExchangeShopData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Itemidx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Itembuycount { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static ExchangeShopData GetRootAsExchangeShopData(ByteBuffer _bb)
		{
			return GetRootAsExchangeShopData(_bb, new ExchangeShopData());
		}

		public static ExchangeShopData GetRootAsExchangeShopData(ByteBuffer _bb, ExchangeShopData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public ExchangeShopData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateItemidx(int itemidx)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, itemidx);
				return true;
			}
			return false;
		}

		public bool MutateItembuycount(int itembuycount)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, itembuycount);
				return true;
			}
			return false;
		}

		public static Offset<ExchangeShopData> CreateExchangeShopData(FlatBufferBuilder builder, int itemidx = 0, int itembuycount = 0)
		{
			builder.StartTable(2);
			AddItembuycount(builder, itembuycount);
			AddItemidx(builder, itemidx);
			return EndExchangeShopData(builder);
		}

		public static void StartExchangeShopData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		public static void AddItemidx(FlatBufferBuilder builder, int itemidx)
		{
			builder.AddInt(0, itemidx, 0);
		}

		public static void AddItembuycount(FlatBufferBuilder builder, int itembuycount)
		{
			builder.AddInt(1, itembuycount, 0);
		}

		public static Offset<ExchangeShopData> EndExchangeShopData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<ExchangeShopData>(o);
		}

		public ExchangeShopDataT UnPack()
		{
			var _o = new ExchangeShopDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(ExchangeShopDataT _o)
		{
			_o.Itemidx = this.Itemidx;
			_o.Itembuycount = this.Itembuycount;
		}

		public static Offset<ExchangeShopData> Pack(FlatBufferBuilder builder, ExchangeShopDataT _o)
		{
			if (_o == null) return default(Offset<ExchangeShopData>);
			StartExchangeShopData(builder);
			AddItemidx(builder, _o.Itemidx);
			AddItembuycount(builder, _o.Itembuycount);
			return EndExchangeShopData(builder);
		}
	}
}
