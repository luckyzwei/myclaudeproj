using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct RichAchieveCount : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Regionidx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Count { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static RichAchieveCount GetRootAsRichAchieveCount(ByteBuffer _bb)
		{
			return GetRootAsRichAchieveCount(_bb, new RichAchieveCount());
		}

		public static RichAchieveCount GetRootAsRichAchieveCount(ByteBuffer _bb, RichAchieveCount obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public RichAchieveCount __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateRegionidx(int regionidx)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, regionidx);
				return true;
			}
			return false;
		}

		public bool MutateCount(int count)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, count);
				return true;
			}
			return false;
		}

		public static Offset<RichAchieveCount> CreateRichAchieveCount(FlatBufferBuilder builder, int regionidx = 0, int count = 0)
		{
			builder.StartTable(2);
			AddCount(builder, count);
			AddRegionidx(builder, regionidx);
			return EndRichAchieveCount(builder);
		}

		public static void StartRichAchieveCount(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		public static void AddRegionidx(FlatBufferBuilder builder, int regionidx)
		{
			builder.AddInt(0, regionidx, 0);
		}

		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(1, count, 0);
		}

		public static Offset<RichAchieveCount> EndRichAchieveCount(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<RichAchieveCount>(o);
		}

		public RichAchieveCountT UnPack()
		{
			var _o = new RichAchieveCountT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(RichAchieveCountT _o)
		{
			_o.Regionidx = this.Regionidx;
			_o.Count = this.Count;
		}

		public static Offset<RichAchieveCount> Pack(FlatBufferBuilder builder, RichAchieveCountT _o)
		{
			if (_o == null) return default(Offset<RichAchieveCount>);
			StartRichAchieveCount(builder);
			AddRegionidx(builder, _o.Regionidx);
			AddCount(builder, _o.Count);
			return EndRichAchieveCount(builder);
		}
	}
}
