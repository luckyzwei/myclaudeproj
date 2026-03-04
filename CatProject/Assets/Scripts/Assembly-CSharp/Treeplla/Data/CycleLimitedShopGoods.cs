using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct CycleLimitedShopGoods : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Shopgoodsidx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public long Nextresettime { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public int Buycount { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static CycleLimitedShopGoods GetRootAsCycleLimitedShopGoods(ByteBuffer _bb)
		{
			return GetRootAsCycleLimitedShopGoods(_bb, new CycleLimitedShopGoods());
		}

		public static CycleLimitedShopGoods GetRootAsCycleLimitedShopGoods(ByteBuffer _bb, CycleLimitedShopGoods obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public CycleLimitedShopGoods __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateShopgoodsidx(int shopgoodsidx)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, shopgoodsidx);
				return true;
			}
			return false;
		}

		public bool MutateNextresettime(long nextresettime)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, nextresettime);
				return true;
			}
			return false;
		}

		public bool MutateBuycount(int buycount)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, buycount);
				return true;
			}
			return false;
		}

		public static Offset<CycleLimitedShopGoods> CreateCycleLimitedShopGoods(FlatBufferBuilder builder, int shopgoodsidx = 0, long nextresettime = 0L, int buycount = 0)
		{
			builder.StartTable(3);
			AddBuycount(builder, buycount);
			AddNextresettime(builder, nextresettime);
			AddShopgoodsidx(builder, shopgoodsidx);
			return EndCycleLimitedShopGoods(builder);
		}

		public static void StartCycleLimitedShopGoods(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		public static void AddShopgoodsidx(FlatBufferBuilder builder, int shopgoodsidx)
		{
			builder.AddInt(0, shopgoodsidx, 0);
		}

		public static void AddNextresettime(FlatBufferBuilder builder, long nextresettime)
		{
			builder.AddLong(1, nextresettime, 0);
		}

		public static void AddBuycount(FlatBufferBuilder builder, int buycount)
		{
			builder.AddInt(2, buycount, 0);
		}

		public static Offset<CycleLimitedShopGoods> EndCycleLimitedShopGoods(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<CycleLimitedShopGoods>(o);
		}

		public CycleLimitedShopGoodsT UnPack()
		{
			var _o = new CycleLimitedShopGoodsT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(CycleLimitedShopGoodsT _o)
		{
			_o.Shopgoodsidx = this.Shopgoodsidx;
			_o.Nextresettime = this.Nextresettime;
			_o.Buycount = this.Buycount;
		}

		public static Offset<CycleLimitedShopGoods> Pack(FlatBufferBuilder builder, CycleLimitedShopGoodsT _o)
		{
			if (_o == null) return default(Offset<CycleLimitedShopGoods>);
			StartCycleLimitedShopGoods(builder);
			AddShopgoodsidx(builder, _o.Shopgoodsidx);
			AddNextresettime(builder, _o.Nextresettime);
			AddBuycount(builder, _o.Buycount);
			return EndCycleLimitedShopGoods(builder);
		}
	}
}
