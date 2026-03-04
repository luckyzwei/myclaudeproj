using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct FactoryAdsItem : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Idx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public long Resettime { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public int Count { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static FactoryAdsItem GetRootAsFactoryAdsItem(ByteBuffer _bb)
		{
			return GetRootAsFactoryAdsItem(_bb, new FactoryAdsItem());
		}

		public static FactoryAdsItem GetRootAsFactoryAdsItem(ByteBuffer _bb, FactoryAdsItem obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public FactoryAdsItem __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateIdx(int idx)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, idx);
				return true;
			}
			return false;
		}

		public bool MutateResettime(long resettime)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, resettime);
				return true;
			}
			return false;
		}

		public bool MutateCount(int count)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, count);
				return true;
			}
			return false;
		}

		public static Offset<FactoryAdsItem> CreateFactoryAdsItem(FlatBufferBuilder builder, int idx = 0, long resettime = 0L, int count = 0)
		{
			builder.StartTable(3);
			AddCount(builder, count);
			AddResettime(builder, resettime);
			AddIdx(builder, idx);
			return EndFactoryAdsItem(builder);
		}

		public static void StartFactoryAdsItem(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
			builder.AddInt(0, idx, 0);
		}

		public static void AddResettime(FlatBufferBuilder builder, long resettime)
		{
			builder.AddLong(1, resettime, 0);
		}

		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(2, count, 0);
		}

		public static Offset<FactoryAdsItem> EndFactoryAdsItem(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<FactoryAdsItem>(o);
		}

		public FactoryAdsItemT UnPack()
		{
			var _o = new FactoryAdsItemT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(FactoryAdsItemT _o)
		{
			_o.Idx = this.Idx;
			_o.Resettime = this.Resettime;
			_o.Count = this.Count;
		}

		public static Offset<FactoryAdsItem> Pack(FlatBufferBuilder builder, FactoryAdsItemT _o)
		{
			if (_o == null) return default(Offset<FactoryAdsItem>);
			StartFactoryAdsItem(builder);
			AddIdx(builder, _o.Idx);
			AddResettime(builder, _o.Resettime);
			AddCount(builder, _o.Count);
			return EndFactoryAdsItem(builder);
		}
	}
}
