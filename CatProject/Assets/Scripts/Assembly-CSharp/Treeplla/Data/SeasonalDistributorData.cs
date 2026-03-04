using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SeasonalDistributorData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Sellingproductidx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static SeasonalDistributorData GetRootAsSeasonalDistributorData(ByteBuffer _bb)
		{
			return GetRootAsSeasonalDistributorData(_bb, new SeasonalDistributorData());
		}

		public static SeasonalDistributorData GetRootAsSeasonalDistributorData(ByteBuffer _bb, SeasonalDistributorData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public SeasonalDistributorData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateSellingproductidx(int sellingproductidx)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, sellingproductidx);
				return true;
			}
			return false;
		}

		public static Offset<SeasonalDistributorData> CreateSeasonalDistributorData(FlatBufferBuilder builder, int sellingproductidx = 0)
		{
			builder.StartTable(1);
			AddSellingproductidx(builder, sellingproductidx);
			return EndSeasonalDistributorData(builder);
		}

		public static void StartSeasonalDistributorData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		public static void AddSellingproductidx(FlatBufferBuilder builder, int sellingproductidx)
		{
			builder.AddInt(0, sellingproductidx, 0);
		}

		public static Offset<SeasonalDistributorData> EndSeasonalDistributorData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<SeasonalDistributorData>(o);
		}

		public SeasonalDistributorDataT UnPack()
		{
			var _o = new SeasonalDistributorDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(SeasonalDistributorDataT _o)
		{
			_o.Sellingproductidx = this.Sellingproductidx;
		}

		public static Offset<SeasonalDistributorData> Pack(FlatBufferBuilder builder, SeasonalDistributorDataT _o)
		{
			if (_o == null) return default(Offset<SeasonalDistributorData>);
			StartSeasonalDistributorData(builder);
			AddSellingproductidx(builder, _o.Sellingproductidx);
			return EndSeasonalDistributorData(builder);
		}
	}
}
