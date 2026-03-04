using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct RouletteData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public long Nextspintime { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public int Luckydrawcount { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public bool Havefreespin { get { int o = __p.__offset(8); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static RouletteData GetRootAsRouletteData(ByteBuffer _bb)
		{
			return GetRootAsRouletteData(_bb, new RouletteData());
		}

		public static RouletteData GetRootAsRouletteData(ByteBuffer _bb, RouletteData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public RouletteData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateNextspintime(long nextspintime)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, nextspintime);
				return true;
			}
			return false;
		}

		public bool MutateLuckydrawcount(int luckydrawcount)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, luckydrawcount);
				return true;
			}
			return false;
		}

		public bool MutateHavefreespin(bool havefreespin)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(havefreespin ? 1 : 0));
				return true;
			}
			return false;
		}

		public static Offset<RouletteData> CreateRouletteData(FlatBufferBuilder builder, long nextspintime = 0L, int luckydrawcount = 0, bool havefreespin = true)
		{
			builder.StartTable(3);
			AddHavefreespin(builder, havefreespin);
			AddLuckydrawcount(builder, luckydrawcount);
			AddNextspintime(builder, nextspintime);
			return EndRouletteData(builder);
		}

		public static void StartRouletteData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		public static void AddNextspintime(FlatBufferBuilder builder, long nextspintime)
		{
			builder.AddLong(0, nextspintime, 0);
		}

		public static void AddLuckydrawcount(FlatBufferBuilder builder, int luckydrawcount)
		{
			builder.AddInt(1, luckydrawcount, 0);
		}

		public static void AddHavefreespin(FlatBufferBuilder builder, bool havefreespin)
		{
			builder.AddBool(2, havefreespin, false);
		}

		public static Offset<RouletteData> EndRouletteData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<RouletteData>(o);
		}

		public RouletteDataT UnPack()
		{
			var _o = new RouletteDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(RouletteDataT _o)
		{
			_o.Nextspintime = this.Nextspintime;
			_o.Luckydrawcount = this.Luckydrawcount;
			_o.Havefreespin = this.Havefreespin;
		}

		public static Offset<RouletteData> Pack(FlatBufferBuilder builder, RouletteDataT _o)
		{
			if (_o == null) return default(Offset<RouletteData>);
			StartRouletteData(builder);
			AddNextspintime(builder, _o.Nextspintime);
			AddLuckydrawcount(builder, _o.Luckydrawcount);
			AddHavefreespin(builder, _o.Havefreespin);
			return EndRouletteData(builder);
		}
	}
}
