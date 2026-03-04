using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SeasonalDistributorProductsData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Productidx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Productlevel { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public bool Isselling { get { int o = __p.__offset(8); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public bool Isupgradeopen { get { int o = __p.__offset(10); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static SeasonalDistributorProductsData GetRootAsSeasonalDistributorProductsData(ByteBuffer _bb)
		{
			return GetRootAsSeasonalDistributorProductsData(_bb, new SeasonalDistributorProductsData());
		}

		public static SeasonalDistributorProductsData GetRootAsSeasonalDistributorProductsData(ByteBuffer _bb, SeasonalDistributorProductsData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public SeasonalDistributorProductsData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateProductidx(int productidx)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, productidx);
				return true;
			}
			return false;
		}

		public bool MutateProductlevel(int productlevel)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, productlevel);
				return true;
			}
			return false;
		}

		public bool MutateIsselling(bool isselling)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(isselling ? 1 : 0));
				return true;
			}
			return false;
		}

		public bool MutateIsupgradeopen(bool isupgradeopen)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(isupgradeopen ? 1 : 0));
				return true;
			}
			return false;
		}

		public static Offset<SeasonalDistributorProductsData> CreateSeasonalDistributorProductsData(FlatBufferBuilder builder, int productidx = 0, int productlevel = 0, bool isselling = false, bool isupgradeopen = false)
		{
			builder.StartTable(4);
			AddIsupgradeopen(builder, isupgradeopen);
			AddIsselling(builder, isselling);
			AddProductlevel(builder, productlevel);
			AddProductidx(builder, productidx);
			return EndSeasonalDistributorProductsData(builder);
		}

		public static void StartSeasonalDistributorProductsData(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		public static void AddProductidx(FlatBufferBuilder builder, int productidx)
		{
			builder.AddInt(0, productidx, 0);
		}

		public static void AddProductlevel(FlatBufferBuilder builder, int productlevel)
		{
			builder.AddInt(1, productlevel, 0);
		}

		public static void AddIsselling(FlatBufferBuilder builder, bool isselling)
		{
			builder.AddBool(2, isselling, false);
		}

		public static void AddIsupgradeopen(FlatBufferBuilder builder, bool isupgradeopen)
		{
			builder.AddBool(3, isupgradeopen, false);
		}

		public static Offset<SeasonalDistributorProductsData> EndSeasonalDistributorProductsData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<SeasonalDistributorProductsData>(o);
		}

		public SeasonalDistributorProductsDataT UnPack()
		{
			var _o = new SeasonalDistributorProductsDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(SeasonalDistributorProductsDataT _o)
		{
			_o.Productidx = this.Productidx;
			_o.Productlevel = this.Productlevel;
			_o.Isselling = this.Isselling;
			_o.Isupgradeopen = this.Isupgradeopen;
		}

		public static Offset<SeasonalDistributorProductsData> Pack(FlatBufferBuilder builder, SeasonalDistributorProductsDataT _o)
		{
			if (_o == null) return default(Offset<SeasonalDistributorProductsData>);
			StartSeasonalDistributorProductsData(builder);
			AddProductidx(builder, _o.Productidx);
			AddProductlevel(builder, _o.Productlevel);
			AddIsselling(builder, _o.Isselling);
			AddIsupgradeopen(builder, _o.Isupgradeopen);
			return EndSeasonalDistributorProductsData(builder);
		}
	}
}
